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
	public partial class ErrorLogsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertErrorLogs(ErrorLogs instance);
    partial void UpdateErrorLogs(ErrorLogs instance);
    partial void DeleteErrorLogs(ErrorLogs instance);
    #endregion
		
		public ErrorLogsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RoboNewserConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vErrorLogs> vErrorLogs
		{
			get
			{
				return this.GetTable<vErrorLogs>();
			}
		}
		
		public System.Data.Linq.Table<ErrorLogs> ErrorLogs
		{
			get
			{
				return this.GetTable<ErrorLogs>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vErrorLogs")]
	public partial class vErrorLogs
	{
		
		private int _Code;
		
		private string _Message;
		
		private System.Nullable<System.DateTime> _DateTime;
		
		public vErrorLogs()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="VarChar(1000)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this._Message = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this._DateTime = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ErrorLogs")]
	public partial class ErrorLogs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _ErrorDesc;
		
		private System.Nullable<System.DateTime> _ErrorTime;
		
		private string _SectionName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnErrorDescChanging(string value);
    partial void OnErrorDescChanged();
    partial void OnErrorTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnErrorTimeChanged();
    partial void OnSectionNameChanging(string value);
    partial void OnSectionNameChanged();
    #endregion
		
		public ErrorLogs()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorDesc", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string ErrorDesc
		{
			get
			{
				return this._ErrorDesc;
			}
			set
			{
				if ((this._ErrorDesc != value))
				{
					this.OnErrorDescChanging(value);
					this.SendPropertyChanging();
					this._ErrorDesc = value;
					this.SendPropertyChanged("ErrorDesc");
					this.OnErrorDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> ErrorTime
		{
			get
			{
				return this._ErrorTime;
			}
			set
			{
				if ((this._ErrorTime != value))
				{
					this.OnErrorTimeChanging(value);
					this.SendPropertyChanging();
					this._ErrorTime = value;
					this.SendPropertyChanged("ErrorTime");
					this.OnErrorTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionName", DbType="NVarChar(500)")]
		public string SectionName
		{
			get
			{
				return this._SectionName;
			}
			set
			{
				if ((this._SectionName != value))
				{
					this.OnSectionNameChanging(value);
					this.SendPropertyChanging();
					this._SectionName = value;
					this.SendPropertyChanged("SectionName");
					this.OnSectionNameChanged();
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
}
#pragma warning restore 1591