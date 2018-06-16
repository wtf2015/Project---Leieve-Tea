create table Customer (

	CustomerID      int      not null
	Constraint PK_Customer primary key clustered,
	FirstName       varchar(50)  not null,
	LastName        varchar (50)  not null,
	Address       Varchar(100)    not null,
    City          Varchar(50)     not null,
    Province      char(2)         not null
	 Constraint CK_ValidProvince Check (Province like'[A-Z][A-Z]'),
	Email         varchar         not null
	 Constraint	CK_validCustomerEmail check (email like '%@%.%'),
	PostalCode    char(7)         not null
	 Constraint CK_PostalCode Check (PostalCode Like '[A-Z][0-9][A-Z] [0-9][A-Z][0-9]'),
	Phone          Varchar(14)    not null
	   Constraint CK_CustomervalidPhone Check (Phone Like '([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	Points         int           not null,

)

create table Employee (

	EmployeeID          int       not null
	Constraint PK_Employee primary key clustered,
	FirstName       varchar(50)  not null,
	LastName        varchar (50)  not null,
	DateHired        datetime      not null,
	DateReleased     datetime          not null,
	Phone          Varchar(14)    not null
	Constraint CK_EmployeevalidPhone Check (Phone Like '([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
)

create table  Schedule (

	ScheduleID        Int            not null
	Constraint PK_Schedule primary key clustered,
	EmployeeID        int            not null
	Constraint FK_ScheduleToEmployee references Employee (EmployeeID),
	StartTime        datetime        not null,
	EndTime          dateTime        not null,
)

create table Coupon (
	
	CouponID      int     not null
	Constraint PK_Coupon primary key clustered,
	CouponName     varchar(50)   not null,
	Discount       int         not null,
	Active         bit         not null,
)

create table ReceiveOrder (
	
	OrderID           int     not null
	Constraint PK_ReceiveOrder primary key clustered,
	CustomerID        int       not null
	Constraint FK_ReceiveorderToCustomer references Customer (CustomerID),
	EmployeeID        int       not null
	Constraint FK_ReceiveorderToEmployee references Employee (EmployeeID),
	CouponID          int       not null
	Constraint FK_ReceiveorderToCoupon references Coupon (CouponID),
	FirstName       varchar(50)  not null,
	OrderDate         datetime  not null,
	Address       Varchar(100)    not null,
    City          Varchar(50)     not null,
    Province      char(2)         not null
	 Constraint CK_ValidProvince Check (Province like'[A-Z][A-Z]'),
	Email         varchar         not null
	Constraint	CK_validReceiveOrderEmail check (email like '%@%.%'),
	PostalCode    char(7)         not null
	 Constraint CK_PostalCode Check (PostalCode Like '[A-Z][0-9][A-Z] [0-9][A-Z][0-9]'),
	Phone          Varchar(14)    not null
	Constraint CK_ReceiveOrdervalidPhone Check (Phone Like '([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	DeliveryType   varchar(20)    not null,
	GST            money          not null,
	DeliveryFee     money             not null,
	PaymentType        money          not null,         
)


Create table ShoppingCart (

		ShoppingCartID     int             not null
		Constraint PK_ShoppingCart primary key clustered,
		EmployeeID         int             not null
		Constraint FK_ShoppingCartToEmployee references Employee (EmployeeID),
		CustomerID         int             not null
		Constraint FK_ShoppingCartToCustomer references Customer (CustomerID),
		CreatedOn          datetime        not null,
		UpdatedOn          datetime        not null,
)
create table Category (

	CategoryID            int    not null
	Constraint PK_Category primary key clustered,
	Description           varchar(50)   not null,
)

create table   MenuItems (
	
	MenuItemID     int    not null
	Constraint PK_MenuItems primary key clustered,
	Description    varchar(50)    not null,
	SellingPrice   money          not null,
	CategoryID     int            not null
	Constraint FK_MenuItemsToCategory references Category (CategoryID),
	Active         bit            not null,
)

create table ShoppingCartItem (

	ShoppongCartItemID    int     not null
	Constraint PK_ShoppingCartItem primary key clustered,
	ShoppingCartID        int      not null
	Constraint FK_ShoppingCartItemToShoppingCart references ShoppingCart (ShoppingCartID),
	MenuItemID           int       not null
	Constraint FK_ShoppingCartItemToMenuItem references MenuItems (MenuItemID),
	Quantity              int       not null,
)

create table OrderDetails (

	OrderDetailID         int       not null
	Constraint PK_OrderDetails primary key clustered,
	OrderID               int       not null
	Constraint FK_OrderDetailsToReceiveOrder references ReceiveOrder (OrderID),
	MenuItemID           int        not null
	Constraint FK_OrderDetailsToMenuItem references MenuItems (MenuItemID),
	SellingPrice        money       not null,
	Qty                  int        not null,
)

create table  PaymentType (

	PaymentTypeID          int         not null
	Constraint PK_PaymentType primary key clustered,
	Description           varchar(50)      not null,
)


create table position (

	PositionID        Int          not null
	Constraint PK_position primary key clustered,
	Description       varchar(50)   not null,
	OpenOrNot               bit          not null,
)