using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Ecommerce.DTO.Commands
{
    public class DeleteOrderCommand
    {
        public Guid Id { get; set; }
    }
}
