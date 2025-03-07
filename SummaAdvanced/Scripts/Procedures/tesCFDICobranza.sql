DROP PROCEDURE tesCFDICobranzaGuardar
GO
CREATE PROCEDURE tesCFDICobranzaGuardar
(
@ptesCFDICobranza INT, 
@pCliente_Id varchar(25),
@pMoneda_Id varchar(3),
@pFecha datetime,
@pSelloDigital varchar(max),
@pXml varchar(max),
@pCadena varchar(max),
@pNoCertificado varchar(20),
@pUUID varchar(36),
@pFechaTimbrado varchar(19),
@pSelloSat varchar(max),
@pNoCertificadoSat varchar(20),
@pRfcProvCertif varchar(13) = NULL,
@pLeyenda varchar(max) = NULL,
@pAnulada char(1),
@pSucursal VarChar(25)
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM tesCFDICobranza WHERE tesCFDICobranza = @ptesCFDICobranza ))
BEGIN 
	UPDATE tesCFDICobranza
	SET		
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Fecha = @pFecha,
		SelloDigital = @pSelloDigital,
		Xml = @pXml,
		Cadena = @pCadena,
		NoCertificado = @pNoCertificado,
		UUID = @pUUID,
		FechaTimbrado = @pFechaTimbrado,
		SelloSat = @pSelloSat,
		NoCertificadoSat = @pNoCertificadoSat,
		RfcProvCertif = @pRfcProvCertif,
		Leyenda = @pLeyenda,
		Anulada = @pAnulada,
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)
	WHERE 
		tesCFDICobranza = @ptesCFDICobranza
END  
ELSE 
BEGIN 
	INSERT INTO tesCFDICobranza
	(
		Cliente_Id,
		Moneda_Id,
		Fecha,
		SelloDigital,
		Xml,
		Cadena,
		NoCertificado,
		UUID,
		FechaTimbrado,
		SelloSat,
		NoCertificadoSat,
		RfcProvCertif,
		Leyenda,
		Anulada,
		Sucursal
	)
	VALUES 
	(
		dbo.FuncFKvenClientes(@pCliente_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pFecha,
		@pSelloDigital,
		@pXml,
		@pCadena,
		@pNoCertificado,
		@pUUID,
		@pFechaTimbrado,
		@pSelloSat,
		@pNoCertificadoSat,
		@pRfcProvCertif,
		@pLeyenda,
		@pAnulada,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal)
	)
	SET @ptesCFDICobranza =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @ptesCFDICobranza as RetVal 

GO

DROP PROCEDURE tesCFDICobranzaDatos
GO
CREATE PROCEDURE tesCFDICobranzaDatos
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10),
	@pSegmento1N INT, 
	@pSegmento2N INT, 
	@pSegmento3N INT, 
	@pSegmento4N INT, 
	@pSegmento1C VarChar(20), 
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

SELECT tesCFDICobranza.tesCFDICobranza, 
	genSegmentos.Segmento_Id,  TesCFDICobranzaSegmentos.Segmento1N, TesCFDICobranzaSegmentos.Segmento2N,
	TesCFDICobranzaSegmentos.Segmento3N, TesCFDICobranzaSegmentos.Segmento4N,
	TesCFDICobranzaSegmentos.Segmento1C, TesCFDICobranzaSegmentos.Segmento2C,
	TesCFDICobranzaSegmentos.Segmento3C, TesCFDICobranzaSegmentos.Segmento4C,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	tesCFDICobranza.Fecha,	tesCFDICobranza.SelloDigital, tesCFDICobranza.Xml, 
	tesCFDICobranza.Cadena, tesCFDICobranza.NoCertificado,
	tesCFDICobranza.UUID, tesCFDICobranza.FechaTimbrado, tesCFDICobranza.SelloSat, 
	tesCFDICobranza.NoCertificadoSat,
	tesCFDICobranza.RfcProvCertif, tesCFDICobranza.Leyenda, tesCFDICobranza.Anulada, genSucursalesEmpr.Sucursal, 
	tesCFDICobranza.Motivo
FROM tesCFDICobranza 
INNER JOIN venClientes  ON (venClientes.genEntidades = tesCFDICobranza.Cliente_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesCFDICobranza.Moneda_Id)
INNER JOIN TesCFDICobranzaSegmentos ON
TesCFDICobranzaSegmentos.TesCFDICobranza =tesCFDICobranza.tesCFDICobranza 
INNER JOIN genSegmentos ON 
genSegmentos.genSegmentos =  TesCFDICobranzaSegmentos.Segmento_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = tesCFDICobranza.Sucursal
WHERE  
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N and 
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C 


 RETURN @@Error 

GO

DROP PROCEDURE tesCFDICobranzaEliminar
GO
CREATE PROCEDURE tesCFDICobranzaEliminar
(
	@ptesCFDICobranza INT, 
	@pAnulada Char(1), 
	@pMotivo VarChar(2)
)
AS
SET NOCOUNT ON 

UPDATE tesCFDICobranza  SET Anulada = @pAnulada, 
	Motivo = @pMotivo WHERE tesCFDICobranza =  @ptesCFDICobranza 

RETURN @@Error 

GO




DROP PROCEDURE tesCFDICobranzaDatosInt
GO
CREATE PROCEDURE tesCFDICobranzaDatosInt
(
	@ptesCFDICobranza Int
)
AS
SET NOCOUNT ON 

SELECT tesCFDICobranza.tesCFDICobranza, 
	genSegmentos.Segmento_Id,  TesCFDICobranzaSegmentos.Segmento1N, TesCFDICobranzaSegmentos.Segmento2N,
	TesCFDICobranzaSegmentos.Segmento3N, TesCFDICobranzaSegmentos.Segmento4N,
	TesCFDICobranzaSegmentos.Segmento1C, TesCFDICobranzaSegmentos.Segmento2C,
	TesCFDICobranzaSegmentos.Segmento3C, TesCFDICobranzaSegmentos.Segmento4C,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	tesCFDICobranza.Fecha,	tesCFDICobranza.SelloDigital, tesCFDICobranza.Xml, 
	tesCFDICobranza.Cadena, tesCFDICobranza.NoCertificado,
	tesCFDICobranza.UUID, tesCFDICobranza.FechaTimbrado, tesCFDICobranza.SelloSat, 
	tesCFDICobranza.NoCertificadoSat,
	tesCFDICobranza.RfcProvCertif, tesCFDICobranza.Leyenda, tesCFDICobranza.Anulada, genSucursalesEmpr.Sucursal, 
	tesCFDICobranza.Motivo
FROM tesCFDICobranza 
INNER JOIN venClientes  ON (venClientes.genEntidades = tesCFDICobranza.Cliente_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesCFDICobranza.Moneda_Id)
INNER JOIN TesCFDICobranzaSegmentos ON
TesCFDICobranzaSegmentos.TesCFDICobranza =tesCFDICobranza.tesCFDICobranza 
INNER JOIN genSegmentos ON 
genSegmentos.genSegmentos =  TesCFDICobranzaSegmentos.Segmento_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = tesCFDICobranza.Sucursal
WHERE  
	tesCFDICobranza.tesCFDICobranza = @ptesCFDICobranza


 RETURN @@Error 

GO






DROP PROCEDURE  tesCFDICobranzaCancelarSAT
GO
CREATE PROCEDURE  tesCFDICobranzaCancelarSAT
(
	@ptesCFDICobranza INT, 
@pRazonCancelacion varchar(20)
)
AS
SET NOCOUNT ON 

Update  tesCFDICobranza  set FechaCancelacionSAT = dbo.FechaActual(),RazonCancelacion= @pRazonCancelacion
	WHERE (tesCFDICobranza = 	@ptesCFDICobranza)
 
 RETURN @@Error 

GO



   
DROP PROCEDURE  tesCFDICobranzaRelacinadoDatos
go
CREATE PROCEDURE  tesCFDICobranzaRelacinadoDatos(
	@ptesCFDICobranza bigint
)
as

	SELECT tesCFDICobranza.tesCFDICobranza
	from vtesCobranzas inner join tesCFDICobranza on tesCFDICobranza.tesCFDICobranza = vtesCobranzas.tesMovimientos 
			where
		vtesCobranzas.tesMovimientos= @ptesCFDICobranza and
		tesCFDICobranza.Anulada = 0 and
		tesCFDICobranza.FechaCancelacion is null
			
GO