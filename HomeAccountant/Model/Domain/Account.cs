using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant.Model.Domain
{
    class Account
    {
        public virtual Guid Id { get; set; }
        public virtual decimal AvailableFunds { get; set; }
        public ISet<SavingsType> savingsTypes = new HashSet<SavingsType>();

        public ISet<SavingsType> SavingsTypes
        {
            get { return savingsTypes; }
            set { savingsTypes = value; }
        }
    }
}
