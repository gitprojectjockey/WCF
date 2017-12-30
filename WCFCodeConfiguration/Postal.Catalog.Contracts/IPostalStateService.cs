using System.Collections.Generic;
using System.ServiceModel;

namespace Postal.Catalog.Contracts
{
    [ServiceContract(Namespace = "http://www.goPostal.com/postalServices")]
    public interface IPostalStateService : IPostalServiceBase
    {
        [OperationContract]
        IEnumerable<string> GetStates(bool primaryOnly);

        [OperationContract]
        StateCodeData GetStateCode(string state);
    }
}
