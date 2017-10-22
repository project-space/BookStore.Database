create table Rating (
	Id int not null identity(1,1) primary key,
	AccountId int not null,
	BookId int not null,
	Score int not null
)