using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class TipoEmpleado
    {
        public TipoEmpleado()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdTipoEmpleado { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
