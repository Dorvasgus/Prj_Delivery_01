using Microsoft.AspNetCore.Mvc;

namespace Delivery.DTOs
{
    public class ResponsesDTO<T> : ActionResult
    {
        public T? value { get; set; }
    }

    public class ResponseListDTO<T>
    {
        public int pagina { get; set; }
        public int total { get; set; }
        public int cantidad { get; set; }
        public List<T>? valores { get; set; }
    }
    public class ResponseDTO<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public T? value { get; set; }
    }



    public class ResponseError
    {
        public ResponseError(int StatusCode, string message)
        {
            this.Message = message;
            this.StatusCode = StatusCode;
        }




        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public ObjectResult GetObjectResult()
        {
            return new ObjectResult(this)
            {
                StatusCode = StatusCode

            };
        }





    }

}
