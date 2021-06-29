using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            Cita = new HashSet<Citum>();
            Enfermedadesxciudadanos = new HashSet<Enfermedadesxciudadano>();
            ProcesoVacunacions = new HashSet<ProcesoVacunacion>();
            Sintomasxciudadanos = new HashSet<Sintomasxciudadano>();
        }

        public int Dui { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int? IdInstitucion { get; set; }

        public virtual Institucion IdInstitucionNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Enfermedadesxciudadano> Enfermedadesxciudadanos { get; set; }
        public virtual ICollection<ProcesoVacunacion> ProcesoVacunacions { get; set; }
        public virtual ICollection<Sintomasxciudadano> Sintomasxciudadanos { get; set; }
    }
}
