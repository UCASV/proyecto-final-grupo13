using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Proyecto_Vacunacion.VacunacionContext;

namespace Proyecto_Vacunacion
{
    public partial class FrmRegistroEmpleado : Form
    {
        public FrmRegistroEmpleado()
        {
            InitializeComponent();
        }

        public string id_Eliminar;
        private void dgvFacultad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poc = dgvRegistro.CurrentRow.Index;////obteniendo el valor de la final para despues ubicar la columna
            id_Eliminar = dgvRegistro[0,poc].Value.ToString();///ubicando valor de columna e igualando a una variable tipo string
            nudCabina.Text=dgvRegistro[3,poc].Value.ToString();
            dateEntrada.Text=dgvRegistro[1,poc].Value.ToString();
        }

        private void actualizardvg()
        {
            /*
            var db = new vacunacionDBContext();
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = db.RegistroEmpleados.ToList();*/
            var db = new vacunacionDBContext();

            var listRegistro = (from c in db.RegistroEmpleados
                from i in db.Cabinas.Where(n => n.IdCabina == c.IdCabinaNavigation.IdCabina)
                from e in db.Empleados.Where(e => e.IdEmpleado == c.IdEmpleadoNavigation.IdEmpleado)
                select new
                {
                    c.IdRegistro,
                    c.Fecha,
                    e.Nombre,
                    c.IdCabina
                });
            /*
              var filtro = listCruz
                .Where(r => r.Dui.Equals(ciudadano.Dui))  ////Para filtrar en un usuario o registro especifico
                .ToList();
              
             */
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = listRegistro.ToList();
           }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar la solicitud?", "Registro UCA", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                int id_Delete = Convert.ToInt32(id_Eliminar);
                var db = new vacunacionDBContext();
                ///Buscando el id en la tabla solicitud
                RegistroEmpleado Deleteregistro = db.RegistroEmpleados.Find(id_Delete);
                ///Eliminando datos
                db.RegistroEmpleados.Remove(Deleteregistro);
                ///actualizando cambios
                db.SaveChanges();
                actualizardvg();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void FrmRegistroEmpleado_Load(object sender, EventArgs e)
        {
            actualizardvg();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var db = new vacunacionDBContext();
            DateTime fecha = dateEntrada.Value;
            int updcabina = Convert.ToInt32(nudCabina.Value);
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea modificar la facultad?", "Registro UCA", MessageBoxButtons.YesNo);
            var CabinExist = db.Cabinas.FirstOrDefault(x => x.IdCabina == updcabina);
            if (CabinExist!=null)
            {
                if (dialogResult == DialogResult.Yes)
                {
                    int id_Delete = Convert.ToInt32(id_Eliminar);

                    var UPDregistro = db.RegistroEmpleados.FirstOrDefault(x => x.IdRegistro == id_Delete);
                    UPDregistro.Fecha = fecha;
                    UPDregistro.IdCabina = updcabina;
                    ////guardando en el registro para editar
                    db.SaveChanges();
                    MessageBox.Show("Se a modificado registro!");
                    actualizardvg();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
                MessageBox.Show("Cabina no existe!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}