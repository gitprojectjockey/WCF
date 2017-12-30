using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Client
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Throttle Client";
            using (ThrottleService.ThrottleServiceClient client = new ThrottleService.ThrottleServiceClient())
            {
                Console.WriteLine("Processing will start in 5 seconds...");
                Thread.Sleep(5000);
                for (int i = 1; i <= 100; i++ )
                {
                    Thread thread = new Thread(client.DoWork);
                    thread.Start();
                    Console.WriteLine("Calling Service Host {0} Time(s)",i);
                }
                Console.WriteLine("Hit enter to exit...");
                Console.Read();
            }
        }
    }
}
