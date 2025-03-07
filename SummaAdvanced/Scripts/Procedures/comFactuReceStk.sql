DROP PROCEDURE comFactuReceStkGuardar
GO
CREATE PROCEDURE comFactuReceStkGuardar
(
@pcomMovProv bigint,
@pcomOrdenComp int,
@pRenglon_OC int,
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidad qCantidadD8
)
AS

	INSERT INTO comFactuReceStk
	(
		comMovProv,
		comOrdenComp,
		Renglon_OC,
		stkMoviCabe,
		Renglon,
		Cantidad
	)
	VALUES 
	(
		@pcomMovProv,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pstkMoviCabe,
		@pRenglon,
		@pCantidad
	)

GO

DROP PROCEDURE comFactuReceStkDatos
GO
CREATE PROCEDURE comFactuReceStkDatos
(
@pcomMovProv bigint
)
AS
SET NOCOUNT ON 

Select Cast(0 As bigint) comMovProv, 0 comOrdenComp, 0 Renglon_OC

SELECT 0 Renglon_OC, stkMoviOC.stkMoviCabe, stkMoviOC.Renglon, comFactuReceStk.Cantidad, conAsientos.Cambio
FROM comFactuReceStk 
INNER JOIN comMovPOC  ON comMovPOC.comMovProv = comFactuReceStk.comMovProv AND comMovPOC.comOrdenComp = comFactuReceStk.comOrdenComp AND 
comMovPOC.Renglon_OC = comFactuReceStk.Renglon_OC
INNER JOIN stkMoviOC  ON stkMoviOC.stkMoviCabe = comFactuReceStk.stkMoviCabe AND stkMoviOC.Renglon = comFactuReceStk.Renglon
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe And stkMoviCuerpo.Renglon = stkMoviOC.Renglon
Inner Join conAsientos On conAsientos.conAsientos = stkMoviOC.stkMoviCabe
WHERE comFactuReceStk.comMovProv = @pcomMovProv

 
 RETURN @@Error 

GO

DROP PROCEDURE comFactuReceStkEliminar
GO
CREATE PROCEDURE comFactuReceStkEliminar
(
@pcomMovProv bigint,
@pcomOrdenComp int = Null,
@pRenglon_OC int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comFactuReceStk 
WHERE comMovProv = @pcomMovProv
AND comFactuReceStk.comOrdenComp = IsNull(@pcomOrdenComp, comFactuReceStk.comOrdenComp)
AND comFactuReceStk.Renglon_OC = IsNull(@pRenglon_OC, comFactuReceStk.Renglon_OC)
 
RETURN @@Error 

GO


Drop PROCEDURE comFactuReceStkCalcularPendiente
Go

CREATE PROCEDURE comFactuReceStkCalcularPendiente
(
@pcomOrdenComp int,
@pRenglon_OC int
)
AS
SET NOCOUNT ON

Select Cast(0 As bigint) comMovProv, @pcomOrdenComp comOrdenComp, @pRenglon_OC Renglon_OC

SELECT @pRenglon_OC Renglon_OC, stkMoviOC.stkMoviCabe, stkMoviOC.Renglon, stkMoviOc.CantFactPendiente Cantidad, conAsientos.Cambio
FROM stkMoviOC 
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe And stkMoviCuerpo.Renglon = stkMoviOC.Renglon
Inner Join conAsientos On conAsientos.conAsientos = stkMoviOC.stkMoviCabe
WHERE stkMoviOC.comOrdenComp = @pcomOrdenComp
AND stkMoviOC.Renglon_OC = @pRenglon_OC And
conAsientos.Anulado = 0
 
RETURN @@Error 

GO
