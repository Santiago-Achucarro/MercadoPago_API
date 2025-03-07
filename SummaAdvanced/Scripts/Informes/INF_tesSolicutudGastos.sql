-- INF_tesSolicutudGastos 0, '20200101','20100131',' ','ZZ',' ','ZZ', 1, 1
DROP PROCEDURE INF_tesSolicutudGastos
GO
CREATE PROCEDURE INF_tesSolicutudGastos(
	@Pendiente Bit,
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@CarteraDesde VarChar(5), 
	@CarteraHasta VarChar(5),
	@SolicitanteDesde VarChar(5),
	@SolicitanteHasta VarChar(5),
	@Detallado Bit, 
	@Empresa int
)
AS

if @Detallado = 0
	begin

	SELECT tesSolicitud.tesSolicitud, 
			dbo.Segmento(tesSolSegmentos.Segmento_Id, tesSolSegmentos.Segmento1C,
				tesSolSegmentos.Segmento2C, tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, 
				tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N,
				tesSolSegmentos.Segmento4N) as SegmentoStr, tesSolicitud.Estado, 
				tesSolicitud.Fecha, tesSolicitud.FechaAutorizo, tesSolicitud.FechaCarga, 
				tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, tesSolicitud.Monto, 
				ISNULL((SELECT sum(conMovCont.Importe*(-2*conMovcont.Tipomov+3)) 
					from tesSolRendicion inner join conMovCont ON 
					tesSolRendicion.tesMovimientos = conMovCont.conAsientos 
					INNER JOIN conAsientos ON 
					conAsientos.conAsientos = conMovCont.conAsientos
					INNER JOIN tesRengMovi ON
					tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
					tesRengMovi.conRenglon =conMovCont.Renglon
					Where
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado = 1 and 
					tesRengMovi.TipoMovCont = 1 and 
					conAsientos.Fecha <= @FechaHasta and
					tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud),0) as Rendido, 
					tesSolicitud.Monto -
				ISNULL((SELECT sum(conMovCont.Importe*(-2*conMovcont.Tipomov+3)) 
					from tesSolRendicion inner join conMovCont ON 
					tesSolRendicion.tesMovimientos = conMovCont.conAsientos 
					INNER JOIN conAsientos ON 
					conAsientos.conAsientos = conMovCont.conAsientos
					INNER JOIN tesRengMovi ON
					tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
					tesRengMovi.conRenglon =conMovCont.Renglon
					Where
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado = 1 and 
					tesRengmovi.TipoMovCont = 1 and 
					
					tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud),0) as Saldo
	 FROM tesSolicitud inner join tesSolSegmentos ON
	 tesSolicitud.tesSolicitud = tesSolSegmentos.tesSolicitud
	 INNER JOIN tesSolicitantes ON
	 tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id
	 INNER JOIN tesIdentifica ON 
	 tesIdentifica.tesIdentifica = tesSolicitud.Cartera_Id
	 Where
		tesSolicitud.Estado != 'R' AND 
		exists(select 1 from conasientos conasientosp, tesSolPago where
			conasientosp.conasientos =tesSolPago.tesMovimientos and 
			tesSolPago.tesSolicitud = tesSolicitud.tesSolicitud and 
			conasientosp.Fecha <= @FechaHasta and 
			conasientosp.anulado = 0 and 
			conasientosp.Posteado = 1) and 
		(@Pendiente=0 or (
		(tesSolicitud.Monto - 
				ISNULL((SELECT sum(conMovCont.Importe*(-2*conMovcont.Tipomov+3)) 
					from tesSolRendicion inner join conMovCont ON 
					tesSolRendicion.tesMovimientos = conMovCont.conAsientos 
					INNER JOIN conAsientos ON 
					conAsientos.conAsientos = conMovCont.conAsientos
					INNER JOIN tesRengMovi ON
					tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
					tesRengMovi.conRenglon =conMovCont.Renglon
					Where
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado = 1 and 
					tesRengMovi.TipoMovCont = 1 and 
					tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud),0) > 0 ))) and 
	tesSolicitantes.Solicitante_Id between @SolicitanteDesde And @SolicitanteHasta and 
	--(@Pendiente =1 or  tesSolicitud.Fecha between @FechaDesde And  @FechaHasta) and 
	tesIdentifica.Cartera_Id between @CarteraDesde And  @CarteraHasta and 
	tesSolSegmentos.Empresa_Id = @Empresa
	ORDER BY 4,2

END
ELSE
BEGIN 


	SELECT tesSolicitud.tesSolicitud, 1 tm, 
			dbo.Segmento(tesSolSegmentos.Segmento_Id, tesSolSegmentos.Segmento1C,
				tesSolSegmentos.Segmento2C, tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, 
				tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N,
				tesSolSegmentos.Segmento4N) as SegmentoStr, tesSolicitud.Estado, 
				tesSolicitud.Fecha, tesSolicitud.FechaAutorizo, tesSolicitud.FechaCarga, 
				tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, tesSolicitud.Monto, 
				dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
				genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
				genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
				genAsiSegmentos.Segmento4N) as Segmento1Str, 
				0.00 as Rendido, conAsientos.Fecha as Fecha1
	 FROM tesSolicitud inner join tesSolSegmentos ON
	 tesSolicitud.tesSolicitud = tesSolSegmentos.tesSolicitud
	 INNER JOIN tesSolicitantes ON
	 tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id
	 INNER JOIN tesIdentifica ON 
	 tesIdentifica.tesIdentifica = tesSolicitud.Cartera_Id
	 INNER JOIN tesSolPago ON
	 tesSolPago.tesSolicitud = tesSolicitud.tesSolicitud
	 INNER JOIN genAsiSegmentos ON 
	 genAsiSegmentos.Asiento_Id = tesSolPago.tesMovimientos
	 INNER JOIn conAsientos ON conAsientos.conAsientos = tesSolPago.tesMovimientos
	  Where
		conAsientos.Posteado = 1 and 
		conAsientos.Anulado = 0 and 
		tesSolicitud.Estado != 'R' AND 
		exists(select 1 from conasientos conasientosp, tesSolPago where
			conasientosp.conasientos =tesSolPago.tesMovimientos and 
			tesSolPago.tesSolicitud = tesSolicitud.tesSolicitud and 
			conasientosp.Fecha <= @FechaHasta and 
			conasientosp.anulado = 0 and 
			conasientosp.Posteado = 1) and 

		(@Pendiente=0 or  (
		(tesSolicitud.Monto - 
				ISNULL((SELECT sum(conMovCont.Importe*(-2*conMovcont.Tipomov+3)) 
					from tesSolRendicion inner join conMovCont ON 
					tesSolRendicion.tesMovimientos = conMovCont.conAsientos 
					INNER JOIN conAsientos ON 
					conAsientos.conAsientos = conMovCont.conAsientos
					INNER JOIN tesRengMovi ON
					tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
					tesRengMovi.conRenglon =conMovCont.Renglon
					Where
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado = 1 and 
					tesRengMovi.TipoMovCont = 1 and 
					tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud),0) > 0 ))) and 
	tesSolicitantes.Solicitante_Id between @SolicitanteDesde And @SolicitanteHasta and 
	--(@Pendiente =1 or  tesSolicitud.Fecha between @FechaDesde And  @FechaHasta) and 
	tesIdentifica.Cartera_Id between @CarteraDesde And  @CarteraHasta and 
	tesSolSegmentos.Empresa_Id = @Empresa
	UNION ALL
		SELECT tesSolicitud.tesSolicitud, 2 tm,
			dbo.Segmento(tesSolSegmentos.Segmento_Id, tesSolSegmentos.Segmento1C,
				tesSolSegmentos.Segmento2C, tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, 
				tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N,
				tesSolSegmentos.Segmento4N) as SegmentoStr, tesSolicitud.Estado, 
				conAsientos.Fecha, tesSolicitud.FechaAutorizo, conAsientos.FechaRegistro, 
				tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, 0 Monto, 
				dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
				genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
				genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
				genAsiSegmentos.Segmento4N) as Segmento1Str, 
				SUM(conMovCont.Importe*(-2*conMovcont.Tipomov+3)) as Rendido, conAsientos.Fecha as Fecha1
	 FROM tesSolicitud inner join tesSolSegmentos ON
	 tesSolicitud.tesSolicitud = tesSolSegmentos.tesSolicitud
	 INNER JOIN tesSolicitantes ON
	 tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id
	 INNER JOIN tesIdentifica ON 
	 tesIdentifica.tesIdentifica = tesSolicitud.Cartera_Id
	 INNER JOIN tesSolRendicion ON
	 tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud
	 INNER JOIN genAsiSegmentos ON 
	 genAsiSegmentos.Asiento_Id = tesSolRendicion.tesMovimientos
	 inner join conAsientos ON 
	 conAsientos.conAsientos = tesSolRendicion.tesMovimientos
	 inner join conMovCont ON
	 conMovCont.conAsientos = conAsientos.conAsientos 
	 INNER JOIN tesRengMovi ON
	 tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
	 tesRengMovi.conRenglon =conMovCont.Renglon and
	 tesRengMovi.TipoMovCont = 1
	  Where
		conasientos.anulado = 0 and 
		conasientos.Posteado = 1 and
		tesSolicitud.Estado != 'R' AND 
		exists(select 1 from conasientos conasientosp, tesSolPago where
			conasientosp.conasientos =tesSolPago.tesMovimientos and 
			tesSolPago.tesSolicitud = tesSolicitud.tesSolicitud and 
			conasientosp.Fecha <= @FechaHasta and 
			conasientosp.anulado = 0 and 
			conasientosp.Posteado = 1) and 

		(@Pendiente=0 or  (
		(tesSolicitud.Monto - 
				ISNULL((SELECT sum(conMovCont.Importe*(-2*conMovcont.Tipomov+3)) 
					from tesSolRendicion inner join conMovCont ON 
					tesSolRendicion.tesMovimientos = conMovCont.conAsientos 
					INNER JOIN conAsientos ON 
					conAsientos.conAsientos = conMovCont.conAsientos
					INNER JOIN tesRengMovi ON
					tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
					tesRengMovi.conRenglon =conMovCont.Renglon
					Where
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado = 1 and 
					tesRengMovi.TipoMovCont = 1 and 
					tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud),0) > 0 ))) and 
	tesSolicitantes.Solicitante_Id between @SolicitanteDesde And @SolicitanteHasta and 
	conAsientos.Fecha <= @FechaHasta and
--	(@Pendiente =1 or  tesSolicitud.Fecha between @FechaDesde And  @FechaHasta) and 
	tesIdentifica.Cartera_Id between @CarteraDesde And  @CarteraHasta and 
	tesSolSegmentos.Empresa_Id = @Empresa
	GROUP BY tesSolicitud.tesSolicitud, 
				tesSolSegmentos.Segmento_Id, tesSolSegmentos.Segmento1C,
				tesSolSegmentos.Segmento2C, tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, 
				tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N,
				tesSolSegmentos.Segmento4N , tesSolicitud.Estado, 
				conAsientos.Fecha, tesSolicitud.FechaAutorizo, conAsientos.FechaRegistro, 
				tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, 
				genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
				genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
				genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
				genAsiSegmentos.Segmento4N, conAsientos.Fecha 
	ORDER BY 5,1,2

END


GO

