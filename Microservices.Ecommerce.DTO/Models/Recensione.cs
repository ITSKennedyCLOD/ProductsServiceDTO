using System.Text.Json.Serialization;

namespace Microservices.Ecommerce.DTO
{
    public class Recensione
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Cliente { get; set; }

        public int Voto { get; set; }

        public string Nota { get; set; }

        public int IdOrdineProdotto { get; set; }
    }
}
