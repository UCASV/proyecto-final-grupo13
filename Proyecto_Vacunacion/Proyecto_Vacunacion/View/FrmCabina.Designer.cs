using System.ComponentModel;

namespace Proyecto_Vacunacion
{
    partial class FrmCabina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCabina));
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudencargado = new System.Windows.Forms.NumericUpDown();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudtelefono = new System.Windows.Forms.NumericUpDown();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.nudencargado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudtelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtdireccion.Location = new System.Drawing.Point(56, 191);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(299, 65);
            this.txtdireccion.TabIndex = 7;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtcorreo.Location = new System.Drawing.Point(56, 366);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(229, 37);
            this.txtcorreo.TabIndex = 8;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtcodigo.Location = new System.Drawing.Point(56, 115);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(229, 37);
            this.txtcodigo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo cabina:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(56, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Direccion cabina:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(56, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefono cabina:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(56, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Correo cabina:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(320, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Encargado cabina (carnet):";
            // 
            // nudencargado
            // 
            this.nudencargado.Location = new System.Drawing.Point(320, 115);
            this.nudencargado.Maximum = new decimal(new int[] {9999, 0, 0, 0});
            this.nudencargado.Name = "nudencargado";
            this.nudencargado.Size = new System.Drawing.Size(234, 20);
            this.nudencargado.TabIndex = 57;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.Location = new System.Drawing.Point(56, 432);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(129, 66);
            this.btnguardar.TabIndex = 58;
            this.btnguardar.Text = "Agregar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(-5, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 536);
            this.label7.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(-5, -28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(812, 82);
            this.label6.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(715, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 536);
            this.label8.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(135, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(480, 45);
            this.label9.TabIndex = 65;
            this.label9.Text = "Registrando nueva cabina";
            // 
            // nudtelefono
            // 
            this.nudtelefono.Location = new System.Drawing.Point(56, 304);
            this.nudtelefono.Maximum = new decimal(new int[] {79999999, 0, 0, 0});
            this.nudtelefono.Name = "nudtelefono";
            this.nudtelefono.Size = new System.Drawing.Size(234, 20);
            this.nudtelefono.TabIndex = 66;
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(320, 280);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(371, 172);
            this.dgvRegistro.TabIndex = 67;
            this.dgvRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(352, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 66);
            this.button1.TabIndex = 68;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(524, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 66);
            this.button2.TabIndex = 69;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(642, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 34);
            this.button3.TabIndex = 70;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(737, 585);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.nudtelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.nudencargado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtdireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCabina";
            this.Text = "Nueva cabina";
            this.Load += new System.EventHandler(this.FrmCabina_Load);
            ((System.ComponentModel.ISupportInitialize) (this.nudencargado)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudtelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.NumericUpDown nudtelefono;

        private System.Windows.Forms.TextBox txtcorreo;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button btnguardar;

        private System.Windows.Forms.NumericUpDown nudencargado;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.TextBox txtcodigo;

        private System.Windows.Forms.TextBox txtdireccion;

        #endregion
    }
}