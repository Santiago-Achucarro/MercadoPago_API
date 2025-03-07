DROP PROCEDURE Inf_ComFactARecibirImp
GO
CREATE PROCEDURE Inf_ComFactARecibirImp @FechaHasta DateTime, @Empresa int, @FechaDesde DateTime, @Tipo int
AS
IF @Tipo = 1
	SELECT EmbarqueSeg, comEmbarques, Fecha, FechaEmbarque, FechaArribo,
		Embarque, Recepcion, FacturasMerc , 
		FacturasGastos, Cierres, 
		Embarque + Recepcion + FacturasMerc +FacturasGastos + Cierres as Saldo
	from (
	SELECT  dbo.Segmento(genAsiSegmentos.Segmento_id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) as EmbarqueSeg,
		comEmbarques.comEmbarques , 
		conAsientos.Fecha, comEmbarques.FechaEmbarque, comEmbarques.FechaArribo,
		sum(case when conAsientos.Fecha <= @FechaHasta then
		conMovCont.importe*(-2*conMovCont.Tipomov+3) else 0 end ) Embarque, 
		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN stkMoviEmbarque on 
			 stkMoviEmbarque.stkMoviCabe = conAsientos.conAsientos and 
			 stkMoviEmbarque.comEmbarques = comEmbarques.comEmbarques
			 Where
		 			clase = 'OEFAR' and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0),0) as Recepcion,

		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN comMovProvEmb on 
			 comMovProvEmb.comMovProv = conAsientos.conAsientos and 
			 comMovProvEmb.comEmbarques = comEmbarques.comEmbarques 
			 Where
				not exists(select 1 from  comEmbGastoMovProv Where
				 comEmbGastoMovProv.comMovProv = conMovCont.conAsientos and 
				 comEmbGastoMovProv.comRenglon = conMovCont.Renglon) and
		 			clase = 'OEFAR' and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0),0) as FacturasMerc,

		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN comEmbGastoMovProv on 
			 comEmbGastoMovProv.comMovProv = conAsientos.conAsientos and 
			 comEmbGastoMovProv.comEmbarques = comEmbarques.comEmbarques and 
			 comEmbGastoMovProv.comRenglon = conMovCont.Renglon
				Where
		 			--clase IN('FACAR','OEFAR') and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0),0) as FacturasGastos, 
		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN comEmbAsiCierre on 
			 comEmbAsiCierre.stkMoviCabe = conAsientos.conAsientos and 
			 comEmbAsiCierre.comEmbarques = comEmbarques.comEmbarques
			 Where
		 			clase = 'OEFAR' and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha <= @FechaHasta and
					conAsientos.Anulado = 0),0) as Cierres
		from conMovCont inner join comEmbarques ON
			conMovCont.conAsientos = comEmbarques.comEmbarques
			INNER JOIN conAsientos ON
			conAsientos.conAsientos = comEmbarques.comEmbarques
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos  
		Where
			comEmbarques.Estado_Id != 'Q' AND 
			clase = 'OEFAR' and 
			conAsientos.Empresa_Id = @Empresa and 
			conAsientos.Anulado = 0
	group by comEmbarques.comEmbarques, genAsiSegmentos.Empresa_Id, 
		conAsientos.Fecha, genAsiSegmentos.Segmento_id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N, comEmbarques.FechaEmbarque, comEmbarques.FechaArribo ) as XXX
	Where
		Embarque + Recepcion + FacturasMerc +FacturasGastos + Cierres <> 0
	ORDER BY 1
ELSE
	SELECT EmbarqueSeg, comEmbarques, Fecha, FechaEmbarque, FechaArribo,
		Embarque, Recepcion, FacturasMerc , 
		FacturasGastos, Cierres, 
		Embarque + Recepcion + FacturasMerc +FacturasGastos + Cierres as Saldo
	from (
	SELECT  dbo.Segmento(genAsiSegmentos.Segmento_id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) as EmbarqueSeg,
		comEmbarques.comEmbarques , 
		conAsientos.Fecha, comEmbarques.FechaEmbarque, comEmbarques.FechaArribo,
		sum(case when conAsientos.Fecha <= @FechaHasta then
		conMovCont.importe*(-2*conMovCont.Tipomov+3) else 0 end ) Embarque, 
		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN stkMoviEmbarque on 
			 stkMoviEmbarque.stkMoviCabe = conAsientos.conAsientos and 
			 stkMoviEmbarque.comEmbarques = comEmbarques.comEmbarques
			 Where
		 			clase = 'OEFAR' and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and
					conAsientos.Anulado = 0),0) as Recepcion,

		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN comMovProvEmb on 
			 comMovProvEmb.comMovProv = conAsientos.conAsientos and 
			 comMovProvEmb.comEmbarques = comEmbarques.comEmbarques 
			 Where
				not exists(select 1 from  comEmbGastoMovProv Where
				 comEmbGastoMovProv.comMovProv = conMovCont.conAsientos and 
				 comEmbGastoMovProv.comRenglon = conMovCont.Renglon) and
		 			clase = 'OEFAR' and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and
					conAsientos.Anulado = 0),0) as FacturasMerc,

		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN comEmbGastoMovProv on 
			 comEmbGastoMovProv.comMovProv = conAsientos.conAsientos and 
			 comEmbGastoMovProv.comEmbarques = comEmbarques.comEmbarques and 
			 comEmbGastoMovProv.comRenglon = conMovCont.Renglon
				Where
		 			--clase IN('FACAR','OEFAR') and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and
					conAsientos.Anulado = 0),0) as FacturasGastos, 
		isnull((select sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from
			conMovCont INNER JOIN conAsientos ON 
			 conMovCont.conAsientos = conAsientos.conAsientos
			 INNER JOIN comEmbAsiCierre on 
			 comEmbAsiCierre.stkMoviCabe = conAsientos.conAsientos and 
			 comEmbAsiCierre.comEmbarques = comEmbarques.comEmbarques
			 Where
		 			clase = 'OEFAR' and 
					conAsientos.Empresa_Id = @Empresa and 
					conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and
					conAsientos.Anulado = 0),0) as Cierres
		from conMovCont inner join comEmbarques ON
			conMovCont.conAsientos = comEmbarques.comEmbarques
			INNER JOIN conAsientos ON
			conAsientos.conAsientos = comEmbarques.comEmbarques
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos  
		Where
			comEmbarques.Estado_Id != 'Q' AND 
			clase = 'OEFAR' and 
			conAsientos.Empresa_Id = @Empresa and 
			conAsientos.Anulado = 0
	group by comEmbarques.comEmbarques, genAsiSegmentos.Empresa_Id, 
		conAsientos.Fecha, genAsiSegmentos.Segmento_id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N, comEmbarques.FechaEmbarque, comEmbarques.FechaArribo ) as XXX
	ORDER BY 1
GO










