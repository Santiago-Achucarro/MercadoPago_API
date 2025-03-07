DROP PROCEDURE stkTiposGuardar
GO
CREATE PROCEDURE stkTiposGuardar
(
@pTipo_Id varchar(5),
@pTipo_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkTipos WHERE (Tipo_Id = @pTipo_Id)))
BEGIN 
	UPDATE stkTipos
	SET		@lIdentidad = stkTipos,
		Tipo_Id = @pTipo_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Tipo_Id = @pTipo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkTipos
	(
		Tipo_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pTipo_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkTiposDatos
GO
CREATE PROCEDURE stkTiposDatos
(
@pTipo_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT stkTipos.stkTipos, stkTipos.Tipo_Id, stkTipos.Empresa_Id, Cast( Case When stkTipos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	stkTipos.Descripcion, stkTipos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	stkTipos.Posteado
FROM stkTipos 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkTipos.Usuario_Id)
WHERE (Tipo_Id = @pTipo_Id)
 


  Declare @pidentity bigint= dbo.FuncFKstkTipos(@pTipo_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkTipos'
 RETURN @@Error 

GO

DROP PROCEDURE stkTiposEliminar
GO
CREATE PROCEDURE stkTiposEliminar
(
@pTipo_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkTipos 
WHERE (Tipo_Id = @pTipo_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkTipos
GO

CREATE FUNCTION FuncFKstkTipos
(
@pTipo_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkTipos FROM stkTipos WHERE 
	Tipo_Id = @pTipo_Id
  RETURN @pIdentity
END


GO
