﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoboNewser.Code.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RoboNewser")]
	public partial class DBToolsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItemRates(ItemRates instance);
    partial void UpdateItemRates(ItemRates instance);
    partial void DeleteItemRates(ItemRates instance);
    #endregion
		
		public DBToolsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RoboNewserConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBToolsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBToolsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBToolsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBToolsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ItemRates> ItemRates
		{
			get
			{
				return this.GetTable<ItemRates>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spGetCount")]
		public ISingleResult<spGetCountResult> spGetCount([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TableName", DbType="VarChar(100)")] string tableName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WhereCond", DbType="NVarChar(1000)")] string whereCond)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tableName, whereCond);
			return ((ISingleResult<spGetCountResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemRates")]
	public partial class ItemRates : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemCode;
		
		private int _HCEntityCode;
		
		private decimal _RateVal;
		
		private int _RateCount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemCodeChanging(int value);
    partial void OnItemCodeChanged();
    partial void OnHCEntityCodeChanging(int value);
    partial void OnHCEntityCodeChanged();
    partial void OnRateValChanging(decimal value);
    partial void OnRateValChanged();
    partial void OnRateCountChanging(int value);
    partial void OnRateCountChanged();
    #endregion
		
		public ItemRates()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ItemCode
		{
			get
			{
				return this._ItemCode;
			}
			set
			{
				if ((this._ItemCode != value))
				{
					this.OnItemCodeChanging(value);
					this.SendPropertyChanging();
					this._ItemCode = value;
					this.SendPropertyChanged("ItemCode");
					this.OnItemCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCEntityCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int HCEntityCode
		{
			get
			{
				return this._HCEntityCode;
			}
			set
			{
				if ((this._HCEntityCode != value))
				{
					this.OnHCEntityCodeChanging(value);
					this.SendPropertyChanging();
					this._HCEntityCode = value;
					this.SendPropertyChanged("HCEntityCode");
					this.OnHCEntityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RateVal", DbType="Decimal(18,2) NOT NULL")]
		public decimal RateVal
		{
			get
			{
				return this._RateVal;
			}
			set
			{
				if ((this._RateVal != value))
				{
					this.OnRateValChanging(value);
					this.SendPropertyChanging();
					this._RateVal = value;
					this.SendPropertyChanged("RateVal");
					this.OnRateValChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RateCount", DbType="Int NOT NULL")]
		public int RateCount
		{
			get
			{
				return this._RateCount;
			}
			set
			{
				if ((this._RateCount != value))
				{
					this.OnRateCountChanging(value);
					this.SendPropertyChanging();
					this._RateCount = value;
					this.SendPropertyChanged("RateCount");
					this.OnRateCountChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class spGetCountResult
	{
		
		private System.Nullable<int> _Column1;
		
		public spGetCountResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Column1", DbType="Int")]
		public System.Nullable<int> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
