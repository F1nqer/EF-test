﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NET_start.ProductServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductContract", Namespace="http://schemas.datacontract.org/2004/07/WcfContracts.DataContracts")]
    [System.SerializableAttribute()]
    public partial class ProductContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DaysToManufactureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] LargePhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ListPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ProductModelIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short SafetyStockLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal StandardCostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StyleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ThumbNailPhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> WeightField;
        
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
        public string Class {
            get {
                return this.ClassField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassField, value) != true)) {
                    this.ClassField = value;
                    this.RaisePropertyChanged("Class");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DaysToManufacture {
            get {
                return this.DaysToManufactureField;
            }
            set {
                if ((this.DaysToManufactureField.Equals(value) != true)) {
                    this.DaysToManufactureField = value;
                    this.RaisePropertyChanged("DaysToManufacture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] LargePhoto {
            get {
                return this.LargePhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.LargePhotoField, value) != true)) {
                    this.LargePhotoField = value;
                    this.RaisePropertyChanged("LargePhoto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ListPrice {
            get {
                return this.ListPriceField;
            }
            set {
                if ((this.ListPriceField.Equals(value) != true)) {
                    this.ListPriceField = value;
                    this.RaisePropertyChanged("ListPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                if ((this.ModifiedDateField.Equals(value) != true)) {
                    this.ModifiedDateField = value;
                    this.RaisePropertyChanged("ModifiedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductLine {
            get {
                return this.ProductLineField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductLineField, value) != true)) {
                    this.ProductLineField = value;
                    this.RaisePropertyChanged("ProductLine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ProductModelID {
            get {
                return this.ProductModelIDField;
            }
            set {
                if ((this.ProductModelIDField.Equals(value) != true)) {
                    this.ProductModelIDField = value;
                    this.RaisePropertyChanged("ProductModelID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductNumber {
            get {
                return this.ProductNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNumberField, value) != true)) {
                    this.ProductNumberField = value;
                    this.RaisePropertyChanged("ProductNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short SafetyStockLevel {
            get {
                return this.SafetyStockLevelField;
            }
            set {
                if ((this.SafetyStockLevelField.Equals(value) != true)) {
                    this.SafetyStockLevelField = value;
                    this.RaisePropertyChanged("SafetyStockLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Size {
            get {
                return this.SizeField;
            }
            set {
                if ((object.ReferenceEquals(this.SizeField, value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal StandardCost {
            get {
                return this.StandardCostField;
            }
            set {
                if ((this.StandardCostField.Equals(value) != true)) {
                    this.StandardCostField = value;
                    this.RaisePropertyChanged("StandardCost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Style {
            get {
                return this.StyleField;
            }
            set {
                if ((object.ReferenceEquals(this.StyleField, value) != true)) {
                    this.StyleField = value;
                    this.RaisePropertyChanged("Style");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ThumbNailPhoto {
            get {
                return this.ThumbNailPhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.ThumbNailPhotoField, value) != true)) {
                    this.ThumbNailPhotoField = value;
                    this.RaisePropertyChanged("ThumbNailPhoto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((this.WeightField.Equals(value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceRef.IProjectServiceOf_ProductContract")]
    public interface IProjectServiceOf_ProductContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/GetAll", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/GetAllResponse")]
        ASP.NET_start.ProductServiceRef.ProductContract[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/GetAll", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/GetAllResponse")]
        System.Threading.Tasks.Task<ASP.NET_start.ProductServiceRef.ProductContract[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Get", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/GetResponse")]
        ASP.NET_start.ProductServiceRef.ProductContract Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Get", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/GetResponse")]
        System.Threading.Tasks.Task<ASP.NET_start.ProductServiceRef.ProductContract> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Create", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/CreateResponse")]
        void Create(ASP.NET_start.ProductServiceRef.ProductContract item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Create", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(ASP.NET_start.ProductServiceRef.ProductContract item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Update", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/UpdateResponse")]
        void Update(ASP.NET_start.ProductServiceRef.ProductContract item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Update", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(ASP.NET_start.ProductServiceRef.ProductContract item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Delete", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectServiceOf_ProductContract/Delete", ReplyAction="http://tempuri.org/IProjectServiceOf_ProductContract/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProjectServiceOf_ProductContractChannel : ASP.NET_start.ProductServiceRef.IProjectServiceOf_ProductContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProjectServiceOf_ProductContractClient : System.ServiceModel.ClientBase<ASP.NET_start.ProductServiceRef.IProjectServiceOf_ProductContract>, ASP.NET_start.ProductServiceRef.IProjectServiceOf_ProductContract {
        
        public ProjectServiceOf_ProductContractClient() {
        }
        
        public ProjectServiceOf_ProductContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProjectServiceOf_ProductContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectServiceOf_ProductContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectServiceOf_ProductContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ASP.NET_start.ProductServiceRef.ProductContract[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ASP.NET_start.ProductServiceRef.ProductContract[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public ASP.NET_start.ProductServiceRef.ProductContract Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<ASP.NET_start.ProductServiceRef.ProductContract> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public void Create(ASP.NET_start.ProductServiceRef.ProductContract item) {
            base.Channel.Create(item);
        }
        
        public System.Threading.Tasks.Task CreateAsync(ASP.NET_start.ProductServiceRef.ProductContract item) {
            return base.Channel.CreateAsync(item);
        }
        
        public void Update(ASP.NET_start.ProductServiceRef.ProductContract item) {
            base.Channel.Update(item);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(ASP.NET_start.ProductServiceRef.ProductContract item) {
            return base.Channel.UpdateAsync(item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
