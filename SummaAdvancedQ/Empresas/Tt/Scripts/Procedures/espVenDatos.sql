DROP PROCEDURE espVenDatosGuardar
GO
CREATE PROCEDURE espVenDatosGuardar
(
@pVentaDatos_Id varchar(15),
@pVentaDatos_Id_Nuevo varchar(15),
@pMercadoPago_Id varchar(15),
@pCondPagoCli_Id varchar(5),
@pEmpresa_Id int = NULL,
@pFecha datetime,
@pMoneda_Id int,
@pDato varchar(15),
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM espVenDatos WHERE (VentaDatos_Id = @pVentaDatos_Id)))
BEGIN 
	UPDATE espVenDatos
	SET		@lIdentidad = espVenDatos,
		VentaDatos_Id = @pVentaDatos_Id_Nuevo,
		MercadoPago_Id = @pMercadoPago_Id,
		CondPagoCli_Id = @pCondPagoCli_Id,
		Empresa_Id = @pEmpresa_Id,
		Fecha = @pFecha,
		Moneda_Id = @pMoneda_Id,
		Dato = @pDato,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (VentaDatos_Id = @pVentaDatos_Id)
END 
ELSE 
BEGIN 
	INSERT INTO espVenDatos
	(
		VentaDatos_Id,
		MercadoPago_Id,
		CondPagoCli_Id,
		Empresa_Id,
		Fecha,
		Moneda_Id,
		Dato,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pVentaDatos_Id,
		@pMercadoPago_Id,
		@pCondPagoCli_Id,
		@pEmpresa_Id,
		@pFecha,
		@pMoneda_Id,
		@pDato,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE espVenDatosDatos
GO
CREATE PROCEDURE espVenDatosDatos
(
@pVentaDatos_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT espVenDatos.espVenDatos, espVenDatos.VentaDatos_Id, espVenDatos.MercadoPago_Id, espVenDatos.CondPagoCli_Id,
	espVenDatos.VentaDatos_Id VentaDatos_Id_Nueva, espVenDatos.Empresa_Id, Cast( Case When espVenDatos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, espVenDatos.Fecha,
	espVenDatos.Moneda_Id, espVenDatos.Dato, espVenDatos.Descripcion, espVenDatos.Inactivo,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, espVenDatos.Posteado
FROM espVenDatos 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = espVenDatos.Usuario_Id)
WHERE (VentaDatos_Id = @pVentaDatos_Id)
 


 Declare @pidentity bigint= dbo.FuncFKespVenDatos(@pVentaDatos_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'espVenDatos'
RETURN @@Error 

GO

DROP PROCEDURE espVenDatosEliminar
GO
CREATE PROCEDURE espVenDatosEliminar
(
@pVentaDatos_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espVenDatos 
WHERE (VentaDatos_Id = @pVentaDatos_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKespVenDatos
GO

CREATE FUNCTION FuncFKespVenDatos
(
@pVentaDatos_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = espVenDatos FROM espVenDatos WHERE 
	VentaDatos_Id = @pVentaDatos_Id
  RETURN @pIdentity
END


GO
