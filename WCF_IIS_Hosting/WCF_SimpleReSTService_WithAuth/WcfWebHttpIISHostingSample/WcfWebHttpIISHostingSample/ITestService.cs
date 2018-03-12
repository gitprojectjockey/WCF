using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfWebHttpIISHostingSample
{
    [ServiceContract]
    public interface ITestService
    {
        [WebInvoke(Method = "GET", UriTemplate = "/Data/{data}")]
        List<string> GetData(string data);
    }
}
