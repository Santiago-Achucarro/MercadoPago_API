DROP PROCEDURE genAtributosValoresGuardar
GO
CREATE PROCEDURE genAtributosValoresGuardar
(
@pIdentity_Id bigint,
@pAtributoNro int,
@pTabla_Id varchar(60),
@pValorN numeric(28,8) = NULL,
@pValorC varchar(255) = NULL,
@pValorF datetime = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genAtributosValores WHERE (Identity_Id = @pIdentity_Id) AND (AtributoNro = @pAtributoNro) AND (Tabla_Id = @pTabla_Id)))
BEGIN 
	UPDATE genAtributosValores
	SET		ValorN = @pValorN,
		ValorC = @pValorC,
		ValorF = @pValorF
	WHERE (Identity_Id = @pIdentity_Id) AND (AtributoNro = @pAtributoNro) AND (Tabla_Id = @pTabla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genAtributosValores
	(
		Identity_Id,
		AtributoNro,
		Tabla_Id,
		ValorN,
		ValorC,
		ValorF
	)
	VALUES 
	(
		@pIdentity_Id,
		@pAtributoNro,
		@pTabla_Id,
		@pValorN,
		@pValorC,
		@pValorF
	)
END 

GO

DROP PROCEDURE genAtributosValoresDatos
GO
CREATE PROCEDURE genAtributosValoresDatos
(
@pIdentity_Id bigint,
@pAtributoNro int,
@pTabla_Id varchar(60)
)
AS
SET NOCOUNT ON 

SELECT genAtributosValores.Identity_Id, genAtributosValores.AtributoNro, genAtributosValores.Tabla_Id, 
	genAtributosGenerales.Descripcion as DescripcionAtributosGenerales,
	genAtributosGenerales.Tipo,
	genAtributosValores.ValorN, genAtributosValores.ValorC, genAtributosValores.ValorF
FROM genAtributosValores 
INNER JOIN genAtributosGenerales  ON (genAtributosGenerales.AtributoNro = genAtributosValores.AtributoNro) AND (genAtributosGenerales.Tabla_Id = genAtributosValores.Tabla_Id)
WHERE (Identity_Id = @pIdentity_Id)
AND (genAtributosValores.AtributoNro = @pAtributoNro)
AND (genAtributosValores.Tabla_Id = @pTabla_Id)
 
 RETURN @@Error 
GO

DROP PROCEDURE genAtributosValoresEliminar
GO
CREATE PROCEDURE genAtributosValoresEliminar
(
@pIdentity_Id bigint,
@pAtributoNro int=null,
@pTabla_Id varchar(60)
)
AS
SET NOCOUNT ON 

DELETE FROM genAtributosValores 
WHERE Identity_Id = @pIdentity_Id
AND AtributoNro = ISNULL(@pAtributoNro,AtributoNro)
AND Tabla_Id = @pTabla_Id
 
 RETURN @@Error 

GO

DROP PROCEDURE genAtributosValoresValores
GO
CREATE PROCEDURE genAtributosValoresValores
(
@pAtributoNro int,
@pTabla_Id varchar(60)
)
AS
SET NOCOUNT ON 

SELECT genAtributosValores.Identity_Id, genAtributosValores.AtributoNro, genAtributosValores.Tabla_Id, 
	genAtributosGenerales.Descripcion as DescripcionAtributosGenerales,
	genAtributosGenerales.Tipo,
	genAtributosValores.ValorN, genAtributosValores.ValorC, genAtributosValores.ValorF
FROM genAtributosValores 
INNER JOIN genAtributosGenerales  ON (genAtributosGenerales.AtributoNro = genAtributosValores.AtributoNro) AND (genAtributosGenerales.Tabla_Id = genAtributosValores.Tabla_Id)
WHERE (genAtributosValores.AtributoNro = @pAtributoNro)
AND (genAtributosValores.Tabla_Id = @pTabla_Id)
 
RETURN @@Error 
GO