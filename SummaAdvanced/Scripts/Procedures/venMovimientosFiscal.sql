DROP PROCEDURE venMovimientosFiscalGuardar
GO
CREATE PROCEDURE venMovimientosFiscalGuardar
(
@pvenMovimientos bigint,
@pClaveFiscal varchar(36) = NULL,
@pFecha qFecha = NULL,
@pLetra char(1) = Null,
@pComprobante_Id int = Null,
@pEsFactElec Sino = NULL,
@pMotivo QMemo = NULL,
@pXMLFiscal text = NULL,
@pSelloDigital varchar(Max) = NULL,
@pFechaString varchar(20) = NULL,
@pSelloFiscal varchar(Max) = NULL,
@pNoCertificadoFiscal varchar(20) = NULL,
@pNoCertificadoPropio varchar(20) = Null,
@pFechaAutorizacion qFecha = NULL,
@pFechaDesde qFecha = Null,
@pNumeroDesde int = NULL,
@pNumeroHasta int = NULL, 
@pRfcProvCertif VarChar(13)=NULL,
@pLeyenda VarChar(50) = NULL, 
@pTipoProceso VarChar(10)= NULL,
@pTipoComite VarChar(18) = NULL,
@pidContabilidad Numeric(6,0) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovimientosFiscal WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovimientosFiscal
	SET		ClaveFiscal = @pClaveFiscal,
		Fecha = @pFecha,
		Letra = @pLetra,
		Comprobante_Id = @pComprobante_Id,
		EsFactElec = @pEsFactElec,
		Motivo = @pMotivo,
		XMLFiscal = @pXMLFiscal,
		SelloDigital = @pSelloDigital,
		FechaString = @pFechaString,
		SelloFiscal = @pSelloFiscal,
		NoCertificadoFiscal = @pNoCertificadoFiscal,
		NoCertificadoPropio = @pNoCertificadoPropio,
		FechaAutorizacion = @pFechaAutorizacion,
		FechaDesde = @pFechaDesde,
		NumeroDesde = @pNumeroDesde,
		NumeroHasta = @pNumeroHasta, 
		RfcProvCertif = @pRfcProvCertif,
		Leyenda = @pLeyenda,
		TipoProceso = @pTipoProceso,
		TipoComite = @pTipoComite,
		idContabilidad = @pidContabilidad
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosFiscal
	(
		venMovimientos,
		ClaveFiscal,
		Fecha,
		Letra,
		Comprobante_Id,
		EsFactElec,
		Motivo,
		XMLFiscal,
		SelloDigital,
		FechaString,
		SelloFiscal,
		NoCertificadoFiscal,
		NoCertificadoPropio,
		FechaAutorizacion,
		FechaDesde,
		NumeroDesde,
		NumeroHasta, 
		RfcProvCertif,
		Leyenda, 
		TipoProceso, 
		TipoComite,
		idContabilidad
	)
	VALUES 
	(
		@pvenMovimientos,
		@pClaveFiscal,
		@pFecha,
		@pLetra,
		@pComprobante_Id,
		@pEsFactElec,
		@pMotivo,
		@pXMLFiscal,
		@pSelloDigital,
		@pFechaString,
		@pSelloFiscal,
		@pNoCertificadoFiscal,
		@pNoCertificadoPropio,
		@pFechaAutorizacion,
		@pFechaDesde,
		@pNumeroDesde,
		@pNumeroHasta, 
		@pRfcProvCertif,
		@pLeyenda, 
		@pTipoProceso, 
		@pTipoComite,
		@pidContabilidad
	)
END 

GO

DROP PROCEDURE venMovimientosFiscalDatos
GO
CREATE PROCEDURE venMovimientosFiscalDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venMovimientosFiscal.venMovimientos, venMovimientosFiscal.ClaveFiscal, 
venMovimientosFiscal.Fecha, venMovimientosFiscal.Letra, venMovimientosFiscal.Comprobante_Id, genTiposCompAfip.Descripcion DescripcionTipoComp,
venMovimientosFiscal.EsFactElec, venMovimientosFiscal.Motivo, venMovimientosFiscal.XMLFiscal, 
venMovimientosFiscal.SelloDigital, venMovimientosFiscal.FechaString, venMovimientosFiscal.SelloFiscal, 
venMovimientosFiscal.NoCertificadoFiscal, venMovimientosFiscal.NoCertificadoPropio, venMovimientosFiscal.FechaAutorizacion, 
venMovimientosFiscal.FechaDesde, venMovimientosFiscal.NumeroDesde, venMovimientosFiscal.NumeroHasta, 
venMovimientosFiscal.RfcProvCertif,venMovimientosFiscal.Leyenda, venMovimientosFiscal.TipoProceso, 
venMovimientosFiscal.TipoComite,venMovimientosFiscal.idContabilidad
FROM venMovimientosFiscal
Left Join genTiposCompAfip On genTiposCompAfip.Comprobante_Id = venMovimientosFiscal.Comprobante_Id
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosFiscalEliminar
GO
CREATE PROCEDURE venMovimientosFiscalEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosFiscal 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO



DROP PROCEDURE venMovimientosFiscalActuAcuse
GO
CREATE PROCEDURE venMovimientosFiscalActuAcuse
(
@pvenMovimientos bigint,
@pAcuse VarChar(Max) 
)
AS
	UPDATE venMovimientosFiscal
	SET	Acuse = @pAcuse
	WHERE (venMovimientos = @pvenMovimientos)

GO
