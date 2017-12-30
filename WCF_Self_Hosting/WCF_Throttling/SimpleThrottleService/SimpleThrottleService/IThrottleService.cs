using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleThrottleService
{
    [ServiceContract]
    public interface IThrottleService
    {
        [OperationContract(IsOneWay = true)]
        void DoWork();
    }
}

