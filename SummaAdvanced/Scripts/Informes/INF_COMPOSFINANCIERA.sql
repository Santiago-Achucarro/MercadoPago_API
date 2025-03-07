-- INF_COMPOSFINANCIERADETA ' ','zzzz','20210225',60,1, 1
-- INF_COMPOSFINANCIERA ' ','zzzz','20201201',60,1, 1
DROP PROCEDURE INF_COMPOSFINANCIERADETA
--ComPosfinancieraDeta
GO
CREATE PROCEDURE INF_COMPOSFINANCIERADETA(
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Fecha DateTime, 
	@Dias Int,
	@Columna int,
	@Empresa Int
)

AS
DECLARE @Fecha1 DateTime
DECLARE @Fecha2 DateTime
DECLARE @Fecha3 DateTime
DECLARE @Fecha4 DateTime
DECLARE @Fecha5 DateTime

SET @Fecha1 = dateadd(dd, @Dias*(1-@Columna), @Fecha)
SET @Fecha2 = dateadd(dd, @Dias*(2-@Columna), @Fecha)
SET @Fecha3 = dateadd(dd, @Dias*(3-@Columna), @Fecha)
SET @Fecha4 = dateadd(dd, @Dias*(4-@Columna), @Fecha)
SET @Fecha5 = dateadd(dd, @Dias*(5-@Columna), @Fecha)


SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	conAsientos.Cambio, 
	conAsientos.Fecha as FechaFactura, 
	genMovCuotas.FechaVencimiento, 
	comProveedores.RazonSocial, 
		dbo.Segmento(genAsiSegmentos.Segmento_id, 
			genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
			genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
			genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
			genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento, 
		CASE WHEN genMovCuotas.FechaVencimiento < @FECHA1 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Anterior ,
		CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA1 And
				genMovCuotas.FechaVencimiento < @FECHA2
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo01 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA2 And
				genMovCuotas.FechaVencimiento < @FECHA3
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo02 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA3 And
				genMovCuotas.FechaVencimiento < @FECHA4
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo03 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA4 And
				genMovCuotas.FechaVencimiento < @FECHA5
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo04 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA5
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Posterior ,

		(-comMovTipos.Signo*genMovCuotas.Saldo) AS Saldo, 
		@Fecha as Fecha,
		@Fecha1 as Fecha1,@Fecha2 as Fecha2, @Fecha3 as Fecha3,
		@Fecha4 as Fecha4, @Fecha5 as Fecha5
	
FROM comMovProv inner join comProveedores ON
	comMovProv.Proveed_id = comProveedores.genEntidades
	INNER JOIN genProvincias ON 
	genProvincias.genProvincias = comProveedores.Provincia_Id
	INNER JOIN genPaises ON
	genPaises.genPaises = comProveedores.Pais
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = comMovProv.comMovProv
	inner join genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join genAsiSegmentos on 
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN comMovTipos ON
	comMovTipos.TipoMov = comMovprov.TipoMov
	INNER JOIN (select genMovCuotas.Asiento_Id, 
		genMovCuotas.FechaVencimiento,
		genMovCuotas.Saldo + 
			isnull((select sum(genCancMov.Importe) from genCancMov , conAsientos where
				genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
				genCancMov.Asiento_Id_ap = conAsientos.conAsientos and
				conAsientos.Anulado = 0 and 
				genCancMov.FechaAplicacion > @Fecha),0) +
	isnull((select sum(genCancMov.Importe) from genCancMov , conAsientos where
				genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
				genCancMov.Asiento_Id = conAsientos.conAsientos and
				conAsientos.Anulado = 0 and 
				genCancMov.FechaAplicacion > @Fecha),0)
				 as Saldo
	 from genMovCuotas) genMovCuotas ON
	genMovCuotas.Asiento_Id = comMovprov.comMovprov
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		commovprov.FacturaTesoreria = 0 and 
		conAsientos.Fecha <= @Fecha and 
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		genMovCuotas.Saldo <> 0 and 
		conAsientos.Empresa_Id = @Empresa

ORDER BY 1,2,5,4

GO
DROP PROCEDURE INF_COMPOSFINANCIERA
--ComPosfinancieraDeta
GO

CREATE PROCEDURE INF_COMPOSFINANCIERA(
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Fecha DateTime, 
	@Dias Int,
	@Columna int,
	@Empresa Int
)
AS
DECLARE @Fecha1 DateTime
DECLARE @Fecha2 DateTime
DECLARE @Fecha3 DateTime
DECLARE @Fecha4 DateTime
DECLARE @Fecha5 DateTime

SET @Fecha1 = dateadd(dd, @Dias*(1-@Columna), @Fecha)
SET @Fecha2 = dateadd(dd, @Dias*(2-@Columna), @Fecha)
SET @Fecha3 = dateadd(dd, @Dias*(3-@Columna), @Fecha)
SET @Fecha4 = dateadd(dd, @Dias*(4-@Columna), @Fecha)
SET @Fecha5 = dateadd(dd, @Dias*(5-@Columna), @Fecha)


SELECT Proveed_Id, Moneda_Id,  RazonSocial, SUM(Anterior) as Anterior, 
	SUM(Periodo01) Periodo01, SUM(Periodo02) Periodo02, SUM(Periodo03) Periodo03,
	SUM(Periodo04) Periodo04, SUM(Posterior) Posterior, SUM(Saldo) Saldo,
	Fecha, Fecha1, Fecha2, Fecha3, Fecha4, Fecha5
FROM (
SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	conAsientos.Cambio, conAsientos.Fecha AS FechaFactura, 
	genMovCuotas.FechaVencimiento, 
	comProveedores.RazonSocial, 
		dbo.SegmentoSP(genAsiSegmentos.Segmento_id, 
			genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
			genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
			genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
			genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento, 
		CASE WHEN genMovCuotas.FechaVencimiento < @FECHA1 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Anterior ,
		CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA1 And
				genMovCuotas.FechaVencimiento < @FECHA2
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo01 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA2 And
				genMovCuotas.FechaVencimiento < @FECHA3
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo02 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA3 And
				genMovCuotas.FechaVencimiento < @FECHA4
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo03 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA4 And
				genMovCuotas.FechaVencimiento < @FECHA5
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Periodo04 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA5
		 THEN
			(-comMovTipos.Signo*genMovCuotas.Saldo) ELSE 0 END as Posterior ,

		(-comMovTipos.Signo*genMovCuotas.Saldo) AS Saldo, 
		@Fecha as Fecha,
		@Fecha1 as Fecha1,@Fecha2 as Fecha2, @Fecha3 as Fecha3,
		@Fecha4 as Fecha4, @Fecha5 as Fecha5
	
FROM comMovProv inner join comProveedores ON
	comMovProv.Proveed_id = comProveedores.genEntidades
	INNER JOIN genProvincias ON 
	genProvincias.genProvincias = comProveedores.Provincia_Id
	INNER JOIN genPaises ON
	genPaises.genPaises = comProveedores.Pais
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = comMovProv.comMovProv
	inner join genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join genAsiSegmentos on 
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN comMovTipos ON
	comMovTipos.TipoMov = comMovprov.TipoMov
	INNER JOIN (select genMovCuotas.Asiento_Id, 
		genMovCuotas.FechaVencimiento,
		genMovCuotas.Saldo + 
			isnull((select sum(genCancMov.Importe) from genCancMov , conAsientos where
				genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
				genCancMov.Asiento_Id_ap = conAsientos.conAsientos and
				conAsientos.Anulado = 0 and 
				genCancMov.FechaAplicacion > @Fecha),0) +
	isnull((select sum(genCancMov.Importe) from genCancMov , conAsientos where
				genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
				genCancMov.Asiento_Id = conAsientos.conAsientos and
				conAsientos.Anulado = 0 and 
				genCancMov.FechaAplicacion > @Fecha),0)
				 as Saldo
	 from genMovCuotas) genMovCuotas ON
	genMovCuotas.Asiento_Id = comMovprov.comMovprov
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		commovprov.FacturaTesoreria = 0 and 
		conAsientos.Fecha <= @Fecha and 
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		genMovCuotas.Saldo <> 0 and 
		conAsientos.Empresa_Id = @Empresa) AS XXX
GROUP BY Proveed_Id, Moneda_Id, RazonSocial, Fecha, Fecha1, 
	Fecha2, Fecha3, Fecha4, Fecha5
ORDER BY 2,1
GO


	


	

