DROP PROCEDURE tesGananciasGuardar
GO
CREATE PROCEDURE tesGananciasGuardar
(
@pTabla_Id int,
@pTabla_Id_Nuevo int,
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesGanancias WHERE (Tabla_Id = @pTabla_Id)))
BEGIN 
	UPDATE tesGanancias
	SET		@lIdentidad = tesGanancias,
		Tabla_Id = @pTabla_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Tabla_Id = @pTabla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesGanancias
	(
		Tabla_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pTabla_Id,
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

DROP PROCEDURE tesGananciasDatos
GO
CREATE PROCEDURE tesGananciasDatos
(
@pTabla_Id int
)
AS
SET NOCOUNT ON 

SELECT tesGanancias.tesGanancias, tesGanancias.Tabla_Id, tesGanancias.Empresa_Id, Cast( Case When tesGanancias.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpreas,
	tesGanancias.Descripcion, tesGanancias.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	tesGanancias.Posteado
FROM tesGanancias 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesGanancias.Usuario_Id)
WHERE (Tabla_Id = @pTabla_Id)
 

 Declare @pidentity bigint= dbo.FuncFKtesGanancias(@pTabla_Id)

 Exec tesGanCuerpoDatos @pidentity

 Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesGanancias'
 RETURN @@Error 

GO

DROP PROCEDURE tesGananciasEliminar
GO
CREATE PROCEDURE tesGananciasEliminar
(
@pTabla_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesGanancias 
WHERE (Tabla_Id = @pTabla_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesGanancias
GO

CREATE FUNCTION FuncFKtesGanancias
(
@pTabla_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesGanancias FROM tesGanancias WHERE 
	Tabla_Id = @pTabla_Id
  RETURN @pIdentity
END


GO