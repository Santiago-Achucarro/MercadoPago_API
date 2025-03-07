DROP PROCEDURE tesIdTarjetasTipoGuardar
GO
CREATE PROCEDURE tesIdTarjetasTipoGuardar
(
@pTipoTarjeta varchar(15),
@pTipoTarjeta_Nuevo varchar(15),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pClase varchar(20),
@pUsuario_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesIdTarjetasTipo WHERE (TipoTarjeta = @pTipoTarjeta)))
BEGIN 
	UPDATE tesIdTarjetasTipo
	SET @lIdentidad = tesIdTarjetasTipo,
		TipoTarjeta = @pTipoTarjeta_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Clase = @pClase,
		Usuario_Id = @pUsuario_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado
	WHERE (TipoTarjeta = @pTipoTarjeta)
END 
ELSE 
BEGIN 
	INSERT INTO tesIdTarjetasTipo
	(
		TipoTarjeta,
		Empresa_Id,
		Descripcion,
		Clase,
		Usuario_Id,
		Inactivo,
		Posteado
	)
	VALUES 
	(
		@pTipoTarjeta,
		@pEmpresa_Id,
		@pDescripcion,
		@pClase,
		@pUsuario_Id,
		@pInactivo,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesIdTarjetasTipoDatos
GO
CREATE PROCEDURE tesIdTarjetasTipoDatos
(
@pTipoTarjeta varchar(15)
)
AS
SET NOCOUNT ON 

SELECT tesIdTarjetasTipo.tesIdTarjetasTipo, tesIdTarjetasTipo.TipoTarjeta, tesIdTarjetasTipo.TipoTarjeta TipoTarjeta_Nueva, tesIdTarjetasTipo.Empresa_Id,
	Cast( Case When tesIdTarjetasTipo.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, tesIdTarjetasTipo.Descripcion, tesIdTarjetasTipo.Clase,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, tesIdTarjetasTipo.Inactivo, tesIdTarjetasTipo.Posteado
FROM tesIdTarjetasTipo 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdTarjetasTipo.Usuario_Id)
WHERE (TipoTarjeta = @pTipoTarjeta)
 

Declare @pidentity bigint= dbo.FuncFKtesIdTarjetasTipo(@pTipoTarjeta)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdTarjetasTipo'
RETURN @@Error 

GO

DROP PROCEDURE tesIdTarjetasTipoEliminar
GO
CREATE PROCEDURE tesIdTarjetasTipoEliminar
(
@pTipoTarjeta varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdTarjetasTipo 
WHERE (TipoTarjeta = @pTipoTarjeta)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesIdTarjetasTipo
GO

CREATE FUNCTION FuncFKtesIdTarjetasTipo
(
@pTipoTarjeta varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesIdTarjetasTipo FROM tesIdTarjetasTipo WHERE 
	TipoTarjeta = @pTipoTarjeta
  RETURN @pIdentity
END


GO
