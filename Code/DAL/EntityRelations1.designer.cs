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
	public partial class EntityRelationsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEntityRelations(EntityRelations instance);
    partial void UpdateEntityRelations(EntityRelations instance);
    partial void DeleteEntityRelations(EntityRelations instance);
    #endregion
		
		public EntityRelationsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RoboNewserConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EntityRelationsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntityRelationsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntityRelationsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntityRelationsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EntityRelations> EntityRelations
		{
			get
			{
				return this.GetTable<EntityRelations>();
			}
		}
		
		public System.Data.Linq.Table<vEntityRelations> vEntityRelations
		{
			get
			{
				return this.GetTable<vEntityRelations>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSetRelatedEntities")]
		public int spSetRelatedEntities([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EntityCode", DbType="Int")] System.Nullable<int> entityCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HCEntityTypeCode", DbType="Int")] System.Nullable<int> hCEntityTypeCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HCRelatedEntityTypeCode", DbType="Int")] System.Nullable<int> hCRelatedEntityTypeCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MatualCount", DbType="Int")] System.Nullable<int> matualCount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), entityCode, hCEntityTypeCode, hCRelatedEntityTypeCode, matualCount);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EntityRelations")]
	public partial class EntityRelations : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private int _EntityCode;
		
		private int _HCEntityTypeCode;
		
		private int _RelatedEntityCode;
		
		private int _HCRelatedEntityTypeCode;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnEntityCodeChanging(int value);
    partial void OnEntityCodeChanged();
    partial void OnHCEntityTypeCodeChanging(int value);
    partial void OnHCEntityTypeCodeChanged();
    partial void OnRelatedEntityCodeChanging(int value);
    partial void OnRelatedEntityCodeChanged();
    partial void OnHCRelatedEntityTypeCodeChanging(int value);
    partial void OnHCRelatedEntityTypeCodeChanged();
    #endregion
		
		public EntityRelations()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntityCode", DbType="Int NOT NULL")]
		public int EntityCode
		{
			get
			{
				return this._EntityCode;
			}
			set
			{
				if ((this._EntityCode != value))
				{
					this.OnEntityCodeChanging(value);
					this.SendPropertyChanging();
					this._EntityCode = value;
					this.SendPropertyChanged("EntityCode");
					this.OnEntityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCEntityTypeCode", DbType="Int NOT NULL")]
		public int HCEntityTypeCode
		{
			get
			{
				return this._HCEntityTypeCode;
			}
			set
			{
				if ((this._HCEntityTypeCode != value))
				{
					this.OnHCEntityTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._HCEntityTypeCode = value;
					this.SendPropertyChanged("HCEntityTypeCode");
					this.OnHCEntityTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelatedEntityCode", DbType="Int NOT NULL")]
		public int RelatedEntityCode
		{
			get
			{
				return this._RelatedEntityCode;
			}
			set
			{
				if ((this._RelatedEntityCode != value))
				{
					this.OnRelatedEntityCodeChanging(value);
					this.SendPropertyChanging();
					this._RelatedEntityCode = value;
					this.SendPropertyChanged("RelatedEntityCode");
					this.OnRelatedEntityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCRelatedEntityTypeCode", DbType="Int NOT NULL")]
		public int HCRelatedEntityTypeCode
		{
			get
			{
				return this._HCRelatedEntityTypeCode;
			}
			set
			{
				if ((this._HCRelatedEntityTypeCode != value))
				{
					this.OnHCRelatedEntityTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._HCRelatedEntityTypeCode = value;
					this.SendPropertyChanged("HCRelatedEntityTypeCode");
					this.OnHCRelatedEntityTypeCodeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vEntityRelations")]
	public partial class vEntityRelations
	{
		
		private int _Code;
		
		private int _EntityCode;
		
		private int _HCEntityTypeCode;
		
		private int _RelatedEntityCode;
		
		public vEntityRelations()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this._Code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntityCode", DbType="Int NOT NULL")]
		public int EntityCode
		{
			get
			{
				return this._EntityCode;
			}
			set
			{
				if ((this._EntityCode != value))
				{
					this._EntityCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCEntityTypeCode", DbType="Int NOT NULL")]
		public int HCEntityTypeCode
		{
			get
			{
				return this._HCEntityTypeCode;
			}
			set
			{
				if ((this._HCEntityTypeCode != value))
				{
					this._HCEntityTypeCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelatedEntityCode", DbType="Int NOT NULL")]
		public int RelatedEntityCode
		{
			get
			{
				return this._RelatedEntityCode;
			}
			set
			{
				if ((this._RelatedEntityCode != value))
				{
					this._RelatedEntityCode = value;
				}
			}
		}
	}
}
#pragma warning restore 1591