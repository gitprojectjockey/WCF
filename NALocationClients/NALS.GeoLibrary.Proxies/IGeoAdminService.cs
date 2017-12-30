using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace NALS.GeoLibrary.Contracts
{
    [ServiceContract(Namespace = "http://www.geo.com/nalocationServices")]
    public interface IGeoAdminService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [FaultContract(typeof(GeoDatabaseUpdateFault))]
        [FaultContract(typeof(ApplicationException))]
        void UpdateStateCodeBatch(IEnumerable<StateCodeData> stateCodeBatch);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateZipCity(string zip, string city);

        [OperationContract(Name = "UpdateZipCityBatch")]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateZipCity(IEnumerable<ZipCityData> zipCityData);
    }
}
