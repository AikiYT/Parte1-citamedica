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

    [Table("Appointments", Schema = "appointments")]
    public sealed class Appointments : BaseEntity
    {
        [Key]

        public int AppointmentID { get; set; }

        public int PatientID { get; set; }  

        public int DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int StatusID { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

    }
}
