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

namespace CodeBustersWMU1.Models
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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertOrderDetail(OrderDetail instance);
    partial void UpdateOrderDetail(OrderDetail instance);
    partial void DeleteOrderDetail(OrderDetail instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Statistic> Statistics
		{
			get
			{
				return this.GetTable<Statistic>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<OrderDetail> OrderDetails
		{
			get
			{
				return this.GetTable<OrderDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Remaining;
		
		private int _Price;
		
		private string _Image;
		
		private string _Description;
		
		private string _ArticleName;
		
		private int _ArticleId;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRemainingChanging(int value);
    partial void OnRemainingChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnArticleNameChanging(string value);
    partial void OnArticleNameChanged();
    partial void OnArticleIdChanging(int value);
    partial void OnArticleIdChanged();
    #endregion
		
		public Product()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			OnCreated();
		}
        [DisplayName("Lagerstatus")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remaining", DbType="Int NOT NULL")]
		public int Remaining
		{
			get
			{
				return this._Remaining;
			}
			set
			{
				if ((this._Remaining != value))
				{
					this.OnRemainingChanging(value);
					this.SendPropertyChanging();
					this._Remaining = value;
					this.SendPropertyChanged("Remaining");
					this.OnRemainingChanged();
				}
			}
		}
        [DisplayName("Pris")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
        [DisplayName("Bild")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
        [DisplayName("Beskrivning")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(400) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
        [DisplayName("Namn")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ArticleName
		{
			get
			{
				return this._ArticleName;
			}
			set
			{
				if ((this._ArticleName != value))
				{
					this.OnArticleNameChanging(value);
					this.SendPropertyChanging();
					this._ArticleName = value;
					this.SendPropertyChanged("ArticleName");
					this.OnArticleNameChanged();
				}
			}
		}
        [DisplayName("Artikel Id")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ArticleId
		{
			get
			{
				return this._ArticleId;
			}
			set
			{
				if ((this._ArticleId != value))
				{
					this.OnArticleIdChanging(value);
					this.SendPropertyChanging();
					this._ArticleId = value;
					this.SendPropertyChanged("ArticleId");
					this.OnArticleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_OrderDetails", ThisKey="ArticleId", OtherKey="ArtikcleID")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Statistic")]
	public partial class Statistic
	{
		
		private int _ArticleID;
		
		private int _Sold = default(int);
		
		public Statistic()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleID", DbType="Int NOT NULL")]
		public int ArticleID
		{
			get
			{
				return this._ArticleID;
			}
			set
			{
				if ((this._ArticleID != value))
				{
					this._ArticleID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sold", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int Sold
		{
			get
			{
				return this._Sold;
			}
		}
	}
    [Bind(Exclude = "OrderId")]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private string _FirstName;
		
		private string _SurName;
		
		private System.Nullable<long> _SocialSecurityNumber;
		
		private string _Adress;
		
		private System.Nullable<int> _PostalCode;
		
		private string _City;
		
		private string _Email;
		
		private System.Nullable<int> _Phone;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnSurNameChanging(string value);
    partial void OnSurNameChanged();
    partial void OnSocialSecurityNumberChanging(System.Nullable<long> value);
    partial void OnSocialSecurityNumberChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnPostalCodeChanging(System.Nullable<int> value);
    partial void OnPostalCodeChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(System.Nullable<int> value);
    partial void OnPhoneChanged();
        #endregion
     
        public Order()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			OnCreated();
		}

        [ScaffoldColumn(false)]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
        [Required(ErrorMessage = "Förnamn krävs")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Endast Bokstäver!")]
        [DisplayName("Förnamn")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(20)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
        [Required(ErrorMessage = "Efternamn Krävs")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Endast Bokstäver!")]
        [DisplayName("Efternamn")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurName", DbType="VarChar(50)")]
		public string SurName
		{
			get
			{
				return this._SurName;
			}
			set
			{
				if ((this._SurName != value))
				{
					this.OnSurNameChanging(value);
					this.SendPropertyChanging();
					this._SurName = value;
					this.SendPropertyChanged("SurName");
					this.OnSurNameChanged();
				}
			}
		}
        [Required(ErrorMessage = "Personnummer Krävs")]
        [DisplayName("Personnummer (ÅÅMMDDXXXX)")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Endast Siffror!")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SocialSecurityNumber", DbType="BigInt")]
		public System.Nullable<long> SocialSecurityNumber
		{
			get
			{
				return this._SocialSecurityNumber;
			}
			set
			{
				if ((this._SocialSecurityNumber != value))
				{
					this.OnSocialSecurityNumberChanging(value);
					this.SendPropertyChanging();
					this._SocialSecurityNumber = value;
					this.SendPropertyChanged("SocialSecurityNumber");
					this.OnSocialSecurityNumberChanged();
				}
			}
		}
        [Required(ErrorMessage = "Adress Krävs")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(80)")]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
        [Required(ErrorMessage = "PostNr Krävs")]
        [DisplayName("PostNr")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Endast Siffror!")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="Int")]
		public System.Nullable<int> PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
      
        [Required(ErrorMessage = "Stad Krävs")]
        [DisplayName("Stad")]
        [RegularExpression(@"^[a-öA-Ö]+$", ErrorMessage = "Endast Bokstäver!")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
        [Required(ErrorMessage = "Email  Krävs")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email är ej korrekt!")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(80)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
        [DisplayName("TelefonNr (EX: 0707123456)")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Endast Siffror!")]
        [Required(ErrorMessage = "TelefonNr krävs")]
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int")]
		public System.Nullable<int> Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderDetail", Storage="_OrderDetails", ThisKey="OrderId", OtherKey="OrderID")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderDetails")]
	public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderDetailsId;
		
		private System.Nullable<int> _OrderID;
		
		private System.Nullable<int> _ArtikcleID;
		
		private System.Nullable<int> _Amount;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderDetailsIdChanging(int value);
    partial void OnOrderDetailsIdChanged();
    partial void OnOrderIDChanging(System.Nullable<int> value);
    partial void OnOrderIDChanged();
    partial void OnArtikcleIDChanging(System.Nullable<int> value);
    partial void OnArtikcleIDChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    #endregion
		
		public OrderDetail()
		{
			this._Product = default(EntityRef<Product>);
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDetailsId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderDetailsId
		{
			get
			{
				return this._OrderDetailsId;
			}
			set
			{
				if ((this._OrderDetailsId != value))
				{
					this.OnOrderDetailsIdChanging(value);
					this.SendPropertyChanging();
					this._OrderDetailsId = value;
					this.SendPropertyChanged("OrderDetailsId");
					this.OnOrderDetailsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="Int")]
		public System.Nullable<int> OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArtikcleID", DbType="Int")]
		public System.Nullable<int> ArtikcleID
		{
			get
			{
				return this._ArtikcleID;
			}
			set
			{
				if ((this._ArtikcleID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnArtikcleIDChanging(value);
					this.SendPropertyChanging();
					this._ArtikcleID = value;
					this.SendPropertyChanged("ArtikcleID");
					this.OnArtikcleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_Product", ThisKey="ArtikcleID", OtherKey="ArticleId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._ArtikcleID = value.ArticleId;
					}
					else
					{
						this._ArtikcleID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderDetail", Storage="_Order", ThisKey="OrderID", OtherKey="OrderId", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._OrderID = value.OrderId;
					}
					else
					{
						this._OrderID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Order");
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
