using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Vacunacion.VacunacionContext;

namespace Proyecto_Vacunacion
{
    public partial class frmEnfermedades : Form
    {
        private Ciudadano ciudadano { get; set; }
        public frmEnfermedades(Ciudadano ciudadano)
        {
            InitializeComponent();
            this.ciudadano = ciudadano;
        }


        private void frmEnfermedades_Load(object sender, EventArgs e)
        {
            //ComboBox enfermedades
            
            var db = new vacunacionDBContext();
            
            cmbEnfermedades.DataSource = db.Enfermedades.ToList();
            cmbEnfermedades.DisplayMember = "EnfermedadesCronicas";
            cmbEnfermedades.ValueMember = "IdEnfermedades";
            
            cargartabla();
        }

        public void cargartabla()
        {
            var db = new vacunacionDBContext();

            var listCruz = (from e in db.Enfermedadesxciudadanos
                from c in db.Ciudadanos.Where(n => n.Dui == e.DuiCiudadanoNavigation.Dui)
                from f in db.Enfermedades.Where(r => r.IdEnfermedades == e.IdEnfermedadesNavigation.IdEnfermedades)
                select new
                {
                    c.Dui,
                    f.EnfermedadesCronicas
                });
            
            //Filtrando los datos por usuario

            var filtro = listCruz
                .Where(r => r.Dui.Equals(ciudadano.Dui))
                .ToList();

            dgvEnfermedades.DataSource = null;
            dgvEnfermedades.DataSource = filtro;
        }

        public void agregar()
        {
            Enfermedade enf = (Enfermedade) cmbEnfermedades.SelectedItem;

            var db = new vacunacionDBContext();

            Enfermedade entdd = db.Set<Enfermedade>().SingleOrDefault(i => i.IdEnfermedades == enf.IdEnfermedades);
            
            Ciudadano ind = db.Set<Ciudadano>().SingleOrDefault(v => v.Dui == ciudadano.Dui);

            Enfermedadesxciudadano x = new Enfermedadesxciudadano();
            x.IdEnfermedadesNavigation = entdd;
            x.DuiCiudadanoNavigation = ind;

            db.Add(x);
            db.SaveChanges();
            MessageBox.Show("Agregado exitosamente!", "Ciudadano", MessageBoxButtons.OK);
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
            cargartabla();
        }

    }
}