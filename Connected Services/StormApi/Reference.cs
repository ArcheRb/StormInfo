﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StormInfo.StormApi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://burze.dzis.net/soap.php", ConfigurationName="StormApi.serwerSOAPPort")]
    public interface serwerSOAPPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#KeyAPI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool KeyAPI(string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#KeyAPI", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> KeyAPIAsync(string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#miejscowosc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        StormInfo.StormApi.MyComplexTypeMiejscowosc miejscowosc(string nazwa, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#miejscowosc", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<StormInfo.StormApi.MyComplexTypeMiejscowosc> miejscowoscAsync(string nazwa, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#ostrzezenia_pogodowe", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        StormInfo.StormApi.MyComplexTypeOstrzezenia ostrzezenia_pogodowe(float y, float x, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#ostrzezenia_pogodowe", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<StormInfo.StormApi.MyComplexTypeOstrzezenia> ostrzezenia_pogodoweAsync(float y, float x, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#szukaj_burzy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        StormInfo.StormApi.MyComplexTypeBurza szukaj_burzy(string y, string x, int promien, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#szukaj_burzy", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<StormInfo.StormApi.MyComplexTypeBurza> szukaj_burzyAsync(string y, string x, int promien, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#miejscowosci_lista", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string miejscowosci_lista(string nazwa, string kraj, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#miejscowosci_lista", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> miejscowosci_listaAsync(string nazwa, string kraj, string klucz);
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://burze.dzis.net/soap.php")]
    public partial class MyComplexTypeMiejscowosc : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<float> yField;
        
        private System.Nullable<float> xField;
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<float> y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<float> x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
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
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://burze.dzis.net/soap.php")]
    public partial class MyComplexTypeBurza : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> liczbaField;
        
        private System.Nullable<float> odlegloscField;
        
        private string kierunekField;
        
        private System.Nullable<int> okresField;
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> liczba {
            get {
                return this.liczbaField;
            }
            set {
                this.liczbaField = value;
                this.RaisePropertyChanged("liczba");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<float> odleglosc {
            get {
                return this.odlegloscField;
            }
            set {
                this.odlegloscField = value;
                this.RaisePropertyChanged("odleglosc");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string kierunek {
            get {
                return this.kierunekField;
            }
            set {
                this.kierunekField = value;
                this.RaisePropertyChanged("kierunek");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> okres {
            get {
                return this.okresField;
            }
            set {
                this.okresField = value;
                this.RaisePropertyChanged("okres");
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
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://burze.dzis.net/soap.php")]
    public partial class MyComplexTypeOstrzezenia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string od_dniaField;
        
        private string do_dniaField;
        
        private System.Nullable<int> mrozField;
        
        private string mroz_od_dniaField;
        
        private string mroz_do_dniaField;
        
        private System.Nullable<int> upalField;
        
        private string upal_od_dniaField;
        
        private string upal_do_dniaField;
        
        private System.Nullable<int> wiatrField;
        
        private string wiatr_od_dniaField;
        
        private string wiatr_do_dniaField;
        
        private System.Nullable<int> opadField;
        
        private string opad_od_dniaField;
        
        private string opad_do_dniaField;
        
        private System.Nullable<int> burzaField;
        
        private string burza_od_dniaField;
        
        private string burza_do_dniaField;
        
        private System.Nullable<int> trabaField;
        
        private string traba_od_dniaField;
        
        private string traba_do_dniaField;
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string od_dnia {
            get {
                return this.od_dniaField;
            }
            set {
                this.od_dniaField = value;
                this.RaisePropertyChanged("od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string do_dnia {
            get {
                return this.do_dniaField;
            }
            set {
                this.do_dniaField = value;
                this.RaisePropertyChanged("do_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> mroz {
            get {
                return this.mrozField;
            }
            set {
                this.mrozField = value;
                this.RaisePropertyChanged("mroz");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string mroz_od_dnia {
            get {
                return this.mroz_od_dniaField;
            }
            set {
                this.mroz_od_dniaField = value;
                this.RaisePropertyChanged("mroz_od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string mroz_do_dnia {
            get {
                return this.mroz_do_dniaField;
            }
            set {
                this.mroz_do_dniaField = value;
                this.RaisePropertyChanged("mroz_do_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> upal {
            get {
                return this.upalField;
            }
            set {
                this.upalField = value;
                this.RaisePropertyChanged("upal");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string upal_od_dnia {
            get {
                return this.upal_od_dniaField;
            }
            set {
                this.upal_od_dniaField = value;
                this.RaisePropertyChanged("upal_od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string upal_do_dnia {
            get {
                return this.upal_do_dniaField;
            }
            set {
                this.upal_do_dniaField = value;
                this.RaisePropertyChanged("upal_do_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> wiatr {
            get {
                return this.wiatrField;
            }
            set {
                this.wiatrField = value;
                this.RaisePropertyChanged("wiatr");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string wiatr_od_dnia {
            get {
                return this.wiatr_od_dniaField;
            }
            set {
                this.wiatr_od_dniaField = value;
                this.RaisePropertyChanged("wiatr_od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string wiatr_do_dnia {
            get {
                return this.wiatr_do_dniaField;
            }
            set {
                this.wiatr_do_dniaField = value;
                this.RaisePropertyChanged("wiatr_do_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> opad {
            get {
                return this.opadField;
            }
            set {
                this.opadField = value;
                this.RaisePropertyChanged("opad");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string opad_od_dnia {
            get {
                return this.opad_od_dniaField;
            }
            set {
                this.opad_od_dniaField = value;
                this.RaisePropertyChanged("opad_od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string opad_do_dnia {
            get {
                return this.opad_do_dniaField;
            }
            set {
                this.opad_do_dniaField = value;
                this.RaisePropertyChanged("opad_do_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> burza {
            get {
                return this.burzaField;
            }
            set {
                this.burzaField = value;
                this.RaisePropertyChanged("burza");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string burza_od_dnia {
            get {
                return this.burza_od_dniaField;
            }
            set {
                this.burza_od_dniaField = value;
                this.RaisePropertyChanged("burza_od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string burza_do_dnia {
            get {
                return this.burza_do_dniaField;
            }
            set {
                this.burza_do_dniaField = value;
                this.RaisePropertyChanged("burza_do_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> traba {
            get {
                return this.trabaField;
            }
            set {
                this.trabaField = value;
                this.RaisePropertyChanged("traba");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string traba_od_dnia {
            get {
                return this.traba_od_dniaField;
            }
            set {
                this.traba_od_dniaField = value;
                this.RaisePropertyChanged("traba_od_dnia");
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string traba_do_dnia {
            get {
                return this.traba_do_dniaField;
            }
            set {
                this.traba_do_dniaField = value;
                this.RaisePropertyChanged("traba_do_dnia");
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
    public interface serwerSOAPPortChannel : StormInfo.StormApi.serwerSOAPPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class serwerSOAPPortClient : System.ServiceModel.ClientBase<StormInfo.StormApi.serwerSOAPPort>, StormInfo.StormApi.serwerSOAPPort {
        
        public serwerSOAPPortClient() {
        }
        
        public serwerSOAPPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public serwerSOAPPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serwerSOAPPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serwerSOAPPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool KeyAPI(string klucz) {
            return base.Channel.KeyAPI(klucz);
        }
        
        public System.Threading.Tasks.Task<bool> KeyAPIAsync(string klucz) {
            return base.Channel.KeyAPIAsync(klucz);
        }
        
        public StormInfo.StormApi.MyComplexTypeMiejscowosc miejscowosc(string nazwa, string klucz) {
            return base.Channel.miejscowosc(nazwa, klucz);
        }
        
        public System.Threading.Tasks.Task<StormInfo.StormApi.MyComplexTypeMiejscowosc> miejscowoscAsync(string nazwa, string klucz) {
            return base.Channel.miejscowoscAsync(nazwa, klucz);
        }
        
        public StormInfo.StormApi.MyComplexTypeOstrzezenia ostrzezenia_pogodowe(float y, float x, string klucz) {
            return base.Channel.ostrzezenia_pogodowe(y, x, klucz);
        }
        
        public System.Threading.Tasks.Task<StormInfo.StormApi.MyComplexTypeOstrzezenia> ostrzezenia_pogodoweAsync(float y, float x, string klucz) {
            return base.Channel.ostrzezenia_pogodoweAsync(y, x, klucz);
        }
        
        public StormInfo.StormApi.MyComplexTypeBurza szukaj_burzy(string y, string x, int promien, string klucz) {
            return base.Channel.szukaj_burzy(y, x, promien, klucz);
        }
        
        public System.Threading.Tasks.Task<StormInfo.StormApi.MyComplexTypeBurza> szukaj_burzyAsync(string y, string x, int promien, string klucz) {
            return base.Channel.szukaj_burzyAsync(y, x, promien, klucz);
        }
        
        public string miejscowosci_lista(string nazwa, string kraj, string klucz) {
            return base.Channel.miejscowosci_lista(nazwa, kraj, klucz);
        }
        
        public System.Threading.Tasks.Task<string> miejscowosci_listaAsync(string nazwa, string kraj, string klucz) {
            return base.Channel.miejscowosci_listaAsync(nazwa, kraj, klucz);
        }
    }
}
