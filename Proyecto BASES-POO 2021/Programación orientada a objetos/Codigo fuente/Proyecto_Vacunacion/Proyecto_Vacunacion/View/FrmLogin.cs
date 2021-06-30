
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
            string tipoEmpleado;
           
           
            
            var db = new vacunacionDBContext();
            int carnet = Convert.ToInt32(txtUsuario.Text);
            String pass = txtcontrasena.Text;
            string respuesta = txtcontrasena.Text;
            int cabina = Convert.ToInt32(nudCabina.Value);
            var Usercart = db.Empleados.FirstOrDefault(x => x.IdEmpleado == carnet && x.Contrasenia== pass);
            var CabinExist = db.Cabinas.FirstOrDefault(x => x.IdCabina == cabina);
            if (Usercart!=null && CabinExist!=null)
            { 
                /////Obteniendo El tipo empleado
                var usdr = db.Empleados.Include(i => i.IdTipoEmpleadoNavigation).ToList();
                var filtroP = usdr.Where(u => u.IdEmpleado == carnet).ToList();
                ////Mostrando 
                tipoEmpleado= filtroP[0].IdTipoEmpleadoNavigation.Tipo;
                RegistroCabina(carnet,cabina);
                FrmMenu open = new FrmMenu();
                open.Cartuser = carnet;
                open.tipoEmpleado = tipoEmpleado;
                open.Show();
                this.Hide();
                MessageBox.Show("Bienvenido al sistema COVID19");
            }
            else
            {
                MessageBox.Show("Error al ingresar datos!", "Admicion UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegistroCabina(int usuario,int cabina)
        {
            DateTime date = DateTime.Now;
            var db = new vacunacionDBContext();
            RegistroEmpleado newRegistro = new RegistroEmpleado();
            newRegistro.IdEmpleado = usuario;
            newRegistro.IdCabina = cabina;
            newRegistro.Fecha = date;
            db.Add(newRegistro);
            db.SaveChanges();
        }
    }
    }
