using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EmployeeService
{
    //I added this class so that we can customize the SOAP messages via MESSAGE CONTRACT Attributes that are returned and recieved from the service.
    //This class is just used to hold a copy of the current employee/full time employee/part time employee parameters so they will show up in the SOAP message
    //in a way I choose. For instance I could add an authentication key in the soap header and I can name the soap sections the way I want.

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeRequestObject", WrapperNamespace = "http://ESoft/EServices/Employee")]
    public class EmployeeRequestObject
    {
        [MessageHeader(Namespace = "http://ESoft/EServices/Employee")]
        public string LicenceKey { get; set; }

        [MessageBodyMember(Namespace = "http://ESoft/EServices/Employee")]
        public int EmployeeID { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeResponseObject", WrapperNamespace = "http://ESoft/EServices/Employee")]
    public class EmployeeResponseObject
    {
        public EmployeeResponseObject()
        {

        }

        public EmployeeResponseObject(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Gender = employee.Gender;
            this.DOB = employee.BirthDate;
            this.Type = employee.Type;
            if (employee.Type == Employee.PayType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).HoursWorked;
            }
        }

        [MessageBodyMember(Order = 1, Namespace = "http://ESoft/EServices/Employee")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://ESoft/EServices/Employee")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://ESoft/EServices/Employee")]
        public string Gender { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://ESoft/EServices/Employee")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://ESoft/EServices/Employee")]
        public Employee.PayType Type { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://ESoft/EServices/Employee")]
        public int? AnnualSalary { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://ESoft/EServices/Employee")]
        public int? HourlyPay { get; set; }

        [MessageBodyMember(Order = 8, Namespace = "http://ESoft/EServices/Employee")]
        public int? HoursWorked { get; set; }
    }



    ///NOTE! NOTE! NOTE!
    //After 3.5 service pack one classes used for WCF messaging were serialized by default so you did not need to add the DataContract or DataMember attibutes.
    //We should still use DataContract or DataMember regardless because it gives much more control on what members and how those members are serialized.
    //It is best practice.


    //BELOW IS THE SECTION IN THE WSDL(Web Services Description Language)DOCUMENT THAT LETS YOU VIEW YOUR OBJECTS AFTER THEY ARE SERIALIZED.
    //PAST THIS IMPORT (<xsd:import schemaLocation="http://10.0.0.3:8080/?xsd=xsd2" namespace="http://Esoft.Eservices.EmployeeService"/>)
    //INTO THE BROWSER.

    //<xsd:schema targetNamespace="http://tempuri.org/Imports">
    //    <xsd:import schemaLocation="http://10.0.0.3:8080/?xsd=xsd0" namespace="http://tempuri.org/"/>
    //    <xsd:import schemaLocation="http://10.0.0.3:8080/?xsd=xsd1" namespace="http://schemas.microsoft.com/2003/10/Serialization/"/>
    //    <xsd:import schemaLocation="http://10.0.0.3:8080/?xsd=xsd2" namespace="http://Esoft.Eservices.EmployeeService"/>
    //</xsd:schema>

    //NOTE! NOTE! NOTE!
    //By using the KnownType Attribute on the service class we are able to use classes that are related via inheritance in our
    //WCF Service Contracts


    [System.Runtime.Serialization.KnownType(typeof(FullTimeEmployee))]
    [System.Runtime.Serialization.KnownType(typeof(PartTimeEmployee))]
    [System.Runtime.Serialization.DataContract(Namespace = "http://Esoft.Eservices.EmployeeService")]
    public class Employee
    {
        int _Id;
        string _name;
        string _gender;
        DateTime _birthDate;

        [System.Runtime.Serialization.DataMember(Order = 1, IsRequired = true)]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        [System.Runtime.Serialization.DataMember(Order = 2, IsRequired = false)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [System.Runtime.Serialization.DataMember(Order = 3, IsRequired = false)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [System.Runtime.Serialization.DataMember(Order = 4, IsRequired = false)]
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        [System.Runtime.Serialization.DataMember(Order = 5)]
        public PayType Type { get; set; }

        public enum PayType
        {
            FullTimeEmployee = 1,
            PartTimeEmployee = 2
        }
    }
}
