Create table venListasVersion(
	ListaPrecio_Id INT NOT NULL, 
	Version Int NOT NULL, 
	VigenciaDesde DateTime NOT NULL, 
	VigenciaHasta DateTime NOT NULL,
	Usuario_Id Int NOT NULL, 
	Primary Key(ListaPrecio_Id, Version))
GO

ALTER TABLE venListasVersion ADD 
	FOREIGN KEY(ListaPrecio_Id) References venListasPrecios
GO
	
INSERT INTO venListasVersion(ListaPrecio_Id, Version, 
	VigenciaDesde, VigenciaHasta, Usuario_Id)
SELECT venListasPrecios.venListasPrecios, 1, 
	'20000101','29990101',1
from venListasPrecios
GO

Alter table venListasPrecProd Add Version Int 
GO

UPDATE venListasPrecProd SET Version = 1 
GO

DECLARE @SQL char(250)

SELECT @SQL = 'ALTER TABLE '+sp.name+' DROP Constraint '+sh.name from sysobjects sh , sysobjects sp  where sh.Type = 'K' and
sp.id = sh.parent_obj AND sp.name = 'venListasPrecProd'

EXEC(@SQL)

GO
 
Alter table venListasPrecProd Alter Column Version Int NOT NULL
GO


Alter table venListasPrecProd add Constraint pkvenListasPrecProd
	Primary Key(ListaPrecio_Id, Version, Producto_Id)
GO

Alter table venListasPrecProd ADD 
	Foreign Key(ListaPrecio_Id, Version) References venListasVersion
GO

insert into genVersion (Version) Values(1008.00)
GO