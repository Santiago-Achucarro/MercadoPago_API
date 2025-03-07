-- venConsEdoCtaClientes '00123',2, '20200101','20200822', 'PES', 1,0
-- venConsEdoCtaClientes 'Q001',2, '20170801','20171222', null, 1
 -- venConsEdoCtaClientes 'Q001',2, '20170801','20171222', 'DOL', 1


DROP PROCEDURE venConsEdoCtaClientes
GO
CREATE PROCEDURE venConsEdoCtaClientes(
@Cliente_Id VarChar(15), 
@PendHist INT, 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@Moneda_Id VarChar(5)=NULL, 
@Empresa Int,
@pConsolidados bit,
@TodasLasSucursales bit,
@Sucursal Int
)

AS
select @Cliente_Id as Cliente_Id,@PendHist as PendHist,
@FechaDesde as FechaDesde, @FechaHasta as FechaHasta,
@Moneda_Id as Moneda_Id, @Empresa as Empresa,
 ISNULL(venClientes.RazonSocial, ' ') as RazonSocial, 
 ISNULL(genMonedas.Descripcion,' ') as DescripcionMoneda, dbo.FechaActual() as FechaAplicacion
 , @pConsolidados as Consolidados,
venClientes.Cliente_Id, venClientes.RazonSocial, venClientes.Posteado, venClieHabitual.Direccion1_Entr as DireccionEntrega,
venClieHabitual.Direccion1_Fact as DireccionFacturacion, venClieHabitual.Telefonos, venClieHabitual.EMail,
genEntidades.Cuit, venClieHabitual.Fax, venCobradores.Cobrador_Id as CobradorAsignado, venVendedores.Vendedor_Id as VendedorAsignado,
venZona.Zona_Id, venTiposClie.TipoClie_Id, venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListaPrecios,
venClieHabitual.FechaAlta, venClieHabitual.Contactos, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescrioncionCondPago,
venClieHabitual.Bonificacion1, venClieHabitual.Bonificacion2, venClieHabitual.Bonificacion3, venClieHabitual.Observaciones,
venClientes.LimiteCredito, 0.0 as MontoRemitos, 0.0 as Disponible, @TodasLasSucursales TodasLasSucursales, @Sucursal Sucursal
FROM venClientes 
LEFT OUTER JOIN genMonedas ON genMonedas.Moneda_id = @Moneda_Id
left join venClieHabitual on venClieHabitual.genEntidades=venClientes.genEntidades and 
	venClieHabitual.Sucursal=venClientes.SucursalPredeter
inner join genEntidades on genEntidades.genEntidades=venClientes.genEntidades
left join venCobradores on venCobradores.venCobradores=venClieHabitual.Cobrador_Id
left join venVendedores on venVendedores.venVendedores=venClieHabitual.Vendedor_Id
left join venZona on venZona.venZona=venClieHabitual.Zona_Id
left join venTiposClie on venTiposClie.venTiposClie=venClieHabitual.TipoClie_Id
left join venListasPrecios on venListasPrecios.venListasPrecios=venClieHabitual.ListaPrecio_Id
left join venCondPago on venCondPago.venCondPago=venClieHabitual.CondPagoCli_Id
WHERE
	Cliente_Id = @Cliente_Id
	

-- si no traigo los consolidados
if @pConsolidados=0
begin
SELECT venMovimientos.venMovimientos, venMovimientos.Sucursal,
	venTipoMov.TipoMovResumido, venTipoMov.Descripcion Tipomovs, 
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipo,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
	conAsientos.Fecha, case when venTipoMov.Signo=1  then 
		CASE WHEN @PendHist=1 THEN  genMovCuotas.Importe ELSE genMovCuotas.Importe END else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Debe,
	case when venTipoMov.Signo=-1  then 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Importe ELSE genMovCuotas.Importe END  else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Haber, 
	genMovCuotas.Saldo * venTipoMov.Signo * case When @Moneda_Id IS NULL 
		THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Saldo, 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Saldo else genMovCuotas.Importe end * venTipoMov.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as SaldoAcum, 
	genMovCuotas.CuotaNro,
	genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio, 
	genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro, 
	ISNULL(venMovimientosMetodoPago.NMetodoPago,' ') as MetodoPago,
	ISNULL(venMovimientosMetodoPago.MetodoPago,' ') as FormaPago,
	ISNULL(venMovimientosMetodoPago.UsoCfdi,' ') as UsoCfdi,
	venMovConforma.FechaConforma, conAsientos.Observaciones, genMovCuotas.Importe as MontoOriginal, 
	isnull(	dbo.Segmento(stkHojaSegmentos.Segmento_Id, 
	stkHojaSegmentos.Segmento1C,stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C,
	stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N,
	stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N),' ') HojaDeRuta 
FROM venMovimientos 
INNER JOIN venClientes ON venMovimientos.Cliente_Id= venClientes.genEntidades
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =venMovimientos.venMovimientos
INNER JOIN genMonedas ON genMonedas.genMonedas = 
	case when @Moneda_Id IS NULL THEN genEmpresas.Moneda_Id ELSE conAsientos.Moneda_Id END
inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
left join venMovimientosMetodoPago ON
venMovimientosMetodoPago.venMovimientos = venMovimientos.venMovimientos
left join venMovConforma on venMovConforma.venMovimientos=venMovimientos.venMovimientos
left join (stkHojaDeRutaCuerpo inner join stkHojaSegmentos ON 
	stkHojaDeRutaCuerpo.stkHojaDeRuta  = stkHojaSegmentos.stkHojaDeRuta) ON 
		stkHojaDeRutaCuerpo.conAsientos = venMovimientos.venMovimientos


WHERE
	conAsientos.Empresa_Id =@Empresa and conAsientos.Anulado = 0 And
	conAsientos.Posteado = 1 and 
	venClientes.Cliente_Id=@Cliente_Id and (@TodasLasSucursales = 1 Or venMovimientos.Sucursal = @Sucursal) And
	((genMovCuotas.Saldo > 0  and @PendHist = 1) or (
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
				@PendHist = 2)) and 
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
UNION ALL 
SELECT  -genMonedas.genMonedas as venMovimientos, 0 Sucursal,  ' ' TipoMov, 'Saldo Inicial' as Tipomovs, 
	' ' SubTipoMov_Id, 'Saldo Inicial' as DescripcionSubTipo,
	' ' Segmento, 
	DATEADD(dd,-1,@FechaDesde) as Fecha, 
	case when  
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) > 0
	 then 
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) ELSE 0 END as Debe,
	case when  
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) < 0
	 then 
		-SUM(genMovCuotas.Importe *venTipoMov.Signo) ELSE 0  END as Haber,
	SUM(genMovCuotas.Saldo *venTipoMov.Signo ) as Saldo, 
	SUM(genMovCuotas.Importe *venTipoMov.Signo ) as SaldoAcum, 
	0 CuotaNro,
	DATEADD(dd,-1,@FechaDesde) as FechaVenc,  genMonedas.Moneda_Id, 1 Cambio, 
	' ' Apellido_y_Nombres,DATEADD(dd,-1,@FechaDesde) , 
	' ',' ',' ', null, '' as Observaciones, 0 as MontoOriginal, ' ' HojaDeRuta 
FROM venMovimientos 
INNER JOIN venclientes ON venMovimientos.Cliente_Id= venClientes.genEntidades
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =venMovimientos.venMovimientos
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = case when @Moneda_Id IS NULL THEN genEmpresas.Moneda_Id ELSE conAsientos.Moneda_Id END
inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
WHERE
	conAsientos.Empresa_Id =@Empresa and conAsientos.Anulado = 0 And
	conAsientos.Posteado = 1 and 
	venClientes.Cliente_Id =@Cliente_Id and (@TodasLasSucursales = 1 Or venMovimientos.Sucursal = @Sucursal) And
	conAsientos.Fecha < @FechaDesde and
	@PendHist = 2 and
	genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
GROUP BY genMonedas.Moneda_Id, genMonedas.genMonedas
HAVING SUM(genMovCuotas.Importe *venTipoMov.Signo ) <> 0
ORDER BY 8, 18
end
--si traigo los consolidados

else
begin
SELECT venMovimientos.venMovimientos, venMovimientos.Sucursal,
	venTipoMov.TipoMovResumido, venTipoMov.Descripcion Tipomovs, 
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipo,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
	conAsientos.Fecha, case when venTipoMov.Signo=1  then 
		CASE WHEN @PendHist=1 THEN  genMovCuotas.Importe ELSE genMovCuotas.Importe END else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Debe,
	case when venTipoMov.Signo=-1  then 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Importe ELSE genMovCuotas.Importe END  else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Haber, 
	genMovCuotas.Saldo * venTipoMov.Signo * case When @Moneda_Id IS NULL 
		THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Saldo, 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Saldo else genMovCuotas.Importe end * venTipoMov.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as SaldoAcum, 
	genMovCuotas.CuotaNro,
	genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio, 
	genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro, 
	ISNULL(venMovimientosMetodoPago.NMetodoPago,' ') as MetodoPago,
	ISNULL(venMovimientosMetodoPago.MetodoPago,' ') as FormaPago,
	ISNULL(venMovimientosMetodoPago.UsoCfdi,' ') as UsoCfdi,
	venMovConforma.FechaConforma, conAsientos.Observaciones,' ' Pedido, genMovCuotas.Importe as MontoOriginal, 
	isnull(	dbo.Segmento(stkHojaSegmentos.Segmento_Id, 
	stkHojaSegmentos.Segmento1C,stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C,
	stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N,
	stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N),' ') HojaDeRuta 
FROM venMovimientos 
inner join vvenClientesCons on vvenClientesCons.Padre=venMovimientos.Cliente_Id
INNER JOIN venClientes ON venClientes.genEntidades=vvenClientesCons.Hijo
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =venMovimientos.venMovimientos
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = case when @Moneda_Id IS NULL THEN genEmpresas.Moneda_Id ELSE conAsientos.Moneda_Id END
inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
left join venMovimientosMetodoPago ON
venMovimientosMetodoPago.venMovimientos = venMovimientos.venMovimientos
left join venMovConforma on venMovConforma.venMovimientos=venMovimientos.venMovimientos
left join (stkHojaDeRutaCuerpo inner join stkHojaSegmentos ON 
	stkHojaDeRutaCuerpo.stkHojaDeRuta  = stkHojaSegmentos.stkHojaDeRuta) ON 
		stkHojaDeRutaCuerpo.conAsientos = venMovimientos.venMovimientos
WHERE
	conAsientos.Empresa_Id =@Empresa and conAsientos.Anulado = 0 And
	conAsientos.Posteado = 1 and 
	venClientes.Cliente_Id=@Cliente_Id and (@TodasLasSucursales = 1 Or venMovimientos.Sucursal = @Sucursal) And
	((genMovCuotas.Saldo > 0  and @PendHist = 1) or (
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
				@PendHist = 2)) and 
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
UNION ALL 
SELECT  -genMonedas.genMonedas as venMovimientos, 0 Sucursal,  ' ' TipoMov, 'Saldo Inicial' as Tipomovs, 
	' ' SubTipoMov_Id, 'Saldo Inicial' as DescripcionSubTipo,
	' ' Segmento, 
	DATEADD(dd,-1,@FechaDesde) as Fecha, 
	case when  
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) > 0
	 then 
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) ELSE 0 END as Debe,
	case when  
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) < 0
	 then 
		-SUM(genMovCuotas.Importe *venTipoMov.Signo) ELSE 0  END as Haber,
	SUM(genMovCuotas.Saldo *venTipoMov.Signo ) as Saldo, 
	SUM(genMovCuotas.Importe *venTipoMov.Signo ) as SaldoAcum, 
	0 CuotaNro,
	DATEADD(dd,-1,@FechaDesde) as FechaVenc,  genMonedas.Moneda_Id, 1 Cambio, 
	' ' Apellido_y_Nombres,DATEADD(dd,-1,@FechaDesde) , 
	' ',' ',' ', null, '' as Observaciones,' ' Pedido, 0 as MontoOriginal, ' ' as HojaDeRuta
FROM venMovimientos 
INNER JOIN vvenClientesCons ON venMovimientos.Cliente_Id= vvenClientesCons.Padre
inner join venClientes on venClientes.genEntidades=vvenClientesCons.Hijo
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =venMovimientos.venMovimientos
INNER JOIN genMonedas ON genMonedas.genMonedas = case when @Moneda_Id IS NULL THEN genEmpresas.Moneda_Id ELSE conAsientos.Moneda_Id END
inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
WHERE
	conAsientos.Empresa_Id =@Empresa and conAsientos.Anulado = 0 And
	conAsientos.Posteado = 1 and 
	venClientes.Cliente_Id =@Cliente_Id and (@TodasLasSucursales = 1 Or venMovimientos.Sucursal = @Sucursal) And
	conAsientos.Fecha < @FechaDesde and
	@PendHist = 2 and
	genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
GROUP BY genMonedas.Moneda_Id, genMonedas.genMonedas
HAVING SUM(genMovCuotas.Importe *venTipoMov.Signo ) <> 0
ORDER BY 8, 18
end
--inventario
Select ' ' as Deposito_Id, ' ' as Producto_Id, ' ' as Descripcion, ' ' Medida_Id, 0.00 as Cantidad, 0.00 as Costo, 0.00 as Total, '' As Pedido, '' As Reparto, '' Remito, 0.00 as Descuento

--asiento contable
select ' ' as Cuenta_Id, ' ' as Descripcion, ' ' as Centro1_Id, ' ' as Centro2_Id, 0.00 as Debe, 0.00 as Haber, ' ' LeyendaLibroMayor

--aplicaciones
select ' ' as Segmento, convert(datetime,null) as Fecha, 0.00 as Importe, ' ' as Usuario, cast(0 as bit) as Seleccionar, cast (0 as bigint) as ven_Movimientos, cast(0 as smallint) as NroCuota, 0 as NroAplicacion, 
cast (0 as bigint) AsientoApli_Id, cast (0 as bigint) AsientoDC_Id

	



--impuestos
select ' ' as Impuesto_Id, ' ' as Descripcion, 0.00 as Base, 0.00 as Porcentaje, 0.00 as Importe

--orden de compra
select ' ' as Segmento, convert(datetime,null) as Fecha

--valores
select ' ' as Cartera, ' ' as Descripcion, 0.00 as Importe, ' ' as NumeroDoc, convert(datetime, null) as FechaDoc, ' ' Banco, ' ' DescripcionBanco,
' ' Clearing, 0.00 ImporteOrig

--Aplicacar
select cast(0 as bigint) as venMovimientos, ' ' as Segmento, convert(datetime,null) as Fecha, 0.00 as Importe, 0.00 as Saldo, cast(0 as smallint) as NroCuota, 0.00 as ImporteAplicado, convert(datetime, null) as FechaVencimiento
--CancMov
select cast(0 as bigint) as Asiento_Id, cast(0 as smallint) as Cuota_Nro, 0.00 as Importe, 0.00 as Signo

-- DatosCliente

-- Remisiones Pendientes de Factura

SELECT conAsientos.Fecha, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
	SUM(stkMoviCuerpo.Cantidad*stkMoviCuerpo.PrecioOriginal) as Monto, 
	isnull(	dbo.Segmento(stkHojaSegmentos.Segmento_Id, 
	stkHojaSegmentos.Segmento1C,stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C,
	stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N,
	stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N),' ') HojaDeRuta 
FROM conAsientos 
INNER JOIN genAsiSegmentos ON conAsientos.conAsientos	= genAsiSegmentos.Asiento_Id
INNER JOIN stkRemiPendFact ON stkRemiPendFact.stkMoviCabe = conAsientos.conAsientos
INNER JOIN stkRemitos ON  stkRemitos.stkMoviCabe =conAsientos.conAsientos
INNER JOIN venClientes ON  venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkRemiPendFact.stkMoviCabe AND 
							stkMoviCuerpo.Renglon = stkRemiPendFact.Renglon
	left join stkHojaSegmentos ON 
		stkHojaSegmentos.stkHojaDeRuta = stkRemitos.HojaRuta_Id
where
	conAsientos.Anulado= 0 and 
	conAsientos.Posteado = 1 AND 
	venClientes.Cliente_Id = @Cliente_Id AND (@TodasLasSucursales = 1 Or stkRemitos.Sucursal = @Sucursal) And
	conAsientos.Empresa_Id = @Empresa and 
	stkRemiPendFact.CantidadPendiente >  0 
GROUP BY conAsientos.Fecha, 
	genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	stkHojaSegmentos.Segmento_Id, 
	stkHojaSegmentos.Segmento1C,stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C,
	stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N,
	stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N

GO
