create view RatingBook
as
select b.*, coalesce(sum(g.Score),0)
 as Rating from Book as b
left join Grade as g on b.Id = g.BookId group by b.Id, b.Title, b.Author, b.Price, b.Description, b.ReleaseDate, b.CoverUrl