﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.HelloSimpleServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloSimpleServiceClient.IHelloSimpleService")]
    public interface IHelloSimpleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloSimpleService/GetHelloMessage", ReplyAction="http://tempuri.org/IHelloSimpleService/GetHelloMessageResponse")]
        string GetHelloMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloSimpleService/GetHelloMessage", ReplyAction="http://tempuri.org/IHelloSimpleService/GetHelloMessageResponse")]
        System.Threading.Tasks.Task<string> GetHelloMessageAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloSimpleServiceChannel : Client.HelloSimpleServiceClient.IHelloSimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloSimpleServiceClient : System.ServiceModel.ClientBase<Client.HelloSimpleServiceClient.IHelloSimpleService>, Client.HelloSimpleServiceClient.IHelloSimpleService {
        
        public HelloSimpleServiceClient() {
        }
        
        public HelloSimpleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloSimpleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloSimpleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloSimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHelloMessage(string name) {
            return base.Channel.GetHelloMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> GetHelloMessageAsync(string name) {
            return base.Channel.GetHelloMessageAsync(name);
        }
    }
}
