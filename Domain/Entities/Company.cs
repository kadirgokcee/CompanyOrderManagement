using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Company : Entity
    {

        public string CompanyName { get; set; }
        public bool ApprovalStatus { get; set; }
        public int OrderStartTimeHour { get; set; }
        public int OrderStartTimeMinute { get; set; }
        public int OrderFinishTimeHour { get; set; }
        public int OrderFinishTimeMinute { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
