EXEC genSegmentosGuardar 'FLFO','FLFO', 'Flujo de Fondos',8,0,0,0,1,4,0,0,0,1,0,0,0,11,0,0,0,2,0,0,0,1,0,0,0,1,'1N',0,1,1,0
GO
declare @Segmento_Id Int 
SET @Segmento_Id = dbo.FuncFKgenSegmentos('FLFO')

Exec genSegmentosNombresGuardar  @Segmento_Id,'Flujo','','','',	'Sucursal','','','',1

GO

INSERT INTO genVersion(Version) Values(1004.00)
go