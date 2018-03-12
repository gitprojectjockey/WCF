using System;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace Postal.Catalog.WebHost
{
    public class PostalServicesHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType,Uri[] baseAddresses)
        {
            //All the custom factory does is return a new instance  
            //of our custom host class for IIS and WAS hosting. The bulk of the custom logic should  
            //live in the custom host (as opposed to the factory)   
            //for maximum reuse value outside of the IIS/WAS hosting environment.  

            if (serviceType == typeof(Services.PostalStateCodeManager))
            {
                return new PostalStateCodeManagerServiceHost(serviceType, baseAddresses);
            }
            else if (serviceType == typeof(Services.PostalZipCodeManager))
            {
                return new PostalZipCodeManagerServiceHost(serviceType, baseAddresses);
            }
            else { return null; }
        }
    }
}