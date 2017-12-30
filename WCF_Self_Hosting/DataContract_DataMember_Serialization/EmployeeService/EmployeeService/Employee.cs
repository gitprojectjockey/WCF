﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
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



    [System.Runtime.Serialization.DataContract(Namespace="http://Esoft.Eservices.EmployeeService")]
    public class Employee
    {
        int _Id;
        string _name;
        string _gender;
        DateTime _birthDate;
        int _type;
        int? _salary;
        int? _hourlyPay;
        int? _hours;


        [System.Runtime.Serialization.DataMember(Order=1,IsRequired=true)]
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
        [System.Runtime.Serialization.DataMember(Order = 5, IsRequired = true)]
        public int Type
        {
            get { return _type; }
            set {_type = value; }
        }
        [System.Runtime.Serialization.DataMember(Order = 5, IsRequired = true)]
        public int? Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        [System.Runtime.Serialization.DataMember(Order = 5, IsRequired = true)]
        public int? HourlyPay
        {
            get { return _hourlyPay; }
            set { _hourlyPay = value; }
        }
        [System.Runtime.Serialization.DataMember(Order = 5, IsRequired = true)]
        public int? Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
    }
}
