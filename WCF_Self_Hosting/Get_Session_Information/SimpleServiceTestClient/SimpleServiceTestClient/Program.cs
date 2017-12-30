using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleServiceTestClient
{
    class Program
    {
        static void Main()
        {
            using (SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient())
            {
                Console.WriteLine("Service Sesion Id is {0}", client.GetSessionId());
                Console.WriteLine("Client Sesion Id is {0}", client.InnerChannel.SessionId);
                Console.WriteLine("Hit Enter To Exit...");
                Console.Read();
            }
        }
    }
}
