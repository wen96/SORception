﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Berenjena.ServiceTaller {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTaller.IGestionTaller")]
    public interface IGestionTaller {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/addNewTaller", ReplyAction="http://tempuri.org/IGestionTaller/addNewTallerResponse")]
        int addNewTaller(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/addNewTaller", ReplyAction="http://tempuri.org/IGestionTaller/addNewTallerResponse")]
        System.Threading.Tasks.Task<int> addNewTallerAsync(string nombre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestionTallerChannel : Berenjena.ServiceTaller.IGestionTaller, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestionTallerClient : System.ServiceModel.ClientBase<Berenjena.ServiceTaller.IGestionTaller>, Berenjena.ServiceTaller.IGestionTaller {
        
        public GestionTallerClient() {
        }
        
        public GestionTallerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GestionTallerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionTallerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionTallerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int addNewTaller(string nombre) {
            return base.Channel.addNewTaller(nombre);
        }
        
        public System.Threading.Tasks.Task<int> addNewTallerAsync(string nombre) {
            return base.Channel.addNewTallerAsync(nombre);
        }
    }
}
