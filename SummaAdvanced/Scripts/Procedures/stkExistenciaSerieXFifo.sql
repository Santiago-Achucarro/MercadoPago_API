Drop procedure stkExistenciaSerieXFifoOVto
Go
--exec stkExistenciaSerieXFifoOVto 1, '0147E', '03', 1000, 'REPARTO', 6, 0, 0, 0, '0002', '', '', ''
--exec stkExistenciaSerieXFifoOVto 1, '0208E', '03', 1000, 'REPARTO', 0, 0, 0, 0, '0002', '', '', ''
--exec stkExistenciaSerieXFifoOVto 1, '0147E', '03', 300, 'REPARTO', Null, Null, Null, Null, '0002', Null, Null, Null
Create procedure stkExistenciaSerieXFifoOVto
(
@pEmpresa_Id int,
@pProducto_Id varChar(25),
@pDeposito_Id varChar(15),
@pCantidad qCantidadD8,
@pSegmento_Id varChar(10) = Null,
@pSegmento1N int = Null,
@pSegmento2N int = Null,
@pSegmento3N int = Null,
@pSegmento4N int = Null,
@pSegmento1C varchar(20) = Null,
@pSegmento2C varchar(20) = Null,
@pSegmento3C varchar(20) = Null,
@pSegmento4C varchar(20) = Null
)
As

Declare @lSerie varChar(25)
Declare @lCantidad qCantidadD8
Declare @lFecha datetime

Declare @lvenReparto int
-- Si se informa el reparto y no existe, que asigne 0. Si no se informa que asigne Null para que no reste nada --
If @pSegmento1N Is Null
	Set @lvenReparto = Null
Else
Begin
	Select @lvenReparto = venReparto From venRepaSegmentos Where Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
		Segmento1N = @pSegmento1N And
		Segmento2N = isNull(@pSegmento2N, 0) And
		Segmento3N = isNull(@pSegmento3N, 0) And
		Segmento4N = isNull(@pSegmento4N, 0) And
		Segmento1C = isNull(@pSegmento1C, '') And
		Segmento2C = isNull(@pSegmento2C, '') And
		Segmento3C = isNull(@pSegmento3C, '') And
		Segmento4C = isNull(@pSegmento4C, '') And
		Empresa_Id = @pEmpresa_Id
	If @lvenReparto Is Null
		Set @lvenReparto = 0
End

--print @lvenReparto

Select @pProducto_Id Producto_Id, @pDeposito_Id Deposito_Id, @pCantidad Cantidad, @pSegmento_Id Segmento_Id, @pSegmento1N Segmento1N,
@pSegmento2N Segmento2N, @pSegmento3N Segmento3N, @pSegmento4N Segmento4N, @pSegmento1C Segmento1C,
@pSegmento2C Segmento2C, @pSegmento3C Segmento3C, @pSegmento4C Segmento4C

Declare lCursorSerie Cursor for
-- Primero los productos que llevan Vto se orden por esa fecha, primero los que vencen primero --
Select stkExistenciaSerie.Serie, stkExistenciaSerie.Cantidad -
	isNull((Select Sum(venRepaPediSerie.Cantidad) From venRepaPedi 
	Inner Join venPediCuerpo On venRepaPedi.venPedidos = venPediCuerpo.venPedidos And venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	Inner Join venReparto On venReparto.venReparto = venRepaPedi.venReparto
	Inner Join venRepaPediSerie On venRepaPediSerie.venReparto = venRepaPedi.venReparto And venRepaPediSerie.Renglon_Rep = venRepaPedi.Renglon_Rep And
		venRepaPediSerie.venPedidos = venRepaPedi.venPedidos And venRepaPediSerie.Renglon_Pe = venRepaPedi.Renglon_Pe
	Where venRepaPedi.venReparto <> @lvenReparto And venPediCuerpo.Producto_Id = dbo.funcFKstkProductos(@pProducto_Id) And
	venPediCuerpo.Deposito_Id = dbo.funcFKstkDepositos(@pDeposito_Id) And venRepaPedi.Remitido = 0 And 
	venReparto.Cerrado = 0 And venReparto.Empresa_Id = @pEmpresa_Id And venRepaPediSerie.Serie = stkExistenciaSerie.Serie), 0) Cantidad,
stkSerieVencimiento.Vencimiento
From stkExistenciaSerie
Inner Join stkSerieVencimiento On stkSerieVencimiento.Producto_Id = stkExistenciaSerie.Producto_Id And stkSerieVencimiento.Serie = stkExistenciaSerie.Serie And
	stkSerieVencimiento.Empresa_Id = stkExistenciaSerie.Empresa_Id
Inner Join stkProductos On stkProductos.stkProductos = stkExistenciaSerie.Producto_Id
Where stkProductos.conVencimiento = 1 And stkExistenciaSerie.Cantidad <> 0 And
	stkExistenciaSerie.Empresa_Id = @pEmpresa_Id And stkExistenciaSerie.Producto_Id = dbo.funcFKstkProductos(@pProducto_Id) And
	stkExistenciaSerie.Deposito_Id = dbo.funcFKstkDepositos(@pDeposito_Id) And
	stkExistenciaSerie.Cantidad -
	isNull((Select Sum(venRepaPediSerie.Cantidad) From venRepaPedi 
	Inner Join venPediCuerpo On venRepaPedi.venPedidos = venPediCuerpo.venPedidos And venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	Inner Join venReparto On venReparto.venReparto = venRepaPedi.venReparto
	Inner Join venRepaPediSerie On venRepaPediSerie.venReparto = venRepaPedi.venReparto And venRepaPediSerie.Renglon_Rep = venRepaPedi.Renglon_Rep And
		venRepaPediSerie.venPedidos = venRepaPedi.venPedidos And venRepaPediSerie.Renglon_Pe = venRepaPedi.Renglon_Pe
	Where venRepaPedi.venReparto <> @lvenReparto And venPediCuerpo.Producto_Id = dbo.funcFKstkProductos(@pProducto_Id) And
	venPediCuerpo.Deposito_Id = dbo.funcFKstkDepositos(@pDeposito_Id) And venRepaPedi.Remitido = 0 And 
	venReparto.Cerrado = 0 And venReparto.Empresa_Id = @pEmpresa_Id And venRepaPediSerie.Serie = stkExistenciaSerie.Serie), 0) <> 0
Union All
-- Ahora los productos que no llevan vto. Se ordena por la fecha que ingresaron al stock --
Select Serie, Cantidad - 
	isNull((Select Sum(venRepaPediSerie.Cantidad) From venRepaPedi 
	Inner Join venPediCuerpo On venRepaPedi.venPedidos = venPediCuerpo.venPedidos And venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	Inner Join venReparto On venReparto.venReparto = venRepaPedi.venReparto
	Inner Join venRepaPediSerie On venRepaPediSerie.venReparto = venRepaPedi.venReparto And venRepaPediSerie.Renglon_Rep = venRepaPedi.Renglon_Rep And
		venRepaPediSerie.venPedidos = venRepaPedi.venPedidos And venRepaPediSerie.Renglon_Pe = venRepaPedi.Renglon_Pe
	Where venRepaPedi.venReparto <> @lvenReparto And venPediCuerpo.Producto_Id = dbo.funcFKstkProductos(@pProducto_Id) And
	venPediCuerpo.Deposito_Id = dbo.funcFKstkDepositos(@pDeposito_Id) And venRepaPedi.Remitido = 0 And 
	venReparto.Cerrado = 0 And venReparto.Empresa_Id = @pEmpresa_Id And venRepaPediSerie.Serie = Fifo.Serie), 0) Cantidad, 
Vencimiento From
(
Select stkMoviSerie.Serie, Sum(stkMoviSerie.Cantidad * stkMoviCabe.Signo) Cantidad, PrimeraEntrada.Vencimiento
From stkMoviSerie
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe And stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Inner Join stkMoviCabe On stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
Inner Join stkProductos On stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Inner Join 
(
Select conAsientos.Empresa_Id, stkMoviCuerpo.Producto_Id, stkMoviCuerpo.Deposito_Id, stkMoviSerie.Serie, Min(conAsientos.Fecha) Vencimiento
From stkMoviSerie
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe And stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Inner Join stkMoviCabe On stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
Inner Join stkProductos On stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Where conAsientos.Posteado = 1 And conAsientos.Anulado = 0 And stkMoviCabe.Signo = 1 And stkProductos.conVencimiento = 0 And
	conAsientos.Empresa_Id = @pEmpresa_Id And stkMoviCuerpo.Producto_Id = dbo.funcFKstkProductos(@pProducto_Id) And
	stkMoviCuerpo.Deposito_Id = dbo.funcFKstkDepositos(@pDeposito_Id)
Group By conAsientos.Empresa_Id, stkMoviCuerpo.Producto_Id, stkMoviCuerpo.Deposito_Id, stkMoviSerie.Serie
) PrimeraEntrada On PrimeraEntrada.Empresa_Id = conAsientos.Empresa_Id And PrimeraEntrada.Producto_Id = stkMoviCuerpo.Producto_Id And
	PrimeraEntrada.Deposito_Id = stkMoviCuerpo.Deposito_Id And PrimeraEntrada.Serie = stkMoviSerie.Serie
Where conAsientos.Posteado = 1 And conAsientos.Anulado = 0 And stkProductos.conVencimiento = 0
Group By conAsientos.Empresa_Id, stkProductos.Producto_Id, stkMoviCuerpo.Deposito_Id, stkMoviSerie.Serie, PrimeraEntrada.Vencimiento
Having Sum(stkMoviSerie.Cantidad * stkMoviCabe.Signo) <> 0
) Fifo
Order By 3


Open lCursorSerie

Create table #lCursorSerie
(
Serie varChar(25) Not Null,
Cantidad Numeric(19,8) Not Null,
Vencimiento datetime Not Null
)

-- Que siempre traiga todos los lotes porque dentro del programa puede ser que descarte algunos --
-- renglones anteriores del mismo producto y tiene que ir tomando los siguientes lotes --
Set @pCantidad = 999999999

Fetch Next From lCursorSerie Into @lSerie, @lCantidad, @lFecha

While (@@FETCH_STATUS = 0 And @pCantidad > 0 And @lCantidad > 0)
Begin
--print 'pCantidad'
--print @pCantidad
--print 'lCantidad'
--print @lCantidad
	If @lCantidad >= @pCantidad
	Begin
		Insert Into #lCursorSerie Values (@lSerie, @pCantidad, @lFecha)
		Set @pCantidad = 0
	End
	Else
	Begin
		Insert Into #lCursorSerie Values (@lSerie, @lCantidad, @lFecha)
		Set @pCantidad = @pCantidad - @lCantidad
	End

	Fetch Next From lCursorSerie
	Into @lSerie, @lCantidad, @lFecha
End


Select Serie, Cantidad, Vencimiento From #lCursorSerie
Drop table #lCursorSerie

Close lCursorSerie
Deallocate lCursorSerie

Go
