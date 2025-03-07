CREATE TABLE genMenusOrden
( 
	Opcion               char(1)  NOT NULL ,
	Orden                varchar(10)  NOT NULL ,
	CONSTRAINT XPKgenMenusOrden PRIMARY KEY  CLUSTERED (Opcion ASC)
)
go

Insert into genMenusOrden (Opcion, Orden) Values ('5', '01')
Insert into genMenusOrden (Opcion, Orden) Values ('1', '02')
Insert into genMenusOrden (Opcion, Orden) Values ('2', '03')
Insert into genMenusOrden (Opcion, Orden) Values ('3', '04')
Insert into genMenusOrden (Opcion, Orden) Values ('6', '05')
Insert into genMenusOrden (Opcion, Orden) Values ('9', '06')
Insert into genMenusOrden (Opcion, Orden) Values ('S', '07')
Insert into genMenusOrden (Opcion, Orden) Values ('8', '08')
Insert into genMenusOrden (Opcion, Orden) Values ('4', '09')
Insert into genMenusOrden (Opcion, Orden) Values ('7', '10')
Go

Insert into genVersion (Version) Values (560.10)
Go
