create table Genre(
	Id int not null identity(1,1) primary key,
	Name nvarchar(50) not null,
	Description nvarchar(max) not null,
	Illustration nvarchar(max) 
)