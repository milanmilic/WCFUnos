﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospitalizacija.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pacijent", Namespace="http://schemas.datacontract.org/2004/07/WCFUnos")]
    [System.SerializableAttribute()]
    public partial class Pacijent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string adresa_prebivalistaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime datum_rodjenjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_drzavljanstvoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_opstinaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_osiguranjeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_polField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jmbgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lboField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prezime_imeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int starostField;
        
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
        public string adresa_prebivalista {
            get {
                return this.adresa_prebivalistaField;
            }
            set {
                if ((object.ReferenceEquals(this.adresa_prebivalistaField, value) != true)) {
                    this.adresa_prebivalistaField = value;
                    this.RaisePropertyChanged("adresa_prebivalista");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime datum_rodjenja {
            get {
                return this.datum_rodjenjaField;
            }
            set {
                if ((this.datum_rodjenjaField.Equals(value) != true)) {
                    this.datum_rodjenjaField = value;
                    this.RaisePropertyChanged("datum_rodjenja");
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
        public int id_drzavljanstvo {
            get {
                return this.id_drzavljanstvoField;
            }
            set {
                if ((this.id_drzavljanstvoField.Equals(value) != true)) {
                    this.id_drzavljanstvoField = value;
                    this.RaisePropertyChanged("id_drzavljanstvo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_opstina {
            get {
                return this.id_opstinaField;
            }
            set {
                if ((object.ReferenceEquals(this.id_opstinaField, value) != true)) {
                    this.id_opstinaField = value;
                    this.RaisePropertyChanged("id_opstina");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_osiguranje {
            get {
                return this.id_osiguranjeField;
            }
            set {
                if ((this.id_osiguranjeField.Equals(value) != true)) {
                    this.id_osiguranjeField = value;
                    this.RaisePropertyChanged("id_osiguranje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_pol {
            get {
                return this.id_polField;
            }
            set {
                if ((this.id_polField.Equals(value) != true)) {
                    this.id_polField = value;
                    this.RaisePropertyChanged("id_pol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jmbg {
            get {
                return this.jmbgField;
            }
            set {
                if ((object.ReferenceEquals(this.jmbgField, value) != true)) {
                    this.jmbgField = value;
                    this.RaisePropertyChanged("jmbg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lbo {
            get {
                return this.lboField;
            }
            set {
                if ((object.ReferenceEquals(this.lboField, value) != true)) {
                    this.lboField = value;
                    this.RaisePropertyChanged("lbo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prezime_ime {
            get {
                return this.prezime_imeField;
            }
            set {
                if ((object.ReferenceEquals(this.prezime_imeField, value) != true)) {
                    this.prezime_imeField = value;
                    this.RaisePropertyChanged("prezime_ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int starost {
            get {
                return this.starostField;
            }
            set {
                if ((this.starostField.Equals(value) != true)) {
                    this.starostField = value;
                    this.RaisePropertyChanged("starost");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UnosPacijenta", ReplyAction="http://tempuri.org/IService1/UnosPacijentaResponse")]
        string UnosPacijenta(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UnosPacijenta", ReplyAction="http://tempuri.org/IService1/UnosPacijentaResponse")]
        System.Threading.Tasks.Task<string> UnosPacijentaAsync(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziPacijenta", ReplyAction="http://tempuri.org/IService1/PrikaziPacijentaResponse")]
        System.Data.DataSet PrikaziPacijenta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziPacijenta", ReplyAction="http://tempuri.org/IService1/PrikaziPacijentaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziPacijentaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzbrisiPacijenta", ReplyAction="http://tempuri.org/IService1/IzbrisiPacijentaResponse")]
        bool IzbrisiPacijenta(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzbrisiPacijenta", ReplyAction="http://tempuri.org/IService1/IzbrisiPacijentaResponse")]
        System.Threading.Tasks.Task<bool> IzbrisiPacijentaAsync(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzmeniPacijenta", ReplyAction="http://tempuri.org/IService1/IzmeniPacijentaResponse")]
        void IzmeniPacijenta(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzmeniPacijenta", ReplyAction="http://tempuri.org/IService1/IzmeniPacijentaResponse")]
        System.Threading.Tasks.Task IzmeniPacijentaAsync(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziBolnice", ReplyAction="http://tempuri.org/IService1/PrikaziBolniceResponse")]
        System.Data.DataSet PrikaziBolnice();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziBolnice", ReplyAction="http://tempuri.org/IService1/PrikaziBolniceResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziBolniceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOdeljenjaPrijem", ReplyAction="http://tempuri.org/IService1/PrikaziOdeljenjaPrijemResponse")]
        System.Data.DataSet PrikaziOdeljenjaPrijem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOdeljenjaPrijem", ReplyAction="http://tempuri.org/IService1/PrikaziOdeljenjaPrijemResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOdeljenjaPrijemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOdeljenjaOtpust", ReplyAction="http://tempuri.org/IService1/PrikaziOdeljenjaOtpustResponse")]
        System.Data.DataSet PrikaziOdeljenjaOtpust();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOdeljenjaOtpust", ReplyAction="http://tempuri.org/IService1/PrikaziOdeljenjaOtpustResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOdeljenjaOtpustAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozeOsnovna", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozeOsnovnaResponse")]
        System.Data.DataSet PrikaziDijagnozeOsnovna();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozeOsnovna", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozeOsnovnaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozeOsnovnaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozeUputna", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozeUputnaResponse")]
        System.Data.DataSet PrikaziDijagnozeUputna();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozeUputna", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozeUputnaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozeUputnaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozePrateca", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozePratecaResponse")]
        System.Data.DataSet PrikaziDijagnozePrateca();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozePrateca", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozePratecaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozePratecaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozeSmrt", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozeSmrtResponse")]
        System.Data.DataSet PrikaziDijagnozeSmrt();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDijagnozeSmrt", ReplyAction="http://tempuri.org/IService1/PrikaziDijagnozeSmrtResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozeSmrtAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOperacije", ReplyAction="http://tempuri.org/IService1/PrikaziOperacijeResponse")]
        System.Data.DataSet PrikaziOperacije();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOperacije", ReplyAction="http://tempuri.org/IService1/PrikaziOperacijeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOperacijeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDrzave", ReplyAction="http://tempuri.org/IService1/PrikaziDrzaveResponse")]
        System.Data.DataSet PrikaziDrzave();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziDrzave", ReplyAction="http://tempuri.org/IService1/PrikaziDrzaveResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDrzaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOpstine", ReplyAction="http://tempuri.org/IService1/PrikaziOpstineResponse")]
        System.Data.DataSet PrikaziOpstine();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOpstine", ReplyAction="http://tempuri.org/IService1/PrikaziOpstineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOpstineAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOtpust", ReplyAction="http://tempuri.org/IService1/PrikaziOtpustResponse")]
        System.Data.DataSet PrikaziOtpust();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziOtpust", ReplyAction="http://tempuri.org/IService1/PrikaziOtpustResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOtpustAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziPol", ReplyAction="http://tempuri.org/IService1/PrikaziPolResponse")]
        System.Data.DataSet PrikaziPol();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrikaziPol", ReplyAction="http://tempuri.org/IService1/PrikaziPolResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PrikaziPolAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Hospitalizacija.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Hospitalizacija.ServiceReference1.IService1>, Hospitalizacija.ServiceReference1.IService1 {
        
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
        
        public string UnosPacijenta(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo) {
            return base.Channel.UnosPacijenta(pacijentInfo);
        }
        
        public System.Threading.Tasks.Task<string> UnosPacijentaAsync(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo) {
            return base.Channel.UnosPacijentaAsync(pacijentInfo);
        }
        
        public System.Data.DataSet PrikaziPacijenta() {
            return base.Channel.PrikaziPacijenta();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziPacijentaAsync() {
            return base.Channel.PrikaziPacijentaAsync();
        }
        
        public bool IzbrisiPacijenta(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo) {
            return base.Channel.IzbrisiPacijenta(pacijentInfo);
        }
        
        public System.Threading.Tasks.Task<bool> IzbrisiPacijentaAsync(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo) {
            return base.Channel.IzbrisiPacijentaAsync(pacijentInfo);
        }
        
        public void IzmeniPacijenta(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo) {
            base.Channel.IzmeniPacijenta(pacijentInfo);
        }
        
        public System.Threading.Tasks.Task IzmeniPacijentaAsync(Hospitalizacija.ServiceReference1.Pacijent pacijentInfo) {
            return base.Channel.IzmeniPacijentaAsync(pacijentInfo);
        }
        
        public System.Data.DataSet PrikaziBolnice() {
            return base.Channel.PrikaziBolnice();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziBolniceAsync() {
            return base.Channel.PrikaziBolniceAsync();
        }
        
        public System.Data.DataSet PrikaziOdeljenjaPrijem() {
            return base.Channel.PrikaziOdeljenjaPrijem();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOdeljenjaPrijemAsync() {
            return base.Channel.PrikaziOdeljenjaPrijemAsync();
        }
        
        public System.Data.DataSet PrikaziOdeljenjaOtpust() {
            return base.Channel.PrikaziOdeljenjaOtpust();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOdeljenjaOtpustAsync() {
            return base.Channel.PrikaziOdeljenjaOtpustAsync();
        }
        
        public System.Data.DataSet PrikaziDijagnozeOsnovna() {
            return base.Channel.PrikaziDijagnozeOsnovna();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozeOsnovnaAsync() {
            return base.Channel.PrikaziDijagnozeOsnovnaAsync();
        }
        
        public System.Data.DataSet PrikaziDijagnozeUputna() {
            return base.Channel.PrikaziDijagnozeUputna();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozeUputnaAsync() {
            return base.Channel.PrikaziDijagnozeUputnaAsync();
        }
        
        public System.Data.DataSet PrikaziDijagnozePrateca() {
            return base.Channel.PrikaziDijagnozePrateca();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozePratecaAsync() {
            return base.Channel.PrikaziDijagnozePratecaAsync();
        }
        
        public System.Data.DataSet PrikaziDijagnozeSmrt() {
            return base.Channel.PrikaziDijagnozeSmrt();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDijagnozeSmrtAsync() {
            return base.Channel.PrikaziDijagnozeSmrtAsync();
        }
        
        public System.Data.DataSet PrikaziOperacije() {
            return base.Channel.PrikaziOperacije();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOperacijeAsync() {
            return base.Channel.PrikaziOperacijeAsync();
        }
        
        public System.Data.DataSet PrikaziDrzave() {
            return base.Channel.PrikaziDrzave();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziDrzaveAsync() {
            return base.Channel.PrikaziDrzaveAsync();
        }
        
        public System.Data.DataSet PrikaziOpstine() {
            return base.Channel.PrikaziOpstine();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOpstineAsync() {
            return base.Channel.PrikaziOpstineAsync();
        }
        
        public System.Data.DataSet PrikaziOtpust() {
            return base.Channel.PrikaziOtpust();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziOtpustAsync() {
            return base.Channel.PrikaziOtpustAsync();
        }
        
        public System.Data.DataSet PrikaziPol() {
            return base.Channel.PrikaziPol();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PrikaziPolAsync() {
            return base.Channel.PrikaziPolAsync();
        }
    }
}
