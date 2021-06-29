using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cabinas = new HashSet<Cabina>();
            Cita = new HashSet<Citum>();
            ProcesoVacunacions = new HashSet<ProcesoVacunacion>();
            RegistroEmpleados = new HashSet<RegistroEmpleado>();
        }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Direccion { get; set; }
        public int? IdTipoEmpleado { get; set; }

        public virtual TipoEmpleado IdTipoEmpleadoNavigation { get; set; }
        public virtual ICollection<Cabina> Cabinas { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<ProcesoVacunacion> ProcesoVacunacions { get; set; }
        public virtual ICollection<RegistroEmpleado> RegistroEmpleados { get; set; }
    }
}
