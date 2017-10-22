 create table Book (
	Id int not null identity(1,1) primary key,
	Title varchar(32) not null,
	Author varchar(32) not null,
	Price money not null,
	CoverUrl varchar(max),
	Description varchar(max) null 
 )