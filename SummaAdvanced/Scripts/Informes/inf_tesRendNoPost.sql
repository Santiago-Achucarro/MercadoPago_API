-- inf_tesRendNoPost 1
DROP PROCEDURE inf_tesRendNoPost
GO
CREATE PROCEDURE inf_tesRendNoPost(
	@Empresa_Id INT
)
AS

select dbo.Segmento(genAsiSegmentos.Segmento_Id,	
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante,
	dbo.Segmento(tesSolSegmentos.Segmento_Id,	
	tesSolSegmentos.Segmento1C,tesSolSegmentos.Segmento2C, tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C,
	tesSolSegmentos.Segmento1N,tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N, tesSolSegmentos.Segmento4N) Solicitud, 
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, 
	dbo.Segmento(genAsiSegmentosA.Segmento_Id,	
	genAsiSegmentosA.Segmento1C,genAsiSegmentosA.Segmento2C, genAsiSegmentosA.Segmento3C, genAsiSegmentosA.Segmento4C,
	genAsiSegmentosA.Segmento1N,genAsiSegmentosA.Segmento2N, genAsiSegmentosA.Segmento3N, genAsiSegmentosA.Segmento4N) Anticipo, 
	tesSolicitud.Monto as MontoSolicitado, 
	isnull((select SUM(conMovCont1.Importe) 
		From conMovCont conMovCont1 inner join conAsientos conAsientos1 on
			conMovCont1.conAsientos = conAsientos1.conAsientos 
			INNER JOIN tesSolRendicion tesSolRendicion1 on 
			tesSolRendicion1.tesMovimientos = conAsientos1.conAsientos AND 
			tesSolRendicion1.tesSolicitud = tesSolicitud.tesSolicitud
			Where
			conAsientos1.Posteado = 1 and 
			conAsientos1.Anulado = 0),0) as YaRendido,
	SUM(conMovCont.Importe) as MontoRendido, conAsientos.Fecha as FechaRendicion, 
	conAsientos.FechaRegistro 
FROM genAsiSegmentos INNER JOIN conAsientos ON 
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN tesSolRendicion on
	tesSolRendicion.tesMovimientos = conAsientos.conAsientos
	INNER JOIN tesSolicitud ON
	tesSolicitud.tesSolicitud = tesSolRendicion.tesSolicitud
	INNER JOIN tesSolSegmentos ON
	tesSolSegmentos.tesSolicitud = tesSolicitud.tesSolicitud
	INNER JOIN tesSolicitantes ON
	tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id
	INNER JOIN tesSolPago ON 
	tesSolPago.tesSolicitud = tesSolicitud.tesSolicitud
	INNER JOIN conAsientos conAsientosA ON 
	conAsientosA.conAsientos = tesSolPago.tesMovimientos and 
	conAsientosA.Anulado = 0
	INNER JOIN genAsiSegmentos genAsiSegmentosA ON 
	genAsiSegmentosA.Asiento_Id = conAsientosA.conAsientos
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = conAsientos.conAsientos and 
	conMovCont.Tipomov = 1
	WHERE
		conAsientos.Posteado = 0 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Empresa_Id = @Empresa_Id
GROUP BY genAsiSegmentos.Segmento_Id,	
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	tesSolSegmentos.Segmento_Id,	
	tesSolSegmentos.Segmento1C,tesSolSegmentos.Segmento2C, tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C,
	tesSolSegmentos.Segmento1N,tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N, tesSolSegmentos.Segmento4N, 
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, 
	genAsiSegmentosA.Segmento_Id, genAsiSegmentosA.Segmento1C,genAsiSegmentosA.Segmento2C, genAsiSegmentosA.Segmento3C, genAsiSegmentosA.Segmento4C,
	genAsiSegmentosA.Segmento1N,genAsiSegmentosA.Segmento2N, genAsiSegmentosA.Segmento3N, genAsiSegmentosA.Segmento4N, 
	tesSolicitud.Monto, conAsientos.Fecha, conAsientos.FechaRegistro, tesSolicitud.tesSolicitud
order by 1