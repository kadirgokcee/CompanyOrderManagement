using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Order : Entity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public string FirmaId { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
