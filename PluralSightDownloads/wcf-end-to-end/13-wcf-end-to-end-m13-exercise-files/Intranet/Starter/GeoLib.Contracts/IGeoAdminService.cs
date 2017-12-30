using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;

namespace GeoLib.Contracts
{
    [ServiceContract]
    public interface IGeoAdminService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateZipCity(string zip, string city);

        [OperationContract(Name = "UpdateZipCityBatch")]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateZipCity(IEnumerable<ZipCityData> zipCityData);
    }
}
