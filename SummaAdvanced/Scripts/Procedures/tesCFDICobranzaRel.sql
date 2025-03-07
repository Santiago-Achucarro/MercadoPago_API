DROP PROCEDURE tesCFDICobranzaRelGuardar
GO
CREATE PROCEDURE tesCFDICobranzaRelGuardar
(
@ptesCFDICobranza int,
@ptesCFDICobranzaR int
)
AS
SET NOCOUNT ON 
	INSERT INTO tesCFDICobranzaRel
	(
		tesCFDICobranza,
		tesCFDICobranzaR
	)
	VALUES 
	(
		@ptesCFDICobranza,
		@ptesCFDICobranzaR
	)

GO

DROP PROCEDURE tesCFDICobranzaRelDatos
GO
CREATE PROCEDURE tesCFDICobranzaRelDatos
(
@ptesCFDICobranza int,
@ptesCFDICobranzaR int=NULL
)
AS
SET NOCOUNT ON 

SELECT  tesCFDICobranzaRel.tesCFDICobranza, tesCFDICobranzaRel.tesCFDICobranzaR
FROM tesCFDICobranzaRel 
WHERE tesCFDICobranza = @ptesCFDICobranza AND 
ISNULL(@ptesCFDICobranzaR,tesCFDICobranzaR) = @ptesCFDICobranzaR
 
RETURN @@Error 

GO

DROP PROCEDURE tesCFDICobranzaRelEliminar
GO
CREATE PROCEDURE tesCFDICobranzaRelEliminar
(
@ptesCFDICobranza int,
@ptesCFDICobranzaR int
)
AS
SET NOCOUNT ON 

DELETE FROM tesCFDICobranzaRel 
WHERE (tesCFDICobranza = @ptesCFDICobranza)
AND (tesCFDICobranzaR = @ptesCFDICobranzaR)
 
RETURN @@Error 

GO

