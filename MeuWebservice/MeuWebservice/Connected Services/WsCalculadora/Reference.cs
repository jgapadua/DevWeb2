//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeuWebservice.WsCalculadora {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsCalculadora.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Somar", ReplyAction="*")]
        int Somar(int numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Somar", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SomarAsync(int numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicar", ReplyAction="*")]
        int Multiplicar(int numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicar", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplicarAsync(int numero1, int numero2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : MeuWebservice.WsCalculadora.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<MeuWebservice.WsCalculadora.WebService1Soap>, MeuWebservice.WsCalculadora.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Somar(int numero1, int numero2) {
            return base.Channel.Somar(numero1, numero2);
        }
        
        public System.Threading.Tasks.Task<int> SomarAsync(int numero1, int numero2) {
            return base.Channel.SomarAsync(numero1, numero2);
        }
        
        public int Multiplicar(int numero1, int numero2) {
            return base.Channel.Multiplicar(numero1, numero2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicarAsync(int numero1, int numero2) {
            return base.Channel.MultiplicarAsync(numero1, numero2);
        }
    }
}
