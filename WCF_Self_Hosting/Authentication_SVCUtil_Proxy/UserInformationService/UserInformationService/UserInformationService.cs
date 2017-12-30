using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserInformationService
{
    public class UserInformationService : IUserInformationService
    {
        public User GetUserInformation()
        {
            User user = new User();
            user.IsAuthentic = ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated;
            user.Name = ServiceSecurityContext.Current.PrimaryIdentity.Name;
            user.AuthenticationType = ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType;
            return user;
        }
    }
}
