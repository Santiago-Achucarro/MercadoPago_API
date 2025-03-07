Drop procedure venPediRemiFactuDatos
Go
Create procedure venPediRemiFactuDatos
(
@pvenPedidos Int
)
As

Select @pvenPedidos venPedidos


Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remitos, venPediRemitidos.stkMoviCabe, conAsientos.Fecha, 
conAsientos.Anulado
From venPediRemitidos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venPediRemitidos.stkMoviCabe
INNER JOIN conAsientos ON venPediRemitidos.stkMoviCabe = conAsientos.conAsientos
Where venPediRemitidos.venPedidos = @pvenPedidos
-- FM Traigo los remitos que se hicieron desde la factura --
Union
Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Facturas, venMovConStockCrPed.venMovimientos, conAsientos.Fecha,
conAsientos.Anulado
From venMovConStockCrPed
Inner Join venMovStkHist On venMovStkHist.venMovimientos = venMovConStockCrPed.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovStkHist.stkMoviCabe
INNER JOIN conAsientos ON venMovConStockCrPed.venMovimientos = conAsientos.conAsientos
Where venMovConStockCrPed.venPedidos = @pvenPedidos


Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Facturas, venMovConStockCrPed.venMovimientos, conAsientos.Fecha, 
conAsientos.Anulado
From venMovConStockCrPed
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovConStockCrPed.venMovimientos
INNER JOIN conAsientos ON venMovConStockCrPed.venMovimientos = conAsientos.conAsientos
Where venMovConStockCrPed.venPedidos = @pvenPedidos
UNION 
Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Facturas, venPediFacturados.venMovimientos, conAsientos.Fecha,
conAsientos.Anulado
From venPediFacturados
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venPediFacturados.venMovimientos
INNER JOIN conAsientos ON venPediFacturados.venMovimientos = conAsientos.conAsientos
Where venPediFacturados.venPedidos = @pvenPedidos


Select Distinct dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N,
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Repartos, venRepaPedi.venReparto, venReparto.FechaReparto Fecha,
venReparto.Cerrado
From venRepaPedi
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venRepaPedi.venReparto
Inner Join venReparto On venRepaSegmentos.venReparto = venReparto.venReparto
Where venRepaPedi.venPedidos = @pvenPedidos
Go



