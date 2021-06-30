using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion.VacunacionContext
{
    public partial class Citum
    {
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public bool TipoVacuna { get; set; }
        public int? IdEmpleado { get; set; }
        public int? DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
