DROP PROCEDURE venRegionGuardar
GO
CREATE PROCEDURE venRegionGuardar
(
@pRegion_Id varchar(5),
@pRegion_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venRegion WHERE (Region_Id = @pRegion_Id)))
BEGIN 
	UPDATE venRegion
	SET		@lIdentidad = venRegion,
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
	INSERT INTO venRegion
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

DROP PROCEDURE venRegionDatos
GO
CREATE PROCEDURE venRegionDatos
(
@pRegion_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venRegion.venRegion, venRegion.Region_Id, venRegion.Empresa_Id, Cast( Case When venRegion.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venRegion.Descripcion, venRegion.Inactivo, venRegion.Usuario_Id, venRegion.Posteado
FROM venRegion 
WHERE (Region_Id = @pRegion_Id)
 


  Declare @pidentity bigint= dbo.FuncFKvenRegion(@pRegion_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venRegion'
 RETURN @@Error 

GO

DROP PROCEDURE venRegionEliminar
GO
CREATE PROCEDURE venRegionEliminar
(
@pRegion_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venRegion 
WHERE (Region_Id = @pRegion_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenRegion
GO

CREATE FUNCTION FuncFKvenRegion
(
@pRegion_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venRegion FROM venRegion WHERE 
	Region_Id = @pRegion_Id
  RETURN @pIdentity
END


GO
