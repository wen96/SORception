﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eggplant.ServiceTaller {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedTaller", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class ExposedTaller : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedSolicitud", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class ExposedSolicitud : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Eggplant.ServiceTaller.ExposedLineaSolicitud[] lineasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int taller_idField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Eggplant.ServiceTaller.ExposedLineaSolicitud[] lineas {
            get {
                return this.lineasField;
            }
            set {
                if ((object.ReferenceEquals(this.lineasField, value) != true)) {
                    this.lineasField = value;
                    this.RaisePropertyChanged("lineas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int taller_id {
            get {
                return this.taller_idField;
            }
            set {
                if ((this.taller_idField.Equals(value) != true)) {
                    this.taller_idField = value;
                    this.RaisePropertyChanged("taller_id");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedLineaSolicitud", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class ExposedLineaSolicitud : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantityField;
        
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTaller.IGestionTaller")]
    public interface IGestionTaller {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getTaller", ReplyAction="http://tempuri.org/IGestionTaller/getTallerResponse")]
        Eggplant.ServiceTaller.ExposedTaller getTaller(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getTaller", ReplyAction="http://tempuri.org/IGestionTaller/getTallerResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedTaller> getTallerAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/addTaller", ReplyAction="http://tempuri.org/IGestionTaller/addTallerResponse")]
        string addTaller(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/addTaller", ReplyAction="http://tempuri.org/IGestionTaller/addTallerResponse")]
        System.Threading.Tasks.Task<string> addTallerAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getState", ReplyAction="http://tempuri.org/IGestionTaller/getStateResponse")]
        int getState(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getState", ReplyAction="http://tempuri.org/IGestionTaller/getStateResponse")]
        System.Threading.Tasks.Task<int> getStateAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/putTaller", ReplyAction="http://tempuri.org/IGestionTaller/putTallerResponse")]
        int putTaller(Eggplant.ServiceTaller.ExposedTaller t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/putTaller", ReplyAction="http://tempuri.org/IGestionTaller/putTallerResponse")]
        System.Threading.Tasks.Task<int> putTallerAsync(Eggplant.ServiceTaller.ExposedTaller t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/deleteTaller", ReplyAction="http://tempuri.org/IGestionTaller/deleteTallerResponse")]
        int deleteTaller(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/deleteTaller", ReplyAction="http://tempuri.org/IGestionTaller/deleteTallerResponse")]
        System.Threading.Tasks.Task<int> deleteTallerAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudResponse")]
        Eggplant.ServiceTaller.ExposedSolicitud getSolicitud(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud> getSolicitudAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/addSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/addSolicitudResponse")]
        int addSolicitud(Eggplant.ServiceTaller.ExposedSolicitud s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/addSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/addSolicitudResponse")]
        System.Threading.Tasks.Task<int> addSolicitudAsync(Eggplant.ServiceTaller.ExposedSolicitud s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/putSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/putSolicitudResponse")]
        int putSolicitud(Eggplant.ServiceTaller.ExposedSolicitud s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/putSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/putSolicitudResponse")]
        System.Threading.Tasks.Task<int> putSolicitudAsync(Eggplant.ServiceTaller.ExposedSolicitud s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/deleteSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/deleteSolicitudResponse")]
        int deleteSolicitud(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/deleteSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/deleteSolicitudResponse")]
        System.Threading.Tasks.Task<int> deleteSolicitudAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitudes", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudesResponse")]
        Eggplant.ServiceTaller.ExposedSolicitud[] getSolicitudes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitudes", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudesResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud[]> getSolicitudesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestionTallerChannel : Eggplant.ServiceTaller.IGestionTaller, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestionTallerClient : System.ServiceModel.ClientBase<Eggplant.ServiceTaller.IGestionTaller>, Eggplant.ServiceTaller.IGestionTaller {
        
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
        
        public Eggplant.ServiceTaller.ExposedTaller getTaller(string token) {
            return base.Channel.getTaller(token);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedTaller> getTallerAsync(string token) {
            return base.Channel.getTallerAsync(token);
        }
        
        public string addTaller(string nombre) {
            return base.Channel.addTaller(nombre);
        }
        
        public System.Threading.Tasks.Task<string> addTallerAsync(string nombre) {
            return base.Channel.addTallerAsync(nombre);
        }
        
        public int getState(string token) {
            return base.Channel.getState(token);
        }
        
        public System.Threading.Tasks.Task<int> getStateAsync(string token) {
            return base.Channel.getStateAsync(token);
        }
        
        public int putTaller(Eggplant.ServiceTaller.ExposedTaller t) {
            return base.Channel.putTaller(t);
        }
        
        public System.Threading.Tasks.Task<int> putTallerAsync(Eggplant.ServiceTaller.ExposedTaller t) {
            return base.Channel.putTallerAsync(t);
        }
        
        public int deleteTaller(string token) {
            return base.Channel.deleteTaller(token);
        }
        
        public System.Threading.Tasks.Task<int> deleteTallerAsync(string token) {
            return base.Channel.deleteTallerAsync(token);
        }
        
        public Eggplant.ServiceTaller.ExposedSolicitud getSolicitud(int id) {
            return base.Channel.getSolicitud(id);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud> getSolicitudAsync(int id) {
            return base.Channel.getSolicitudAsync(id);
        }
        
        public int addSolicitud(Eggplant.ServiceTaller.ExposedSolicitud s) {
            return base.Channel.addSolicitud(s);
        }
        
        public System.Threading.Tasks.Task<int> addSolicitudAsync(Eggplant.ServiceTaller.ExposedSolicitud s) {
            return base.Channel.addSolicitudAsync(s);
        }
        
        public int putSolicitud(Eggplant.ServiceTaller.ExposedSolicitud s) {
            return base.Channel.putSolicitud(s);
        }
        
        public System.Threading.Tasks.Task<int> putSolicitudAsync(Eggplant.ServiceTaller.ExposedSolicitud s) {
            return base.Channel.putSolicitudAsync(s);
        }
        
        public int deleteSolicitud(int id) {
            return base.Channel.deleteSolicitud(id);
        }
        
        public System.Threading.Tasks.Task<int> deleteSolicitudAsync(int id) {
            return base.Channel.deleteSolicitudAsync(id);
        }
        
        public Eggplant.ServiceTaller.ExposedSolicitud[] getSolicitudes() {
            return base.Channel.getSolicitudes();
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud[]> getSolicitudesAsync() {
            return base.Channel.getSolicitudesAsync();
        }
    }
}
