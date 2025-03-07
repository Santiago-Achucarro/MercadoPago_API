DROP PROCEDURE stkMoviDespaGuardar
GO
CREATE PROCEDURE stkMoviDespaGuardar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pDespacho_Id varChar(20),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviDespa 
	WHERE stkMoviCabe = @pstkMoviCabe AND Renglon = @pRenglon AND Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id)))
BEGIN 
	UPDATE stkMoviDespa
	SET		Cantidad = @pCantidad
	WHERE stkMoviCabe = @pstkMoviCabe AND Renglon = @pRenglon AND Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviDespa
	(
		stkMoviCabe,
		Renglon,
		Despacho_Id,
		Cantidad
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		dbo.FuncFKcomDespachos(@pDespacho_Id),
		@pCantidad
	)
END 

GO

DROP PROCEDURE stkMoviDespaDatos
GO
CREATE PROCEDURE stkMoviDespaDatos
(
@pstkMoviCabe bigint,
@pRenglon int = null,
@pDespacho_Id varChar(20) = null
)
AS
SET NOCOUNT ON 

SELECT stkMoviDespa.stkMoviCabe, stkMoviDespa.Renglon, comDespachos.Despacho_Id, stkMoviDespa.Cantidad
FROM stkMoviDespa 
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviDespa.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviDespa.Renglon
INNER JOIN comDespachos ON comDespachos.comDespachos = stkMoviDespa.Despacho_Id
WHERE stkMoviDespa.stkMoviCabe = @pstkMoviCabe
AND stkMoviDespa.Renglon = IsNull(@pRenglon, stkMoviDespa.Renglon)
AND stkMoviDespa.Despacho_Id = IsNull(dbo.FuncFKcomDespachos(@pDespacho_Id), stkMoviDespa.Despacho_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviDespaEliminar
GO
CREATE PROCEDURE stkMoviDespaEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = null,
@pDespacho_Id varchar(20) = null
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviDespa 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND Renglon = IsNull(@pRenglon, Renglon)
AND Despacho_Id = IsNull(dbo.FuncFKcomDespachos(@pDespacho_Id), Despacho_Id)
 
 RETURN @@Error 

GO

