﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://ESoft.EServices.UserInformationService", ClrNamespace="esoft.eservices.userinformationservice")]

namespace esoft.eservices.userinformationservice
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://ESoft.EServices.UserInformationService")]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AuthenticationTypeField;
        
        private bool IsAuthenticField;
        
        private string NameField;
        
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
        public string AuthenticationType
        {
            get
            {
                return this.AuthenticationTypeField;
            }
            set
            {
                this.AuthenticationTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAuthentic
        {
            get
            {
                return this.IsAuthenticField;
            }
            set
            {
                this.IsAuthenticField = value;
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
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://ESoft.EServices.UserInformationService", ConfigurationName="IUserInformationService")]
public interface IUserInformationService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ESoft.EServices.UserInformationService/IUserInformationService/GetUserInfo" +
        "rmation", ReplyAction="http://ESoft.EServices.UserInformationService/IUserInformationService/GetUserInfo" +
        "rmationResponse")]
    esoft.eservices.userinformationservice.User GetUserInformation();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ESoft.EServices.UserInformationService/IUserInformationService/GetUserInfo" +
        "rmation", ReplyAction="http://ESoft.EServices.UserInformationService/IUserInformationService/GetUserInfo" +
        "rmationResponse")]
    System.Threading.Tasks.Task<esoft.eservices.userinformationservice.User> GetUserInformationAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IUserInformationServiceChannel : IUserInformationService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class UserInformationServiceClient : System.ServiceModel.ClientBase<IUserInformationService>, IUserInformationService
{
    
    public UserInformationServiceClient()
    {
    }
    
    public UserInformationServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public UserInformationServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserInformationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserInformationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public esoft.eservices.userinformationservice.User GetUserInformation()
    {
        return base.Channel.GetUserInformation();
    }
    
    public System.Threading.Tasks.Task<esoft.eservices.userinformationservice.User> GetUserInformationAsync()
    {
        return base.Channel.GetUserInformationAsync();
    }
}
