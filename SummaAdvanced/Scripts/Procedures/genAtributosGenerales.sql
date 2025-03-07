DROP PROCEDURE genAtributosGeneralesGuardar
GO
CREATE PROCEDURE genAtributosGeneralesGuardar
(
@pAtributoNro int,
@pTabla_Id varchar(60),
@pDescripcion varchar(80),
@pTipo char(1),
@pEnGrilla Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genAtributosGenerales WHERE (AtributoNro = @pAtributoNro) AND (Tabla_Id = @pTabla_Id)))
BEGIN 
	UPDATE genAtributosGenerales
	SET Descripcion = @pDescripcion,
		Tipo = @pTipo, EnGrilla = @pEnGrilla
	WHERE (AtributoNro = @pAtributoNro) AND (Tabla_Id = @pTabla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genAtributosGenerales
	(
		AtributoNro,
		Tabla_Id,
		Descripcion,
		Tipo,
		EnGrilla
	)
	VALUES 
	(
		@pAtributoNro,
		@pTabla_Id,
		@pDescripcion,
		@pTipo,
		@pEnGrilla
	)
END 

GO

DROP PROCEDURE genAtributosGeneralesDatos
GO
CREATE PROCEDURE genAtributosGeneralesDatos
(
@pAtributoNro int,
@pTabla_Id varchar(60)
)
AS
SET NOCOUNT ON 

SELECT genAtributosGenerales.AtributoNro, genAtributosGenerales.Tabla_Id, genAtributosGenerales.Descripcion, genAtributosGenerales.Tipo,
genAtributosGenerales.EnGrilla
FROM genAtributosGenerales 
WHERE AtributoNro = @pAtributoNro
AND Tabla_Id = @pTabla_Id 
 
RETURN @@Error 

GO

DROP PROCEDURE genAtributosGeneralesEliminar
GO
CREATE PROCEDURE genAtributosGeneralesEliminar
(
@pAtributoNro int = NULL,
@pTabla_Id varchar(60) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genAtributosGenerales 
WHERE (AtributoNro = ISNULL(@pAtributoNro, AtributoNro))
AND (Tabla_Id = ISNULL(@pTabla_Id, Tabla_Id))
 
RETURN @@Error 

GO

