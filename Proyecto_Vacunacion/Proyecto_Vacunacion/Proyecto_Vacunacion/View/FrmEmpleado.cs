using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Vacunacion.VacunacionContext;

namespace Proyecto_Vacunacion
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            var db = new vacunacionDBContext();
            List<TipoEmpleado> tipoEmpleados = db.TipoEmpleados.ToList();
            cmbIdEmpleado.DataSource = tipoEmpleados;
            cmbIdEmpleado.DisplayMember = "tipo";
            cmbIdEmpleado.ValueMember = "IdTipoEmpleado";
        }
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////Obteniendo valores del combobox
            TipoEmpleado mref = (TipoEmpleado)cmbIdEmpleado.SelectedItem;
            ///////abriendo conexion
            var db = new vacunacionDBContext();
            //////Buscando en la base de datos el id del combobox sea igual al de la base de datos
            TipoEmpleado mbdd = db.Set<TipoEmpleado>().
                SingleOrDefault(m => m.IdTipoEmpleado == mref.IdTipoEmpleado);
            //////llamando al constructor
            Empleado empleador = new Empleado();
            empleador.Nombre = txtNombre.Text;
            empleador.Contrasenia = txtContra.Text;
            empleador.CorreoInstitucional = txtCorreo.Text;
            empleador.Direccion = txtDireccion.Text;
            empleador.IdTipoEmpleadoNavigation = mbdd;
            ///////Almacenando en la base de datos
            db.Add(empleador);
            db.SaveChanges();
            //////Mostrando el carnet
            var UltimoId = db.Set<Empleado>().OrderByDescending(t => t.IdEmpleado).ToList().FirstOrDefault();
            MessageBox.Show("Agregado exitosamente y su carnet es: "+UltimoId.IdEmpleado);
            this.Hide();
        }


        
    }
}