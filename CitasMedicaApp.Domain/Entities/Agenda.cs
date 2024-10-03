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
    [Table("Nombre de la tabla que no tenemos :c", Schema = "dbo")]  // esto debemos ponerselo a cada una de las tablas que tenemos en la bd para que sepa a que llamar en la bd cuando busquemos agenda por ejemplo
    public sealed class Agenda : BaseEntity
    {
        [Key] // esto es para especificar quien es el primary key por si nos da error con eso
        public List<Cita> Citas { get; set; }

        public List<Horario> DisponibilidadDoctor { get; set; }
    }
}
