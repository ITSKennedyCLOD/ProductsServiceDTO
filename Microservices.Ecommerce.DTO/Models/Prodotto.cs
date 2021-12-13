using System.Text.Json.Serialization;

namespace Microservices.Ecommerce.DTO
{
    public class Prodotto
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrizione { get; set; }

        public int Aliquota { get; set; }

        public string Marca { get; set; }

        public double Prezzo { get; set; }
    }
}
