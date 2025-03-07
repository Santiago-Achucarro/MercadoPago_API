DROP PROCEDURE tesDepositoGuardar
GO
CREATE PROCEDURE tesDepositoGuardar
(
@ptesMovimientos bigint,
@pRenglon int,
@pFormaDePagoP char(2),
@pNumOperacion varchar(100) = NULL,
@pNomBancoOrdExt varchar(300) = NULL,
@pCtaOrdenante varchar(50) = NULL,
@pTipoCadPago varchar(2) = NULL,
@pCertPago varchar(max) = NULL,
@pCadPago varchar(max) = NULL,
@pSelloPago varchar(max) = NULL,
@pRfcEmisorCtaOrd varchar(13) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM TesDeposito WHERE (tesMovimientos = @ptesMovimientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE TesDeposito
	SET		FormaDePagoP = @pFormaDePagoP,
		NumOperacion = @pNumOperacion,
		NomBancoOrdExt = @pNomBancoOrdExt,
		CtaOrdenante = @pCtaOrdenante,
		TipoCadPago = @pTipoCadPago,
		CertPago = @pCertPago,
		CadPago = @pCadPago,
		SelloPago = @pSelloPago,
		RfcEmisorCtaOrd = @pRfcEmisorCtaOrd
	WHERE (tesMovimientos = @ptesMovimientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO TesDeposito
	(
		tesMovimientos,
		Renglon,
		FormaDePagoP,
		NumOperacion,
		NomBancoOrdExt,
		CtaOrdenante,
		TipoCadPago,
		CertPago,
		CadPago,
		SelloPago,
		RfcEmisorCtaOrd
	)
	VALUES 
	(
		@ptesMovimientos,
		@pRenglon,
		@pFormaDePagoP,
		@pNumOperacion,
		@pNomBancoOrdExt,
		@pCtaOrdenante,
		@pTipoCadPago,
		@pCertPago,
		@pCadPago,
		@pSelloPago,
		@pRfcEmisorCtaOrd
	)
END 

GO

DROP PROCEDURE tesDepositoDatos
GO
CREATE PROCEDURE tesDepositoDatos
(
@ptesMovimientos bigint,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT TesDeposito.tesMovimientos, TesDeposito.Renglon, TesDeposito.FormaDePagoP, TesDeposito.NumOperacion,
	TesDeposito.NomBancoOrdExt, TesDeposito.CtaOrdenante, TesDeposito.TipoCadPago, TesDeposito.CertPago,
	TesDeposito.CadPago, TesDeposito.SelloPago, TesDeposito.RfcEmisorCtaOrd
FROM TesDeposito 
WHERE (tesMovimientos = @ptesMovimientos)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesDepositoEliminar
GO
CREATE PROCEDURE tesDepositoEliminar
(
@ptesMovimientos bigint = NULL,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM TesDeposito 
WHERE (tesMovimientos = ISNULL(@ptesMovimientos, tesMovimientos))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
