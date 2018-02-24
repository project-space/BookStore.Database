ALTER TABLE Book ALTER COLUMN Title nvarchar(32) not null
ALTER TABLE Book ALTER COLUMN Author nvarchar(32) not null
ALTER TABLE Book ALTER COLUMN Description nvarchar(max) not null
alter table Book alter column Price decimal(7,2) not null