using System.ComponentModel;

namespace Proyecto_Vacunacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelSubmenuAjustes = new System.Windows.Forms.Panel();
            this.btnRegistrocabina = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCabina = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.panelSubmenuVacunacion = new System.Windows.Forms.Panel();
            this.btnCintomas = new System.Windows.Forms.Button();
            this.btnProceso = new System.Windows.Forms.Button();
            this.btnVacunacion = new System.Windows.Forms.Button();
            this.PanelSubmenuRegistro = new System.Windows.Forms.Panel();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnCiudadano = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            this.panelSubmenuAjustes.SuspendLayout();
            this.panelSubmenuVacunacion.SuspendLayout();
            this.PanelSubmenuRegistro.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLateral.Controls.Add(this.panelSubmenuAjustes);
            this.panelLateral.Controls.Add(this.btnAjustes);
            this.panelLateral.Controls.Add(this.panelSubmenuVacunacion);
            this.panelLateral.Controls.Add(this.btnVacunacion);
            this.panelLateral.Controls.Add(this.PanelSubmenuRegistro);
            this.panelLateral.Controls.Add(this.btnRegistro);
            this.panelLateral.Controls.Add(this.panellogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(174, 585);
            this.panelLateral.TabIndex = 0;
            // 
            // panelSubmenuAjustes
            // 
            this.panelSubmenuAjustes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSubmenuAjustes.Controls.Add(this.btnRegistrocabina);
            this.panelSubmenuAjustes.Controls.Add(this.btnEmpleados);
            this.panelSubmenuAjustes.Controls.Add(this.btnCabina);
            this.panelSubmenuAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuAjustes.Location = new System.Drawing.Point(0, 457);
            this.panelSubmenuAjustes.Name = "panelSubmenuAjustes";
            this.panelSubmenuAjustes.Size = new System.Drawing.Size(157, 129);
            this.panelSubmenuAjustes.TabIndex = 6;
            // 
            // btnRegistrocabina
            // 
            this.btnRegistrocabina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrocabina.FlatAppearance.BorderSize = 0;
            this.btnRegistrocabina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrocabina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegistrocabina.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistrocabina.Location = new System.Drawing.Point(0, 80);
            this.btnRegistrocabina.Name = "btnRegistrocabina";
            this.btnRegistrocabina.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrocabina.Size = new System.Drawing.Size(157, 40);
            this.btnRegistrocabina.TabIndex = 2;
            this.btnRegistrocabina.Text = "Registro cabina";
            this.btnRegistrocabina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrocabina.UseVisualStyleBackColor = true;
            this.btnRegistrocabina.Click += new System.EventHandler(this.btnRegistrocabina_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 40);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(157, 40);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click_1);
            // 
            // btnCabina
            // 
            this.btnCabina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCabina.FlatAppearance.BorderSize = 0;
            this.btnCabina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCabina.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCabina.Location = new System.Drawing.Point(0, 0);
            this.btnCabina.Name = "btnCabina";
            this.btnCabina.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCabina.Size = new System.Drawing.Size(157, 40);
            this.btnCabina.TabIndex = 0;
            this.btnCabina.Text = "Cabina";
            this.btnCabina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCabina.UseVisualStyleBackColor = true;
            this.btnCabina.Click += new System.EventHandler(this.btnCabina_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAjustes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAjustes.Location = new System.Drawing.Point(0, 400);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(157, 57);
            this.btnAjustes.TabIndex = 5;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click_1);
            // 
            // panelSubmenuVacunacion
            // 
            this.panelSubmenuVacunacion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSubmenuVacunacion.Controls.Add(this.btnCintomas);
            this.panelSubmenuVacunacion.Controls.Add(this.btnProceso);
            this.panelSubmenuVacunacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuVacunacion.Location = new System.Drawing.Point(0, 307);
            this.panelSubmenuVacunacion.Name = "panelSubmenuVacunacion";
            this.panelSubmenuVacunacion.Size = new System.Drawing.Size(157, 93);
            this.panelSubmenuVacunacion.TabIndex = 4;
            // 
            // btnCintomas
            // 
            this.btnCintomas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCintomas.FlatAppearance.BorderSize = 0;
            this.btnCintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCintomas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCintomas.Location = new System.Drawing.Point(0, 40);
            this.btnCintomas.Name = "btnCintomas";
            this.btnCintomas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCintomas.Size = new System.Drawing.Size(157, 40);
            this.btnCintomas.TabIndex = 1;
            this.btnCintomas.Text = "Cintomas";
            this.btnCintomas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCintomas.UseVisualStyleBackColor = true;
            this.btnCintomas.Click += new System.EventHandler(this.btnCintomas_Click);
            // 
            // btnProceso
            // 
            this.btnProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProceso.FlatAppearance.BorderSize = 0;
            this.btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnProceso.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProceso.Location = new System.Drawing.Point(0, 0);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProceso.Size = new System.Drawing.Size(157, 40);
            this.btnProceso.TabIndex = 0;
            this.btnProceso.Text = "Proceso vacunacion";
            this.btnProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceso.UseVisualStyleBackColor = true;
            this.btnProceso.Click += new System.EventHandler(this.btnProceso_Click_1);
            // 
            // btnVacunacion
            // 
            this.btnVacunacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVacunacion.FlatAppearance.BorderSize = 0;
            this.btnVacunacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVacunacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVacunacion.Location = new System.Drawing.Point(0, 250);
            this.btnVacunacion.Name = "btnVacunacion";
            this.btnVacunacion.Size = new System.Drawing.Size(157, 57);
            this.btnVacunacion.TabIndex = 3;
            this.btnVacunacion.Text = "Vacunacion";
            this.btnVacunacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacunacion.UseVisualStyleBackColor = true;
            this.btnVacunacion.Click += new System.EventHandler(this.btnVacunacion_Click);
            // 
            // PanelSubmenuRegistro
            // 
            this.PanelSubmenuRegistro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelSubmenuRegistro.Controls.Add(this.btnCita);
            this.PanelSubmenuRegistro.Controls.Add(this.btnCiudadano);
            this.PanelSubmenuRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubmenuRegistro.Location = new System.Drawing.Point(0, 159);
            this.PanelSubmenuRegistro.Name = "PanelSubmenuRegistro";
            this.PanelSubmenuRegistro.Size = new System.Drawing.Size(157, 91);
            this.PanelSubmenuRegistro.TabIndex = 2;
            // 
            // btnCita
            // 
            this.btnCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCita.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCita.Location = new System.Drawing.Point(0, 40);
            this.btnCita.Name = "btnCita";
            this.btnCita.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCita.Size = new System.Drawing.Size(157, 40);
            this.btnCita.TabIndex = 1;
            this.btnCita.Text = "Agregar cita";
            this.btnCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // btnCiudadano
            // 
            this.btnCiudadano.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCiudadano.FlatAppearance.BorderSize = 0;
            this.btnCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiudadano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCiudadano.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCiudadano.Location = new System.Drawing.Point(0, 0);
            this.btnCiudadano.Name = "btnCiudadano";
            this.btnCiudadano.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCiudadano.Size = new System.Drawing.Size(157, 40);
            this.btnCiudadano.TabIndex = 0;
            this.btnCiudadano.Text = "Nuevo Ciudadano";
            this.btnCiudadano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiudadano.UseVisualStyleBackColor = true;
            this.btnCiudadano.Click += new System.EventHandler(this.btnCiudadano_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistro.Location = new System.Drawing.Point(0, 102);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(157, 57);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(157, 102);
            this.panellogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.pictureBox2);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(174, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(737, 585);
            this.panelForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(488, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 585);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelSubmenuAjustes.ResumeLayout(false);
            this.panelSubmenuVacunacion.ResumeLayout(false);
            this.PanelSubmenuRegistro.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelForm;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnEmpleados;

        private System.Windows.Forms.Button btnProceso;

        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnRegistrocabina;
        private System.Windows.Forms.Panel panelSubmenuAjustes;
        private System.Windows.Forms.Button btnCabina;

        private System.Windows.Forms.Button btnVacunacion;
        private System.Windows.Forms.Panel panelSubmenuVacunacion;
        private System.Windows.Forms.Button btnCintomas;

        private System.Windows.Forms.Panel panellogo;

        private System.Windows.Forms.Panel PanelSubmenuRegistro;

        private System.Windows.Forms.Button btnCita;

        private System.Windows.Forms.Button btnCiudadano;

        private System.Windows.Forms.Button btnRegistro;

        private System.Windows.Forms.Panel panelLateral;
        

        #endregion
    }
}