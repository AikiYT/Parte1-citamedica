using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class NotificacionReserva : BaseEntity
    {
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }

       
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}

