using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ESoft.EServices.ServiceContracts
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetUserInformation();
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsAuthentic { get; set; }
        [DataMember]
        public string AuthenticationType { get; set; }
    }
}
