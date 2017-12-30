using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserInformationService
{
    [ServiceContract(Namespace = "http://ESoft.EServices.UserInformationService")]
    public interface IUserInformationService
    {
        [OperationContract]
        User GetUserInformation();       
    }
}
