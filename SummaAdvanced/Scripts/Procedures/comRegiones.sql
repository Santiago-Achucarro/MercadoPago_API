DROP PROCEDURE comRegionesGuardar
GO
CREATE PROCEDURE comRegionesGuardar
(
@pRegion_Id varchar(5),
@pRegion_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comRegiones WHERE (Region_Id = @pRegion_Id)))
BEGIN 
	UPDATE comRegiones
	SET		@lIdentidad = comRegiones,
		Region_Id = @pRegion_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Region_Id = @pRegion_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comRegiones
	(
		Region_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pRegion_Id,
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

DROP PROCEDURE comRegionesDatos
GO
CREATE PROCEDURE comRegionesDatos
(
@pRegion_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comRegiones.comRegiones, comRegiones.Region_Id, comRegiones.Empresa_Id, Cast( Case When comRegiones.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comRegiones.Descripcion, comRegiones.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	comRegiones.Posteado
FROM comRegiones 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comRegiones.Usuario_Id)
WHERE (Region_Id = @pRegion_Id)
 


  Declare @pidentity bigint= dbo.FuncFKcomRegiones(@pRegion_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comRegiones'
 RETURN @@Error 

GO

DROP PROCEDURE comRegionesEliminar
GO
CREATE PROCEDURE comRegionesEliminar
(
@pRegion_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comRegiones 
WHERE (Region_Id = @pRegion_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomRegiones
GO

CREATE FUNCTION FuncFKcomRegiones
(
@pRegion_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comRegiones FROM comRegiones WHERE 
	Region_Id = @pRegion_Id
  RETURN @pIdentity
END


GO
