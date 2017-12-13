create table PurchaseDetails(
	Id int not null identity(1,1) primary key,
	PurchaseId int not null,
	AdressId int not null,
	FullName nvarchar(60) not null
)