DROP PROCEDURE venCondFiscalGuardar
GO
CREATE PROCEDURE venCondFiscalGuardar
(
@pCondFisc_id varchar(5),
@pCondFisc_id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pLetra char(1),
@pAplicaFactCredito bit,
@pLetra_Rf char(1),
@pDiscrimina bit,
@pFacturaElectronica bit,
@pCodigoFiscal varchar(3) = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venCondFiscal WHERE (CondFisc_id = @pCondFisc_id)))
BEGIN 
	UPDATE venCondFiscal
	SET		@lIdentidad = venCondFiscal,
		CondFisc_id = @pCondFisc_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Letra = @pLetra,
		AplicaFactCredito = @pAplicaFactCredito,
		Letra_Rf = @pLetra_Rf,
		Discrimina = @pDiscrimina,
		FacturaElectronica = @pFacturaElectronica,
		CodigoFiscal = @pCodigoFiscal,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (CondFisc_id = @pCondFisc_id)
END 
ELSE 
BEGIN 
	INSERT INTO venCondFiscal
	(
		CondFisc_id,
		Empresa_Id,
		Descripcion,
		Letra,
		AplicaFactCredito,
		Letra_Rf,
		Discrimina,
		FacturaElectronica,
		CodigoFiscal,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCondFisc_id,
		@pEmpresa_Id,
		@pDescripcion,
		@pLetra,
		@pAplicaFactCredito,
		@pLetra_Rf,
		@pDiscrimina,
		@pFacturaElectronica,
		@pCodigoFiscal,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venCondFiscalDatos
GO
CREATE PROCEDURE venCondFiscalDatos
(
@pCondFisc_id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venCondFiscal.venCondFiscal, venCondFiscal.CondFisc_Id, venCondFiscal.Empresa_Id, 
Cast( Case When venCondFiscal.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venCondFiscal.Descripcion, venCondFiscal.Letra, venCondFiscal.AplicaFactCredito, venCondFiscal.Letra_Rf,
	venCondFiscal.Discrimina, venCondFiscal.FacturaElectronica, venCondFiscal.CodigoFiscal, venCondFiscal.Inactivo,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCondFiscal.Posteado
FROM venCondFiscal 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCondFiscal.Usuario_Id)
WHERE (venCondFiscal.CondFisc_id = @pCondFisc_id)
 


 Declare @pidentity bigint= dbo.FuncFKvenCondFiscal(@pCondFisc_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCondFiscal'
 
SELECT venImpuestos.Impuesto_Id, venImpuestos.Descripcion, venImpuestos.CodigoFiscal, venImpuestos.UsaFormula,
venImpuestos.FormulaCalc, venImpuestos.Porcentaje, venImpuestos.Fecha_Desde, venImpuestos.Fecha_Hasta,
venImpuestos.Depende_De, venImpuestos.PorVencimiento, CtaReversion.Cuenta_Id CtaReversion, conCuentas.Cuenta_Id,
CtaDifCambio.Cuenta_Id CtaDifCambio, venImpuestos.Inactivo, venImpuestos.ImpuestoXProducto,
impTipoImpuesto.CodigoFiscal CodigoFiscalTipo, impTipoImpuesto.Juris_Id,
impTipoImpuesto.Dominio_id, impTipoImpuesto.Referencia01, impTipoImpuesto.Referencia02, impTipoImpuesto.Referencia03,
impTipoImpuesto.Referencia04, impTipoImpuesto.Referencia05, impTipoImpuesto.Referencia06, impTipoImpuesto.Referencia07,
impTipoImpuesto.Referencia08, impTipoImpuesto.Referencia09, impTipoImpuesto.Referencia10
  FROM venCondFiscImp 
  INNER JOIN venCondFiscal ON venCondFiscImp.venCondFiscal = venCondFiscal.venCondFiscal
	Inner join venImpuestos ON venCondFiscImp.venImpuestos = venImpuestos.venImpuestos
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
	Left Outer Join conCuentas On conCuentas.conCuentas = venImpuestos.Cuenta_Id
	Left Outer Join conCuentas CtaReversion On CtaReversion.conCuentas = venImpuestos.CtaReversion
	Left Outer Join conCuentas CtaDifCambio On CtaDifCambio.conCuentas = venImpuestos.CtaDifCambio
 WHERE
	venCondFiscal.CondFisc_id = @pCondFisc_id
	
 RETURN @@Error 

GO

DROP PROCEDURE venCondFiscalEliminar
GO
CREATE PROCEDURE venCondFiscalEliminar
(
@pCondFisc_id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCondFiscal 
WHERE (CondFisc_id = @pCondFisc_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenCondFiscal
GO

CREATE FUNCTION FuncFKvenCondFiscal
(
@pCondFisc_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venCondFiscal FROM venCondFiscal WHERE 
	CondFisc_id = @pCondFisc_id
  RETURN @pIdentity
END


GO
