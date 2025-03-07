DROP PROCEDURE venImpuestosGuardar
GO
CREATE PROCEDURE venImpuestosGuardar
(
@pImpuesto_id varchar(5),
@pImpuesto_id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pTipoImpuesto int = NULL,
@pCodigoFiscal varchar(20) = NULL,
@pUsaFormula bit,
@pFormulacalc varchar(max),
@pPorcentaje qPorcentaje,
@pFecha_Desde datetime,
@pFecha_Hasta datetime,
@pDepende_de varchar(3),
@pPorVencimiento bit,
@pCtaReversion varchar(25) = NULL,
@pCuenta_id varchar(25) = NULL,
@pCtaDifCambio varchar(25) = NULL,
@pImpuestoXProducto Sino,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venImpuestos WHERE (Impuesto_id = @pImpuesto_id)))
BEGIN 
	UPDATE venImpuestos
	SET		@lIdentidad = venImpuestos,
		Impuesto_id = @pImpuesto_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		TipoImpuesto = @pTipoImpuesto,
		CodigoFiscal = @pCodigoFiscal,
		UsaFormula = @pUsaFormula,
		Formulacalc = @pFormulacalc,
		Porcentaje = @pPorcentaje,
		Fecha_Desde = @pFecha_Desde,
		Fecha_Hasta = @pFecha_Hasta,
		Depende_de = @pDepende_de,
		PorVencimiento = @pPorVencimiento,
		CtaReversion = dbo.FuncFKconCuentas(@pCtaReversion),
		Cuenta_id = dbo.FuncFKconCuentas(@pCuenta_id),
		CtaDifCambio = dbo.FuncFKconCuentas(@pCtaDifCambio),
		ImpuestoXProducto = @pImpuestoXProducto,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Impuesto_id = @pImpuesto_id)
END 
ELSE 
BEGIN 
	INSERT INTO venImpuestos
	(
		Impuesto_id,
		Empresa_Id,
		Descripcion,
		TipoImpuesto,
		CodigoFiscal,
		UsaFormula,
		Formulacalc,
		Porcentaje,
		Fecha_Desde,
		Fecha_Hasta,
		Depende_de,
		PorVencimiento,
		CtaReversion,
		Cuenta_id,
		CtaDifCambio,
		ImpuestoXProducto,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pImpuesto_id,
		@pEmpresa_Id,
		@pDescripcion,
		@pTipoImpuesto,
		@pCodigoFiscal,
		@pUsaFormula,
		@pFormulacalc,
		@pPorcentaje,
		@pFecha_Desde,
		@pFecha_Hasta,
		@pDepende_de,
		@pPorVencimiento,
		dbo.FuncFKconCuentas(@pCtaReversion),
		dbo.FuncFKconCuentas(@pCuenta_id),
		dbo.FuncFKconCuentas(@pCtaDifCambio),
		@pImpuestoXProducto,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venImpuestosDatos
GO
CREATE PROCEDURE venImpuestosDatos
(
@pImpuesto_id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venImpuestos.venImpuestos, venImpuestos.Impuesto_Id, venImpuestos.Empresa_Id, 
Cast( Case When venImpuestos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venImpuestos.Descripcion, venImpuestos.TipoImpuesto, impTipoImpuesto.Descripcion as DescripcionTipoImpuesto, 
	venImpuestos.CodigoFiscal,	venImpuestos.UsaFormula, venImpuestos.Formulacalc, venImpuestos.Porcentaje, venImpuestos.Fecha_Desde,
	venImpuestos.Fecha_Hasta, venImpuestos.Depende_de, 
	venImpuestos.PorVencimiento, 
	CtaReversion.Cuenta_Id AS CtaReversion, CtaReversion.Descripcion as DescripcionCtaReversion, 
	conCuentas.Cuenta_Id, 	conCuentas.Descripcion as DescripcionCuentas, 
	CtaDifCambio.Cuenta_Id as CtaDifCambio, CtaDifCambio.Descripcion as DescripcionCtaDifCambio, 
	venImpuestos.Inactivo, venImpuestos.ImpuestoXProducto, genUsuarios.Usuario_Id, 
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venImpuestos.Posteado
FROM venImpuestos 
LEFT JOIN impTipoImpuesto  ON (impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto)
LEFT JOIN conCuentas AS CtaReversion  ON (CtaReversion.conCuentas = venImpuestos.CtaReversion)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = venImpuestos.Cuenta_id)
LEFT JOIN conCuentas CtaDifCambio ON (CtaDifCambio.conCuentas = venImpuestos.CtaDifCambio)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venImpuestos.Usuario_Id)
WHERE (Impuesto_id = @pImpuesto_id)
 


 Declare @pidentity bigint= dbo.FuncFKvenImpuestos(@pImpuesto_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venImpuestos'
 RETURN @@Error 

GO

DROP PROCEDURE venImpuestosEliminar
GO
CREATE PROCEDURE venImpuestosEliminar
(
@pImpuesto_id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venImpuestos 
WHERE (Impuesto_id = @pImpuesto_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenImpuestos
GO

CREATE FUNCTION FuncFKvenImpuestos
(
@pImpuesto_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venImpuestos FROM venImpuestos WHERE 
	Impuesto_id = @pImpuesto_id
  RETURN @pIdentity
END


GO
