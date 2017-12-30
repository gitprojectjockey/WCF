using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{

    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        EmployeeResponseObject GetEmployee(EmployeeRequestObject employeeRequest);

        [OperationContract]
        void SetEmployee(Employee employee);
    }
}
