--- AJ Causa tiene 100 en Descripcion
DROP PROCEDURE stkCausasMoviGuardar
GO
CREATE PROCEDURE stkCausasMoviGuardar
(
@pCausa_Id varchar(5),
@pCausa_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(100),
@pCuenta_Id varchar(25) = NULL,
@pEntSalAmb char(1),
@pUsuarioAutorizado varchar(25) = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkCausasMovi WHERE (Causa_Id = @pCausa_Id)))
BEGIN 
	UPDATE stkCausasMovi
	SET		@lIdentidad = stkCausasMovi,
		Causa_Id = @pCausa_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		EntSalAmb = @pEntSalAmb,
		UsuarioAutorizado = dbo.FuncFKgenUsuarios(@pUsuarioAutorizado),
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Causa_Id = @pCausa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkCausasMovi
	(
		Causa_Id,
		Empresa_Id,
		Descripcion,
		Cuenta_Id,
		EntSalAmb,
		UsuarioAutorizado,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCausa_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pEntSalAmb,
		dbo.FuncFKgenUsuarios(@pUsuarioAutorizado),
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkCausasMoviDatos
GO
CREATE PROCEDURE stkCausasMoviDatos
(
@pCausa_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT stkCausasMovi.stkCausasMovi, stkCausasMovi.Causa_Id, stkCausasMovi.Empresa_Id, Cast( Case When stkCausasMovi.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	stkCausasMovi.Descripcion, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, stkCausasMovi.EntSalAmb,
	genUsuarios.Usuario_Id UsuarioAutorizado, genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAutorizado, 
	stkCausasMovi.Inactivo, genUsuarios2.Usuario_Id, 	genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, 
	stkCausasMovi.Posteado
FROM stkCausasMovi 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = stkCausasMovi.Cuenta_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkCausasMovi.UsuarioAutorizado)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = stkCausasMovi.Usuario_Id)
WHERE (Causa_Id = @pCausa_Id)
 


  Declare @pidentity bigint= dbo.FuncFKstkCausasMovi(@pCausa_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkCausasMovi'
 RETURN @@Error 

GO

DROP PROCEDURE stkCausasMoviEliminar
GO
CREATE PROCEDURE stkCausasMoviEliminar
(
@pCausa_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkCausasMovi 
WHERE (Causa_Id = @pCausa_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkCausasMovi
GO

CREATE FUNCTION FuncFKstkCausasMovi
(
@pCausa_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkCausasMovi FROM stkCausasMovi WHERE 
	Causa_Id = @pCausa_Id
  RETURN @pIdentity
END


GO
