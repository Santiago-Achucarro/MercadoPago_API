DROP PROCEDURE venMovImpTrasladoGuardar
GO
CREATE PROCEDURE venMovImpTrasladoGuardar
(
@pAsiento_Id bigint,
@pRenglonDebe int,
@pRenglonHaber int = NULL,
@pvenMovimientos bigint = NULL,
@ptesMovimientos bigint = NULL,
@pImpuesto_Id varchar(5),
@pCliente_Id varchar(15) = NULL,
@pCartera_Id varchar(5),
@pBanco_Id varchar(5) = NULL,
@pBaseImponible qMonedaD2,
@pMonto qMonedaD2,
@pTotalCobro qMonedaD2, 
@pDifCambio qMonedaD2, 
@pRenDifCambio Int = NULL
)
AS
SET NOCOUNT ON 
	INSERT INTO venMovImpTraslado
	(
		Asiento_Id,
		RenglonDebe,
		RenglonHaber,
		venMovimientos,
		tesMovimientos,
		Impuesto_Id,
		Cliente_Id,
		Cartera_Id,
		Banco_Id,
		BaseImponible,
		Monto,
		TotalCobro,
		DifCambio,
		RenDifCambio
	)
	VALUES 
	(
		@pAsiento_Id,
		@pRenglonDebe,
		@pRenglonHaber,
		@pvenMovimientos,
		@ptesMovimientos,
		dbo.FuncFKvenImpuestos(@pImpuesto_Id),
		dbo.FuncFKvenClientes(@pCliente_Id),
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		dbo.FuncFKtesIdentifica(@pBanco_Id),
		@pBaseImponible,
		@pMonto,
		@pTotalCobro,
		@pDifCambio,
		@pRenDifCambio
	)

GO

DROP PROCEDURE venMovImpTrasladoDatos
GO
CREATE PROCEDURE venMovImpTrasladoDatos
(
@pAsiento_Id bigint,
@pRenglonDebe int
)
AS
SET NOCOUNT ON 
SELECT @pAsiento_Id AS Asiento_Id, @pRenglonDebe as RenglonDebe

SELECT venMovImpTraslado.Asiento_Id, venMovImpTraslado.RenglonDebe, venMovImpTraslado.RenglonHaber, 
	venMovImpTraslado.venMovimientos, venMovImpTraslado.tesMovimientos, venImpuestos.Impuesto_Id,
	venImpuestos.Descripcion as DescripcionImpuestos, venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionClientes, 
	tesIdentifica.Cartera_Id, 	tesIdentifica.Descripcion as DescripcionIdentifica, 
	tesIdBancoPropio.Cartera_Id Banco_Id, tesIdBancoPropio.Descripcion as DescripcionIdBancoPropio, 
	venMovImpTraslado.BaseImponible, venMovImpTraslado.Monto, venMovImpTraslado.TotalCobro,
	venMovImpTraslado.DifCambio, venMovImpTraslado.RenDifCambio
FROM venMovImpTraslado 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = venMovImpTraslado.Asiento_Id)
--INNER JOIN conMovCont  ON (conMovCont.conAsientos = venMovImpTraslado.Asiento_Id) AND (conMovCont.Renglon = venMovImpTraslado.RenglonDebe)
--LEFT JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = venMovImpTraslado.Asiento_Id) AND (conMovCont2.Renglon = venMovImpTraslado.RenglonHaber)
LEFT JOIN venMovimientos  ON (venMovimientos.venMovimientos = venMovImpTraslado.venMovimientos)
LEFT JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = venMovImpTraslado.tesMovimientos)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venMovImpTraslado.Impuesto_Id)
LEFT JOIN venClientes  ON (venClientes.genEntidades = venMovImpTraslado.Cliente_Id)
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = venMovImpTraslado.Cartera_Id)
LEFT JOIN tesIdentifica tesIdBancoPropio  ON (tesIdBancoPropio.tesIdentifica = venMovImpTraslado.Banco_Id)
--LEFT JOIN conMovCont conMovContDC ON (conMovContDC.conAsientos = venMovImpTraslado.Asiento_Id) AND (conMovContDC.Renglon = venMovImpTraslado.RenglonDC)
WHERE (venMovImpTraslado.Asiento_Id = @pAsiento_Id)
AND (venMovImpTraslado.RenglonDebe = @pRenglonDebe)
 
RETURN @@Error 

GO

DROP PROCEDURE venMovImpTrasladoEliminar
GO
CREATE PROCEDURE venMovImpTrasladoEliminar
(
@pAsiento_Id bigint,
@pRenglonDebe int= NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMovImpTraslado WHERE (Asiento_Id = @pAsiento_Id) AND (RenglonDebe = ISNULL(@pRenglonDebe,RenglonDebe))
 
 RETURN @@Error 

GO



