
-- INF_comOrdenCompra  1,'20200101','20211030',' ','zzz',' ','ZZZZ',1, 1
DROP PROCEDURE INF_comOrdenCompra 
GO
CREATE PROCEDURE INF_comOrdenCompra 
(
	@Empresa int,
	@FechaDesde DateTime , 
	@FechaHasta DateTime, 
	@ProveedDesde Char(15),
	@ProveedHasta Char(15),
	@ProductoDesde Char(25),
	@ProductoHasta Char(25),
	@Tipo Int,
	@Estado_id Int,
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8)
)
/* Tipo es 1 - Todas - 2 Solo Pendientes */
AS
SELECT comOrdenComp.comOrdenComp, dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C,comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) AS Segmento,
	comOCCuerpo.Renglon_OC,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial,
	comTipoPermi.TipoPermi_Id, comTipoPermi.Descripcion as DescripcionTipoPermi,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda,
	isnull(genUsuarios.Usuario_Id,'') as Autorizo, 
	comConPago.CondPago_Id, comConPago.Descripcion as DescripcionCondPago,
	ISNULL(comOrdenComp.Observaciones,'') Observaciones, comOrdenComp.Estado_Id, 
	comOrdenComp.ImporteImpuestos, comOrdenComp.Cambio, 
	Usuario.Usuario_Id as Ingreso,
	comOCCuerpo.Renglon_OC, comOCCuerpo.Cantidad, comOCCuerpo.Cantidad_Recibida, 
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Cantidad_Creditos, 
	CASE WHEN @Estado_id = 5 THEN ISNULL((SELECT MAX(conAsientos.Fecha) 
		From conAsientos , stkMoviOC where
		conAsientos.conAsientos =stkMoviOC.stkMoviCabe and 
		stkMoviOC.comOrdenComp = comOrdencomp.comOrdenComp and 
		conAsientos.Anulado = 0 and conAsientos.Posteado = 1),comOCCuerpo.Fecha_Entrega) 
	ELSE (SELECT MAX(A.Fecha_Entrega) FROM (SELECT Fecha_Entrega FROM comOcCuerpo comOCC
		WHERE comOCC.comOrdenComp = comOrdencomp.comOrdenComp AND comOCC.Renglon_OC = comOCCuerpo.Renglon_OC
		UNION ALL SELECT MAX(conAsientos.Fecha) Fecha
		FROM conAsientos INNER JOIN stkMoviOC ON
		conAsientos.conAsientos = stkMoviOC.stkMoviCabe AND
		stkMoviOC.comOrdenComp = comOrdencomp.comOrdenComp
		WHERE conAsientos.Anulado = 0 and conAsientos.Posteado = 1
		GROUP BY stkMoviOC.comOrdenComp) A) 
	END AS Fecha_Entrega, 
	comOCCuerpo.Precio, Convert(Numeric(18,2),comOCCuerpo.Precio*
		CASE WHEN @Estado_Id = 4 THEN  comOCCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada
		WHEN @Estado_Id = 7 then comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Recibida ELSE comOCCuerpo.Cantidad END) as SubTotal,
	ISNULL(conCentro1.Centro1_Id,'') AS Centro1_Id , ISNULL(conCentro1.Descripcion,'') as DescripcionC1,
	ISNULL(conCentro2.Centro2_Id,'') AS Centro2_Id , ISNULL(conCentro2.Descripcion,'') as DescripcionC2,
	ISNULL(stkUniMed.Medida_Id,'') AS Medida_Id, 
	ISNULL(stkProductos.Producto_Id,'') as Producto_id, 
	ISNULL(stkProductos.Descripcion, comOCMemo.Detalle) as DescripcionProducto, 
	ISNULL(conCuentasP.Cuenta_Id, conCuentasM.Cuenta_Id) as Cuenta_Id, 
	ISNULL(conCuentasP.Descripcion, conCuentasM.Descripcion) as DescripcionCuenta,
	ISNULL(stkDepositos.Deposito_Id,'') Deposito_id, 
	comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Recibida as CantidadPendiente
FROM comOrdenComp 
	INNER Join comOCSegmentos ON comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_Id
	INNER JOIN comTipoPermi ON comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	LEFT JOIN genUsuarios ON genUsuarios.genUsuarios = comOrdenComp.Autorizo
	INNER JOIN comConPago ON comConPago.comConPago = comOrdenComp.CondPago_Id
	inner JOIN genUsuarios as Usuario ON Usuario.genUsuarios = comOrdenComp.Usuario_Id
	INNER JOIN comOCCuerpo ON comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp
	LEFT JOIN conCentro1 ON conCentro1.conCentro1 = comOCCuerpo.Centro1_Id
	LEFT JOIN conCentro2 ON conCentro2.conCentro2 = comOCCuerpo.Centro2_Id
	LEFT JOIN stkUniMed ON stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
	LEFT JOIN (comOCArticulo inner join stkProductos ON 
		comOCArticulo.Producto_Id= stkProductos.stkProductos
		INNER JOIN stkDepositos ON comOCArticulo.Deposito_Id = stkDepositos.stkDepositos
		LEFT JOIN conCuentas conCuentasP ON
		conCuentasP.conCuentas= stkProductos.CtaCompra) ON
		comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp and
		comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
	LEFT JOIN (comOCMemo INNER JOIN conCuentas conCuentasM ON 
		comOCMemo.Cuenta_Id= conCuentasM.conCuentas) ON
		comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp and
		comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
WHERE
	(comOCSegmentos.Empresa_Id = @Empresa) and
	(comordenComp.Fecha Between @FechaDesde and @FechaHasta) and
	(comProveedores.Proveed_Id Between @ProveedDesde And @ProveedHasta) and
	((stkProductos.Producto_Id Between @ProductoDesde And @ProductoHasta Or (@ProductoDesde = ' ' and  stkProductos.Producto_Id Is Null))) And
	((@Tipo = 1 or (comOrdenComp.Estado_Id IN ('A','P','E') And comOCCuerpo.Pendiente = 1)) AND
	/*Todos*/
	(@Estado_Id = '6' OR
	/*Pendientes de Autorizacion */
	(comOrdenComp.Estado_Id = 'P' AND @Estado_Id = 1) OR
	/*Autorizadas*/
	(comOrdenComp.Estado_Id = 'A' AND @Estado_Id = 2) OR
	/*Rechazadas*/
	(comOrdenComp.Estado_Id = 'R' AND @Estado_Id = 3) OR
	/*Pendiente de Factura */
	(comOCCuerpo.Cantidad_Recibida > comOCCuerpo.Cantidad_Facturada AND @Estado_Id = 4) OR
	-- Pendiente de Recibir
	(comOCCuerpo.Pendiente = 1  and comOCCuerpo.Cantidad > comOCCuerpo.Cantidad_Recibida AND @Estado_Id = 7) OR
	/*Terminadas*/
	(comOrdenComp.Estado_Id = 'T' AND @Estado_Id = 5))) and 
	ISNULL(conCentro1.Centro1_Id, ' ') BETWEEN @Centro1Desde AND @Centro1Hasta AND 
	ISNULL(conCentro2.Centro2_Id, ' ') BETWEEN @Centro2Desde AND @Centro2Hasta 
ORDER BY 1,3
GO
	



