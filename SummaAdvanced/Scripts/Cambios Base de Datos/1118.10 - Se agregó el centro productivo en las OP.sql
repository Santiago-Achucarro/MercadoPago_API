Alter table proOrden Add CtroProd_Id integer NULL
Go
ALTER TABLE proOrden
	ADD CONSTRAINT V30R_4804 FOREIGN KEY (CtroProd_Id) REFERENCES proCentroProductivo(proCentroProductivo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Update proOrden Set CtroProd_Id = (Select CtroProd_Id From proRecetas Where proRecetas.proRecetas = proOrden.Receta_Id)

Insert Into genVersion (Version) Values (1118.10)
Go

