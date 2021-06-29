using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class Sintomasxciudadano
    {
        public int IdSintoma { get; set; }
        public int DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Sintoma IdSintomaNavigation { get; set; }
    }
}
