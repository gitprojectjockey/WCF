using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.ServiceModel;
using System.IdentityModel.Tokens;
using System.IdentityModel.Claims;

namespace ToothPickService
{
    public class CustomServiceAuthorizationManager : ServiceAuthorizationManager
    {
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
          //  bool baseResult = base.CheckAccessCore(operationContext);
          //  if (operationContext.ServiceSecurityContext.IsAnonymous)
          //  { return true; }
          //  //Extract the identity token of the current context user making the call to this service 
          //  IIdentity Identity = operationContext.ServiceSecurityContext.PrimaryIdentity;
          //  //Prior to proceeding, throw an exception if the user has not been authenticated at all 
          //  if (!Identity.IsAuthenticated)
          //  {
          //      throw new SecurityTokenValidationException
          //      ("Service Authorization can not be done for unauthenticated user.");


               
          //  }
          //  if (operationContext.Host.Authorization.RoleProvider != null)
          //  {
          //      //Get the instance of Role provider from operation context 
          //      //and get the roles of associated identity
          //      string[] roles = operationContext.Host.Authorization.RoleProvider.GetRolesForUser
          //             (Identity.Name);
          //      // You can put your logic here to retrieve expected role based on 
          //      // method called or any other criteria.
          //      // I hardcoded the role here for simplicity
          //      if (roles == null || roles.Length == 0 || !roles.Contains("MyRole"))
          //      {
          //          throw new System.ServiceModel.Security.SecurityAccessDeniedException
          //          ("User is not authorized. Identity : " + Identity.Name);
          //      }
          //  }
          //  else
          //  {
          //      throw new System.ServiceModel.Security.SecurityAccessDeniedException
          //("Service Authorization failed because role provider is missing or it is not configured properly.");
          //  }
            //return baseResult;
            return true;
        }
    }
}
