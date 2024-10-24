using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Appointments
{
    [Table("DoctorAvailability", Schema = "appointments")] 
    public sealed class DoctorAvailability : BaseEntity
    {
        [Key]
        public int AvailabilityID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AvailableDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }
    }
}
