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
    [Table("Patients", Schema = "User")]
    public sealed class Paciente : BaseEntity
    {
        [Key]
        
        public int IdPaciente { get; set; } 

        public string Nombre { get; set; }  

        public string Direccion { get; set; }   

        public string Telefono { get; set; }    

        public string CorreoElectronico { get; set; }

        public string contrasena { get; set; }
    }
}
