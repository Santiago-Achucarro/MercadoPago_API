DROP PROCEDURE comForEntreGuardar
GO
CREATE PROCEDURE comForEntreGuardar
(
@pFormaEnt_Id varchar(5),
@pFormaEnt_Id_Nuevo varchar(5),
@pDescripcion varchar(35),
@pEmpresa_Id int = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comForEntre WHERE (FormaEnt_Id = @pFormaEnt_Id)))
BEGIN 
	UPDATE comForEntre
	SET		@lIdentidad = comForEntre,
		FormaEnt_Id = @pFormaEnt_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (FormaEnt_Id = @pFormaEnt_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comForEntre
	(
		FormaEnt_Id,
		Descripcion,
		Empresa_Id,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pFormaEnt_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comForEntreDatos
GO
CREATE PROCEDURE comForEntreDatos
(
@pFormaEnt_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comForEntre.comForEntre, comForEntre.FormaEnt_Id, comForEntre.Descripcion, comForEntre.Empresa_Id,
	Cast( Case When comForEntre.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, comForEntre.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	comForEntre.Posteado
FROM comForEntre 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comForEntre.Usuario_Id)
WHERE (FormaEnt_Id = @pFormaEnt_Id)
 


 Declare @pidentity bigint= dbo.FuncFKcomForEntre(@pFormaEnt_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comForEntre'
 RETURN @@Error 

GO

DROP PROCEDURE comForEntreEliminar
GO
CREATE PROCEDURE comForEntreEliminar
(
@pFormaEnt_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comForEntre 
WHERE (FormaEnt_Id = @pFormaEnt_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomForEntre
GO

CREATE FUNCTION FuncFKcomForEntre
(
@pFormaEnt_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comForEntre FROM comForEntre WHERE 
	FormaEnt_Id = @pFormaEnt_Id
  RETURN @pIdentity
END


GO
