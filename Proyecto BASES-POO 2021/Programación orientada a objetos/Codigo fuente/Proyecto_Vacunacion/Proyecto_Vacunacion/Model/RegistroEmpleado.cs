using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class RegistroEmpleado
    {
        public int IdRegistro { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
