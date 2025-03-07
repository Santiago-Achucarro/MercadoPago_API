DROP PROCEDURE venCotizFactuCuerpoInsertar
GO
CREATE PROCEDURE venCotizFactuCuerpoInsertar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int,
@pvenCotizaciones int ,
@pRenglon_Co int ,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
	INSERT INTO venCotizFactuCuerpo
	(
		venMovimientos,
		RenglonCuerpo,
		venCotizaciones,
		Renglon_Co,
		Cantidad
	)
	VALUES 
	(
		@pvenMovimientos,
		@pRenglonCuerpo,
		@pvenCotizaciones,
		@pRenglon_Co,
		@pCantidad
	)

GO

DROP PROCEDURE venCotizFactuCuerpoDatos
GO
CREATE PROCEDURE venCotizFactuCuerpoDatos
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = Null
)
AS
SET NOCOUNT ON 

SELECT venCotizFactuCuerpo.venMovimientos, venCotizFactuCuerpo.RenglonCuerpo, venCotizFactuCuerpo.venCotizaciones,venCotizFactuCuerpo.Renglon_Co, 
	venCotizFactuCuerpo.Cantidad
FROM venCotizFactuCuerpo 
WHERE (venMovimientos = @pvenMovimientos)
AND (RenglonCuerpo = isnull(@pRenglonCuerpo, RenglonCuerpo))
 
RETURN @@Error 

GO

DROP PROCEDURE venCotizFactuCuerpoEliminar
GO
CREATE PROCEDURE venCotizFactuCuerpoEliminar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizFactuCuerpo 
WHERE (venMovimientos = @pvenMovimientos)
AND (RenglonCuerpo = @pRenglonCuerpo)
 
RETURN @@Error 

GO

GO
