alter table CartItem 
add foreign key(CartId) references Cart(Id);