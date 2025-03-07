-- Inf_StkSubDiario '20170101','20170831',1
DROP PROCEDURE Inf_StkSubDiario
GO
CREATE PROCEDURE Inf_StkSubDiario @FechaDesde DateTime, @FechaHasta DateTime,
	@Empresa int
AS
SELECT conAsientos.Fecha,conAsientos.conAsientos, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	conMovCont.Renglon,  stkSubTipoMov.Descripcion, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm stkMoviCabe INNER JOIN conAsientos ON
stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
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
INNER JOIN stkSubTipoMov ON
stkSubTipoMov.SubTipomov_id = stkMoviCabe.SubTipomov_id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  
ORDER BY 1,2,4
GO
