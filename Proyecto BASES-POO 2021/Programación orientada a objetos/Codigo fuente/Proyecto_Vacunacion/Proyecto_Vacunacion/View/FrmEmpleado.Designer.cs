using System.ComponentModel;

namespace Proyecto_Vacunacion
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbIdEmpleado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-10, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombre.Location = new System.Drawing.Point(223, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 30);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblContra
            // 
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblContra.Location = new System.Drawing.Point(207, 184);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(96, 31);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCorreo.Location = new System.Drawing.Point(151, 237);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(152, 27);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo institucional:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDireccion.Location = new System.Drawing.Point(223, 293);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 27);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion\r\n:";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(188, 355);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(123, 27);
            this.lblIdEmpleado.TabIndex = 5;
            this.lblIdEmpleado.Text = "Tipo empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(306, 121);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 37);
            this.txtNombre.TabIndex = 6;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(306, 175);
            this.txtContra.Multiline = true;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(235, 40);
            this.txtContra.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(306, 224);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 40);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(309, 279);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(238, 41);
            this.txtDireccion.TabIndex = 9;
            // 
            // cmbIdEmpleado
            // 
            this.cmbIdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdEmpleado.FormattingEnabled = true;
            this.cmbIdEmpleado.Location = new System.Drawing.Point(322, 357);
            this.cmbIdEmpleado.Name = "cmbIdEmpleado";
            this.cmbIdEmpleado.Size = new System.Drawing.Size(189, 21);
            this.cmbIdEmpleado.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(322, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 59);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(692, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 557);
            this.label2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(0, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(772, 59);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 524);
            this.label3.TabIndex = 13;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(737, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbIdEmpleado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.ComboBox cmbIdEmpleado;
        

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContra;

        private System.Windows.Forms.Label lblIdEmpleado;

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;

        private System.Windows.Forms.Label lblContra;
        
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}