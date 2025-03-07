-- FM 13/07/2022 Que no traiga los cheques propios que todavía están en estado diferido y tampoco 

-- Inf_tesConcBancaria 'SBMX', '20180630', 1
DROP PROCEDURE Inf_tesConcBancaria
GO
CREATE PROCEDURE Inf_tesConcBancaria
(
	@Cartera_Id VarChar(5), 
	@FechaHasta DateTime, 
	@Empresa_Id Int
)
AS
SELECT 1 as Orden, @FechaHasta as Fecha, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, ' ' SubTipo_Id, 
	'Saldo_Segun_Libro_de_Banco' DescripcionSubTipo, 3 TipoMov, ' ' as DescripcionMov, 
	'' as Detalle,  ' ' as Segmento, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as Monto,
	0 Chequera_Id, 0 numCheque
From tesIdentifica 
INNER JOIN tesRengMovi ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conMovCont ON conMovCont.conAsientos =tesRengMovi.tesMovimientos and
	conMovCont.Renglon =tesRengMovi.conRenglon
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
Left Join (tesBPlink Inner Join tesCheqProp On tesCheqProp.tesCheqProp = tesBPlink.tesCheqProp) On tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos And
	tesBPlink.conRenglon = tesRengMovi.conRenglon
WHERE
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @FechaHasta and 
	tesIdentifica.Cartera_Id = @Cartera_Id
	And conCuentas.Tipo_Id <> 'CDADP'	
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion
UNION ALL
SELECT 2 as Orden, conAsientos.Fecha,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, tesSubTiposMov.SubTipo_Id, 
	'Depositos_No_Acreditados' DescripcionSubTipo, conMovCont.TipoMov,
	tesSubTiposMov.Descripcion DescripcionMOV, ISNULL(conAsientos.Observaciones,tesSubTiposMov.Descripcion) as Detalle,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	-tesRengConciliac.Saldo -
	ISNULL((SELECT SUM(tesRengConcilEsp.Importe)
		From tesRengConcilEsp, tesConciliacion
		Where
		tesConciliacion.FechaConciliacion > @FechaHasta and 
		tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc and 
		tesConciliacion.tesIdentifica =tesRengConcilEsp.tesIdentifica and
		tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and
		tesRengConcilEsp.conRenglon =tesRengMovi.conRenglon),0) as Monto,
		0 Chequera_Id, 0 numCheque
From tesIdentifica 
INNER JOIN tesRengMovi ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conMovCont ON conMovCont.conAsientos =tesRengMovi.tesMovimientos and
	conMovCont.Renglon =tesRengMovi.conRenglon
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN tesRengConciliac ON tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos and
	tesRengConciliac.conRenglon =tesRengMovi.conRenglon
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos 
INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
WHERE
	conMovCont.TipoMov = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @FechaHasta and 
	tesIdentifica.Cartera_Id = @Cartera_Id AND 
	tesRengConciliac.Saldo + 
	ISNULL((SELECT SUM(tesRengConcilEsp.Importe)
		from tesRengConcilEsp, tesConciliacion
		Where
		tesConciliacion.FechaConciliacion > @FechaHasta and 
		tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc and 
		tesConciliacion.tesIdentifica =tesRengConcilEsp.tesIdentifica and
		tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and
		tesRengConcilEsp.conRenglon =tesRengMovi.conRenglon),0) <> 0
	And conCuentas.Tipo_Id <> 'CDADP'

UNION ALL
SELECT 3 as Orden, ISNULL(tesCheqProp.FechaVencimiento,conAsientos.Fecha) Fecha,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, tesSubTiposMov.SubTipo_Id,
	'Cheques_No_Pagados' DescripcionSubTipo, conMovCont.TipoMov,
	tesSubTiposMov.Descripcion DescripcionMOV, 
	ISNULL(tesCheqProp.aLaOrden, ISNULL(conAsientos.Observaciones,'')) as Detalle,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	tesRengConciliac.Saldo +
	ISNULL((SELECT SUM(tesRengConcilEsp.Importe)
		From tesRengConcilEsp, tesConciliacion
		Where
		tesConciliacion.FechaConciliacion > @FechaHasta and 
		tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc and 
		tesConciliacion.tesIdentifica =tesRengConcilEsp.tesIdentifica and
		tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and
		tesRengConcilEsp.conRenglon =tesRengMovi.conRenglon),0) as Monto,
		tesCheqProp.Chequera_Id, tesCheqProp.numCheque
FROM tesIdentifica 
INNER JOIN tesRengMovi ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conMovCont ON conMovCont.conAsientos =tesRengMovi.tesMovimientos and
	conMovCont.Renglon =tesRengMovi.conRenglon
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN tesRengConciliac ON 
	tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos and
	tesRengConciliac.conRenglon =tesRengMovi.conRenglon
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos 
INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov =tesMovimientos.SubTipo_Id
LEFT JOIN (tesBPlink INNER JOIN tesCheqProp ON tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp) ON 
	tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos AND
	tesRengMovi.conRenglon = tesBPlink.conRenglon
WHERE
	conMovCont.TipoMov = 2 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @FechaHasta and 
	tesIdentifica.Cartera_Id = @Cartera_Id AND 
	tesRengConciliac.Saldo + 
	ISNULL((SELECT SUM(tesRengConcilEsp.Importe)
		From tesRengConcilEsp, tesConciliacion
		Where
		tesConciliacion.FechaConciliacion > @FechaHasta and 
		tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc and 
		tesConciliacion.tesIdentifica =tesRengConcilEsp.tesIdentifica and
		tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and
		tesRengConcilEsp.conRenglon =tesRengMovi.conRenglon),0) <> 0 
UNION ALL
SELECT 4, Fecha, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, '',
'Movimientos Bancarios No Reconocidos Por La Empresa', CASE WHEN (-2*Debe_Haber+3)*Importe > 0 THEN 1 ELSE 2 END,
'', convert(varchar(10),Comprobante), '', (-2*Debe_Haber+3)*Importe, 0 Chequera_Id, 0 numCheque
from tesPartidasInCon inner join tesIdentifica on tesIdentifica=tesPartidasInCon.Cartera_Id
where YEAR(Fecha)= YEAR(@FechaHasta) and month(Fecha)=MONTH(@FechaHasta) and 
	tesIdentifica.Cartera_Id=@Cartera_Id and 
	tesPartidasInCon.Empresa_Id=@Empresa_Id
ORDER BY 1,2
	

