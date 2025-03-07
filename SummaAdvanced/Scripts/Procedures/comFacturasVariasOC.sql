-- exec comFacturasVariasOCDatos 1,'FPRO',0,0,0,0, ' ',' ',' ',' ', 'BSD', 'PES'




DROP PROCEDURE comFacturasVariasOCDatos
GO
CREATE PROCEDURE comFacturasVariasOCDatos
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
@pProveed_id VarChar(15),
@pMoneda_Id VarChar(5)
)


AS
SET NOCOUNT ON 

DECLARE @pComMovProv bigint

SET @pComMovProv = (
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
	
	
exec comMovprovDatos @pComMovProv

if @pComMovProv is null
BEGIN

	-- Productos pendientes --
	SELECT Convert(bigint, 0) AS comMovProv, 
		dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N, 
		comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as Segmento_str,
		genSegmentos.Segmento_Id, comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, 
		comOCSegmentos.Segmento4N,comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
		comOrdenComp.Fecha, genMonedas.Moneda_Id, comOCCuerpo.Renglon_OC Renglon, 0 RenglonReferencia, 	
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		comOCArticulo.Factor, comOCCuerpo.Cantidad*0 as Cantidad, comOCCuerpo.Cantidad*0 as CantidadForm, comOCArticulo.PrecioOriginal as CostoUnitario, 
		comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
		comOCArticulo.CantidadOriginal as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, 'P' ProdMemo
	FROM comOCSegmentos
	INNER JOIN comOcCuerpo ON comOCSegmentos.comOrdenComp = comOcCuerpo.comOrdenComp
	INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	INNER JOIN comOrdenComp ON comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comProveedores ON  comProveedores.genEntidades = comOrdenComp.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	inner join comTipoPermi ON comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id
	WHERE 
		comTipoPermi.Importaciones = 0 and 
		comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos>0 and 
		comOCSegmentos.Empresa_Id =@pEmpresa_id and 
		comProveedores.Proveed_Id = @pProveed_id AND 
		genMonedas.Moneda_Id = @pMoneda_Id
	Union all
	-- Memos pendientes --
	SELECT Convert(bigint, 0) AS comMovProv, 
		dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N, 
		comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as Segmento_str,
		genSegmentos.Segmento_Id, comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, 
		comOCSegmentos.Segmento4N,comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOrdenComp.Fecha, genMonedas.Moneda_Id,
		comOCCuerpo.Renglon_OC Renglon, 0 RenglonReferencia, ' ' Producto_Id, comOCMemo.Detalle as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 1 Factor, comOCCuerpo.Cantidad*0 as Cantidad,
		comOCCuerpo.Cantidad*0 as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
		comOcCuerpo.Precio PrecioOriginal, 0 as conRenglonDebe, 
		 comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, 'M' ProdMemo
	FROM comOCSegmentos 
	INNER JOIN comOcCuerpo ON comOCSegmentos.comOrdenComp = comOcCuerpo.comOrdenComp
	INNER JOIN comOCMemo ON comOCCuerpo.comOrdenComp = comOCMemo.comOrdenComp and 
		comOcCuerpo.Renglon_OC = comOCMemo.Renglon_OC
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	INNER JOIN comOrdenComp ON comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	WHERE 
		comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada +comOCCuerpo.Cantidad_Creditos>0 and 
		comOCSegmentos.Empresa_Id =@pEmpresa_id and 
		comOCSegmentos.Empresa_Id =@pEmpresa_id and 
		comProveedores.Proveed_Id = @pProveed_id AND 
		genMonedas.Moneda_Id = @pMoneda_Id

 
END

ELSE
-- Cuerpo
BEGIN

	-- Productos consulta de factura --
	SELECT comMovPOC.comMovProv, 
		dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N, 
		comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as Segmento_str,
		genSegmentos.Segmento_Id, comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, 
		comOCSegmentos.Segmento4N,comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOrdenComp.Fecha, genMonedas.Moneda_Id,
		comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, comOCArticulo.Factor, comMovPOC.Cantidad as Cantidad,
		comMovPOC.CantidadOriginal as CantidadForm, comOCArticulo.PrecioOriginal as CostoUnitario, 
		comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
		comOCArticulo.CantidadOriginal as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, 'P' ProdMemo
	FROM comMovPOC inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
	INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and 
		comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	INNER JOIN comOrdenComp ON comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	Inner Join genMonedas genMonedasOC On genMonedasOC.genMonedas = comOrdenComp.Moneda_Id
	WHERE 
		comMovPOC.comMovProv = @pComMovProv

	UNION ALL

	-- Memos consulta de factura --
	SELECT comMovPOC.comMovProv, 
	dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N, 
		comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as Segmento_str,
		genSegmentos.Segmento_Id, comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,comOCSegmentos.Segmento3N, 
		comOCSegmentos.Segmento4N,comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOrdenComp.Fecha, genMonedas.Moneda_Id,
		comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, ' ' Producto_Id, comOCMemo.Detalle as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 1 Factor, comMovPOC.Cantidad as Cantidad,
		comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
		comOCCuerpo.Precio AS PrecioOriginal, 0 as conRenglonDebe, 
		comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada +comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, 'M' ProdMemo
	FROM comMovPOC 
	inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
	INNER JOIN comOCMemo ON comOcCuerpo.comOrdenComp = comOCMemo.comOrdenComp and 
		comOcCuerpo.Renglon_OC = comOCMemo.Renglon_OC
	INNER JOIN stkUniMed ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	INNER JOIN comOrdenComp ON comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	Inner Join genMonedas genMonedasOC On genMonedasOC.genMonedas = comOrdenComp.Moneda_Id
	WHERE 
		comMovPOC.comMovProv = @pComMovProv

END


exec comMovImpuestosDatos @pComMovProv, null
Exec genAtributosGeneralesIdentityDatos @pComMovProv, 'comMovProv' 
Exec genMovCuotasDatos @pComMovProv, null

if @pComMovProv is null
BEGIN
-- Busco la Moneda base --
	Select genMonedas.Moneda_Id MonedaOc, genMonedas.Descripcion
	From genEmpresas
	Inner Join genMonedas On genMonedas.genMonedas = genEmpresas.Moneda_Id
	Where genEmpresas.genEmpresas = @pEmpresa_Id
End
Else
Begin
-- Busco la moneda de las Oc
	Select genMonedas.Moneda_Id MonedaOc, genMonedas.Descripcion
	From comOrdenComp 
	Inner Join comMovPOC On comMovPOC.comOrdenComp = comOrdenComp.comOrdenComp
	Inner Join genMonedas On genMonedas.genMonedas = comOrdenComp.Moneda_Id
	Where comMovPOC.comMovProv = @pComMovProv
End

-- FM 05/06/2019 Descuento/Recargo --
Select commovprov.RenglonDtoFin , conCuentas.Cuenta_Id, 
	conCuentas.Descripcion as DescripcionCuenta, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal, 
	conMovCont.LeyendaLibroMayor as Leyenda
From commovprov 
inner join conMovCont on commovprov.comMovProv = conMovcont.conAsientos and commovprov.RenglonDtoFin = conMovcont.Renglon
INNER JOIN conCuentas ON conCuentas.conCuentas = conmovCont.Cuenta_Id
LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovcont.Centro1_Id
LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovcont.Centro2_Id
Where comMovProv.comMovProv = @pComMovProv

Exec genAdjuntosDatos 'comMovprov', @pComMovProv, 0
 
RETURN @@Error 

GO

