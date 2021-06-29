using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion.VacunacionContext
{
    public partial class Enfermedade
    {
        public Enfermedade()
        {
            Enfermedadesxciudadanos = new HashSet<Enfermedadesxciudadano>();
        }

        public int IdEnfermedades { get; set; }
        public string EnfermedadesCronicas { get; set; }

        public virtual ICollection<Enfermedadesxciudadano> Enfermedadesxciudadanos { get; set; }
    }
}
