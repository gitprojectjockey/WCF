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
    [System.Runtime.Serialization.DataContractAttribute(Name="PostalDataBase", Namespace="http://www.goPostal.com/postalServices")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(www.gopostal.com.postalServices.ZipCityData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(www.gopostal.com.postalServices.ZipCodeData))]
    public partial class PostalDataBase : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CityField;
        
        private string ZipCodeField;
        
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
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode
        {
            get
            {
                return this.ZipCodeField;
            }
            set
            {
                this.ZipCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ZipCityData", Namespace="http://www.goPostal.com/postalServices")]
    public partial class ZipCityData : www.gopostal.com.postalServices.PostalDataBase
    {
        
        private bool IsPrimaryStateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPrimaryState
        {
            get
            {
                return this.IsPrimaryStateField;
            }
            set
            {
                this.IsPrimaryStateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ZipCodeData", Namespace="http://www.goPostal.com/postalServices")]
    public partial class ZipCodeData : www.gopostal.com.postalServices.PostalDataBase
    {
        
        private string StateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.goPostal.com/postalServices", ConfigurationName="IPostalZipService")]
public interface IPostalZipService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalServiceBase/Ping", ReplyAction="http://www.goPostal.com/postalServices/IPostalServiceBase/PingResponse")]
    string Ping(string echo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalServiceBase/Ping", ReplyAction="http://www.goPostal.com/postalServices/IPostalServiceBase/PingResponse")]
    System.Threading.Tasks.Task<string> PingAsync(string echo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCode", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCodeResponse")]
    www.gopostal.com.postalServices.ZipCodeData GetZipCode(string zip);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCode", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipCodeResponse")]
    System.Threading.Tasks.Task<www.gopostal.com.postalServices.ZipCodeData> GetZipCodeAsync(string zip);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByState", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByStateResponse")]
    www.gopostal.com.postalServices.ZipCodeData[] GetZipsByState(string state);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByState", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsByStateResponse")]
    System.Threading.Tasks.Task<www.gopostal.com.postalServices.ZipCodeData[]> GetZipsByStateAsync(string state);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRange", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRangeResponse")]
    www.gopostal.com.postalServices.ZipCodeData[] GetZipsForRange(string zip, int range);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRange", ReplyAction="http://www.goPostal.com/postalServices/IPostalZipService/GetZipsForRangeResponse")]
    System.Threading.Tasks.Task<www.gopostal.com.postalServices.ZipCodeData[]> GetZipsForRangeAsync(string zip, int range);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPostalZipServiceChannel : IPostalZipService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PostalZipServiceClient : System.ServiceModel.ClientBase<IPostalZipService>, IPostalZipService
{
    
    public PostalZipServiceClient()
    {
    }
    
    public PostalZipServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PostalZipServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostalZipServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostalZipServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
    
    public www.gopostal.com.postalServices.ZipCodeData GetZipCode(string zip)
    {
        return base.Channel.GetZipCode(zip);
    }
    
    public System.Threading.Tasks.Task<www.gopostal.com.postalServices.ZipCodeData> GetZipCodeAsync(string zip)
    {
        return base.Channel.GetZipCodeAsync(zip);
    }
    
    public www.gopostal.com.postalServices.ZipCodeData[] GetZipsByState(string state)
    {
        return base.Channel.GetZipsByState(state);
    }
    
    public System.Threading.Tasks.Task<www.gopostal.com.postalServices.ZipCodeData[]> GetZipsByStateAsync(string state)
    {
        return base.Channel.GetZipsByStateAsync(state);
    }
    
    public www.gopostal.com.postalServices.ZipCodeData[] GetZipsForRange(string zip, int range)
    {
        return base.Channel.GetZipsForRange(zip, range);
    }
    
    public System.Threading.Tasks.Task<www.gopostal.com.postalServices.ZipCodeData[]> GetZipsForRangeAsync(string zip, int range)
    {
        return base.Channel.GetZipsForRangeAsync(zip, range);
    }
}
