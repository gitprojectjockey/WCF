using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESoft.EServices.ServiceTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (EmployeeManagerService.EmployeeClient ec = new EmployeeManagerService.EmployeeClient())
                {
                    List<EmployeeManagerService.Employee> employees = new List<EmployeeManagerService.Employee>();
                    var e = ec.GetEmployeeManagers(5);
                }
            }
            catch(Exception ex)
            {
                string x = ex.Message;
            }
        }
    }
}
