using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ESoft.EServices.Library
{
    
    [ServiceContract]
    public interface IEmployee
    {
       [OperationContract]
       List<Employee> GetEmployeeManagers(int businessEntityID);
    }
   
    [DataContract]
    public class Employee
    {
        int _businessEntityID;
        [DataMember]
        public int BusinessEntityID
        {
            get { return _businessEntityID; }
            set { _businessEntityID = value; }
        }

        string _firstName;
        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        string _lastName;
        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        string _managerFistName;
        [DataMember]
        public string ManagerFistName
        {
            get { return _managerFistName; }
            set { _managerFistName = value; }
        }

        string _managerLastName;
        [DataMember]
        public string ManagerLastName
        {
            get { return _managerLastName; }
            set { _managerLastName = value; }
        }
    }
}
