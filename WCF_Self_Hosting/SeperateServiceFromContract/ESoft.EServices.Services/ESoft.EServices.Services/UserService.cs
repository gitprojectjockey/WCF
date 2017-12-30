using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ESoft.EServices.Services
{
    public class UserService : ESoft.EServices.ServiceContracts.IUserService
    {
        public ESoft.EServices.ServiceContracts.User GetUserInformation()
        {
            ESoft.EServices.ServiceContracts.User user = new ESoft.EServices.ServiceContracts.User();
            user.IsAuthentic = ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated;
            user.Name = ServiceSecurityContext.Current.PrimaryIdentity.Name;
            user.AuthenticationType = ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType;
            return user;
        }
    }
}
