﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduSendSMS_VIETGUYS.vetguys {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="sms", ConfigurationName="vetguys.smsPortType")]
    public interface smsPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="send", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string send(EduSendSMS_VIETGUYS.vetguys.sms sms);
        
        [System.ServiceModel.OperationContractAttribute(Action="send", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> sendAsync(EduSendSMS_VIETGUYS.vetguys.sms sms);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="sms")]
    public partial class sms : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string phoneField;
        
        private string passcodeField;
        
        private string sms1Field;
        
        private string accountField;
        
        private string passwordField;
        
        private string contenttypeField;
        
        private string messagetypeField;
        
        private string messageidField;
        
        private string transactionidField;
        
        private string service_idField;
        
        private string jsonField;
        
        /// <remarks/>
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
                this.RaisePropertyChanged("phone");
            }
        }
        
        /// <remarks/>
        public string passcode {
            get {
                return this.passcodeField;
            }
            set {
                this.passcodeField = value;
                this.RaisePropertyChanged("passcode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute("sms")]
        public string sms1 {
            get {
                return this.sms1Field;
            }
            set {
                this.sms1Field = value;
                this.RaisePropertyChanged("sms1");
            }
        }
        
        /// <remarks/>
        public string account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
                this.RaisePropertyChanged("account");
            }
        }
        
        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        public string contenttype {
            get {
                return this.contenttypeField;
            }
            set {
                this.contenttypeField = value;
                this.RaisePropertyChanged("contenttype");
            }
        }
        
        /// <remarks/>
        public string messagetype {
            get {
                return this.messagetypeField;
            }
            set {
                this.messagetypeField = value;
                this.RaisePropertyChanged("messagetype");
            }
        }
        
        /// <remarks/>
        public string messageid {
            get {
                return this.messageidField;
            }
            set {
                this.messageidField = value;
                this.RaisePropertyChanged("messageid");
            }
        }
        
        /// <remarks/>
        public string transactionid {
            get {
                return this.transactionidField;
            }
            set {
                this.transactionidField = value;
                this.RaisePropertyChanged("transactionid");
            }
        }
        
        /// <remarks/>
        public string service_id {
            get {
                return this.service_idField;
            }
            set {
                this.service_idField = value;
                this.RaisePropertyChanged("service_id");
            }
        }
        
        /// <remarks/>
        public string json {
            get {
                return this.jsonField;
            }
            set {
                this.jsonField = value;
                this.RaisePropertyChanged("json");
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
    public interface smsPortTypeChannel : EduSendSMS_VIETGUYS.vetguys.smsPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class smsPortTypeClient : System.ServiceModel.ClientBase<EduSendSMS_VIETGUYS.vetguys.smsPortType>, EduSendSMS_VIETGUYS.vetguys.smsPortType {
        
        public smsPortTypeClient() {
        }
        
        public smsPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public smsPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public smsPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public smsPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string send(EduSendSMS_VIETGUYS.vetguys.sms sms) {
            return base.Channel.send(sms);
        }
        
        public System.Threading.Tasks.Task<string> sendAsync(EduSendSMS_VIETGUYS.vetguys.sms sms) {
            return base.Channel.sendAsync(sms);
        }
    }
}
