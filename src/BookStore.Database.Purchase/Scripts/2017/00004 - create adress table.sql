create table Adress(
	Id int not null identity(1,1) primary key,
	Postcode varchar(6) not null,
	Country nvarchar(25) not null,
	City nvarchar(25) not null,
	Street nvarchar(30) not null,
	House nvarchar(5) not null,
	Apartment varchar(5) not null,
	PhoneNumber varchar(15)
)