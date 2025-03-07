
DROP PROCEDURE stkMoviProvGuardar
GO
CREATE PROCEDURE stkMoviProvGuardar
(
@pstkMoviCabe bigint,
@pProveed_Id VarChar(15),
@pRemitoProv VarChar(50), 
@pFechaRemito DateTime
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviProv WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkMoviProv
	SET		Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id),
		RemitoProv = @pRemitoProv, FechaRemito = @pFechaRemito
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviProv
	(
		stkMoviCabe,
		Proveed_Id,
		RemitoProv, 
		FechaRemito
	)
	VALUES 
	(
		@pstkMoviCabe,
		dbo.FuncFKcomProveedores(@pProveed_Id),
		@pRemitoProv, 
		@pFechaRemito
	)
END 

GO

DROP PROCEDURE stkMoviProvDatos
GO
CREATE PROCEDURE stkMoviProvDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviProv.stkMoviCabe, comProveedores.Proveed_Id, 
	comProveedores.RazonSocial as DescripcionProveedores,
	stkMoviProv.RemitoProv, stkMoviProv.FechaRemito
FROM stkMoviProv 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkMoviProv.stkMoviCabe)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = stkMoviProv.Proveed_Id)
WHERE (stkMoviProv.stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviProvEliminar
GO
CREATE PROCEDURE stkMoviProvEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviProv 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO

drop procedure stkRemiProvDatos
go
create procedure stkRemiProvDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec stkMoviCabeDatos @pstkMoviCabe
exec stkMoviProvDatos @pstkMoviCabe
go

