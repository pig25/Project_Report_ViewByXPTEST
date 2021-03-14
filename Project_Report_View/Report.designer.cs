﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Report_View
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class ReportDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 擴充性方法定義
    partial void OnCreated();
    #endregion
		
		public ReportDataContext() : 
				base(global::Project_Report_View.Properties.Settings.Default.DataSourceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ReportDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReportDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReportDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReportDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<projectline> projectline
		{
			get
			{
				return this.GetTable<projectline>();
			}
		}
		
		public System.Data.Linq.Table<projectlist> projectlist
		{
			get
			{
				return this.GetTable<projectlist>();
			}
		}
		
		public System.Data.Linq.Table<sheudle> sheudle
		{
			get
			{
				return this.GetTable<sheudle>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.projectline")]
	public partial class projectline
	{
		
		private string _group;
		
		private string _groupname;
		
		public projectline()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[group]", Storage="_group", DbType="Char(8)")]
		public string group
		{
			get
			{
				return this._group;
			}
			set
			{
				if ((this._group != value))
				{
					this._group = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupname", DbType="Char(8)")]
		public string groupname
		{
			get
			{
				return this._groupname;
			}
			set
			{
				if ((this._groupname != value))
				{
					this._groupname = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.projectlist")]
	public partial class projectlist
	{
		
		private string _project;
		
		private string _group;
		
		private string _projectname;
		
		private string _itemname;
		
		private string _itemid;
		
		private System.Nullable<int> _design;
		
		private System.Nullable<bool> _enable;
		
		private System.Nullable<int> _elc;
		
		public projectlist()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_project", DbType="Char(8)")]
		public string project
		{
			get
			{
				return this._project;
			}
			set
			{
				if ((this._project != value))
				{
					this._project = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[group]", Storage="_group", DbType="Char(8)")]
		public string group
		{
			get
			{
				return this._group;
			}
			set
			{
				if ((this._group != value))
				{
					this._group = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_projectname", DbType="Char(8)")]
		public string projectname
		{
			get
			{
				return this._projectname;
			}
			set
			{
				if ((this._projectname != value))
				{
					this._projectname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemname", DbType="VarChar(10)")]
		public string itemname
		{
			get
			{
				return this._itemname;
			}
			set
			{
				if ((this._itemname != value))
				{
					this._itemname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemid", DbType="VarChar(10)")]
		public string itemid
		{
			get
			{
				return this._itemid;
			}
			set
			{
				if ((this._itemid != value))
				{
					this._itemid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_design", DbType="Int")]
		public System.Nullable<int> design
		{
			get
			{
				return this._design;
			}
			set
			{
				if ((this._design != value))
				{
					this._design = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enable", DbType="Bit")]
		public System.Nullable<bool> enable
		{
			get
			{
				return this._enable;
			}
			set
			{
				if ((this._enable != value))
				{
					this._enable = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_elc", DbType="Int")]
		public System.Nullable<int> elc
		{
			get
			{
				return this._elc;
			}
			set
			{
				if ((this._elc != value))
				{
					this._elc = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sheudle")]
	public partial class sheudle
	{
		
		private string _project;
		
		private System.Nullable<int> _level;
		
		private System.Nullable<int> _no;
		
		private string _itemid;
		
		private string _itemname;
		
		private System.Nullable<int> _plea;
		
		private System.Nullable<int> _pur;
		
		private int _wo;
		
		private System.Nullable<int> _finwo;
		
		public sheudle()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_project", DbType="Char(8)")]
		public string project
		{
			get
			{
				return this._project;
			}
			set
			{
				if ((this._project != value))
				{
					this._project = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[level]", Storage="_level", DbType="Int")]
		public System.Nullable<int> level
		{
			get
			{
				return this._level;
			}
			set
			{
				if ((this._level != value))
				{
					this._level = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no", DbType="Int")]
		public System.Nullable<int> no
		{
			get
			{
				return this._no;
			}
			set
			{
				if ((this._no != value))
				{
					this._no = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemid", DbType="VarChar(10)")]
		public string itemid
		{
			get
			{
				return this._itemid;
			}
			set
			{
				if ((this._itemid != value))
				{
					this._itemid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemname", DbType="VarChar(10)")]
		public string itemname
		{
			get
			{
				return this._itemname;
			}
			set
			{
				if ((this._itemname != value))
				{
					this._itemname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_plea", DbType="Int")]
		public System.Nullable<int> plea
		{
			get
			{
				return this._plea;
			}
			set
			{
				if ((this._plea != value))
				{
					this._plea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pur", DbType="Int")]
		public System.Nullable<int> pur
		{
			get
			{
				return this._pur;
			}
			set
			{
				if ((this._pur != value))
				{
					this._pur = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wo", DbType="Int NOT NULL")]
		public int wo
		{
			get
			{
				return this._wo;
			}
			set
			{
				if ((this._wo != value))
				{
					this._wo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_finwo", DbType="Int")]
		public System.Nullable<int> finwo
		{
			get
			{
				return this._finwo;
			}
			set
			{
				if ((this._finwo != value))
				{
					this._finwo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
