create table Purchase(
	Id int not null identity(1,1) primary key,
	AccountId int,
	GuestId int,
	PurchaseDetailsId int not null
)