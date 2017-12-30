using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloSimpleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HelloSimpleService : IHelloSimpleService
    {
        public string GetHelloMessage(string name)
        {
            return string.Format("Hello {0} from WCF wsHttp Transport Service.", name);
        }
    }
}
