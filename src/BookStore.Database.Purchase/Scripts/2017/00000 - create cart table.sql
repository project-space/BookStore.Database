create table Cart (
	Id int Identity(1,1) not null primary key,
	AccountId int not null,
	GuestId int not null
)
