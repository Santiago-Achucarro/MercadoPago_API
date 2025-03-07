exec genSegmentosGuardar  'IMPLQ', 'IMPLQ', 'Liquidacion Impuestos' , 8,0,0,0, 1, 4,0,0,0,1,0,0,0,11,0,0,0,
	2,0,0,0,1,0,0,0,1, '1N',0,1,1
GO
DECLARE @pSegmento_Id VarChar(25)
SET @pSegmento_Id = DBO.FuncFkgenSegmentos('IMPLQ')
exec genSegmentosNombresGuardar   @pSegmento_Id,  'Comprobante',' ',' ',' ', 'Sucrusal',' ',' ',' ', 1

GO

insert into genVersion (Version) Values(529.000)
GO