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
        static void Main(string[] args)
        {
            Console.Title = "Throttle Host";
            using (ServiceHost host = new ServiceHost(typeof(SimpleThrottleService.ThrottleService)))
            {
                host.Open();
                Console.WriteLine("Host was open at {0}", DateTime.Now);
                Console.Read();
            }
        }
    }
}
