using System.Collections.Generic;
using System.ServiceModel;

namespace GeoLibrary.Contracts
{
    [ServiceContract(Namespace= "http://www.geo.com/nalocationServices")]
    public interface IGeoService
    {
        [OperationContract]
        ZipCodeData GetZipCode(string zip);

        [OperationContract]
        IEnumerable<string> GetStates(bool primaryOnly);

        [OperationContract(Name = "GetZipsByState")]
        IEnumerable<ZipCodeData> GetZips(string state);

        [OperationContract(Name = "GetZipsForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);

        [OperationContract]
        StateCodeData GetStateCode(string state);

        [OperationContract]
        IEnumerable<StateCodeData> GetStatesCodes(bool primaryOnly);
    }
}
