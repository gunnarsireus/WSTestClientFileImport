﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSTestClientFileImport.Authentication {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.xledger.net/", ConfigurationName="Authentication.AuthenticationSoap")]
    public interface AuthenticationSoap {
        
        // CODEGEN: Generating message contract since element name sLogonID from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/LogonKey", ReplyAction="*")]
        WSTestClientFileImport.Authentication.LogonKeyResponse LogonKey(WSTestClientFileImport.Authentication.LogonKeyRequest request);
        
        // CODEGEN: Generating message contract since element name sLogonID from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/LogonTicket", ReplyAction="*")]
        WSTestClientFileImport.Authentication.LogonTicketResponse LogonTicket(WSTestClientFileImport.Authentication.LogonTicketRequest request);
        
        // CODEGEN: Generating message contract since element name sLogonID from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/LogonRoleAccess", ReplyAction="*")]
        WSTestClientFileImport.Authentication.LogonRoleAccessResponse LogonRoleAccess(WSTestClientFileImport.Authentication.LogonRoleAccessRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogonKeyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogonKey", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.Authentication.LogonKeyRequestBody Body;
        
        public LogonKeyRequest() {
        }
        
        public LogonKeyRequest(WSTestClientFileImport.Authentication.LogonKeyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class LogonKeyRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sLogonID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sApplication;
        
        public LogonKeyRequestBody() {
        }
        
        public LogonKeyRequestBody(string sLogonID, string sPassword, string sApplication) {
            this.sLogonID = sLogonID;
            this.sPassword = sPassword;
            this.sApplication = sApplication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogonKeyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogonKeyResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.Authentication.LogonKeyResponseBody Body;
        
        public LogonKeyResponse() {
        }
        
        public LogonKeyResponse(WSTestClientFileImport.Authentication.LogonKeyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class LogonKeyResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LogonKeyResult;
        
        public LogonKeyResponseBody() {
        }
        
        public LogonKeyResponseBody(string LogonKeyResult) {
            this.LogonKeyResult = LogonKeyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogonTicketRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogonTicket", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.Authentication.LogonTicketRequestBody Body;
        
        public LogonTicketRequest() {
        }
        
        public LogonTicketRequest(WSTestClientFileImport.Authentication.LogonTicketRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class LogonTicketRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sLogonID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sApplication;
        
        public LogonTicketRequestBody() {
        }
        
        public LogonTicketRequestBody(string sLogonID, string sKey, string sApplication) {
            this.sLogonID = sLogonID;
            this.sKey = sKey;
            this.sApplication = sApplication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogonTicketResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogonTicketResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.Authentication.LogonTicketResponseBody Body;
        
        public LogonTicketResponse() {
        }
        
        public LogonTicketResponse(WSTestClientFileImport.Authentication.LogonTicketResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class LogonTicketResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LogonTicketResult;
        
        public LogonTicketResponseBody() {
        }
        
        public LogonTicketResponseBody(string LogonTicketResult) {
            this.LogonTicketResult = LogonTicketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogonRoleAccessRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogonRoleAccess", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.Authentication.LogonRoleAccessRequestBody Body;
        
        public LogonRoleAccessRequest() {
        }
        
        public LogonRoleAccessRequest(WSTestClientFileImport.Authentication.LogonRoleAccessRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class LogonRoleAccessRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sLogonID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public long lRoleID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string sApplication;
        
        public LogonRoleAccessRequestBody() {
        }
        
        public LogonRoleAccessRequestBody(string sLogonID, string sKey, long lRoleID, string sApplication) {
            this.sLogonID = sLogonID;
            this.sKey = sKey;
            this.lRoleID = lRoleID;
            this.sApplication = sApplication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogonRoleAccessResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogonRoleAccessResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.Authentication.LogonRoleAccessResponseBody Body;
        
        public LogonRoleAccessResponse() {
        }
        
        public LogonRoleAccessResponse(WSTestClientFileImport.Authentication.LogonRoleAccessResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class LogonRoleAccessResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LogonRoleAccessResult;
        
        public LogonRoleAccessResponseBody() {
        }
        
        public LogonRoleAccessResponseBody(bool LogonRoleAccessResult) {
            this.LogonRoleAccessResult = LogonRoleAccessResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticationSoapChannel : WSTestClientFileImport.Authentication.AuthenticationSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationSoapClient : System.ServiceModel.ClientBase<WSTestClientFileImport.Authentication.AuthenticationSoap>, WSTestClientFileImport.Authentication.AuthenticationSoap {
        
        public AuthenticationSoapClient() {
        }
        
        public AuthenticationSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.Authentication.LogonKeyResponse WSTestClientFileImport.Authentication.AuthenticationSoap.LogonKey(WSTestClientFileImport.Authentication.LogonKeyRequest request) {
            return base.Channel.LogonKey(request);
        }
        
        public string LogonKey(string sLogonID, string sPassword, string sApplication) {
            WSTestClientFileImport.Authentication.LogonKeyRequest inValue = new WSTestClientFileImport.Authentication.LogonKeyRequest();
            inValue.Body = new WSTestClientFileImport.Authentication.LogonKeyRequestBody();
            inValue.Body.sLogonID = sLogonID;
            inValue.Body.sPassword = sPassword;
            inValue.Body.sApplication = sApplication;
            WSTestClientFileImport.Authentication.LogonKeyResponse retVal = ((WSTestClientFileImport.Authentication.AuthenticationSoap)(this)).LogonKey(inValue);
            return retVal.Body.LogonKeyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.Authentication.LogonTicketResponse WSTestClientFileImport.Authentication.AuthenticationSoap.LogonTicket(WSTestClientFileImport.Authentication.LogonTicketRequest request) {
            return base.Channel.LogonTicket(request);
        }
        
        public string LogonTicket(string sLogonID, string sKey, string sApplication) {
            WSTestClientFileImport.Authentication.LogonTicketRequest inValue = new WSTestClientFileImport.Authentication.LogonTicketRequest();
            inValue.Body = new WSTestClientFileImport.Authentication.LogonTicketRequestBody();
            inValue.Body.sLogonID = sLogonID;
            inValue.Body.sKey = sKey;
            inValue.Body.sApplication = sApplication;
            WSTestClientFileImport.Authentication.LogonTicketResponse retVal = ((WSTestClientFileImport.Authentication.AuthenticationSoap)(this)).LogonTicket(inValue);
            return retVal.Body.LogonTicketResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.Authentication.LogonRoleAccessResponse WSTestClientFileImport.Authentication.AuthenticationSoap.LogonRoleAccess(WSTestClientFileImport.Authentication.LogonRoleAccessRequest request) {
            return base.Channel.LogonRoleAccess(request);
        }
        
        public bool LogonRoleAccess(string sLogonID, string sKey, long lRoleID, string sApplication) {
            WSTestClientFileImport.Authentication.LogonRoleAccessRequest inValue = new WSTestClientFileImport.Authentication.LogonRoleAccessRequest();
            inValue.Body = new WSTestClientFileImport.Authentication.LogonRoleAccessRequestBody();
            inValue.Body.sLogonID = sLogonID;
            inValue.Body.sKey = sKey;
            inValue.Body.lRoleID = lRoleID;
            inValue.Body.sApplication = sApplication;
            WSTestClientFileImport.Authentication.LogonRoleAccessResponse retVal = ((WSTestClientFileImport.Authentication.AuthenticationSoap)(this)).LogonRoleAccess(inValue);
            return retVal.Body.LogonRoleAccessResult;
        }
    }
}
