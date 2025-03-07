DROP PROCEDURE impRetencionesCFDIGuardar
GO
CREATE PROCEDURE impRetencionesCFDIGuardar
(
@pFolio int,
@pSello varchar(max),
@pNumCert varchar(20),
@pFechaExp datetime,
@pCveRetenc varchar(2) = NULL,
@pDescRetenc varchar(100),
@pNacionalidad varchar(10),
@pRFC varchar(14),
@pRazonSocial varchar(300),
@pCURP char(18),
@pNroRegIdTrib char(20),
@pEjercicio int,
@pMesIni smallint,
@pMesFin smallint,
@pmontoTotOperacion numeric(18,4),
@pmontoTotGrav numeric(18,4),
@pmontoTotExent numeric(18,4),
@pmontoTotRet numeric(18,4),
@pCancelado bit,
@pFechaCancelacion datetime = NULL,
@pFechaTimbre varchar(19),
@pSelloSAT varchar(max),
@pNoCertificadoSAT varchar(20),
@pUUID char(36),
@pRfcProvCertif varchar(12) = NULL,
@pLeyenda varchar(150) = NULL, 
@pUsuario_Id Int, 
@pEmpresa_Id Int, 
@pXml Text,
@pCodPostal VarChar(5) = NULL,
@pUtilidadBimestral QMonedaD2 = NULL,
@pISRCorrespondiente QMonedaD2 = NULL

)
AS
SET NOCOUNT ON 
DECLARE @pidentity INT =(select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio)

	
IF (@pidentity  IS NOT NULL)

BEGIN 

	
	UPDATE impRetencionesCFDI
	SET		Sello = @pSello,
		NumCert = @pNumCert,
		FechaExp = @pFechaExp,
		CveRetenc = @pCveRetenc,
		DescRetenc = @pDescRetenc,
		Nacionalidad = @pNacionalidad,
		RFC = @pRFC,
		RazonSocial = @pRazonSocial,
		CURP = @pCURP,
		NroRegIdTrib = @pNroRegIdTrib,
		Ejercicio = @pEjercicio,
		MesIni = @pMesIni,
		MesFin = @pMesFin,
		montoTotOperacion = @pmontoTotOperacion,
		montoTotGrav = @pmontoTotGrav,
		montoTotExent = @pmontoTotExent,
		montoTotRet = @pmontoTotRet,
		Cancelado = @pCancelado,
		FechaCancelacion = @pFechaCancelacion,
		FechaTimbre = @pFechaTimbre,
		SelloSAT = @pSelloSAT,
		NoCertificadoSAT = @pNoCertificadoSAT,
		UUID = @pUUID,
		RfcProvCertif = @pRfcProvCertif,
		Leyenda = @pLeyenda, 
		Usuario_Id = @pUsuario_Id, 
		Empresa_Id = @pEmpresa_Id, 
		FechaRegistro = dbo.FechaActual(), 
		Xml = @pXml, 
		CodPostal = @pCodPostal, 
		UtilidadBimestral = @pUtilidadBimestral, 
		ISRCorrespondiente = @pISRCorrespondiente
	WHERE (Folio = @pFolio)
END 
ELSE 
BEGIN 

	SET @pFolio = 
		(SELECT ISNULL(MAX(Folio),0)+1 from impRetencionesCFDI)

	INSERT INTO impRetencionesCFDI
	(
		Folio,
		Sello,
		NumCert,
		FechaExp,
		CveRetenc,
		DescRetenc,
		Nacionalidad,
		RFC,
		RazonSocial,
		CURP,
		NroRegIdTrib,
		Ejercicio,
		MesIni,
		MesFin,
		montoTotOperacion,
		montoTotGrav,
		montoTotExent,
		montoTotRet,
		Cancelado,
		FechaCancelacion,
		FechaTimbre,
		SelloSAT,
		NoCertificadoSAT,
		UUID,
		RfcProvCertif,
		Leyenda, 
		Usuario_Id, 
		Empresa_Id,
		FechaRegistro, 
		Xml, 
		CodPostal, 
		UtilidadBimestral, 
		ISRCorrespondiente

	)
	VALUES 
	(
		@pFolio,
		@pSello,
		@pNumCert,
		@pFechaExp,
		@pCveRetenc,
		@pDescRetenc,
		@pNacionalidad,
		@pRFC,
		@pRazonSocial,
		@pCURP,
		@pNroRegIdTrib,
		@pEjercicio,
		@pMesIni,
		@pMesFin,
		@pmontoTotOperacion,
		@pmontoTotGrav,
		@pmontoTotExent,
		@pmontoTotRet,
		@pCancelado,
		@pFechaCancelacion,
		@pFechaTimbre,
		@pSelloSAT,
		@pNoCertificadoSAT,
		@pUUID,
		@pRfcProvCertif,
		@pLeyenda, 
		@pUsuario_Id, 
		@pEmpresa_Id, 
		dbo.FechaActual(), 
		@pXml, 
		@pCodPostal, 
		@pUtilidadBimestral, 
		@pISRCorrespondiente
	)
	SET @pidentity =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @pidentity as RetVal 

GO





DROP PROCEDURE impRetencionesCFDIDatos
GO
CREATE PROCEDURE impRetencionesCFDIDatos
(
@pFolio int, 
@pEmpresa_Id Int
)
AS

SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

SELECT impRetencionesCFDI.impRetencionesCFDI,
	impRetencionesCFDI.Folio, impRetencionesCFDI.Sello, impRetencionesCFDI.NumCert, impRetencionesCFDI.FechaExp,
	impRetencionesCFDI.CveRetenc, impRetencionesCFDI.DescRetenc, impRetencionesCFDI.Nacionalidad, impRetencionesCFDI.RFC,
	impRetencionesCFDI.RazonSocial, impRetencionesCFDI.CURP, impRetencionesCFDI.NroRegIdTrib, impRetencionesCFDI.Ejercicio,
	impRetencionesCFDI.MesIni, impRetencionesCFDI.MesFin, impRetencionesCFDI.montoTotOperacion, impRetencionesCFDI.montoTotGrav,
	impRetencionesCFDI.montoTotExent, impRetencionesCFDI.montoTotRet, impRetencionesCFDI.Cancelado, impRetencionesCFDI.FechaCancelacion,
	impRetencionesCFDI.FechaTimbre, impRetencionesCFDI.SelloSAT, impRetencionesCFDI.NoCertificadoSAT, impRetencionesCFDI.UUID,
	impRetencionesCFDI.RfcProvCertif, impRetencionesCFDI.Leyenda, impRetencionesCFDI.Xml, 
	impRetencionesCFDI.CodPostal, impRetencionesCFDI.UtilidadBimestral, impRetencionesCFDI.ISRCorrespondiente
FROM impRetencionesCFDI 
WHERE (Folio = @pFolio)
 

Exec impRetCFDIDetalleDatos   @pidentity

Exec impRetCFDIArrendaDatos  @pidentity

Exec impRetCFDIDividendosDatos @pidentity

Exec impRetCFDIEnajAccionDatos @pidentity

Exec impRetCFDIFiedeEmprDatos @pidentity

Exec impRetCFDIOperConDerivDatos @pidentity

Exec impRetCFDIPagosExtrDatos  @pidentity

Exec impRetCFDIPlanesRetDatos @pidentity

Exec impRetCFDIPremiosDatos @pidentity

Exec impRetCFDISecFinanDatos @pidentity

Exec impRetCFDIInteresesDatos @pidentity

 
RETURN @@Error 

GO

DROP PROCEDURE impRetencionesCFDIEliminar
GO
CREATE PROCEDURE impRetencionesCFDIEliminar
(
@pFolio int,
@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetencionesCFDI 
WHERE Folio = @pFolio and Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO


DROP PROCEDURE impRetencionesCFDICancelar
GO
CREATE PROCEDURE impRetencionesCFDICancelar
(
@pFolio int,
@pEmpresa_Id Int, 
@pUsuario_Id Int
)
AS
SET NOCOUNT ON 

Update impRetencionesCFDI  SET Cancelado = 1 , FechaCancelacion = dbo.FechaActual(), 
	Usuario_Id = @pUsuario_Id
	WHERE Folio = @pFolio and Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO


DROP PROCEDURE impRetencionesCFDIDatosInt
GO
CREATE PROCEDURE impRetencionesCFDIDatosInt
(
@pImpReteciones int
)
AS

DECLARE @pEmpresa_Id int
DECLARE @pFolio int

SELECT @pEmpresa_Id = Empresa_Id , @pFolio = Folio From impRetencionesCFDI WHERE
	impRetencionesCFDI = @pImpReteciones

exec impRetencionesCFDIDatos @pFolio, @pEmpresa_Id

GO
