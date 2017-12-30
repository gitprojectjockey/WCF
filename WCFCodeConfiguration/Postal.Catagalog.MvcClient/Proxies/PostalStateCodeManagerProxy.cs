﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://www.goPostal.com/postalServices", ClrNamespace="www.gopostal.com.postalServices")]

namespace www.gopostal.com.postalServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StateCodeData", Namespace="http://www.goPostal.com/postalServices")]
    public partial class StateCodeData : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AbbreviationField;
        
        private string NameField;
        
        private string SSCodeField;
        
        private int StateIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Abbreviation
        {
            get
            {
                return this.AbbreviationField;
            }
            set
            {
                this.AbbreviationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SSCode
        {
            get
            {
                return this.SSCodeField;
            }
            set
            {
                this.SSCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StateId
        {
            get
            {
                return this.StateIdField;
            }
            set
            {
                this.StateIdField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.goPostal.com/postalServices", ConfigurationName="IPostalStateService")]
public interface IPostalStateService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalServiceBase/Ping", ReplyAction="http://www.goPostal.com/postalServices/IPostalServiceBase/PingResponse")]
    string Ping(string echo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalServiceBase/Ping", ReplyAction="http://www.goPostal.com/postalServices/IPostalServiceBase/PingResponse")]
    System.Threading.Tasks.Task<string> PingAsync(string echo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalStateService/GetStates", ReplyAction="http://www.goPostal.com/postalServices/IPostalStateService/GetStatesResponse")]
    string[] GetStates(bool primaryOnly);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalStateService/GetStates", ReplyAction="http://www.goPostal.com/postalServices/IPostalStateService/GetStatesResponse")]
    System.Threading.Tasks.Task<string[]> GetStatesAsync(bool primaryOnly);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalStateService/GetStateCode", ReplyAction="http://www.goPostal.com/postalServices/IPostalStateService/GetStateCodeResponse")]
    www.gopostal.com.postalServices.StateCodeData GetStateCode(string state);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalStateService/GetStateCode", ReplyAction="http://www.goPostal.com/postalServices/IPostalStateService/GetStateCodeResponse")]
    System.Threading.Tasks.Task<www.gopostal.com.postalServices.StateCodeData> GetStateCodeAsync(string state);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPostalStateServiceChannel : IPostalStateService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PostalStateServiceClient : System.ServiceModel.ClientBase<IPostalStateService>, IPostalStateService
{
    
    public PostalStateServiceClient()
    {
    }
    
    public PostalStateServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PostalStateServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostalStateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostalStateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string Ping(string echo)
    {
        return base.Channel.Ping(echo);
    }
    
    public System.Threading.Tasks.Task<string> PingAsync(string echo)
    {
        return base.Channel.PingAsync(echo);
    }
    
    public string[] GetStates(bool primaryOnly)
    {
        return base.Channel.GetStates(primaryOnly);
    }
    
    public System.Threading.Tasks.Task<string[]> GetStatesAsync(bool primaryOnly)
    {
        return base.Channel.GetStatesAsync(primaryOnly);
    }
    
    public www.gopostal.com.postalServices.StateCodeData GetStateCode(string state)
    {
        return base.Channel.GetStateCode(state);
    }
    
    public System.Threading.Tasks.Task<www.gopostal.com.postalServices.StateCodeData> GetStateCodeAsync(string state)
    {
        return base.Channel.GetStateCodeAsync(state);
    }
}