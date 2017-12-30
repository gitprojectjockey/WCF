using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetPublicInformation()
        {
            return "This is public informtaion and is available over HTTP to all general public outside the firewall.";
        }

        public string GetConfidentialInformation()
        {
            return "This is confidential information and only available over TCP behind the company filewall";
        }
    }
}
