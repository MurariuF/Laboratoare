﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Detalii", Namespace="http://schemas.datacontract.org/2004/07/P1", IsReference=true)]
    public partial class Detalii : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<System.DateTime> DataField;
        
        private bool DeletedField;
        
        private string EvenimentField;
        
        private P1.Extras[] ExtrasField;
        
        private int IdField;
        
        private string LocatieField;
        
        private string PathField;
        
        private string PeisajeField;
        
        private string PersoaneField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Eveniment
        {
            get
            {
                return this.EvenimentField;
            }
            set
            {
                this.EvenimentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public P1.Extras[] Extras
        {
            get
            {
                return this.ExtrasField;
            }
            set
            {
                this.ExtrasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Locatie
        {
            get
            {
                return this.LocatieField;
            }
            set
            {
                this.LocatieField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Peisaje
        {
            get
            {
                return this.PeisajeField;
            }
            set
            {
                this.PeisajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Persoane
        {
            get
            {
                return this.PersoaneField;
            }
            set
            {
                this.PersoaneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Extras", Namespace="http://schemas.datacontract.org/2004/07/P1", IsReference=true)]
    public partial class Extras : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private P1.Detalii DetaliiField;
        
        private int DetaliiIdField;
        
        private int IdField;
        
        private string NumeField;
        
        private string ValoareField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public P1.Detalii Detalii
        {
            get
            {
                return this.DetaliiField;
            }
            set
            {
                this.DetaliiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DetaliiId
        {
            get
            {
                return this.DetaliiIdField;
            }
            set
            {
                this.DetaliiIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nume
        {
            get
            {
                return this.NumeField;
            }
            set
            {
                this.NumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Valoare
        {
            get
            {
                return this.ValoareField;
            }
            set
            {
                this.ValoareField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDetaliiExtras")]
public interface IDetaliiExtras
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/getDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/getDetaliiResponse")]
    P1.Detalii getDetalii(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/getDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/getDetaliiResponse")]
    System.Threading.Tasks.Task<P1.Detalii> getDetaliiAsync(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/addDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/addDetaliiResponse")]
    P1.Detalii addDetalii(P1.Detalii d);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/addDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/addDetaliiResponse")]
    System.Threading.Tasks.Task<P1.Detalii> addDetaliiAsync(P1.Detalii d);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/getAllDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/getAllDetaliiResponse")]
    P1.Detalii[] getAllDetalii();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/getAllDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/getAllDetaliiResponse")]
    System.Threading.Tasks.Task<P1.Detalii[]> getAllDetaliiAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/UpdateDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/UpdateDetaliiResponse")]
    void UpdateDetalii(P1.Detalii d);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/UpdateDetalii", ReplyAction="http://tempuri.org/InterfaceDetalii/UpdateDetaliiResponse")]
    System.Threading.Tasks.Task UpdateDetaliiAsync(P1.Detalii d);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/Save", ReplyAction="http://tempuri.org/InterfaceDetalii/SaveResponse")]
    void Save();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/Save", ReplyAction="http://tempuri.org/InterfaceDetalii/SaveResponse")]
    System.Threading.Tasks.Task SaveAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/Dispose", ReplyAction="http://tempuri.org/InterfaceDetalii/DisposeResponse")]
    void Dispose();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceDetalii/Dispose", ReplyAction="http://tempuri.org/InterfaceDetalii/DisposeResponse")]
    System.Threading.Tasks.Task DisposeAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceExtras/AddExtras", ReplyAction="http://tempuri.org/InterfaceExtras/AddExtrasResponse")]
    void AddExtras(P1.Detalii d, P1.Extras extra);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceExtras/AddExtras", ReplyAction="http://tempuri.org/InterfaceExtras/AddExtrasResponse")]
    System.Threading.Tasks.Task AddExtrasAsync(P1.Detalii d, P1.Extras extra);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IDetaliiExtrasChannel : IDetaliiExtras, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DetaliiExtrasClient : System.ServiceModel.ClientBase<IDetaliiExtras>, IDetaliiExtras
{
    
    public DetaliiExtrasClient()
    {
    }
    
    public DetaliiExtrasClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public DetaliiExtrasClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DetaliiExtrasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DetaliiExtrasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public P1.Detalii getDetalii(string path)
    {
        return base.Channel.getDetalii(path);
    }
    
    public System.Threading.Tasks.Task<P1.Detalii> getDetaliiAsync(string path)
    {
        return base.Channel.getDetaliiAsync(path);
    }
    
    public P1.Detalii addDetalii(P1.Detalii d)
    {
        return base.Channel.addDetalii(d);
    }
    
    public System.Threading.Tasks.Task<P1.Detalii> addDetaliiAsync(P1.Detalii d)
    {
        return base.Channel.addDetaliiAsync(d);
    }
    
    public P1.Detalii[] getAllDetalii()
    {
        return base.Channel.getAllDetalii();
    }
    
    public System.Threading.Tasks.Task<P1.Detalii[]> getAllDetaliiAsync()
    {
        return base.Channel.getAllDetaliiAsync();
    }
    
    public void UpdateDetalii(P1.Detalii d)
    {
        base.Channel.UpdateDetalii(d);
    }
    
    public System.Threading.Tasks.Task UpdateDetaliiAsync(P1.Detalii d)
    {
        return base.Channel.UpdateDetaliiAsync(d);
    }
    
    public void Save()
    {
        base.Channel.Save();
    }
    
    public System.Threading.Tasks.Task SaveAsync()
    {
        return base.Channel.SaveAsync();
    }
    
    public void Dispose()
    {
        base.Channel.Dispose();
    }
    
    public System.Threading.Tasks.Task DisposeAsync()
    {
        return base.Channel.DisposeAsync();
    }
    
    public void AddExtras(P1.Detalii d, P1.Extras extra)
    {
        base.Channel.AddExtras(d, extra);
    }
    
    public System.Threading.Tasks.Task AddExtrasAsync(P1.Detalii d, P1.Extras extra)
    {
        return base.Channel.AddExtrasAsync(d, extra);
    }
}
