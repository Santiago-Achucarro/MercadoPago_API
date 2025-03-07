exec genSegmentosGuardar  'PROG', 'PROG', 'Programa de Produccion' , 8,0,0,0, 1, 4,0,0,0,1,0,0,0,11,0,0,0,
	2,0,0,0,1,0,0,0,1, '1N',0,1,1
	go
	DECLARE @pSegmento_Id VarChar(25)
	
SET @pSegmento_Id = DBO.FuncFkgenSegmentos('PROG')
exec genSegmentosNombresGuardar   @pSegmento_Id,  'Comprobante',' ',' ',' ', 'Sucrusal',' ',' ',' ', 1
go

exec genSegmentosGuardar  'PORD', 'PORD', 'Ordenes de Produccion' , 8,0,0,0, 1, 4,0,0,0,1,0,0,0,11,0,0,0,
	2,0,0,0,1,0,0,0,1, '1N',0,1,1
	go
	DECLARE @pSegmento_Id VarChar(25)
	
SET @pSegmento_Id = DBO.FuncFkgenSegmentos('PORD')
exec genSegmentosNombresGuardar   @pSegmento_Id,  'Comprobante',' ',' ',' ', 'Sucrusal',' ',' ',' ', 1
go




insert into genVersion (Version) values (519.02)