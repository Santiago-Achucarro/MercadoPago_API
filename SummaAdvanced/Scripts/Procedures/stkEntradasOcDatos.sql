-- stkEntradasOcDatos 1, 'STK',0,0,0,0,' ',' ',' ',' ','OC',3,0,0,0,'0002',' ',' ',' '

DROP PROCEDURE stkEntradasOcDatos
GO
CREATE PROCEDURE stkEntradasOcDatos
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
@pSegmento_Id_OC VarChar(10), 
@pSegmento1N_OC int,
@pSegmento2N_OC int,
@pSegmento3N_OC int,
@pSegmento4N_OC int,
@pSegmento1C_OC VarChar(20),
@pSegmento2C_OC VarChar(20),
@pSegmento3C_OC VarChar(20),
@pSegmento4C_OC VarChar(20)

)
AS
SET NOCOUNT ON 

DECLARE @pstkMoviCabe bigint

SET @pstkMoviCabe = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id) and
	Segmento1N =@pSegmento1N and
	Segmento2N = @pSegmento2N and
	Segmento3N = @pSegmento3N and
	Segmento4N = @pSegmento4N and
	Segmento1C = @pSegmento1C and
	Segmento2C = @pSegmento2C and 
	Segmento3C = @pSegmento3C and 
	Segmento4C = @pSegmento4C )



	
SELECT stkMoviCabe.stkMoviCabe,
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, Cast(0 As Bit) DistribuyeContrapartida,
	conAsientos.Posteado, conAsientos.Fecha, conAsientos.FechaRegistro, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones,  disFormularios.Formulario_Id Formulario,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	stkSubTipoMov.SubTipoMov_Id, stkSubTipoMov.Descripcion as DescripcionSubTipoMov, 
	stkMoviCabe.ModificaCosto, 	stkMoviCabe.Signo, stkSubTipoMov.Tipomov, ' ' as Proveed_Id, 
			genSucursalesEmpr.Sucursal
FROM stkMoviCabe 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = stkMoviCabe.stkMoviCabe)
INNER JOIN stkSubTipoMov  ON (stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = stkMoviCabe.stkMoviCabe
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_id = genSegmentos.genSegmentos
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE (stkMoviCabe = @pstkMoviCabe)


if @pstkMoviCabe is null
BEGIN
-- Traigo el pendiente de recepción de la OC --
SELECT comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id

From comOCSegmentos 
INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
WHERE 
	
	comOCSegmentos.Empresa_Id =@pEmpresa_id and 
	comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
	comOCSegmentos.Segmento1N =@pSegmento1N_OC and
	comOCSegmentos.Segmento2N = @pSegmento2N_OC and
	comOCSegmentos.Segmento3N = @pSegmento3N_OC and
	comOCSegmentos.Segmento4N = @pSegmento4N_OC and
	comOCSegmentos.Segmento1C = @pSegmento1C_OC and
	comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
	comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
	comOCSegmentos.Segmento4C = @pSegmento4C_OC 
ORDER BY 2




SELECT Convert(bigint, 0) AS stkMoviCabe, comOCCuerpo.Renglon_OC Renglon, 0 RenglonReferencia, 
	comOCCuerpo.Fecha_Entrega Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	comOCArticulo.Factor, comOCCuerpo.Cantidad*0 as Cantidad,
	comOCCuerpo.Cantidad*0 as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
	comOCArticulo.PrecioOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna, 
	stkMedidaAlterna.Descripcion DescripcionMedidaAlterna,
	comOCCuerpo.Cantidad*0 As CantidadAlternaForm, ' ' Observaciones, 0.00 as Descuento, 0 as conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_Id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_Id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	' ' as ClaseDebe, comOCCuerpo.Precio*0  as ImporteContableDebe, 
	0 as conRenglonHaber, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	' ' as Centro1Haber, ' ' as DescripcionCentro1Haber,
	' ' as Centro2Haber, ' ' as DescripcionCentro2Haber,
	' '  as ClaseHaber, comOCCuerpo.Precio*0 as ImporteContableHaber, 
	comOcCuerpo.Renglon_oc, comOcArticulo.CantidadOriginal as CantidadOC, case when stkDepositos.consCompra_Venta=1 then comOCCuerpo.CantidadConsignada else comOCCuerpo.Cantidad_Recibida end as Cantidad_Recibida, 
	comOcCuerpo.Precio, '' Despacho_Id, comOCCuerpo.CantidadConsignada, '' as PegarSeries
FROM comOCSegmentos 
INNER JOIN comOcCuerpo ON comOCSegmentos.comOrdenComp = comOcCuerpo.comOrdenComp
INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = comOcArticulo.Deposito_Id)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
Inner Join comOrdenComp On comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp
Left Join genMonedas On genMonedas.genMonedas = comOrdenComp.Moneda_Id
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = stkProductos.CtaCompra
LEFT OUTER JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = comOcCuerpo.Centro1_id
LEFT OUTER JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = comOcCuerpo.Centro2_id
left outer Join conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = genMonedas.CtaFactaRecibir
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkProductos.MedidaAlterna

WHERE 
	comOCCuerpo.Cantidad > case when stkDepositos.consCompra_Venta=1 then comOCCuerpo.CantidadConsignada else comOCCuerpo.Cantidad_Recibida end and 
	comOCCuerpo.Pendiente = 1 and 
	comOCSegmentos.Empresa_Id =@pEmpresa_id and 
	comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
	comOCSegmentos.Segmento1N =@pSegmento1N_OC and
	comOCSegmentos.Segmento2N = @pSegmento2N_OC and
	comOCSegmentos.Segmento3N = @pSegmento3N_OC and
	comOCSegmentos.Segmento4N = @pSegmento4N_OC and
	comOCSegmentos.Segmento1C = @pSegmento1C_OC and
	comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
	comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
	comOCSegmentos.Segmento4C = @pSegmento4C_OC 
ORDER BY 2


END

ELSE
-- Cuerpo
-- Traigo el comprobante que se está consultando --
BEGIN

SELECT comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id

From comOCSegmentos 
INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id


WHERE 
	Exists(select 1 from stkmovioc where
		stkmovioc.stkMoviCabe = @pstkMoviCabe and 
		stkmovioc.comOrdenComp =	comOrdenComp.comOrdenComp) or
	Exists(select 1 from stkMoviConsigna Where
		stkMoviConsigna.stkMoviCabe = @pstkMoviCabe and 
		stkMoviConsigna.comOrdenComp =	comOrdenComp.comOrdenComp) 
ORDER BY 2


SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, 0 RenglonReferencia, stkMoviCuerpo.Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkProductos.Producto_Id, 
	stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad,
	stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal,
	stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion DescripcionMedidaAlterna,
	stkMoviCuerpo.CantidadalternaForm, stkMoviCuerpo.Observaciones, stkMoviCuerpo.Descuento, 
	stkMoviCuerpo.conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_Id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_Id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	conMovContDebe.Clase as ClaseDebe, conMovContDebe.Importe as ImporteContableDebe, 
	stkMoviCuerpo.conRenglonHaber, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conCentro1Haber.Centro1_id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber , 
	stkMoviOC.Renglon_oc Renglon_oc, 
	comOCArticulo.CantidadOriginal as CantidadOC, 
	isNull(case when stkDepositos.consCompra_Venta=1 then comOCCuerpo.CantidadConsignada else comOCCuerpo.Cantidad_Recibida end, 0) Cantidad_Recibida, 
	comOcCuerpo.Precio  as Precio, comDespachos.Despacho_Id, 
	comOCCuerpo.CantidadConsignada CantidadConsignada, '' as PegarSerie
FROM stkMoviCabe 
INNER JOIN stkMoviCuerpo ON (stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe) 
Left JOIN (stkMoviOC
INNER JOIN comOcCuerpo ON comOcCuerpo.comOrdenComp = stkMoviOC.comOrdenComp and comOcCuerpo.Renglon_OC = stkMoviOC.Renglon_oc
Inner Join comOCArticulo On comOCArticulo.comOrdenComp = stkMoviOC.comOrdenComp And comOCArticulo.Renglon_OC = stkMoviOC.Renglon_OC)
	  ON stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and stkMoviOC.Renglon = stkMoviCuerpo.Renglon
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = stkMoviCuerpo.Producto_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont.Renglon = stkMoviCuerpo.conRenglonDebe)
INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont2.Renglon = stkMoviCuerpo.conRenglonHaber)
INNER JOIN conMovCont as conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.cuenta_id 
LEFT OUTER  JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = conMovContDebe.Centro1_id
LEFT OUTER  JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = conMovContDebe.Centro2_id
INNER JOIN conMovCont as conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.cuenta_id 
LEFT OUTER JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = conMovContHaber.Centro1_id
LEFT OUTER JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = conMovContHaber.Centro2_id
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
left join (stkMoviDespa  INNER JOIN comDespachos ON stkMoviDespa.Despacho_Id = comDespachos.comDespachos) ON 
	stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
	stkMoviDespa.Renglon = stkMoviCuerpo.Renglon

WHERE (stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe)
ORDER BY 2
END


Exec genAtributosGeneralesIdentityDatos @pstkMoviCabe, 'stkMoviCabe' 

Exec stkMoviSerieDatos @pstkMoviCabe

Exec stkMoviDespaDatos @pstkMoviCabe

SELECT RemitoProv, FechaRemito 
	FROM stkMoviProv
	Where
	 stkMoviCabe = @pstkMoviCabe

Exec stkMoviUbicacionDatos @pstkMoviCabe
 
RETURN @@Error 

GO
