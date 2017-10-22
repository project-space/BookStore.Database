create table BasketItem (
	Id int not null identity(1,1) primary key,
	BasketId int not null,
	BookId int not null,
	Quantity int not null
)