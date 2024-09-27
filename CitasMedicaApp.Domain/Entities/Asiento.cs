using System;


namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Asiento
    {
       public int IdAsiento { get; set; }  

       public int IdBus { get; set; }

        public int NumeroPiso { get; set; } 

        public int NumeroAsiento { get; set; }

        public DateTime FechaCreacion { get; set; } 

        public DateTime? FechaModificacion { get; set; }    

        public DateTime? UsuarioModificacion { get; set; }  

        public bool Estatus {  get; set; }  





    }
}
