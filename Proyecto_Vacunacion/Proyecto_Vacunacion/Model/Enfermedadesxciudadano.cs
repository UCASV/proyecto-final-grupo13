using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion.VacunacionContext
{
    public partial class Enfermedadesxciudadano
    {
        public int IdEnfermedades { get; set; }
        public int DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Enfermedade IdEnfermedadesNavigation { get; set; }
    }
}
