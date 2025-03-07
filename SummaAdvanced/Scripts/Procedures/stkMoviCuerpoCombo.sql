DROP PROCEDURE stkMoviCuerpoComboGuardar
GO
CREATE PROCEDURE stkMoviCuerpoComboGuardar
(
@pstkMoviCabeComponente bigint,
@pRenglonComponente int,
@pstkMoviCabe bigint ,
@pRenglon int 
)
AS
	INSERT INTO stkMoviCuerpoCombo
	(
		stkMoviCabeComponente,
		RenglonComponente,
		stkMoviCabe,
		Renglon
	)
	VALUES 
	(
		@pstkMoviCabeComponente,
		@pRenglonComponente,
		@pstkMoviCabe,
		@pRenglon
	)

GO

DROP PROCEDURE stkMoviCuerpoComboDatos
GO
CREATE PROCEDURE stkMoviCuerpoComboDatos
(
@pstkMoviCabeComponente bigint,
@pRenglonComponente int = NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviCuerpoCombo.stkMoviCabeComponente, stkMoviCuerpoCombo.RenglonComponente, stkMoviCuerpoCombo.stkMoviCabe,
	stkMoviCuerpoCombo.Renglon
FROM stkMoviCuerpoCombo 
WHERE (stkMoviCabeComponente = @pstkMoviCabeComponente)
AND (RenglonComponente = isnull(@pRenglonComponente,RenglonComponente))
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviCuerpoOrigenDatos
GO
CREATE PROCEDURE stkMoviCuerpoOrigenDatos
(
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviCuerpoCombo.stkMoviCabeComponente, stkMoviCuerpoCombo.RenglonComponente, stkMoviCuerpoCombo.stkMoviCabe,
	stkMoviCuerpoCombo.Renglon
FROM stkMoviCuerpoCombo 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = isnull(@pRenglon,Renglon))
 
RETURN @@Error 

GO


DROP PROCEDURE stkMoviCuerpoComboEliminar
GO
CREATE PROCEDURE stkMoviCuerpoComboEliminar
(
@pstkMoviCabeComponente bigint,
@pRenglonComponente int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCuerpoCombo 
WHERE (stkMoviCabeComponente = @pstkMoviCabeComponente)
AND (RenglonComponente = isnull(@pRenglonComponente,RenglonComponente))
 
 RETURN @@Error 

GO

