using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;
using CitasMedicaApp.Domain.Entities;

namespace CitasMedicaApp.Domain.Users
{
    public sealed  class Cita : BaseEntity
    {
        [Key]
        public int IdCita { get; set; }

        public Patients Paciente { get; set; }

        public Doctors Doctor { get; set; }

        public DateTime FechaHora { get; set; }

        public string Estado { get; set; }
    
}
    }

