
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_Vacunacion.VacunacionContext;

namespace Proyecto_Vacunacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var db = new vacunacionDBContext();
            int carnet = Convert.ToInt32(txtUsuario.Text);
            String pass = txtcontrasena.Text;
            string respuesta = txtcontrasena.Text;
            var Usercart = db.Empleados.FirstOrDefault(x => x.IdEmpleado == carnet && x.Contrasenia== pass);
            if (Usercart!=null)
            { 
                MessageBox.Show("Bienbenido al sistema UCA");

            }
            else
            {
                MessageBox.Show("Error al ingresar datos!", "Admicion UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}