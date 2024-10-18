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
    [Table("Patients", Schema = "users")]
    public sealed class Patients : BaseEntity
    {
        [Key]
        
        public int PatientID { get; set; } 

        public DateTime DateOfBirth { get; set; }

        public string? Gender { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? EmergencyContactName { get; set; }

        public string? EmergencyContactPhone { get; set; }

        public string? BloodType { get; set; }

        public string? Allergies { get; set; }

        public int InsuranceProviderID { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public bool IsActive { get; set; }
    }
}
