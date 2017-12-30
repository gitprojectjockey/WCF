using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Threading;

namespace ToothPickService
{
    public class CustomPrincipal : IPrincipal
    {
        //NOTE: Make sure you reference this project using WSDL and Not MEX
        //MEX reference will make this Custom Principal code execute with no ID which will raise exception an prevent proxy reference from being created.
        IIdentity _identity;
        string[]  _roles;

        public CustomPrincipal(IIdentity identity)
        {
            _identity = identity;
        }

        public static CustomPrincipal Current
        {
            get
            {
                return Thread.CurrentPrincipal as CustomPrincipal;
            }
        }

        public string[] Roles
        {
            get
            {
                EnsureRoles();
                return _roles;
            }
        }

        public bool IsInRole(string role)
        {
            EnsureRoles();
            return _roles.Contains(role);
        }

        protected virtual void EnsureRoles()
        {
            if (_identity.Name == "dave")
            {
                _roles = new string[1] { "ADMIN" };
            }
            else
            {
                _roles = new string[1] { "USER" };
            }
        }

        public IIdentity Identity
        {
            get { return _identity; }
        }
    }
}
