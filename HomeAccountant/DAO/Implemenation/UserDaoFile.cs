using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAccountant.Model.Domain;

namespace HomeAccountant.DAO.Implemenation
{
    class UserDaoFile : IUserDao
    {
        public User GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveNewUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
