-- Inf_venSubMayor '20190101','20191231','1130-102','1130-102',' ','ZZZ',' ','ZZZ',' ','ZZZ', 1,1
DROP PROCEDURE Inf_venSubMayor
GO

CREATE PROCEDURE [dbo].[Inf_venSubMayor] 
	(@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@CuentaDesde VarChar(25),
	@CuentaHasta VarChar(25),
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@ClienteDesde VarChar(15), 
	@ClienteHasta VarChar(15), 
	@Empresa int, 
	@IncluCobranza Bit
)
AS
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	venTipoMov.Descripcion, 
	venClientes.Cliente_id, venClientes.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm venMovimientos 
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipomov = venMovimientos.venTipoMov
Where
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	conMovCont.Importe > 0 AND
	(@IncluCobranza=1 or venTipoMov.venTipoMov NOT IN ('C','N')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	venClientes.Cliente_id BETWEEN @ClienteDesde AND @ClienteHasta And
	venSubTipoMov.SubTipoMov_Id Not In ('DDC', 'CDC')
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	venTipoMov.Descripcion, 
	venClientes.Cliente_id, venClientes.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genCancMov.Asiento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipomov = venMovimientos.venTipoMov
Where
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	(@IncluCobranza=1 or venTipoMov.venTipoMov NOT IN ('C','N')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	venClientes.Cliente_id BETWEEN @ClienteDesde AND @ClienteHasta 

UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	venTipoMov.Descripcion, 
	venClientes.Cliente_id, venClientes.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genCancMov.Asiento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipomov = venMovimientos.venTipoMov
Where
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	conMovCont.Importe > 0 AND
	(@IncluCobranza=1 or venTipoMov.venTipoMov NOT IN ('C','N')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	venClientes.Cliente_id BETWEEN @ClienteDesde AND @ClienteHasta 
union all
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	'Cierre Mes' as Descripcion, 
	venClientes.Cliente_id, venClientes.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm venAsiCierre 
INNER JOIN venAsiCierreCr ON venAsiCierre.Asiento_Id = venAsiCierreCr.Asiento_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = venAsiCierre.Asiento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venAsiCierreCr.Cliente_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = venAsiCierreCr.Asiento_Id and conMovCont.Renglon = venAsiCierreCr.conRenglon
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
Where
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	conMovCont.Importe > 0 AND
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	venClientes.Cliente_id BETWEEN @ClienteDesde AND @ClienteHasta 


ORDER BY 1,3,4,5

GO

