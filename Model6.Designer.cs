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
    public partial class dbCommercialEntitiesLIVE : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new dbCommercialEntitiesLIVE object using the connection string found in the 'dbCommercialEntitiesLIVE' section of the application configuration file.
        /// </summary>
        public dbCommercialEntitiesLIVE() : base("name=dbCommercialEntitiesLIVE", "dbCommercialEntitiesLIVE")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbCommercialEntitiesLIVE object.
        /// </summary>
        public dbCommercialEntitiesLIVE(string connectionString) : base(connectionString, "dbCommercialEntitiesLIVE")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbCommercialEntitiesLIVE object.
        /// </summary>
        public dbCommercialEntitiesLIVE(EntityConnection connection) : base(connection, "dbCommercialEntitiesLIVE")
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
        public ObjectSet<tbDormantMonitoring> tbDormantMonitorings
        {
            get
            {
                if ((_tbDormantMonitorings == null))
                {
                    _tbDormantMonitorings = base.CreateObjectSet<tbDormantMonitoring>("tbDormantMonitorings");
                }
                return _tbDormantMonitorings;
            }
        }
        private ObjectSet<tbDormantMonitoring> _tbDormantMonitorings;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbDormantMonitorings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbDormantMonitorings(tbDormantMonitoring tbDormantMonitoring)
        {
            base.AddObject("tbDormantMonitorings", tbDormantMonitoring);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dbCommercialModelLive", Name="tbDormantMonitoring")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbDormantMonitoring : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbDormantMonitoring object.
        /// </summary>
        /// <param name="dormant_id">Initial value of the dormant_id property.</param>
        public static tbDormantMonitoring CreatetbDormantMonitoring(global::System.Int32 dormant_id)
        {
            tbDormantMonitoring tbDormantMonitoring = new tbDormantMonitoring();
            tbDormantMonitoring.dormant_id = dormant_id;
            return tbDormantMonitoring;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 dormant_id
        {
            get
            {
                return _dormant_id;
            }
            set
            {
                if (_dormant_id != value)
                {
                    Ondormant_idChanging(value);
                    ReportPropertyChanging("dormant_id");
                    _dormant_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("dormant_id");
                    Ondormant_idChanged();
                }
            }
        }
        private global::System.Int32 _dormant_id;
        partial void Ondormant_idChanging(global::System.Int32 value);
        partial void Ondormant_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> cardno
        {
            get
            {
                return _cardno;
            }
            set
            {
                OncardnoChanging(value);
                ReportPropertyChanging("cardno");
                _cardno = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cardno");
                OncardnoChanged();
            }
        }
        private Nullable<global::System.Int32> _cardno;
        partial void OncardnoChanging(Nullable<global::System.Int32> value);
        partial void OncardnoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String zone
        {
            get
            {
                return _zone;
            }
            set
            {
                OnzoneChanging(value);
                ReportPropertyChanging("zone");
                _zone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("zone");
                OnzoneChanged();
            }
        }
        private global::System.String _zone;
        partial void OnzoneChanging(global::System.String value);
        partial void OnzoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> category
        {
            get
            {
                return _category;
            }
            set
            {
                OncategoryChanging(value);
                ReportPropertyChanging("category");
                _category = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("category");
                OncategoryChanged();
            }
        }
        private Nullable<global::System.Int32> _category;
        partial void OncategoryChanging(Nullable<global::System.Int32> value);
        partial void OncategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> date_disconnected
        {
            get
            {
                return _date_disconnected;
            }
            set
            {
                Ondate_disconnectedChanging(value);
                ReportPropertyChanging("date_disconnected");
                _date_disconnected = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date_disconnected");
                Ondate_disconnectedChanged();
            }
        }
        private Nullable<global::System.DateTime> _date_disconnected;
        partial void Ondate_disconnectedChanging(Nullable<global::System.DateTime> value);
        partial void Ondate_disconnectedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> arrears
        {
            get
            {
                return _arrears;
            }
            set
            {
                OnarrearsChanging(value);
                ReportPropertyChanging("arrears");
                _arrears = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("arrears");
                OnarrearsChanged();
            }
        }
        private Nullable<global::System.Decimal> _arrears;
        partial void OnarrearsChanging(Nullable<global::System.Decimal> value);
        partial void OnarrearsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> amount_paid
        {
            get
            {
                return _amount_paid;
            }
            set
            {
                Onamount_paidChanging(value);
                ReportPropertyChanging("amount_paid");
                _amount_paid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("amount_paid");
                Onamount_paidChanged();
            }
        }
        private Nullable<global::System.Decimal> _amount_paid;
        partial void Onamount_paidChanging(Nullable<global::System.Decimal> value);
        partial void Onamount_paidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> date_paid
        {
            get
            {
                return _date_paid;
            }
            set
            {
                Ondate_paidChanging(value);
                ReportPropertyChanging("date_paid");
                _date_paid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date_paid");
                Ondate_paidChanged();
            }
        }
        private Nullable<global::System.DateTime> _date_paid;
        partial void Ondate_paidChanging(Nullable<global::System.DateTime> value);
        partial void Ondate_paidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> paid_count
        {
            get
            {
                return _paid_count;
            }
            set
            {
                Onpaid_countChanging(value);
                ReportPropertyChanging("paid_count");
                _paid_count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("paid_count");
                Onpaid_countChanged();
            }
        }
        private Nullable<global::System.Int32> _paid_count;
        partial void Onpaid_countChanging(Nullable<global::System.Int32> value);
        partial void Onpaid_countChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String current_status
        {
            get
            {
                return _current_status;
            }
            set
            {
                Oncurrent_statusChanging(value);
                ReportPropertyChanging("current_status");
                _current_status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("current_status");
                Oncurrent_statusChanged();
            }
        }
        private global::System.String _current_status;
        partial void Oncurrent_statusChanging(global::System.String value);
        partial void Oncurrent_statusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> date_generated
        {
            get
            {
                return _date_generated;
            }
            set
            {
                Ondate_generatedChanging(value);
                ReportPropertyChanging("date_generated");
                _date_generated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date_generated");
                Ondate_generatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _date_generated;
        partial void Ondate_generatedChanging(Nullable<global::System.DateTime> value);
        partial void Ondate_generatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String baseline_data
        {
            get
            {
                return _baseline_data;
            }
            set
            {
                Onbaseline_dataChanging(value);
                ReportPropertyChanging("baseline_data");
                _baseline_data = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("baseline_data");
                Onbaseline_dataChanged();
            }
        }
        private global::System.String _baseline_data;
        partial void Onbaseline_dataChanging(global::System.String value);
        partial void Onbaseline_dataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> masterID
        {
            get
            {
                return _masterID;
            }
            set
            {
                OnmasterIDChanging(value);
                ReportPropertyChanging("masterID");
                _masterID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("masterID");
                OnmasterIDChanged();
            }
        }
        private Nullable<global::System.Int32> _masterID;
        partial void OnmasterIDChanging(Nullable<global::System.Int32> value);
        partial void OnmasterIDChanged();
    
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
        public Nullable<global::System.Decimal> balance
        {
            get
            {
                return _balance;
            }
            set
            {
                OnbalanceChanging(value);
                ReportPropertyChanging("balance");
                _balance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("balance");
                OnbalanceChanged();
            }
        }
        private Nullable<global::System.Decimal> _balance;
        partial void OnbalanceChanging(Nullable<global::System.Decimal> value);
        partial void OnbalanceChanged();

        #endregion

    
    }

    #endregion

    
}