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
            hideSubmenu();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnProceso_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCintomas_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCabina_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnRegistrocabina_Click(object sender, EventArgs e)
        {
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
            hideSubmenu();
        }
    }
}