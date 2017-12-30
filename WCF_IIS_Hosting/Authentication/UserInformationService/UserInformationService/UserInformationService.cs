using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserInformationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
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
