using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion.VacunacionContext
{
    public partial class ProcesoVacunacion
    {
        public int IdProceso { get; set; }
        public DateTime FechaHora { get; set; }
        public int? DuiCiudadano { get; set; }
        public int? IdEmpleado { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
