alter table wooorders drop column Subido 
go
alter table wooOrders add stkMoviCabe bigint, Cancelado bit
go
insert into genVersion (Version) values (1082.02)
go