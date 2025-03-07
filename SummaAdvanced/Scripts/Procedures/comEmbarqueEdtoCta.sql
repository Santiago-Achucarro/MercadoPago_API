

-- comEmbarqueEdtoCta 1, 'EMB',44,0,0,0, '0001',' ',' ',' '
DROP PROCEDURE comEmbarqueEdtoCta 
go

CREATE PROCEDURE comEmbarqueEdtoCta
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
AS

DECLARE @pcomEmbarques bigint 

SET @pcomEmbarques = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id) and
	Segmento1N =@pSegmento1N and
	Segmento2N = @pSegmento2N and
	Segmento3N = @pSegmento3N and
	Segmento4N = @pSegmento4N and
	Segmento1C = @pSegmento1C and
	Segmento2C = @pSegmento2C and 
	Segmento3C = @pSegmento3C and 
	Segmento4C = @pSegmento4C )

SELECT genAsiSegmentos.Asiento_Id,	genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genMonedas.Moneda_Id, genMonedas.Descripcion AS DescripcionMoneda, 
	ISNULL( case when comDespachos.TomaCambioTes = 1 then XXX.Cambio else
	comDespachos.Cambio end , 1.0000) as Cambio, Cast(0 as bit) as Cerrando, 
		Cast(0 as Bigint) stkMoviCabeReva, conAsientos.Fecha as FechaCierreStock, 
			ISNULL(( SELECT MAX(conAsientos.Fecha) 
				from 	conAsientos inner join comEmbAsiCierre on
					conAsientos.conAsientos = comEmbAsiCierre.stkMoviCabe
					WHERE
						conAsientos.Anulado = 0 AND 
						conAsientos.Posteado = 1 AND 
						comEmbAsiCierre.comEmbarques = @pcomEmbarques),dbo.FechaActual()) as FechaCierreEmb,
				conAsientos.FechaRegistro , 
				comEmbEstado.Estado_Id, comEmbEstado.Descripcion, comDespachos.TomaCambioTes
from genAsiSegmentos 
inner join genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN comEmbarques ON	comEmbarques.comEmbarques = conAsientos.conAsientos 
INNER JOIN comEmbEstado ON comEmbEstado.Estado_Id= comEmbarques.Estado_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = (Select max(Moneda_Id) From comEmbCuerpo, comOrdenComp
			Where
				comEmbCuerpo.comEmbarques =genAsiSegmentos.Asiento_Id and 
				comEmbCuerpo.comOrdenComp = comOrdenComp.comOrdenComp)
Left outer join (comDespachos INNER JOIN (SELECT comEmbCuerpo.comEmbarques, 
				MIN(stkmoviDespa.Despacho_Id) as comDespachos,
 				 MAX(conAsientosE.CambioMonedaOriginal) AS Cambio 				
			FROM stkmoviDespa 
			inner join stkMoviEmbarque on stkmoviDespa.stkMoviCabe = stkMoviEmbarque.stkmovicabe  and 
				stkMoviEmbarque.comEmbarques = @pcomEmbarques
			inner join conAsientos conAsientosE ON conAsientosE.conAsientos = stkmoviDespa.stkMoviCabe
			INNER JOIN comEmbCuerpo ON comEmbCuerpo.comEmbarques = @pcomEmbarques 
					group by comEmbCuerpo.comEmbarques) as XXX ON XXX.comDespachos = comDespachos.comDespachos) 
					
					ON XXX.comEmbarques = genAsiSegmentos.Asiento_Id
					
			
WHere
	genAsiSegmentos.Asiento_Id = @pcomEmbarques

SELECT comMovProv.comMovProv, 
	dbo.Segmento(	
	genAsiSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	comMovProv.Fecha_CCP, genMonedas.Moneda_Id, conAsientos.Cambio,
	CASE WHEN commovtipos.Signo = 1 THEN 	genMovCuotas.Importe ELSE 0 END AS Debe,
	CASE WHEN commovtipos.Signo = -1 THEN 	genMovCuotas.Importe ELSE 0 END AS Haber,
	genMovCuotas.Saldo*commovtipos.Signo as Saldo, 
	genMovCuotas.Saldo*conAsientos.Cambio as SaldoBase, 
	genMovCuotas.CuotaNro, genMovCuotas.FechaVencimiento
from comMovProv inner join genAsiSegmentos ON
	comMovProv.comMovProv = genAsiSegmentos.Asiento_Id
	INNER JOIN genMovCuotas ON
	genMovCuotas.Asiento_Id = comMovProv.comMovProv
	INNER JOIN comProveedores ON
	comProveedores.genEntidades = comMovProv.Proveed_Id
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = comMovProv.comMovProv
	INNER JOIN genMonedas ON 
	genMonedas.genMonedas  =  conAsientos.Moneda_Id
	INNER JOIN comMovProvEmb ON
	comMovProvEmb.comMovProv = comMovProv.comMovProv
	INNER JOIN commovtipos ON
	commovtipos.TipoMov = comMovprov.Tipomov
	Where
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comMovProvEmb.comEmbarques = @pcomEmbarques

	ORDER BY 5


-- Para Aplicar

--CompAAplic
select cast(0 as bigint) as Asiento_Id, cast(0 as smallint) as Cuota_Nro, 0.00 as Importe, 0.00 as Signo, 
		cast(0.0000 as Numeric(18,4)) as Cambio, ' ' as Moneda_Id, 
			Convert(Numeric(18,2), 0) as Monto, dbo.FechaActual() as FechaApli

-- CompAAplic_Ap
SELECT genCancMov.Asiento_Id_Ap, ' ' as Segmento_str_ap,  
	genCancMov.CuotaNro_Ap, ' ' RazonSocial,  genCancMov.Importe , genCancMov.Importe as Saldo, 
	 1.0000 as Cambio,
	' ' as Moneda_Id, genCancMov.Importe as ImporteAplicado, genCancMov.FechaAplicacion Fecha
from genCancMov where 1 = 2


-- Para Mostrar Gastos

SELECT comEmbGastos.Renglon, comEmbGastos.Detalle, comEmbGastos.Importe as Estimado, 
	ISNULL((SELECT SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3)) 
		FROM conAsientos 
			inner join comEmbGastoMovProv ON conAsientos.conAsientos = comEmbGastoMovProv.comMovProv 
			INNER join conMovCont ON comEmbGastoMovProv.comMovProv =  conMovCont.conAsientos and 
									 comEmbGastoMovProv.comRenglon = conMovCont.Renglon AND 
									 comEmbGastoMovProv.Renglon = comEmbGastos.Renglon 
			WHERE
				comEmbGastoMovProv.comEmbarques = @pcomEmbarques AND 
				conAsientos.Anulado= 0 and 
				conAsientos.Posteado = 1
		),0) as Real, comEmbGastos.CantidadImporte,0.00 as Diferencia
from comEmbGastos
WHERE
	 comEmbGastos.comEmbarques = @pcomEmbarques
order by 1

-- Para Mostar Productos
SELECT   dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, 
comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N,
comOCSegmentos.Segmento4N) as OrdenDeCompra,
comEmbCuerpo.comOrdenComp, comEmbCuerpo.Renglon_OC, stkProductos.Producto_Id,
	stkProductos.Descripcion, comOCCuerpo.Cantidad, comEmbCuerpo.PrecioCalculado* comOrdenComp.Cambio as PrecioCalculado, 
	comOCCuerpo.Precio * comOrdenComp.Cambio as PrecioReal, 0.00 as Diferencia
FROM comEmbCuerpo
inner join comOCArticulo ON  comOCArticulo.comOrdenComp = comEmbCuerpo.comOrdenComp AND 
							  comOCArticulo.Renglon_OC = comEmbCuerpo.Renglon_OC
inner join comOCCuerpo ON comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
							  comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
INNER JOIN stkProductos ON  stkProductos.stkProductos = comOCArticulo.Producto_Id
INNER JOIN comOCSegmentos ON comOCSegmentos.comOrdenComp = comEmbCuerpo.comOrdenComp
INNER JOIN comOrdenComp ON  comOrdenComp.comOrdenComp = comEmbCuerpo.comOrdenComp
where
comEmbCuerpo.comEmbarques = @pcomEmbarques
order by 1,3
GO

Drop procedure comEmbarqueEdtoCtaBorrarCierre
Go
Create procedure comEmbarqueEdtoCtaBorrarCierre
(
@pcomEmbarques bigint
)
As
Update conAsientos Set Anulado = 1
From genEmpresas, comEmbAsiCierre
Where genEmpresas.genEmpresas = conAsientos.Empresa_Id And conAsientos.conAsientos = comEmbAsiCierre.stkMoviCabe And
	comEmbAsiCierre.comEmbarques = @pcomEmbarques And conAsientos.Fecha > genEmpresas.FechaCierreCompras
Go

