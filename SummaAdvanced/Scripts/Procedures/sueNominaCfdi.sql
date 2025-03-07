DROP PROCEDURE sueNominaCfdiGuardar
GO
CREATE PROCEDURE sueNominaCfdiGuardar
(
@pFolio int,
@psueLiquidacion bigint,
@pLegajo int,
@pSelloDigital varchar(max) = NULL,
@pXml varchar(max) = NULL,
@pNoCertificado varchar(20),
@pUUID varchar(36) = NULL,
@pFechaTimbrado varchar(19) = NULL,
@pSelloSat varchar(max) = NULL,
@pnoCertificadoSAT varchar(20) = NULL,
@pFecha varchar(20),
@pAnulada Sino,
@pRfcProvCertif varchar(12) = NULL,
@pLeyenda varchar(150) = NULL
)
AS
SET NOCOUNT ON 
if (@pFolio != 0)

BEGIN 
	UPDATE sueNominaCfdi
	SET		sueLiquidacion = @psueLiquidacion,
		Legajo = dbo.FuncFKsuePersonal(@pLegajo),
		SelloDigital = @pSelloDigital,
		Xml = @pXml,
		NoCertificado = @pNoCertificado,
		UUID = @pUUID,
		FechaTimbrado = @pFechaTimbrado,
		SelloSat = @pSelloSat,
		noCertificadoSAT = @pnoCertificadoSAT,
		Fecha = @pFecha,
		Anulada = @pAnulada,
		RfcProvCertif = @pRfcProvCertif,
		Leyenda = @pLeyenda
	WHERE (Folio = @pFolio)
END 
ELSE 
BEGIN 
	SELECT @pFolio= ISNULL(MAX(Folio),0)+1 from sueNominaCfdi

	INSERT INTO sueNominaCfdi
	(
		Folio,
		sueLiquidacion,
		Legajo,
		SelloDigital,
		Xml,
		NoCertificado,
		UUID,
		FechaTimbrado,
		SelloSat,
		noCertificadoSAT,
		Fecha,
		Anulada,
		RfcProvCertif,
		Leyenda
	)
	VALUES 
	(
		@pFolio,
		@psueLiquidacion,
		dbo.FuncFKsuePersonal(@pLegajo),
		@pSelloDigital,
		@pXml,
		@pNoCertificado,
		@pUUID,
		@pFechaTimbrado,
		@pSelloSat,
		@pnoCertificadoSAT,
		@pFecha,
		@pAnulada,
		@pRfcProvCertif,
		@pLeyenda
	)
END 
SELECT @pFolio as RetVal
GO

DROP PROCEDURE sueNominaCfdiDatos
GO
CREATE PROCEDURE sueNominaCfdiDatos
(
@pFolio int
)
AS
SET NOCOUNT ON 

SELECT sueNominaCfdi.Folio, sueNominaCfdi.sueLiquidacion, sueLiquidacion.Descripcion as DescripcionLiquidacion, 
	suePersonal.Legajo, suePersonal.ApellidoPaterno+' '+suePersonal.ApellidoPaterno+' '+suePersonal.Nombres  as Nombre, 
	sueNominaCfdi.SelloDigital, sueNominaCfdi.Xml, sueNominaCfdi.NoCertificado,
	sueNominaCfdi.UUID, sueNominaCfdi.FechaTimbrado, sueNominaCfdi.SelloSat, sueNominaCfdi.noCertificadoSAT,
	sueNominaCfdi.Fecha, sueNominaCfdi.Anulada, sueNominaCfdi.RfcProvCertif, sueNominaCfdi.Leyenda
FROM sueNominaCfdi 
INNER JOIN sueLiquidacion  ON (sueLiquidacion.sueLiquidacion = sueNominaCfdi.sueLiquidacion)
INNER JOIN suePersonal  ON (suePersonal.genEntidades = sueNominaCfdi.Legajo)
WHERE (sueNominaCfdi.Folio = @pFolio)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueNominaCfdiCancelar
GO
CREATE PROCEDURE sueNominaCfdiCancelar
(
@pFolio int 
)
AS
SET NOCOUNT ON 

Update sueNominaCfdi  set Anulada = 1 , FechaCancelacion = dbo.FechaActual()
	WHERE (Folio = @pFolio)
 
 RETURN @@Error 

GO
-- sueNominasQueEmpleadosDatos 461060,0,9999,' ','zzz'
-- sueNominasQueEmpleadosDescargarDatos 461060,0,9999,'MXL','MXL'




DROP PROCEDURE sueNominasQueEmpleadosDatos
GO

CREATE PROCEDURE sueNominasQueEmpleadosDatos(
	@sueLiquidacion bigint, 
	@LegajoDesde int, 
	@LegajoHasta int, 
	@SucursalDesde varChar(4),
	@SucursalHasta varChar(4)
)
as

	SELECT suePersonal.Legajo
	from sueliquidacion inner join suePersonal ON 
		EXISTS(SELECT 1 From sueTerminada WHERE
			sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion And
			sueTerminada.Legajo = suePersonal.genEntidades)
		inner join suePersSucursal ON	suePersSucursal.Legajo = suePersonal.genEntidades and 
			 sueLiquidacion.FechaFinal BETWEEN  suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	where
		sueliquidacion.sueliquidacion = @sueLiquidacion AND 
		suePersonal.Legajo Between @LegajoDesde And @LegajoHasta and
		not exists(select 1 from sueNominaCfdi where
			sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
			sueNominaCfdi.Legajo = suePersonal.genEntidades and 
			sueNominaCfdi.Anulada = 0) and 
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
		
			ORDER BY 1
GO

DROP PROCEDURE sueNominasQueEmpleadosDescargarDatos
go
CREATE PROCEDURE sueNominasQueEmpleadosDescargarDatos(
	@sueLiquidacion bigint, 
	@LegajoDesde int, 
	@LegajoHasta int,
	@SucursalDesde varChar(4),
	@SucursalHasta varChar(4)
)
as

	SELECT suePersonal.Legajo, sueNominaCfdi.Folio, suePersonal.eMail
	from sueliquidacion inner join sueNominaCfdi on sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion 
			inner join suePersonal ON  sueNominaCfdi.Legajo = suePersonal.genEntidades 
			inner join suePersSucursal ON	suePersSucursal.Legajo = suePersonal.genEntidades and 
			 sueLiquidacion.FechaFinal BETWEEN  suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	where
		sueliquidacion.sueliquidacion = @sueLiquidacion AND 
		suePersonal.Legajo Between @LegajoDesde And @LegajoHasta and
		sueNominaCfdi.Anulada = 0 and 
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
			
GO

DROP PROCEDURE sueNominasQueEmpleadosCancelarSAT
go
CREATE PROCEDURE sueNominasQueEmpleadosCancelarSAT(
	@sueLiquidacion bigint, 
	@LegajoDesde int, 
	@LegajoHasta int,
	@SucursalDesde varChar(4),
	@SucursalHasta varChar(4)
)
as

	SELECT suePersonal.Legajo, sueNominaCfdi.Folio, suePersonal.eMail
	from sueliquidacion inner join sueNominaCfdi on sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion 
			inner join suePersonal ON  sueNominaCfdi.Legajo = suePersonal.genEntidades 
		inner join suePersSucursal ON	suePersSucursal.Legajo = suePersonal.genEntidades and 
		sueLiquidacion.FechaFinal BETWEEN  suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	where
		sueliquidacion.sueliquidacion = @sueLiquidacion AND 
		suePersonal.Legajo Between @LegajoDesde And @LegajoHasta and
		sueNominaCfdi.Anulada = 1 and
		sueNominaCfdi.FechaCancelacionSAT is null and
		sueNominaCfdi.FechaCancelacion is not null and
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
			
GO



DROP PROCEDURE sueNominaCfdiCancelarSAT
GO
CREATE PROCEDURE sueNominaCfdiCancelarSAT
(
@pFolio int,
@pRazonCancelacion varchar(20)
)
AS
SET NOCOUNT ON 

Update sueNominaCfdi  set FechaCancelacionSAT = dbo.FechaActual(),RazonCancelacion= @pRazonCancelacion
	WHERE (Folio = @pFolio)
 
 RETURN @@Error 

GO


DROP PROCEDURE sueNominaCfdiRelacinadoDatos
go
CREATE PROCEDURE sueNominaCfdiRelacinadoDatos(
	@sueLiquidacion bigint, 
	@Legajo int
)
as

	SELECT suePersonal.Legajo, sueNominaCfdi.Folio
	from sueliquidacion inner join sueNominaCfdi on sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion 
			inner join suePersonal ON  sueNominaCfdi.Legajo = suePersonal.genEntidades 
	where
		sueliquidacion.sueliquidacion = @sueLiquidacion AND 
		suePersonal.Legajo = @Legajo and
		sueNominaCfdi.Anulada = 0 and
		sueNominaCfdi.FechaCancelacion is null
			
GO