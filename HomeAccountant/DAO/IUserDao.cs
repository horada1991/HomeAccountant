using System;
using HomeAccountant.Model.Domain;

namespace HomeAccountant.DAO.Implemenation
{
    interface IUserDao
    {
        User GetUserByUserName(string userName);
        User GetUserById(Guid id);
        void SaveNewUser(User newUser);
        void DeleteUser(Guid id);
    }
}