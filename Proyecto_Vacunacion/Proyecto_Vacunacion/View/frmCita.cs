using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.Devices;


namespace Proyecto_Vacunacion
{
    public partial class frmCita : Form
    {
        public frmCita()
        {
            InitializeComponent();
        }
        
        private void frmCita_Load(object sender, EventArgs e)
        {
            //Validando fecha
            
            dtpFecha.MinDate = DateTime.Today.AddDays(10);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            cargartabla();
        }

        public void cargartabla()
        {
            
            var db = new vacunacionDBContext();

            var listCita = (from c in db.Cita
                from i in db.Ciudadanos.Where(n => n.Dui == c.DuiCiudadanoNavigation.Dui)
                from e in db.Empleados.Where(e => e.IdEmpleado == c.IdEmpleadoNavigation.IdEmpleado)
                select new
                {
                    c.IdCita,
                    c.Fecha,
                    c.TipoVacuna,
                    i.Dui,
                    e.IdEmpleado,
                    e.Nombre
                });

            dgvCita.DataSource = null;
            dgvCita.DataSource = listCita.ToList();
        }

        public void ingresar()
        {
            var db = new vacunacionDBContext();

            var fecha = dtpFecha.Value;
            bool dosis = false;
            var id = Int32.Parse(txtEmpleado.Text.Trim());
            var dui = Int32.Parse(txtDui.Text.Trim());

            if (rbSegunda.Checked)
                dosis = true;

            //validando datos

            if (txtDui.Text.Length <= 9 && dui != 0)
            {
                //Insertando datos

                Citum cita = new Citum();

                cita.Fecha = fecha; 
                cita.TipoVacuna = dosis;
                cita.IdEmpleado = id;
                cita.DuiCiudadano = dui;
                 
                db.Add(cita);
                db.SaveChanges();
                MessageBox.Show("Agregado exitosamente!", "Ciudadano", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectamente", "Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        

        public void modificar()
        {
            var db = new vacunacionDBContext();
            
            var ci = Int32.Parse(txtCita.Text.Trim());
            var fecha = dtpFecha.Value;
            bool dosis = false;
            var empleado = Int32.Parse(txtEmpleado.Text.Trim());
            var dui = Int32.Parse(txtDui.Text.Trim());
            
            if (rbSegunda.Checked)
                dosis = true;

            if (txtDui.Text.Length <= 9 && dui != 0)
            {
                //modificando datos

                Citum cita = (from c in db.Cita
                    where c.IdCita == ci
                    select c).First();

                cita.IdCita = ci;
                cita.Fecha = fecha;
                cita.TipoVacuna = dosis;
                cita.IdEmpleado = empleado;
                cita.DuiCiudadano = dui;
                db.SaveChanges();
                MessageBox.Show("Modificado exitosamente!", "Ciudadano", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectamente", "Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void eliminar()
        {
            
            var cita = Int32.Parse(txtCita.Text.Trim());
            
            var db = new vacunacionDBContext();

                Citum e = (from x in db.Cita
                    where x.IdCita == cita
                    select x).First();

                if (e != null)
                {
                    db.RemoveRange(e);
                    db.SaveChanges();
                    MessageBox.Show("Datos eliminados exitosamente!", "Clinica UCA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la cita", "Clinica UCA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
        }

        public void limpiar()
        {
            txtDui.Text = "";
            txtEmpleado.Text = "";
            txtCita.Text = "";
            btnDetalle.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ingresar();
            cargartabla();
            limpiar();
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            cargartabla();
            limpiar();
        }

        private void dgvCita_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtCita.Text = dgvCita.CurrentRow.Cells[0].Value.ToString();
                dtpFecha.Text = dgvCita.CurrentRow.Cells[1].Value.ToString();
                /*if (rbPrimera.Checked)
                    rbPrimera.Checked = dgvCita.CurrentRow.Cells[2].Value;
                else 
                    rbSegunda.Text  = dgvCita.CurrentRow.Cells[2].Value.ToString();*/
                txtDui.Text = dgvCita.CurrentRow.Cells[3].Value.ToString();
                txtEmpleado.Text = dgvCita.CurrentRow.Cells[4].Value.ToString();
                btnDetalle.Enabled = true;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            cargartabla();
            limpiar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            var db = new vacunacionDBContext();

            var dui = Int32.Parse(txtDui.Text.Trim());
            var resultado = db.Cita
                .Where(c => c.DuiCiudadanoNavigation.Dui == dui).ToList();

            if (resultado.Count() > 0)
            {
                frmSeguimientoCita seguimiento = new frmSeguimientoCita(resultado[0]);
                seguimiento.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}