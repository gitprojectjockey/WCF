using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace MtomServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(MtomService.MtomService)))
            {
                host.Open();
                Console.WriteLine(string.Format("Host was opened at {0}", DateTime.Now));
                Console.WriteLine("Press enter to exit...");
                Console.Read();
            }
        }
    }
}
