using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Proyecto_Vacunacion.VacunacionContext;

namespace Proyecto_Vacunacion
{
    public partial class FrmProcesoVacunacion : Form
    {
        
        public FrmProcesoVacunacion()
        {
            InitializeComponent();
        }

        public string id_eliminar;
        private void FrmProcesoVacunacion_Load(object sender, EventArgs e)
        {
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            cargarTabla();
            
        }

        

        public void cargarTabla()
        {
            
            var db = new vacunacionDBContext();

            var listRegistro = (from c in db.ProcesoVacunacions
                from i in db.Empleados.Where(n => n.IdEmpleado == c.IdEmpleadoNavigation.IdEmpleado)
                from e in db.Ciudadanos.Where(n => n.Dui == c.DuiCiudadanoNavigation.Dui)
                select new
                {
                    c.IdProceso,
                    c.FechaHora,
                    e.Dui,
                    i.IdEmpleado,
                });
            dgvProceso.DataSource = null;
            dgvProceso.DataSource = listRegistro.ToList();
        }

        public void Agregar()
        {
            var db = new vacunacionDBContext();
            
            
            var fecha = dtpFecha.Value;
            var dui = Int32.Parse(txtDUI.Text.Trim());
            var id = Int32.Parse(txtIdEmpleado.Text.Trim());

            if (txtDUI.Text.Length <= 9 && dui != 0)
            {
                //Insertando datos

                ProcesoVacunacion proceso = new ProcesoVacunacion();

                
                proceso.FechaHora = fecha;
                proceso.DuiCiudadano = dui;
                proceso.IdEmpleado = id;


                db.Add(proceso);
                db.SaveChanges();
                MessageBox.Show("Agregado exitosamente!", "Ciudadano", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectamente", "Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Agregar();
            cargarTabla();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar la solicitud?", "Registro UCA", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                int id_Delete = Convert.ToInt32(id_eliminar);
                var db = new vacunacionDBContext();
                ///Buscando el id en la tabla solicitud
                ProcesoVacunacion proceso = db.ProcesoVacunacions.Find(id_Delete);
                ///Eliminando datos
                db.ProcesoVacunacions.Remove(proceso);
                ///actualizando cambios
                db.SaveChanges();
                cargarTabla();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dgvProceso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poc = dgvProceso.CurrentRow.Index;////obteniendo el valor de la final para despues ubicar la columna
            id_eliminar = dgvProceso[0,poc].Value.ToString();///ubicando valor de columna e igualando a una variable tipo string
           
            
        }
    }
}