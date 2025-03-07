DROP PROCEDURE genAdjuntosGuardar
GO


CREATE PROCEDURE genAdjuntosGuardar
(
@pTabla_Id varchar(60),
@pIdentity_Id bigint,
@pRenglon int,
@pGuid varchar(36),
@pNombreArchivo varchar(200),
@pExtension varchar(10)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genAdjuntos WHERE (Identity_Id = @pIdentity_Id) AND (Tabla_Id = @pTabla_Id) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE genAdjuntos
	SET	Guid = @pGuid,
		NombreArchivo = @pNombreArchivo,
		Extension = @pExtension
	WHERE (Identity_Id = @pIdentity_Id) AND (Tabla_Id = @pTabla_Id) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO genAdjuntos
	(
		Tabla_Id,
		Identity_Id,
		Renglon,
		Guid,
		NombreArchivo,
		Extension
	)
	VALUES 
	(
		@pTabla_Id,
		@pIdentity_Id,
		@pRenglon,
		@pGuid,
		@pNombreArchivo,
		@pExtension
	)
END 

GO

DROP PROCEDURE genAdjuntosDatos
GO
CREATE PROCEDURE genAdjuntosDatos
(
@pTabla_Id varchar(60),
@pIdentity_Id bigint,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT 	genAdjuntos.Tabla_Id, genAdjuntos.Identity_Id, genAdjuntos.Renglon, genAdjuntos.Guid,
		genAdjuntos.NombreArchivo, genAdjuntos.Extension, '' as ArchivoBase64, '' as Estado
FROM genAdjuntos 
WHERE (genAdjuntos.Tabla_Id = @pTabla_Id)
AND (Identity_Id = @pIdentity_Id)
AND (Renglon = @pRenglon) 
 RETURN @@Error 

GO

DROP PROCEDURE genAdjuntosEliminar
GO
CREATE PROCEDURE genAdjuntosEliminar
(
@pTabla_Id varchar(60),
@pIdentity_Id bigint,
@pRenglon int=null
)
AS
SET NOCOUNT ON 

DELETE FROM genAdjuntos 
WHERE Tabla_Id = @pTabla_Id
AND Identity_Id = @pIdentity_Id
AND Renglon = ISNULL(@pRenglon,Renglon)

 
 RETURN @@Error 

GO

GO
