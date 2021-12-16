using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Ecommerce.DTO.Commands
{
    public class ProductInOrder
    {
        public int ProductId { get; set; }
        public int OrderedQuantity { get; set; }
    }
}
