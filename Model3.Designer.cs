﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace BillingSystem
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class dbRezoneEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new dbRezoneEntities object using the connection string found in the 'dbRezoneEntities' section of the application configuration file.
        /// </summary>
        public dbRezoneEntities() : base("name=dbRezoneEntities", "dbRezoneEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbRezoneEntities object.
        /// </summary>
        public dbRezoneEntities(string connectionString) : base(connectionString, "dbRezoneEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbRezoneEntities object.
        /// </summary>
        public dbRezoneEntities(EntityConnection connection) : base(connection, "dbRezoneEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbNewZone> tbNewZones
        {
            get
            {
                if ((_tbNewZones == null))
                {
                    _tbNewZones = base.CreateObjectSet<tbNewZone>("tbNewZones");
                }
                return _tbNewZones;
            }
        }
        private ObjectSet<tbNewZone> _tbNewZones;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbRezone> tbRezones
        {
            get
            {
                if ((_tbRezones == null))
                {
                    _tbRezones = base.CreateObjectSet<tbRezone>("tbRezones");
                }
                return _tbRezones;
            }
        }
        private ObjectSet<tbRezone> _tbRezones;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbNewZones EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbNewZones(tbNewZone tbNewZone)
        {
            base.AddObject("tbNewZones", tbNewZone);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbRezones EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbRezones(tbRezone tbRezone)
        {
            base.AddObject("tbRezones", tbRezone);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dbRezoneModel", Name="tbNewZone")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbNewZone : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbNewZone object.
        /// </summary>
        /// <param name="newzone_id">Initial value of the newzone_id property.</param>
        public static tbNewZone CreatetbNewZone(global::System.Int32 newzone_id)
        {
            tbNewZone tbNewZone = new tbNewZone();
            tbNewZone.newzone_id = newzone_id;
            return tbNewZone;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 newzone_id
        {
            get
            {
                return _newzone_id;
            }
            set
            {
                if (_newzone_id != value)
                {
                    Onnewzone_idChanging(value);
                    ReportPropertyChanging("newzone_id");
                    _newzone_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("newzone_id");
                    Onnewzone_idChanged();
                }
            }
        }
        private global::System.Int32 _newzone_id;
        partial void Onnewzone_idChanging(global::System.Int32 value);
        partial void Onnewzone_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String newzone_name
        {
            get
            {
                return _newzone_name;
            }
            set
            {
                Onnewzone_nameChanging(value);
                ReportPropertyChanging("newzone_name");
                _newzone_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("newzone_name");
                Onnewzone_nameChanged();
            }
        }
        private global::System.String _newzone_name;
        partial void Onnewzone_nameChanging(global::System.String value);
        partial void Onnewzone_nameChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dbRezoneModel", Name="tbRezone")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbRezone : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbRezone object.
        /// </summary>
        /// <param name="rezone_id">Initial value of the rezone_id property.</param>
        public static tbRezone CreatetbRezone(global::System.Int32 rezone_id)
        {
            tbRezone tbRezone = new tbRezone();
            tbRezone.rezone_id = rezone_id;
            return tbRezone;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 rezone_id
        {
            get
            {
                return _rezone_id;
            }
            set
            {
                if (_rezone_id != value)
                {
                    Onrezone_idChanging(value);
                    ReportPropertyChanging("rezone_id");
                    _rezone_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("rezone_id");
                    Onrezone_idChanged();
                }
            }
        }
        private global::System.Int32 _rezone_id;
        partial void Onrezone_idChanging(global::System.Int32 value);
        partial void Onrezone_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String acctno
        {
            get
            {
                return _acctno;
            }
            set
            {
                OnacctnoChanging(value);
                ReportPropertyChanging("acctno");
                _acctno = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("acctno");
                OnacctnoChanged();
            }
        }
        private global::System.String _acctno;
        partial void OnacctnoChanging(global::System.String value);
        partial void OnacctnoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String old_zone
        {
            get
            {
                return _old_zone;
            }
            set
            {
                Onold_zoneChanging(value);
                ReportPropertyChanging("old_zone");
                _old_zone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("old_zone");
                Onold_zoneChanged();
            }
        }
        private global::System.String _old_zone;
        partial void Onold_zoneChanging(global::System.String value);
        partial void Onold_zoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String new_zone
        {
            get
            {
                return _new_zone;
            }
            set
            {
                Onnew_zoneChanging(value);
                ReportPropertyChanging("new_zone");
                _new_zone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("new_zone");
                Onnew_zoneChanged();
            }
        }
        private global::System.String _new_zone;
        partial void Onnew_zoneChanging(global::System.String value);
        partial void Onnew_zoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> date_added
        {
            get
            {
                return _date_added;
            }
            set
            {
                Ondate_addedChanging(value);
                ReportPropertyChanging("date_added");
                _date_added = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date_added");
                Ondate_addedChanged();
            }
        }
        private Nullable<global::System.DateTime> _date_added;
        partial void Ondate_addedChanging(Nullable<global::System.DateTime> value);
        partial void Ondate_addedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                OnremarksChanging(value);
                ReportPropertyChanging("remarks");
                _remarks = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("remarks");
                OnremarksChanged();
            }
        }
        private global::System.String _remarks;
        partial void OnremarksChanging(global::System.String value);
        partial void OnremarksChanged();

        #endregion

    
    }

    #endregion

    
}
