﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ToothPickService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ToothPick", Namespace="http://ESoft.EServices.ToothPickService.ToothPick")]
    [System.SerializableAttribute()]
    public partial class ToothPick : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FlavorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BoxCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BoxCostField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCode {
            get {
                return this.ProductCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductCodeField, value) != true)) {
                    this.ProductCodeField = value;
                    this.RaisePropertyChanged("ProductCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Length {
            get {
                return this.LengthField;
            }
            set {
                if ((this.LengthField.Equals(value) != true)) {
                    this.LengthField = value;
                    this.RaisePropertyChanged("Length");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Flavor {
            get {
                return this.FlavorField;
            }
            set {
                if ((object.ReferenceEquals(this.FlavorField, value) != true)) {
                    this.FlavorField = value;
                    this.RaisePropertyChanged("Flavor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int BoxCount {
            get {
                return this.BoxCountField;
            }
            set {
                if ((this.BoxCountField.Equals(value) != true)) {
                    this.BoxCountField = value;
                    this.RaisePropertyChanged("BoxCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public decimal BoxCost {
            get {
                return this.BoxCostField;
            }
            set {
                if ((this.BoxCostField.Equals(value) != true)) {
                    this.BoxCostField = value;
                    this.RaisePropertyChanged("BoxCost");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ESoft.EServices.ToothPickService", ConfigurationName="ToothPickService.IToothPickService")]
    public interface IToothPickService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ESoft.EServices.ToothPickService/IToothPickService/GetToothPickList", ReplyAction="http://ESoft.EServices.ToothPickService/IToothPickService/GetToothPickListRespons" +
            "e")]
        Client.ToothPickService.ToothPick[] GetToothPickList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ESoft.EServices.ToothPickService/IToothPickService/GetToothPickList", ReplyAction="http://ESoft.EServices.ToothPickService/IToothPickService/GetToothPickListRespons" +
            "e")]
        System.Threading.Tasks.Task<Client.ToothPickService.ToothPick[]> GetToothPickListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToothPickServiceChannel : Client.ToothPickService.IToothPickService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToothPickServiceClient : System.ServiceModel.ClientBase<Client.ToothPickService.IToothPickService>, Client.ToothPickService.IToothPickService {
        
        public ToothPickServiceClient() {
        }
        
        public ToothPickServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ToothPickServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToothPickServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToothPickServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ToothPickService.ToothPick[] GetToothPickList() {
            return base.Channel.GetToothPickList();
        }
        
        public System.Threading.Tasks.Task<Client.ToothPickService.ToothPick[]> GetToothPickListAsync() {
            return base.Channel.GetToothPickListAsync();
        }
    }
}
