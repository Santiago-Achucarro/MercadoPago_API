--exec venGeneraRemitoFactura 1,'Reparto',7431,0,0,0,'0001','','','',1,1
--exec venGeneraRemitoFactura @pEmpresa_Id=1,@pSegmento_Id='REPARTO',@pSegmento1N=7431,@pSegmento2N=0,@pSegmento3N=0,@pSegmento4N=0,@pSegmento1C='0001',@pSegmento2C='',@pSegmento3C='',@pSegmento4C='',@pSoloRemito=1,@pConRemito=1
Drop procedure venGeneraRemitoFactura
Go

Create procedure venGeneraRemitoFactura
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
@pSoloRemito bit,
@pConRemito bit
)
As

Declare @pIdentity int = (Select venReparto From venRepaSegmentos
	Where
	venRepaSegmentos.Empresa_Id = @pEmpresa_Id and 
	venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venRepaSegmentos.Segmento1N = @pSegmento1N and 
	venRepaSegmentos.Segmento2N = @pSegmento2N and 
	venRepaSegmentos.Segmento3N = @pSegmento3N and 
	venRepaSegmentos.Segmento4N = @pSegmento4N and 
	venRepaSegmentos.Segmento1C = @pSegmento1C and 
	venRepaSegmentos.Segmento2C = @pSegmento2C and 
	venRepaSegmentos.Segmento3C = @pSegmento3C and 
	venRepaSegmentos.Segmento4C = @pSegmento4C)

Select venReparto.venReparto, '' as Segmento_Id_Fact, 0 as Segmento1N_Fact,
	0 as Segmento2N_Fact,0 as Segmento3N_Fact,0 as Segmento4N_Fact, '' as  Segmento1C_Fact, 
	 '' as Segmento2C_Fact, '' as Segmento3C_Fact, '' as  Segmento4C_Fact,
	 	 '' as  Segmento_Id_Rem, 0 as Segmento1N_Rem,
	0 as Segmento2N_Rem,0 as Segmento3N_Rem,0 as Segmento4N_Rem, '' as  Segmento1C_Rem, 
	 '' as Segmento2C_Rem, '' as Segmento3C_Rem,  '' as Segmento4C_Rem,
venRepaSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venRepaSegmentos.Segmento1N,
	venRepaSegmentos.Segmento2N,venRepaSegmentos.Segmento3N,venRepaSegmentos.Segmento4N, venRepaSegmentos.Segmento1C, 
	venRepaSegmentos.Segmento2C,venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C,
	venReparto.Cerrado, venReparto.Automatico, ' ' RemitoFactura, stkDepositos.Deposito_Id, stkDepositos.Descripcion DescripcionDeposito,
	' ' as Observaciones
From venReparto
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venReparto.venReparto
Inner Join genSegmentos On genSegmentos.genSegmentos = venRepaSegmentos.Segmento_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = venReparto.Deposito_Id
Where venReparto.venReparto = @pIdentity

If @pConRemito = 1
	-- Si genero remito traigo lo pendiente de remitir --
	Select venRepaPedi.Renglon_Rep,
	venSubTipoMov.SubTipoMov_Id, venClientes.Cliente_Id, venPedidos.Sucursal, stkDepositos.Deposito_Id, stkProductos.Producto_Id,
	venRepaPedi.CantidadForm, stkUniMed.Medida_Id, venPediCuerpo.Factor, venRepaPedi.CantidadAlternaForm, stkMedAlterna.Medida_Id MedidaAlterna,
	venPedidos.venPedidos, venPediCuerpo.Renglon_Pe, venPediCuerpo.PrecioVenta, venPediCuerpo.PrecioForm, venPediCuerpo.PrecioLista, venPediCuerpo.PrecioSinIva,
	venPediCuerpo.Bonificacion, venPediCuerpo.Observaciones, venPediCuerpo.FechaEntrega, venPediCuerpo.TipoPrecio,
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C,
	venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,
	venPediSegmentos.Segmento4N) Pedido, conCentro1.Centro1_Id, conCentro2.Centro2_Id, Cast(0 As bigint) stkMoviCabe, 0 Renglon
	From venReparto
	Inner Join stkDepositos On stkDepositos.stkDepositos = venReparto.Deposito_Id
	Inner Join venRepaPedi On venRepaPedi.venReparto = venReparto.venReparto
	Inner Join venPedidos On venRepaPedi.venPedidos = venPedidos.venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join venPediCuerpo On venPediCuerpo.venPedidos = venRepaPedi.venPedidos And venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe
	Inner Join stkProductos On stkProductos.stkProductos = venPediCuerpo.Producto_Id
	Inner Join stkUniMed On stkUniMed.stkUniMed = venPediCuerpo.Medida_Id
	Left Join stkUniMed stkMedAlterna On stkMedAlterna.stkUniMed = stkProductos.MedidaAlterna
	Left Join conCentro1 On conCentro1.conCentro1 = venPediCuerpo.Centro1_Id
	Left Join conCentro2 On conCentro2.conCentro2 = venPediCuerpo.Centro2_Id
	Where venReparto.venReparto = @pIdentity And venReparto.Cerrado = 0 And venRepaPedi.Remitido = 0 And
	venRepaPedi.CantidadForm > 0 and  venPediCuerpo.Pendiente = 1
	Order By venPedidos.venPedidos, venPediCuerpo.Renglon_Pe
Else
	-- Si no genero remito traigo lo remitido y no facturado --
	Select venRepaPedi.Renglon_Rep,
	venSubTipoMov.SubTipoMov_Id, venClientes.Cliente_Id, venPedidos.Sucursal, stkDepositos.Deposito_Id, stkProductos.Producto_Id,
	venRepaPedi.CantidadForm, stkUniMed.Medida_Id, venPediCuerpo.Factor, venRepaPedi.CantidadAlternaForm, stkMedAlterna.Medida_Id MedidaAlterna,
	venPedidos.venPedidos, venPediCuerpo.Renglon_Pe, venPediCuerpo.PrecioVenta, venPediCuerpo.PrecioForm, venPediCuerpo.PrecioLista, venPediCuerpo.PrecioSinIva,
	venPediCuerpo.Bonificacion, venPediCuerpo.Observaciones, venPediCuerpo.FechaEntrega, venPediCuerpo.TipoPrecio,
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C,
	venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,
	venPediSegmentos.Segmento4N) Pedido, conCentro1.Centro1_Id, conCentro2.Centro2_Id, venPediRemitidos.stkMoviCabe, venPediRemitidos.Renglon
	From venReparto
	Inner Join stkDepositos On stkDepositos.stkDepositos = venReparto.Deposito_Id
	Inner Join venRepaPedi On venRepaPedi.venReparto = venReparto.venReparto
	Inner Join venPedidos On venRepaPedi.venPedidos = venPedidos.venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join venPediCuerpo On venPediCuerpo.venPedidos = venRepaPedi.venPedidos And venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe
	Inner Join stkProductos On stkProductos.stkProductos = venPediCuerpo.Producto_Id
	Inner Join stkUniMed On stkUniMed.stkUniMed = venPediCuerpo.Medida_Id
	Inner Join venPediRemitidos On venPediRemitidos.venPedidos = venRepaPedi.venPedidos And venPediRemitidos.Renglon_Pe = venRepaPedi.Renglon_Pe And
		venPediRemitidos.venReparto = venReparto.venReparto
	Left Join stkUniMed stkMedAlterna On stkMedAlterna.stkUniMed = stkProductos.MedidaAlterna
	Left Join conCentro1 On conCentro1.conCentro1 = venPediCuerpo.Centro1_Id
	Left Join conCentro2 On conCentro2.conCentro2 = venPediCuerpo.Centro2_Id
	Where 
	venReparto.venReparto = @pIdentity And 
	venReparto.Cerrado = 0 And
	venRepaPedi.CantidadForm > 0 And venRepaPedi.Facturado = 0 And venRepaPedi.Remitido = 1 and 
	venPediCuerpo.CantidadFacturada < venPediCuerpo.CantidadRemitida
	Order By venPedidos.venPedidos, venPediCuerpo.Renglon_Pe


If @pSoloRemito = 0
	-- Se genera remito así que traigo las monedas de facturación --
	Select Distinct 0 venPedidos, genMonedas.Moneda_Id, genMonedas.Descripcion DecripcionMoneda,
	--dbo.func_TipoCambio(venPedidos.MonedaFacturacion, dbo.FechaActual(), venReparto.Empresa_Id) Cambio
	dbo.func_TipoCambio(venPedidos.Moneda_Id, dbo.FechaActual(), venReparto.Empresa_Id) Cambio
	From venReparto
	Inner Join venRepaPedi On venRepaPedi.venReparto = venReparto.venReparto
	Inner Join venPedidos On venRepaPedi.venPedidos = venPedidos.venPedidos
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	--Inner Join genMonedas On genMonedas.genMonedas = venPedidos.MonedaFacturacion
	Inner Join genMonedas On genMonedas.genMonedas = venPedidos.Moneda_Id
	Inner Join genEmpresas On genEmpresas.genEmpresas = venReparto.Empresa_Id
	Where venReparto.venReparto = @pIdentity And venReparto.Cerrado = 0 And --venRepaPedi.Remitido = 0 And
	--venRepaPedi.CantidadForm > 0 And venPedidos.MonedaFacturacion <> genEmpresas.Moneda_Id
	venRepaPedi.CantidadForm > 0 And venPedidos.Moneda_Id <> genEmpresas.Moneda_Id
Else
	-- Se genera solo el remito así que traigo las monedas de los pedidos --
	Select Distinct 0 venPedidos, genMonedas.Moneda_Id, genMonedas.Descripcion DecripcionMoneda,
	dbo.func_TipoCambio(venPedidos.Moneda_Id, dbo.FechaActual(), venReparto.Empresa_Id) Cambio
	From venReparto
	Inner Join venRepaPedi On venRepaPedi.venReparto = venReparto.venReparto
	Inner Join venPedidos On venRepaPedi.venPedidos = venPedidos.venPedidos
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join genMonedas On genMonedas.genMonedas = venPedidos.Moneda_Id
	Inner Join genEmpresas On genEmpresas.genEmpresas = venReparto.Empresa_Id
	Where venReparto.venReparto = @pIdentity And venReparto.Cerrado = 0 And --venRepaPedi.Remitido = 0 And
	venRepaPedi.CantidadForm > 0 And venPedidos.Moneda_Id <> genEmpresas.Moneda_Id

If  @pConRemito = 1

	SELECT venRepaPediSerie.venReparto, venRepaPediSerie.Renglon_Rep, venRepaPediSerie.venPedidos, 
		venRepaPediSerie.Renglon_Pe, 
		venRepaPediSerie.Serie, isnull(venRepaPediSerieUbi.Cantidad, venRepaPediSerie.Cantidad) as Cantidad, 
		stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id
	FROM 
	venRepaPediSerie 
	INNER JOIN venReparto ON venReparto.venReparto = venRepaPediSerie.venReparto
	INNER JOIN venRepaPedi ON venReparto.venReparto = venRepaPedi.venReparto  and 
							  venRepaPedi.Renglon_Rep = venRepaPediSerie.Renglon_Rep
	INNER JOIN venPediCuerpo ON venPediCuerpo.venPedidos = venRepaPediSerie.venPedidos and 
								venPediCuerpo.Renglon_Pe = venRepaPediSerie.Renglon_pe 
	LEFT JOIN stkSerieVencimiento ON stkSerieVencimiento.Serie = venRepaPediSerie.Serie and 
						stkSerieVencimiento.Empresa_Id = venReparto.Empresa_Id and
						stkSerieVencimiento.Producto_Id = venPediCuerpo.Producto_Id
	LEFT JOIN (venRepaPediSerieUbi INNER JOIN stkUbicaciones ON 
				venRepaPediSerieUbi.Ubicacion_Id = stkUbicaciones.stkUbicaciones) ON 
			venRepaPediSerieUbi.venReparto  = venRepaPediSerie.venReparto AND
			venRepaPediSerieUbi.Renglon_Rep =venRepaPediSerie.Renglon_Rep AND 
			venRepaPediSerieUbi.venPedidos = venRepaPediSerie.venPedidos AND
			venRepaPediSerieUbi.Renglon_Pe = venRepaPediSerie.Renglon_Pe AND
			venRepaPediSerieUbi.Serie = venRepaPediSerie.Serie
	WHERE 
	venRepaPediSerie.venReparto = @pIdentity And venReparto.Cerrado = 0 And venRepaPedi.Remitido = 0 And
		venRepaPedi.CantidadForm > 0
ELSE

	SELECT venRepaPediSerie.venReparto, venRepaPediSerie.Renglon_Rep, venRepaPediSerie.venPedidos, 
		venRepaPediSerie.Renglon_Pe, 
		venRepaPediSerie.Serie, isnull(venRepaPediSerieUbi.Cantidad, venRepaPediSerie.Cantidad) as Cantidad, 
		stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id
	FROM 
	venRepaPediSerie 
	INNER JOIN venReparto ON venReparto.venReparto = venRepaPediSerie.venReparto
	INNER JOIN venRepaPedi ON venReparto.venReparto = venRepaPedi.venReparto  and 
							  venRepaPedi.Renglon_Rep = venRepaPediSerie.Renglon_Rep
	INNER JOIN venPediCuerpo ON venPediCuerpo.venPedidos = venRepaPediSerie.venPedidos and 
								venPediCuerpo.Renglon_Pe = venRepaPediSerie.Renglon_pe 
	LEFT JOIN stkSerieVencimiento ON stkSerieVencimiento.Serie = venRepaPediSerie.Serie and 
						stkSerieVencimiento.Empresa_Id = venReparto.Empresa_Id and
						stkSerieVencimiento.Producto_Id = venPediCuerpo.Producto_Id
	LEFT JOIN (venRepaPediSerieUbi INNER JOIN stkUbicaciones ON 
				venRepaPediSerieUbi.Ubicacion_Id = stkUbicaciones.stkUbicaciones) ON 
			venRepaPediSerieUbi.venReparto  = venRepaPediSerie.venReparto AND
			venRepaPediSerieUbi.Renglon_Rep =venRepaPediSerie.Renglon_Rep AND 
			venRepaPediSerieUbi.venPedidos = venRepaPediSerie.venPedidos AND
			venRepaPediSerieUbi.Renglon_Pe = venRepaPediSerie.Renglon_Pe AND
			venRepaPediSerieUbi.Serie = venRepaPediSerie.Serie
	Where venReparto.venReparto = @pIdentity And venReparto.Cerrado = 0 And
		venRepaPedi.CantidadForm > 0 And venRepaPedi.Facturado = 0 And venRepaPedi.Remitido = 1



EXEC venRepaUbicacionDatos @pIdentity

Go

	
		