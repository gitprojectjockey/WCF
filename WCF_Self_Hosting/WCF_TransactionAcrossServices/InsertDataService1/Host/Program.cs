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

            ServiceHost host1 = new ServiceHost(typeof(InsertDataService1.InsertDataService1));
            host1.Open();
            Console.WriteLine("Service 1 opened at {0} ", DateTime.Now);
            ServiceHost host2 = new ServiceHost(typeof(InsertDataService2.InsertDataService2));
            Console.WriteLine("Service 2 opened at {0} ", DateTime.Now);
            host2.Open();
           
            Console.Read();
        }
    }
}
