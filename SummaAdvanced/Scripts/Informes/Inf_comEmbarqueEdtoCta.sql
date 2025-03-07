-- Inf_comEmbarqueEdtoCta 'EMB',1,0,0,0,'0001',' ',' ',' ',1
DROP PROCEDURE Inf_comEmbarqueEdtoCta
GO

CREATE PROCEDURE Inf_comEmbarqueEdtoCta
(
	@Segmento_Id VarChar(10), 
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20),
	@Empresa_Id int 
)
AS

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
	INNER JOIN genAsiSegmentos Embarque ON Embarque.Asiento_Id = comMovProvEmb.comEmbarques
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = Embarque.Segmento_Id
	Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	genSegmentos.Segmento_Id = @Segmento_Id and 
	Embarque.Segmento1N= @Segmento1N and 
	Embarque.Segmento2N= @Segmento2N and 
	Embarque.Segmento3N= @Segmento3N and 
	Embarque.Segmento4N= @Segmento4N and 
	Embarque.Segmento1C= @Segmento1C and 
	Embarque.Segmento2C= @Segmento2C and 
	Embarque.Segmento3C= @Segmento3C and 
	Embarque.Segmento4C= @Segmento4C and 
	Embarque.Empresa_Id = @Empresa_Id
ORDER BY 5,1,2
go

