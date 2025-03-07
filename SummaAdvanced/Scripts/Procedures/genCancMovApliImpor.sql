DROP PROCEDURE genCancMovApliImporGuardar
GO
CREATE PROCEDURE genCancMovApliImporGuardar
(
@pconAsientos bigint,
@pRenglon int,
@pEsDelAp bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genCancMovApliImpor WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE genCancMovApliImpor
	SET		EsDelAp = @pEsDelAp
	WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO genCancMovApliImpor
	(
		conAsientos,
		Renglon,
		EsDelAp
	)
	VALUES 
	(
		@pconAsientos,
		@pRenglon,
		@pEsDelAp
	)
END 

GO

DROP PROCEDURE genCancMovApliImporDatos
GO
CREATE PROCEDURE genCancMovApliImporDatos
(
@pconAsientos bigint,
@pRenglon int=Null
)
AS
SET NOCOUNT ON 

SELECT genCancMovApliImpor.conAsientos, genCancMovApliImpor.Renglon, genCancMovApliImpor.EsDelAp
FROM genCancMovApliImpor 
WHERE (conAsientos = @pconAsientos)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE genCancMovApliImporEliminar
GO
CREATE PROCEDURE genCancMovApliImporEliminar
(
@pconAsientos bigint,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genCancMovApliImpor 
WHERE (conAsientos = @pconAsientos)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

