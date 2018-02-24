alter table Adress alter column Apartment varchar(5)
alter table Adress drop column Country
alter table Adress drop column City
alter table Adress add Town nvarchar(25) not null