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
        public string id_Eliminar;
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
            var listRegistro = (from c in db.Cabinas
                from i in db.Empleados.Where(n => n.IdEmpleado == c.IdEmpleadoNavigation.IdEmpleado)
                select new
                {
                    c.IdCabina,
                    c.Correo,
                    c.Direccion,
                    i.Nombre
                });
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = listRegistro.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCabina_Load(object sender, EventArgs e)
        {
            actualizardgv();
        }

        private void dgvRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poc = dgvRegistro.CurrentRow.Index;////obteniendo el valor de la final para despues ubicar la columna
            id_Eliminar = dgvRegistro[0,poc].Value.ToString();///ubicando valor de columna e igualando a una variable tipo string
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar la solicitud?", "Registro UCA", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                int id_Delete = Convert.ToInt32(id_Eliminar);
                var db = new vacunacionDBContext();
                ///Buscando el id en la tabla solicitud
                Cabina Deleteregistro = db.Cabinas.Find(id_Delete);
                ///Eliminando datos
                db.Cabinas.Remove(Deleteregistro);
                ///actualizando cambios
                db.SaveChanges();
                actualizardgv();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }
    }
}