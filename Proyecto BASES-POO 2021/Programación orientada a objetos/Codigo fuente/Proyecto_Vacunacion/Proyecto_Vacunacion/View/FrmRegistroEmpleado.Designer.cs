using System.ComponentModel;

namespace Proyecto_Vacunacion
{
    partial class FrmRegistroEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEmpleado));
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.nudCabina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCabina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(102, 174);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(531, 275);
            this.dgvRegistro.TabIndex = 60;
            this.dgvRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultad_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.Location = new System.Drawing.Point(102, 473);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 43);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar registro";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.Location = new System.Drawing.Point(390, 473);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(243, 43);
            this.btnEditar.TabIndex = 61;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dateEntrada
            // 
            this.dateEntrada.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEntrada.CustomFormat = "  yy-mm-dd      hh:mm   tt";
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEntrada.Location = new System.Drawing.Point(107, 129);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(255, 20);
            this.dateEntrada.TabIndex = 63;
            // 
            // nudCabina
            // 
            this.nudCabina.Location = new System.Drawing.Point(389, 133);
            this.nudCabina.Maximum = new decimal(new int[] {9999, 0, 0, 0});
            this.nudCabina.Name = "nudCabina";
            this.nudCabina.Size = new System.Drawing.Size(234, 20);
            this.nudCabina.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(107, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Fecha y hora:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(389, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cabina:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(-4, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 524);
            this.label7.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(-4, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(726, 79);
            this.label3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(698, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 524);
            this.label4.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(216, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 45);
            this.label9.TabIndex = 70;
            this.label9.Text = "Registro Cabina";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(625, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 34);
            this.button3.TabIndex = 71;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmRegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(721, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCabina);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroEmpleado";
            this.Text = "Registro empleados";
            this.Load += new System.EventHandler(this.FrmRegistroEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCabina)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.DateTimePicker dateEntrada;

        private System.Windows.Forms.DataGridView dgvRegistro;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.NumericUpDown nudCabina;

      

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        

        #endregion
    }
}