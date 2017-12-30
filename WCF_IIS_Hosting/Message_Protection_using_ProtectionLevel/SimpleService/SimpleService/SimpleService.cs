using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SimpleService : ISimpleService
    {
        public string GetMessageWithNoProtection()
        {
            return "Message without signature or encryption";
        }

        public string GetSignedMessage()
        {
            return "Message with signature and no encryption";
        }

        public string GetSignedAndEncryptedMessage()
        {
            return "Message with signature and encryption";
        }
    }
}
