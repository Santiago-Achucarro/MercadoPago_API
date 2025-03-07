-- FM 2023/04/17 venMovimientosConStockDatos. No traía los lotes si no usaba Ubicación --

DROP PROCEDURE venMovimientosGuardar
GO
CREATE PROCEDURE venMovimientosGuardar
(
@pEmpresa_Id int, 
@pvenMovimientos bigint,
@pCliente_Id VarChar(15) = NULL,
@pSucursal SucursalN = NULL,
@pvenSubTipoMov_Id varchar(5) = NULL,
@pCondPagoCli_Id varchar(5) = NULL,
@pVendedor_Id varchar(5) = NULL,
@pCobrador_Id varchar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pCondFisc_Id varchar(5) = NULL,
@pImporte qMonedaD2,
@pSaldo qMonedaD2,
@pSubTotal qMonedaD2,
@pSubTotalBonif qMonedaD2,
@pComision1 numeric(5),
@pComision2 numeric(5),
@pBonificacion1 qMonedaD2,
@pBonificacion2 qMonedaD2,
@pBonificacion3 qMonedaD2,
@pBonificacion4 qMonedaD2,
@pBonificacion5 qMonedaD2,
@pDato1 qMonedaD4,
@pDato2 qMonedaD4,
@pDato3 qMonedaD4,
@pCobraAbasto Sino,
@pCambioFijo Sino,
@pComprobanteDesde int = NULL,
@pTipoPago int,
@pIncoterm_Id char(3) = NULL, 
@pVenTipoMov Char(1),
@pDatoOtCargos qMonedaD2,
@pRenglonCtaOtCargos int = Null
)
AS
SET NOCOUNT ON 
	
IF (EXISTS (SELECT 1 FROM venMovimientos WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovimientos
	SET	Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Sucursal = @pSucursal,
		venSubTipoMov_Id = dbo.FuncFKvenSubTipoMov(@pvenSubTipoMov_Id),
		CondPagoCli_Id = dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		Cobrador_Id = dbo.FuncFKvenCobradores(@pCobrador_Id),
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		CondFisc_Id = dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		Importe = @pImporte,
		Saldo = @pSaldo,
		SubTotal = @pSubTotal,
		SubTotalBonif = @pSubTotalBonif,
		Comision1 = @pComision1,
		Comision2 = @pComision2,
		Bonificacion1 = @pBonificacion1,
		Bonificacion2 = @pBonificacion2,
		Bonificacion3 = @pBonificacion3,
		Bonificacion4 = @pBonificacion4,
		Bonificacion5 = @pBonificacion5,
		Dato1 = @pDato1,
		Dato2 = @pDato2,
		Dato3 = @pDato3,
		CobraAbasto = @pCobraAbasto,
		CambioFijo = @pCambioFijo,
		ComprobanteDesde = @pComprobanteDesde,
		TipoPago = @pTipoPago,
		Incoterm_Id = dbo.FuncFKvenIncoterm(@pIncoterm_Id), 
		VenTipoMov = @pVenTipoMov,
		DatoOtCargos = @pDatoOtCargos,
		RenglonCtaOtCargos = @pRenglonCtaOtCargos
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientos
	(
		venMovimientos,
		Cliente_Id,
		Sucursal,
		venSubTipoMov_Id,
		CondPagoCli_Id,
		Vendedor_Id,
		Cobrador_Id,
		FormaEntrega_Id,
		CondFisc_Id,
		Importe,
		Saldo,
		SubTotal,
		SubTotalBonif,
		Comision1,
		Comision2,
		Bonificacion1,
		Bonificacion2,
		Bonificacion3,
		Bonificacion4,
		Bonificacion5,
		Dato1,
		Dato2,
		Dato3,
		CobraAbasto,
		CambioFijo,
		ComprobanteDesde,
		TipoPago,
		Incoterm_Id,
		VenTipoMov,
		DatoOtCargos,
		RenglonCtaOtCargos
	)
	VALUES 
	(
		@pvenMovimientos,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pSucursal,
		dbo.FuncFKvenSubTipoMov(@pvenSubTipoMov_Id),
		dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenCobradores(@pCobrador_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		@pImporte,
		@pSaldo,
		@pSubTotal,
		@pSubTotalBonif,
		@pComision1,
		@pComision2,
		@pBonificacion1,
		@pBonificacion2,
		@pBonificacion3,
		@pBonificacion4,
		@pBonificacion5,
		@pDato1,
		@pDato2,
		@pDato3,
		@pCobraAbasto,
		@pCambioFijo,
		@pComprobanteDesde,
		@pTipoPago,
		dbo.FuncFKvenIncoterm(@pIncoterm_Id), 
		@pVenTipoMov,
		@pDatoOtCargos,
		@pRenglonCtaOtCargos
	)
END 

GO
------------------------------------------------------------------------------------------------
DROP PROCEDURE venMovimientosDatos
GO
CREATE PROCEDURE venMovimientosDatos
(
@pIdentity bigint
)
AS
SET NOCOUNT ON 

SELECT venMovimientos.venMovimientos,
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, venMovimientos.venTipoMov, 
	conAsientos.Posteado, conAsientos.Fecha, conAsientos.FechaRegistro, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal, 
	CAST(
             CASE
                  WHEN conAsientos.Anulado = 1 or conAsientosAnul.FechaAnulacion is not null
                     THEN 1
                  ELSE 0
             END AS bit) as Anulado
, conAsientos.Observaciones,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	venClientes.Cliente_Id, venMovimientos.Sucursal, venClieHabitual.NombreFantasia,
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov,
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago,
	venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedores, 
	venCobradores.Cobrador_Id, venCobradores.Nombre as DescripcionCobradores,
	venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega, 
	venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion as DescripcionCondFiscal,
	venMovimientos.Importe, venMovimientos.Saldo, venMovimientos.SubTotal, venMovimientos.SubTotalBonif,
	venMovimientos.Comision1, venMovimientos.Comision2,
	venMovimientos.Bonificacion1, venMovimientos.Bonificacion2, venMovimientos.Bonificacion3, 
	venMovimientos.Bonificacion4,venMovimientos.Bonificacion5, 
	venMovimientos.Dato1, venMovimientos.Dato2, venMovimientos.Dato3,
	venMovimientos.CobraAbasto, 
	venMovimientos.CambioFijo, venMovimientos.ComprobanteDesde, venMovimientos.TipoPago, 
	venIncoterm.Incoterm_Id, venIncoterm.Descripcion as DescripcionIncoterm,
	conCuentasDXV.Cuenta_Id CtaClientes, conCuentasDXV.Descripcion as DescripcionCtaClientes,
	conCentro1DXV.Centro1_Id Centro1DXV_Id, conCentro1DXV.Descripcion as DescripcionCentro1DXV,
	conCentro2DXV.Centro2_Id Centro2DXV_Id, conCentro2DXV.Descripcion as DescripcionCentro2DXV,
	conMovCont.TipoMov AS TipomovCont, conMovCont.Clase, conMovCont.Importe AS ImporteContable,
	genMovimientos.CantCuotas, disFormularios.Formulario_Id, Cast(1 As bit) LlamarAlWSFE, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS SegmentoStr,
	genSucursalesEmpr.Sucursal AS SucursalEmpr, CAST(0 as bit) NoRecalcular, Cast(0 As Bit) SinEntrega,
	Cast(0 As bit) EsSaldoInicial, Cast(0 As bit) AceptarDatosExternos, Cast(0 As bit) PreGuardaComprobante,
	renCtaOtCargos.ImporteMonedaOriginal ImpOtCargos, renCtaOtCargos.Importe ImpOtCargosMO, DatoOtCargos, renCtaOtCargos.Renglon RenglonCtaOtCargos,
	renCtaOtCargos.LeyendaLibroMayor DescOtrosCargos, CtaOtc.Cuenta_Id CtaOtrosCargos, CtaOtc.Descripcion DescCtaOtrosCargos, 
	CC1Otc.Centro1_Id Centro1Otc, CC1Otc.Descripcion DescCC1Otc, CC2Otc.Centro2_Id Centro2Otc, CC2Otc.Descripcion DescCC2Otc
FROM venMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = venMovimientos.venMovimientos
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_id = genSegmentos.genSegmentos
INNER JOIN genMovimientos  ON genMovimientos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON venMovimientos.venMovimientos  = conAsientos.conAsientos
INNER JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
LEFT JOIN venClieHabitual  ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id AND 
	venClieHabitual.Sucursal = venMovimientos.Sucursal
Left Join venClientes On venMovimientos.Cliente_Id = venClientes.genEntidades
LEFT JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id)
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venMovimientos.CondPagoCli_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venMovimientos.Vendedor_Id)
LEFT JOIN venCobradores  ON (venCobradores.venCobradores = venMovimientos.Cobrador_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venMovimientos.FormaEntrega_Id)
LEFT JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id)
LEFT JOIN conMovCont ON conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI'
LEFT JOIN conCuentas conCuentasDXV ON conCuentasDXV.conCuentas = conMovCont.cuenta_Id 
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
Left JOIN conCentro1 conCentro1DXV ON conCentro1DXV.conCentro1 = conMovCont.Centro1_Id
Left JOIN conCentro2 conCentro2DXV ON conCentro2DXV.conCentro2 = conMovCont.Centro2_Id
LEFT JOIN venIncoterm  ON (venIncoterm.venIncoterm_int = venMovimientos.Incoterm_Id)
Inner Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
left join conAsientosAnul on conAsientos.conAsientos= conAsientosAnul.Asiento_Id
Left Join (conMovCont renCtaOtCargos Inner Join conCuentas CtaOtc On CtaOtc.conCuentas = renCtaOtCargos.Cuenta_Id
									Left Join conCentro1 CC1Otc On CC1Otc.conCentro1 = renCtaOtCargos.Centro1_Id
									Left Join conCentro2 CC2Otc On CC2Otc.conCentro2 = renCtaOtCargos.Centro2_Id) On renCtaOtCargos.conAsientos = venMovimientos.venMovimientos And
																													renCtaOtCargos.Renglon = venMovimientos.RenglonCtaOtCargos
WHERE (venMovimientos = @pIdentity)
GO

------------------------------------------------------------------------------------------------
DROP PROCEDURE venMovimientosSinStockDatos
GO
CREATE PROCEDURE venMovimientosSinStockDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON

Declare @pIdentity bigint = (Select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

Exec venMovimientosDatos @pIdentity

Exec venMovDetalleDatos @pIdentity
Exec VenMovImpuestosDatos @pIdentity

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venMovimientos' 

Exec genMovCuotasDatos @pIdentity

--Exec genSegmentosConfiguracion @pSegmento_Id, @pEmpresa_Id

Exec  venMovSSImpuestosDatos @pIdentity

exec venMovimientosFiscalDatos @pIdentity
exec venMovimientosFiscalINEDatos @pIdentity
exec venMovimientosMetodoPagoDatos @pIdentity
exec venMovimientosCFDIRDatos @pIdentity -- AR
exec venMovimientosCFDIRDatos @pIdentity -- MX
exec venMoviAnticipoDatos @pIdentity

-- PARA ENVIAR LA DIFERNCIA EN CAMBIOS DE ANTICIPO
select venMovDetalle.venMovimientos, venMovDetalle.conRenglon, 
	venMovDetalle.ImporteUnitario*0 as Importe, ' ' as Cuenta_Id
FROM
	venMovDetalle WHERE 1 = 2

Exec conAsientosAnulDatos @pidentity

RETURN @@Error
GO

------------------------------------------------------------------------------------------------

Drop Procedure venMovimientosConStockDatos
GO
Create Procedure venMovimientosConStockDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @pIdentity bigint = (Select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id And 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And 
	genAsiSegmentos.Segmento1N = @pSegmento1N And 
	genAsiSegmentos.Segmento2N = @pSegmento2N And 
	genAsiSegmentos.Segmento3N = @pSegmento3N And 
	genAsiSegmentos.Segmento4N = @pSegmento4N And 
	genAsiSegmentos.Segmento1C = @pSegmento1C And 
	genAsiSegmentos.Segmento2C = @pSegmento2C And 
	genAsiSegmentos.Segmento3C = @pSegmento3C And 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
Exec venMovimientosDatos @pIdentity

exec venMovConStockDatos @pIdentity

Exec venMovImpuestosDatos @pIdentity, Null

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venMovimientos'
Exec genMovCuotasDatos @pIdentity
/*
SELECT genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo, genMovCuotas.FechaVencimiento
FROM genMovCuotas
WHERE genMovCuotas.Asiento_id = @pIdentity
ORDER BY 1
*/
exec venMovCSImpuestosDatos @pIdentity, Null, Null
exec venMovimientosFiscalDatos @pIdentity
exec venMovimientosFiscalINEDatos @pIdentity
exec venMovimientosMetodoPagoDatos  @pIdentity
exec venMovimientosExpMXDatos  @pIdentity

exec venMovimientosCFDIRDatos @pIdentity -- AR
exec venMovimientosCFDIRDatos @pIdentity -- MX

SELECT stkMoviSerie.stkMoviCabe, venMovStkHist.RenglonCuerpo Renglon, stkMoviSerie.Serie, isNull(stkMoviSerieUbicacion.Cantidad, stkMoviSerie.Cantidad) / stkMoviCuerpo.Factor Cantidad,
stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia,
	Case @pIdentity When 0 Then Cast(0 As bit) Else Cast(1 As bit) End Marcado
FROM stkMoviSerie 
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Left Join stkSerieVencimiento On stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
	stkSerieVencimiento.Empresa_Id = @pEmpresa_id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviSerie.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
left join (stkMoviSerieUbicacion INNER JOIN stkUbicaciones ON
	stkUbicaciones.stkUbicaciones = stkMoviSerieUbicacion.Ubicacion_Id) ON  
	stkMoviSerieUbicacion.stkMoviCabe = stkMoviSerie.stkMoviCabe and 
	  stkMoviSerieUbicacion.Renglon  = stkMoviSerie.Renglon And
	  stkMoviSerieUbicacion.Serie = stkMoviSerie.Serie
WHERE venMovStkHist.venMovimientos = @pIdentity

exec venMoviAnticipoDatos @pIdentity

-- V2 UBICACIONES
Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id,
	Cast(0 As Numeric(19,8)) Cantidad, Cast(0 As Numeric(19,8)) CantidadAlterna, 
	stkMoviUbicacion.Cantidad Existencia, stkMoviUbicacion.CantidadAlterna ExistenciaAlterna
From stkMoviUbicacion 
inner join stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and
	stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
INNER JOIN stkProductos on  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos on  stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
inner join venMovimientos ON venMovimientos.venMovimientos = venMovStkHist.venMovimientos
INNER JOIN venTipoMov ON venTipoMov.Signo = 1
WHERE venMovStkHist.venMovimientos = @pIdentity 



Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id,
	stkMoviUbicacion.Cantidad, stkMoviUbicacion.CantidadAlterna
From stkMoviUbicacion 
inner join stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and
	stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
INNER JOIN stkProductos on  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos on  stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
inner join venMovimientos ON venMovimientos.venMovimientos = venMovStkHist.venMovimientos
INNER JOIN venTipoMov ON venTipoMov.Signo = -1
WHERE venMovStkHist.venMovimientos = @pIdentity

-- AJ MAY 2020 PARA LAS CONSULTAS DE STOCK
SELECT getdate() as Fecha, '' Producto_Id, '' Descripcion, 0.00 as Existencia, 
	0.00 as Compras, 0.00 as Embarques,	
		0.00 as Pedidos, 0.00 as TransitoLocal,
		0.00 as Final, '' as Deposito_Id

select '' as Entidad_Id, '' as Descripcion, '' SegmentoSTR, 0.00 as Cantidad


-- para las cotizaciones
select genSegmentos.Segmento_Id, venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N,
	venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C
FROM venCotizFactura INNER JOIN venCotizSegmento ON
	venCotizFactura.venCotizaciones = venCotizSegmento.venCotizaciones
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = venCotizSegmento.Segmento_Id
	Where
		venCotizFactura.venMovimientos = @pIdentity

Exec conAsientosAnulDatos @pidentity

-- Carta Porte

SELECT venCompCartaporte.TranspInternac, venCompCartaporte.EntradaSalidaMerc, venCompCartaPorte.ViaEntradaSalida, 
	venCompCartaporte.TotalDistRec, venCompCartaporte.PesoBrutoTotal, venCompCartaporte.UnidadPeso, 
	venCompCartaporte.PesoBrutoTotal, venCompCartaporte.PesoNetoTotal, venCompCartaporte.CargoPorTasacion,
	venCamiones.Patente_Id as Camion_Id,  venCamiones.Descripcion  DescripcionCamion,
	Remolque1.Patente_Id as Remolque1, Remolque1.Descripcion as DescripcionRemolque1,
	Remolque2.Patente_Id as Remolque2, Remolque2.Descripcion as DescripcionRemolque2,
	venOperadores.Operador_Id, venOperadores.NombreOperador,
	venCompCartaPorteOrigen.RFCRemitente, venCompCartaPorteOrigen.NombreRemitente,
	venCompCartaPorteOrigen.NumRegIdTrib NumRegIdTribO, genPaisesOR.Pais_Id as  ResidenciaFiscalO,
	venCompCartaPorteOrigen.NumEstacion NumEstacionO, venCompCartaPorteOrigen.NombreEstacion NombreEstacionO, 
	venCompCartaPorteOrigen.NavegacionTrafico NavegacionTraficoO, venCompCartaPorteOrigen.FechaHoraSalida,
	venCompCartaPorteOrigen.Calle CalleOrigen,  venCompCartaPorteOrigen.NumeroExterior  NumeroExteriorOrigen, 
	venCompCartaPorteOrigen.Numerointerior NumerointeriorOrigen, 
	venCompCartaPorteOrigen.Colonia ColoiniaOrigen, 
		genColoniasO.NombreAsentamiento as DescripcionColoniaO, 
	venCompCartaPorteOrigen.Localidad  LocalidadOrigen, genlocalidadesO.Descripcion as DescripcionLocalidadO, 
	venCompCartaPorteOrigen.Referencia ReferenciaOrigen,
	venCompCartaPorteOrigen.Municipio MunicipioOrigen, genMunicipiosO.Descripcion AS DescripcionMunicipioO, 
	genProvincias.Provincia_Id EstadoO, venCompCartaPorteOrigen.CodigoPostal CodigoPostalOrigen, 
	genPaisesO.Pais_Id PaisOrigen, genPaisesO.Descripcion DescripcionPaisO,
	venCompCartaPorteDestino.RFCDestinatario, venCompCartaPorteDestino.NombreDestinatario,
	venCompCartaPorteDestino.NumRegIdTrib NumRegIdTribD, genPaisesOR.Pais_Id as  ResidenciaFiscal,
	venCompCartaPorteDestino.NumEstacion NumEstacionD, venCompCartaPorteDestino.NombreEstacion NombreEstacionD, 
	venCompCartaPorteDestino.NavegacionTrafico NavegacionTraficoD, venCompCartaPorteDestino.FechaHoraProgLlegada,
	venCompCartaPorteDestino.Calle CalleDestino,  venCompCartaPorteDestino.NumeroExterior  NumeroExteriorDestino, 
	venCompCartaPorteDestino.Numerointerior NumerointeriorDestino, 
	venCompCartaPorteDestino.Colonia ColoiniaDestino, 
		genColoniasD.NombreAsentamiento as DescripcionColoniaD, 
	venCompCartaPorteDestino.Localidad  LocalidadDestino, genlocalidadesD.Descripcion as DescripcionLocalidadD, 
	venCompCartaPorteDestino.Referencia ReferenciaDestino,
	venCompCartaPorteDestino.Municipio MunicipioDestino, genMunicipiosD.Descripcion AS DescripcionMunicipioD, 
	genProvinciasD.Provincia_Id EstadoD, venCompCartaPorteDestino.CodigoPostal CodigoPostalDestino, 
	genPaisesO.Pais_Id PaisDestino, genPaisesD.Descripcion DescripcionPaisD
FROM  venCompCartaporte
	inner join venCamiones ON  venCompCartaporte.Camion_Id= venCamiones.venCamiones
	left join venCamiones Remolque1 ON  venCompCartaporte.Remolque1= Remolque1.venCamiones
	left join venCamiones Remolque2 ON  venCompCartaporte.Remolque2= Remolque2.venCamiones
	inner join venOperadores on  venOperadores.venOperadores = venCompCartaPorte.Operador_Id
	INNER JOIN venCompCartaPorteOrigen on  venCompCartaPorteOrigen.venmovimientos = venCompCartaPorte.venmovimientos
	INNER JOIN genPaises genPaisesOR ON  genPaisesOR.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
	LEFT JOIN genProvincias ON  genProvincias.CodFiscal = venCompCartaPorteOrigen.Estado
	LEFT JOIN genColonias  genColoniasO ON genColoniasO.c_Colonia = venCompCartaPorteOrigen.Colonia AND 
	genColoniasO.c_CodigoPostal = venCompCartaPorteOrigen.CodigoPostal
	LEFT JOIN genlocalidades  genlocalidadesO ON genlocalidadesO.c_Localidad = venCompCartaPorteOrigen.Localidad AND 
		genlocalidadesO.c_Estado = venCompCartaPorteOrigen.Estado
	LEFT JOIN genMunicipios  genMunicipiosO ON genMunicipiosO.c_Municipio = venCompCartaPorteOrigen.Municipio and 
								genMunicipiosO.c_Estado = venCompCartaPorteOrigen.Estado
	INNER JOIN genPaises genPaisesO ON genPaisesO.genPaises = venCompCartaPorteOrigen.Pais

	INNER JOIN venCompCartaPorteDestino on  venCompCartaPorteDestino.venmovimientos = venCompCartaPorte.venmovimientos
	INNER JOIN genPaises genPaisesDR ON  genPaisesDR.genPaises = venCompCartaPorteDestino.ResidenciaFiscal
	LEFT JOIN genProvincias genProvinciasD ON  genProvinciasD.CodFiscal = venCompCartaPorteDestino.Estado
	LEFT JOIN genColonias  genColoniasD ON genColoniasD.c_Colonia = venCompCartaPorteDestino.Colonia AND 
	genColoniasD.c_CodigoPostal = venCompCartaPorteDestino.CodigoPostal
	LEFT JOIN genlocalidades  genlocalidadesD ON genlocalidadesD.c_Localidad = venCompCartaPorteDestino.Localidad AND 
		genlocalidadesD.c_Estado = venCompCartaPorteDestino.Estado
	LEFT JOIN genMunicipios  genMunicipiosD ON genMunicipiosD.c_Municipio = venCompCartaPorteDestino.Municipio and 
								genMunicipiosD.c_Estado = venCompCartaPorteDestino.Estado
	INNER JOIN genPaises genPaisesD ON genPaisesD.genPaises = venCompCartaPorteDestino.Pais
WHERE
	venCompCartaPorte.venmovimientos = @pIdentity

-- mercancia Carta Porte
Select venCompCartaPorteMercancia.Renglon, venCompCartaPorteMercancia.BienesTransp, venCompCartaPorteMercancia.ClaveSTCC, 
	venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, stkUniMed.Medida_Id, 
		venCompCartaPorteMercancia.Dimensiones, venCompCartaPorteMercancia.MaterialPeligroso, venCompCartaPorteMercancia.CveMaterialPeligroso, 
			venCompCartaPorteMercancia.Embalaje, venCompCartaPorteMercancia.DescripEmbalaje, venCompCartaPorteMercancia.PesoEnKg, 
			venCompCartaPorteMercancia.ValorMercancia, venCompCartaPorteMercancia.FraccionArancelaria, 
			venCompCartaPorteMercancia.UUIDComercioExt
from venCompCartaPorteMercancia
	INNER JOIN stkUniMed ON venCompCartaPorteMercancia.Medida_id = stkUniMed.stkUniMed
	WHERE venCompCartaPorteMercancia.venMovimientos = @pIdentity
ORDER BY 1


-- Datos de cobranzas venta al contado/pto de venta --
Select 0 Renglon, '' Cartera_Id, '' DescripcionCartera, '' TipoCartera, Cast(0 As Numeric(19,2)) Importe, Cast(0 As Numeric(12,8)) Ponderado,
	'' CTBanco_Id, '' CTDescripcionBanco, '' CTClearing,
	'' CTClearingDias, GetDate() CTFechaVencimiento, '' CTsucBanco, '' CTcuentaBanco, 0 CTnumCheque, '' CTLectoraCheques,
	0 T3Cuotas, 0 T3Cupon, 0 T3Lote, 0 T3Comercio, 0 T3Terminal, 0 T3Promocion, Cast(0 As Numeric(19,8)) T3Coeficiente

RETURN @@Error
GO

------------------------------------------------------------------------------------------------
Drop Procedure venMovimientosConsultaDatos
Go
Create Procedure venMovimientosConsultaDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @pIdentity bigint = (Select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id And 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And 
	genAsiSegmentos.Segmento1N = @pSegmento1N And 
	genAsiSegmentos.Segmento2N = @pSegmento2N And 
	genAsiSegmentos.Segmento3N = @pSegmento3N And 
	genAsiSegmentos.Segmento4N = @pSegmento4N And 
	genAsiSegmentos.Segmento1C = @pSegmento1C And 
	genAsiSegmentos.Segmento2C = @pSegmento2C And 
	genAsiSegmentos.Segmento3C = @pSegmento3C And 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
Exec venMovimientosDatos @pIdentity

SELECT venMovConStock.venMovimientos, venListasPrecios.ListaPrecio_Id, 
venListasPrecios.Descripcion as DescripcionListasPrecios, venMovConStock.TipoPrecioForm, venListasPrecios.LlevaImpuestoInclu
FROM venMovConStock 
INNER JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venMovConStock.ListaPrecio_Id)
WHERE (venMovimientos = @pIdentity)

SELECT venMovConStockCr.venMovimientos, 
	venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, stkProductos.Descripcion as Detalle, stkCondFisVenta.CFVenta_Id,
	stkCondFisVenta.Descripcion as DescripcionCondFisVenta, stkDepositos.Deposito_Id,
	stkDepositos.Descripcion as DescripcionDepositos, stkUniMed.Medida_Id, 
	stkUniMed.Descripcion as DescripcionUniMed, venMovConStockCr.Factor,
	venMovConStockCr.CantFacturada, venMovConStockCr.CantEntregada, venMovConStockCr.CantPendiente, 
	venMovConStockCr.CantOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna, venMovConStockCr.CantidadAlternaForm,
	venMovConStockCr.TipoPrecio, venMovConStockCr.PrecioForm, 
	venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta,
	venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, venMovConStockCr.PrecioFormImpuestoTot,
	venMovConStockCr.ComiPorce, venMovConStockCr.Bonificacion, 
	venMovConStockCr.SubTotal, venMovConStockCr.SubTotalFormImpuesto,
	venMovConStockCr.Observaciones, venMovConStockCr.FechaEntrega, 
	venMovConStockCr.CantEntregadaForm
FROM venMovConStockCr 
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venMovConStockCr.Producto_Id)
LEFT JOIN stkCondFisVenta  ON stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venMovConStockCr.Deposito_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venMovConStockCr.Medida_Id)
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = venMovConStockCr.Medida_Id
WHERE venMovConStockCr.venMovimientos = @pIdentity
Union All

SELECT venMovDetalle.venMovimientos, venMovDetalle.conRenglon,
	'' Producto_Id, venMovDetalle.Detalle, stkCondFisVenta.CFVenta_Id, stkCondFisVenta.Descripcion as DescripcionCondFisVenta,
	'' Deposito_Id, '' DescripcionDepositos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed,
	1 Factor, venMovDetalle.Cantidad CantFacturada, venMovDetalle.Cantidad CantEntragada, 0 CantPendiente,
	venMovDetalle.Cantidad CantOriginal, '' MedidaAlterna, 0 CantidadAlternaForm,
	'' TipoPrecio, venMovDetalle.ImporteUnitario PrecioForm, venMovDetalle.ImporteUnitario PrecioLista,
	venMovDetalle.ImporteUnitario PrecioVenta, venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuesto,
	venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuestoBon, venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuestoTot,
	0 ComiPorce, 0 Bonificacion,
	venMovDetalle.SubTotal, venMovDetalle.SubTotalFormImpuesto, '' Observaciones, dbo.FechaActual() FechaEntrega,
	0 CantEntregadaForm
FROM venMovDetalle 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = venMovDetalle.venMovimientos) AND (conMovCont.Renglon = venMovDetalle.conRenglon)
LEFT JOIN stkCondFisVenta  ON (stkCondFisVenta.stkCondFisVenta = venMovDetalle.CFVenta_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venMovDetalle.Medida_Id)
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.cuenta_id 
Left JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
Left JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
WHERE (venMovimientos = @pIdentity)
Order By 2

SELECT venMovImpuestos.venMovimientos, venMovImpuestos.conRenglon,
	venImpuestos.Impuesto_Id, venImpuestos.Descripcion as DescripcionImpuestos, venMovImpuestos.Porcentaje,
	venMovImpuestos.BaseImponible, venMovImpuestos.Importe, venMovImpuestos.BaseImponibleMonedaNac,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.TipoMov, conMovCont.Clase, conMovCont.Importe as ImporteContable
FROM venMovImpuestos 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = venMovImpuestos.venMovimientos) AND (conMovCont.Renglon = venMovImpuestos.conRenglon)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id)
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.cuenta_id 
	Left JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
	Left JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
WHERE venMovimientos = @pIdentity
Order By 2

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venMovimientos' 

SELECT genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo, genMovCuotas.FechaVencimiento
FROM genMovCuotas
WHERE
	genMovCuotas.Asiento_id = @pIdentity
ORDER BY 1

--Exec genSegmentosConfiguracion @pSegmento_Id, @pEmpresa_Id

SELECT venMovCSImpuestos.venMovimientos, venMovCSImpuestos.RenglonCuerpo, venImpuestos.Impuesto_Id,
	venImpuestos.Descripcion as DescripcionImpuestos, venMovCSImpuestos.Importe, venMovCSImpuestos.Porcentaje, venMovCSImpuestos.BaseImponible,
	venMovCSImpuestos.BaseImponibleMonedaNac
FROM venMovCSImpuestos 
INNER JOIN venMovConStockCr  ON (venMovConStockCr.venMovimientos = venMovCSImpuestos.venMovimientos) AND 
(venMovConStockCr.RenglonCuerpo = venMovCSImpuestos.RenglonCuerpo)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venMovCSImpuestos.Impuesto_Id)
WHERE venMovCSImpuestos.venMovimientos = @pidentity


SELECT venMovSSImpuestos.venMovimientos, venMovSSImpuestos.ConRenglon, venImpuestos.Impuesto_Id,
	venImpuestos.Descripcion as DescripcionImpuestos, venMovSSImpuestos.Importe, 
	venMovSSImpuestos.Porcentaje, venMovSSImpuestos.BaseImponible, venMovSSImpuestos.BaseImponibleMonedaNac
FROM venMovSSImpuestos 
INNER JOIN venMovDetalle ON (venMovDetalle.venMovimientos = venMovSSImpuestos.venMovimientos) AND 
(venMovDetalle.ConRenglon = venMovSSImpuestos.ConRenglon)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venMovSSImpuestos.Impuesto_Id)
WHERE venMovSSImpuestos.venMovimientos = @pidentity


SELECT venMovConStockCrCtas.venMovimientos, venMovConStockCrCtas.RenglonCuerpo,
	venMovConStockCrCtas.Renglon, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2,
	conMovCont.TipoMov, conMovCont.Clase, conMovCont.Importe as ImporteContable
FROM venMovConStockCrCtas 
INNER JOIN venMovConStockCr ON (venMovConStockCr.venMovimientos = venMovConStockCrCtas.venMovimientos) AND 
	(venMovConStockCr.RenglonCuerpo = venMovConStockCrCtas.RenglonCuerpo)
INNER JOIN conMovCont ON (conMovCont.conAsientos = venMovConStockCrCtas.venMovimientos) AND 
	(conMovCont.Renglon = venMovConStockCrCtas.Renglon)
Inner Join conCuentas On conMovCont.Cuenta_Id = conCuentas.conCuentas
Left Join conCentro1 On conMovCont.Centro1_Id = conCentro1.conCentro1
Left Join conCentro2 On conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE (venMovConStockCrCtas.venMovimientos = @pIdentity)
Union All
Select venMovDetalle.venMovimientos, venMovDetalle.conRenglon, venMovDetalle.conRenglon,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.TipoMov, conMovCont.Clase, conMovCont.Importe as ImporteContable
FROM venMovDetalle 
INNER JOIN conMovCont ON (conMovCont.conAsientos = venMovDetalle.venMovimientos) AND (conMovCont.Renglon = venMovDetalle.conRenglon)
LEFT JOIN stkCondFisVenta ON (stkCondFisVenta.stkCondFisVenta = venMovDetalle.CFVenta_Id)
LEFT JOIN stkUniMed ON (stkUniMed.stkUniMed = venMovDetalle.Medida_Id)
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.cuenta_id 
Left JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
Left JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
WHERE (venMovimientos = @pIdentity)

exec venMovimientosFiscalDatos @pIdentity
exec venMoviAnticipoDatos @pIdentity

Exec conAsientosAnulDatos @pidentity

RETURN @@Error
GO


------------------------------------------------------------------------------------------------
DROP PROCEDURE venMovimientosEliminar
GO
CREATE PROCEDURE venMovimientosEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientos WHERE (venMovimientos = @pvenMovimientos)
 
RETURN @@Error 

GO

------------------------------------------------------------------------------------------------

Drop Procedure venMovimientosDatosSeg
Go
Create Procedure venMovimientosDatosSeg
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @pIdentity bigint = (Select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id And 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And 
	genAsiSegmentos.Segmento1N = @pSegmento1N And 
	genAsiSegmentos.Segmento2N = @pSegmento2N And 
	genAsiSegmentos.Segmento3N = @pSegmento3N And 
	genAsiSegmentos.Segmento4N = @pSegmento4N And 
	genAsiSegmentos.Segmento1C = @pSegmento1C And 
	genAsiSegmentos.Segmento2C = @pSegmento2C And 
	genAsiSegmentos.Segmento3C = @pSegmento3C And 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec venMovimientosDatos @pIdentity
go