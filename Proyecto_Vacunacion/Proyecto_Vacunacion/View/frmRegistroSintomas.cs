using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Proyecto_Vacunacion.VacunacionContext;

namespace Proyecto_Vacunacion
{
    public partial class frmRegistroSintomas : Form
    {
        public frmRegistroSintomas()
        {
            InitializeComponent();
        }
    


        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cmbSintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void frmRegistroSintomas_Load(object sender, EventArgs e)
        {
            var db = new vacunacionDBContext();
             
            cmbSintomas.DataSource =  db.Sintomas.ToList();
            cmbSintomas.DisplayMember = "Sintoma1";
            cmbSintomas.ValueMember = "IdSintoma";
        }

        private void btnEnviarSintomas_Click(object sender, EventArgs e)
        {
            
         int dui = Convert.ToInt32(txtDui.Text);
         Sintoma sinto = (Sintoma) cmbSintomas.SelectedItem;
         
         var db = new vacunacionDBContext();
         Sintoma istdd = db.Set<Sintoma>().SingleOrDefault(i => i.IdSintoma == sinto.IdSintoma);
         
         Sintomasxciudadano sintomaDelCiudadno = new Sintomasxciudadano();
         sintomaDelCiudadno.DuiCiudadano = dui;
         sintomaDelCiudadno.IdSintomaNavigation = istdd;
         
         db.Add(sintomaDelCiudadno);
         db.SaveChanges();
         MessageBox.Show("Agregado con exito");

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
    } 
}