
-- comMovProvRemiPendDatos 1,'STOCK',0,0,0,0,' ',' ',' ',' ','C008'
 --- exec comMovProvRemiPendDatosRemi 20632

DROP PROCEDURE comMovProvRemiPendDatos
GO
CREATE PROCEDURE comMovProvRemiPendDatos
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
@pProveed_Id VarChar(15)
)
AS
SET NOCOUNT ON 
Declare @pidentity bigint = (select Asiento_Id
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

PRINT @pIdentity

exec comMovprovDatos @pidentity

-- Cuerpo
SELECT comRemiPendFact.Renglon, comRemiPendFact.RenglonCuerpo, comRemiPendFact.CantidadFacturado,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	comRemiPendFact.CantidadOriginalFact, comRemiPendFact.PrecioFacturado,
	stkMoviCuerpo.PrecioOriginal, stkUniMed.Medida_Id, stkMoviCuerpo.Cantidad, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.CantidadForm as CantidadOriginal,
	dbo.Segmento(genAsiSegmentos.Segmento_Id,  
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	stkMoviCuerpo.stkMoviCabe
from comRemiPendFact inner join stkMoviCuerpo ON
	comRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
	comRemiPendFact.Renglon = stkMoviCuerpo.Renglon
	inner join stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = comRemiPendFact.stkMoviCabe
	left JOIN conCuentas ON 
	conCuentas.conCuentas = stkProductos.CtaCompra
Where
	comRemiPendFact.comMovprov = @pidentity


exec comMovImpuestosDatos @pidentity, null
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comMovProv' 
Exec genMovCuotasDatos @pidentity, null

-- esta es para agregar el segmento del remito
SELECT stkmoviprov.FechaRemito,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id,  
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr,
	stkmoviprov.RemitoProv,genAsiSegmentos.Asiento_Id as stkMoviCabe,
	Cast(0 as Bit) as Marca, 
	Convert(Numeric(18,2),SUM(stkMoviCuerpo.CostoUnitario * stkRemiPendFactPro.CantidadPendiente)) as Monto
from genSegmentos INNER JOIN genAsiSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN stkRemiPendFactPro ON
	stkRemiPendFactPro.stkMoviCabe = genAsiSegmentos.Asiento_Id  
	inner join stkmoviprov ON
	stkmoviprov.stkMoviCabe =stkRemiPendFactPro.stkMoviCabe
	INNER JOIN comProveedores ON
	comProveedores.genEntidades =stkmoviprov.Proveed_Id
	INNER JOIN conAsientos on
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkRemiPendFactPro.stkMoviCabe AND
	stkMoviCuerpo.Renglon =stkRemiPendFactPro.Renglon
Where 
	@pidentity IS NULL AND 
	stkRemiPendFactPro.CantidadPendiente > 0 and 
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and
	conAsientos.Anulado = 0 and 
	comProveedores.Proveed_Id = @pProveed_Id

GROUP BY genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Asiento_Id,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C,  stkmoviprov.FechaRemito,genAsiSegmentos.Segmento_Id, stkmoviprov.RemitoProv
UNION ALL
-- ya existe
SELECT stkmoviprov.FechaRemito,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id,  
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr,
	stkmoviprov.RemitoProv, genAsiSegmentos.Asiento_Id as stkMoviCabe,
	Cast(1 as Bit) as Marca, 
	Convert(Numeric(18,2),SUM(comRemiPendFact.CantidadOriginalFact * comRemiPendFact.CantidadFacturado)) as Monto
from genSegmentos INNER JOIN genAsiSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN comRemiPendFact ON
	comRemiPendFact.stkMoviCabe = genAsiSegmentos.Asiento_Id  
	inner join comMovprov ON
	comMovprov.comMovProv = comRemiPendFact.comMovProv
	INNER JOIN comProveedores ON
	comProveedores.genEntidades =comMovprov.Proveed_Id
	inner join stkMoviProv ON
	stkMoviProv.stkMoviCabe = comRemiPendFact.stkMoviCabe
	INNER JOIN conAsientos on
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
Where 
	commovprov.comMovProv = @pidentity and
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and
	conAsientos.Anulado = 0 and 
	comProveedores.Proveed_Id = @pProveed_Id
GROUP BY genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C,  stkmoviprov.FechaRemito, genAsiSegmentos.Segmento_Id, stkmoviprov.RemitoProv, 
	genAsiSegmentos.Asiento_Id 
order by 1,2

GO
DROP PROCEDURE comMovProvRemiPendDatosRemi
GO
CREATE PROCEDURE comMovProvRemiPendDatosRemi(
	@pStkMoviCabe bigint
)
as

-- Cuerpo
SELECT stkRemiPendFactPro.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	Convert(Numeric(19,8),stkRemiPendFactPro.CantidadPendiente /stkMoviCuerpo.Factor) as CantidadOriginal,
	stkMoviCuerpo.PrecioOriginal, stkUniMed.Medida_Id, stkRemiPendFactPro.CantidadPendiente as Cantidad , 
	stkMoviCuerpo.Factor, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id,  
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	stkMoviCuerpo.stkMoviCabe
from stkRemiPendFactPro inner join stkMoviCuerpo ON
	stkRemiPendFactPro.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
	stkRemiPendFactPro.Renglon =stkMoviCuerpo.Renglon
	inner join stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = stkRemiPendFactPro.stkMoviCabe
	inner join conAsientos ON
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	left JOIN conCuentas ON 
	conCuentas.conCuentas = stkProductos.CtaCompra
Where
	conAsientos.Anulado = 0 and 
	stkRemiPendFactPro.stkMoviCabe = @pStkMoviCabe 

order by 1

GO