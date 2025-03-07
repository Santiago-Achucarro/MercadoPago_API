DROP PROCEDURE venSubTipoMovGuardar
GO
CREATE PROCEDURE venSubTipoMovGuardar
(
@pSubTipoMov_Id varchar(5),
@pSubTipoMov_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pvenTipoMov char(1) = NULL,
@pDescripcion varchar(50),
@pMueveStock Sino,
@pEsVentaContado Sino,
@pAdmiteDevolucion Sino,
@pModificaPrecio Sino,
@pReservado Sino,
@pGeneraRemito Sino,
@pSegmentoRemito_Id varchar(10) = NULL,
@pNCxDevolucion Sino,
@pUsuarioAutorizado varchar(25) = NULL,
@pAdmiteBoniRenglon Sino,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pPideCambio Sino,
@pModFecha Sino,
@pModCondPago Sino,
@pModVendedor Sino,
@pModCobrador Sino,
@pPideObervaciones Sino,
@pCantidadCopias smallint,
@pModDeposito Sino,
@pModListaPrecios Sino,
@pPideFechaEntrega Sino,
@pPideObsReng Sino,
@pCtaDefecto varchar(25) = NULL,
@pModCtaDefecto Sino,
@pModCentro1 Sino,
@pModCentro2 Sino,
@pPideOtrosCargos Sino,
@pCtaOtrosCargos varchar(25) = NULL,
@pPermModCtaOtCar Sino,
@pFechaEntregaporRen Sino,
@pAdmiteFactsinEntr Sino,
@pModiUniMed Sino,
@pAfectaComVenta Sino,
@pAfectaComCobra Sino,
@pMaxCantItems smallint,
@pEsPorDifPrecio Sino,
@pAfectaEstadistica Sino,
@pClaveAcceso varchar(50),
@pEsPorDifCambio Sino,
@pTipoPrecioForm char(1),
@pSoloImpuestos Sino,
@pCodigoFormulario varchar(15) = NULL,
@pBajoCosto Sino,
@pAdministrativa Sino,
@pPideReferencia Sino,
@pPideOrdenCompra Sino,
@pPideCongelarCambio Sino,
@pPideMarcaReserva Sino,
@pPermiteSoloEntrega Sino,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino, 
@pPidePredial Sino,
@pPideCodProd SiNo, 
@pPideComExpoMX SiNo, 
@pCodigoFiscal VarChar(10)=NULL,
@pReporte_Id varchar(50)=null, 
@pEsquemaAuto_Id VarChar(10)= NULL, 
@pPorCotizacion SiNo, 
@pUsaCartaPorte Bit,
@pCodFormula int,
@pCFOtCargos_Id varchar(5)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venSubTipoMov WHERE (SubTipoMov_Id = @pSubTipoMov_Id)))
BEGIN 
	UPDATE venSubTipoMov
	SET		@lIdentidad = venSubTipoMov,
		SubTipoMov_Id = @pSubTipoMov_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		venTipoMov = @pvenTipoMov,
		Descripcion = @pDescripcion,
		MueveStock = @pMueveStock,
		EsVentaContado = @pEsVentaContado,
		AdmiteDevolucion = @pAdmiteDevolucion,
		ModificaPrecio = @pModificaPrecio,
		Reservado = @pReservado,
		GeneraRemito = @pGeneraRemito,
		SegmentoRemito_Id = dbo.FuncFKgenSegmentos(@pSegmentoRemito_Id),
		NCxDevolucion = @pNCxDevolucion,
		UsuarioAutorizado = dbo.FuncFKgenUsuarios(@pUsuarioAutorizado),
		AdmiteBoniRenglon = @pAdmiteBoniRenglon,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		PideCambio = @pPideCambio,
		ModFecha = @pModFecha,
		ModCondPago = @pModCondPago,
		ModVendedor = @pModVendedor,
		ModCobrador = @pModCobrador,
		PideObervaciones = @pPideObervaciones,
		CantidadCopias = @pCantidadCopias,
		ModDeposito = @pModDeposito,
		ModListaPrecios = @pModListaPrecios,
		PideFechaEntrega = @pPideFechaEntrega,
		PideObsReng = @pPideObsReng,
		CtaDefecto = dbo.FuncFKconCuentas(@pCtaDefecto),
		ModCtaDefecto = @pModCtaDefecto,
		ModCentro1 = @pModCentro1,
		ModCentro2 = @pModCentro2,
		PideOtrosCargos = @pPideOtrosCargos,
		CtaOtrosCargos = dbo.FuncFKconCuentas(@pCtaOtrosCargos),
		PermModCtaOtCar = @pPermModCtaOtCar,
		FechaEntregaporRen = @pFechaEntregaporRen,
		AdmiteFactsinEntr = @pAdmiteFactsinEntr,
		ModiUniMed = @pModiUniMed,
		AfectaComVenta = @pAfectaComVenta,
		AfectaComCobra = @pAfectaComCobra,
		MaxCantItems = @pMaxCantItems,
		EsPorDifPrecio = @pEsPorDifPrecio,
		AfectaEstadistica = @pAfectaEstadistica,
		ClaveAcceso = @pClaveAcceso,
		EsPorDifCambio = @pEsPorDifCambio,
		TipoPrecioForm = @pTipoPrecioForm,
		SoloImpuestos = @pSoloImpuestos,
		CodigoFormulario = @pCodigoFormulario,
		BajoCosto = @pBajoCosto,
		Administrativa = @pAdministrativa,
		PideReferencia = @pPideReferencia,
		PideOrdenCompra = @pPideOrdenCompra,
		PideCongelarCambio = @pPideCongelarCambio,
		PideMarcaReserva = @pPideMarcaReserva,
		PermiteSoloEntrega = @pPermiteSoloEntrega,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		PidePredial = @pPidePredial, PideCodProd = @pPideCodProd, 
		PideComExpoMX = @pPideComExpoMX, 
		CodigoFiscal = @pCodigoFiscal,
		Reporte_Id = dbo.FuncFKgenReportes(@pReporte_Id), 
		EsquemaAuto_Id = dbo.FuncfkvenEsquemaAuto(@pEsquemaAuto_Id), 
		PorCotizacion = @pPorCotizacion, 
		UsaCartaPorte = @pUsaCartaPorte,
		CodFormula = dbo.FuncFKvenOtcFormula(@pCodFormula),
		CFOtCargos_Id = dbo.FuncFKstkCondFisVenta(@pCFOtCargos_Id)
		
	WHERE (SubTipoMov_Id = @pSubTipoMov_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venSubTipoMov
	(
		SubTipoMov_Id,
		Empresa_Id,
		venTipoMov,
		Descripcion,
		MueveStock,
		EsVentaContado,
		AdmiteDevolucion,
		ModificaPrecio,
		Reservado,
		GeneraRemito,
		SegmentoRemito_Id,
		NCxDevolucion,
		UsuarioAutorizado,
		AdmiteBoniRenglon,
		Centro1_Id,
		Centro2_Id,
		PideCambio,
		ModFecha,
		ModCondPago,
		ModVendedor,
		ModCobrador,
		PideObervaciones,
		CantidadCopias,
		ModDeposito,
		ModListaPrecios,
		PideFechaEntrega,
		PideObsReng,
		CtaDefecto,
		ModCtaDefecto,
		ModCentro1,
		ModCentro2,
		PideOtrosCargos,
		CtaOtrosCargos,
		PermModCtaOtCar,
		FechaEntregaporRen,
		AdmiteFactsinEntr,
		ModiUniMed,
		AfectaComVenta,
		AfectaComCobra,
		MaxCantItems,
		EsPorDifPrecio,
		AfectaEstadistica,
		ClaveAcceso,
		EsPorDifCambio,
		TipoPrecioForm,
		SoloImpuestos,
		CodigoFormulario,
		BajoCosto,
		Administrativa,
		PideReferencia,
		PideOrdenCompra,
		PideCongelarCambio,
		PideMarcaReserva,
		PermiteSoloEntrega,
		Inactivo,
		Usuario_Id,
		Posteado,
		PidePredial, 
		PideCodProd, 
		PideComExpoMX,
		CodigoFiscal,
		Reporte_Id, 
		EsquemaAuto_Id, 
		PorCotizacion, 
		UsaCartaPorte,
		CodFormula,
		CFOtCargos_Id
	)
	VALUES 
	(
		@pSubTipoMov_Id,
		@pEmpresa_Id,
		@pvenTipoMov,
		@pDescripcion,
		@pMueveStock,
		@pEsVentaContado,
		@pAdmiteDevolucion,
		@pModificaPrecio,
		@pReservado,
		@pGeneraRemito,
		dbo.FuncFKgenSegmentos(@pSegmentoRemito_Id),
		@pNCxDevolucion,
		dbo.FuncFKgenUsuarios(@pUsuarioAutorizado),
		@pAdmiteBoniRenglon,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pPideCambio,
		@pModFecha,
		@pModCondPago,
		@pModVendedor,
		@pModCobrador,
		@pPideObervaciones,
		@pCantidadCopias,
		@pModDeposito,
		@pModListaPrecios,
		@pPideFechaEntrega,
		@pPideObsReng,
		dbo.FuncFKconCuentas(@pCtaDefecto),
		@pModCtaDefecto,
		@pModCentro1,
		@pModCentro2,
		@pPideOtrosCargos,
		dbo.FuncFKconCuentas(@pCtaOtrosCargos),
		@pPermModCtaOtCar,
		@pFechaEntregaporRen,
		@pAdmiteFactsinEntr,
		@pModiUniMed,
		@pAfectaComVenta,
		@pAfectaComCobra,
		@pMaxCantItems,
		@pEsPorDifPrecio,
		@pAfectaEstadistica,
		@pClaveAcceso,
		@pEsPorDifCambio,
		@pTipoPrecioForm,
		@pSoloImpuestos,
		@pCodigoFormulario,
		@pBajoCosto,
		@pAdministrativa,
		@pPideReferencia,
		@pPideOrdenCompra,
		@pPideCongelarCambio,
		@pPideMarcaReserva,
		@pPermiteSoloEntrega,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pPidePredial, 
		@pPideCodProd, 
		@pPideComExpoMX, 
		@pCodigoFiscal,
		dbo.FuncFKgenReportes(@pReporte_Id), 
		dbo.FuncfkvenEsquemaAuto(@pEsquemaAuto_Id), 
		@pPorCotizacion, 
		@pUsaCartaPorte,
		dbo.FuncFKvenOtcFormula(@pCodFormula),
		dbo.FuncFKstkCondFisVenta(@pCFOtCargos_Id)
		)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venSubTipoMovDatos
GO
CREATE PROCEDURE venSubTipoMovDatos
(
@pSubTipoMov_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venSubTipoMov.venSubTipoMov, venSubTipoMov.SubTipoMov_Id, venSubTipoMov.SubTipoMov_Id as SubTipoMov_Id_Nueva, venSubTipoMov.Empresa_Id, 
	Cast( Case When venSubTipoMov.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, venTipoMov.Signo, venTipoMov.TipoMovResumido,
	venSubTipoMov.venTipoMov, venTipoMov.Descripcion as DescripcionTipoMov, venSubTipoMov.Descripcion, venSubTipoMov.MueveStock,
	venSubTipoMov.EsVentaContado, venSubTipoMov.AdmiteDevolucion, venSubTipoMov.ModificaPrecio, venSubTipoMov.Reservado,
	venSubTipoMov.GeneraRemito, genSegmentos.Segmento_Id SegmentoRemito_Id, genSegmentos.Descripcion as DescripcionSegmentos, 
	venSubTipoMov.NCxDevolucion, genUsuarios.Usuario_Id UsuarioAutorizado, genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAutorizado, 
	venSubTipoMov.AdmiteBoniRenglon, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, venSubTipoMov.PideCambio,
	venSubTipoMov.ModFecha, venSubTipoMov.ModCondPago, venSubTipoMov.ModVendedor, venSubTipoMov.ModCobrador,
	venSubTipoMov.PideObervaciones, venSubTipoMov.CantidadCopias, venSubTipoMov.ModDeposito, venSubTipoMov.ModListaPrecios,
	venSubTipoMov.PideFechaEntrega, venSubTipoMov.PideObsReng, conCuentas.Cuenta_Id CtaDefecto, conCuentas.Descripcion as DescripcionCtaDefecto,
	venSubTipoMov.ModCtaDefecto, venSubTipoMov.ModCentro1, venSubTipoMov.ModCentro2, venSubTipoMov.PideOtrosCargos,
	conCuentas2.Cuenta_Id CtaOtrosCargos, conCuentas2.Descripcion as DescripcionCtaOtrosCargos, 
	venSubTipoMov.PermModCtaOtCar, venSubTipoMov.FechaEntregaporRen,
	venSubTipoMov.AdmiteFactsinEntr, venSubTipoMov.ModiUniMed, venSubTipoMov.AfectaComVenta, venSubTipoMov.AfectaComCobra,
	venSubTipoMov.MaxCantItems, venSubTipoMov.EsPorDifPrecio, venSubTipoMov.AfectaEstadistica, venSubTipoMov.ClaveAcceso,
	venSubTipoMov.EsPorDifCambio, venSubTipoMov.TipoPrecioForm, venSubTipoMov.SoloImpuestos, venSubTipoMov.CodigoFormulario,
	venSubTipoMov.BajoCosto, venSubTipoMov.Administrativa, venSubTipoMov.PideReferencia, venSubTipoMov.PideOrdenCompra,
	venSubTipoMov.PideCongelarCambio, PideMarcaReserva, venSubTipoMov.PermiteSoloEntrega,
	venSubTipoMov.Inactivo, genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, venSubTipoMov.Posteado, 
	venSubTipoMov.PidePredial , venSubTipoMov.PideCodProd, venSubTipoMov.PideComExpoMX, venSubTipoMov.CodigoFiscal,
	genReportes.Reporte_Id, genReportes.Titulo as DescripcionReporte, venEsquemaAuto.EsquemaAuto_Id, 
	venEsquemaAuto.Descripcion as DescripcionEsquemaAuto, venSubTipoMov.PorCotizacion, venSubTipoMov.UsaCartaPorte,
	venOtcFormula.Formula_Id, venOtcFormula.Descripcion DescOtCargos, stkCondFisVenta.CFVenta_Id CFOtCargos_Id, stkCondFisVenta.Descripcion DescCFOtCargos
FROM venSubTipoMov 
LEFT JOIN venTipoMov  ON (venTipoMov.venTipoMov = venSubTipoMov.venTipoMov)
LEFT JOIN genSegmentos  ON (genSegmentos.genSegmentos = venSubTipoMov.SegmentoRemito_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venSubTipoMov.UsuarioAutorizado)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = venSubTipoMov.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = venSubTipoMov.Centro2_Id)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = venSubTipoMov.CtaDefecto)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = venSubTipoMov.CtaOtrosCargos)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = venSubTipoMov.Usuario_Id)
left join genReportes on venSubTipoMov.Reporte_Id=genReportes.genReportes
left join venEsquemaAuto ON  venEsquemaAuto.venEsquemaAuto = venSubTipoMov.EsquemaAuto_Id
Left Join venOtcFormula On venOtcFormula.venOtcFormula = venSubTipoMov.CodFormula
Left Join stkCondFisVenta On stkCondFisVenta.stkCondFisVenta = venSubTipoMov.CFOtCargos_Id
WHERE (SubTipoMov_Id = @pSubTipoMov_Id)

Declare @pidentity bigint= dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venSubTipoMov'

exec venSTMAfipDatos @pIdentity

RETURN @@Error 

GO


DROP PROCEDURE venSubTipoMovEliminar
GO
CREATE PROCEDURE venSubTipoMovEliminar
(
@pSubTipoMov_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venSubTipoMov 
WHERE (SubTipoMov_Id = @pSubTipoMov_Id)
 
RETURN @@Error 

GO

DROP FUNCTION FuncFKvenSubTipoMov
GO

CREATE FUNCTION FuncFKvenSubTipoMov
(
@pSubTipoMov_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venSubTipoMov FROM venSubTipoMov WHERE 
	SubTipoMov_Id = @pSubTipoMov_Id
  RETURN @pIdentity
END


GO
