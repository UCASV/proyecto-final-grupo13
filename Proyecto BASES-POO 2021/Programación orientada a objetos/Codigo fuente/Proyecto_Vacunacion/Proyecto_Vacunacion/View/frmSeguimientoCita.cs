using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Windows.Forms.VisualStyles;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Proyecto_Vacunacion
{
    public partial class frmSeguimientoCita : Form
    {
        private Citum cita { get; set; }
        public frmSeguimientoCita(Citum cita)
        {
            InitializeComponent();
            this.cita = cita;
        }

        public void cargartabla()
        {
            var db = new vacunacionDBContext();

            var listSeguimiento = (from c in db.Cita
                from i in db.Ciudadanos.Where(n => n.Dui == c.DuiCiudadanoNavigation.Dui)
                select new
                {
                    c.IdCita,
                    i.Dui,
                    c.Fecha,
                    i.Telefono,
                    i.IdInstitucionNavigation.Institucion1
                });

            var filtro = listSeguimiento
                .Where(r => r.IdCita.Equals(cita.IdCita))
                .ToList();
            
            dgvSeguimiento.DataSource = null;
            dgvSeguimiento.DataSource = filtro;
        }

        private void frmSeguimientoCita_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            pdf();
        }

        public void pdf()
        {
            PdfPTable pdftable = new PdfPTable(dgvSeguimiento.Columns.Count);
            
            foreach (DataGridViewColumn column in dgvSeguimiento.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdftable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvSeguimiento.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString()));
                }
            }

            
            var save = new SaveFileDialog();
            var filename = save.FileName;
            save.DefaultExt = ".pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();
                    doc.Add(pdftable);
                    doc.Close();
                    stream.Close();
                }
            }

        }    
    }
}