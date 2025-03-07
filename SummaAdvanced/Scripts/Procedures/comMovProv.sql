
--comMovProvDatosSinStock 1, 1, 0,0,0,0,' ',' ',' ',' '

DROP PROCEDURE comMovProvGuardar
GO
CREATE PROCEDURE comMovProvGuardar
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
@pSegmento4C VarChar(20),
@pProveed_Id VarChar(15),
@pTipomov Char(1),
@pTipoCtaProv int,
@pFecha_CCP qFecha,
@pBase_Ganancias qMonedaD2,
@pImportacion Sino,
@pOrigen_Id smallint = NULL,
@pComCondPago_Id varchar(5) = NULL,
@pCondFiscal_Id varchar(5) = NULL,
@pFechaFiscal qFecha = NULL,
@pClaveFiscal varchar(36) = NULL,
@pVieneDeFiscal Sino = NULL,
@pXMLFiscal text,
@pImporte qMonedaD2,
@pSaldo qMonedaD2,
@pTipoCompFE int = Null,
@pFacturaTesoreria bit, 
@pRenglonDtoFin INT=NULL
)
AS


SET NOCOUNT ON 
Declare @pidentity bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comMovProv WHERE (comMovProv = @pidentity)))
BEGIN 
	UPDATE comMovProv
	SET		Proveed_Id = dbo.FuncFkcomProveedores(@pProveed_Id),
		Tipomov = @pTipomov,
		TipoCtaProv = @pTipoCtaProv,
		Fecha_CCP = @pFecha_CCP,
		Base_Ganancias = @pBase_Ganancias,
		Importacion = @pImportacion,
		Origen_Id = dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id),
		ComCondPago_Id = dbo.FuncFKcomConPago(@pComCondPago_Id),
		CondFiscal_Id = dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		FechaFiscal = @pFechaFiscal,
		ClaveFiscal = @pClaveFiscal,
		VieneDeFiscal = @pVieneDeFiscal,
		XMLFiscal = @pXMLFiscal,
		Importe = @pImporte,
		Saldo = @pSaldo,
		TipoCompFE = @pTipoCompFE, 
		FacturaTesoreria = @pFacturaTesoreria,
		RenglonDtoFin = @pRenglonDtoFin
	WHERE (comMovProv = @pidentity)
END 
ELSE 
BEGIN 
	INSERT INTO comMovProv
	(
		comMovProv,
		Proveed_Id,
		Tipomov,
		TipoCtaProv,
		Fecha_CCP,
		Base_Ganancias,
		Importacion,
		Origen_Id,
		ComCondPago_Id,
		CondFiscal_Id,
		FechaFiscal,
		ClaveFiscal,
		VieneDeFiscal,
		XMLFiscal,
		Importe,
		Saldo,
		TipoCompFE, 
		FacturaTesoreria, 
		RenglonDtoFin
	)
	VALUES 
	(
		@pidentity,
		dbo.FuncFkcomProveedores(@pProveed_Id),
		@pTipomov,
		@pTipoCtaProv,
		@pFecha_CCP,
		@pBase_Ganancias,
		@pImportacion,
		dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id),
		dbo.FuncFKcomConPago(@pComCondPago_Id),
		dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		@pFechaFiscal,
		@pClaveFiscal,
		@pVieneDeFiscal,
		@pXMLFiscal,
		@pImporte,
		@pSaldo,
		@pTipoCompFE, 
		@pFacturaTesoreria, 
		@pRenglonDtoFin
	)
END 

GO


DROP PROCEDURE comMovProvDatos
GO
CREATE PROCEDURE comMovProvDatos (
@pComMovprov bigint
)
AS

SELECT comMovProv.comMovProv, 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, comMovProv.Tipomov,
	conAsientos.Posteado, conAsientos.Fecha, conAsientos.FechaRegistro, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones,  disFormularios.Formulario_Id as Formulario,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores,
	comMovProv.TipoCtaProv, comProveedoresTipoPasivo.Descripcion as DescripcionProveedoresTipoPasivo, 
	comMovProv.Fecha_CCP, comMovProv.Base_Ganancias, comMovProv.Importacion, 
	comOrigenesFiscales.Origen_Id, comOrigenesFiscales.Descripcion as DescripcionOrCredFisc, 
	comConPago.CondPago_Id, comConPago.Descripcion as DescripcionConPago, 
	comCondFiscal.CondFiscal_Id,comCondFiscal.Descripcion as DescripcionCondFiscal, 
	comMovProv.FechaFiscal, comMovProv.ClaveFiscal, comMovProv.VieneDeFiscal,
	comMovProv.XMLFiscal, comMovProv.Importe, comMovProv.Saldo, comMovProv.TipoCompFE,
	genTiposCompAfip.Descripcion DescripcionTipoCompFE,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.TipoMov as TipomovCont, conMovCont.Clase, conMovCont.Importe as ImporteContable, 
	genMovimientos.CantCuotas, 
	(SELECT MIN(genMovCuotas.FechaVencimiento) FROM genMovCuotas where
		genMovCuotas.Asiento_Id = comMovProv.comMovProv) as FechaVencimiento,
	conCuentas.Cuenta_Id as CtaProveedores, conCuentas.Descripcion as DescripcionCtaProveedores, 
	FacturaTesoreria, Cast(0 as bit) Cierre, conAsientos.Fecha as FechaCierre, '' as RFCPrveedor, 
	RenglonDtoFin, ' ' AS ArchivoXML
FROM comMovProv 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovProv.comMovProv 
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER JOIN conAsientos ON comMovProv.comMovProv  = conAsientos.conAsientos
INNER JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = comMovProv.comMovProv  and conMovCont.Clase in('PRO','ANTPR')
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.cuenta_Id 
LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN genMovimientos  ON (genMovimientos.Asiento_Id = comMovProv.comMovProv)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comMovProv.Proveed_Id)
Left JOIN comProveedoresTipoPasivo  ON (comProveedoresTipoPasivo.TipoCtaProv = comMovProv.TipoCtaProv)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
LEFT JOIN comOrigenesFiscales  ON (comOrigenesFiscales.comOrigenesFiscales = comMovProv.Origen_Id)
LEFT JOIN comConPago  ON (comConPago.comConPago = comMovProv.ComCondPago_Id)
LEFT JOIN comCondFiscal  ON (comCondFiscal.comCondFiscal = comMovProv.CondFiscal_Id)
Left Join genTiposCompAfip On genTiposCompAfip.Comprobante_Id = comMovProv.TipoCompFE
WHERE (comMovProv = @pComMovprov)

GO



DROP PROCEDURE comMovProvDatosSinStock
GO
CREATE PROCEDURE comMovProvDatosSinStock
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
Declare @pidentity bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

PRINT @pIdentity

exec comMovprovDatos @pidentity


SELECT comMovDetalle.comMovProv, comMovDetalle.Renglon, comMovDetalle.Detalle,
	comMovDetalle.Importe, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, 	conCentro2.Descripcion as DescripcionCentro2, 
	conBaseDistri.Base_Id, conBaseDistri.Descripcion as DescripcionBaseDistri
FROM comMovDetalle 
INNER JOIN comMovProv  ON (comMovProv.comMovProv = comMovDetalle.comMovProv)
LEFT JOIN conCuentas ON (conCuentas.conCuentas = comMovDetalle.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comMovDetalle.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comMovDetalle.Centro2_Id)
LEFT JOIN conBaseDistri  ON (conBaseDistri.conBaseDistri = comMovDetalle.Base_Id)
WHERE (comMovProv.comMovProv = @pidentity)
order by 2


exec comMovImpuestosDatos @pidentity, null
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comMovProv' 
Exec genMovCuotasDatos @pidentity, null

-- AJ MAY 2019 para poder controlar si es del mismo en que rendicion esta
Exec tesRengMovicomMovProvDatosXcomMovProv @pidentity
--Exec genSegmentosConfiguracion @pSegmento_Id, @pEmpresa_Id

Exec genAdjuntosDatos 'comMovprov', @pIdentity, 0

-- FM 04/03/2022 Detalle de los impuestos que van al costo --
Select 0 Renglon, '' Cuenta_Id, '' DescripcionCuenta, '' Centro1_Id, '' DescripcionCentro1, '' Centro2_Id, '' DescripcionCentro2, Cast(0 As numeric(18,2)) Importe

RETURN @@Error 
GO

DROP PROCEDURE comMovProvEliminar
GO
CREATE PROCEDURE comMovProvEliminar
(
@pcomMovProv bigint
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProv WHERE (comMovProv = @pcomMovProv)
 
RETURN @@Error 

GO

DROP PROCEDURE [dbo].[comMovProvDatosConStock]
GO

CREATE PROCEDURE [dbo].[comMovProvDatosConStock]
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
Declare @pIdentity bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id =  dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec comMovprovDatos @pIdentity


SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, 0 RenglonReferencia, stkMoviCuerpo.Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkProductos.Producto_Id, 
	stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad,
	stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal,
	stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion DescripcionUnidadAlterna,
	stkMoviCuerpo.CantidadAlternaForm,
	stkMoviCuerpo.Observaciones, stkMoviCuerpo.Descuento, 
	stkMoviCuerpo.conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_Id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_Id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	conMovContDebe.Clase as ClaseDebe, conMovContDebe.Importe as ImporteContableDebe, 
	stkMoviCuerpo.conRenglonHaber, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conCentro1Haber.Centro1_Id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_Id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber, comDespachos.Despacho_Id
FROM stkMoviCuerpo 
INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
LEFT JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
LEFT JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
LEFT JOIN stkUniMed ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = stkMoviCuerpo.stkMoviCabe AND conMovCont.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conMovCont conMovCont2 ON conMovCont2.conAsientos = stkMoviCuerpo.stkMoviCabe AND conMovCont2.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conMovCont as conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.cuenta_Id 
left JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = conMovContDebe.Centro1_Id
left JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = conMovContDebe.Centro2_Id
INNER JOIN conMovCont as conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.cuenta_Id 
left JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = conMovContHaber.Centro1_Id
left JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = conMovContHaber.Centro2_Id
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
Left Join stkMoviDespa On stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And stkMoviDespa.Renglon = stkMoviCuerpo.Renglon
Left Join comDespachos On comDespachos.comDespachos = stkMoviDespa.Despacho_Id
WHERE 
	stkMoviCuerpo.stkMoviCabe = @pIdentity
ORDER BY 2


exec comMovImpuestosDatos @pIdentity, null
Exec genAtributosGeneralesIdentityDatos @pIdentity, 'comMovProv' 
Exec genMovCuotasDatos @pIdentity, null
-- Exec genSegmentosConfiguracion @pSegmento_Id, @pEmpresa_Id

Exec stkMoviSerieDatos @pIdentity
Exec stkMoviDespaDatos @pIdentity


-- AJ Abr 19 Se agrega la posibilidad de Ajuste positivo o Negativo

Select commovprov.RenglonDtoFin , conCuentas.Cuenta_Id, 
	conCuentas.Descripcion as DescripcionCuenta, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal, 
	conMovCont.LeyendaLibroMayor as Leyenda
from commovprov inner join conMovCont on 
commovprov.comMovProv = conMovcont.conAsientos and 
commovprov.RenglonDtoFin = conMovcont.Renglon
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conmovCont.Cuenta_Id
LEFT JOIN conCentro1 ON
conCentro1.conCentro1 = conMovcont.Centro1_Id
LEFT JOIN conCentro2 ON 
conCentro2.conCentro2 = conMovcont.Centro2_Id
Where
	comMovProv.comMovProv = @pIdentity

Exec stkMoviUbicacionDatos @pIdentity

Exec genAdjuntosDatos 'comMovprov', @pIdentity, 0

RETURN @@Error 

GO




DROP PROCEDURE comMovProvDatosConsulta
GO
CREATE PROCEDURE comMovProvDatosConsulta
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
Declare @pidentity bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec comMovprovDatos @pidentity



SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProducto, 
	stkMoviCuerpo.Fecha, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, 
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUnimed, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad, stkMoviCuerpo.CantidadForm Cantidad_Original, 
	stkMoviCuerpo.CostoUnitario, 
	stkMoviCuerpo.PrecioOriginal, stkMoviCuerpo.Observaciones, 
	stkMoviCuerpo.Descuento, 
	stkMoviCuerpo.conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_Id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_Id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	conMovContDebe.Clase as ClaseDebe, conMovContDebe.Importe as ImporteContableDebe, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	stkMoviCuerpo.conRenglonHaber	,
	conCentro1Haber.Centro1_Id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_Id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber
FROM stkMoviCuerpo INNER JOIN stkProductos ON
	stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
	INNER JOIN stkUniMed ON
	stkMoviCuerpo.Medida_Id = stkUniMed.stkUniMed
	INNER JOIN stkDepositos ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	INNER JOIN conMovCont as conMovContDebe ON
	conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
	INNER JOIN conCuentas as conCuentasDebe ON 
	conCuentasDebe.conCuentas = conMovContDebe.cuenta_Id 
	INNER JOIN conCentro1 as conCentro1Debe ON 
	conCentro1Debe.conCentro1 = conMovContDebe.Centro1_Id
	INNER JOIN conCentro2  as conCentro2Debe ON 
	conCentro2Debe.conCentro2 = conMovContDebe.Centro2_Id
	INNER JOIN conMovCont as conMovContHaber ON
	conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
	INNER JOIN conCuentas as conCuentasHaber ON 
	conCuentasHaber.conCuentas = conMovContHaber.cuenta_Id 
	INNER JOIN conCentro1 as conCentro1Haber ON 
	conCentro1Haber.conCentro1 = conMovContHaber.Centro1_Id
	INNER JOIN conCentro2  as conCentro2Haber ON 
	conCentro2Haber.conCentro2 = conMovContHaber.Centro2_Id
Where 
	stkMoviCuerpo.stkMoviCabe = @pidentity
UNION ALL
SELECT comMovDetalle.comMovProv, comMovDetalle.Renglon, 
	null as Producto_Id , comMovDetalle.Detalle DescripcionProducto, 
	NULL AS Fecha, Null AS Deposito_Id, Null AS DescripcionDeposito,
	Null AS Medida_Id, Null AS DescripcionUniMed,
	1 AS Factor, 1 AS Cantidad, 1 AS Cantidad_Original,
	comMovDetalle.Importe AS Costo_Unitario,
	comMovDetalle.Importe AS PrecioOriginal, null AS Observaciones, 
	0 as Descuento,
	NULL RenglonDebe,
	case when comMovTipos.Signo=-1 THEN  conCuentas.Cuenta_Id ELSE NULL END  CuentaDebe, 
	case when comMovTipos.Signo=-1 THEN  conCuentas.Descripcion ELSE NULL END  DescripcionCuentaDebe,
	case when comMovTipos.Signo=-1 THEN  conCentro1.Centro1_Id ELSE NULL END Centro1Debe, 
	case when comMovTipos.Signo=-1 THEN  conCentro1.Descripcion ELSE NULL END  DescripcionCentro1Debe,
	case when comMovTipos.Signo=-1 THEN  conCentro2.Centro2_Id ELSE NULL END  Centro2Debe, 
	case when comMovTipos.Signo=-1 THEN  conCentro2.Descripcion ELSE NULL END DescripcionCentro2Debe,
	NULL ClaseDebe, 
	NULL as ImporteContableDebe,
	case when comMovTipos.Signo=1 THEN  conCuentas.Cuenta_Id ELSE NULL END  CuentaHaber, 
	case when comMovTipos.Signo=1 THEN  conCuentas.Descripcion ELSE NULL END  DescripcionCuentaHaber,
	NULL as RenglonHaber,
	case when comMovTipos.Signo=1 THEN  conCentro1.Centro1_Id ELSE NULL END Centro1Haber, 
	case when comMovTipos.Signo=1 THEN  conCentro1.Descripcion ELSE NULL END  DescripcionCentro1Haber,
	case when comMovTipos.Signo=1 THEN  conCentro2.Centro2_Id ELSE NULL END  Centro2Haber, 
	case when comMovTipos.Signo=1 THEN  conCentro2.Descripcion ELSE NULL END DescripcionCentro2Haber,
	NULL as  ClaseHaber, 
	NULL as ImporteContableHaber
FROM comMovDetalle INNER JOIN comMovprov ON
comMovprov.comMovprov = comMovDetalle.comMovProv
INNER JOIN comMovTipos ON
comMovTipos.TipoMov = comMovprov.Tipomov
INNER JOIN conCuentas ON 
conCuentas.conCuentas = comMovDetalle.Cuenta_Id 
left JOIN conCentro1 ON 
conCentro1.conCentro1 = comMovDetalle.Centro1_Id
left JOIN conCentro2 ON 
conCentro2.conCentro2 = comMovDetalle.Centro2_Id
Where 
	comMovDetalle.comMovProv = @pidentity
	
ORDER BY 2


exec comMovImpuestosDatos @pidentity, null
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comMovProv' 
Exec genMovCuotasDatos @pidentity, null


RETURN @@Error 

GO

DROP Procedure comMovProvxClaveFiscal
GO
Create Procedure comMovProvxClaveFiscal(
	@ClaveFiscal VarChar(36),
	@Empresa_Id iNT
)
AS

Select dbo.Segmento( genAsiSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	conAsientos.Fecha, comMovProv.ClaveFiscal
from comMovProv 
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id= conAsientos.conAsientos
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_Id
Where
	comMovProv.ClaveFiscal = @ClaveFiscal AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id= @Empresa_Id
GO
	


