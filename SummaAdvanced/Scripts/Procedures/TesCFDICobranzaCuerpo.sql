DROP PROCEDURE TesCFDICobranzaCuerpoGuardar
GO
CREATE PROCEDURE TesCFDICobranzaCuerpoGuardar
(
@pTesCFDICobranza int,
@ptesMovimientos bigint
)
AS
	INSERT INTO TesCFDICobranzaCuerpo
	(
		TesCFDICobranza,
		tesMovimientos
	)
	VALUES 
	(
		@pTesCFDICobranza,
		@ptesMovimientos
	)

GO

DROP PROCEDURE TesCFDICobranzaCuerpoDatos
GO
CREATE PROCEDURE TesCFDICobranzaCuerpoDatos
(
@pTesCFDICobranza int=NULL,
@ptesMovimientos bigint=NULL
)
AS
SET NOCOUNT ON 

SELECT TesCFDICobranzaCuerpo.TesCFDICobranza, TesCFDICobranzaCuerpo.tesMovimientos 
FROM TesCFDICobranzaCuerpo 
INNER JOIN tesCFDICobranza  ON (tesCFDICobranza.tesCFDICobranza = TesCFDICobranzaCuerpo.TesCFDICobranza)
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = TesCFDICobranzaCuerpo.tesMovimientos)
INNER JOIN conAsientos ON 
conAsientos.conAsientos =TesCFDICobranzaCuerpo.tesMovimientos
WHERE (TesCFDICobranzaCuerpo.TesCFDICobranza = isnull(@pTesCFDICobranza,TesCFDICobranzaCuerpo.TesCFDICobranza))
AND (TesCFDICobranzaCuerpo.tesMovimientos = ISNULL(@ptesMovimientos,TesCFDICobranzaCuerpo.tesMovimientos)) AND 
conAsientos.Anulado = 0 AND 
 tesCFDICobranza.Anulada = ' '
RETURN @@Error 

GO

DROP PROCEDURE TesCFDICobranzaCuerpoEliminar
GO
CREATE PROCEDURE TesCFDICobranzaCuerpoEliminar
(
@pTesCFDICobranza int,
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM TesCFDICobranzaCuerpo 
WHERE (TesCFDICobranza = @pTesCFDICobranza)
AND (tesMovimientos = @ptesMovimientos)
 
 RETURN @@Error 

GO

