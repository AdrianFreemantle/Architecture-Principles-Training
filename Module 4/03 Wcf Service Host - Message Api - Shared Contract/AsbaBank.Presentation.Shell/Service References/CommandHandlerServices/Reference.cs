﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsbaBank.Presentation.Shell.CommandHandlerServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Asba.Commands", ConfigurationName="CommandHandlerServices.CommandHandlerService")]
    public interface CommandHandlerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="Asba.Commands/CommandHandlerService/Execute", ReplyAction="Asba.Commands/CommandHandlerService/ExecuteResponse")]
        void Execute(string command);
        
        [System.ServiceModel.OperationContractAttribute(Action="Asba.Commands/CommandHandlerService/Execute", ReplyAction="Asba.Commands/CommandHandlerService/ExecuteResponse")]
        System.Threading.Tasks.Task ExecuteAsync(string command);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CommandHandlerServiceChannel : AsbaBank.Presentation.Shell.CommandHandlerServices.CommandHandlerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommandHandlerServiceClient : System.ServiceModel.ClientBase<AsbaBank.Presentation.Shell.CommandHandlerServices.CommandHandlerService>, AsbaBank.Presentation.Shell.CommandHandlerServices.CommandHandlerService {
        
        public CommandHandlerServiceClient() {
        }
        
        public CommandHandlerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommandHandlerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommandHandlerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommandHandlerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Execute(string command) {
            base.Channel.Execute(command);
        }
        
        public System.Threading.Tasks.Task ExecuteAsync(string command) {
            return base.Channel.ExecuteAsync(command);
        }
    }
}