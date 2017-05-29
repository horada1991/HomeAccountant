using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant.Model.Domain
{
    public class UserData
    {
        public virtual Guid Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual Account Account { get; set; }
    }
}
