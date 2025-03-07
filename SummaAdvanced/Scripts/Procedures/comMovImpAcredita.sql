DROP PROCEDURE comMovImpAcreditaGuardar
GO
CREATE PROCEDURE comMovImpAcreditaGuardar
(
@pAsiento_Id bigint,
@pRenglonDebe int,
@pRenglonHaber int = NULL,
@pcomMovProv bigint = NULL,
@ptesMovimientos bigint = NULL,
@pImpuesto_Id varchar(5),
@pCartera_Id varchar(5),
@pBaseImponible qMonedaD2,
@pMonto qMonedaD2,
@pTotalPago qMonedaD2,
@pOrigen char(1),
@pDifCambio qMonedaD2, 
@pRenDifCambio Int = NULL
)
AS
	INSERT INTO comMovImpAcredita
	(
		Asiento_Id,
		RenglonDebe,
		RenglonHaber,
		comMovProv,
		tesMovimientos,
		Impuesto_Id,
		Cartera_Id,
		BaseImponible,
		Monto,
		TotalPago,
		Origen,
		DifCambio,
		RenDifCambio
	)
	VALUES 
	(
		@pAsiento_Id,
		@pRenglonDebe,
		@pRenglonHaber,
		@pcomMovProv,
		@ptesMovimientos,
		dbo.FuncFKcomImpuestos(@pImpuesto_Id),
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pBaseImponible,
		@pMonto,
		@pTotalPago,
		@pOrigen,
		@pDifCambio,
		@pRenDifCambio
	)

GO

DROP PROCEDURE comMovImpAcreditaDatos
GO
CREATE PROCEDURE comMovImpAcreditaDatos
(
@pAsiento_Id bigint,
@pRenglonDebe int
)
AS
SET NOCOUNT ON 

SELECT comMovImpAcredita.Asiento_Id, comMovImpAcredita.RenglonDebe, 
	comMovImpAcredita.RenglonHaber,  comMovImpAcredita.comMovProv, 
	comMovImpAcredita.tesMovimientos, comImpuestos.Impuesto_Id, comImpuestos.Descripcion as DescripcionImpuestos,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdentifica, comMovImpAcredita.BaseImponible, comMovImpAcredita.Monto,
	comMovImpAcredita.TotalPago, comMovImpAcredita.Origen, comMovImpAcredita.DifCambio, 
	comMovImpAcredita.RenDifCambio
FROM comMovImpAcredita 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = comMovImpAcredita.Asiento_Id) AND (conMovCont.Renglon = comMovImpAcredita.RenglonDebe)
LEFT JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = comMovImpAcredita.Asiento_Id) AND (conMovCont2.Renglon = comMovImpAcredita.RenglonHaber)
LEFT JOIN comMovProv  ON (comMovProv.comMovProv = comMovImpAcredita.comMovProv)
LEFT JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = comMovImpAcredita.tesMovimientos)
INNER JOIN comImpuestos  ON (comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_Id)
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = comMovImpAcredita.Cartera_Id)
WHERE (comMovImpAcredita.Asiento_Id = @pAsiento_Id)
AND (comMovImpAcredita.RenglonDebe = @pRenglonDebe)
 
 RETURN @@Error 

GO

DROP PROCEDURE comMovImpAcreditaEliminar
GO
CREATE PROCEDURE comMovImpAcreditaEliminar
(
@pAsiento_Id bigint,
@pRenglonDebe int
)
AS
SET NOCOUNT ON 

DELETE FROM comMovImpAcredita 
WHERE (Asiento_Id = @pAsiento_Id)
AND (RenglonDebe = @pRenglonDebe)
 
RETURN @@Error 

GO


