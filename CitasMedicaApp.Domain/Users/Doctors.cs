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
    [Table("Doctors", Schema = "users")]

    public sealed class Doctors : BaseEntity
    {
        [Key]
       public int DoctorID { get; set; }    

       public int SpecialityID { get; set; }

       public string? LicenseNumber { get; set; }

        public string? PhoneNumber { get; set; }

        public int YearsOfExperience { get; set; }

        public string? Education { get; set; }

        public string? Bio { get; set; }

        public decimal ConsultationFee { get; set; }

        public string? ClinicAddress { get; set; }

        public int AvailabilityModeId   { get; set; }

        public DateTime licenseExpirationDate { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public bool IsActive { get; set; }

    }
}
