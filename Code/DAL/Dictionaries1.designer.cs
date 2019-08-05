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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Dic")]
	public partial class DictionariesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEF(EF instance);
    partial void UpdateEF(EF instance);
    partial void DeleteEF(EF instance);
    partial void InsertEA(EA instance);
    partial void UpdateEA(EA instance);
    partial void DeleteEA(EA instance);
    partial void InsertEE(EE instance);
    partial void UpdateEE(EE instance);
    partial void DeleteEE(EE instance);
    partial void InsertEG(EG instance);
    partial void UpdateEG(EG instance);
    partial void DeleteEG(EG instance);
    partial void InsertEI(EI instance);
    partial void UpdateEI(EI instance);
    partial void DeleteEI(EI instance);
    partial void InsertES(ES instance);
    partial void UpdateES(ES instance);
    partial void DeleteES(ES instance);
    partial void InsertSearchedWords(SearchedWords instance);
    partial void UpdateSearchedWords(SearchedWords instance);
    partial void DeleteSearchedWords(SearchedWords instance);
    #endregion
		
		public DictionariesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RoboNewserConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DictionariesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DictionariesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DictionariesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DictionariesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EF> EFs
		{
			get
			{
				return this.GetTable<EF>();
			}
		}
		
		public System.Data.Linq.Table<EA> EAs
		{
			get
			{
				return this.GetTable<EA>();
			}
		}
		
		public System.Data.Linq.Table<EE> EEs
		{
			get
			{
				return this.GetTable<EE>();
			}
		}
		
		public System.Data.Linq.Table<EG> EGs
		{
			get
			{
				return this.GetTable<EG>();
			}
		}
		
		public System.Data.Linq.Table<EI> EIs
		{
			get
			{
				return this.GetTable<EI>();
			}
		}
		
		public System.Data.Linq.Table<ES> ES
		{
			get
			{
				return this.GetTable<ES>();
			}
		}
		
		public System.Data.Linq.Table<SearchedWords> SearchedWords
		{
			get
			{
				return this.GetTable<SearchedWords>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EF")]
	public partial class EF : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Meaning;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnMeaningChanging(string value);
    partial void OnMeaningChanged();
    #endregion
		
		public EF()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(100)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Meaning", DbType="NVarChar(250)")]
		public string Meaning
		{
			get
			{
				return this._Meaning;
			}
			set
			{
				if ((this._Meaning != value))
				{
					this.OnMeaningChanging(value);
					this.SendPropertyChanging();
					this._Meaning = value;
					this.SendPropertyChanged("Meaning");
					this.OnMeaningChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EA")]
	public partial class EA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Meaning;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnMeaningChanging(string value);
    partial void OnMeaningChanged();
    #endregion
		
		public EA()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="NVarChar(100)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Meaning", DbType="NVarChar(500)")]
		public string Meaning
		{
			get
			{
				return this._Meaning;
			}
			set
			{
				if ((this._Meaning != value))
				{
					this.OnMeaningChanging(value);
					this.SendPropertyChanging();
					this._Meaning = value;
					this.SendPropertyChanged("Meaning");
					this.OnMeaningChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EE")]
	public partial class EE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Meaning;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnMeaningChanging(string value);
    partial void OnMeaningChanged();
    #endregion
		
		public EE()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="NVarChar(100)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Meaning", DbType="NVarChar(500)")]
		public string Meaning
		{
			get
			{
				return this._Meaning;
			}
			set
			{
				if ((this._Meaning != value))
				{
					this.OnMeaningChanging(value);
					this.SendPropertyChanging();
					this._Meaning = value;
					this.SendPropertyChanged("Meaning");
					this.OnMeaningChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EG")]
	public partial class EG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Meaning;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnMeaningChanging(string value);
    partial void OnMeaningChanged();
    #endregion
		
		public EG()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(100)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Meaning", DbType="VarChar(250)")]
		public string Meaning
		{
			get
			{
				return this._Meaning;
			}
			set
			{
				if ((this._Meaning != value))
				{
					this.OnMeaningChanging(value);
					this.SendPropertyChanging();
					this._Meaning = value;
					this.SendPropertyChanged("Meaning");
					this.OnMeaningChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EI")]
	public partial class EI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Meaning;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnMeaningChanging(string value);
    partial void OnMeaningChanged();
    #endregion
		
		public EI()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(100)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Meaning", DbType="VarChar(2500)")]
		public string Meaning
		{
			get
			{
				return this._Meaning;
			}
			set
			{
				if ((this._Meaning != value))
				{
					this.OnMeaningChanging(value);
					this.SendPropertyChanging();
					this._Meaning = value;
					this.SendPropertyChanged("Meaning");
					this.OnMeaningChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ES")]
	public partial class ES : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Meaning;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnMeaningChanging(string value);
    partial void OnMeaningChanged();
    #endregion
		
		public ES()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(100)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Meaning", DbType="VarChar(250)")]
		public string Meaning
		{
			get
			{
				return this._Meaning;
			}
			set
			{
				if ((this._Meaning != value))
				{
					this.OnMeaningChanging(value);
					this.SendPropertyChanging();
					this._Meaning = value;
					this.SendPropertyChanged("Meaning");
					this.OnMeaningChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SearchedWords")]
	public partial class SearchedWords : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Word;
		
		private string _Dic;
		
		private string _IP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnWordChanging(string value);
    partial void OnWordChanged();
    partial void OnDicChanging(string value);
    partial void OnDicChanged();
    partial void OnIPChanging(string value);
    partial void OnIPChanged();
    #endregion
		
		public SearchedWords()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="NVarChar(50)")]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this.OnWordChanging(value);
					this.SendPropertyChanging();
					this._Word = value;
					this.SendPropertyChanged("Word");
					this.OnWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dic", DbType="Char(3)")]
		public string Dic
		{
			get
			{
				return this._Dic;
			}
			set
			{
				if ((this._Dic != value))
				{
					this.OnDicChanging(value);
					this.SendPropertyChanging();
					this._Dic = value;
					this.SendPropertyChanged("Dic");
					this.OnDicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IP", DbType="NVarChar(50)")]
		public string IP
		{
			get
			{
				return this._IP;
			}
			set
			{
				if ((this._IP != value))
				{
					this.OnIPChanging(value);
					this.SendPropertyChanging();
					this._IP = value;
					this.SendPropertyChanged("IP");
					this.OnIPChanged();
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
