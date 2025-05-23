﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zp
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://zarinpal.com/", ConfigurationName="zp.PaymentGatewayImplementationServicePortType")]
    public interface PaymentGatewayImplementationServicePortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<zp.PaymentRequestResponse> PaymentRequestAsync(zp.PaymentRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentRequestWithExtra", ReplyAction="*")]
        System.Threading.Tasks.Task<zp.PaymentRequestWithExtraResponse> PaymentRequestWithExtraAsync(zp.PaymentRequestWithExtraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentVerification", ReplyAction="*")]
        System.Threading.Tasks.Task<zp.PaymentVerificationResponse> PaymentVerificationAsync(zp.PaymentVerificationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentVerificationWithExtra", ReplyAction="*")]
        System.Threading.Tasks.Task<zp.PaymentVerificationWithExtraResponse> PaymentVerificationWithExtraAsync(zp.PaymentVerificationWithExtraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#GetUnverifiedTransactions", ReplyAction="*")]
        System.Threading.Tasks.Task<zp.GetUnverifiedTransactionsResponse> GetUnverifiedTransactionsAsync(zp.GetUnverifiedTransactionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#RefreshAuthority", ReplyAction="*")]
        System.Threading.Tasks.Task<zp.RefreshAuthorityResponse> RefreshAuthorityAsync(zp.RefreshAuthorityRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequest", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentRequestRequestBody Body;
        
        public PaymentRequestRequest()
        {
        }
        
        public PaymentRequestRequest(zp.PaymentRequestRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Mobile;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string CallbackURL;
        
        public PaymentRequestRequestBody()
        {
        }
        
        public PaymentRequestRequestBody(string MerchantID, int Amount, string Description, string Email, string Mobile, string CallbackURL)
        {
            this.MerchantID = MerchantID;
            this.Amount = Amount;
            this.Description = Description;
            this.Email = Email;
            this.Mobile = Mobile;
            this.CallbackURL = CallbackURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequestResponse", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentRequestResponseBody Body;
        
        public PaymentRequestResponse()
        {
        }
        
        public PaymentRequestResponse(zp.PaymentRequestResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        public PaymentRequestResponseBody()
        {
        }
        
        public PaymentRequestResponseBody(int Status, string Authority)
        {
            this.Status = Status;
            this.Authority = Authority;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestWithExtraRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequestWithExtra", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentRequestWithExtraRequestBody Body;
        
        public PaymentRequestWithExtraRequest()
        {
        }
        
        public PaymentRequestWithExtraRequest(zp.PaymentRequestWithExtraRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestWithExtraRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string AdditionalData;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Mobile;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string CallbackURL;
        
        public PaymentRequestWithExtraRequestBody()
        {
        }
        
        public PaymentRequestWithExtraRequestBody(string MerchantID, int Amount, string Description, string AdditionalData, string Email, string Mobile, string CallbackURL)
        {
            this.MerchantID = MerchantID;
            this.Amount = Amount;
            this.Description = Description;
            this.AdditionalData = AdditionalData;
            this.Email = Email;
            this.Mobile = Mobile;
            this.CallbackURL = CallbackURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestWithExtraResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequestWithExtraResponse", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentRequestWithExtraResponseBody Body;
        
        public PaymentRequestWithExtraResponse()
        {
        }
        
        public PaymentRequestWithExtraResponse(zp.PaymentRequestWithExtraResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestWithExtraResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        public PaymentRequestWithExtraResponseBody()
        {
        }
        
        public PaymentRequestWithExtraResponseBody(int Status, string Authority)
        {
            this.Status = Status;
            this.Authority = Authority;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerification", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentVerificationRequestBody Body;
        
        public PaymentVerificationRequest()
        {
        }
        
        public PaymentVerificationRequest(zp.PaymentVerificationRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Amount;
        
        public PaymentVerificationRequestBody()
        {
        }
        
        public PaymentVerificationRequestBody(string MerchantID, string Authority, int Amount)
        {
            this.MerchantID = MerchantID;
            this.Authority = Authority;
            this.Amount = Amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerificationResponse", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentVerificationResponseBody Body;
        
        public PaymentVerificationResponse()
        {
        }
        
        public PaymentVerificationResponse(zp.PaymentVerificationResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public long RefID;
        
        public PaymentVerificationResponseBody()
        {
        }
        
        public PaymentVerificationResponseBody(int Status, long RefID)
        {
            this.Status = Status;
            this.RefID = RefID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationWithExtraRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerificationWithExtra", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentVerificationWithExtraRequestBody Body;
        
        public PaymentVerificationWithExtraRequest()
        {
        }
        
        public PaymentVerificationWithExtraRequest(zp.PaymentVerificationWithExtraRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationWithExtraRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Amount;
        
        public PaymentVerificationWithExtraRequestBody()
        {
        }
        
        public PaymentVerificationWithExtraRequestBody(string MerchantID, string Authority, int Amount)
        {
            this.MerchantID = MerchantID;
            this.Authority = Authority;
            this.Amount = Amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationWithExtraResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerificationWithExtraResponse", Namespace="http://zarinpal.com/", Order=0)]
        public zp.PaymentVerificationWithExtraResponseBody Body;
        
        public PaymentVerificationWithExtraResponse()
        {
        }
        
        public PaymentVerificationWithExtraResponse(zp.PaymentVerificationWithExtraResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationWithExtraResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public long RefID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ExtraDetail;
        
        public PaymentVerificationWithExtraResponseBody()
        {
        }
        
        public PaymentVerificationWithExtraResponseBody(int Status, long RefID, string ExtraDetail)
        {
            this.Status = Status;
            this.RefID = RefID;
            this.ExtraDetail = ExtraDetail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUnverifiedTransactionsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUnverifiedTransactions", Namespace="http://zarinpal.com/", Order=0)]
        public zp.GetUnverifiedTransactionsRequestBody Body;
        
        public GetUnverifiedTransactionsRequest()
        {
        }
        
        public GetUnverifiedTransactionsRequest(zp.GetUnverifiedTransactionsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class GetUnverifiedTransactionsRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        public GetUnverifiedTransactionsRequestBody()
        {
        }
        
        public GetUnverifiedTransactionsRequestBody(string MerchantID)
        {
            this.MerchantID = MerchantID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUnverifiedTransactionsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUnverifiedTransactionsResponse", Namespace="http://zarinpal.com/", Order=0)]
        public zp.GetUnverifiedTransactionsResponseBody Body;
        
        public GetUnverifiedTransactionsResponse()
        {
        }
        
        public GetUnverifiedTransactionsResponse(zp.GetUnverifiedTransactionsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class GetUnverifiedTransactionsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authorities;
        
        public GetUnverifiedTransactionsResponseBody()
        {
        }
        
        public GetUnverifiedTransactionsResponseBody(int Status, string Authorities)
        {
            this.Status = Status;
            this.Authorities = Authorities;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RefreshAuthorityRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RefreshAuthority", Namespace="http://zarinpal.com/", Order=0)]
        public zp.RefreshAuthorityRequestBody Body;
        
        public RefreshAuthorityRequest()
        {
        }
        
        public RefreshAuthorityRequest(zp.RefreshAuthorityRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class RefreshAuthorityRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int ExpireIn;
        
        public RefreshAuthorityRequestBody()
        {
        }
        
        public RefreshAuthorityRequestBody(string MerchantID, string Authority, int ExpireIn)
        {
            this.MerchantID = MerchantID;
            this.Authority = Authority;
            this.ExpireIn = ExpireIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RefreshAuthorityResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RefreshAuthorityResponse", Namespace="http://zarinpal.com/", Order=0)]
        public zp.RefreshAuthorityResponseBody Body;
        
        public RefreshAuthorityResponse()
        {
        }
        
        public RefreshAuthorityResponse(zp.RefreshAuthorityResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class RefreshAuthorityResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        public RefreshAuthorityResponseBody()
        {
        }
        
        public RefreshAuthorityResponseBody(int Status)
        {
            this.Status = Status;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface PaymentGatewayImplementationServicePortTypeChannel : zp.PaymentGatewayImplementationServicePortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class PaymentGatewayImplementationServicePortTypeClient : System.ServiceModel.ClientBase<zp.PaymentGatewayImplementationServicePortType>, zp.PaymentGatewayImplementationServicePortType
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PaymentGatewayImplementationServicePortTypeClient() : 
                base(PaymentGatewayImplementationServicePortTypeClient.GetDefaultBinding(), PaymentGatewayImplementationServicePortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PaymentGatewayImplementationServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(PaymentGatewayImplementationServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), PaymentGatewayImplementationServicePortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PaymentGatewayImplementationServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PaymentGatewayImplementationServicePortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zp.PaymentRequestResponse> zp.PaymentGatewayImplementationServicePortType.PaymentRequestAsync(zp.PaymentRequestRequest request)
        {
            return base.Channel.PaymentRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<zp.PaymentRequestResponse> PaymentRequestAsync(string MerchantID, int Amount, string Description, string Email, string Mobile, string CallbackURL)
        {
            zp.PaymentRequestRequest inValue = new zp.PaymentRequestRequest();
            inValue.Body = new zp.PaymentRequestRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Amount = Amount;
            inValue.Body.Description = Description;
            inValue.Body.Email = Email;
            inValue.Body.Mobile = Mobile;
            inValue.Body.CallbackURL = CallbackURL;
            return ((zp.PaymentGatewayImplementationServicePortType)(this)).PaymentRequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zp.PaymentRequestWithExtraResponse> zp.PaymentGatewayImplementationServicePortType.PaymentRequestWithExtraAsync(zp.PaymentRequestWithExtraRequest request)
        {
            return base.Channel.PaymentRequestWithExtraAsync(request);
        }
        
        public System.Threading.Tasks.Task<zp.PaymentRequestWithExtraResponse> PaymentRequestWithExtraAsync(string MerchantID, int Amount, string Description, string AdditionalData, string Email, string Mobile, string CallbackURL)
        {
            zp.PaymentRequestWithExtraRequest inValue = new zp.PaymentRequestWithExtraRequest();
            inValue.Body = new zp.PaymentRequestWithExtraRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Amount = Amount;
            inValue.Body.Description = Description;
            inValue.Body.AdditionalData = AdditionalData;
            inValue.Body.Email = Email;
            inValue.Body.Mobile = Mobile;
            inValue.Body.CallbackURL = CallbackURL;
            return ((zp.PaymentGatewayImplementationServicePortType)(this)).PaymentRequestWithExtraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zp.PaymentVerificationResponse> zp.PaymentGatewayImplementationServicePortType.PaymentVerificationAsync(zp.PaymentVerificationRequest request)
        {
            return base.Channel.PaymentVerificationAsync(request);
        }
        
        public System.Threading.Tasks.Task<zp.PaymentVerificationResponse> PaymentVerificationAsync(string MerchantID, string Authority, int Amount)
        {
            zp.PaymentVerificationRequest inValue = new zp.PaymentVerificationRequest();
            inValue.Body = new zp.PaymentVerificationRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Authority = Authority;
            inValue.Body.Amount = Amount;
            return ((zp.PaymentGatewayImplementationServicePortType)(this)).PaymentVerificationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zp.PaymentVerificationWithExtraResponse> zp.PaymentGatewayImplementationServicePortType.PaymentVerificationWithExtraAsync(zp.PaymentVerificationWithExtraRequest request)
        {
            return base.Channel.PaymentVerificationWithExtraAsync(request);
        }
        
        public System.Threading.Tasks.Task<zp.PaymentVerificationWithExtraResponse> PaymentVerificationWithExtraAsync(string MerchantID, string Authority, int Amount)
        {
            zp.PaymentVerificationWithExtraRequest inValue = new zp.PaymentVerificationWithExtraRequest();
            inValue.Body = new zp.PaymentVerificationWithExtraRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Authority = Authority;
            inValue.Body.Amount = Amount;
            return ((zp.PaymentGatewayImplementationServicePortType)(this)).PaymentVerificationWithExtraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zp.GetUnverifiedTransactionsResponse> zp.PaymentGatewayImplementationServicePortType.GetUnverifiedTransactionsAsync(zp.GetUnverifiedTransactionsRequest request)
        {
            return base.Channel.GetUnverifiedTransactionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<zp.GetUnverifiedTransactionsResponse> GetUnverifiedTransactionsAsync(string MerchantID)
        {
            zp.GetUnverifiedTransactionsRequest inValue = new zp.GetUnverifiedTransactionsRequest();
            inValue.Body = new zp.GetUnverifiedTransactionsRequestBody();
            inValue.Body.MerchantID = MerchantID;
            return ((zp.PaymentGatewayImplementationServicePortType)(this)).GetUnverifiedTransactionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zp.RefreshAuthorityResponse> zp.PaymentGatewayImplementationServicePortType.RefreshAuthorityAsync(zp.RefreshAuthorityRequest request)
        {
            return base.Channel.RefreshAuthorityAsync(request);
        }
        
        public System.Threading.Tasks.Task<zp.RefreshAuthorityResponse> RefreshAuthorityAsync(string MerchantID, string Authority, int ExpireIn)
        {
            zp.RefreshAuthorityRequest inValue = new zp.RefreshAuthorityRequest();
            inValue.Body = new zp.RefreshAuthorityRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Authority = Authority;
            inValue.Body.ExpireIn = ExpireIn;
            return ((zp.PaymentGatewayImplementationServicePortType)(this)).RefreshAuthorityAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PaymentGatewayImplementationServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PaymentGatewayImplementationServicePort))
            {
                return new System.ServiceModel.EndpointAddress("https://sandbox.zarinpal.com/pg/services/WebGate/service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PaymentGatewayImplementationServicePortTypeClient.GetBindingForEndpoint(EndpointConfiguration.PaymentGatewayImplementationServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PaymentGatewayImplementationServicePortTypeClient.GetEndpointAddress(EndpointConfiguration.PaymentGatewayImplementationServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            PaymentGatewayImplementationServicePort,
        }
    }
}
