alter table Book
add foreign key(GenreId) references Genre(Id);