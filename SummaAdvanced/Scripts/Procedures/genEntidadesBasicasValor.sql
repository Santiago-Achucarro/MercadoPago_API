DROP PROCEDURE genEntidadesBasicasValorGuardar
GO
CREATE PROCEDURE genEntidadesBasicasValorGuardar
(
@pEntidad_Id int,
@pDominio_Id char(2),
@pClave varchar(20),
@pDescripcion varchar(200)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genEntidadesBasicasValor WHERE (Entidad_Id = @pEntidad_Id) AND (Dominio_Id = @pDominio_Id) AND (Clave = @pClave)))
BEGIN 
	UPDATE genEntidadesBasicasValor
	SET		Descripcion = @pDescripcion
	WHERE (Entidad_Id = @pEntidad_Id) AND (Dominio_Id = @pDominio_Id) AND (Clave = @pClave)
END 
ELSE 
BEGIN 
	INSERT INTO genEntidadesBasicasValor
	(
		Entidad_Id,
		Dominio_Id,
		Clave,
		Descripcion
	)
	VALUES 
	(
		@pEntidad_Id,
		@pDominio_Id,
		@pClave,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE genEntidadesBasicasValorDatos
GO
CREATE PROCEDURE genEntidadesBasicasValorDatos
(
@pEntidad_Id int,
@pDominio_Id char(2),
@pClave varchar(20)
)
AS
SET NOCOUNT ON 

SELECT genEntidadesBasicasValor.Entidad_Id, genEntidadesBasicas.Descripcion as DescripcionEntidadesBasicas, genEntidadesBasicasValor.Dominio_Id, genDominios.Descripcion as DescripcionDominios,
	genEntidadesBasicasValor.Clave, genEntidadesBasicasValor.Descripcion
FROM genEntidadesBasicasValor 
INNER JOIN genEntidadesBasicas  ON (genEntidadesBasicas.Entidad_Id = genEntidadesBasicasValor.Entidad_Id)
INNER JOIN genDominios  ON (genDominios.Dominio_Id = genEntidadesBasicasValor.Dominio_Id)
WHERE (genEntidadesBasicasValor.Entidad_Id = @pEntidad_Id)
AND (genEntidadesBasicasValor.Dominio_Id = @pDominio_Id)
AND (Clave = @pClave)
 
 RETURN @@Error 

GO

DROP PROCEDURE genEntidadesBasicasValorEliminar
GO
CREATE PROCEDURE genEntidadesBasicasValorEliminar
(
@pEntidad_Id int,
@pDominio_Id char(2),
@pClave varchar(20) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genEntidadesBasicasValor 
WHERE (genEntidadesBasicasValor.Entidad_Id = @pEntidad_Id)
AND (Dominio_Id = @pDominio_Id)
AND (Clave = ISNULL(@pClave, Clave))
 
 RETURN @@Error 

GO

GO
