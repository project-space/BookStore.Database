alter table Purchase 
add foreign key(PurchaseDetailsId) references PurchaseDetails(Id);