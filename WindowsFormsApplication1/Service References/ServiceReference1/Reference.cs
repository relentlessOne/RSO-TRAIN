﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Trainz")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[][] StartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] StartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[][] StopField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] StopTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[][] Start {
            get {
                return this.StartField;
            }
            set {
                if ((object.ReferenceEquals(this.StartField, value) != true)) {
                    this.StartField = value;
                    this.RaisePropertyChanged("Start");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.StartTimeField, value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[][] Stop {
            get {
                return this.StopField;
            }
            set {
                if ((object.ReferenceEquals(this.StopField, value) != true)) {
                    this.StopField = value;
                    this.RaisePropertyChanged("Stop");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] StopTime {
            get {
                return this.StopTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.StopTimeField, value) != true)) {
                    this.StopTimeField = value;
                    this.RaisePropertyChanged("StopTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/fetchData", ReplyAction="http://tempuri.org/IService1/fetchDataResponse")]
        WindowsFormsApplication1.ServiceReference1.CompositeType fetchData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/fetchData", ReplyAction="http://tempuri.org/IService1/fetchDataResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.CompositeType> fetchDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findConnection", ReplyAction="http://tempuri.org/IService1/findConnectionResponse")]
        string findConnection(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string cityA, string cityB, string startDate, string stopDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findConnection", ReplyAction="http://tempuri.org/IService1/findConnectionResponse")]
        System.Threading.Tasks.Task<string> findConnectionAsync(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string cityA, string cityB, string startDate, string stopDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfStartCityExists", ReplyAction="http://tempuri.org/IService1/checkIfStartCityExistsResponse")]
        bool checkIfStartCityExists(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfStartCityExists", ReplyAction="http://tempuri.org/IService1/checkIfStartCityExistsResponse")]
        System.Threading.Tasks.Task<bool> checkIfStartCityExistsAsync(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfStopCityExists", ReplyAction="http://tempuri.org/IService1/checkIfStopCityExistsResponse")]
        bool checkIfStopCityExists(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkIfStopCityExists", ReplyAction="http://tempuri.org/IService1/checkIfStopCityExistsResponse")]
        System.Threading.Tasks.Task<bool> checkIfStopCityExistsAsync(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IService1>, WindowsFormsApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApplication1.ServiceReference1.CompositeType fetchData() {
            return base.Channel.fetchData();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.CompositeType> fetchDataAsync() {
            return base.Channel.fetchDataAsync();
        }
        
        public string findConnection(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string cityA, string cityB, string startDate, string stopDate) {
            return base.Channel.findConnection(CT, cityA, cityB, startDate, stopDate);
        }
        
        public System.Threading.Tasks.Task<string> findConnectionAsync(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string cityA, string cityB, string startDate, string stopDate) {
            return base.Channel.findConnectionAsync(CT, cityA, cityB, startDate, stopDate);
        }
        
        public bool checkIfStartCityExists(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData) {
            return base.Channel.checkIfStartCityExists(CT, clientData);
        }
        
        public System.Threading.Tasks.Task<bool> checkIfStartCityExistsAsync(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData) {
            return base.Channel.checkIfStartCityExistsAsync(CT, clientData);
        }
        
        public bool checkIfStopCityExists(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData) {
            return base.Channel.checkIfStopCityExists(CT, clientData);
        }
        
        public System.Threading.Tasks.Task<bool> checkIfStopCityExistsAsync(WindowsFormsApplication1.ServiceReference1.CompositeType CT, string clientData) {
            return base.Channel.checkIfStopCityExistsAsync(CT, clientData);
        }
    }
}
