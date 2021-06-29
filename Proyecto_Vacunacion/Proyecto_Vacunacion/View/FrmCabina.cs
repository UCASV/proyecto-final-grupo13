using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Vacunacion
{
    public partial class FrmCabina : Form
    {
        public FrmCabina()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string direccion = txtdireccion.Text;
            string correo = txtcorreo.Text;
            int telefono = Convert.ToInt32(nudtelefono.Value);
            int encargado = Convert.ToInt32(nudencargado.Value);
            var db = new vacunacionDBContext();
            var ValidacionEmpleado = db.Empleados.FirstOrDefault(x => x.IdEmpleado == encargado );
            if (direccion.Length!=0 && correo.Length!=0 && telefono >20000000 && telefono<79999999 && encargado>0 )
            {
                if (ValidacionEmpleado != null)
                {
                    Cabina nCabina = new Cabina();
                    nCabina.Direccion = direccion;
                    nCabina.Telefono = telefono;
                    nCabina.Correo = correo;
                    nCabina.IdEmpleado = encargado;
                    db.Add(nCabina);
                    db.SaveChanges();
                    MessageBox.Show("Agregado exitosamente!");
                }
                else
                {
                    MessageBox.Show("El encargado de cabina no existe!", "Vacunacion COVID19",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en los datos!", "Vacunacion COVID19",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizardgv()
        {
            var db = new vacunacionDBContext();
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = db.Cabinas.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}