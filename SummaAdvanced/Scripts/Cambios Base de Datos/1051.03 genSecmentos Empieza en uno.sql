
alter table genSegmentos
add  EmpiezaEnUno bit not null default 0
go
INSERT INTO genVersion (Version) Values(1051.03)
GO
