DROP PROCEDURE sueTablaVacacionGuardar
GO
CREATE PROCEDURE sueTablaVacacionGuardar
(
@pTablaVac_Id varchar(5),
@pTablaVac_Id_Nuevo varchar(5),
@pDescripcion varchar(100),
@pDias int,
@pEmpresa_Id int = NULL,
@pUsuario_Id int,
@pInactivo Sino,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueTablaVacacion WHERE (TablaVac_Id = @pTablaVac_Id)))
BEGIN 
	UPDATE sueTablaVacacion
	SET		@lIdentidad = sueTablaVacacion,
		TablaVac_Id = @pTablaVac_Id_Nuevo,
		Descripcion = @pDescripcion,
		Dias = @pDias,
		Empresa_Id = @pEmpresa_Id,
		Usuario_Id = @pUsuario_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado
	WHERE (TablaVac_Id = @pTablaVac_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueTablaVacacion
	(
		TablaVac_Id,
		Descripcion,
		Dias,
		Empresa_Id,
		Usuario_Id,
		Inactivo,
		Posteado
	)
	VALUES 
	(
		@pTablaVac_Id,
		@pDescripcion,
		@pDias,
		@pEmpresa_Id,
		@pUsuario_Id,
		@pInactivo,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueTablaVacacionDatos
GO
CREATE PROCEDURE sueTablaVacacionDatos
(
@pTablaVac_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT sueTablaVacacion.sueTablaVacacion, sueTablaVacacion.TablaVac_Id, sueTablaVacacion.Descripcion, sueTablaVacacion.Dias,
	sueTablaVacacion.Empresa_Id, Cast( Case When sueTablaVacacion.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, sueTablaVacacion.Inactivo, sueTablaVacacion.Posteado
FROM sueTablaVacacion 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueTablaVacacion.Usuario_Id)
WHERE (TablaVac_Id = @pTablaVac_Id)
 

 exec sueTablaVacRengDatos @pTablaVac_Id, null

  Declare @pidentity bigint= dbo.FuncFKsueTablaVacacion(@pTablaVac_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueTablaVacacion'
 RETURN @@Error 

GO

DROP PROCEDURE sueTablaVacacionEliminar
GO
CREATE PROCEDURE sueTablaVacacionEliminar
(
@pTablaVac_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueTablaVacacion 
WHERE (TablaVac_Id = @pTablaVac_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsueTablaVacacion
GO

CREATE FUNCTION FuncFKsueTablaVacacion
(
@pTablaVac_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueTablaVacacion FROM sueTablaVacacion WHERE 
	TablaVac_Id = @pTablaVac_Id
  RETURN @pIdentity
END


GO
