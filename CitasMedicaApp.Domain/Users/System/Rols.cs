using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Security
{
    [Table("Roles", Schema = "system")]
    public class Rols 
    {
        [Key]
        public int RoleID { get; set; }

        public string? RoleName { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public bool IsActive { get; set; }

       

        public List<string> Permisos { get; set; }



        public Rols()
        {
            Permisos = new List<string>();
            CreateAt = DateTime.Now;
            IsActive = true;


            // faltan cosas segun dijo el profesor debemos completarla esta clase
        }
    }
}
