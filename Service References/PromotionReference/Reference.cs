﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5448
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication2.PromotionReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PromotionRequest", Namespace="http://schemas.datacontract.org/2004/07/Promotion.Components")]
    [System.SerializableAttribute()]
    public partial class PromotionRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int areaidField;
        
        private int channelIdField;
        
        private string inputparmField;
        
        private System.Nullable<bool> isCacheField;
        
        private string productIdField;
        
        private string productcodeField;
        
        private int promtionIdField;
        
        private string qtyField;
        
        private int sceneidField;
        
        private int shoppingcartIdField;
        
        private decimal totalField;
        
        private int userIdField;
        
        private int usergroupField;
        
        private string userguidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int areaid {
            get {
                return this.areaidField;
            }
            set {
                if ((this.areaidField.Equals(value) != true)) {
                    this.areaidField = value;
                    this.RaisePropertyChanged("areaid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int channelId {
            get {
                return this.channelIdField;
            }
            set {
                if ((this.channelIdField.Equals(value) != true)) {
                    this.channelIdField = value;
                    this.RaisePropertyChanged("channelId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string inputparm {
            get {
                return this.inputparmField;
            }
            set {
                if ((object.ReferenceEquals(this.inputparmField, value) != true)) {
                    this.inputparmField = value;
                    this.RaisePropertyChanged("inputparm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<bool> isCache {
            get {
                return this.isCacheField;
            }
            set {
                if ((this.isCacheField.Equals(value) != true)) {
                    this.isCacheField = value;
                    this.RaisePropertyChanged("isCache");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string productId {
            get {
                return this.productIdField;
            }
            set {
                if ((object.ReferenceEquals(this.productIdField, value) != true)) {
                    this.productIdField = value;
                    this.RaisePropertyChanged("productId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string productcode {
            get {
                return this.productcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.productcodeField, value) != true)) {
                    this.productcodeField = value;
                    this.RaisePropertyChanged("productcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int promtionId {
            get {
                return this.promtionIdField;
            }
            set {
                if ((this.promtionIdField.Equals(value) != true)) {
                    this.promtionIdField = value;
                    this.RaisePropertyChanged("promtionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string qty {
            get {
                return this.qtyField;
            }
            set {
                if ((object.ReferenceEquals(this.qtyField, value) != true)) {
                    this.qtyField = value;
                    this.RaisePropertyChanged("qty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int sceneid {
            get {
                return this.sceneidField;
            }
            set {
                if ((this.sceneidField.Equals(value) != true)) {
                    this.sceneidField = value;
                    this.RaisePropertyChanged("sceneid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int shoppingcartId {
            get {
                return this.shoppingcartIdField;
            }
            set {
                if ((this.shoppingcartIdField.Equals(value) != true)) {
                    this.shoppingcartIdField = value;
                    this.RaisePropertyChanged("shoppingcartId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int usergroup {
            get {
                return this.usergroupField;
            }
            set {
                if ((this.usergroupField.Equals(value) != true)) {
                    this.usergroupField = value;
                    this.RaisePropertyChanged("usergroup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string userguid {
            get {
                return this.userguidField;
            }
            set {
                if ((object.ReferenceEquals(this.userguidField, value) != true)) {
                    this.userguidField = value;
                    this.RaisePropertyChanged("userguid");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PromotionResponse", Namespace="http://schemas.datacontract.org/2004/07/Promotion.Components")]
    [System.SerializableAttribute()]
    public partial class PromotionResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool flagField;
        
        private string messageField;
        
        private string objresultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool flag {
            get {
                return this.flagField;
            }
            set {
                if ((this.flagField.Equals(value) != true)) {
                    this.flagField = value;
                    this.RaisePropertyChanged("flag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                if ((object.ReferenceEquals(this.messageField, value) != true)) {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string objresult {
            get {
                return this.objresultField;
            }
            set {
                if ((object.ReferenceEquals(this.objresultField, value) != true)) {
                    this.objresultField = value;
                    this.RaisePropertyChanged("objresult");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PromotionReference.IPromotionEngineService")]
    public interface IPromotionEngineService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPromotionEngineService/Display", ReplyAction="http://tempuri.org/IPromotionEngineService/DisplayResponse")]
        ConsoleApplication2.PromotionReference.PromotionResponse Display(ConsoleApplication2.PromotionReference.PromotionRequest pa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPromotionEngineService/Exec", ReplyAction="http://tempuri.org/IPromotionEngineService/ExecResponse")]
        ConsoleApplication2.PromotionReference.PromotionResponse Exec(ConsoleApplication2.PromotionReference.PromotionRequest pa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPromotionEngineService/ClearCache", ReplyAction="http://tempuri.org/IPromotionEngineService/ClearCacheResponse")]
        ConsoleApplication2.PromotionReference.PromotionResponse ClearCache(int PromotionID, string PromotionType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IPromotionEngineServiceChannel : ConsoleApplication2.PromotionReference.IPromotionEngineService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class PromotionEngineServiceClient : System.ServiceModel.ClientBase<ConsoleApplication2.PromotionReference.IPromotionEngineService>, ConsoleApplication2.PromotionReference.IPromotionEngineService {
        
        public PromotionEngineServiceClient() {
        }
        
        public PromotionEngineServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PromotionEngineServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PromotionEngineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PromotionEngineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApplication2.PromotionReference.PromotionResponse Display(ConsoleApplication2.PromotionReference.PromotionRequest pa) {
            return base.Channel.Display(pa);
        }
        
        public ConsoleApplication2.PromotionReference.PromotionResponse Exec(ConsoleApplication2.PromotionReference.PromotionRequest pa) {
            return base.Channel.Exec(pa);
        }
        
        public ConsoleApplication2.PromotionReference.PromotionResponse ClearCache(int PromotionID, string PromotionType) {
            return base.Channel.ClearCache(PromotionID, PromotionType);
        }
    }
}