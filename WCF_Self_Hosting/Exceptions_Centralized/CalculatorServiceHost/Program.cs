using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace CalculatorServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService.CalculatorService)))
            {
               host.Open();
               Console.WriteLine(string.Format("Service opened at {0}", DateTime.Now));
               Console.Read();
            }
        }
    }
}
