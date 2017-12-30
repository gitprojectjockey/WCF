using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class SimpleService : ISimpleService
    {
        public string GetSessionId()
        {
            return OperationContext.Current.SessionId;
        }
    }
}
