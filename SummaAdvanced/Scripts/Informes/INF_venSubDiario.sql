-- INF_venSubDiario '20210712','20210712',1,1
DROP PROCEDURE INF_venSubDiario
GO
CREATE PROCEDURE INF_venSubDiario 
(
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@Empresa int, 
@IncluCobra Bit
)
AS
SELECT conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	venTipoMov.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm venMovimientos INNER JOIN conAsientos ON
venMovimientos.venMovimientos = conAsientos.conAsientos
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON
conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON
conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipomov = venMovimientos.venTipomov
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	(@IncluCobra=1 or venTipoMov.venTipomov NOT IN ('C','N')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta 
UNION ALL
SELECT conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	venTipoMov.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
	FROm genCancMov INNER JOIN conAsientos ON
genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN venMovimientos ON
venMovimientos.venMovimientos = genCancMov.Asiento_Id
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON
conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON
conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN venSubTipoMov ON 
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipomov = venMovimientos.venTipoMov
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	(@IncluCobra=1 or venTipoMov.venTipoMov NOT IN ('C','N')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta 
UNION ALL
SELECT conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	venTipoMov.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
	FROm genCancMov INNER JOIN conAsientos ON
genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN venMovimientos ON
venMovimientos.venMovimientos = genCancMov.Asiento_Id
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON
conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON
conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN venSubTipoMov ON 
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipomov = venMovimientos.venTipoMov
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	(@IncluCobra=1 or venTipoMov.venTipoMov NOT IN ('C','N')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta And
	conAsientos.conAsientos Not In (Select venMovimientos From venMovimientos) -- Puedo tener ND/NC que esté aplicada y sale 2 veces --
UNION ALL
SELECT conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	'Cierre' as Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
	FROm venAsiCierre INNER JOIN venAsiCierreCr ON
venAsiCierre.Asiento_Id = venAsiCierreCr.Asiento_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos = venAsiCierre.Asiento_Id
INNER JOIN venClientes ON
venClientes.genEntidades = venAsiCierreCr.Cliente_id 
INNER JOIN conMovCont ON 
conMovCont.conAsientos = venAsiCierreCr.Asiento_Id and 
conMovCont.Renglon = venAsiCierreCr.conRenglon
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON
conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON
conCentro2.conCentro2 = conMovCont.Centro2_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  
ORDER BY 1,2,3
GO
