-- Inf_tesLibroBanco 'SBMX', '20180101', '20180630', 1,1
DROP PROCEDURE Inf_tesLibroBanco
GO

CREATE PROCEDURE Inf_tesLibroBanco
(
	@Cartera_Id VarChar(5), 
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@EnMonedaBase bit,
	@Empresa_Id Int
)

AS


SELECT DateAdd(dd,-1,@FechaDesde) as Fecha, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	'Saldo_inicial' DescripcionSubTipo, 
	' ' as Segmento,  0 AS Cheque, DateAdd(dd,-1,@FechaDesde) FechaVencimiento, ' ' as AlaOrden,

	 ' ' as Entidad,  ' ' as RazonSocial,
	SUM(CASE WHEN @EnMonedaBase=1 THEN conMovCont.Importe ELSE conMovCont.ImporteMonedaOriginal END* (-2*conMovCont.TipoMov+3)) as Debe, 
	0 as Haber, ' ' as Concepto 
from tesIdentifica INNER JOIN tesRengMovi ON
tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =tesRengMovi.tesMovimientos and
conMovCont.Renglon =tesRengMovi.conRenglon
INNER JOIN conAsientos ON
conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas on 
conMovCont.Cuenta_Id = conCuentas.conCuentas
WHERE
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha < @FechaDesde and 
	tesIdentifica.Cartera_Id = @Cartera_Id and 
	conCuentas.conCuentas = tesIdentifica.Cuenta_Id
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion
UNION ALL
SELECT conAsientos.Fecha,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	tesSubTiposMov.Descripcion as DescripcionSubTipo,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	ISNULL(tesCheqProp.numCheque,0) AS Cheque, 
	ISNULL(tesCheqProp.FechaVencimiento,conAsientos.Fecha) as FechaVencimiento , 
	ISNULL(tesCheqProp.aLaOrden,'') AS aLaOrden, 
	isnull(comProveedores.Proveed_Id, venClientes.Cliente_id) as Entidad, 
	ISNULL(ISNULL(comProveedores.RazonSocial,venClientes.RazonSocial), conAsientos.Observaciones) as RazonSocial,
	case when conMovCont.TipoMov=1 THEN 
		CASE WHEN @EnMonedaBase=1 THEN conMovCont.Importe ELSE conMovCont.ImporteMonedaOriginal END 
			ELSE 0 END AS Debe,
	case when conMovCont.TipoMov=2 THEN 
		CASE WHEN @EnMonedaBase=1 THEN conMovCont.Importe ELSE conMovCont.ImporteMonedaOriginal END
			ELSE 0 END AS Haber, ISNULL(conAsientos.Observaciones,' ') as Concepto
from tesIdentifica INNER JOIN tesRengMovi ON
tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =tesRengMovi.tesMovimientos and
conMovCont.Renglon =tesRengMovi.conRenglon
INNER JOIN conAsientos ON
conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN tesMovimientos ON
tesMovimientos.tesMovimientos = conAsientos.conAsientos
INNER JOIN tesSubTiposMov ON
tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
LEFT JOIN (comMovprov INNER JOIN comProveedores ON
	comMovprov.Proveed_Id = comProveedores.genEntidades) ON
	comMovprov.comMovProv = tesMovimientos.tesMovimientos
LEFT JOIN (venMovimientos INNER JOIN venClientes ON
	venMovimientos.Cliente_Id = venClientes.genEntidades) ON
	venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
LEFT JOIN (tesBPlink INNER JOIN tesCheqProp ON
	tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp) ON
	tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos and
	tesBPlink.conRenglon =  tesRengMovi.conRenglon
INNER JOIN conCuentas on 
conMovCont.Cuenta_Id = conCuentas.conCuentas	



WHERE
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and  @FechaHasta and 
	tesIdentifica.Cartera_Id = @Cartera_Id AND 
	CASE WHEN @EnMonedaBase=1 THEN conMovCont.Importe  ELSE
	conMovCont.ImporteMonedaOriginal END <> 0 AND 
	conCuentas.conCuentas = tesIdentifica.Cuenta_Id

ORDER BY 1,2