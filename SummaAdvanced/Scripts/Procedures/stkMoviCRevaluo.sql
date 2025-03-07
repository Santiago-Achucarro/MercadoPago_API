DROP PROCEDURE stkMoviCRevaluoInsertar
GO
CREATE PROCEDURE stkMoviCRevaluoInsertar
(
@pstkMoviCabeReva bigint,
@pconAsientos bigint
)
AS
	INSERT INTO stkMoviCRevaluo
	(
		stkMoviCabeReva,
		conAsientos
	)
	VALUES 
	(
		@pstkMoviCabeReva,
		@pconAsientos
	)
GO

DROP PROCEDURE stkMoviCRevaluoDatos
GO
CREATE PROCEDURE stkMoviCRevaluoDatos
(
@pstkMoviCabeReva bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviCRevaluo.stkMoviCabeReva, stkMoviCRevaluo.conAsientos
FROM stkMoviCRevaluo 
WHERE (stkMoviCabeReva = @pstkMoviCabeReva)
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviCRevaluoEliminar
GO
CREATE PROCEDURE stkMoviCRevaluoEliminar
(
@pstkMoviCabeReva bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCRevaluo WHERE (stkMoviCabeReva = @pstkMoviCabeReva)
 
 RETURN @@Error 

GO


DROP PROCEDURE stkMoviCRevaluoDatosCabe
GO
CREATE PROCEDURE stkMoviCRevaluoDatosCabe
(
@pconAsientos bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviCRevaluo.stkMoviCabeReva, stkMoviCRevaluo.conAsientos
FROM stkMoviCRevaluo 
WHERE (conAsientos= @pconAsientos)
 
RETURN @@Error 

GO



