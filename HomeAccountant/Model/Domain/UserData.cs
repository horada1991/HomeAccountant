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

        public override string ToString()
        {
            string formattedString = "";
            formattedString += $"ID: {Id}\n";
            formattedString += $"UserName: {UserName}\n";
            if (Account != null)
            {
                formattedString += $"Account Id: {Account.Id}\n";
            }
            else
            {
                formattedString += $"None";
            }

            return formattedString;
        }
    }
}
