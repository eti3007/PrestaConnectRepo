﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Client
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/DBPrestaConnectData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Client :
        global::LightSwitchApplication.Client.DetailsClass.IImplementation
    {
        partial void OnLocalisationChanged()
        {
            this.___OnPropertyChanged("Localisation");
            this.___OnPropertyChanged("Localisation1");
        }
        
        partial void OnZoneChanged()
        {
            this.___OnPropertyChanged("Zone");
            this.___OnPropertyChanged("Zone1");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNomChanged()
        {
            this.___OnPropertyChanged("Nom");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Client.DetailsClass.IImplementation.Localisation1
        {
            get
            {
                return this.Localisation1;
            }
            set
            {
                this.Localisation1 = (global::LightSwitchApplication.Implementation.Localisation)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> __Localisation1
        {
            get
            {
                if (this.___Localisation1 == null)
                {
                    this.___Localisation1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation>(
                        this,
                        "Localisation1",
                        new string[] { "Localisation" },
                        e => global::System.Object.Equals(e.Id, this.Localisation),
                        () => this._Localisation1,
                        e => this._Localisation1 = e);
                }
                return this.___Localisation1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> ___Localisation1;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Client.DetailsClass.IImplementation.Zone1
        {
            get
            {
                return this.Zone1;
            }
            set
            {
                this.Zone1 = (global::LightSwitchApplication.Implementation.Zone)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Zone> __Zone1
        {
            get
            {
                if (this.___Zone1 == null)
                {
                    this.___Zone1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Zone>(
                        this,
                        "Zone1",
                        new string[] { "Zone" },
                        e => global::System.Object.Equals(e.Id, this.Zone),
                        () => this._Zone1,
                        e => this._Zone1 = e);
                }
                return this.___Zone1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Zone> ___Zone1;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Client.DetailsClass.IImplementation.Interventions
        {
            get
            {
                return this.Interventions;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Intervention> __Interventions
        {
            get
            {
                if (this.___Interventions == null)
                {
                    this.___Interventions = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Intervention>(
                        this,
                        "Interventions",
                        () => this._Interventions,
                        e => global::System.Object.Equals(e.Client, this.Id));
                }
                return this.___Interventions;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Intervention> ___Interventions;
        
    }
    #endregion
    
    #region Intervention
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/DBPrestaConnectData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Intervention :
        global::LightSwitchApplication.Intervention.DetailsClass.IImplementation
    {
        partial void OnClientChanged()
        {
            this.___OnPropertyChanged("Client");
            this.___OnPropertyChanged("Client1");
        }
        
        partial void OnPrestataireChanged()
        {
            this.___OnPropertyChanged("Prestataire");
            this.___OnPropertyChanged("Prestataire1");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnDateDebutChanged()
        {
            this.___OnPropertyChanged("DateDebut");
        }
        
        partial void OnDateFinChanged()
        {
            this.___OnPropertyChanged("DateFin");
        }
        
        partial void OnPosteChanged()
        {
            this.___OnPropertyChanged("Poste");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Intervention.DetailsClass.IImplementation.Client1
        {
            get
            {
                return this.Client1;
            }
            set
            {
                this.Client1 = (global::LightSwitchApplication.Implementation.Client)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Client> __Client1
        {
            get
            {
                if (this.___Client1 == null)
                {
                    this.___Client1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Client>(
                        this,
                        "Client1",
                        new string[] { "Client" },
                        e => global::System.Object.Equals(e.Id, this.Client),
                        () => this._Client1,
                        e => this._Client1 = e);
                }
                return this.___Client1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Client> ___Client1;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Intervention.DetailsClass.IImplementation.Prestataire1
        {
            get
            {
                return this.Prestataire1;
            }
            set
            {
                this.Prestataire1 = (global::LightSwitchApplication.Implementation.Prestataire)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Prestataire> __Prestataire1
        {
            get
            {
                if (this.___Prestataire1 == null)
                {
                    this.___Prestataire1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Prestataire>(
                        this,
                        "Prestataire1",
                        new string[] { "Prestataire" },
                        e => global::System.Object.Equals(e.Id, this.Prestataire),
                        () => this._Prestataire1,
                        e => this._Prestataire1 = e);
                }
                return this.___Prestataire1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Prestataire> ___Prestataire1;
        
    }
    #endregion
    
    #region Localisation
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/DBPrestaConnectData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Localisation :
        global::LightSwitchApplication.Localisation.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnLatitudeChanged()
        {
            this.___OnPropertyChanged("Latitude");
        }
        
        partial void OnLongitudeChanged()
        {
            this.___OnPropertyChanged("Longitude");
        }
        
        partial void OnAdresseCompleteChanged()
        {
            this.___OnPropertyChanged("AdresseComplete");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Clients
        {
            get
            {
                return this.Clients;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Client> __Clients
        {
            get
            {
                if (this.___Clients == null)
                {
                    this.___Clients = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Client>(
                        this,
                        "Clients",
                        () => this._Clients,
                        e => global::System.Object.Equals(e.Localisation, this.Id));
                }
                return this.___Clients;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Client> ___Clients;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Prestataires
        {
            get
            {
                return this.Prestataires;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Prestataire> __Prestataires
        {
            get
            {
                if (this.___Prestataires == null)
                {
                    this.___Prestataires = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Prestataire>(
                        this,
                        "Prestataires",
                        () => this._Prestataires,
                        e => global::System.Object.Equals(e.Localisation, this.Id));
                }
                return this.___Prestataires;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Prestataire> ___Prestataires;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Zones
        {
            get
            {
                return this.Zones;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Zone> __Zones
        {
            get
            {
                if (this.___Zones == null)
                {
                    this.___Zones = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Zone>(
                        this,
                        "Zones",
                        () => this._Zones,
                        e => global::System.Object.Equals(e.LocalisationNO, this.Id));
                }
                return this.___Zones;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Zone> ___Zones;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Zones1
        {
            get
            {
                return this.Zones1;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Zone> __Zones1
        {
            get
            {
                if (this.___Zones1 == null)
                {
                    this.___Zones1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Zone>(
                        this,
                        "Zones1",
                        () => this._Zones1,
                        e => global::System.Object.Equals(e.LocalisationSE, this.Id));
                }
                return this.___Zones1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Zone> ___Zones1;
        
    }
    #endregion
    
    #region Prestataire
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/DBPrestaConnectData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Prestataire :
        global::LightSwitchApplication.Prestataire.DetailsClass.IImplementation
    {
        partial void OnLocalisationChanged()
        {
            this.___OnPropertyChanged("Localisation");
            this.___OnPropertyChanged("Localisation1");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNomChanged()
        {
            this.___OnPropertyChanged("Nom");
        }
        
        partial void OnPrenomChanged()
        {
            this.___OnPropertyChanged("Prenom");
        }
        
        partial void OnEmailProChanged()
        {
            this.___OnPropertyChanged("EmailPro");
        }
        
        partial void OnEmailPersoChanged()
        {
            this.___OnPropertyChanged("EmailPerso");
        }
        
        partial void OnMobileChanged()
        {
            this.___OnPropertyChanged("Mobile");
        }
        
        partial void OnCompteSkypeChanged()
        {
            this.___OnPropertyChanged("CompteSkype");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Prestataire.DetailsClass.IImplementation.Interventions
        {
            get
            {
                return this.Interventions;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Intervention> __Interventions
        {
            get
            {
                if (this.___Interventions == null)
                {
                    this.___Interventions = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Intervention>(
                        this,
                        "Interventions",
                        () => this._Interventions,
                        e => global::System.Object.Equals(e.Prestataire, this.Id));
                }
                return this.___Interventions;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Intervention> ___Interventions;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Prestataire.DetailsClass.IImplementation.Localisation1
        {
            get
            {
                return this.Localisation1;
            }
            set
            {
                this.Localisation1 = (global::LightSwitchApplication.Implementation.Localisation)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> __Localisation1
        {
            get
            {
                if (this.___Localisation1 == null)
                {
                    this.___Localisation1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation>(
                        this,
                        "Localisation1",
                        new string[] { "Localisation" },
                        e => global::System.Object.Equals(e.Id, this.Localisation),
                        () => this._Localisation1,
                        e => this._Localisation1 = e);
                }
                return this.___Localisation1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> ___Localisation1;
        
    }
    #endregion
    
    #region Zone
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/DBPrestaConnectData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Zone :
        global::LightSwitchApplication.Zone.DetailsClass.IImplementation
    {
        partial void OnLocalisationNOChanged()
        {
            this.___OnPropertyChanged("LocalisationNO");
            this.___OnPropertyChanged("Localisation");
        }
        
        partial void OnLocalisationSEChanged()
        {
            this.___OnPropertyChanged("LocalisationSE");
            this.___OnPropertyChanged("Localisation1");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNomChanged()
        {
            this.___OnPropertyChanged("Nom");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Zone.DetailsClass.IImplementation.Clients
        {
            get
            {
                return this.Clients;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Client> __Clients
        {
            get
            {
                if (this.___Clients == null)
                {
                    this.___Clients = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Client>(
                        this,
                        "Clients",
                        () => this._Clients,
                        e => global::System.Object.Equals(e.Zone, this.Id));
                }
                return this.___Clients;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Client> ___Clients;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Zone.DetailsClass.IImplementation.Localisation
        {
            get
            {
                return this.Localisation;
            }
            set
            {
                this.Localisation = (global::LightSwitchApplication.Implementation.Localisation)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> __Localisation
        {
            get
            {
                if (this.___Localisation == null)
                {
                    this.___Localisation = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation>(
                        this,
                        "Localisation",
                        new string[] { "LocalisationNO" },
                        e => global::System.Object.Equals(e.Id, this.LocalisationNO),
                        () => this._Localisation,
                        e => this._Localisation = e);
                }
                return this.___Localisation;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> ___Localisation;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Zone.DetailsClass.IImplementation.Localisation1
        {
            get
            {
                return this.Localisation1;
            }
            set
            {
                this.Localisation1 = (global::LightSwitchApplication.Implementation.Localisation)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> __Localisation1
        {
            get
            {
                if (this.___Localisation1 == null)
                {
                    this.___Localisation1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation>(
                        this,
                        "Localisation1",
                        new string[] { "LocalisationSE" },
                        e => global::System.Object.Equals(e.Id, this.LocalisationSE),
                        () => this._Localisation1,
                        e => this._Localisation1 = e);
                }
                return this.___Localisation1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Localisation> ___Localisation1;
        
    }
    #endregion
    
    #region DBPrestaConnectData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class DBPrestaConnectData
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Client))
            {
                return new global::LightSwitchApplication.Implementation.Client();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Intervention))
            {
                return new global::LightSwitchApplication.Implementation.Intervention();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Localisation))
            {
                return new global::LightSwitchApplication.Implementation.Localisation();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Prestataire))
            {
                return new global::LightSwitchApplication.Implementation.Prestataire();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Zone))
            {
                return new global::LightSwitchApplication.Implementation.Zone();
            }
            return null;
        }
        
        protected override void InitializeDataServiceContext()
        {
            this.Format.LoadServiceModel = global::LightSwitchApplication.Implementation.DBPrestaConnectData.GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.DBPrestaConnectData))
            {
                return new global::LightSwitchApplication.DBPrestaConnectData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.DBPrestaConnectData))
            {
                return new global::LightSwitchApplication.Implementation.DBPrestaConnectData(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../../DBPrestaConnectData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Client) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Client);
            }
            if (typeof(global::LightSwitchApplication.Intervention) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Intervention);
            }
            if (typeof(global::LightSwitchApplication.Localisation) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Localisation);
            }
            if (typeof(global::LightSwitchApplication.Prestataire) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Prestataire);
            }
            if (typeof(global::LightSwitchApplication.Zone) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Zone);
            }
            return null;
        }
    }
}
