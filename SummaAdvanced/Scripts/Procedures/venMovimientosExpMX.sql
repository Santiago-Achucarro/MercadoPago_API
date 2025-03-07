DROP PROCEDURE venMovimientosExpMXGuardar
GO
CREATE PROCEDURE venMovimientosExpMXGuardar
(
@pvenMovimientos bigint,
@pMotivo_id varchar(2) = NULL,
@pTipoOperacion char(1),
@pClaveDePedimento char(2),
@pCertificadoOrigen int,
@pNumCertificadoOrigen varchar(40) = NULL,
@pNumeroExportadorConfiable varchar(50) = NULL,
@pSubdivision int,
@pObservaciones varchar(300) = NULL,
@pTipoCambioUSD numeric(18,4) = NULL,
@pTotalUSD numeric(18,4) = NULL,
@pUsaProv Sino,
@pPropNumRegIdTrib varchar(40) = NULL,
@pPropResidenciaFiscal char(3) = NULL,
@pReceptorNumRegIdTrib varchar(40) = NULL,
@pDestinatario_id VarChar(15) = NULL,
@pSucursalDest int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovimientosExpMX WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovimientosExpMX
	SET		Motivo_id = @pMotivo_id,
		TipoOperacion = @pTipoOperacion,
		ClaveDePedimento = @pClaveDePedimento,
		CertificadoOrigen = @pCertificadoOrigen,
		NumCertificadoOrigen = @pNumCertificadoOrigen,
		NumeroExportadorConfiable = @pNumeroExportadorConfiable,
		Subdivision = @pSubdivision,
		Observaciones = @pObservaciones,
		TipoCambioUSD = @pTipoCambioUSD,
		TotalUSD = @pTotalUSD,
		UsaProv = @pUsaProv,
		PropNumRegIdTrib = @pPropNumRegIdTrib,
		PropResidenciaFiscal = @pPropResidenciaFiscal,
		ReceptorNumRegIdTrib = @pReceptorNumRegIdTrib,
		Destinatario_id = dbo.FuncFKvenClientes(@pDestinatario_id),
		SucursalDest = @pSucursalDest
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosExpMX
	(
		venMovimientos,
		Motivo_id,
		TipoOperacion,
		ClaveDePedimento,
		CertificadoOrigen,
		NumCertificadoOrigen,
		NumeroExportadorConfiable,
		Subdivision,
		Observaciones,
		TipoCambioUSD,
		TotalUSD,
		UsaProv,
		PropNumRegIdTrib,
		PropResidenciaFiscal,
		ReceptorNumRegIdTrib,
		Destinatario_id,
		SucursalDest
	)
	VALUES 
	(
		@pvenMovimientos,
		@pMotivo_id,
		@pTipoOperacion,
		@pClaveDePedimento,
		@pCertificadoOrigen,
		@pNumCertificadoOrigen,
		@pNumeroExportadorConfiable,
		@pSubdivision,
		@pObservaciones,
		@pTipoCambioUSD,
		@pTotalUSD,
		@pUsaProv,
		@pPropNumRegIdTrib,
		@pPropResidenciaFiscal,
		@pReceptorNumRegIdTrib,
		dbo.FuncFKvenClientes(@pDestinatario_id),
		@pSucursalDest
	)
END 

GO

DROP PROCEDURE venMovimientosExpMXDatos
GO
CREATE PROCEDURE venMovimientosExpMXDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venMovimientosExpMX.venMovimientos, venMovimientosExpMX.Motivo_id, venMovimientosExpMX.TipoOperacion, venMovimientosExpMX.ClaveDePedimento,
	venMovimientosExpMX.CertificadoOrigen, venMovimientosExpMX.NumCertificadoOrigen, venMovimientosExpMX.NumeroExportadorConfiable, venMovimientosExpMX.Subdivision,
	venMovimientosExpMX.Observaciones, venMovimientosExpMX.TipoCambioUSD, venMovimientosExpMX.TotalUSD, venMovimientosExpMX.UsaProv,
	venMovimientosExpMX.PropNumRegIdTrib, venMovimientosExpMX.PropResidenciaFiscal, venMovimientosExpMX.ReceptorNumRegIdTrib, 
	venClientes.Cliente_Id as Destinatario_id,
	venMovimientosExpMX.SucursalDest
FROM venMovimientosExpMX 
left join venClientes ON 
venClientes.genentidades = venMovimientosExpMX.Destinatario_Id
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosExpMXEliminar
GO
CREATE PROCEDURE venMovimientosExpMXEliminar
(
@pvenMovimientos bigint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosExpMX 
WHERE (venMovimientos = ISNULL(@pvenMovimientos, venMovimientos))
 
 RETURN @@Error 

GO

GO
