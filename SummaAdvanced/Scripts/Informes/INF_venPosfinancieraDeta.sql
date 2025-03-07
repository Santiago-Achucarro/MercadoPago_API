-- INF_venPOSFINANCIERADETA ' ','zzzz', '20201105', 7, 1,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 'C' ,1
-- INF_venPOSFINANCIERADETA ' ','zzzz', '20180930', 7, 1,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 'V' ,1
-- INF_venPOSFINANCIERADETA ' ','zzzz', '20180930', 7, 1,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 'R' ,1
-- INF_venPOSFINANCIERADETA ' ','zzzz', '20180930', 7, 1,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 'Z' ,1
-- INF_venPOSFINANCIERADETA ' ','zzzz', '20180930', 7, 1,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 'T' ,1
-- INF_venPOSFINANCIERADETA ' ','zzzz', '20180930', 7, 1,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 'S' ,1

DROP PROCEDURE INF_venPOSFINANCIERADETA

GO
CREATE PROCEDURE INF_venPOSFINANCIERADETA(
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Fecha DateTime, 
	@Dias Int,
	@Columna int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@VendedorDesde varchar(5),
	@VendedorHasta varchar(5),
	@RegionDesde varchar(5),
	@RegionHasta varchar(5),
	@ZonaDesde varchar(5),
	@ZonaHasta varchar(5),
	@AgruparPor Char(1),
	@Empresa Int,
	@MonedaRegional bit
)

AS

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

SELECT genMonedas.genMonedas,
dbo.func_TipoCambio(genMonedas.genMonedas, DATEADD(dd,1,dbo.FechaActual()), @Empresa) as Cambio
INTO #CAMBIO
FROM genMonedas

-- @AgruparPor C Cliente - V Vendedror - Z Zona - R Region - T tipo de Cliente - S SucursalCliente
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


SELECT case @AgruparPor when 'C' Then  venClientes.Cliente_Id 
	when 'V' then venVendedores.Vendedor_Id
	when 'Z' Then venZona.Zona_Id
	when 'R' Then venRegion.Region_Id
	when 'T' Then venTiposClie.TipoClie_Id
	else venClientes.Cliente_Id +'-'+LTRIM(STR(venCliehabitual.Sucursal,8)) END AS Agrupador_Id,
	case @AgruparPor when 'C' Then  venClientes.RazonSocial
	when 'V' then venVendedores.Nombre
	when 'Z' Then venZona.Descripcion
	when 'R' Then venRegion.Descripcion
	when 'T' Then venTiposClie.Descripcion
	else venClieHabitual.NombreFantasia END AS Descripcion,
	venClientes.Cliente_Id, 	genMonedas.Moneda_Id,	conAsientos.Cambio, conAsientos.Fecha as FechaEmision, 
	genMovCuotas.FechaVencimiento, 
	venClientes.RazonSocial, 
		dbo.Segmento(genAsiSegmentos.Segmento_id, 
			genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
			genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
			genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
			genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento, 
		CASE WHEN genMovCuotas.FechaVencimiento < @FECHA1 THEN
			(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0))) 

			 ELSE 0 END * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end as Anterior ,
		CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA1 And
				genMovCuotas.FechaVencimiento < @FECHA2
		 THEN
			(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov, conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0)))  ELSE 0 END * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end as Periodo01 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA2 And
				genMovCuotas.FechaVencimiento < @FECHA3
		 THEN
			(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0)))  ELSE 0 END * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end as Periodo02 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA3 And
				genMovCuotas.FechaVencimiento < @FECHA4
		 THEN
			(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0)))  ELSE 0 END * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end as Periodo03 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA4 And
				genMovCuotas.FechaVencimiento < @FECHA5
		 THEN
			(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0)))  ELSE 0 END * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end as Periodo04 ,

	CASE WHEN genMovCuotas.FechaVencimiento >= @FECHA5
		 THEN
			(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0)))  ELSE 0 END * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end as Posterior ,

		(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0))) * case when @MonedaRegional=1 then #Cambio.Cambio else 1 end AS Saldo, 
		@Fecha as Fecha,
		@Fecha1 as Fecha1,@Fecha2 as Fecha2, @Fecha3 as Fecha3,
		@Fecha4 as Fecha4, @Fecha5 as Fecha5,
		venTiposClie.TipoClie_Id, venTiposClie.Descripcion as DescripcionTipoClie, 
		venVendedores.Vendedor_Id, venZona.Zona_Id, venZona.Descripcion as DescripcionZona,
		venRegion.Region_Id, venRegion.Descripcion as DescripcionRegionn
		
	
FROM venMovimientos inner join venClientes ON
	venMovimientos.Cliente_Id= venClientes.genEntidades
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join genAsiSegmentos on 
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN venSubTipoMov ON
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN genMovCuotas ON
	genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
	inner join genSucursalesEmpr ON 
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	inner join venVendedores on venVendedores.venVendedores=venMovimientos.Vendedor_Id
	inner join venClieHabitual on venClieHabitual.genEntidades=venMovimientos.Cliente_Id and 
	venClieHabitual.Sucursal=venMovimientos.Sucursal
	inner join venRegion on venClieHabitual.Region_Id=venRegion.venRegion
	inner join venZona on venZona.venZona=venClieHabitual.Zona_Id
	inner join venTiposClie on venTiposClie.venTiposClie=venClieHabitual.TipoClie_Id
	inner join #Cambio  on #Cambio.genmonedas=conAsientos.Moneda_Id
	WHERE
		genSucursalesEmpr.Sucursal Between @SucursalDesde and @SucursalHasta and 
		conAsientos.Anulado = 0 and 
		conAsientos.Fecha <= @Fecha and 
		venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
		venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
		venRegion.Region_Id between @RegionDesde and @RegionHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and
		(venTipoMov.Signo*(genMovCuotas.Saldo+ 
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0) +
			ISNULL((select sum(genCancMov.Importe) from genCancMov , conAsientos conAsientos1
					Where
						conAsientos1.conAsientos = genCancMov.Asiento_Id and
						conAsientos1.Anulado = 0 and 
						conAsientos1.Posteado = 1 and 
						genCancMov.Asiento_Id_ap = genMovCuotas.Asiento_Id and 
						genCancMov.CuotaNro = genMovCuotas.CuotaNro And
						genCancMov.FechaAplicacion > @Fecha),0)))  <> 0 and 
		conAsientos.Empresa_Id = @Empresa 

ORDER BY 1,7,9
OPTION (RECOMPILE)
GO


	

	