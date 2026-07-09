using System.Text.Json.Serialization;

namespace Sales.API.Dtos
{
    public class ResponseDto<T>
    {
        [JsonIgnore]
        public int StatusCode { get; set; }
        public bool Status { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}