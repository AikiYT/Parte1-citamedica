

namespace CitasMedicaApp.Domain.Result
{
    public class OperationRessult
    {
        public OperationRessult() 
        { 
            this.Success = true;
        }   
        public string? Message  { get; set; }


        public bool Success { get; set; }

        public  dynamic? Data { get; set; }

        


    }
}
