﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysClientes.WcfSituacaoClientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SituacaoCliente", Namespace="http://schemas.datacontract.org/2004/07/WCF_CRUD")]
    [System.SerializableAttribute()]
    public partial class SituacaoCliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GetSetSICL_DESCRICAOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> GetSetSICL_PK_IDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GetSetSICL_DESCRICAO {
            get {
                return this.GetSetSICL_DESCRICAOField;
            }
            set {
                if ((object.ReferenceEquals(this.GetSetSICL_DESCRICAOField, value) != true)) {
                    this.GetSetSICL_DESCRICAOField = value;
                    this.RaisePropertyChanged("GetSetSICL_DESCRICAO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GetSetSICL_PK_ID {
            get {
                return this.GetSetSICL_PK_IDField;
            }
            set {
                if ((this.GetSetSICL_PK_IDField.Equals(value) != true)) {
                    this.GetSetSICL_PK_IDField = value;
                    this.RaisePropertyChanged("GetSetSICL_PK_ID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfSituacaoClientes.IServiceSituacaoCliente")]
    public interface IServiceSituacaoCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/InsertSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/InsertSituacaoClienteResponse")]
        string InsertSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/InsertSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/InsertSituacaoClienteResponse")]
        System.Threading.Tasks.Task<string> InsertSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/GetSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/GetSituacaoClienteResponse")]
        System.Data.DataSet GetSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/GetSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/GetSituacaoClienteResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/FetchUpdatedRecords", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/FetchUpdatedRecordsResponse")]
        System.Data.DataSet FetchUpdatedRecords(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/FetchUpdatedRecords", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/FetchUpdatedRecordsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FetchUpdatedRecordsAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/UpdateSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/UpdateSituacaoClienteResponse")]
        string UpdateSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/UpdateSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/UpdateSituacaoClienteResponse")]
        System.Threading.Tasks.Task<string> UpdateSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/DeleteSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/DeleteSituacaoClienteResponse")]
        bool DeleteSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSituacaoCliente/DeleteSituacaoCliente", ReplyAction="http://tempuri.org/IServiceSituacaoCliente/DeleteSituacaoClienteResponse")]
        System.Threading.Tasks.Task<bool> DeleteSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSituacaoClienteChannel : SysClientes.WcfSituacaoClientes.IServiceSituacaoCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSituacaoClienteClient : System.ServiceModel.ClientBase<SysClientes.WcfSituacaoClientes.IServiceSituacaoCliente>, SysClientes.WcfSituacaoClientes.IServiceSituacaoCliente {
        
        public ServiceSituacaoClienteClient() {
        }
        
        public ServiceSituacaoClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSituacaoClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSituacaoClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSituacaoClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.InsertSituacaoCliente(eDatils);
        }
        
        public System.Threading.Tasks.Task<string> InsertSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.InsertSituacaoClienteAsync(eDatils);
        }
        
        public System.Data.DataSet GetSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.GetSituacaoCliente(eDatils);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.GetSituacaoClienteAsync(eDatils);
        }
        
        public System.Data.DataSet FetchUpdatedRecords(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.FetchUpdatedRecords(eDatils);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FetchUpdatedRecordsAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.FetchUpdatedRecordsAsync(eDatils);
        }
        
        public string UpdateSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.UpdateSituacaoCliente(eDatils);
        }
        
        public System.Threading.Tasks.Task<string> UpdateSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.UpdateSituacaoClienteAsync(eDatils);
        }
        
        public bool DeleteSituacaoCliente(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.DeleteSituacaoCliente(eDatils);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSituacaoClienteAsync(SysClientes.WcfSituacaoClientes.SituacaoCliente eDatils) {
            return base.Channel.DeleteSituacaoClienteAsync(eDatils);
        }
    }
}
