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
        private static SessionStorage _instance;

        private SessionStorage() { }

        public static SessionStorage Instance => _instance ?? (_instance = new SessionStorage());


        public UserData LoggedInUser { get; set; }
    }
}
