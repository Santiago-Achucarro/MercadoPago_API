-- Inf_conMayor '2143-401','2143-401',' ','ZZZZZZZZ',' ','ZZZZZZZZ','20220801','20221030',1,0, 'es',1,0

-- Inf_conMayor '1140-101','1140-101',' ','ZZZZZZZZ',' ','ZZZZZZZZ','20190501','20190531',1,1, 'en'
DROP Procedure Inf_conMayor
GO

Create Procedure Inf_conMayor
( 
	@CuentaDesde VarChar(25),@CuentaHasta VarChar(25), 
	@Centro1Desde VarChar(8), @Centro1Hasta VarChar(8),  
	@Centro2Desde VarChar(8), @Centro2Hasta VarChar(8),  
	@FechaDesde DateTime, @FechaHasta DateTime, @Empresa Int,
	@ConSaldo Sino,  @Cultura VarChar(5)=null, 
	@IncuCierre Bit, @ResumirPorCom Bit)
AS

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))
DECLARE @FechaDesdeE DateTime

/* FM 11/05/2020 Que vaya hasta el primer asiento de apertura cualquiera sea el ejercicio

SET @FechaDesdeE = (select min(Fecha_Desde) from conPeriodos WHERE
			conPeriodos.Empresa_Id = @Empresa AND 
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				conPeriodos1.Empresa_Id = @Empresa AND 
				@FechaHasta between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta))
*/
Set @FechaDesdeE = isNull((Select Max(Fecha) From conAsientos Where Fecha <= @FechaDesde And Especial = 'APE'), '20000101')

IF @ResumirPorCom = 0

	SELECT conCuentas.Cuenta_Id, 
		case when @EnOtro=1 then concuentas.Description else conCuentas.Descripcion end Descripcion , 
		DATEADD(dd, -1,@FechaDesde) as Fecha, 
		case when @EnOtro=1 then 'INITIAL BALANCE' else 'SALDO INICIAL' end AS Segmento,
		0 as conAsientos, 
		'  ' as Formulario, ' ' as Formulario_Id,
		' ' Centro1_Id, ' ' Centro2_Id, 
		SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3)) as SaldoInicial, 
		0 As Debe,
		0 As Haber,'' as Observaciones,  ' ' Entidad, ' ' RazonSocial, ' ' Detalle, ' ' as ClaveFiscal,
		'' as SegmentotesMoviSTR, ' ' as Sucursal, '  ' as Clase
	From conCuentas 
	INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = ISNULL(conMovCont.Centro1_Id,' ')
	LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = ISNULL(conMovCont.Centro2_Id,' ')
	INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
	Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
	WHERE
	@ConSaldo = 1 And
	conAsientos.Empresa_Id = @Empresa and conAsientos.Anulado = 0 And conAsientos.Posteado = 1 and 
	(conAsientos.Fecha < @FechaDesde or conAsientos.Especial = 'APE') and 
	(conAsientos.Fecha between @FechaDesdeE AND @FechaDesde) and 
	conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
	ISNULL(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	ISNULL(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta And
	(conAsientos.Fecha >= genEmpresas.FechaInicioSumma OR conAsientosCon.conAsientos IS NoT NULL)
	GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, concuentas.Description
	UNION ALL
	SELECT conCuentas.Cuenta_Id, 
		case when @EnOtro=1 then concuentas.Description else conCuentas.Descripcion end Descripcion , 
		conAsientos.Fecha, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
		, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
		, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
		conAsientos.conAsientos, disFormularios.Descripcion as Formulario,disFormularios.Formulario_Id,
		ISNULL(conCentro1.Centro1_Id,' ') as Centro1_Id,
		ISNULL(conCentro2.Centro2_Id,' ') as Centro2_Id,
		0 as SaldoInicial, 
		CASE WHEN conMovCont.Tipomov = 1 then  conMovCont.Importe else 0 end As Debe,
		CASE WHEN conMovCont.Tipomov = 2 then  conMovCont.Importe else 0 end As Haber,
		ISNULL(conAsientos.Observaciones,'') AS Observaciones, 
			ISNULL(iSNULL(iSNULL(isnull(isnull(venclientes.Cliente_Id, comProveedores.Proveed_Id),venClientesS.Cliente_Id), comProveedoresA.Proveed_Id), venClientesA.Cliente_Id), comProveedoresR.Proveed_Id) as Entidad, 
			ISNULL(isnull(isnull(isnull(isnull(venclientes.RazonSocial, comProveedores.RazonSocial),venClientesS.RazonSocial), comProveedoresA.RazonSocial), venClientesA.RazonSocial), comProveedoresR.RazonSocial) as RazonSocial,		
			CASE WHEN venMovDetalle.Detalle is not null then venMovDetalle.Detalle
				WHEN comMovDetalle.Detalle is not null then comMovDetalle.Detalle
				when CompApli.Segmento_Id IS NOT NULL THEN 
				dbo.Segmento(CompApli.Segmento_Id, CompApli.Segmento1C, CompApli.Segmento2C
					, CompApli.Segmento3C, CompApli.Segmento4C, CompApli.Segmento1N
					, CompApli.Segmento2N, CompApli.Segmento3N, CompApli.Segmento4N)
				When CompDC.Segmento_Id  IS NOT NULL THEN 
			dbo.Segmento(CompDC.Segmento_Id, CompDC.Segmento1C, CompDC.Segmento2C
				, CompDC.Segmento3C, CompDC.Segmento4C, CompDC.Segmento1N
				, CompDC.Segmento2N, CompDC.Segmento3N, CompDC.Segmento4N)
				ELSE isnull(conMovCont.LeyendaLibroMayor,'') END as Detalle,
		isnull(isnull(venMovimientosFiscal.ClaveFiscal,isnull(comMovProv.ClaveFiscal, comMovprovA.ClaveFiscal)),' ') as ClaveFiscal,
			dbo.Segmento(SegtesMovi.Segmento_Id,SegtesMovi.Segmento1C,SegtesMovi.Segmento2C,
			SegtesMovi.Segmento3C,SegtesMovi.Segmento4C,SegtesMovi.Segmento1N,SegtesMovi.Segmento2N,
			SegtesMovi.Segmento3N,SegtesMovi.Segmento4N) as SegmentotesMoviSTR, 
			genSucursalesEmpr.Sucursal, conMovCont.Clase

	From conCuentas INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
	LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	left join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	left JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
	Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
	left join (commovprov inner join comProveedores ON  commovprov.Proveed_Id = comProveedores.genEntidades) ON commovprov.comMovProv = conAsientos.conAsientos
	left join (comOcReceCuerpo inner join comOrdenComp ON  comOrdenComp.comOrdenComp = comOcReceCuerpo.comOrdencomp 
		inner join comProveedores  comProveedoresR ON comOrdenComp.Proveed_Id = comProveedoresR.genEntidades) ON comOcReceCuerpo.comOcRecepcion = conMovCont.conAsientos AND 
					comOcReceCuerpo.conRenglon = conMovCont.Renglon 
	left join (venMovimientos inner join venclientes ON  venClientes.genEntidades = venMovimientos.Cliente_Id) ON venMovimientos.venMovimientos = conAsientos.conAsientos
	left join (commovdetallecont  INNER JOIN comMovDetalle ON
		comMovDetalle.comMovProv = commovdetallecont.comMovProv AND 
		comMovDetalle.Renglon =  commovdetallecont.Renglon) on commovdetallecont.comMovProv = conMovCont.conAsientos  and 
			commovdetallecont.conRenglon = conmovcont.Renglon
	LEFT JOIN venMovDetalle on 
		venMovDetalle.venMovimientos = conmovcont.conAsientos and 
		venMovDetalle.conRenglon = conMovcont.Renglon
		left join tesRengMovicomMovProv on conMovCont.conAsientos=tesRengMovicomMovProv.comMovProv
		left join genAsiSegmentos SegtesMovi on SegtesMovi.Asiento_Id=tesRengMovicomMovProv.tesMovimientos
		left join venMovimientosFiscal on conMovCont.conAsientos=venMovimientosFiscal.venMovimientos
		left join genSegmentos genSegmentotesMovi on SegtesMovi.Segmento_Id=genSegmentotesMovi.genSegmentos
		-- factura directa
	LEFT JOIN (select venClientesS.Cliente_Id, venClientesS.RazonSocial, 
		venMovStkHist.stkMoviCabe, max(stkMoviCuerpo.conRenglonDebe) conRenglonDebe, max(stkMoviCuerpo.conRenglonHaber) conRenglonHaber
		from 
		venMovStkHist inner join  stkMoviCuerpo on  
		venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		venMovStkHist.RenglonCuerpo = stkMoviCuerpo.Renglon
		inner join venMovimientos venMovimientosS ON 
		venMovimientosS.venMovimientos = venMovStkHist.venMovimientos
		INNER JOIN venClientes venClientesS ON 
		venClientesS.genEntidades = venMovimientosS.Cliente_Id
		group by venClientesS.Cliente_Id, venClientesS.RazonSocial, 
		venMovStkHist.stkMoviCabe
		) as  venClientesS on
		venClientesS.stkMoviCabe = conMovCont.conAsientos AND 
		(venClientesS.conRenglonDebe = conMovCont.Renglon or
		venClientesS.conRenglonHaber = conMovCont.Renglon)
	LEFT JOIN (comMovImpAcredita 
		INNER JOIN comMovprov comMovprovA ON comMovprovA.comMovprov = comMovImpAcredita.comMovProv
		INNER JOIN comProveedores  comProveedoresA ON comProveedoresA.genEntidades = comMovprovA.Proveed_Id) ON
		comMovImpAcredita.Asiento_Id = conAsientos.conAsientos and 
		(comMovImpAcredita.RenglonDebe = conMovCont.Renglon  or comMovImpAcredita.RenglonHaber = conMovCont.Renglon ) 
	LEFT JOIN ((SELECT MAX(venMovImpTraslado.tesMovimientos) AS tesMovimientos, venMovImpTraslado.Asiento_Id, venMovImpTraslado.RenglonDebe, venMovImpTraslado.RenglonHaber 
			FROM  venMovImpTraslado 
			GROUP BY venMovImpTraslado.Asiento_Id, venMovImpTraslado.RenglonDebe, venMovImpTraslado.RenglonHaber ) AS venMovImpTraslado
		INNER JOIN venMovimientos venMovimientosA ON venMovimientosA.venMovimientos = venMovImpTraslado.tesMovimientos 
		INNER JOIN venClientes venClientesA ON venClientesA.genEntidades = venMovimientosA.Cliente_Id) ON
		venMovImpTraslado.Asiento_Id = conAsientos.conAsientos and 
		(venMovImpTraslado.RenglonDebe = conMovCont.Renglon  or venMovImpTraslado.RenglonHaber = conMovCont.Renglon ) 
	LEFT JOIN (genCancMov INNER JOIN genAsiSegmentos as CompApli ON
					genCancMov.Asiento_Id = CompApli.Asiento_Id) ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
	LEFT JOIN (genCancMov genCancMovDC INNER JOIN genAsiSegmentos as CompDC ON
					genCancMovDC.Asiento_Id = CompDC.Asiento_Id) ON genCancMovDC.AsieDifCambio_Id = conAsientos.conAsientos


	WHERE
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha Between @FechaDesde and @FechaHasta and 
	conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
	ISNULL(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	ISNULL(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta And
	(conAsientos.Fecha >= genEmpresas.FechaInicioSumma OR conAsientosCon.conAsientos IS NoT NULL) AND 
	conAsientos.Especial != 'APE' and 
	(@IncuCierre=1 or (conAsientos.Especial NOT IN('CIR','CCP')))
	And conMovCont.Importe <> 0
	ORDER BY 1,3,4
	OPTION	(RECOMPILE)

ELSE


	SELECT conCuentas.Cuenta_Id, 
		case when @EnOtro=1 then concuentas.Description else conCuentas.Descripcion end Descripcion , 
		DATEADD(dd, -1,@FechaDesde) as Fecha, 
		case when @EnOtro=1 then 'INITIAL BALANCE' else 'SALDO INICIAL' end AS Segmento,
		0 as conAsientos, 
		'  ' as Formulario, ' ' as Formulario_Id,
		' ' Centro1_Id, ' ' Centro2_Id, 
		SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3)) as SaldoInicial, 
		0 As Debe,
		0 As Haber,'' as Observaciones,  ' ' Entidad, ' ' RazonSocial, ' ' Detalle, ' ' as ClaveFiscal,
		'' as SegmentotesMoviSTR, ' ' as Sucursal, ' ' Clase
	From conCuentas INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = ISNULL(conMovCont.Centro1_Id,' ')
	LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = ISNULL(conMovCont.Centro2_Id,' ')
	INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
	Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
	WHERE
	@ConSaldo = 1 And
	conAsientos.Empresa_Id = @Empresa and conAsientos.Anulado = 0 And conAsientos.Posteado = 1 and 
	(conAsientos.Fecha < @FechaDesde or conAsientos.Especial = 'APE') and 
	(conAsientos.Fecha between @FechaDesdeE AND @FechaDesde) and 
	conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
	ISNULL(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	ISNULL(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta And
	(conAsientos.Fecha >= genEmpresas.FechaInicioSumma OR conAsientosCon.conAsientos IS NoT NULL)
	GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, concuentas.Description
	UNION ALL
	SELECT conCuentas.Cuenta_Id, 
		case when @EnOtro=1 then concuentas.Description else conCuentas.Descripcion end Descripcion , 
		conAsientos.Fecha, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
		, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
		, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
		conAsientos.conAsientos, disFormularios.Descripcion as Formulario,disFormularios.Formulario_Id,
		ISNULL(conCentro1.Centro1_Id,' ') as Centro1_Id,
		ISNULL(conCentro2.Centro2_Id,' ') as Centro2_Id,
		0 as SaldoInicial, 
		sum(CASE WHEN conMovCont.Tipomov = 1 then  conMovCont.Importe else 0 end) As Debe,
		sum(CASE WHEN conMovCont.Tipomov = 2 then  conMovCont.Importe else 0 end) As Haber,
		ISNULL(conAsientos.Observaciones,'') AS Observaciones, 
			iSNULL(iSNULL(iSNULL(isnull(isnull(venclientes.Cliente_Id, comProveedores.Proveed_Id),venClientesS.Cliente_Id), comProveedoresA.Proveed_Id), venClientesA.Cliente_Id), comProveedoresR.Proveed_Id) as Entidad, 
			iSNULL(isnull(isnull(isnull(isnull(venclientes.RazonSocial, comProveedores.RazonSocial),venClientesS.RazonSocial), comProveedoresA.RazonSocial), venClientesA.RazonSocial), comProveedoresR.RazonSocial) as RazonSocial,		
			CASE WHEN venMovDetalle.Detalle is not null then venMovDetalle.Detalle
				WHEN comMovDetalle.Detalle is not null then comMovDetalle.Detalle
				when CompApli.Segmento_Id IS NOT NULL THEN 
				dbo.Segmento(CompApli.Segmento_Id, CompApli.Segmento1C, CompApli.Segmento2C
					, CompApli.Segmento3C, CompApli.Segmento4C, CompApli.Segmento1N
					, CompApli.Segmento2N, CompApli.Segmento3N, CompApli.Segmento4N)
				When CompDC.Segmento_Id  IS NOT NULL THEN 
			dbo.Segmento(CompDC.Segmento_Id, CompDC.Segmento1C, CompDC.Segmento2C
				, CompDC.Segmento3C, CompDC.Segmento4C, CompDC.Segmento1N
				, CompDC.Segmento2N, CompDC.Segmento3N, CompDC.Segmento4N)
				ELSE isnull(conMovCont.LeyendaLibroMayor,'') END  as Detalle,
			isnull(isnull(venMovimientosFiscal.ClaveFiscal,ISNULL(comMovProv.ClaveFiscal, comMovProvA.ClaveFiscal)),' ') as ClaveFiscal,
			dbo.Segmento(SegtesMovi.Segmento_Id,SegtesMovi.Segmento1C,SegtesMovi.Segmento2C,
			SegtesMovi.Segmento3C,SegtesMovi.Segmento4C,SegtesMovi.Segmento1N,SegtesMovi.Segmento2N,
			SegtesMovi.Segmento3N,SegtesMovi.Segmento4N) as SegmentotesMoviSTR, 
			genSucursalesEmpr.Sucursal, conMovCont.Clase

	From conCuentas INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
	LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	left join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	left JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
	Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
	left join (commovprov inner join comProveedores ON  commovprov.Proveed_Id = comProveedores.genEntidades) ON commovprov.comMovProv = conAsientos.conAsientos
	left join (venMovimientos inner join venclientes ON  venClientes.genEntidades = venMovimientos.Cliente_Id) ON venMovimientos.venMovimientos = conAsientos.conAsientos
	left join (commovdetallecont  INNER JOIN comMovDetalle ON
		comMovDetalle.comMovProv = commovdetallecont.comMovProv AND 
		comMovDetalle.Renglon =  commovdetallecont.Renglon) on commovdetallecont.comMovProv = conMovCont.conAsientos  and 
			commovdetallecont.conRenglon = conmovcont.Renglon
	LEFT JOIN venMovDetalle on 
		venMovDetalle.venMovimientos = conmovcont.conAsientos and 
		venMovDetalle.conRenglon = conMovcont.Renglon
		left join tesRengMovicomMovProv on conMovCont.conAsientos=tesRengMovicomMovProv.comMovProv
		left join genAsiSegmentos SegtesMovi on SegtesMovi.Asiento_Id=tesRengMovicomMovProv.tesMovimientos
		left join venMovimientosFiscal on conMovCont.conAsientos=venMovimientosFiscal.venMovimientos
		left join genSegmentos genSegmentotesMovi on SegtesMovi.Segmento_Id=genSegmentotesMovi.genSegmentos
	left join (comOcReceCuerpo inner join comOrdenComp ON  comOrdenComp.comOrdenComp = comOcReceCuerpo.comOrdencomp 
		inner join comProveedores  comProveedoresR ON comOrdenComp.Proveed_Id = comProveedoresR.genEntidades) ON comOcReceCuerpo.comOcRecepcion = conMovCont.conAsientos AND 
					comOcReceCuerpo.conRenglon = conMovCont.Renglon 
		-- factura directa
	LEFT JOIN (select venClientesS.Cliente_Id, venClientesS.RazonSocial, 
		venMovStkHist.stkMoviCabe, max(stkMoviCuerpo.conRenglonDebe) conRenglonDebe, max(stkMoviCuerpo.conRenglonHaber) conRenglonHaber
		from 
		venMovStkHist inner join  stkMoviCuerpo on  
		venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		venMovStkHist.RenglonCuerpo = stkMoviCuerpo.Renglon
		inner join venMovimientos venMovimientosS ON 
		venMovimientosS.venMovimientos = venMovStkHist.venMovimientos
		INNER JOIN venClientes venClientesS ON 
		venClientesS.genEntidades = venMovimientosS.Cliente_Id
		group by venClientesS.Cliente_Id, venClientesS.RazonSocial, 
		venMovStkHist.stkMoviCabe
		) as  venClientesS on
		venClientesS.stkMoviCabe = conMovCont.conAsientos AND 
		(venClientesS.conRenglonDebe = conMovCont.Renglon or
		venClientesS.conRenglonHaber = conMovCont.Renglon)
	LEFT JOIN (comMovImpAcredita 
		INNER JOIN comMovprov comMovprovA ON comMovprovA.comMovprov = comMovImpAcredita.comMovProv 
		INNER JOIN comProveedores  comProveedoresA ON comProveedoresA.genEntidades = comMovprovA.Proveed_Id) ON
		comMovImpAcredita.Asiento_Id = conAsientos.conAsientos and 
		(comMovImpAcredita.RenglonDebe = conMovCont.Renglon  or comMovImpAcredita.RenglonHaber = conMovCont.Renglon ) 
	LEFT JOIN ((SELECT MAX(venMovImpTraslado.tesMovimientos) AS tesMovimientos, venMovImpTraslado.Asiento_Id, venMovImpTraslado.RenglonDebe, venMovImpTraslado.RenglonHaber 
			FROM  venMovImpTraslado 
			GROUP BY venMovImpTraslado.Asiento_Id, venMovImpTraslado.RenglonDebe, venMovImpTraslado.RenglonHaber ) AS venMovImpTraslado
		INNER JOIN venMovimientos venMovimientosA ON venMovimientosA.venMovimientos = venMovImpTraslado.tesMovimientos 
		INNER JOIN venClientes venClientesA ON venClientesA.genEntidades = venMovimientosA.Cliente_Id) ON
		venMovImpTraslado.Asiento_Id = conAsientos.conAsientos and 
		(venMovImpTraslado.RenglonDebe = conMovCont.Renglon  or venMovImpTraslado.RenglonHaber = conMovCont.Renglon ) 
		LEFT JOIN (genCancMov INNER JOIN genAsiSegmentos as CompApli ON
					genCancMov.Asiento_Id = CompApli.Asiento_Id) ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
		LEFT JOIN (genCancMov genCancMovDC INNER JOIN genAsiSegmentos as CompDC ON
					genCancMovDC.Asiento_Id = CompDC.Asiento_Id) ON genCancMovDC.AsieDifCambio_Id = conAsientos.conAsientos

	WHERE
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha Between @FechaDesde and @FechaHasta and 
	conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
	ISNULL(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	ISNULL(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta And
	(conAsientos.Fecha >= genEmpresas.FechaInicioSumma OR conAsientosCon.conAsientos IS NoT NULL) AND 
	conAsientos.Especial != 'APE' and 
	(@IncuCierre=1 or (conAsientos.Especial NOT IN('CIR','CCP')))
	And conMovCont.Importe <> 0
	GROUP BY conCuentas.Cuenta_Id, 	conCuentas.Descripcion , 
		conAsientos.Fecha, 
		genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
		, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
		, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		conAsientos.conAsientos, disFormularios.Descripcion ,disFormularios.Formulario_Id,
		ISNULL(conCentro1.Centro1_Id,' ') ,ISNULL(conCentro2.Centro2_Id,' ') ,
		conAsientos.Observaciones,venclientes.Cliente_Id, comProveedores.Proveed_Id,
		venClientesS.Cliente_Id, comProveedoresA.Proveed_Id, venClientesA.Cliente_Id,
		venclientes.RazonSocial, comProveedores.RazonSocial,venClientesS.RazonSocial, comProveedoresA.RazonSocial, venClientesA.RazonSocial,		
		venMovDetalle.Detalle, comMovDetalle.Detalle, conMovCont.LeyendaLibroMayor,
		venMovimientosFiscal.ClaveFiscal,comMovProv.ClaveFiscal,
		SegtesMovi.Segmento_Id,SegtesMovi.Segmento1C,SegtesMovi.Segmento2C,
			SegtesMovi.Segmento3C,SegtesMovi.Segmento4C,SegtesMovi.Segmento1N,SegtesMovi.Segmento2N,
			SegtesMovi.Segmento3N,SegtesMovi.Segmento4N,genSucursalesEmpr.Sucursal, 
			concuentas.Description, 
			CompApli.Segmento_Id, CompApli.Segmento1C, CompApli.Segmento2C
		, CompApli.Segmento3C, CompApli.Segmento4C, CompApli.Segmento1N
		, CompApli.Segmento2N, CompApli.Segmento3N, CompApli.Segmento4N,CompDC.Segmento_Id, CompDC.Segmento1C, CompDC.Segmento2C
		, CompDC.Segmento3C, CompDC.Segmento4C, CompDC.Segmento1N, conMovCont.Clase
		, CompDC.Segmento2N, CompDC.Segmento3N, CompDC.Segmento4N, comMovprovA.ClaveFiscal, 
		comProveedoresR.Proveed_Id, comProveedoresR.RazonSocial
	ORDER BY 1,3,4
	OPTION	(RECOMPILE)

GO


