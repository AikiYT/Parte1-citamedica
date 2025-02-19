﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.System
{
    [Table("Notifications", Schema = "system")]
    public sealed class Notifications 
    {
        [Key]
        public int NotificationID { get; set; }

        public int UserID { get; set; }

        public string? Message { get; set; }

        public DateTime SetAT { get; set; }
    }
}
