using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Policy;
using System.IdentityModel.Claims;
using System.Security.Principal;

namespace ToothPickService
{
    public class AuthorizationPolicy : IAuthorizationPolicy
    {
        Guid _id = Guid.NewGuid();

        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            object obj;
            if (!evaluationContext.Properties.TryGetValue("Identities", out obj))
            {
                throw new Exception("No Identity found");
            }

            IList<IIdentity> identities = obj as IList<IIdentity>;
            if (identities == null || identities.Count <= 0)
            {
                throw new Exception("No Identity found");
            }
           
            evaluationContext.Properties["Principal"] = new CustomPrincipal(identities[0] as IIdentity);

            return true;
        }

        public System.IdentityModel.Claims.ClaimSet Issuer
        {
            get { return ClaimSet.System; }
        }

        public string Id
        {
            get { return _id.ToString(); }
        }
    }
}
