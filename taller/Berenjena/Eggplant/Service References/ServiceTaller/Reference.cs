﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eggplant.ServiceTaller {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedTaller", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class ExposedTaller : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TokenResponse", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class TokenResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Eggplant.ServiceTaller.TokenResponseCode statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenField;
        
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
        public Eggplant.ServiceTaller.TokenResponseCode status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenField, value) != true)) {
                    this.tokenField = value;
                    this.RaisePropertyChanged("token");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TokenResponse.Code", Namespace="http://schemas.datacontract.org/2004/07/ManagerSystem")]
    public enum TokenResponseCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATED = 201,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ACCEPTED = 202,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NON_AUTHORITATIVE = 203,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BAD_REQUEST = 400,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NOT_FOUND = 404,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedSolicitud", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class ExposedSolicitud : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime deadlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_en_tallerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Eggplant.ServiceTaller.ExposedLineaSolicitud[] lineasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public System.DateTime deadline {
            get {
                return this.deadlineField;
            }
            set {
                if ((this.deadlineField.Equals(value) != true)) {
                    this.deadlineField = value;
                    this.RaisePropertyChanged("deadline");
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
        public int id_en_taller {
            get {
                return this.id_en_tallerField;
            }
            set {
                if ((this.id_en_tallerField.Equals(value) != true)) {
                    this.id_en_tallerField = value;
                    this.RaisePropertyChanged("id_en_taller");
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedLineaSolicitud", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class ExposedLineaSolicitud : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string actionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_en_tallerField;
        
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
        public string action {
            get {
                return this.actionField;
            }
            set {
                if ((object.ReferenceEquals(this.actionField, value) != true)) {
                    this.actionField = value;
                    this.RaisePropertyChanged("action");
                }
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
        public int id_en_taller {
            get {
                return this.id_en_tallerField;
            }
            set {
                if ((this.id_en_tallerField.Equals(value) != true)) {
                    this.id_en_tallerField = value;
                    this.RaisePropertyChanged("id_en_taller");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedOferta", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class ExposedOferta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string desguace_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Eggplant.ServiceTaller.ExposedLineaOferta[] lineasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int solicitud_idField;
        
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
        public string desguace_id {
            get {
                return this.desguace_idField;
            }
            set {
                if ((object.ReferenceEquals(this.desguace_idField, value) != true)) {
                    this.desguace_idField = value;
                    this.RaisePropertyChanged("desguace_id");
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
        public Eggplant.ServiceTaller.ExposedLineaOferta[] lineas {
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
        public int solicitud_id {
            get {
                return this.solicitud_idField;
            }
            set {
                if ((this.solicitud_idField.Equals(value) != true)) {
                    this.solicitud_idField = value;
                    this.RaisePropertyChanged("solicitud_id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposedLineaOferta", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class ExposedLineaOferta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_en_desguaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string notesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceField;
        
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
        public string notes {
            get {
                return this.notesField;
            }
            set {
                if ((object.ReferenceEquals(this.notesField, value) != true)) {
                    this.notesField = value;
                    this.RaisePropertyChanged("notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double price {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TallerResponse", Namespace="http://sorception.azurewebsites.net/")]
    [System.SerializableAttribute()]
    public partial class TallerResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int oferta_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Eggplant.ServiceTaller.TallerResponse.SelectedLine[] selected_linesField;
        
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
        public int oferta_id {
            get {
                return this.oferta_idField;
            }
            set {
                if ((this.oferta_idField.Equals(value) != true)) {
                    this.oferta_idField = value;
                    this.RaisePropertyChanged("oferta_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Eggplant.ServiceTaller.TallerResponse.SelectedLine[] selected_lines {
            get {
                return this.selected_linesField;
            }
            set {
                if ((object.ReferenceEquals(this.selected_linesField, value) != true)) {
                    this.selected_linesField = value;
                    this.RaisePropertyChanged("selected_lines");
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
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="TallerResponse.SelectedLine", Namespace="http://sorception.azurewebsites.net/")]
        [System.SerializableAttribute()]
        public partial class SelectedLine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private int line_idField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private int quantityField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public int line_id {
                get {
                    return this.line_idField;
                }
                set {
                    if ((this.line_idField.Equals(value) != true)) {
                        this.line_idField = value;
                        this.RaisePropertyChanged("line_id");
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTaller.IGestionTaller")]
    public interface IGestionTaller {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/signUp", ReplyAction="http://tempuri.org/IGestionTaller/signUpResponse")]
        Eggplant.ServiceTaller.TokenResponse signUp(Eggplant.ServiceTaller.ExposedTaller et);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/signUp", ReplyAction="http://tempuri.org/IGestionTaller/signUpResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.TokenResponse> signUpAsync(Eggplant.ServiceTaller.ExposedTaller et);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getState", ReplyAction="http://tempuri.org/IGestionTaller/getStateResponse")]
        Eggplant.ServiceTaller.TokenResponse getState(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getState", ReplyAction="http://tempuri.org/IGestionTaller/getStateResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.TokenResponse> getStateAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/putTaller", ReplyAction="http://tempuri.org/IGestionTaller/putTallerResponse")]
        int putTaller(Eggplant.ServiceTaller.ExposedTaller t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/putTaller", ReplyAction="http://tempuri.org/IGestionTaller/putTallerResponse")]
        System.Threading.Tasks.Task<int> putTallerAsync(Eggplant.ServiceTaller.ExposedTaller t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/deleteTaller", ReplyAction="http://tempuri.org/IGestionTaller/deleteTallerResponse")]
        int deleteTaller();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/deleteTaller", ReplyAction="http://tempuri.org/IGestionTaller/deleteTallerResponse")]
        System.Threading.Tasks.Task<int> deleteTallerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudResponse")]
        Eggplant.ServiceTaller.ExposedSolicitud getSolicitud(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitud", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud> getSolicitudAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitudes", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudesResponse")]
        Eggplant.ServiceTaller.ExposedSolicitud[] getSolicitudes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getSolicitudes", ReplyAction="http://tempuri.org/IGestionTaller/getSolicitudesResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud[]> getSolicitudesAsync();
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getOfertas", ReplyAction="http://tempuri.org/IGestionTaller/getOfertasResponse")]
        Eggplant.ServiceTaller.ExposedOferta[] getOfertas(int solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getOfertas", ReplyAction="http://tempuri.org/IGestionTaller/getOfertasResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedOferta[]> getOfertasAsync(int solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getOferta", ReplyAction="http://tempuri.org/IGestionTaller/getOfertaResponse")]
        Eggplant.ServiceTaller.ExposedOferta getOferta(int oferta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/getOferta", ReplyAction="http://tempuri.org/IGestionTaller/getOfertaResponse")]
        System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedOferta> getOfertaAsync(int oferta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/selectOferta", ReplyAction="http://tempuri.org/IGestionTaller/selectOfertaResponse")]
        int selectOferta(Eggplant.ServiceTaller.TallerResponse r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionTaller/selectOferta", ReplyAction="http://tempuri.org/IGestionTaller/selectOfertaResponse")]
        System.Threading.Tasks.Task<int> selectOfertaAsync(Eggplant.ServiceTaller.TallerResponse r);
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
        
        public Eggplant.ServiceTaller.TokenResponse signUp(Eggplant.ServiceTaller.ExposedTaller et) {
            return base.Channel.signUp(et);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.TokenResponse> signUpAsync(Eggplant.ServiceTaller.ExposedTaller et) {
            return base.Channel.signUpAsync(et);
        }
        
        public Eggplant.ServiceTaller.TokenResponse getState(string token) {
            return base.Channel.getState(token);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.TokenResponse> getStateAsync(string token) {
            return base.Channel.getStateAsync(token);
        }
        
        public int putTaller(Eggplant.ServiceTaller.ExposedTaller t) {
            return base.Channel.putTaller(t);
        }
        
        public System.Threading.Tasks.Task<int> putTallerAsync(Eggplant.ServiceTaller.ExposedTaller t) {
            return base.Channel.putTallerAsync(t);
        }
        
        public int deleteTaller() {
            return base.Channel.deleteTaller();
        }
        
        public System.Threading.Tasks.Task<int> deleteTallerAsync() {
            return base.Channel.deleteTallerAsync();
        }
        
        public Eggplant.ServiceTaller.ExposedSolicitud getSolicitud(int id) {
            return base.Channel.getSolicitud(id);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud> getSolicitudAsync(int id) {
            return base.Channel.getSolicitudAsync(id);
        }
        
        public Eggplant.ServiceTaller.ExposedSolicitud[] getSolicitudes() {
            return base.Channel.getSolicitudes();
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedSolicitud[]> getSolicitudesAsync() {
            return base.Channel.getSolicitudesAsync();
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
        
        public Eggplant.ServiceTaller.ExposedOferta[] getOfertas(int solicitud) {
            return base.Channel.getOfertas(solicitud);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedOferta[]> getOfertasAsync(int solicitud) {
            return base.Channel.getOfertasAsync(solicitud);
        }
        
        public Eggplant.ServiceTaller.ExposedOferta getOferta(int oferta) {
            return base.Channel.getOferta(oferta);
        }
        
        public System.Threading.Tasks.Task<Eggplant.ServiceTaller.ExposedOferta> getOfertaAsync(int oferta) {
            return base.Channel.getOfertaAsync(oferta);
        }
        
        public int selectOferta(Eggplant.ServiceTaller.TallerResponse r) {
            return base.Channel.selectOferta(r);
        }
        
        public System.Threading.Tasks.Task<int> selectOfertaAsync(Eggplant.ServiceTaller.TallerResponse r) {
            return base.Channel.selectOfertaAsync(r);
        }
    }
}
