--exec stkExistenciaXSerieXUbi 1, 'PRUEBA', 'UNI', '3'

Drop procedure stkExistenciaXSerieXUbi
Go
Create procedure stkExistenciaXSerieXUbi
(
@pEmpresa_Id int,
@pProducto_Id varchar(25),
@pMedida_Id varchar(5),
@pDeposito_Id varchar(15),
@pTipoSerieUni char(1),
@pRestaRepartos Sino = Null
)
As

Select @pProducto_Id Producto_Id, @pMedida_Id Medida_Id, @pDeposito_Id Deposito_Id, @pTipoSerieUni TipoSerieUni, @pRestaRepartos RestaRepartos

Select Cast(0 as bigint) stkMoviCabe, 0 Renglon, stkExistenciaSerie.Serie, Cast(0 as numeric(19,8)) Cantidad, Cast(0 as numeric(19,8)) CantidadAlterna, 
	stkSerieVencimiento.Vencimiento, isNull(stkUbicaciones.Ubicacion_Id, '') Ubicacion_Id, 
	(isNull(stkExistenciaUbiSerie.Cantidad, stkExistenciaSerie.Cantidad) - 
	
	isNull((Select Sum(venRepaPediSerieUbi.Cantidad) 
		From venReparto
		Inner Join venRepaPediSerieUbi On venRepaPediSerieUbi.venReparto = venReparto.venReparto
		Inner Join venRepaPedi On venRepaPedi.venReparto = venRepaPediSerieUbi.venReparto And venRepaPedi.Renglon_Rep = venRepaPediSerieUbi.Renglon_Rep
		Inner Join venPediCuerpo On venPediCuerpo.venPedidos = venRepaPedi.venPedidos And venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe
		Where venReparto.Cerrado = 0 And venRepaPedi.Remitido = 0 And venPediCuerpo.Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) And
		venPediCuerpo.Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) And venRepaPediSerieUbi.Serie = stkExistenciaSerie.Serie And 
		venRepaPediSerieUbi.Ubicacion_Id = stkExistenciaUbiSerie.Ubicacion_Id And isNull(@pRestaRepartos, 0) = 1), 0) -
	isNull((Select Sum(venRepaPediSerie.Cantidad) 
		From venReparto
		Inner Join venRepaPediSerie On venRepaPediSerie.venReparto = venReparto.venReparto
		Inner Join venRepaPedi On venRepaPedi.venReparto = venRepaPediSerie.venReparto And venRepaPedi.Renglon_Rep = venRepaPediSerie.Renglon_Rep
		Inner Join venPediCuerpo On venPediCuerpo.venPedidos = venRepaPedi.venPedidos And venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe
		Left Join venRepaPediSerieUbi On venRepaPediSerieUbi.venReparto = venRepaPediSerie.venReparto And 
			venRepaPediSerieUbi.Renglon_Rep = venRepaPediSerie.Renglon_Rep And venRepaPediSerieUbi.venPedidos = venRepaPediSerie.venPedidos And 
			venRepaPediSerieUbi.Renglon_Pe = venRepaPediSerie.Renglon_Pe And venRepaPediSerieUbi.Serie = venRepaPediSerie.Serie
		Where venRepaPediSerieUbi.venReparto is Null And venReparto.Cerrado = 0 And venRepaPedi.Remitido = 0 And venPediCuerpo.Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) And
		venPediCuerpo.Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) And venRepaPediSerie.Serie = stkExistenciaSerie.Serie And isNull(@pRestaRepartos, 0) = 1), 0)
	)
	/ vProductoMedida.Factor Existencia
From stkExistenciaSerie
Inner Join stkProductos On stkProductos.stkProductos = stkExistenciaSerie.Producto_Id
Inner Join vProductoMedida On vProductoMedida.Producto_Id = @pProducto_Id And vProductoMedida.Medida_Id = @pMedida_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkExistenciaSerie.Deposito_Id
Left Join stkSerieVencimiento On stkSerieVencimiento.Empresa_Id = stkExistenciaSerie.Empresa_Id And 
	stkSerieVencimiento.Producto_Id = stkExistenciaSerie.Producto_Id And stkSerieVencimiento.Serie = stkExistenciaSerie.Serie
Left Join (stkExistenciaUbiSerie Inner Join stkUbicaciones On stkUbicaciones.stkUbicaciones = stkExistenciaUbiSerie.Ubicacion_Id) 
	On stkExistenciaUbiSerie.Empresa_Id = stkExistenciaSerie.Empresa_Id And
		stkExistenciaUbiSerie.Producto_Id = stkExistenciaSerie.Producto_Id And stkExistenciaUbiSerie.Deposito_Id = stkExistenciaSerie.Deposito_Id And
		stkExistenciaUbiSerie.Serie = stkExistenciaSerie.Serie
Where stkProductos.Producto_Id = @pProducto_Id And
stkDepositos.Deposito_Id = @pDeposito_Id And stkExistenciaSerie.Empresa_Id = @pEmpresa_Id And
stkExistenciaSerie.Cantidad <> 0 And isNull(stkExistenciaUbiSerie.Cantidad, 1) <> 0 And @pTipoSerieUni = 'S'
ORDER BY 6, 3

Select Cast(0 as bigint) stkMoviCabe, 0 Renglon, Cast(0 as numeric(19,8)) Cantidad, Cast(0 as numeric(19,8)) CantidadAlterna, 
	stkUbicaciones.Ubicacion_Id, stkExistenciaUbi.Cantidad / vProductoMedida.Factor Existencia, stkExistenciaUbi.CantidadAlterna ExistenciaAlterna
From stkExistencia
Inner Join stkProductos On stkProductos.stkProductos = stkExistencia.Producto_Id
Inner Join vProductoMedida On vProductoMedida.Producto_Id = @pProducto_Id And vProductoMedida.Medida_Id = @pMedida_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkExistencia.Deposito_Id
Inner Join stkExistenciaUbi On stkExistenciaUbi.Empresa_Id = stkExistencia.Empresa_Id And stkExistenciaUbi.Producto_Id = stkExistencia.Producto_Id And
	stkExistenciaUbi.Deposito_Id = stkExistencia.Deposito_Id
Inner Join stkUbicaciones On stkUbicaciones.stkUbicaciones = stkExistenciaUbi.Ubicacion_Id
Where stkProductos.Producto_Id = @pProducto_Id And
stkDepositos.Deposito_Id = @pDeposito_Id And stkExistencia.Empresa_Id = @pEmpresa_Id And
stkExistencia.Cantidad <> 0 And isNull(stkExistenciaUbi.Cantidad, 1) <> 0 And @pTipoSerieUni = 'U'
Go


