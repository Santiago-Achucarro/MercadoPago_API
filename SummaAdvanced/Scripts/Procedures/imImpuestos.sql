DROP PROCEDURE impImpuestosGuardar
GO
CREATE PROCEDURE impImpuestosGuardar
(
@pImpuesto_Id varchar(5),
@pDescripcion varchar(60),
@pPosteado Sino,
@pInactivo Sino,
@pTipoVencimiento varchar(3),
@pDiaMesVence smallint,
@pAvisarNDias smallint,
@pProximoVencimiento qFecha,
@pCtaHaber_Id varchar(25) = NULL,
@pCtaDebe_Id varchar(25) = NULL,
@pPagoAnticipado Sino,
@pSePaga Sino,
@pVaAlCashFlow Sino,
@pLiquidadoHasta qFecha
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM impImpuestos WHERE Impuesto_Id = @pImpuesto_Id))
BEGIN 
	UPDATE impImpuestos
	SET		@lIdentidad = impImpuestos,
		Impuesto_Id = @pImpuesto_Id,
		Descripcion = @pDescripcion,
		Posteado = @pPosteado,
		Inactivo = @pInactivo,
		TipoVencimiento = @pTipoVencimiento,
		DiaMesVence = @pDiaMesVence,
		AvisarNDias = @pAvisarNDias,
		ProximoVencimiento = @pProximoVencimiento,
		CtaHaber_Id = dbo.FuncFKconCuentas(@pCtaHaber_Id),
		CtaDebe_Id = dbo.FuncFKconCuentas(@pCtaDebe_Id),
		PagoAnticipado = @pPagoAnticipado,
		SePaga = @pSePaga,
		VaAlCashFlow = @pVaAlCashFlow,
		LiquidadoHasta = @pLiquidadoHasta
	WHERE 
	Impuesto_Id = @pImpuesto_Id
END 
ELSE 
BEGIN 
	INSERT INTO impImpuestos
	(
		Impuesto_Id,
		Descripcion,
		Posteado,
		Inactivo,
		TipoVencimiento,
		DiaMesVence,
		AvisarNDias,
		ProximoVencimiento,
		CtaHaber_Id,
		CtaDebe_Id,
		PagoAnticipado,
		SePaga,
		VaAlCashFlow,
		LiquidadoHasta
	)
	VALUES 
	(
		@pImpuesto_Id,
		@pDescripcion,
		@pPosteado,
		@pInactivo,
		@pTipoVencimiento,
		@pDiaMesVence,
		@pAvisarNDias,
		@pProximoVencimiento,
		dbo.FuncFKconCuentas(@pCtaHaber_Id),
		dbo.FuncFKconCuentas(@pCtaDebe_Id),
		@pPagoAnticipado,
		@pSePaga,
		@pVaAlCashFlow,
		@pLiquidadoHasta
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE impImpuestosDatos
GO
CREATE PROCEDURE impImpuestosDatos
(
@pImpuesto_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT impImpuestos.impImpuestos, impImpuestos.Impuesto_Id, impImpuestos.Impuesto_Id as Impuesto_Id_Nueva, impImpuestos.Descripcion, impImpuestos.Posteado,
	impImpuestos.Inactivo, impImpuestos.TipoVencimiento, impImpuestos.DiaMesVence, impImpuestos.AvisarNDias,
	impImpuestos.ProximoVencimiento, CuentaHaber.Cuenta_Id as CuentaHaber , CuentaHaber.Descripcion as DescripcionCuentaHaber, CuentaDebe.Cuenta_Id as CuentaDebe,
	CuentaDebe.Descripcion as DescripcionCuentaDebe, impImpuestos.PagoAnticipado, impImpuestos.SePaga, impImpuestos.VaAlCashFlow,
	impImpuestos.LiquidadoHasta
FROM impImpuestos 
LEFT JOIN conCuentas CuentaHaber ON (CuentaHaber.conCuentas = impImpuestos.CtaHaber_Id)
LEFT JOIN conCuentas CuentaDebe ON (CuentaDebe.conCuentas = impImpuestos.CtaDebe_Id)
WHERE 

Impuesto_Id = @pImpuesto_Id




SELECT impImpuestos.Impuesto_Id, impImpuestos.Descripcion as DescripcionImpuestos, impFormulas.Renglon, conCuentas.Cuenta_Id, 
conCuentas.Descripcion as DescripcionCuentas,
impFormulas.Detalle, impFormulas.DebeHaberAmbos
FROM impFormulas 
INNER JOIN impImpuestos  ON (impImpuestos.impImpuestos = impFormulas.impImpuestos)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = impFormulas.Cuenta_Id)
WHERE (impImpuestos.Impuesto_Id = @pImpuesto_Id)

 
 

Declare @pidentity bigint= dbo.FuncFKimpImpuestos( @pImpuesto_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'impImpuestos'




 RETURN @@Error 

GO

DROP PROCEDURE impImpuestosEliminar
GO
CREATE PROCEDURE impImpuestosEliminar
(
@pImpuesto_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM impImpuestos 
WHERE  Impuesto_Id = @pImpuesto_Id
 RETURN @@Error 

GO

DROP FUNCTION FuncFKimpImpuestos
GO

CREATE FUNCTION FuncFKimpImpuestos
(
@pImpuesto_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = impImpuestos FROM impImpuestos WHERE 
	Impuesto_Id = @pImpuesto_Id
  RETURN @pIdentity
END


GO