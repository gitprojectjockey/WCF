using Postal.Catalog.Contracts;
using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;

namespace Postal.Catalog.WebHost
{
    public class PostalStateCodeManagerServiceHost : ServiceHost
    {
        public PostalStateCodeManagerServiceHost(Type serviceType, params Uri[] baseAddresses) : base(serviceType, baseAddresses) { }
        protected override void ApplyConfiguration()
        {
            base.ApplyConfiguration();

            WSHttpBinding postalServiceBinding = new WSHttpBinding();

            postalServiceBinding.Security.Mode = SecurityMode.Message;
            postalServiceBinding.MaxReceivedMessageSize = 2097152;
            postalServiceBinding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;
            postalServiceBinding.Security.Message.NegotiateServiceCredential = false;
            postalServiceBinding.ReliableSession.Enabled = true;
            postalServiceBinding.TransactionFlow = true;
            postalServiceBinding.SendTimeout = new TimeSpan(0, 5, 0);
            postalServiceBinding.ReaderQuotas.MaxArrayLength = 5000;
            postalServiceBinding.ReaderQuotas.MaxBytesPerRead = 4096;
            postalServiceBinding.ReaderQuotas.MaxNameTableCharCount = 16384;
            postalServiceBinding.ReaderQuotas.MaxDepth = 32;

            this.Credentials.ClientCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.ChainTrust;
            this.Credentials.ServiceCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.TrustedPeople, X509FindType.FindBySubjectName, "Eric-PC");
            this.Credentials.UserNameAuthentication.UserNamePasswordValidationMode = UserNamePasswordValidationMode.Custom;
            this.Credentials.UserNameAuthentication.CustomUserNamePasswordValidator = new CustomUserNamePasswordValidator();

            AddServiceEndpoint(typeof(IPostalStateService), postalServiceBinding, "");

            ServiceMetadataBehavior mexBehavior = Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (mexBehavior == null)
            {
                mexBehavior = new ServiceMetadataBehavior();
                Description.Behaviors.Add(mexBehavior);
            }
            else
            {
                //Metadata behavior has already been configured,   
                //so we do not have any work to do.  
                return;
            }

            foreach (Uri baseAddress in this.BaseAddresses)
            {
                if (baseAddress.Scheme == Uri.UriSchemeHttp)
                {
                    mexBehavior.HttpGetEnabled = true;
                    this.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName,
                                            MetadataExchangeBindings.CreateMexHttpBinding(),
                                            "mex");
                }
                else if (baseAddress.Scheme == Uri.UriSchemeHttps)
                {
                    mexBehavior.HttpsGetEnabled = true;
                    this.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName,
                                            MetadataExchangeBindings.CreateMexHttpsBinding(),
                                            "mex");
                }
            }
        }
    }
}