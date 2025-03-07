DROP PROCEDURE stkGruposGuardar
GO
CREATE PROCEDURE stkGruposGuardar
(
@pGrupo_Id varchar(15),
@pGrupo_Id_Nuevo varchar(15),
@pDescripcion varchar(60),
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkGrupos WHERE (Grupo_Id = @pGrupo_Id)))
BEGIN 
	UPDATE stkGrupos
	SET		@lIdentidad = stkGrupos,
		Grupo_Id = @pGrupo_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Grupo_Id = @pGrupo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkGrupos
	(
		Grupo_Id,
		Descripcion,
		Empresa_Id,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pGrupo_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkGruposDatos
GO
CREATE PROCEDURE stkGruposDatos
(
@pGrupo_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT stkGrupos.stkGrupos, stkGrupos.Grupo_Id, stkGrupos.Descripcion, stkGrupos.Grupo_Id Grupo_Id_Nueva,
	stkGrupos.Empresa_Id, Cast( Case When stkGrupos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, stkGrupos.Inactivo, stkGrupos.Posteado,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM stkGrupos 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkGrupos.Usuario_Id)
WHERE (Grupo_Id = @pGrupo_Id)
 


 Declare @pidentity bigint= dbo.FuncFKstkGrupos(@pGrupo_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkGrupos'
 RETURN @@Error 

GO

DROP PROCEDURE stkGruposEliminar
GO
CREATE PROCEDURE stkGruposEliminar
(
@pGrupo_Id varchar(15) 
)
AS
SET NOCOUNT ON 

DELETE FROM stkGrupos 
WHERE (Grupo_Id = @pGrupo_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkGrupos
GO

CREATE FUNCTION FuncFKstkGrupos
(
@pGrupo_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkGrupos FROM stkGrupos WHERE 
	Grupo_Id = @pGrupo_Id
  RETURN @pIdentity
END


GO
