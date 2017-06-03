using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant.Model.Domain
{
    public class Account
    {
        public virtual Guid Id { get; set; }
        public virtual decimal AvailableFunds { get; set; }
        public virtual ISet<SavingsType> SavingsTypes { get; set; }
        public virtual UserData UserData { get; set; }
    }
}
