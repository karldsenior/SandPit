﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.HelloWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWebService.HelloWebServiceSoap")]
    public interface HelloWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetList", ReplyAction="*")]
        WebApplication2.HelloWebService.GetListResponse GetList(WebApplication2.HelloWebService.GetListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetList", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetListResponse> GetListAsync(WebApplication2.HelloWebService.GetListRequest request);
        
        // CODEGEN: Generating message contract since element name strID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRecord", ReplyAction="*")]
        WebApplication2.HelloWebService.GetRecordResponse GetRecord(WebApplication2.HelloWebService.GetRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetRecordResponse> GetRecordAsync(WebApplication2.HelloWebService.GetRecordRequest request);
        
        // CODEGEN: Generating message contract since element name strID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessage", ReplyAction="*")]
        WebApplication2.HelloWebService.GetMessageResponse GetMessage(WebApplication2.HelloWebService.GetMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessage", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetMessageResponse> GetMessageAsync(WebApplication2.HelloWebService.GetMessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetList", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.HelloWebService.GetListRequestBody Body;
        
        public GetListRequest() {
        }
        
        public GetListRequest(WebApplication2.HelloWebService.GetListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetListRequestBody {
        
        public GetListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.HelloWebService.GetListResponseBody Body;
        
        public GetListResponse() {
        }
        
        public GetListResponse(WebApplication2.HelloWebService.GetListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetListResult;
        
        public GetListResponseBody() {
        }
        
        public GetListResponseBody(string GetListResult) {
            this.GetListResult = GetListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRecordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecord", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.HelloWebService.GetRecordRequestBody Body;
        
        public GetRecordRequest() {
        }
        
        public GetRecordRequest(WebApplication2.HelloWebService.GetRecordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRecordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strID;
        
        public GetRecordRequestBody() {
        }
        
        public GetRecordRequestBody(string strID) {
            this.strID = strID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRecordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecordResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.HelloWebService.GetRecordResponseBody Body;
        
        public GetRecordResponse() {
        }
        
        public GetRecordResponse(WebApplication2.HelloWebService.GetRecordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRecordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetRecordResult;
        
        public GetRecordResponseBody() {
        }
        
        public GetRecordResponseBody(string GetRecordResult) {
            this.GetRecordResult = GetRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessage", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.HelloWebService.GetMessageRequestBody Body;
        
        public GetMessageRequest() {
        }
        
        public GetMessageRequest(WebApplication2.HelloWebService.GetMessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strID;
        
        public GetMessageRequestBody() {
        }
        
        public GetMessageRequestBody(string strID) {
            this.strID = strID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.HelloWebService.GetMessageResponseBody Body;
        
        public GetMessageResponse() {
        }
        
        public GetMessageResponse(WebApplication2.HelloWebService.GetMessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetMessageResult;
        
        public GetMessageResponseBody() {
        }
        
        public GetMessageResponseBody(string GetMessageResult) {
            this.GetMessageResult = GetMessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWebServiceSoapChannel : WebApplication2.HelloWebService.HelloWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWebServiceSoapClient : System.ServiceModel.ClientBase<WebApplication2.HelloWebService.HelloWebServiceSoap>, WebApplication2.HelloWebService.HelloWebServiceSoap {
        
        public HelloWebServiceSoapClient() {
        }
        
        public HelloWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.HelloWebService.GetListResponse WebApplication2.HelloWebService.HelloWebServiceSoap.GetList(WebApplication2.HelloWebService.GetListRequest request) {
            return base.Channel.GetList(request);
        }
        
        public string GetList() {
            WebApplication2.HelloWebService.GetListRequest inValue = new WebApplication2.HelloWebService.GetListRequest();
            inValue.Body = new WebApplication2.HelloWebService.GetListRequestBody();
            WebApplication2.HelloWebService.GetListResponse retVal = ((WebApplication2.HelloWebService.HelloWebServiceSoap)(this)).GetList(inValue);
            return retVal.Body.GetListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetListResponse> WebApplication2.HelloWebService.HelloWebServiceSoap.GetListAsync(WebApplication2.HelloWebService.GetListRequest request) {
            return base.Channel.GetListAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetListResponse> GetListAsync() {
            WebApplication2.HelloWebService.GetListRequest inValue = new WebApplication2.HelloWebService.GetListRequest();
            inValue.Body = new WebApplication2.HelloWebService.GetListRequestBody();
            return ((WebApplication2.HelloWebService.HelloWebServiceSoap)(this)).GetListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.HelloWebService.GetRecordResponse WebApplication2.HelloWebService.HelloWebServiceSoap.GetRecord(WebApplication2.HelloWebService.GetRecordRequest request) {
            return base.Channel.GetRecord(request);
        }
        
        public string GetRecord(string strID) {
            WebApplication2.HelloWebService.GetRecordRequest inValue = new WebApplication2.HelloWebService.GetRecordRequest();
            inValue.Body = new WebApplication2.HelloWebService.GetRecordRequestBody();
            inValue.Body.strID = strID;
            WebApplication2.HelloWebService.GetRecordResponse retVal = ((WebApplication2.HelloWebService.HelloWebServiceSoap)(this)).GetRecord(inValue);
            return retVal.Body.GetRecordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetRecordResponse> WebApplication2.HelloWebService.HelloWebServiceSoap.GetRecordAsync(WebApplication2.HelloWebService.GetRecordRequest request) {
            return base.Channel.GetRecordAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetRecordResponse> GetRecordAsync(string strID) {
            WebApplication2.HelloWebService.GetRecordRequest inValue = new WebApplication2.HelloWebService.GetRecordRequest();
            inValue.Body = new WebApplication2.HelloWebService.GetRecordRequestBody();
            inValue.Body.strID = strID;
            return ((WebApplication2.HelloWebService.HelloWebServiceSoap)(this)).GetRecordAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.HelloWebService.GetMessageResponse WebApplication2.HelloWebService.HelloWebServiceSoap.GetMessage(WebApplication2.HelloWebService.GetMessageRequest request) {
            return base.Channel.GetMessage(request);
        }
        
        public string GetMessage(string strID) {
            WebApplication2.HelloWebService.GetMessageRequest inValue = new WebApplication2.HelloWebService.GetMessageRequest();
            inValue.Body = new WebApplication2.HelloWebService.GetMessageRequestBody();
            inValue.Body.strID = strID;
            WebApplication2.HelloWebService.GetMessageResponse retVal = ((WebApplication2.HelloWebService.HelloWebServiceSoap)(this)).GetMessage(inValue);
            return retVal.Body.GetMessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetMessageResponse> WebApplication2.HelloWebService.HelloWebServiceSoap.GetMessageAsync(WebApplication2.HelloWebService.GetMessageRequest request) {
            return base.Channel.GetMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.HelloWebService.GetMessageResponse> GetMessageAsync(string strID) {
            WebApplication2.HelloWebService.GetMessageRequest inValue = new WebApplication2.HelloWebService.GetMessageRequest();
            inValue.Body = new WebApplication2.HelloWebService.GetMessageRequestBody();
            inValue.Body.strID = strID;
            return ((WebApplication2.HelloWebService.HelloWebServiceSoap)(this)).GetMessageAsync(inValue);
        }
    }
}
