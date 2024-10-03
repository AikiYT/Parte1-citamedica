using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class DisponibilidadReserva : BaseEntity
    {
        public int IdDoctor { get; set; }
        public DateTime FechaDisponible { get; set; }
        public string HorasDisponibles { get; set; } 

        // Relación con Doctor
        public Doctor Doctor { get; set; }
    }
}
