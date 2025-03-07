DROP PROCEDURE AfiMovimientosGuardar
GO
CREATE PROCEDURE AfiMovimientosGuardar
(
@pAfiActivoFijo int,
@pRenglon int,
@pconAsientos bigint,
@pTipoMov varchar(2)
)
AS
	INSERT INTO AfiMovimientos
	(
		AfiActivoFijo,
		Renglon,
		conAsientos,
		TipoMov
	)
	VALUES 
	(
		@pAfiActivoFijo,
		@pRenglon,
		@pconAsientos,
		@pTipoMov
	)

GO

DROP PROCEDURE AfiMovimientosDatos
GO
CREATE PROCEDURE AfiMovimientosDatos
(
@pAfiActivoFijo int=NULL,
@pRenglon int=NULL,
@pconAsientos bigint=NULL
)
AS
SET NOCOUNT ON 

SELECT afiActivoFijo.ActivoFijo_Id, afiActivoFijo.Descripcion as DescripcionActivoFijo, 
	AfiMovimientos.Renglon, AfiMovimientos.conAsientos, AfiMovimientos.TipoMov
FROM AfiMovimientos 
INNER JOIN afiActivoFijo  ON (afiActivoFijo.AfiActivoFijo = AfiMovimientos.AfiActivoFijo)
WHERE AfiMovimientos.AfiActivoFijo = ISNULL(@pAfiActivoFijo,AfiMovimientos.AfiActivoFijo)
AND AfiMovimientos.Renglon = ISNULL(@pRenglon,AfiMovimientos.Renglon)
AND conAsientos =  iSNull(@pconAsientos,conAsientos)
 
RETURN @@Error 

GO

DROP PROCEDURE AfiMovimientosEliminar
GO
CREATE PROCEDURE AfiMovimientosEliminar
(
@pAfiActivoFijo int=NULL,
@pRenglon int=NULL,
@pconAsientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM AfiMovimientos 
WHERE (AfiActivoFijo = @pAfiActivoFijo)
AND (Renglon = ISNULL(Renglon,@pRenglon))
AND (conAsientos =ISNULL(@pconAsientos,conAsientos))
 
 RETURN @@Error 

GO

GO
