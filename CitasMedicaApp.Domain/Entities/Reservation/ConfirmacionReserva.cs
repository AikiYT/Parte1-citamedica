using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class ConfirmacionReserva : BaseEntity
    {
        public int SolicitudReservaId { get; set; }
        public DateTime FechaConfirmacion { get; set; }

        
        public SolicitudReserva SolicitudReserva { get; set; } // Relación con SolicitudReserva

        // Si la cita fue generada tras la confirmación
        public int? IdCita { get; set; }
        public Cita CitaGenerada { get; set; }
    }
}
