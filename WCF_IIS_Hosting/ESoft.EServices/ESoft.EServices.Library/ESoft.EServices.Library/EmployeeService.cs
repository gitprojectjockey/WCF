using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ESoft.EServices.Library
{
    public class EmployeeService : IEmployee
    {
        public List<Employee> GetEmployeeManagers(int businessEntityID)
        {
            DataTable data = ESoft.EServices.Data.Employee.GetEmployeeManagersByBusinessEntity(businessEntityID, ConnectionStringHelper.GetConnectionString()).Tables[0];
            List<Employee> employees = data.AsEnumerable().Select(r => new Employee
             {
                 BusinessEntityID = (int)r["BusinessEntityID"],
                 FirstName = (string)r["FirstName"],
                 LastName = (string)r["LastName"],
                 ManagerFistName = (string)r["ManagerFirstName"],
                 ManagerLastName = (string)r["ManagerLastName"]
             }).ToList<Employee>();

            return employees;
        }
    }
}
