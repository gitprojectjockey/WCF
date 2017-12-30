using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InsertDataService2
{
    [ServiceContract]
    public interface IInsertDataService2
    {
        [OperationContract]
        void SetData(string connectionString);

    }
}
