DROP PROCEDURE venZonaGuardar
GO
CREATE PROCEDURE venZonaGuardar
(
@pZona_Id varchar(5),
@pZona_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venZona WHERE (Zona_Id = @pZona_Id)))
BEGIN 
	UPDATE venZona
	SET		@lIdentidad = venZona,
		Zona_Id = @pZona_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Zona_Id = @pZona_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venZona
	(
		Zona_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pZona_Id,
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

DROP PROCEDURE venZonaDatos
GO
CREATE PROCEDURE venZonaDatos
(
@pZona_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venZona.venZona, venZona.Zona_Id, venZona.Empresa_Id, Cast( Case When venZona.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venZona.Descripcion, venZona.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	venZona.Posteado
FROM venZona 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venZona.Usuario_Id)
WHERE (Zona_Id = @pZona_Id)
 


  Declare @pidentity bigint= dbo.FuncFKvenZona(@pZona_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venZona'
 RETURN @@Error 

GO

DROP PROCEDURE venZonaEliminar
GO
CREATE PROCEDURE venZonaEliminar
(
@pZona_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venZona 
WHERE (Zona_Id = @pZona_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenZona
GO

CREATE FUNCTION FuncFKvenZona
(
@pZona_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venZona FROM venZona WHERE 
	Zona_Id = @pZona_Id
  RETURN @pIdentity
END


GO
