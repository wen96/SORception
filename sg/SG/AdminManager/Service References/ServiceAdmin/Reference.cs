﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminManager.ServiceAdmin {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Desguace", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class Desguace : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminManager.ServiceAdmin.Oferta[] OfertaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool activeField;
        
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
        public AdminManager.ServiceAdmin.Oferta[] Oferta {
            get {
                return this.OfertaField;
            }
            set {
                if ((object.ReferenceEquals(this.OfertaField, value) != true)) {
                    this.OfertaField = value;
                    this.RaisePropertyChanged("Oferta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool active {
            get {
                return this.activeField;
            }
            set {
                if ((this.activeField.Equals(value) != true)) {
                    this.activeField = value;
                    this.RaisePropertyChanged("active");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Oferta", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class Oferta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminManager.ServiceAdmin.Desguace DesguaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Desguace_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Desguace_id1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminManager.ServiceAdmin.LineaPedidoOferta[] LineaPedidoOfertaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminManager.ServiceAdmin.Taller TallerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TallerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TallerId1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_en_desguaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stateField;
        
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
        public AdminManager.ServiceAdmin.Desguace Desguace {
            get {
                return this.DesguaceField;
            }
            set {
                if ((object.ReferenceEquals(this.DesguaceField, value) != true)) {
                    this.DesguaceField = value;
                    this.RaisePropertyChanged("Desguace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Desguace_id {
            get {
                return this.Desguace_idField;
            }
            set {
                if ((this.Desguace_idField.Equals(value) != true)) {
                    this.Desguace_idField = value;
                    this.RaisePropertyChanged("Desguace_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Desguace_id1 {
            get {
                return this.Desguace_id1Field;
            }
            set {
                if ((this.Desguace_id1Field.Equals(value) != true)) {
                    this.Desguace_id1Field = value;
                    this.RaisePropertyChanged("Desguace_id1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminManager.ServiceAdmin.LineaPedidoOferta[] LineaPedidoOferta {
            get {
                return this.LineaPedidoOfertaField;
            }
            set {
                if ((object.ReferenceEquals(this.LineaPedidoOfertaField, value) != true)) {
                    this.LineaPedidoOfertaField = value;
                    this.RaisePropertyChanged("LineaPedidoOferta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminManager.ServiceAdmin.Taller Taller {
            get {
                return this.TallerField;
            }
            set {
                if ((object.ReferenceEquals(this.TallerField, value) != true)) {
                    this.TallerField = value;
                    this.RaisePropertyChanged("Taller");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TallerId {
            get {
                return this.TallerIdField;
            }
            set {
                if ((this.TallerIdField.Equals(value) != true)) {
                    this.TallerIdField = value;
                    this.RaisePropertyChanged("TallerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TallerId1 {
            get {
                return this.TallerId1Field;
            }
            set {
                if ((this.TallerId1Field.Equals(value) != true)) {
                    this.TallerId1Field = value;
                    this.RaisePropertyChanged("TallerId1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
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
        public int id_en_desguace {
            get {
                return this.id_en_desguaceField;
            }
            set {
                if ((this.id_en_desguaceField.Equals(value) != true)) {
                    this.id_en_desguaceField = value;
                    this.RaisePropertyChanged("id_en_desguace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string state {
            get {
                return this.stateField;
            }
            set {
                if ((object.ReferenceEquals(this.stateField, value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Taller", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class Taller : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminManager.ServiceAdmin.Oferta[] OfertasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool activeField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminManager.ServiceAdmin.Oferta[] Ofertas {
            get {
                return this.OfertasField;
            }
            set {
                if ((object.ReferenceEquals(this.OfertasField, value) != true)) {
                    this.OfertasField = value;
                    this.RaisePropertyChanged("Ofertas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool active {
            get {
                return this.activeField;
            }
            set {
                if ((this.activeField.Equals(value) != true)) {
                    this.activeField = value;
                    this.RaisePropertyChanged("active");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LineaPedidoOferta", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    [System.SerializableAttribute()]
    public partial class LineaPedidoOferta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminManager.ServiceAdmin.Oferta OfertaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Oferta_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_en_desguaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
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
        public AdminManager.ServiceAdmin.Oferta Oferta {
            get {
                return this.OfertaField;
            }
            set {
                if ((object.ReferenceEquals(this.OfertaField, value) != true)) {
                    this.OfertaField = value;
                    this.RaisePropertyChanged("Oferta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Oferta_id {
            get {
                return this.Oferta_idField;
            }
            set {
                if ((this.Oferta_idField.Equals(value) != true)) {
                    this.Oferta_idField = value;
                    this.RaisePropertyChanged("Oferta_id");
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
        public int id_en_desguace {
            get {
                return this.id_en_desguaceField;
            }
            set {
                if ((this.id_en_desguaceField.Equals(value) != true)) {
                    this.id_en_desguaceField = value;
                    this.RaisePropertyChanged("id_en_desguace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAdmin.IGestionAdmin")]
    public interface IGestionAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/getDesguaces", ReplyAction="http://tempuri.org/IGestionAdmin/getDesguacesResponse")]
        AdminManager.ServiceAdmin.Desguace[] getDesguaces();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/getDesguaces", ReplyAction="http://tempuri.org/IGestionAdmin/getDesguacesResponse")]
        System.Threading.Tasks.Task<AdminManager.ServiceAdmin.Desguace[]> getDesguacesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/getTalleres", ReplyAction="http://tempuri.org/IGestionAdmin/getTalleresResponse")]
        AdminManager.ServiceAdmin.Taller[] getTalleres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/getTalleres", ReplyAction="http://tempuri.org/IGestionAdmin/getTalleresResponse")]
        System.Threading.Tasks.Task<AdminManager.ServiceAdmin.Taller[]> getTalleresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/activeDesguace", ReplyAction="http://tempuri.org/IGestionAdmin/activeDesguaceResponse")]
        int activeDesguace(int id, bool active);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/activeDesguace", ReplyAction="http://tempuri.org/IGestionAdmin/activeDesguaceResponse")]
        System.Threading.Tasks.Task<int> activeDesguaceAsync(int id, bool active);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/activeTaller", ReplyAction="http://tempuri.org/IGestionAdmin/activeTallerResponse")]
        int activeTaller(int id, bool active);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/activeTaller", ReplyAction="http://tempuri.org/IGestionAdmin/activeTallerResponse")]
        System.Threading.Tasks.Task<int> activeTallerAsync(int id, bool active);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/deleteTaller", ReplyAction="http://tempuri.org/IGestionAdmin/deleteTallerResponse")]
        int deleteTaller(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/deleteTaller", ReplyAction="http://tempuri.org/IGestionAdmin/deleteTallerResponse")]
        System.Threading.Tasks.Task<int> deleteTallerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/deleteDesguace", ReplyAction="http://tempuri.org/IGestionAdmin/deleteDesguaceResponse")]
        int deleteDesguace(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionAdmin/deleteDesguace", ReplyAction="http://tempuri.org/IGestionAdmin/deleteDesguaceResponse")]
        System.Threading.Tasks.Task<int> deleteDesguaceAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestionAdminChannel : AdminManager.ServiceAdmin.IGestionAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestionAdminClient : System.ServiceModel.ClientBase<AdminManager.ServiceAdmin.IGestionAdmin>, AdminManager.ServiceAdmin.IGestionAdmin {
        
        public GestionAdminClient() {
        }
        
        public GestionAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GestionAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AdminManager.ServiceAdmin.Desguace[] getDesguaces() {
            return base.Channel.getDesguaces();
        }
        
        public System.Threading.Tasks.Task<AdminManager.ServiceAdmin.Desguace[]> getDesguacesAsync() {
            return base.Channel.getDesguacesAsync();
        }
        
        public AdminManager.ServiceAdmin.Taller[] getTalleres() {
            return base.Channel.getTalleres();
        }
        
        public System.Threading.Tasks.Task<AdminManager.ServiceAdmin.Taller[]> getTalleresAsync() {
            return base.Channel.getTalleresAsync();
        }
        
        public int activeDesguace(int id, bool active) {
            return base.Channel.activeDesguace(id, active);
        }
        
        public System.Threading.Tasks.Task<int> activeDesguaceAsync(int id, bool active) {
            return base.Channel.activeDesguaceAsync(id, active);
        }
        
        public int activeTaller(int id, bool active) {
            return base.Channel.activeTaller(id, active);
        }
        
        public System.Threading.Tasks.Task<int> activeTallerAsync(int id, bool active) {
            return base.Channel.activeTallerAsync(id, active);
        }
        
        public int deleteTaller(int id) {
            return base.Channel.deleteTaller(id);
        }
        
        public System.Threading.Tasks.Task<int> deleteTallerAsync(int id) {
            return base.Channel.deleteTallerAsync(id);
        }
        
        public int deleteDesguace(int id) {
            return base.Channel.deleteDesguace(id);
        }
        
        public System.Threading.Tasks.Task<int> deleteDesguaceAsync(int id) {
            return base.Channel.deleteDesguaceAsync(id);
        }
    }
}
