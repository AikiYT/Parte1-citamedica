

namespace CitasMedicaApp.Domain.Result
{
    public class OperationRessult
    {
        private bool v1;
        private string v2;

        public OperationRessult() 
        { 
            this.Success = true;
        }

        public OperationRessult(bool v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string? Message  { get; set; }


        public bool Success { get; set; }

        public  dynamic? Data { get; set; }

        


    }
}
