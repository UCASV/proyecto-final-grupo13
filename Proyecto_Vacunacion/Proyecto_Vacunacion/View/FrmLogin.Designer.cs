namespace Proyecto_Vacunacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudCabina = new System.Windows.Forms.NumericUpDown();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.nudCabina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCabina
            // 
            this.nudCabina.Location = new System.Drawing.Point(346, 312);
            this.nudCabina.Name = "nudCabina";
            this.nudCabina.Size = new System.Drawing.Size(202, 20);
            this.nudCabina.TabIndex = 1;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtcontrasena.Location = new System.Drawing.Point(55, 212);
            this.txtcontrasena.Multiline = true;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(220, 42);
            this.txtcontrasena.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(60, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsuario.Location = new System.Drawing.Point(55, 120);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 42);
            this.txtUsuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(55, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carnet:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.Location = new System.Drawing.Point(55, 271);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(157, 50);
            this.btnIngresar.TabIndex = 54;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(-7, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(618, 70);
            this.label4.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(-7, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 57);
            this.label5.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(199, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "Inicio Secion";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(346, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cabina:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(-7, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 340);
            this.label7.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(587, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 340);
            this.label8.TabIndex = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(605, 437);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCabina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.nudCabina)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;


        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnIngresar;

        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown nudCabina;

        #endregion
    }
}