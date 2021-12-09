using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Ecommerce.DTO.Commands
{
    public class NewProductCommands
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrizione { get; set; }

        public double Aliquota { get; set; }

        public string Marca { get; set; }

        public double Prezzo { get; set; }
    }
}
