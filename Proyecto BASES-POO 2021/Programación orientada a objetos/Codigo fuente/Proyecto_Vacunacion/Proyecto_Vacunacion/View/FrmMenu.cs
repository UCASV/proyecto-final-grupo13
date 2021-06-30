using System;
using System.Windows.Forms;

namespace Proyecto_Vacunacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            CustumDesing();
        }
        public int Cartuser;
        public string tipoEmpleado;
        private void CustumDesing()
        {
            panelSubmenuAjustes.Visible = false;
            panelSubmenuVacunacion.Visible = false;
            PanelSubmenuRegistro.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubmenuAjustes.Visible == true)
                panelSubmenuAjustes.Visible = false;
            if (panelSubmenuVacunacion.Visible == true)
                panelSubmenuVacunacion.Visible = false;
            if (PanelSubmenuRegistro.Visible == true)
                PanelSubmenuRegistro.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }else
                submenu.Visible = false;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelSubmenuRegistro);
        }

        private void btnCiudadano_Click(object sender, EventArgs e)
        {
            openForm(new frmCiudadano());
            hideSubmenu();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            openForm(new frmCita());
            hideSubmenu();
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnProceso_Click_1(object sender, EventArgs e)
        {
            openForm(new FrmProcesoVacunacion());
            hideSubmenu();
        }

        private void btnCintomas_Click(object sender, EventArgs e)
        {
            openForm(new frmRegistroSintomas());
            hideSubmenu();
        }

        private void btnCabina_Click(object sender, EventArgs e)
        {
            openForm(new FrmCabina());
            hideSubmenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnRegistrocabina_Click(object sender, EventArgs e)
        {
            openForm(new FrmRegistroEmpleado());
            hideSubmenu();
        }

        private void btnVacunacion_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuVacunacion);
        }
        private void btnAjustes_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuAjustes);
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            openForm(new FrmEmpleado());
            hideSubmenu();
        }

        private Form activeform = null;

        private void openForm(Form Childform)
        {
            if (activeform != null)
            {
                activeform.Close(); 
            }
            activeform = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            panelForm.Controls.Add(Childform);
            panelForm.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Tipo empleado: " + tipoEmpleado + " empleado " + Cartuser);
        }
    }
}