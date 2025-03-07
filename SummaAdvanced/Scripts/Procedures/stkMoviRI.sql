DROP PROCEDURE stkMoviRIGuardar
GO
CREATE PROCEDURE stkMoviRIGuardar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pcomReqInterno int = NULL,
@pRenglon_RI int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviRI WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE stkMoviRI
	SET		comReqInterno = @pcomReqInterno,
		Renglon_RI = @pRenglon_RI
	WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviRI
	(
		stkMoviCabe,
		Renglon,
		comReqInterno,
		Renglon_RI
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pcomReqInterno,
		@pRenglon_RI
	)
END 

GO

DROP PROCEDURE stkMoviRIDatos
GO
CREATE PROCEDURE stkMoviRIDatos
(
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviRI.stkMoviCabe, stkMoviRI.Renglon, stkMoviRI.comReqInterno, stkMoviRI.Renglon_RI
FROM stkMoviRI 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviRIEliminar
GO
CREATE PROCEDURE stkMoviRIEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = null
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviRI 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

GO
