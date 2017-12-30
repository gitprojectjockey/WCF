using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace GeoLibrary.Services.Security
{
    public class CustomUserValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new FaultException(string.Format("Wrong username ({0}) or password ", userName));
            }

            if (!(userName == "BillyBob" && password == "TouchDown33") && !(userName == "dave" && password == "dave"))
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}
