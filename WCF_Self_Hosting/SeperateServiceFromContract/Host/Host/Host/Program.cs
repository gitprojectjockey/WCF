using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Host
{
    class Program
    {
        static void Main()
        {
            ServiceHost userServiceHost = new ServiceHost(typeof(ESoft.EServices.Services.UserService));
            userServiceHost.Open();
            Console.WriteLine("User service host opened at {0}", DateTime.Now);
            ServiceHost mtomServiceHost = new ServiceHost(typeof(ESoft.EServices.Services.MtomService));
            mtomServiceHost.Open();
            Console.WriteLine("Mtom service host opened at {0}", DateTime.Now);
            Console.Read();
            if (userServiceHost != null) {userServiceHost.Close();}
            if (mtomServiceHost != null) {mtomServiceHost.Close();}
        }
    }
}
