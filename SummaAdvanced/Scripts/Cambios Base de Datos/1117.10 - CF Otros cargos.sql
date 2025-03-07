Alter table venSubTipoMov Add CFOtCargos_Id integer NULL
Go
ALTER TABLE venSubTipoMov
	ADD CONSTRAINT V30R_4803 FOREIGN KEY (CFOtCargos_Id) REFERENCES stkCondFisVenta(stkCondFisVenta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert Into genVersion (Version) Values (1117.10)
Go
