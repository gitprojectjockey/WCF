﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.SimpleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleService.ISimpleService")]
    public interface ISimpleService {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/ISimpleService/GetMessageWithNoProtection", ReplyAction="http://tempuri.org/ISimpleService/GetMessageWithNoProtectionResponse")]
        string GetMessageWithNoProtection();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/ISimpleService/GetMessageWithNoProtection", ReplyAction="http://tempuri.org/ISimpleService/GetMessageWithNoProtectionResponse")]
        System.Threading.Tasks.Task<string> GetMessageWithNoProtectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/ISimpleService/GetSignedMessage", ReplyAction="http://tempuri.org/ISimpleService/GetSignedMessageResponse")]
        string GetSignedMessage();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/ISimpleService/GetSignedMessage", ReplyAction="http://tempuri.org/ISimpleService/GetSignedMessageResponse")]
        System.Threading.Tasks.Task<string> GetSignedMessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ISimpleService/GetSignedAndEncryptedMessage", ReplyAction="http://tempuri.org/ISimpleService/GetSignedAndEncryptedMessageResponse")]
        string GetSignedAndEncryptedMessage();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ISimpleService/GetSignedAndEncryptedMessage", ReplyAction="http://tempuri.org/ISimpleService/GetSignedAndEncryptedMessageResponse")]
        System.Threading.Tasks.Task<string> GetSignedAndEncryptedMessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleServiceChannel : Client.SimpleService.ISimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleServiceClient : System.ServiceModel.ClientBase<Client.SimpleService.ISimpleService>, Client.SimpleService.ISimpleService {
        
        public SimpleServiceClient() {
        }
        
        public SimpleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessageWithNoProtection() {
            return base.Channel.GetMessageWithNoProtection();
        }
        
        public System.Threading.Tasks.Task<string> GetMessageWithNoProtectionAsync() {
            return base.Channel.GetMessageWithNoProtectionAsync();
        }
        
        public string GetSignedMessage() {
            return base.Channel.GetSignedMessage();
        }
        
        public System.Threading.Tasks.Task<string> GetSignedMessageAsync() {
            return base.Channel.GetSignedMessageAsync();
        }
        
        public string GetSignedAndEncryptedMessage() {
            return base.Channel.GetSignedAndEncryptedMessage();
        }
        
        public System.Threading.Tasks.Task<string> GetSignedAndEncryptedMessageAsync() {
            return base.Channel.GetSignedAndEncryptedMessageAsync();
        }
    }
}
