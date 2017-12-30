using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

namespace SimpleService
{
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string GetMessageWithNoProtection();

        [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
        string GetSignedMessage();

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        string GetSignedAndEncryptedMessage();
    }
}
