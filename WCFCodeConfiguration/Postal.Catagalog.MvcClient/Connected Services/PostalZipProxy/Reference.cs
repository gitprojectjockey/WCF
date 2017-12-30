﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Postal.Catagalog.MvcClient.PostalZipProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PostalDataBase", Namespace="http://www.goPostal.com/postalServices")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Postal.Catagalog.MvcClient.PostalZipProxy.ZipCityData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData))]
    public partial class PostalDataBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ZipCityData", Namespace="http://www.goPostal.com/postalServices")]
    [System.SerializableAttribute()]
    public partial class ZipCityData : Postal.Catagalog.MvcClient.PostalZipProxy.PostalDataBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPrimaryStateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPrimaryState {
            get {
                return this.IsPrimaryStateField;
            }
            set {
                if ((this.IsPrimaryStateField.Equals(value) != true)) {
                    this.IsPrimaryStateField = value;
                    this.RaisePropertyChanged("IsPrimaryState");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ZipCodeData", Namespace="http://www.goPostal.com/postalServices")]
    [System.SerializableAttribute()]
    public partial class ZipCodeData : Postal.Catagalog.MvcClient.PostalZipProxy.PostalDataBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.goPostal.com/postalServices", ConfigurationName="PostalZipProxy.IPostalZipService")]
    public interface IPostalZipService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalServiceBase/Ping", ReplyAction="http://www.goPostal.com/postalServices/IPostalServiceBase/PingResponse")]
        string Ping(string echo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalServiceBase/Ping", ReplyAction="http://www.goPostal.com/postalServices/IPostalServiceBase/PingResponse")]
        System.Threading.Tasks.Task<string> PingAsync(string echo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCode", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCodeResponse")]
        Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData GetZipCode(string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCode", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCodeResponse")]
        System.Threading.Tasks.Task<Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData> GetZipCodeAsync(string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByState", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByStateResponse")]
        Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[] GetZipsByState(string state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByState", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByStateResponse")]
        System.Threading.Tasks.Task<Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[]> GetZipsByStateAsync(string state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRange", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRangeResponse")]
        Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[] GetZipsForRange(string zip, int range);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRange", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRangeResponse")]
        System.Threading.Tasks.Task<Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[]> GetZipsForRangeAsync(string zip, int range);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPostalZipServiceChannel : Postal.Catagalog.MvcClient.PostalZipProxy.IPostalZipService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PostalZipServiceClient : System.ServiceModel.ClientBase<Postal.Catagalog.MvcClient.PostalZipProxy.IPostalZipService>, Postal.Catagalog.MvcClient.PostalZipProxy.IPostalZipService {
        
        public PostalZipServiceClient() {
        }
        
        public PostalZipServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PostalZipServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostalZipServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostalZipServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Ping(string echo) {
            return base.Channel.Ping(echo);
        }
        
        public System.Threading.Tasks.Task<string> PingAsync(string echo) {
            return base.Channel.PingAsync(echo);
        }
        
        public Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData GetZipCode(string zip) {
            return base.Channel.GetZipCode(zip);
        }
        
        public System.Threading.Tasks.Task<Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData> GetZipCodeAsync(string zip) {
            return base.Channel.GetZipCodeAsync(zip);
        }
        
        public Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[] GetZipsByState(string state) {
            return base.Channel.GetZipsByState(state);
        }
        
        public System.Threading.Tasks.Task<Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[]> GetZipsByStateAsync(string state) {
            return base.Channel.GetZipsByStateAsync(state);
        }
        
        public Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[] GetZipsForRange(string zip, int range) {
            return base.Channel.GetZipsForRange(zip, range);
        }
        
        public System.Threading.Tasks.Task<Postal.Catagalog.MvcClient.PostalZipProxy.ZipCodeData[]> GetZipsForRangeAsync(string zip, int range) {
            return base.Channel.GetZipsForRangeAsync(zip, range);
        }
    }
}
