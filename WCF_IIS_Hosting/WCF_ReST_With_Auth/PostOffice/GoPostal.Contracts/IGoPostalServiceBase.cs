using System.ServiceModel;

namespace GoPostal.Contracts
{
    [ServiceContract(Namespace = "http://www.goPostal.com/postalServices")]
    public interface IGoPostalServiceBase
    {
        [OperationContract]
        string Ping(string echo);
    }
}
