using System.ComponentModel;

namespace Proyecto_Vacunacion
{
    partial class frmRegistroSintomas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroSintomas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarSintomas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSintomas = new System.Windows.Forms.ComboBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 72);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(0, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 101);
            this.label2.TabIndex = 1;
            // 
            // btnEnviarSintomas
            // 
            this.btnEnviarSintomas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnviarSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEnviarSintomas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnviarSintomas.Location = new System.Drawing.Point(319, 428);
            this.btnEnviarSintomas.Name = "btnEnviarSintomas";
            this.btnEnviarSintomas.Size = new System.Drawing.Size(166, 65);
            this.btnEnviarSintomas.TabIndex = 6;
            this.btnEnviarSintomas.Text = "Enviar";
            this.btnEnviarSintomas.UseVisualStyleBackColor = false;
            this.btnEnviarSintomas.Click += new System.EventHandler(this.btnEnviarSintomas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSintomas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDui, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 295);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 82);
            this.label3.TabIndex = 0;
            this.label3.Text = "DUI de la persona:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(70, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 82);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sintomas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSintomas
            // 
            this.cmbSintomas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSintomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSintomas.FormattingEnabled = true;
            this.cmbSintomas.Location = new System.Drawing.Point(394, 195);
            this.cmbSintomas.Name = "cmbSintomas";
            this.cmbSintomas.Size = new System.Drawing.Size(162, 21);
            this.cmbSintomas.TabIndex = 2;
            this.cmbSintomas.SelectedIndexChanged += new System.EventHandler(this.cmbSintomas_SelectedIndexChanged);
            // 
            // txtDui
            // 
            this.txtDui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDui.Location = new System.Drawing.Point(370, 47);
            this.txtDui.Multiline = true;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(211, 43);
            this.txtDui.TabIndex = 3;
            this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(656, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 34);
            this.button3.TabIndex = 71;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(218, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 72);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sintomas Ciudadano";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistroSintomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(773, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnEnviarSintomas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroSintomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Sintomas";
            this.Load += new System.EventHandler(this.frmRegistroSintomas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox txtDui;

        private System.Windows.Forms.ComboBox cmbSintomas;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Button btnEnviarSintomas;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}