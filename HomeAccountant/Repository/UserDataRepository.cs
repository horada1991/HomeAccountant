using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAccountant.Model.Domain;
using NHibernate;

namespace HomeAccountant.Repository
{
    public class UserDataRepository
    {
        public UserData GetByUserName(string userName)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = session.QueryOver<UserData>()
                    .Where(x => x.UserName == userName)
                    .SingleOrDefault();
                return result ?? new UserData();
            }
        }
    }
}
