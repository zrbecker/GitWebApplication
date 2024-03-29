﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitWebServiceConsole.GitWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GitWebServiceResponse", Namespace="http://schemas.datacontract.org/2004/07/GitWebService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GitWebServiceConsole.GitWebService.CreateGitRepositoryResponse))]
    public partial class GitWebServiceResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GitWebServiceConsole.GitWebService.GitWebServiceStatus StatusField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GitWebServiceConsole.GitWebService.GitWebServiceStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateGitRepositoryResponse", Namespace="http://schemas.datacontract.org/2004/07/GitWebService")]
    [System.SerializableAttribute()]
    public partial class CreateGitRepositoryResponse : GitWebServiceConsole.GitWebService.GitWebServiceResponse {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GitWebServiceStatus", Namespace="http://schemas.datacontract.org/2004/07/GitWebService")]
    public enum GitWebServiceStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidRequest = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServerError = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GitWebService.IGitWebService")]
    public interface IGitWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGitWebService/CreateGitRepository", ReplyAction="http://tempuri.org/IGitWebService/CreateGitRepositoryResponse")]
        GitWebServiceConsole.GitWebService.CreateGitRepositoryResponse CreateGitRepository(string repositoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGitWebService/CreateGitRepository", ReplyAction="http://tempuri.org/IGitWebService/CreateGitRepositoryResponse")]
        System.Threading.Tasks.Task<GitWebServiceConsole.GitWebService.CreateGitRepositoryResponse> CreateGitRepositoryAsync(string repositoryName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGitWebServiceChannel : GitWebServiceConsole.GitWebService.IGitWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GitWebServiceClient : System.ServiceModel.ClientBase<GitWebServiceConsole.GitWebService.IGitWebService>, GitWebServiceConsole.GitWebService.IGitWebService {
        
        public GitWebServiceClient() {
        }
        
        public GitWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GitWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GitWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GitWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GitWebServiceConsole.GitWebService.CreateGitRepositoryResponse CreateGitRepository(string repositoryName) {
            return base.Channel.CreateGitRepository(repositoryName);
        }
        
        public System.Threading.Tasks.Task<GitWebServiceConsole.GitWebService.CreateGitRepositoryResponse> CreateGitRepositoryAsync(string repositoryName) {
            return base.Channel.CreateGitRepositoryAsync(repositoryName);
        }
    }
}
