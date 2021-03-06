﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERespondent.Entity
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="E_Respondent")]
	public partial class E_RespondentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertDestinationSave(DestinationSave instance);
    partial void UpdateDestinationSave(DestinationSave instance);
    partial void DeleteDestinationSave(DestinationSave instance);
    partial void InsertTypeFuelEnergy(TypeFuelEnergy instance);
    partial void UpdateTypeFuelEnergy(TypeFuelEnergy instance);
    partial void DeleteTypeFuelEnergy(TypeFuelEnergy instance);
    #endregion
		
		public E_RespondentDataContext() : 
				base(global::ERespondent.Properties.Settings.Default.E_RespondentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public E_RespondentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public E_RespondentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public E_RespondentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public E_RespondentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DestinationSave> DestinationSave
		{
			get
			{
				return this.GetTable<DestinationSave>();
			}
		}
		
		public System.Data.Linq.Table<TypeFuelEnergy> TypeFuelEnergy
		{
			get
			{
				return this.GetTable<TypeFuelEnergy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DestinationSave")]
	public partial class DestinationSave : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodeRecord;
		
		private System.Nullable<int> _CodeDirection;
		
		private string _DestinationsSave;
		
		private string _Unit;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeRecordChanging(int value);
    partial void OnCodeRecordChanged();
    partial void OnCodeDirectionChanging(System.Nullable<int> value);
    partial void OnCodeDirectionChanged();
    partial void OnDestinationsSaveChanging(string value);
    partial void OnDestinationsSaveChanged();
    partial void OnUnitChanging(string value);
    partial void OnUnitChanged();
    #endregion
		
		public DestinationSave()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeRecord", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodeRecord
		{
			get
			{
				return this._CodeRecord;
			}
			set
			{
				if ((this._CodeRecord != value))
				{
					this.OnCodeRecordChanging(value);
					this.SendPropertyChanging();
					this._CodeRecord = value;
					this.SendPropertyChanged("CodeRecord");
					this.OnCodeRecordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeDirection", DbType="Int")]
		public System.Nullable<int> CodeDirection
		{
			get
			{
				return this._CodeDirection;
			}
			set
			{
				if ((this._CodeDirection != value))
				{
					this.OnCodeDirectionChanging(value);
					this.SendPropertyChanging();
					this._CodeDirection = value;
					this.SendPropertyChanged("CodeDirection");
					this.OnCodeDirectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DestinationsSave", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string DestinationsSave
		{
			get
			{
				return this._DestinationsSave;
			}
			set
			{
				if ((this._DestinationsSave != value))
				{
					this.OnDestinationsSaveChanging(value);
					this.SendPropertyChanging();
					this._DestinationsSave = value;
					this.SendPropertyChanged("DestinationsSave");
					this.OnDestinationsSaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TypeFuelEnergy")]
	public partial class TypeFuelEnergy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodeRecord;
		
		private System.Nullable<int> _CodeTypeFuel;
		
		private string _TypeFuel;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeRecordChanging(int value);
    partial void OnCodeRecordChanged();
    partial void OnCodeTypeFuelChanging(System.Nullable<int> value);
    partial void OnCodeTypeFuelChanged();
    partial void OnTypeFuelChanging(string value);
    partial void OnTypeFuelChanged();
    #endregion
		
		public TypeFuelEnergy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeRecord", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodeRecord
		{
			get
			{
				return this._CodeRecord;
			}
			set
			{
				if ((this._CodeRecord != value))
				{
					this.OnCodeRecordChanging(value);
					this.SendPropertyChanging();
					this._CodeRecord = value;
					this.SendPropertyChanged("CodeRecord");
					this.OnCodeRecordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeTypeFuel", DbType="Int")]
		public System.Nullable<int> CodeTypeFuel
		{
			get
			{
				return this._CodeTypeFuel;
			}
			set
			{
				if ((this._CodeTypeFuel != value))
				{
					this.OnCodeTypeFuelChanging(value);
					this.SendPropertyChanging();
					this._CodeTypeFuel = value;
					this.SendPropertyChanged("CodeTypeFuel");
					this.OnCodeTypeFuelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeFuel", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string TypeFuel
		{
			get
			{
				return this._TypeFuel;
			}
			set
			{
				if ((this._TypeFuel != value))
				{
					this.OnTypeFuelChanging(value);
					this.SendPropertyChanging();
					this._TypeFuel = value;
					this.SendPropertyChanged("TypeFuel");
					this.OnTypeFuelChanged();
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
