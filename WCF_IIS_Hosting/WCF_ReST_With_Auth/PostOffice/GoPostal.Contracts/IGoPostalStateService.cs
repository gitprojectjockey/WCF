using System.Collections.Generic;
using System.ServiceModel;

namespace GoPostal.Contracts
{
    [ServiceContract(Namespace = "http://www.goPostal.com/postalServices")]
    public interface IGoPostalStateService : IGoPostalServiceBase
    {
        [OperationContract]
        IEnumerable<string> GetStates(bool primaryOnly);

        [OperationContract]
        StateCodeData GetStateCode(string stateAbbrev);
    }
}
