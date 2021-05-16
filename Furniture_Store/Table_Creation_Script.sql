create table Item_Types
(
	ID int primary key identity,
	[Name] nvarchar(40) not null
)

create table Items
(
	ID int primary key identity,
	[Name] nvarchar(40),
	Item_Type int references Item_Types(ID),
	Cost decimal not null,
	Date_Of_Add datetime not null
)

create table User_Role
(
	ID int primary key identity,
	[Name] nvarchar(40)
)

create table Users
(
	ID int primary key identity,
	[Name] nvarchar(40),
	[Login] nvarchar(40),
	[Password] nvarchar(15),
	[Role] int references User_Role(ID),
	[Address] nvarchar(70) 
)

create table Orders
(
	ID int primary key identity,
	Cost decimal not null,
	[Customer] int references [Users](ID)
)

create table Order_Items
(
	Item_ID int references Items(ID),
	Order_ID int references Orders(ID)
)

