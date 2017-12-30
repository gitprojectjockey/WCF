using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InsertDataService1
{
    
    [ServiceContract]
    public interface IInsertDataService1
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void SetData(string connectionString);
    }
}
