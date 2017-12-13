create table CartItem (
	Id int not null identity(1,1) primary key,
	CartId int not null,
	BookId int not null
)