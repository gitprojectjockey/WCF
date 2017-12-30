﻿using System;
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
            using (ServiceHost host = new ServiceHost(typeof(UserInformationService.UserInformationService)))
            {
                host.Open();
                Console.WriteLine("Host was opened at {0}", DateTime.Now);
                Console.Read();
            }
        }
    }
}
