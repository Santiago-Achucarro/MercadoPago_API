-- stkCondFisVentaDatos 'VF'
DROP PROCEDURE stkCondFisVentaGuardar
GO
CREATE PROCEDURE stkCondFisVentaGuardar
(
@pCFVenta_Id varchar(5),
@pCFVenta_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkCondFisVenta WHERE (CFVenta_Id = @pCFVenta_Id)))
BEGIN 
	UPDATE stkCondFisVenta
	SET		@lIdentidad = stkCondFisVenta,
		CFVenta_Id = @pCFVenta_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (CFVenta_Id = @pCFVenta_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkCondFisVenta
	(
		CFVenta_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCFVenta_Id,
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

DROP PROCEDURE stkCondFisVentaDatos
GO
CREATE PROCEDURE stkCondFisVentaDatos
(
@pCFVenta_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT stkCondFisVenta.stkCondFisVenta, stkCondFisVenta.CFVenta_Id, stkCondFisVenta.Empresa_Id, 
	dbo.PTodasEmpresas(stkCondFisVenta.Empresa_Id) as PTodasEmpresas,
	stkCondFisVenta.Descripcion,
	stkCondFisVenta.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, stkCondFisVenta.Posteado
FROM stkCondFisVenta 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkCondFisVenta.Usuario_Id)
WHERE (CFVenta_Id = @pCFVenta_Id)

SELECT venImpuestos.Impuesto_Id, venImpuestos.Descripcion, venImpuestos.CodigoFiscal, venImpuestos.UsaFormula,
venImpuestos.FormulaCalc, venImpuestos.Porcentaje, venImpuestos.Fecha_Desde, venImpuestos.Fecha_Hasta,
venImpuestos.Depende_De, venImpuestos.PorVencimiento, venImpuestos.CtaReversion, venImpuestos.Cuenta_Id,
venImpuestos.CtaDifCambio, venImpuestos.Inactivo, impTipoImpuesto.CodigoFiscal CodigoFiscalTipo, impTipoImpuesto.Juris_Id,
impTipoImpuesto.Dominio_Id, impTipoImpuesto.Referencia01, impTipoImpuesto.Referencia02, impTipoImpuesto.Referencia03,
impTipoImpuesto.Referencia04, impTipoImpuesto.Referencia05, impTipoImpuesto.Referencia06, impTipoImpuesto.Referencia07,
impTipoImpuesto.Referencia08, impTipoImpuesto.Referencia09, impTipoImpuesto.Referencia10
FROM stkCFVenImp 
INNER JOIN stkCondFisVenta  ON (stkCondFisVenta.stkCondFisVenta = stkCFVenImp.CFVenta_Id)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = stkCFVenImp.Impuesto_Id)
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE (stkCondFisVenta.CFVenta_Id = @pCFVenta_Id)
order by 1
 
 
 Declare @pidentity bigint= dbo.FuncFKstkCondFisVenta(@pCFVenta_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkCondFisVenta'
 
 RETURN @@Error 

GO

DROP PROCEDURE stkCondFisVentaEliminar
GO
CREATE PROCEDURE stkCondFisVentaEliminar
(
@pCFVenta_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkCondFisVenta 
WHERE (CFVenta_Id = @pCFVenta_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkCondFisVenta
GO

CREATE FUNCTION FuncFKstkCondFisVenta
(
@pCFVenta_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkCondFisVenta FROM stkCondFisVenta WHERE 
	CFVenta_Id = @pCFVenta_Id
  RETURN @pIdentity
END


GO
