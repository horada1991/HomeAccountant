using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant.Model.Domain
{
    class SavingsType
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual float Percentage { get; set; }
        public virtual decimal Savings { get; set; }
    }
}
