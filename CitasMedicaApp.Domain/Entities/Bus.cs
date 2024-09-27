using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Bus : BaseEntity
    {
        public int IdBus { get; set; }  

        public int NumeroPlaca { get; set; }    

        public string Nombre { get; set; }  

        public int CapacidadPiso1 { get; set; } 

        public int CapacidadPiso2 { get; set; } 

        public bool Disponible { get; set; }    

        

    }
}
