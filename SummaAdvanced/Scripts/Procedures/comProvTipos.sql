DROP PROCEDURE comProvTiposGuardar
GO
CREATE PROCEDURE comProvTiposGuardar
(
@pProvTipo_Id varchar(5),
@pProvTipo_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comProvTipos WHERE (ProvTipo_Id = @pProvTipo_Id)))
BEGIN 
	UPDATE comProvTipos
	SET		@lIdentidad = comProvTipos,
		ProvTipo_Id = @pProvTipo_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (ProvTipo_Id = @pProvTipo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comProvTipos
	(
		ProvTipo_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pProvTipo_Id,
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

DROP PROCEDURE comProvTiposDatos
GO
CREATE PROCEDURE comProvTiposDatos
(
@pProvTipo_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comProvTipos.comProvTipos, comProvTipos.ProvTipo_Id, comProvTipos.Empresa_Id, Cast( Case When comProvTipos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comProvTipos.Descripcion, comProvTipos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	comProvTipos.Posteado
FROM comProvTipos 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comProvTipos.Usuario_Id)
WHERE (ProvTipo_Id = @pProvTipo_Id)
 


  Declare @pidentity bigint= dbo.FuncFKcomProvTipos(@pProvTipo_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comProvTipos'
 RETURN @@Error 

GO

DROP PROCEDURE comProvTiposEliminar
GO
CREATE PROCEDURE comProvTiposEliminar
(
@pProvTipo_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comProvTipos 
WHERE (ProvTipo_Id = @pProvTipo_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomProvTipos
GO

CREATE FUNCTION FuncFKcomProvTipos
(
@pProvTipo_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comProvTipos FROM comProvTipos WHERE 
	ProvTipo_Id = @pProvTipo_Id
  RETURN @pIdentity
END


GO
