create table PurchaseItem(
	Id int not null identity(1,1) primary key,
	PurchaseId int not null,
	BookId int not null
)