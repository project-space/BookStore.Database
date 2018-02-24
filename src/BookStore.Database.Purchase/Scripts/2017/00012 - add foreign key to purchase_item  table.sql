alter table PurchaseItem 
add foreign key(PurchaseId) references Purchase(Id);