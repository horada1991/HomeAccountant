using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAccountant.Model.Domain;

namespace HomeAccountant.Model
{
    public class SessionStorage
    {
        public UserData LoggedInUser { get; set; }
    }
}
