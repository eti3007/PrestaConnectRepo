﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DBPrestaConnectDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.DBPrestaConnectData>
    {
    
        public DBPrestaConnectDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).DBPrestaConnectData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DBPrestaConnectDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.DBPrestaConnectData>
    {
        public DBPrestaConnectDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Client))
            {
                return new global::LightSwitchApplication.Implementation.Client();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Intervention))
            {
                return new global::LightSwitchApplication.Implementation.Intervention();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Localisation))
            {
                return new global::LightSwitchApplication.Implementation.Localisation();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Prestataire))
            {
                return new global::LightSwitchApplication.Implementation.Prestataire();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Zone))
            {
                return new global::LightSwitchApplication.Implementation.Zone();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.DBPrestaConnectData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.DBPrestaConnectData(this.GetEntityConnectionString(
                "DBPrestaConnectData",
                "res://" + assemblyName + "/DBPrestaConnectData.csdl|res://" + assemblyName + "/DBPrestaConnectData.ssdl|res://" + assemblyName + "/DBPrestaConnectData.msl",
                "System.Data.SqlClient",
                true));
        }
    
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
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.DBPrestaConnectDataService))
            {
                return new global::LightSwitchApplication.DBPrestaConnectDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.DBPrestaConnectDataService))
            {
                return new global::LightSwitchApplication.Implementation.DBPrestaConnectDataServiceImplementation(dataService);
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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Client :
        global::LightSwitchApplication.Client.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Client.DetailsClass.IImplementation.Localisation1
        {
            get
            {
                return this.Localisation1;
            }
            set
            {
                this.Localisation1 = (global::LightSwitchApplication.Implementation.Localisation)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Localisation1");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Client.DetailsClass.IImplementation.Zone1
        {
            get
            {
                return this.Zone1;
            }
            set
            {
                this.Zone1 = (global::LightSwitchApplication.Implementation.Zone)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Zone1");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Client.DetailsClass.IImplementation.Interventions
        {
            get
            {
                return this.Interventions;
            }
        }
        
        partial void OnLocalisationChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Localisation1");
            }
        }
        
        partial void OnZoneChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Zone1");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Intervention :
        global::LightSwitchApplication.Intervention.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Intervention.DetailsClass.IImplementation.Client1
        {
            get
            {
                return this.Client1;
            }
            set
            {
                this.Client1 = (global::LightSwitchApplication.Implementation.Client)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Client1");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Intervention.DetailsClass.IImplementation.Prestataire1
        {
            get
            {
                return this.Prestataire1;
            }
            set
            {
                this.Prestataire1 = (global::LightSwitchApplication.Implementation.Prestataire)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Prestataire1");
                }
            }
        }
        
        partial void OnClientChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Client1");
            }
        }
        
        partial void OnPrestataireChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Prestataire1");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Localisation :
        global::LightSwitchApplication.Localisation.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Clients
        {
            get
            {
                return this.Clients;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Prestataires
        {
            get
            {
                return this.Prestataires;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Zones
        {
            get
            {
                return this.Zones;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Localisation.DetailsClass.IImplementation.Zones1
        {
            get
            {
                return this.Zones1;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Prestataire :
        global::LightSwitchApplication.Prestataire.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Prestataire.DetailsClass.IImplementation.Interventions
        {
            get
            {
                return this.Interventions;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Prestataire.DetailsClass.IImplementation.Localisation1
        {
            get
            {
                return this.Localisation1;
            }
            set
            {
                this.Localisation1 = (global::LightSwitchApplication.Implementation.Localisation)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Localisation1");
                }
            }
        }
        
        partial void OnLocalisationChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Localisation1");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Zone :
        global::LightSwitchApplication.Zone.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Zone.DetailsClass.IImplementation.Clients
        {
            get
            {
                return this.Clients;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Zone.DetailsClass.IImplementation.Localisation
        {
            get
            {
                return this.Localisation;
            }
            set
            {
                this.Localisation = (global::LightSwitchApplication.Implementation.Localisation)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Localisation");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Zone.DetailsClass.IImplementation.Localisation1
        {
            get
            {
                return this.Localisation1;
            }
            set
            {
                this.Localisation1 = (global::LightSwitchApplication.Implementation.Localisation)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Localisation1");
                }
            }
        }
        
        partial void OnLocalisationNOChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Localisation");
            }
        }
        
        partial void OnLocalisationSEChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Localisation1");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}
