DROP Procedure comComprasConsPendDatos
GO

Create Procedure comComprasConsPendDatos
(
	@Producto_Id VarChar(25),
	@Deposito_Id VarChar(5),
	@Empresa_Id int
)
as
select @Producto_Id as Producto_Id, @Deposito_Id Deposito_Id

SELECT comOCCuerpo.comOrdenComp, comOCCuerpo.Renglon_OC, 
	comOCCuerpo.CantidadConsignada - comOCCuerpo.Cantidad_Recibida as Cantidad, 
	genMonedas.Moneda_Id, conCuentas.Cuenta_Id
FROM comOCCuerpo 
	INNER JOIN comOCArticulo ON comOCCuerpo.comOrdenComp = comOCArticulo.comOrdencomp and 
							    comOCCuerpo.Renglon_OC = comOCArticulo.Renglon_OC
	INNER JOIN stkProductos ON  stkProductos.stkProductos = comOCArticulo.Producto_Id
	INNER JOIN comOrdenComp ON  comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp
	INNER JOIN stkDepositos ON  stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
	INNER JOIN comOCSegmentos ON comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
	inner join genMonedas on  genMonedas.genMonedas = comOrdenComp.Moneda_Id
	left JOIN conCuentas ON conCuentas.conCuentas = genMonedas.CtaFactaRecibir
WHERE
	stkProductos.Producto_Id = @Producto_Id and 
	stkDepositos.Deposito_id = @Deposito_Id and
	comOCSegmentos.Empresa_Id = @Empresa_Id and
	comOCCuerpo.CantidadConsignada > comOCCuerpo.Cantidad_Recibida and 
	comOrdenComp.Estado_Id IN ('A','P','E')
ORDER BY 1,2

GO
