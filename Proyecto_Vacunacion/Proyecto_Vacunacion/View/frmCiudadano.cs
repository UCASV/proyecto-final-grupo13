using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Vacunacion
{
    public partial class frmCiudadano : Form
    {
        public frmCiudadano()
        {
            InitializeComponent();
        }
        
        //Validacion de TextBox
        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void frmCiudadano_Load(object sender, EventArgs e)
        {
            //ComboBox Institucion

            var db = new vacunacionDBContext();
            
            cmbInstitucion.DataSource = db.Institucions.ToList();
            cmbInstitucion.DisplayMember = "Institucion1";
            cmbInstitucion.ValueMember = "IdInstitucion";
            
            //DataGridView
            
            cargarTabla();
        }

        public void cargarTabla()
        {
            var db = new vacunacionDBContext();

            var listCiudadano = (from c in db.Ciudadanos
                from i in db.Institucions.Where(n => n.IdInstitucion == c.IdInstitucionNavigation.IdInstitucion)
                select new
                {
                    c.Dui,
                    c.CorreoElectronico,
                    c.Direccion,
                    c.Telefono,
                    i.Institucion1,
                    i.IdInstitucion
                });

            dgvCiudadano.DataSource = null;
            dgvCiudadano.DataSource = listCiudadano.ToList();
        }
        
        // Funcion agregar

        public void agregar()
        {
            var dui = Int32.Parse(txtDui.Text.Trim());
            var correo = txtCorreo.Text.Trim();
            var direccion = txtDireccion.Text.Trim();
            var telefono = Int32.Parse(txtTelefono.Text.Trim());
            Institucion ins = (Institucion) cmbInstitucion.SelectedItem;

            var db = new vacunacionDBContext();

            Institucion istdd = db.Set<Institucion>().SingleOrDefault(i => i.IdInstitucion == ins.IdInstitucion);
            
            //validando datos
            
            if (txtDui.Text.Length <= 9 && correo.Length != 0 && direccion.Length != 0 && telefono > 20000000 && telefono < 79999999)
            {
                //Insertando datos
                
                Ciudadano ciudadano = new Ciudadano();
                ciudadano.Dui = dui;
                ciudadano.CorreoElectronico = correo;
                ciudadano.Direccion = direccion;
                ciudadano.Telefono = telefono;
                ciudadano.IdInstitucionNavigation = istdd;
                db.Add(ciudadano);
                db.SaveChanges();
                MessageBox.Show("Agregado exitosamente!", "Ciudadano", MessageBoxButtons.OK);

                if (rbSi.Checked)
                {
                    var resultado = db.Ciudadanos
                        .Where(c => ciudadano.Dui == c.Dui).ToList();

                    if (resultado.Count() > 0)
                    {
                        frmEnfermedades enfermedades = new frmEnfermedades(resultado[0]);
                        enfermedades.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectamente", "Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void modificar()
        {
            var dui = Int32.Parse(txtDui.Text.Trim());
            var correo = txtCorreo.Text.Trim();
            var direccion = txtDireccion.Text.Trim();
            var telefono = Int32.Parse(txtTelefono.Text.Trim());
            Institucion ins = (Institucion) cmbInstitucion.SelectedItem;
            
            var db = new vacunacionDBContext();

            Institucion istdd = db.Set<Institucion>().SingleOrDefault(i => i.IdInstitucion == ins.IdInstitucion);

            if (txtDui.Text.Length <= 9 && correo.Length != 0 && direccion.Length != 0 && telefono > 20000000 && telefono < 79999999)
            {
                //modificando datos

                Ciudadano ciudadano = (from c in db.Ciudadanos
                    where c.Dui == dui
                    select c).First();
               
                ciudadano.Dui = dui;
                ciudadano.CorreoElectronico = correo;
                ciudadano.Direccion = direccion;
                ciudadano.Telefono = telefono;
                ciudadano.IdInstitucionNavigation = istdd;
                db.SaveChanges();
                MessageBox.Show("Modificado exitosamente!", "Ciudadano", MessageBoxButtons.OK);
                
                if (rbSi.Checked)
                {
                    var resultado = db.Ciudadanos
                        .Where(c => ciudadano.Dui == c.Dui).ToList();

                    if (resultado.Count() > 0)
                    {
                        frmEnfermedades enfermedades = new frmEnfermedades(resultado[0]);
                        enfermedades.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectamente", "Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void limpiar()
        {
            txtDui.Text = null;
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
            cargarTabla();
            limpiar();
        }

        private void dgvCiudadano_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtDui.Text = dgvCiudadano.CurrentRow.Cells[0].Value.ToString();
                txtCorreo.Text = dgvCiudadano.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvCiudadano.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvCiudadano.CurrentRow.Cells[3].Value.ToString();
                cmbInstitucion.Text = dgvCiudadano.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            cargarTabla();
            limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}