﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Proxies
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:WebsIFAC/PersonneIFAC", ConfigurationName="WCF.Proxies.PersonneIFAC")]
    public interface PersonneIFAC
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectAll", ReplyAction="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectAllResponse")]
        System.Collections.Generic.List<WebsBO.PersonneBO> SelectAll();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectAll", ReplyAction="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectAllResponse")]
        System.IAsyncResult BeginSelectAll(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<WebsBO.PersonneBO> EndSelectAll(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectById", ReplyAction="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectByIdResponse")]
        System.Collections.Generic.List<WebsBO.PersonneBO> SelectById(int pId);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectById", ReplyAction="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectByIdResponse")]
        System.IAsyncResult BeginSelectById(int pId, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<WebsBO.PersonneBO> EndSelectById(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectByName", ReplyAction="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectByNameResponse")]
        System.Collections.Generic.List<WebsBO.PersonneBO> SelectByName(string pName);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectByName", ReplyAction="urn:WebsIFAC/PersonneIFAC/PersonneIFAC/SelectByNameResponse")]
        System.IAsyncResult BeginSelectByName(string pName, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<WebsBO.PersonneBO> EndSelectByName(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PersonneIFACChannel : WCF.Proxies.PersonneIFAC, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonneIFACClient : System.ServiceModel.ClientBase<WCF.Proxies.PersonneIFAC>, WCF.Proxies.PersonneIFAC
    {
        
        public PersonneIFACClient()
        {
        }
        
        public PersonneIFACClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public PersonneIFACClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PersonneIFACClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PersonneIFACClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<WebsBO.PersonneBO> SelectAll()
        {
            return base.Channel.SelectAll();
        }
        
        public System.IAsyncResult BeginSelectAll(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectAll(callback, asyncState);
        }
        
        public System.Collections.Generic.List<WebsBO.PersonneBO> EndSelectAll(System.IAsyncResult result)
        {
            return base.Channel.EndSelectAll(result);
        }
        
        public System.Collections.Generic.List<WebsBO.PersonneBO> SelectById(int pId)
        {
            return base.Channel.SelectById(pId);
        }
        
        public System.IAsyncResult BeginSelectById(int pId, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectById(pId, callback, asyncState);
        }
        
        public System.Collections.Generic.List<WebsBO.PersonneBO> EndSelectById(System.IAsyncResult result)
        {
            return base.Channel.EndSelectById(result);
        }
        
        public System.Collections.Generic.List<WebsBO.PersonneBO> SelectByName(string pName)
        {
            return base.Channel.SelectByName(pName);
        }
        
        public System.IAsyncResult BeginSelectByName(string pName, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectByName(pName, callback, asyncState);
        }
        
        public System.Collections.Generic.List<WebsBO.PersonneBO> EndSelectByName(System.IAsyncResult result)
        {
            return base.Channel.EndSelectByName(result);
        }
    }
}
