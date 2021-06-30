using System.ComponentModel;

namespace Proyecto_Vacunacion
{
    partial class frmSeguimientoCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientoCita));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.dgvSeguimiento = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvSeguimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.btnPdf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvSeguimiento, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.93478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.06522F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdf.Location = new System.Drawing.Point(605, 191);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(160, 44);
            this.btnPdf.TabIndex = 77;
            this.btnPdf.Text = "Descargar PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // dgvSeguimiento
            // 
            this.dgvSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSeguimiento, 2);
            this.dgvSeguimiento.Location = new System.Drawing.Point(3, 3);
            this.dgvSeguimiento.MultiSelect = false;
            this.dgvSeguimiento.Name = "dgvSeguimiento";
            this.dgvSeguimiento.RowTemplate.Height = 28;
            this.dgvSeguimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeguimiento.Size = new System.Drawing.Size(763, 166);
            this.dgvSeguimiento.TabIndex = 0;
            // 
            // frmSeguimientoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeguimientoCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento Cita";
            this.Load += new System.EventHandler(this.frmSeguimientoCita_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvSeguimiento)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPdf;

        private System.Windows.Forms.DataGridView dgvSeguimiento;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}