DROP PROCEDURE genTamanioHojaGuardar
GO
CREATE PROCEDURE genTamanioHojaGuardar
(
@pTamanioHoja varchar(2),
@pDescripcion varchar(50),
@pAltoIn QCantidad,
@pAnchoIn QCantidad,
@pAltocm QCantidad,
@pAnchicm QCantidad,
@pAltoPx int,
@pAnchoPx int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTamanioHoja WHERE (TamanioHoja = @pTamanioHoja)))
BEGIN 
	UPDATE genTamanioHoja
	SET		Descripcion = @pDescripcion,
		AltoIn = @pAltoIn,
		AnchoIn = @pAnchoIn,
		Altocm = @pAltocm,
		Anchicm = @pAnchicm,
		AltoPx = @pAltoPx,
		AnchoPx = @pAnchoPx
	WHERE (TamanioHoja = @pTamanioHoja)
END 
ELSE 
BEGIN 
	INSERT INTO genTamanioHoja
	(
		TamanioHoja,
		Descripcion,
		AltoIn,
		AnchoIn,
		Altocm,
		Anchicm,
		AltoPx,
		AnchoPx
	)
	VALUES 
	(
		@pTamanioHoja,
		@pDescripcion,
		@pAltoIn,
		@pAnchoIn,
		@pAltocm,
		@pAnchicm,
		@pAltoPx,
		@pAnchoPx
	)
END 

GO

DROP PROCEDURE genTamanioHojaDatos
GO
CREATE PROCEDURE genTamanioHojaDatos
(
@pTamanioHoja varchar(2)
)
AS
SET NOCOUNT ON 

SELECT genTamanioHoja.TamanioHoja, genTamanioHoja.Descripcion, genTamanioHoja.AltoIn, genTamanioHoja.AnchoIn,
	genTamanioHoja.Altocm, genTamanioHoja.Anchicm, genTamanioHoja.AltoPx, genTamanioHoja.AnchoPx
FROM genTamanioHoja 
WHERE (TamanioHoja = @pTamanioHoja)
 
 RETURN @@Error 

GO

DROP PROCEDURE genTamanioHojaEliminar
GO
CREATE PROCEDURE genTamanioHojaEliminar
(
@pTamanioHoja varchar(2) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genTamanioHoja 
WHERE (TamanioHoja = ISNULL(@pTamanioHoja, TamanioHoja))
 
 RETURN @@Error 

GO

GO
