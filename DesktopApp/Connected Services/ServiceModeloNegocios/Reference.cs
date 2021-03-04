﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApp.ServiceModeloNegocios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Data_Service.Models")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Customer_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Document_nroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<DesktopApp.ServiceModeloNegocios.TipoDocumento> Document_typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<DesktopApp.ServiceModeloNegocios.Estado> EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.Order[] OrdersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Customer_name {
            get {
                return this.Customer_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Customer_nameField, value) != true)) {
                    this.Customer_nameField = value;
                    this.RaisePropertyChanged("Customer_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document_nro {
            get {
                return this.Document_nroField;
            }
            set {
                if ((object.ReferenceEquals(this.Document_nroField, value) != true)) {
                    this.Document_nroField = value;
                    this.RaisePropertyChanged("Document_nro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<DesktopApp.ServiceModeloNegocios.TipoDocumento> Document_type {
            get {
                return this.Document_typeField;
            }
            set {
                if ((this.Document_typeField.Equals(value) != true)) {
                    this.Document_typeField = value;
                    this.RaisePropertyChanged("Document_type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<DesktopApp.ServiceModeloNegocios.Estado> Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApp.ServiceModeloNegocios.Order[] Orders {
            get {
                return this.OrdersField;
            }
            set {
                if ((object.ReferenceEquals(this.OrdersField, value) != true)) {
                    this.OrdersField = value;
                    this.RaisePropertyChanged("Orders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoDocumento", Namespace="http://schemas.datacontract.org/2004/07/Data_Service.Models")]
    public enum TipoDocumento : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DNI = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LIBRETA_ENROLAMIENTO = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estado", Namespace="http://schemas.datacontract.org/2004/07/Data_Service.Models")]
    public enum Estado : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ACTIVO = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INACTIVO = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PENDIENTE = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SIN_STOCK = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Data_Service.Models", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.OrderDetail[] DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.Estado EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Order_dateField;
        
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
        public DesktopApp.ServiceModeloNegocios.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApp.ServiceModeloNegocios.OrderDetail[] Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApp.ServiceModeloNegocios.Estado Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Order_date {
            get {
                return this.Order_dateField;
            }
            set {
                if ((this.Order_dateField.Equals(value) != true)) {
                    this.Order_dateField = value;
                    this.RaisePropertyChanged("Order_date");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDetail", Namespace="http://schemas.datacontract.org/2004/07/Data_Service.Models")]
    [System.SerializableAttribute()]
    public partial class OrderDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.Order OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderDetailIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public DesktopApp.ServiceModeloNegocios.Order Order {
            get {
                return this.OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderField, value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderDetailID {
            get {
                return this.OrderDetailIDField;
            }
            set {
                if ((this.OrderDetailIDField.Equals(value) != true)) {
                    this.OrderDetailIDField = value;
                    this.RaisePropertyChanged("OrderDetailID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApp.ServiceModeloNegocios.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
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
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Data_Service.Models")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double Cost_priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApp.ServiceModeloNegocios.Estado EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double GainField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_nameField;
        
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
        public double Cost_price {
            get {
                return this.Cost_priceField;
            }
            set {
                if ((this.Cost_priceField.Equals(value) != true)) {
                    this.Cost_priceField = value;
                    this.RaisePropertyChanged("Cost_price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApp.ServiceModeloNegocios.Estado Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Gain {
            get {
                return this.GainField;
            }
            set {
                if ((this.GainField.Equals(value) != true)) {
                    this.GainField = value;
                    this.RaisePropertyChanged("Gain");
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
        public string Product_code {
            get {
                return this.Product_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_codeField, value) != true)) {
                    this.Product_codeField = value;
                    this.RaisePropertyChanged("Product_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Product_name {
            get {
                return this.Product_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_nameField, value) != true)) {
                    this.Product_nameField = value;
                    this.RaisePropertyChanged("Product_name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceModeloNegocios.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/GetAllCustomers", ReplyAction="http://tempuri.org/IControllerCustomer/GetAllCustomersResponse")]
        DesktopApp.ServiceModeloNegocios.Customer[] GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/GetAllCustomers", ReplyAction="http://tempuri.org/IControllerCustomer/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Customer[]> GetAllCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/GetListCustomersByEstado", ReplyAction="http://tempuri.org/IControllerCustomer/GetListCustomersByEstadoResponse")]
        DesktopApp.ServiceModeloNegocios.Customer[] GetListCustomersByEstado(DesktopApp.ServiceModeloNegocios.Estado estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/GetListCustomersByEstado", ReplyAction="http://tempuri.org/IControllerCustomer/GetListCustomersByEstadoResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Customer[]> GetListCustomersByEstadoAsync(DesktopApp.ServiceModeloNegocios.Estado estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/GetCustomerById", ReplyAction="http://tempuri.org/IControllerCustomer/GetCustomerByIdResponse")]
        DesktopApp.ServiceModeloNegocios.Customer GetCustomerById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/GetCustomerById", ReplyAction="http://tempuri.org/IControllerCustomer/GetCustomerByIdResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Customer> GetCustomerByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/CreateCustomer", ReplyAction="http://tempuri.org/IControllerCustomer/CreateCustomerResponse")]
        void CreateCustomer(DesktopApp.ServiceModeloNegocios.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/CreateCustomer", ReplyAction="http://tempuri.org/IControllerCustomer/CreateCustomerResponse")]
        System.Threading.Tasks.Task CreateCustomerAsync(DesktopApp.ServiceModeloNegocios.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/EditCustomer", ReplyAction="http://tempuri.org/IControllerCustomer/EditCustomerResponse")]
        void EditCustomer(DesktopApp.ServiceModeloNegocios.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/EditCustomer", ReplyAction="http://tempuri.org/IControllerCustomer/EditCustomerResponse")]
        System.Threading.Tasks.Task EditCustomerAsync(DesktopApp.ServiceModeloNegocios.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/DeleteCustomer", ReplyAction="http://tempuri.org/IControllerCustomer/DeleteCustomerResponse")]
        void DeleteCustomer(DesktopApp.ServiceModeloNegocios.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerCustomer/DeleteCustomer", ReplyAction="http://tempuri.org/IControllerCustomer/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(DesktopApp.ServiceModeloNegocios.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/GetAllProducts", ReplyAction="http://tempuri.org/IControllerProduct/GetAllProductsResponse")]
        DesktopApp.ServiceModeloNegocios.Product[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/GetAllProducts", ReplyAction="http://tempuri.org/IControllerProduct/GetAllProductsResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Product[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/GetAllProductsDisponibles", ReplyAction="http://tempuri.org/IControllerProduct/GetAllProductsDisponiblesResponse")]
        DesktopApp.ServiceModeloNegocios.Product[] GetAllProductsDisponibles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/GetAllProductsDisponibles", ReplyAction="http://tempuri.org/IControllerProduct/GetAllProductsDisponiblesResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Product[]> GetAllProductsDisponiblesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/GetProductById", ReplyAction="http://tempuri.org/IControllerProduct/GetProductByIdResponse")]
        DesktopApp.ServiceModeloNegocios.Product GetProductById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/GetProductById", ReplyAction="http://tempuri.org/IControllerProduct/GetProductByIdResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Product> GetProductByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/CreateProduct", ReplyAction="http://tempuri.org/IControllerProduct/CreateProductResponse")]
        void CreateProduct(DesktopApp.ServiceModeloNegocios.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/CreateProduct", ReplyAction="http://tempuri.org/IControllerProduct/CreateProductResponse")]
        System.Threading.Tasks.Task CreateProductAsync(DesktopApp.ServiceModeloNegocios.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/EditProduct", ReplyAction="http://tempuri.org/IControllerProduct/EditProductResponse")]
        void EditProduct(DesktopApp.ServiceModeloNegocios.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/EditProduct", ReplyAction="http://tempuri.org/IControllerProduct/EditProductResponse")]
        System.Threading.Tasks.Task EditProductAsync(DesktopApp.ServiceModeloNegocios.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/DeleteProduct", ReplyAction="http://tempuri.org/IControllerProduct/DeleteProductResponse")]
        void DeleteProduct(DesktopApp.ServiceModeloNegocios.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerProduct/DeleteProduct", ReplyAction="http://tempuri.org/IControllerProduct/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(DesktopApp.ServiceModeloNegocios.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/GetAllOrders", ReplyAction="http://tempuri.org/IControllerOrder/GetAllOrdersResponse")]
        DesktopApp.ServiceModeloNegocios.Order[] GetAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/GetAllOrders", ReplyAction="http://tempuri.org/IControllerOrder/GetAllOrdersResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Order[]> GetAllOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/GetOrderById", ReplyAction="http://tempuri.org/IControllerOrder/GetOrderByIdResponse")]
        DesktopApp.ServiceModeloNegocios.Order GetOrderById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/GetOrderById", ReplyAction="http://tempuri.org/IControllerOrder/GetOrderByIdResponse")]
        System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Order> GetOrderByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/CreateOrder", ReplyAction="http://tempuri.org/IControllerOrder/CreateOrderResponse")]
        void CreateOrder(DesktopApp.ServiceModeloNegocios.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/CreateOrder", ReplyAction="http://tempuri.org/IControllerOrder/CreateOrderResponse")]
        System.Threading.Tasks.Task CreateOrderAsync(DesktopApp.ServiceModeloNegocios.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/EditOrder", ReplyAction="http://tempuri.org/IControllerOrder/EditOrderResponse")]
        void EditOrder(DesktopApp.ServiceModeloNegocios.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/EditOrder", ReplyAction="http://tempuri.org/IControllerOrder/EditOrderResponse")]
        System.Threading.Tasks.Task EditOrderAsync(DesktopApp.ServiceModeloNegocios.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/DeleteOrder", ReplyAction="http://tempuri.org/IControllerOrder/DeleteOrderResponse")]
        void DeleteOrder(DesktopApp.ServiceModeloNegocios.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControllerOrder/DeleteOrder", ReplyAction="http://tempuri.org/IControllerOrder/DeleteOrderResponse")]
        System.Threading.Tasks.Task DeleteOrderAsync(DesktopApp.ServiceModeloNegocios.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : DesktopApp.ServiceModeloNegocios.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<DesktopApp.ServiceModeloNegocios.IService>, DesktopApp.ServiceModeloNegocios.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DesktopApp.ServiceModeloNegocios.Customer[] GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Customer[]> GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
        
        public DesktopApp.ServiceModeloNegocios.Customer[] GetListCustomersByEstado(DesktopApp.ServiceModeloNegocios.Estado estado) {
            return base.Channel.GetListCustomersByEstado(estado);
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Customer[]> GetListCustomersByEstadoAsync(DesktopApp.ServiceModeloNegocios.Estado estado) {
            return base.Channel.GetListCustomersByEstadoAsync(estado);
        }
        
        public DesktopApp.ServiceModeloNegocios.Customer GetCustomerById(int id) {
            return base.Channel.GetCustomerById(id);
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Customer> GetCustomerByIdAsync(int id) {
            return base.Channel.GetCustomerByIdAsync(id);
        }
        
        public void CreateCustomer(DesktopApp.ServiceModeloNegocios.Customer customer) {
            base.Channel.CreateCustomer(customer);
        }
        
        public System.Threading.Tasks.Task CreateCustomerAsync(DesktopApp.ServiceModeloNegocios.Customer customer) {
            return base.Channel.CreateCustomerAsync(customer);
        }
        
        public void EditCustomer(DesktopApp.ServiceModeloNegocios.Customer customer) {
            base.Channel.EditCustomer(customer);
        }
        
        public System.Threading.Tasks.Task EditCustomerAsync(DesktopApp.ServiceModeloNegocios.Customer customer) {
            return base.Channel.EditCustomerAsync(customer);
        }
        
        public void DeleteCustomer(DesktopApp.ServiceModeloNegocios.Customer customer) {
            base.Channel.DeleteCustomer(customer);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(DesktopApp.ServiceModeloNegocios.Customer customer) {
            return base.Channel.DeleteCustomerAsync(customer);
        }
        
        public DesktopApp.ServiceModeloNegocios.Product[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Product[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public DesktopApp.ServiceModeloNegocios.Product[] GetAllProductsDisponibles() {
            return base.Channel.GetAllProductsDisponibles();
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Product[]> GetAllProductsDisponiblesAsync() {
            return base.Channel.GetAllProductsDisponiblesAsync();
        }
        
        public DesktopApp.ServiceModeloNegocios.Product GetProductById(int id) {
            return base.Channel.GetProductById(id);
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Product> GetProductByIdAsync(int id) {
            return base.Channel.GetProductByIdAsync(id);
        }
        
        public void CreateProduct(DesktopApp.ServiceModeloNegocios.Product product) {
            base.Channel.CreateProduct(product);
        }
        
        public System.Threading.Tasks.Task CreateProductAsync(DesktopApp.ServiceModeloNegocios.Product product) {
            return base.Channel.CreateProductAsync(product);
        }
        
        public void EditProduct(DesktopApp.ServiceModeloNegocios.Product product) {
            base.Channel.EditProduct(product);
        }
        
        public System.Threading.Tasks.Task EditProductAsync(DesktopApp.ServiceModeloNegocios.Product product) {
            return base.Channel.EditProductAsync(product);
        }
        
        public void DeleteProduct(DesktopApp.ServiceModeloNegocios.Product product) {
            base.Channel.DeleteProduct(product);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(DesktopApp.ServiceModeloNegocios.Product product) {
            return base.Channel.DeleteProductAsync(product);
        }
        
        public DesktopApp.ServiceModeloNegocios.Order[] GetAllOrders() {
            return base.Channel.GetAllOrders();
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Order[]> GetAllOrdersAsync() {
            return base.Channel.GetAllOrdersAsync();
        }
        
        public DesktopApp.ServiceModeloNegocios.Order GetOrderById(int id) {
            return base.Channel.GetOrderById(id);
        }
        
        public System.Threading.Tasks.Task<DesktopApp.ServiceModeloNegocios.Order> GetOrderByIdAsync(int id) {
            return base.Channel.GetOrderByIdAsync(id);
        }
        
        public void CreateOrder(DesktopApp.ServiceModeloNegocios.Order order) {
            base.Channel.CreateOrder(order);
        }
        
        public System.Threading.Tasks.Task CreateOrderAsync(DesktopApp.ServiceModeloNegocios.Order order) {
            return base.Channel.CreateOrderAsync(order);
        }
        
        public void EditOrder(DesktopApp.ServiceModeloNegocios.Order order) {
            base.Channel.EditOrder(order);
        }
        
        public System.Threading.Tasks.Task EditOrderAsync(DesktopApp.ServiceModeloNegocios.Order order) {
            return base.Channel.EditOrderAsync(order);
        }
        
        public void DeleteOrder(DesktopApp.ServiceModeloNegocios.Order order) {
            base.Channel.DeleteOrder(order);
        }
        
        public System.Threading.Tasks.Task DeleteOrderAsync(DesktopApp.ServiceModeloNegocios.Order order) {
            return base.Channel.DeleteOrderAsync(order);
        }
    }
}