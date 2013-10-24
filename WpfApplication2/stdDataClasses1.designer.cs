﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="stuDB")]
	public partial class stdDataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public stdDataClasses1DataContext() : 
				base(global::WpfApplication2.Properties.Settings.Default.stuDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public stdDataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public stdDataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public stdDataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public stdDataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _deptId;
		
		private string _deptName;
		
		private EntitySet<Student> _Students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndeptIdChanging(int value);
    partial void OndeptIdChanged();
    partial void OndeptNameChanging(string value);
    partial void OndeptNameChanged();
    #endregion
		
		public Department()
		{
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int deptId
		{
			get
			{
				return this._deptId;
			}
			set
			{
				if ((this._deptId != value))
				{
					this.OndeptIdChanging(value);
					this.SendPropertyChanging();
					this._deptId = value;
					this.SendPropertyChanged("deptId");
					this.OndeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptName", DbType="VarChar(10)")]
		public string deptName
		{
			get
			{
				return this._deptName;
			}
			set
			{
				if ((this._deptName != value))
				{
					this.OndeptNameChanging(value);
					this.SendPropertyChanging();
					this._deptName = value;
					this.SendPropertyChanged("deptName");
					this.OndeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Student", Storage="_Students", ThisKey="deptId", OtherKey="deptID")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
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
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _stuId;
		
		private string _stuName;
		
		private System.Nullable<int> _age;
		
		private string _image;
		
		private System.Nullable<int> _deptID;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstuIdChanging(int value);
    partial void OnstuIdChanged();
    partial void OnstuNameChanging(string value);
    partial void OnstuNameChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    partial void OnimageChanging(string value);
    partial void OnimageChanged();
    partial void OndeptIDChanging(System.Nullable<int> value);
    partial void OndeptIDChanged();
    #endregion
		
		public Student()
		{
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stuId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int stuId
		{
			get
			{
				return this._stuId;
			}
			set
			{
				if ((this._stuId != value))
				{
					this.OnstuIdChanging(value);
					this.SendPropertyChanging();
					this._stuId = value;
					this.SendPropertyChanged("stuId");
					this.OnstuIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stuName", DbType="VarChar(30)")]
		public string stuName
		{
			get
			{
				return this._stuName;
			}
			set
			{
				if ((this._stuName != value))
				{
					this.OnstuNameChanging(value);
					this.SendPropertyChanging();
					this._stuName = value;
					this.SendPropertyChanged("stuName");
					this.OnstuNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
		public System.Nullable<int> age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="VarChar(100)")]
		public string image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptID", DbType="Int")]
		public System.Nullable<int> deptID
		{
			get
			{
				return this._deptID;
			}
			set
			{
				if ((this._deptID != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndeptIDChanging(value);
					this.SendPropertyChanging();
					this._deptID = value;
					this.SendPropertyChanged("deptID");
					this.OndeptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Student", Storage="_Department", ThisKey="deptID", OtherKey="deptId", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._deptID = value.deptId;
					}
					else
					{
						this._deptID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Department");
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
