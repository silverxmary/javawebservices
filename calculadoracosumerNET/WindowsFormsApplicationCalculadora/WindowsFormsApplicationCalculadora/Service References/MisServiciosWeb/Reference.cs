﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplicationCalculadora.MisServiciosWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.java.curso.edu/", ConfigurationName="MisServiciosWeb.HolaMundoWebService")]
    public interface HolaMundoWebService {
        
        // CODEGEN: Generating message contract since message part namespace () does not match the default value (http://ws.java.curso.edu/)
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.java.curso.edu/HolaMundoWebService/sumarRequest", ReplyAction="http://ws.java.curso.edu/HolaMundoWebService/sumarResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarResponse sumar(WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.java.curso.edu/HolaMundoWebService/sumarRequest", ReplyAction="http://ws.java.curso.edu/HolaMundoWebService/sumarResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarResponse> sumarAsync(WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.java.curso.edu/HolaMundoWebService/helloRequest", ReplyAction="http://ws.java.curso.edu/HolaMundoWebService/helloResponse")]
        WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponse hello(WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.java.curso.edu/HolaMundoWebService/helloRequest", ReplyAction="http://ws.java.curso.edu/HolaMundoWebService/helloResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponse> helloAsync(WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sumar", WrapperNamespace="http://ws.java.curso.edu/", IsWrapped=true)]
    public partial class sumarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int num2;
        
        public sumarRequest() {
        }
        
        public sumarRequest(int num1, int num2) {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sumarResponse", WrapperNamespace="http://ws.java.curso.edu/", IsWrapped=true)]
    public partial class sumarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public sumarResponse() {
        }
        
        public sumarResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://ws.java.curso.edu/", Order=0)]
        public WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://ws.java.curso.edu/", Order=0)]
        public WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HolaMundoWebServiceChannel : WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HolaMundoWebServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService>, WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService {
        
        public HolaMundoWebServiceClient() {
        }
        
        public HolaMundoWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HolaMundoWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HolaMundoWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HolaMundoWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarResponse WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService.sumar(WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest request) {
            return base.Channel.sumar(request);
        }
        
        public int sumar(int num1, int num2) {
            WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest inValue = new WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarResponse retVal = ((WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService)(this)).sumar(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarResponse> WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService.sumarAsync(WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest request) {
            return base.Channel.sumarAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarResponse> sumarAsync(int num1, int num2) {
            WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest inValue = new WindowsFormsApplicationCalculadora.MisServiciosWeb.sumarRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            return ((WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService)(this)).sumarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponse WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService.hello(WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest inValue = new WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest();
            inValue.Body = new WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequestBody();
            inValue.Body.name = name;
            WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponse retVal = ((WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponse> WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService.helloAsync(WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplicationCalculadora.MisServiciosWeb.helloResponse> helloAsync(string name) {
            WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest inValue = new WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequest();
            inValue.Body = new WindowsFormsApplicationCalculadora.MisServiciosWeb.helloRequestBody();
            inValue.Body.name = name;
            return ((WindowsFormsApplicationCalculadora.MisServiciosWeb.HolaMundoWebService)(this)).helloAsync(inValue);
        }
    }
}
