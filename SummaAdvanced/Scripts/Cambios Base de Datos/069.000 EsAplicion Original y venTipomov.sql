INSERT INTO genVersion (Version) Values('069.000')
GO

Alter table genCancMov add EsVentaContado Bit 
GO

Alter table genCancMov add EsAplicOriginal Bit 
GO

UPDATE genCancMov SET EsVentaContado = 0 
GO

UPDATE genCancMov SET EsAplicOriginal = 1 
GO


Alter table genCancMov Alter Column EsVentaContado Bit  NOT NULL
GO

Alter table genCancMov Alter Column EsAplicOriginal Bit  NOT NULL
GO

Alter table venMovimientos ADD venTipomov Char(1)
GO

UPDATE venMovimientos set venTipomov = 	venSubTipoMov.venTipoMov 
	FROM venSubTipoMov WHERE venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
GO

Alter table venMovimientos Alter Column venTipomov Char(1) NOT NULL
GO


Alter table venMovimientos  add Foreign Key (venTipomov) references venTipomov
GO


