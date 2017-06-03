using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAccountant.Model.Domain;
using log4net.Repository.Hierarchy;
using NHibernate;
using Microsoft.Extensions.Logging;
using NHibernate.Exceptions;

namespace HomeAccountant.Repository
{
    public class UserDataRepository
    {
        #region Get one user by username
        public UserData GetByUserName(string userName)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Trace.TraceInformation($"----------- GetByUserName -- Start query for: {userName} ------------");
                var result = session.QueryOver<UserData>()
                    .Where(x => x.UserName == userName)
                    .SingleOrDefault();
                Trace.TraceInformation($"Queried object: {result}");
                return result;
            }
        }
        #endregion

        #region Gett all user from userData table
        public List<UserData> GetAllUser()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Trace.TraceInformation($"----------- GetAllUser -- Start query for all users ------------");
                var result = session.QueryOver<UserData>().List().ToList();
                Trace.TraceInformation($"Queried List: {result}");
                return result;
            }
        }
        #endregion

        #region Save New User
        public UserData SaveNewUser(string userName)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    Trace.TraceInformation($"----------- SaveNewUser -- Saving new user with username: {userName} ------------");
                    UserData newUser = new UserData() { UserName = userName };
                    session.Save(newUser);
                    try
                    {
                        transaction.Commit();
                    }
                    catch (GenericADOException e)
                    {
                        Trace.TraceError(e.Message);
                        throw;
                    }
                    return newUser;
                }
            }
        }
        #endregion
    }
}
