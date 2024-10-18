using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class RecordatorioReserva : BaseEntity
    {
        public int SolicitudReservaId { get; set; }
        public DateTime FechaRecordatorio { get; set; }
        public string? Mensaje { get; set; }

        
        public SolicitudReserva SolicitudReserva { get; set; } // Relación con SolicitudReserva
    }
}
