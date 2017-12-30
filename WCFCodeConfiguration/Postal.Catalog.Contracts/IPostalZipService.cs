using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Postal.Catalog.Contracts
{
    [ServiceContract(Namespace = "http://www.goPostal.com/postalServices")]
    public interface IPostalZipService : IPostalServiceBase
    {
        [OperationContract]
        ZipCodeData GetZipCode(string zip);

        [OperationContract(Name = "GetZipsByState")]
        IEnumerable<ZipCodeData> GetZips(string state);

        [OperationContract(Name = "GetZipsForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);
    }
}
