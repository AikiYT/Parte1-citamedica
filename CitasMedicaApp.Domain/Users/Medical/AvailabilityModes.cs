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
    [Table("AvailabilityModes", Schema = "medical")]

    public sealed class AvailabilityModes : BaseEntity
    {
        [Key]
        public int SAvailabilityModeID { get; set; }

        public string? AvailabilityMode { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public bool IsActive { get; set; }
    }
}
