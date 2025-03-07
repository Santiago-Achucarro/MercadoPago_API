
Alter table stkProductos add CtaConsumo Int
GO

ALTER TABLE stkProductos
	ADD CONSTRAINT V2R_4423 FOREIGN KEY (CtaConsumo) REFERENCES conCuentas(conCuentas)
go

Alter table comTipoPermiRI add GeneraOC bit NULL
GO

UPDATE comTipoPermiRI set GeneraOC= 1
GO

Alter table comTipoPermiRI Alter Column GeneraOC bit not null
GO


INSERT INTO genVersion (Version) Values(536.000)
GO
