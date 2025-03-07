DROP PROCEDURE stkMoviLegaGuardar
GO

CREATE PROCEDURE stkMoviLegaGuardar
(
@pstkMoviCabe bigint,
@pLegajo Int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviLega WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkMoviLega
	SET		Legajo = dbo.FuncFKsuePersonal(@pLegajo)
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviLega
	(
		stkMoviCabe,
		Legajo
	)
	VALUES 
	(
		@pstkMoviCabe,
		dbo.FuncFKsuePersonal(@pLegajo)
	)
END 

GO

DROP PROCEDURE stkMoviLegaDatos
GO
CREATE PROCEDURE stkMoviLegaDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviLega.stkMoviCabe, suePersonal.Legajo
FROM stkMoviLega 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = stkMoviLega.Legajo)
WHERE (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviLegaEliminar
GO
CREATE PROCEDURE stkMoviLegaEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviLega 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO

