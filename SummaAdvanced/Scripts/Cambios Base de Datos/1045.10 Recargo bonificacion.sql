Alter table venListasPrecBoniRec Add
	UsaCtasProducto      Sino Null,
	CtaBonificacion      integer  NULL ,
	CtaRecargo           integer  NULL
Go
Update venListasPrecBoniRec Set UsaCtasProducto = 1
Go
Alter table venListasPrecBoniRec alter column
	UsaCtasProducto      Sino Not Null
Go

ALTER TABLE venListasPrecBoniRec
	ADD CONSTRAINT V2R_4688 FOREIGN KEY (CtaBonificacion) REFERENCES conCuentas(conCuentas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE venListasPrecBoniRec
	ADD CONSTRAINT V2R_4689 FOREIGN KEY (CtaRecargo) REFERENCES conCuentas(conCuentas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert into genVersion (Version) Values (1045.10)

