﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapServiceReference.ISoapService")]
    public interface ISoapService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/StringToUpper", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapServiceReference.StringToUpperResponse> StringToUpperAsync(SoapServiceReference.StringToUpperRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/StringToLower", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapServiceReference.StringToLowerResponse> StringToLowerAsync(SoapServiceReference.StringToLowerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StringToUpperRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StringToUpper", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceReference.StringToUpperRequestBody Body;
        
        public StringToUpperRequest()
        {
        }
        
        public StringToUpperRequest(SoapServiceReference.StringToUpperRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StringToUpperRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string words;
        
        public StringToUpperRequestBody()
        {
        }
        
        public StringToUpperRequestBody(string words)
        {
            this.words = words;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StringToUpperResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StringToUpperResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceReference.StringToUpperResponseBody Body;
        
        public StringToUpperResponse()
        {
        }
        
        public StringToUpperResponse(SoapServiceReference.StringToUpperResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StringToUpperResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StringToUpperResult;
        
        public StringToUpperResponseBody()
        {
        }
        
        public StringToUpperResponseBody(string StringToUpperResult)
        {
            this.StringToUpperResult = StringToUpperResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StringToLowerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StringToLower", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceReference.StringToLowerRequestBody Body;
        
        public StringToLowerRequest()
        {
        }
        
        public StringToLowerRequest(SoapServiceReference.StringToLowerRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StringToLowerRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string words;
        
        public StringToLowerRequestBody()
        {
        }
        
        public StringToLowerRequestBody(string words)
        {
            this.words = words;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StringToLowerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StringToLowerResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceReference.StringToLowerResponseBody Body;
        
        public StringToLowerResponse()
        {
        }
        
        public StringToLowerResponse(SoapServiceReference.StringToLowerResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StringToLowerResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StringToLowerResult;
        
        public StringToLowerResponseBody()
        {
        }
        
        public StringToLowerResponseBody(string StringToLowerResult)
        {
            this.StringToLowerResult = StringToLowerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ISoapServiceChannel : SoapServiceReference.ISoapService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class SoapServiceClient : System.ServiceModel.ClientBase<SoapServiceReference.ISoapService>, SoapServiceReference.ISoapService
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SoapServiceClient() : 
                base(SoapServiceClient.GetDefaultBinding(), SoapServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISoapService_soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), SoapServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapServiceReference.StringToUpperResponse> SoapServiceReference.ISoapService.StringToUpperAsync(SoapServiceReference.StringToUpperRequest request)
        {
            return base.Channel.StringToUpperAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapServiceReference.StringToUpperResponse> StringToUpperAsync(string words)
        {
            SoapServiceReference.StringToUpperRequest inValue = new SoapServiceReference.StringToUpperRequest();
            inValue.Body = new SoapServiceReference.StringToUpperRequestBody();
            inValue.Body.words = words;
            return ((SoapServiceReference.ISoapService)(this)).StringToUpperAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapServiceReference.StringToLowerResponse> SoapServiceReference.ISoapService.StringToLowerAsync(SoapServiceReference.StringToLowerRequest request)
        {
            return base.Channel.StringToLowerAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapServiceReference.StringToLowerResponse> StringToLowerAsync(string words)
        {
            SoapServiceReference.StringToLowerRequest inValue = new SoapServiceReference.StringToLowerRequest();
            inValue.Body = new SoapServiceReference.StringToLowerRequestBody();
            inValue.Body.words = words;
            return ((SoapServiceReference.ISoapService)(this)).StringToLowerAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapService_soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapService_soap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7181/Service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SoapServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SoapServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISoapService_soap,
        }
    }
}