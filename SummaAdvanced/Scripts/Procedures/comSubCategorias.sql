DROP PROCEDURE comSubCategoriasGuardar
GO
CREATE PROCEDURE comSubCategoriasGuardar
(
@pSubCategoria_Id varchar(5),
@pSubCategoria_Id_Nuevo varchar(5),
@pDescripcion varchar(60),
@pCategoria_Id varchar(5),
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comSubCategorias WHERE (SubCategoria_Id = @pSubCategoria_Id)))
BEGIN 
	UPDATE comSubCategorias
	SET		@lIdentidad = comSubCategorias,
		SubCategoria_Id = @pSubCategoria_Id_Nuevo,
		Descripcion = @pDescripcion,
		Categoria_Id = dbo.FuncFKcomCategorias(@pCategoria_Id),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id)
	WHERE (SubCategoria_Id = @pSubCategoria_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comSubCategorias
	(
		SubCategoria_Id,
		Descripcion,
		Categoria_Id,
		Centro1_Id,
		Centro2_Id
	)
	VALUES 
	(
		@pSubCategoria_Id,
		@pDescripcion,
		dbo.FuncFKcomCategorias(@pCategoria_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id)
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comSubCategoriasDatos
GO
CREATE PROCEDURE comSubCategoriasDatos
(
@pSubCategoria_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comSubCategorias.comSubCategorias, comSubCategorias.SubCategoria_Id, comSubCategorias.Descripcion, comCategorias.Categoria_Id,
	comCategorias.Descripcion as DescripcionCategorias, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2
FROM comSubCategorias 
INNER JOIN comCategorias  ON (comCategorias.comCategorias = comSubCategorias.Categoria_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comSubCategorias.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comSubCategorias.Centro2_Id)
WHERE (SubCategoria_Id = @pSubCategoria_Id)
 


  Declare @pidentity bigint= dbo.FuncFKcomSubCategorias(@pSubCategoria_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comSubCategorias'
 RETURN @@Error 

GO

DROP PROCEDURE comSubCategoriasEliminar
GO
CREATE PROCEDURE comSubCategoriasEliminar
(
@pCategoria_Id varchar(5),
@pSubCategoria_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comSubCategorias 
WHERE (SubCategoria_Id = isnull(@pSubCategoria_Id, SubCategoria_Id)) and
Categoria_Id=dbo.FuncFKcomCategorias(@pCategoria_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomSubCategorias
GO

CREATE FUNCTION FuncFKcomSubCategorias
(
@pSubCategoria_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comSubCategorias FROM comSubCategorias WHERE 
	SubCategoria_Id = isnull(@pSubCategoria_Id,SubCategoria_Id)
  RETURN @pIdentity
END


GO
