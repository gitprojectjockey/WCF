﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeServiceTestClient.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://Esoft.Eservices.EmployeeService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(EmployeeServiceTestClient.EmployeeService.FullTimeEmployee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(EmployeeServiceTestClient.EmployeeService.PartTimeEmployee))]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EmployeeServiceTestClient.EmployeeService.EmployeePayType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public EmployeeServiceTestClient.EmployeeService.EmployeePayType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FullTimeEmployee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class FullTimeEmployee : EmployeeServiceTestClient.EmployeeService.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AnnualSalaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> AnnualSalary {
            get {
                return this.AnnualSalaryField;
            }
            set {
                if ((this.AnnualSalaryField.Equals(value) != true)) {
                    this.AnnualSalaryField = value;
                    this.RaisePropertyChanged("AnnualSalary");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartTimeEmployee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class PartTimeEmployee : EmployeeServiceTestClient.EmployeeService.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> HourlyPayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> HoursWorkedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> HourlyPay {
            get {
                return this.HourlyPayField;
            }
            set {
                if ((this.HourlyPayField.Equals(value) != true)) {
                    this.HourlyPayField = value;
                    this.RaisePropertyChanged("HourlyPay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> HoursWorked {
            get {
                return this.HoursWorkedField;
            }
            set {
                if ((this.HoursWorkedField.Equals(value) != true)) {
                    this.HoursWorkedField = value;
                    this.RaisePropertyChanged("HoursWorked");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee.PayType", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    public enum EmployeePayType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FullTimeEmployee = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartTimeEmployee = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        EmployeeServiceTestClient.EmployeeService.Employee GetEmployee(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeServiceTestClient.EmployeeService.Employee> GetEmployeeAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SetEmployeeResponse")]
        void SetEmployee(EmployeeServiceTestClient.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SetEmployeeResponse")]
        System.Threading.Tasks.Task SetEmployeeAsync(EmployeeServiceTestClient.EmployeeService.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : EmployeeServiceTestClient.EmployeeService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<EmployeeServiceTestClient.EmployeeService.IEmployeeService>, EmployeeServiceTestClient.EmployeeService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EmployeeServiceTestClient.EmployeeService.Employee GetEmployee(int Id) {
            return base.Channel.GetEmployee(Id);
        }
        
        public System.Threading.Tasks.Task<EmployeeServiceTestClient.EmployeeService.Employee> GetEmployeeAsync(int Id) {
            return base.Channel.GetEmployeeAsync(Id);
        }
        
        public void SetEmployee(EmployeeServiceTestClient.EmployeeService.Employee employee) {
            base.Channel.SetEmployee(employee);
        }
        
        public System.Threading.Tasks.Task SetEmployeeAsync(EmployeeServiceTestClient.EmployeeService.Employee employee) {
            return base.Channel.SetEmployeeAsync(employee);
        }
    }
}