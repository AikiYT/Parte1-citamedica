using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicaApp.Domain.Entities.Security
{
    public class Rol
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public List<string> Permisos { get; set; }


        public DateTime FechaCreacion { get; set; }


        public bool EstaActivo { get; set; }


        public Rol()
        {
            Permisos = new List<string>();
            FechaCreacion = DateTime.Now;
            EstaActivo = true;


            // faltan cosas segun dijo el profesor debemos completarla esta clase
        }
    }
}
