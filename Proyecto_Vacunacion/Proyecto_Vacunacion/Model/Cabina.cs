using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion.VacunacionContext
{
    public partial class Cabina
    {
        public Cabina()
        {
            RegistroEmpleados = new HashSet<RegistroEmpleado>();
        }

        public int IdCabina { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public int? IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<RegistroEmpleado> RegistroEmpleados { get; set; }
    }
}
