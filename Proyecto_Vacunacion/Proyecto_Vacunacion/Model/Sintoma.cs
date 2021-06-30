using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class Sintoma
    {
        public Sintoma()
        {
            Sintomasxciudadanos = new HashSet<Sintomasxciudadano>();
        }

        public int IdSintoma { get; set; }
        public string Sintoma1 { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Sintomasxciudadano> Sintomasxciudadanos { get; set; }
    }
}
