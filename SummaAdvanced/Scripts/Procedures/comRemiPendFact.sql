DROP PROCEDURE comRemiPendFactGuardar
GO
CREATE PROCEDURE comRemiPendFactGuardar
(
@pcomMovProv bigint,
@pRenglonCuerpo int,
@pstkMoviCabe bigint = NULL,
@pRenglon int = NULL,
@pCantidadFacturado qCantidadD8,
@pPrecioFacturado numeric(18,8),
@pCantidadOriginalFact numeric(18,8)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comRemiPendFact WHERE (comMovProv = @pcomMovProv) AND (RenglonCuerpo = @pRenglonCuerpo)))
BEGIN 
	UPDATE comRemiPendFact
	SET		stkMoviCabe = @pstkMoviCabe,
		Renglon = @pRenglon,
		CantidadFacturado = @pCantidadFacturado,
		PrecioFacturado = @pPrecioFacturado,
		CantidadOriginalFact = @pCantidadOriginalFact
	WHERE (comMovProv = @pcomMovProv) AND (RenglonCuerpo = @pRenglonCuerpo)
END 
ELSE 
BEGIN 
	INSERT INTO comRemiPendFact
	(
		comMovProv,
		RenglonCuerpo,
		stkMoviCabe,
		Renglon,
		CantidadFacturado,
		PrecioFacturado,
		CantidadOriginalFact
	)
	VALUES 
	(
		@pcomMovProv,
		@pRenglonCuerpo,
		@pstkMoviCabe,
		@pRenglon,
		@pCantidadFacturado,
		@pPrecioFacturado,
		@pCantidadOriginalFact
	)
END 

GO

DROP PROCEDURE comRemiPendFactDatos
GO
CREATE PROCEDURE comRemiPendFactDatos
(
@pcomMovProv bigint,
@pRenglonCuerpo int
)
AS
SET NOCOUNT ON 

SELECT comRemiPendFact.comMovProv, comRemiPendFact.RenglonCuerpo, comRemiPendFact.stkMoviCabe,
	comRemiPendFact.Renglon, comRemiPendFact.CantidadFacturado, comRemiPendFact.PrecioFacturado,
	comRemiPendFact.CantidadOriginalFact
FROM comRemiPendFact 
WHERE (comMovProv = @pcomMovProv)
AND (RenglonCuerpo = @pRenglonCuerpo)
 
 RETURN @@Error 

GO

DROP PROCEDURE comRemiPendFactEliminar
GO
CREATE PROCEDURE comRemiPendFactEliminar
(
@pcomMovProv bigint,
@pRenglonCuerpo int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comRemiPendFact 
WHERE (comMovProv = @pcomMovProv)
AND (RenglonCuerpo = ISNULL(@pRenglonCuerpo, RenglonCuerpo))
 
 RETURN @@Error 

GO

