using System.ServiceModel;

namespace Postal.Catalog.Contracts
{
    [ServiceContract(Namespace = "http://www.goPostal.com/postalServices")]
    public interface IPostalServiceBase
    {
       [OperationContract]
       string Ping(string echo);
    }
}
