EXEC genSegmentosGuardar 'SCD','SCD', 'Solicitud Cambio Almacen',8,0,0,0,1,4,0,0,0,1,0,0,0,11,0,0,0,2,0,0,0,1,0,0,0,1,'1N',0,1,1,0
GO
declare @Segmento_Id Int 
SET @Segmento_Id = dbo.FuncFKgenSegmentos('SCD')

Exec genSegmentosNombresGuardar  @Segmento_Id,'Solicitud','','','',	'Sucursal','','','',1

GO


INSERT INTO genVersion(Version) Values(1005.00)
go