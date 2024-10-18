using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Medical
{
    [Table("MedicalRecords", Schema = "medical")]

    public sealed class MedicalRecords : BaseEntity
    {
        [Key]
        public int RecordID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public string? Diagnosis { get; set; }

        public string? Treatment { get; set; }
        
        public DateTime DateOfVisit { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }


    }
}
