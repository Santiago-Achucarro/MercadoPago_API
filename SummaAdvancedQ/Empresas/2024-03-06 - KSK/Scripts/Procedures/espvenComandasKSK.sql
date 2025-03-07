-- exec espvenComandasDatosKSK '20211021'

Drop procedure espvenComandasDatosKSK
Go
Create procedure espvenComandasDatosKSK
(
@pFecha datetime
)
As

Select @pFecha Fecha

Select conAsientos.conAsientos Comanda, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Ticket, venMovimientos.Importe, venClientes.Cliente_Id, venClientes.RazonSocial,
genMovCuotas.Saldo Saldo
From genAsiSegmentos
Inner Join conAsientos On conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
--Inner Join conMovCont On conMovCont.conAsientos = conAsientos.conAsientos
Inner Join venMovimientos On venMovimientos.venMovimientos = conAsientos.conAsientos
Inner Join venClientes On venClientes.genEntidades = venMovimientos.Cliente_Id
Inner Join genMovCuotas On genMovCuotas.Asiento_Id = conAsientos.conAsientos
Where genAsiSegmentos.Segmento1C = 'Z' And
conAsientos.Posteado = 1 And conAsientos.Anulado = 0 And conAsientos.Fecha = @pFecha

Select conAsientos.conAsientos Comanda, stkProductos.Producto_Id, stkProductos.Descripcion, venMovConStockCr.CantFacturada, venMovConStockCr.PrecioForm
From genAsiSegmentos
Inner Join conAsientos On conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
Inner Join venMovConStockCr On venMovConStockCr.venMovimientos = conAsientos.conAsientos
Inner Join stkProductos On stkProductos.stkProductos = venMovConStockCr.Producto_Id
Where genAsiSegmentos.Segmento1C = 'Z' And
conAsientos.Posteado = 1 And conAsientos.Anulado = 0 And conAsientos.Fecha = @pFecha
GO


