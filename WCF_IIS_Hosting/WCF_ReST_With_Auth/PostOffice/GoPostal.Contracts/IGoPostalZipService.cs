using System.Collections.Generic;
using System.ServiceModel;

namespace GoPostal.Contracts
{
    [ServiceContract(Namespace = "http://www.goPostal.com/postalServices")]
    public interface IGoPostalZipService
    {
        [OperationContract]
        ZipCodeData GetZipCode(string zip);

        [OperationContract(Name = "GetZipsByState")]
        IEnumerable<ZipCodeData> GetZips(string state);

        [OperationContract(Name = "GetZipsForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);
    }
}
