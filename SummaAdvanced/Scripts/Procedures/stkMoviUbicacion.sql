DROP PROCEDURE stkMoviUbicacionInsertar
GO
CREATE PROCEDURE stkMoviUbicacionInsertar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pUbicacion_Id varchar(25),
@pCantidad qCantidadD8,
@pCantidadAlterna qCantidadD8
)
AS
	INSERT INTO stkMoviUbicacion
	(
		stkMoviCabe,
		Renglon,
		Ubicacion_Id,
		Cantidad,
		CantidadAlterna
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pCantidad,
		@pCantidadAlterna
	)


GO

DROP PROCEDURE stkMoviUbicacionDatos
GO
CREATE PROCEDURE stkMoviUbicacionDatos
(
@pstkMoviCabe bigint,
@pRenglon int = NULL,
@pUbicacion_Id VarChar(25) = NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, stkProductos.Producto_Id, 
	stkDepositos.Deposito_Id,  stkUbicaciones.Ubicacion_Id, Cast(0 As Numeric(19,8)) Cantidad, Cast(0 As Numeric(19,8)) CantidadAlterna,
	stkMoviUbicacion.Cantidad / stkMoviCuerpo.Factor as Existencia, stkMoviUbicacion.CantidadAlterna ExistenciaAlterna
FROM stkMoviUbicacion
INNER JOIN stkMoviCuerpo  ON (stkMoviCuerpo.stkMoviCabe = stkMoviUbicacion.stkMoviCabe) AND (stkMoviCuerpo.Renglon = stkMoviUbicacion.Renglon)
INNER JOIN stkUbicaciones  ON (stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id)
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
WHERE stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe
AND stkMoviCuerpo.Renglon = ISNULL(@pRenglon,stkMoviCuerpo.Renglon)
AND stkUbicaciones.Ubicacion_Id = ISNULL(@pUbicacion_Id,stkUbicaciones.Ubicacion_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviUbicacionEliminar
GO
CREATE PROCEDURE stkMoviUbicacionEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = null,
@pUbicacion_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviUbicacion 
WHERE 
	(stkMoviCabe = @pstkMoviCabe)
AND (Renglon = ISNULL(@pRenglon,stkMoviUbicacion.Renglon))
AND (Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id))
 
RETURN @@Error 

GO
