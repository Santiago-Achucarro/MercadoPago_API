DROP PROCEDURE genLinksAyudaGuardar
GO
CREATE PROCEDURE genLinksAyudaGuardar
(
@pCodigoLnk varchar(25),
@pDominio_Id varchar(2),
@pDescripcion varchar(150),
@pLink varchar(max)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genLinksAyuda WHERE (CodigoLnk = @pCodigoLnk) AND (Dominio_Id = @pDominio_Id)))
BEGIN 
	UPDATE genLinksAyuda
	SET		Descripcion = @pDescripcion,
		Link = @pLink
	WHERE (CodigoLnk = @pCodigoLnk) AND (Dominio_Id = @pDominio_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genLinksAyuda
	(
		CodigoLnk,
		Dominio_Id,
		Descripcion,
		Link
	)
	VALUES 
	(
		@pCodigoLnk,
		@pDominio_Id,
		@pDescripcion,
		@pLink
	)
END 

GO

DROP PROCEDURE genLinksAyudaDatos
GO
CREATE PROCEDURE genLinksAyudaDatos
(
@pCodigoLnk varchar(25),
@pDominio_Id varchar(2)
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM genLinksAyuda WHERE (CodigoLnk = @pCodigoLnk) AND (Dominio_Id = @pDominio_Id)))
BEGIN
	SELECT genLinksAyuda.CodigoLnk, genLinksAyuda.Dominio_Id, genLinksAyuda.Descripcion, genLinksAyuda.Link
	FROM genLinksAyuda 
	WHERE (CodigoLnk = @pCodigoLnk)
	AND (Dominio_Id = @pDominio_Id)
END
ELSE
BEGIN
	SELECT genLinksAyuda.CodigoLnk, genLinksAyuda.Dominio_Id, genLinksAyuda.Descripcion, genLinksAyuda.Link
	FROM genLinksAyuda 
	WHERE (CodigoLnk = @pCodigoLnk)
	AND (Dominio_Id = '')
END
 
 RETURN @@Error 

GO

DROP PROCEDURE genLinksAyudaEliminar
GO
CREATE PROCEDURE genLinksAyudaEliminar
(
@pCodigoLnk varchar(25) = NULL,
@pDominio_Id varchar(2) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genLinksAyuda 
WHERE (CodigoLnk = ISNULL(@pCodigoLnk, CodigoLnk))
AND (Dominio_Id = ISNULL(@pDominio_Id, Dominio_Id))
 
 RETURN @@Error 

GO


DROP PROCEDURE genLinksAyudaDatosTodos
GO
CREATE PROCEDURE genLinksAyudaDatosTodos
AS
SET NOCOUNT ON 

SELECT distinct genLinksAyuda.CodigoLnk
FROM genLinksAyuda 
 
 RETURN @@Error 

GO

GO
