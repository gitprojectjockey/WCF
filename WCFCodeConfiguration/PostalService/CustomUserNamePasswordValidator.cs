using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace Postal.Catalog.WebHost
{
    public class CustomUserNamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new FaultException(string.Format("Invalid username ({0}) or password ", userName));
            }

            //Here we would go to an Identity Store/Database to validate the user name and password

            if (!(userName == "TangoTango" && password == "TangoDown") && !(userName == "dave" && password == "dave"))
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}