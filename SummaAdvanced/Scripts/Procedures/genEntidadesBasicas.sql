DROP PROCEDURE genEntidadesBasicasGuardar
GO
CREATE PROCEDURE genEntidadesBasicasGuardar
(
@pEntidad_Id int,
@pDescripcion varchar(150)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genEntidadesBasicas WHERE (Entidad_Id = @pEntidad_Id)))
BEGIN 
	UPDATE genEntidadesBasicas
	SET		Descripcion = @pDescripcion
	WHERE (Entidad_Id = @pEntidad_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genEntidadesBasicas
	(
		Entidad_Id,
		Descripcion
	)
	VALUES 
	(
		@pEntidad_Id,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE genEntidadesBasicasDatos
GO
CREATE PROCEDURE genEntidadesBasicasDatos
(
@pEntidad_Id int
)
AS
SET NOCOUNT ON 

SELECT genEntidadesBasicas.Entidad_Id, genEntidadesBasicas.Descripcion
FROM genEntidadesBasicas 
WHERE (Entidad_Id = @pEntidad_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE genEntidadesBasicasEliminar
GO
CREATE PROCEDURE genEntidadesBasicasEliminar
(
@pEntidad_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genEntidadesBasicas 
WHERE (Entidad_Id = ISNULL(@pEntidad_Id, Entidad_Id))
 
 RETURN @@Error 

GO



DROP PROCEDURE genEntidadesBasicasModDatos
GO
CREATE PROCEDURE genEntidadesBasicasModDatos
(
@pEntidad_Id int, 
@pDominio_Id Char(2) 
)
AS
SET NOCOUNT ON 

SELECT genEntidadesBasicas.Entidad_Id, genEntidadesBasicas.Descripcion
FROM genEntidadesBasicas 
WHERE (Entidad_Id = @pEntidad_Id)


SELECT genEntidadesBasicasValor.Clave, genEntidadesBasicasValor.Descripcion
FROM genEntidadesBasicas 
	INNER JOIN genEntidadesBasicasValor ON  genEntidadesBasicasValor.Entidad_Id = genEntidadesBasicas.Entidad_Id
WHERE (genEntidadesBasicas.Entidad_Id = @pEntidad_Id) and 
genEntidadesBasicasValor.Dominio_Id = @pDominio_Id
ORDER BY 1

GO


