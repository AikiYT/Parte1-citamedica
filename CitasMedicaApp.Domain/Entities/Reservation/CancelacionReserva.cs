using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class CancelacionReserva : BaseEntity
    {
        public int SolicitudReservaId { get; set; }
        public string MotivoCancelacion { get; set; }
        public DateTime FechaCancelacion { get; set; }

        // Relación con SolicitudReserva
        public SolicitudReserva SolicitudReserva { get; set; }
    }
}
