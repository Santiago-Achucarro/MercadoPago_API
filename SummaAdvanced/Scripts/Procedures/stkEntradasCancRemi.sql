DROP PROCEDURE stkEntradasCancRemiGuardar
GO
CREATE PROCEDURE stkEntradasCancRemiGuardar
(
@pstkMoviCabeEntrada bigint,
@pRenglonEntrada int,
@pstkMoviCabeRemi bigint,
@pRenglonRemi int,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
	INSERT INTO stkEntradasCancRemi
	(
		stkMoviCabeEntrada,
		RenglonEntrada,
		stkMoviCabeRemi,
		RenglonRemi,
		Cantidad
	)
	VALUES 
	(
		@pstkMoviCabeEntrada,
		@pRenglonEntrada,
		@pstkMoviCabeRemi,
		@pRenglonRemi,
		@pCantidad
	)

GO

DROP PROCEDURE stkEntradasCancRemiDatos
GO
CREATE PROCEDURE stkEntradasCancRemiDatos
(
@pstkMoviCabeEntrada bigint,
@pRenglonEntrada int = null
)
AS
SET NOCOUNT ON 

SELECT stkEntradasCancRemi.stkMoviCabeEntrada, stkEntradasCancRemi.RenglonEntrada, 
stkEntradasCancRemi.stkMoviCabeRemi, stkEntradasCancRemi.RenglonRemi,  stkEntradasCancRemi.Cantidad
FROM stkEntradasCancRemi 
WHERE (stkMoviCabeEntrada = @pstkMoviCabeEntrada)
AND (RenglonEntrada = ISNULL(@pRenglonEntrada,RenglonEntrada))
 
 RETURN @@Error 

GO

DROP PROCEDURE stkEntradasCancRemiEliminar
GO
CREATE PROCEDURE stkEntradasCancRemiEliminar
(
@pstkMoviCabeEntrada bigint,
@pRenglonEntrada int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkEntradasCancRemi 
WHERE (stkMoviCabeEntrada = @pstkMoviCabeEntrada)
AND (RenglonEntrada = ISNULL(@pRenglonEntrada,RenglonEntrada))
 
RETURN @@Error 

GO
