DROP PROCEDURE comCategoriasGuardar
GO
CREATE PROCEDURE comCategoriasGuardar
(
@pCategoria_Id varchar(5),
@pCategoria_Id_Nuevo varchar(5),
@pDescripcion varchar(60),
@pCuenta_Id varchar(25) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pEmpresa_Id int=null,
@pPTodasEmpresas bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comCategorias WHERE (Categoria_Id = @pCategoria_Id)))
BEGIN 
	UPDATE comCategorias
	SET		@lIdentidad = comCategorias,
		Categoria_Id = @pCategoria_Id_Nuevo,
		Descripcion = @pDescripcion,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id=@pEmpresa_Id
	WHERE (Categoria_Id = @pCategoria_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comCategorias
	(
		Categoria_Id,
		Descripcion,
		Cuenta_Id,
		Inactivo,
		Posteado,
		Usuario_Id,
		Empresa_Id
	)
	VALUES 
	(
		@pCategoria_Id,
		@pDescripcion,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pEmpresa_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comCategoriasDatos
GO
CREATE PROCEDURE comCategoriasDatos
(
@pCategoria_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comCategorias.comCategorias, comCategorias.Categoria_Id, comCategorias.Descripcion, conCuentas.Cuenta_Id,
	conCuentas.Descripcion as DescripcionCuentas, comCategorias.Inactivo, comCategorias.Posteado, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comCategorias.Empresa_Id, cast(case when comCategorias.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas
FROM comCategorias 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comCategorias.Cuenta_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comCategorias.Usuario_Id)
WHERE (Categoria_Id = @pCategoria_Id)

 SELECT comSubCategorias.comSubCategorias, comSubCategorias.SubCategoria_Id, comSubCategorias.Descripcion, comCategorias.Categoria_Id,
	comCategorias.Descripcion as DescripcionCategorias, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2
FROM comSubCategorias 
INNER JOIN comCategorias  ON (comCategorias.comCategorias = comSubCategorias.Categoria_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comSubCategorias.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comSubCategorias.Centro2_Id)

WHERE (comCategorias.Categoria_Id = @pCategoria_Id)
 


 Declare @pidentity bigint= dbo.FuncFKcomCategorias(@pCategoria_Id)  
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comCategorias'
 RETURN @@Error 

GO

DROP PROCEDURE comCategoriasEliminar
GO
CREATE PROCEDURE comCategoriasEliminar
(
@pCategoria_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comCategorias 
WHERE (Categoria_Id = @pCategoria_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomCategorias
GO

CREATE FUNCTION FuncFKcomCategorias
(
@pCategoria_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comCategorias FROM comCategorias WHERE 
	Categoria_Id = @pCategoria_Id
  RETURN @pIdentity
END


GO
