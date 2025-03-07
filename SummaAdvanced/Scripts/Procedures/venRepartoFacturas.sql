-- exec venRepartoFacturasDatos 1,'REPARTO',23,0,0,0,'0001',' ',' ', ' '


Drop procedure venRepartoFacturasDatos
Go
Create procedure venRepartoFacturasDatos
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
@pSegmento4C VarChar(20)
)
As

Select @pEmpresa_Id Empresa_Id, @pSegmento_Id Segmento_Id, @pSegmento1C Segmento1C, @pSegmento2C Segmento2C, @pSegmento3C Segmento3C, @pSegmento4C Segmento4C,
@pSegmento1N Segmento1N, @pSegmento2N Segmento2N, @pSegmento3N Segmento3N, @pSegmento4N Segmento4N

Select Distinct venMovConStockCrPed.venMovimientos, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
From venMovConStockCrPed
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovConStockCrPed.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovConStockCrPed.venMovimientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN venRepaPedi ON venRepaPedi.venPedidos = venMovConStockCrPed.venPedidos and
							venRepaPedi.Renglon_Pe = venMovConStockCrPed.Renglon_Pe and 
							venRepaPedi.venReparto = 		venMovConStockCrPed.venReparto
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venRepaPedi.venReparto
Where 
conAsientos.Anulado = 0 and conasientos.Posteado = 1 and 
venRepaSegmentos.Empresa_Id = @pEmpresa_Id And venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
venRepaSegmentos.Segmento1C = @pSegmento1C And venRepaSegmentos.Segmento2C = @pSegmento2C And 
venRepaSegmentos.Segmento3C = @pSegmento3C And venRepaSegmentos.Segmento4C = @pSegmento4C And
venRepaSegmentos.Segmento1N = @pSegmento1N And venRepaSegmentos.Segmento2N = @pSegmento2N And 
venRepaSegmentos.Segmento3N = @pSegmento3N And venRepaSegmentos.Segmento4N = @pSegmento4N
union all

Select venPediFacturados.venMovimientos, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
From venPediFacturados
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venPediFacturados.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venPediFacturados.venMovimientos
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = venPediFacturados.venMovimientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venPediFacturados.Reparto_Id
Where 
venMovimientos.venTipoMov = 'R' and 
conAsientos.Anulado = 0 and conasientos.Posteado = 1 and 
venRepaSegmentos.Empresa_Id = @pEmpresa_Id And venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
venRepaSegmentos.Segmento1C = @pSegmento1C And venRepaSegmentos.Segmento2C = @pSegmento2C And 
venRepaSegmentos.Segmento3C = @pSegmento3C And venRepaSegmentos.Segmento4C = @pSegmento4C And
venRepaSegmentos.Segmento1N = @pSegmento1N And venRepaSegmentos.Segmento2N = @pSegmento2N And 
venRepaSegmentos.Segmento3N = @pSegmento3N And venRepaSegmentos.Segmento4N = @pSegmento4N

Go

