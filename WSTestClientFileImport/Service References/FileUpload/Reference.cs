﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSTestClientFileImport.FileUpload {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.xledger.net/", ConfigurationName="FileUpload.FileUploadSoap")]
    public interface FileUploadSoap {
        
        // CODEGEN: Generating message contract since element name sApplication from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/GetFileUploadEntityCodes", ReplyAction="*")]
        WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesResponse GetFileUploadEntityCodes(WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequest request);
        
        // CODEGEN: Generating message contract since element name sUserName from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/AuthenticateConnection", ReplyAction="*")]
        WSTestClientFileImport.FileUpload.AuthenticateConnectionResponse AuthenticateConnection(WSTestClientFileImport.FileUpload.AuthenticateConnectionRequest request);
        
        // CODEGEN: Generating message contract since element name sUserName from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/ReceiveScannerFile", ReplyAction="*")]
        WSTestClientFileImport.FileUpload.ReceiveScannerFileResponse ReceiveScannerFile(WSTestClientFileImport.FileUpload.ReceiveScannerFileRequest request);
        
        // CODEGEN: Generating message contract since element name sUserName from namespace http://ws.xledger.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.xledger.net/ReceiveFile", ReplyAction="*")]
        WSTestClientFileImport.FileUpload.ReceiveFileResponse ReceiveFile(WSTestClientFileImport.FileUpload.ReceiveFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFileUploadEntityCodesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFileUploadEntityCodes", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequestBody Body;
        
        public GetFileUploadEntityCodesRequest() {
        }
        
        public GetFileUploadEntityCodesRequest(WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class GetFileUploadEntityCodesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sApplication;
        
        public GetFileUploadEntityCodesRequestBody() {
        }
        
        public GetFileUploadEntityCodesRequestBody(string sApplication) {
            this.sApplication = sApplication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFileUploadEntityCodesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFileUploadEntityCodesResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesResponseBody Body;
        
        public GetFileUploadEntityCodesResponse() {
        }
        
        public GetFileUploadEntityCodesResponse(WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class GetFileUploadEntityCodesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetFileUploadEntityCodesResult;
        
        public GetFileUploadEntityCodesResponseBody() {
        }
        
        public GetFileUploadEntityCodesResponseBody(string GetFileUploadEntityCodesResult) {
            this.GetFileUploadEntityCodesResult = GetFileUploadEntityCodesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateConnectionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateConnection", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.AuthenticateConnectionRequestBody Body;
        
        public AuthenticateConnectionRequest() {
        }
        
        public AuthenticateConnectionRequest(WSTestClientFileImport.FileUpload.AuthenticateConnectionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class AuthenticateConnectionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sApplication;
        
        public AuthenticateConnectionRequestBody() {
        }
        
        public AuthenticateConnectionRequestBody(string sUserName, string sKey, string sApplication) {
            this.sUserName = sUserName;
            this.sKey = sKey;
            this.sApplication = sApplication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateConnectionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateConnectionResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.AuthenticateConnectionResponseBody Body;
        
        public AuthenticateConnectionResponse() {
        }
        
        public AuthenticateConnectionResponse(WSTestClientFileImport.FileUpload.AuthenticateConnectionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class AuthenticateConnectionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AuthenticateConnectionResult;
        
        public AuthenticateConnectionResponseBody() {
        }
        
        public AuthenticateConnectionResponseBody(bool AuthenticateConnectionResult) {
            this.AuthenticateConnectionResult = AuthenticateConnectionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceiveScannerFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceiveScannerFile", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.ReceiveScannerFileRequestBody Body;
        
        public ReceiveScannerFileRequest() {
        }
        
        public ReceiveScannerFileRequest(WSTestClientFileImport.FileUpload.ReceiveScannerFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class ReceiveScannerFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sApplication;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string sFileName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public byte[] aFile;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int iEntityCode;
        
        public ReceiveScannerFileRequestBody() {
        }
        
        public ReceiveScannerFileRequestBody(string sUserName, string sKey, string sApplication, string sFileName, byte[] aFile, int iEntityCode) {
            this.sUserName = sUserName;
            this.sKey = sKey;
            this.sApplication = sApplication;
            this.sFileName = sFileName;
            this.aFile = aFile;
            this.iEntityCode = iEntityCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceiveScannerFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceiveScannerFileResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.ReceiveScannerFileResponseBody Body;
        
        public ReceiveScannerFileResponse() {
        }
        
        public ReceiveScannerFileResponse(WSTestClientFileImport.FileUpload.ReceiveScannerFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class ReceiveScannerFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long ReceiveScannerFileResult;
        
        public ReceiveScannerFileResponseBody() {
        }
        
        public ReceiveScannerFileResponseBody(long ReceiveScannerFileResult) {
            this.ReceiveScannerFileResult = ReceiveScannerFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceiveFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceiveFile", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.ReceiveFileRequestBody Body;
        
        public ReceiveFileRequest() {
        }
        
        public ReceiveFileRequest(WSTestClientFileImport.FileUpload.ReceiveFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class ReceiveFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sApplication;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string sFileName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public byte[] aFile;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string sImportCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int iEntityCode;
        
        public ReceiveFileRequestBody() {
        }
        
        public ReceiveFileRequestBody(string sUserName, string sKey, string sApplication, string sFileName, byte[] aFile, string sImportCode, int iEntityCode) {
            this.sUserName = sUserName;
            this.sKey = sKey;
            this.sApplication = sApplication;
            this.sFileName = sFileName;
            this.aFile = aFile;
            this.sImportCode = sImportCode;
            this.iEntityCode = iEntityCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceiveFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceiveFileResponse", Namespace="http://ws.xledger.net/", Order=0)]
        public WSTestClientFileImport.FileUpload.ReceiveFileResponseBody Body;
        
        public ReceiveFileResponse() {
        }
        
        public ReceiveFileResponse(WSTestClientFileImport.FileUpload.ReceiveFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.xledger.net/")]
    public partial class ReceiveFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long ReceiveFileResult;
        
        public ReceiveFileResponseBody() {
        }
        
        public ReceiveFileResponseBody(long ReceiveFileResult) {
            this.ReceiveFileResult = ReceiveFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FileUploadSoapChannel : WSTestClientFileImport.FileUpload.FileUploadSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileUploadSoapClient : System.ServiceModel.ClientBase<WSTestClientFileImport.FileUpload.FileUploadSoap>, WSTestClientFileImport.FileUpload.FileUploadSoap {
        
        public FileUploadSoapClient() {
        }
        
        public FileUploadSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileUploadSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesResponse WSTestClientFileImport.FileUpload.FileUploadSoap.GetFileUploadEntityCodes(WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequest request) {
            return base.Channel.GetFileUploadEntityCodes(request);
        }
        
        public string GetFileUploadEntityCodes(string sApplication) {
            WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequest inValue = new WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequest();
            inValue.Body = new WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesRequestBody();
            inValue.Body.sApplication = sApplication;
            WSTestClientFileImport.FileUpload.GetFileUploadEntityCodesResponse retVal = ((WSTestClientFileImport.FileUpload.FileUploadSoap)(this)).GetFileUploadEntityCodes(inValue);
            return retVal.Body.GetFileUploadEntityCodesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.FileUpload.AuthenticateConnectionResponse WSTestClientFileImport.FileUpload.FileUploadSoap.AuthenticateConnection(WSTestClientFileImport.FileUpload.AuthenticateConnectionRequest request) {
            return base.Channel.AuthenticateConnection(request);
        }
        
        public bool AuthenticateConnection(string sUserName, string sKey, string sApplication) {
            WSTestClientFileImport.FileUpload.AuthenticateConnectionRequest inValue = new WSTestClientFileImport.FileUpload.AuthenticateConnectionRequest();
            inValue.Body = new WSTestClientFileImport.FileUpload.AuthenticateConnectionRequestBody();
            inValue.Body.sUserName = sUserName;
            inValue.Body.sKey = sKey;
            inValue.Body.sApplication = sApplication;
            WSTestClientFileImport.FileUpload.AuthenticateConnectionResponse retVal = ((WSTestClientFileImport.FileUpload.FileUploadSoap)(this)).AuthenticateConnection(inValue);
            return retVal.Body.AuthenticateConnectionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.FileUpload.ReceiveScannerFileResponse WSTestClientFileImport.FileUpload.FileUploadSoap.ReceiveScannerFile(WSTestClientFileImport.FileUpload.ReceiveScannerFileRequest request) {
            return base.Channel.ReceiveScannerFile(request);
        }
        
        public long ReceiveScannerFile(string sUserName, string sKey, string sApplication, string sFileName, byte[] aFile, int iEntityCode) {
            WSTestClientFileImport.FileUpload.ReceiveScannerFileRequest inValue = new WSTestClientFileImport.FileUpload.ReceiveScannerFileRequest();
            inValue.Body = new WSTestClientFileImport.FileUpload.ReceiveScannerFileRequestBody();
            inValue.Body.sUserName = sUserName;
            inValue.Body.sKey = sKey;
            inValue.Body.sApplication = sApplication;
            inValue.Body.sFileName = sFileName;
            inValue.Body.aFile = aFile;
            inValue.Body.iEntityCode = iEntityCode;
            WSTestClientFileImport.FileUpload.ReceiveScannerFileResponse retVal = ((WSTestClientFileImport.FileUpload.FileUploadSoap)(this)).ReceiveScannerFile(inValue);
            return retVal.Body.ReceiveScannerFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTestClientFileImport.FileUpload.ReceiveFileResponse WSTestClientFileImport.FileUpload.FileUploadSoap.ReceiveFile(WSTestClientFileImport.FileUpload.ReceiveFileRequest request) {
            return base.Channel.ReceiveFile(request);
        }
        
        public long ReceiveFile(string sUserName, string sKey, string sApplication, string sFileName, byte[] aFile, string sImportCode, int iEntityCode) {
            WSTestClientFileImport.FileUpload.ReceiveFileRequest inValue = new WSTestClientFileImport.FileUpload.ReceiveFileRequest();
            inValue.Body = new WSTestClientFileImport.FileUpload.ReceiveFileRequestBody();
            inValue.Body.sUserName = sUserName;
            inValue.Body.sKey = sKey;
            inValue.Body.sApplication = sApplication;
            inValue.Body.sFileName = sFileName;
            inValue.Body.aFile = aFile;
            inValue.Body.sImportCode = sImportCode;
            inValue.Body.iEntityCode = iEntityCode;
            WSTestClientFileImport.FileUpload.ReceiveFileResponse retVal = ((WSTestClientFileImport.FileUpload.FileUploadSoap)(this)).ReceiveFile(inValue);
            return retVal.Body.ReceiveFileResult;
        }
    }
}
