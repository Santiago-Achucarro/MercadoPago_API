

DROP Procedure  stkNotasCreditoXDevolucionDatos
go
create procedure stkNotasCreditoXDevolucionDatos
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
@pSegmento_IdNC VarChar(10), 
@pSegmento1NNC int,
@pSegmento2NNC int,
@pSegmento3NNC int,
@pSegmento4NNC int,
@pSegmento1CNC VarChar(20),
@pSegmento2CNC VarChar(20),
@pSegmento3CNC VarChar(20),
@pSegmento4CNC VarChar(20)

)
AS

Declare @pstkMoviCabe bigint = (select Asiento_Id
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

Declare @pvenMovimientos bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_IdNC) and 
	genAsiSegmentos.Segmento1N = @pSegmento1NNC and 
	genAsiSegmentos.Segmento2N = @pSegmento2NNC and 
	genAsiSegmentos.Segmento3N = @pSegmento3NNC and 
	genAsiSegmentos.Segmento4N = @pSegmento4NNC and 
	genAsiSegmentos.Segmento1C = @pSegmento1CNC and 
	genAsiSegmentos.Segmento2C = @pSegmento2CNC and 
	genAsiSegmentos.Segmento3C = @pSegmento3CNC and 
	genAsiSegmentos.Segmento4C = @pSegmento4CNC )



select stkDevolucionesClie.stkMoviCabe, genSegmentos.Segmento_Id ,genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C , 
	/*@pSegmento_IdNC as Segmento_IdNC  , @pSegmento1NNC AS Segmento1NNC,@pSegmento2NNC AS Segmento2NNC,@pSegmento3NNC AS Segmento3NNC ,@pSegmento4NNC AS Segmento4NNC
	,@pSegmento1CNC AS	Segmento1CNC,@pSegmento2CNC AS Segmento2CNC	,@pSegmento3CNC AS Segmento3CNC,@pSegmento4CNC AS Segmento4CNC,*/
	conAsientos.Fecha, venClientes.Cliente_Id,venClientes.RazonSocial,
	conCentro1.Centro1_Id,conCentro2.Centro2_Id,venMovimientos.Dato1,venMovimientos.Dato2,venMovimientos.Dato3,venMovimientos.Comision1,venMovimientos.Comision2,
	venMovimientos.Bonificacion1,venMovimientos.Bonificacion2,venMovimientos.Bonificacion3,venMovimientos.Bonificacion4,venMovimientos.Bonificacion5,
	venMovimientos.CobraAbasto,venVendedores.Vendedor_Id,venFormaEntrega.FormaEntrega_Id,venMovimientos.Sucursal,venMovimientos.SubTotalBonif,
	venMovimientos.SubTotal,venCondPago.CondPagoCli_Id,venMovimientos.Importe,venMovimientos.CambioFijo,venMovimientos.ComprobanteDesde,venMovimientos.TipoPago,
	venIncoterm.Incoterm_Id,venMovimientos.Saldo,venSubTipoMov.SubTipoMov_Id,genMonedas.Moneda_Id,conAsientos.CambioMonedaOriginal,
	conAsientos.Cambio,conAsientos.Observaciones,venCondFiscal.CondFisc_Id
	from genAsiSegmentos 
		inner join	genSegmentos on  genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
		inner join stkDevolucionesClie on  stkDevolucionesClie.venMovimientosFact=genAsiSegmentos.Asiento_Id 
		inner join conAsientos ON conAsientos.conAsientos = stkDevolucionesClie.venMovimientosFact
		inner join venMovimientos on venMovimientos.venMovimientos=stkDevolucionesClie.venMovimientosFact
		inner join venClientes on venClientes.genEntidades=venMovimientos.Cliente_Id
		inner join stkMoviCausa on stkMoviCausa.stkMoviCabe = stkDevolucionesClie.stkMoviCabe
		INNER JOIN stkCausasMovi ON stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id
		LEFT JOIN conCentro1 ON conCentro1.conCentro1 = stkMoviCausa.Centro1_Id
		LEFT JOIN conCentro2 ON conCentro2.conCentro2 = stkMoviCausa.Centro2_Id
		inner join genMonedas on genMonedas.genMonedas=conAsientos.Moneda_Id
		inner join venSubTipoMov on venSubTipoMov.venSubTipoMov=venMovimientos.venSubTipoMov_Id
		inner join venCondPago on venMovimientos.CondPagoCli_Id=venCondPago.venCondPago
		inner join venVendedores on venVendedores.venVendedores= venMovimientos.Vendedor_Id
		inner join venFormaEntrega on venMovimientos.FormaEntrega_Id=venFormaEntrega.venFormaEntrega
		inner join venIncoterm on venIncoterm.venIncoterm_int=venMovimientos.Incoterm_Id
		inner join venCondFiscal on venMovimientos.CondFisc_Id=venCondFiscal.venCondFiscal
		WHERE
			stkDevolucionesClie.stkMoviCabe = @pstkMoviCabe

select stkMoviCabe,Renglon,comDespachos.Despacho_Id,Cantidad 
from stkMoviDespa
inner join comDespachos on comDespachos.comDespachos=stkMoviDespa.Despacho_Id 
where stkMoviCabe=@pstkMoviCabe


if @pvenMovimientos is not null
	Begin

	select venMovConStockCr.venMovimientos,stkMoviCuerpo.Cantidad,stkProductos.Producto_Id,stkProductos.Descripcion,
	FactOriginal.RenglonCuerpo, FactOriginal.PrecioForm,FactOriginal.Bonificacion,
	stkUniMed.Medida_Id,venMovConStockCr.CantOriginal as CantidadNueva,stkDepositos.Deposito_Id,
	FactOriginal.Factor,venMovConStockCr.PrecioForm as PrecioOriginal,FactOriginal.Observaciones,
	FactOriginal.CantOriginal,FactOriginal.FechaEntrega,
	FactOriginal.TipoPrecio,FactOriginal.CantidadAlternaForm,
	FactOriginal.PrecioFormImpuesto,FactOriginal.ComiPorce,
	FactOriginal.PrecioLista,FactOriginal.PrecioSinIva,FactOriginal.PrecioVenta,
	FactOriginal.PrecioFormImpuesto,FactOriginal.PrecioFormImpuestoBon,FactOriginal.PrecioFormImpuestoTot,
	FactOriginal.SubTotal,FactOriginal.SubTotalFormImpuesto
 
 
 from  venMovConStockCr
 
INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = venMovConStockCr.Medida_Id
Inner Join stkDepositos ON stkDepositos.stkDepositos=venMovConStockCr.Deposito_Id
left Join stkDevolucionesClie on  
	venMovConStockCr.venMovimientos=stkDevolucionesClie.venMovimientosNC
left join stkMoviCuerpo  ON 
	stkMoviCuerpo.stkMoviCabe =stkDevolucionesClie.stkMoviCabe and 
	stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
	inner join venMovConStockCr as FactOriginal ON venMovConStockCr.venMovimientos=stkDevolucionesClie.venMovimientosFact

 where venMovConStockCr.venMovimientos= @pvenMovimientos

	end
	else

 select stkMoviCuerpo.stkMoviCabe,stkMoviCuerpo.Cantidad,stkProductos.Producto_Id, stkProductos.Descripcion,
 venMovConStockCr.RenglonCuerpo,venMovConStockCr.PrecioForm,venMovConStockCr.Bonificacion,
 stkUniMed.Medida_Id,0.00 as CantidadNueva,stkDepositos.Deposito_Id,
 venMovConStockCr.Factor,venMovConStockCr.PrecioForm as PrecioOriginal,venMovConStockCr.Observaciones,
 venMovConStockCr.CantOriginal,venMovConStockCr.FechaEntrega,
 venMovConStockCr.TipoPrecio,venMovConStockCr.CantidadAlternaForm,
 venMovConStockCr.PrecioFormImpuesto,venMovConStockCr.ComiPorce,
 venMovConStockCr.PrecioLista,venMovConStockCr.PrecioSinIva,venMovConStockCr.PrecioVenta,
 venMovConStockCr.PrecioFormImpuesto,venMovConStockCr.PrecioFormImpuestoBon,venMovConStockCr.PrecioFormImpuestoTot,
 venMovConStockCr.SubTotal,venMovConStockCr.SubTotalFormImpuesto
 from  stkMoviCuerpo 
 --venMovConStockCr

 inner join stkMoviCabe on stkMoviCabe.stkMoviCabe=stkMoviCuerpo.stkMoviCabe 
 INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 

 INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
 inner join stkDevolucionesClie on stkDevolucionesClie.stkMoviCabe=stkMoviCabe.stkMoviCabe
 inner join venMovConStockCr on  stkDevolucionesClie.venMovimientosFact=venMovConStockCr.venMovimientos 
 
Inner Join stkDepositos ON stkDepositos.stkDepositos=venMovConStockCr.Deposito_Id


 where stkMoviCabe.stkMoviCabe=@pstkMoviCabe
GO


drop procedure stkNotasCreditoXDevolucionGuardar 
go
create procedure stkNotasCreditoXDevolucionGuardar 
(@pstkMoviCabe bigint ,
@pvenMovimientosNC bigint = null)
as

	UPDATE stkDevolucionesClie
	SET		 venMovimientosNC=@pvenMovimientosNC
	WHERE (stkMoviCabe = @pstkMoviCabe)
go
