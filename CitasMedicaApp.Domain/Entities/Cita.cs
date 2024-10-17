using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities
{
    [Table("Cita", Schema = "User")]
    public sealed class Cita : BaseEntity
    {
        [Key]
        public int IdCita { get; set; }

        public Paciente Paciente { get; set; }

        public Doctor Doctor { get; set; }

        public DateTime FechaHora { get; set; } 

        public string Estado  { get; set; } 
    }
}
