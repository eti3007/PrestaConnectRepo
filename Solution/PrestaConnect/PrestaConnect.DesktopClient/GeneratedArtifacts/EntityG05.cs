﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    public sealed partial class Zone : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Zone entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Zone()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Zone(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Zone> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Zone.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Zone_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Zone_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Zone.DetailsClass.GetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Id);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Nom
        {
            get
            {
                return global::LightSwitchApplication.Zone.DetailsClass.GetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Nom);
            }
            set
            {
                global::LightSwitchApplication.Zone.DetailsClass.SetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Nom, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Nom_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Nom_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Nom_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Client> Clients
        {
            get
            {
                return global::LightSwitchApplication.Zone.DetailsClass.GetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Clients);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Client> ClientsQuery
        {
            get
            {
                return global::LightSwitchApplication.Zone.DetailsClass.GetQuery(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Clients);
            }
        }

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Localisation Localisation
        {
            get
            {
                return global::LightSwitchApplication.Zone.DetailsClass.GetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation);
            }
            set
            {
                global::LightSwitchApplication.Zone.DetailsClass.SetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Localisation_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Localisation_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Localisation_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Localisation Localisation1
        {
            get
            {
                return global::LightSwitchApplication.Zone.DetailsClass.GetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation1);
            }
            set
            {
                global::LightSwitchApplication.Zone.DetailsClass.SetValue(this, global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation1, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Localisation1_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Localisation1_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Localisation1_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Zone,
                global::LightSwitchApplication.Zone.DetailsClass,
                global::LightSwitchApplication.Zone.DetailsClass.IImplementation,
                global::LightSwitchApplication.Zone.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass>.Entry
                __ZoneEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass>.Entry(
                    global::LightSwitchApplication.Zone.DetailsClass.__Zone_CreateNew,
                    global::LightSwitchApplication.Zone.DetailsClass.__Zone_Created,
                    global::LightSwitchApplication.Zone.DetailsClass.__Zone_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Zone __Zone_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Zone> es)
            {
                return new global::LightSwitchApplication.Zone(es);
            }
            private static void __Zone_Created(global::LightSwitchApplication.Zone e)
            {
                e.Zone_Created();
            }
            private static bool __Zone_AllowSaveWithErrors(global::LightSwitchApplication.Zone e)
            {
                bool result = false;
                e.Zone_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Zone.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, string> Nom
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Nom) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Client> Clients
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Clients) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Client>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation> Localisation
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation> Localisation1
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation1) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; }
                new string Nom { get; set; }
                new global::System.Collections.IEnumerable Clients { get; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Localisation { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Localisation1 { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Zone.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, int>.Data> c, global::LightSwitchApplication.Zone.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Zone e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Zone e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Zone e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, string>.Entry
                    Nom = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, string>.Entry(
                        "Nom",
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Nom_Stub,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Nom_ComputeIsReadOnly,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Nom_Validate,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Nom_GetImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Nom_SetImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Nom_OnValueChanged);
                private static void _Nom_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Zone.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, string>.Data> c, global::LightSwitchApplication.Zone.DetailsClass d, object sf)
                {
                    c(d, ref d._Nom, sf);
                }
                private static bool _Nom_ComputeIsReadOnly(global::LightSwitchApplication.Zone e)
                {
                    bool result = false;
                    e.Nom_IsReadOnly(ref result);
                    return result;
                }
                private static void _Nom_Validate(global::LightSwitchApplication.Zone e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Nom_Validate(r);
                }
                private static string _Nom_GetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.ImplementationEntity.Nom;
                }
                private static void _Nom_SetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Nom = v;
                }
                private static void _Nom_OnValueChanged(global::LightSwitchApplication.Zone e)
                {
                    e.Nom_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Client>.Entry
                    Clients = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Client>.Entry(
                        "Clients",
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Clients_Stub,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Clients_GetReferencedEntities,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Clients_GetEntityCollection);
                private static void _Clients_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Zone.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Client>.Data> c, global::LightSwitchApplication.Zone.DetailsClass d, object sf)
                {
                    c(d, ref d._Clients, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Client> _Clients_GetReferencedEntities(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Client, global::LightSwitchApplication.Client.DetailsClass>(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Clients, ref d._Clients);
                }
                private static global::System.Collections.IEnumerable _Clients_GetEntityCollection(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.ImplementationEntity.Clients;
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Entry
                    Localisation = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Entry(
                        "Localisation",
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_Stub,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_ComputeIsReadOnly,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_Validate,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_GetCoreImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_GetImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_SetImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_Refresh,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation_OnValueChanged);
                private static void _Localisation_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Zone.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Data> c, global::LightSwitchApplication.Zone.DetailsClass d, object sf)
                {
                    c(d, ref d._Localisation, sf);
                }
                private static bool _Localisation_ComputeIsReadOnly(global::LightSwitchApplication.Zone e)
                {
                    bool result = false;
                    e.Localisation_IsReadOnly(ref result);
                    return result;
                }
                private static void _Localisation_Validate(global::LightSwitchApplication.Zone e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Localisation_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Localisation_GetCoreImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.ImplementationEntity.Localisation;
                }
                private static global::LightSwitchApplication.Localisation _Localisation_GetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Localisation, global::LightSwitchApplication.Localisation.DetailsClass>(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation, ref d._Localisation);
                }
                private static void _Localisation_SetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d, global::LightSwitchApplication.Localisation v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation, ref d._Localisation, (i, ev) => i.Localisation = ev, v);
                }
                private static void _Localisation_Refresh(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation, ref d._Localisation);
                }
                private static void _Localisation_OnValueChanged(global::LightSwitchApplication.Zone e)
                {
                    e.Localisation_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Entry
                    Localisation1 = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Entry(
                        "Localisation1",
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_Stub,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_ComputeIsReadOnly,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_Validate,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_GetCoreImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_GetImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_SetImplementationValue,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_Refresh,
                        global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties._Localisation1_OnValueChanged);
                private static void _Localisation1_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Zone.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Data> c, global::LightSwitchApplication.Zone.DetailsClass d, object sf)
                {
                    c(d, ref d._Localisation1, sf);
                }
                private static bool _Localisation1_ComputeIsReadOnly(global::LightSwitchApplication.Zone e)
                {
                    bool result = false;
                    e.Localisation1_IsReadOnly(ref result);
                    return result;
                }
                private static void _Localisation1_Validate(global::LightSwitchApplication.Zone e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Localisation1_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Localisation1_GetCoreImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.ImplementationEntity.Localisation1;
                }
                private static global::LightSwitchApplication.Localisation _Localisation1_GetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Localisation, global::LightSwitchApplication.Localisation.DetailsClass>(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation1, ref d._Localisation1);
                }
                private static void _Localisation1_SetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass d, global::LightSwitchApplication.Localisation v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation1, ref d._Localisation1, (i, ev) => i.Localisation1 = ev, v);
                }
                private static void _Localisation1_Refresh(global::LightSwitchApplication.Zone.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.Zone.DetailsClass.PropertySetProperties.Localisation1, ref d._Localisation1);
                }
                private static void _Localisation1_OnValueChanged(global::LightSwitchApplication.Zone e)
                {
                    e.Localisation1_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, string>.Data _Nom;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Client>.Data _Clients;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Data _Localisation;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Zone, global::LightSwitchApplication.Zone.DetailsClass, global::LightSwitchApplication.Localisation>.Data _Localisation1;
            
        }
    
        #endregion
    }
    
    #endregion
}
