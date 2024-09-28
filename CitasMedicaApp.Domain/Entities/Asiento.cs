using CitasMedicaApp.Domain.Base;
using System;


namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Asiento : BaseEntity
    {
       public int IdAsiento { get; set; }  

       public int IdBus { get; set; }

        public int NumeroPiso { get; set; } 

        public int NumeroAsiento { get; set; }


    }
}
