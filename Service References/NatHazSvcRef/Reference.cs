﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsodAsgmnt5.NatHazSvcRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NatHazSvcRef.INatHazService1")]
    public interface INatHazService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INatHazService1/NaturalHazards", ReplyAction="http://tempuri.org/INatHazService1/NaturalHazardsResponse")]
        decimal NaturalHazards(decimal latitude, decimal longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INatHazService1/NaturalHazards", ReplyAction="http://tempuri.org/INatHazService1/NaturalHazardsResponse")]
        System.Threading.Tasks.Task<decimal> NaturalHazardsAsync(decimal latitude, decimal longitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INatHazService1Channel : DsodAsgmnt5.NatHazSvcRef.INatHazService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NatHazService1Client : System.ServiceModel.ClientBase<DsodAsgmnt5.NatHazSvcRef.INatHazService1>, DsodAsgmnt5.NatHazSvcRef.INatHazService1 {
        
        public NatHazService1Client() {
        }
        
        public NatHazService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NatHazService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NatHazService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NatHazService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal NaturalHazards(decimal latitude, decimal longitude) {
            return base.Channel.NaturalHazards(latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<decimal> NaturalHazardsAsync(decimal latitude, decimal longitude) {
            return base.Channel.NaturalHazardsAsync(latitude, longitude);
        }
    }
}