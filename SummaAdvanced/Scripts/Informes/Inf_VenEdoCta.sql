-- Exec Inf_VenEdoCta '142','142', 0, '20200101', '20240531', 1, '', 'ZZZZ', 'PES',1,5
DROP PROCEDURE Inf_VenEdoCta
GO
CREATE PROCEDURE Inf_VenEdoCta(
@ClienteDesde VarChar(15), 
@ClienteHasta VarChar(15), 
@Pendiente bit, 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@Empresa Int,
@VendedorDesde VarChar(5), 
@VendedorHasta VarChar(5), 
@Moneda_Id VarChar(5)=NULL,
@TodasLasSucursales bit,  
@Sucursal Int 
)
AS

if @Moneda_Id = ''
	set @Moneda_Id = NULL

SELECT venVendedores.Vendedor_Id, venVendedores.Nombre, venClientes.Cliente_Id, venClientes.RazonSocial, 
	venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, conAsientos.Fecha,
	venClieHabitual.Telefonos, venClieHabitual.EMail, venClieHabitual.Contactos,
	venClieHabitual.Direccion1_Fact, venClieHabitual.CodPostal_Fact, venClieHabitual.Localidad_Fact,
	genProvincias.Descripcion Provincia , genPaises.Descripcion Pais, venCondPago.Descripcion CondPago,
	venMovimientos.venMovimientos, venTipoMov.TipoMovResumido, venTipoMov.Descripcion  Tipomovs, 
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipo,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
	 case when venTipoMov.Signo=1  then 
		--CASE WHEN @Pendiente=1 THEN  genMovCuotas.Saldo ELSE genMovCuotas.Importe END 
		genMovCuotas.Importe else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Debe,
	case when venTipoMov.Signo=-1  then 
		--CASE WHEN @Pendiente=1 THEN  genMovCuotas.Saldo ELSE genMovCuotas.Importe END  
		genMovCuotas.Importe else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Haber, 
	CASE WHEN @Pendiente=1 THEN  genMovCuotas.Saldo else genMovCuotas.Importe end * venTipoMov.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Saldo, 
	CASE WHEN @Pendiente=1 THEN  genMovCuotas.Saldo else genMovCuotas.Importe end * venTipoMov.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as SaldoAcum, 
	genMovCuotas.CuotaNro, genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio, 
	genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro,
	(SELECT SUM(A.Saldo*D.Signo* CASE WHEN @Moneda_Id IS NULL 
	THEN dbo.func_TipoCambio(F.Moneda_id, GETDATE(), @Empresa) ELSE 1 END) SaldoV 
	FROM genMovCuotas A 
	INNER JOIN venMovimientos B ON A.Asiento_Id = B.venMovimientos
	INNER JOIN conAsientos F ON F.conAsientos = A.Asiento_Id
	INNER JOIN venSubTipoMov C ON C.venSubTipoMov = B.venSubTipoMov_Id
	INNER JOIN venTipoMov D ON D.venTipoMov = C.venTipoMov
	inner join genMonedas G ON G.genMonedas = f.Moneda_Id
	WHERE 
	G.Moneda_Id = ISNULL(@Moneda_Id, G.Moneda_ID) AND
	f.anulado = 0 and 
	f.posteado = 1 and 
	B.Cliente_Id = venMovimientos.Cliente_Id AND
	A.FechaVencimiento < GETDATE()) SaldoV,
	(SELECT SUM(A.Saldo*D.Signo* CASE WHEN @Moneda_Id IS NULL 
	THEN dbo.func_TipoCambio(F.Moneda_id, GETDATE(), @Empresa) ELSE 1 END) SaldoV 
	FROM genMovCuotas A 
	INNER JOIN venMovimientos B ON A.Asiento_Id = B.venMovimientos
	INNER JOIN conAsientos F ON F.conAsientos = A.Asiento_Id
	INNER JOIN venSubTipoMov C ON C.venSubTipoMov = B.venSubTipoMov_Id
	INNER JOIN venTipoMov D ON D.venTipoMov = C.venTipoMov
	WHERE 
	f.anulado = 0 and 
	f.posteado = 1 and 
	B.Cliente_Id = venMovimientos.Cliente_Id AND
	A.FechaVencimiento >= GETDATE()) SaldoA
FROM venMovimientos 
INNER JOIN venClientes ON venMovimientos.Cliente_Id= venClientes.genEntidades
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =venMovimientos.venMovimientos
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
	venClieHabitual.Sucursal = venMovimientos.Sucursal --venClientes.SucursalPredeter
inner join venVendedores ON venVendedores.venVendedores = venClieHabitual.Vendedor_Id
INNER JOIN genProvincias ON venClieHabitual.Provincia_Id_Fact = genProvincias.genProvincias
INNER JOIN genPaises ON venClieHabitual.Pais_Id_Fact = genPaises.genPaises
INNER JOIN venCondPago ON venCondPago.venCondPago = venClieHabitual.CondPagoCli_Id
WHERE
	conAsientos.Empresa_Id =@Empresa and conAsientos.Anulado = 0 And
	conAsientos.Posteado = 1 and 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
	(@TodasLasSucursales = 1 Or venMovimientos.Sucursal = @Sucursal) And
	venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta And
	((genMovCuotas.Saldo > 0  and @Pendiente = 1) or (
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
				@Pendiente = 0)) and 
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
UNION ALL 
SELECT venVendedores.Vendedor_Id, venVendedores.Nombre, venClientes.Cliente_Id, venClientes.RazonSocial, 
	venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, DATEADD(dd,-1,@FechaDesde) as Fecha, 
		venClieHabitual.Telefonos, venClieHabitual.EMail, venClieHabitual.Contactos,
		venClieHabitual.Direccion1_Fact, venClieHabitual.CodPostal_Fact, venClieHabitual.Localidad_Fact,
		genProvincias.Descripcion Provincia , genPaises.Descripcion Pais, venCondPago.Descripcion CondPago,
		0 as venMovimientos,  ' ' TipoMov, 'Saldo Inicial' as Tipomovs, 
		' ' SubTipoMov_Id, 'Saldo Inicial' as DescripcionSubTipo,
		'Saldo Inicial' Segmento, 
	
	case when  
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) > 0
	 then 
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) ELSE 0 END as Debe,
	case when  
		SUM(genMovCuotas.Importe *venTipoMov.Signo ) < 0
	 then 
		-SUM(genMovCuotas.Importe *venTipoMov.Signo) ELSE 0  END as Haber,
	SUM(genMovCuotas.Importe *venTipoMov.Signo ) as Saldo, 
	SUM(genMovCuotas.Importe *venTipoMov.Signo ) as SaldoAcum, 
	0 CuotaNro,
	DATEADD(dd,-1,@FechaDesde) as FechaVenc,  genMonedas.Moneda_Id, 1 Cambio, 
	' ' Apellido_y_Nombres,DATEADD(dd,-1,@FechaDesde),
	(SELECT SUM(A.Saldo*D.Signo* CASE WHEN @Moneda_Id IS NULL 
	THEN dbo.func_TipoCambio(F.Moneda_id, GETDATE(), @Empresa) ELSE 1 END) SaldoV 
	FROM genMovCuotas A 
	INNER JOIN venMovimientos B ON A.Asiento_Id = B.venMovimientos
	INNER JOIN conAsientos F ON F.conAsientos = A.Asiento_Id
	INNER JOIN venSubTipoMov C ON C.venSubTipoMov = B.venSubTipoMov_Id
	INNER JOIN venTipoMov D ON D.venTipoMov = C.venTipoMov
	WHERE 
	f.anulado = 0 and 
	f.posteado = 1 and 
	B.Cliente_Id = venMovimientos.Cliente_Id AND
	A.FechaVencimiento < GETDATE()) SaldoV,
	(SELECT SUM(A.Saldo*D.Signo* CASE WHEN @Moneda_Id IS NULL 
	THEN dbo.func_TipoCambio(F.Moneda_id, GETDATE(), @Empresa) ELSE 1 END) SaldoV 
	FROM genMovCuotas A 
	INNER JOIN venMovimientos B ON A.Asiento_Id = B.venMovimientos
	INNER JOIN conAsientos F ON F.conAsientos = A.Asiento_Id
	INNER JOIN venSubTipoMov C ON C.venSubTipoMov = B.venSubTipoMov_Id
	INNER JOIN venTipoMov D ON D.venTipoMov = C.venTipoMov
	WHERE 
	f.anulado = 0 and 
	f.posteado = 1 and 
	B.Cliente_Id = venMovimientos.Cliente_Id AND
	A.FechaVencimiento >= GETDATE()) SaldoA

FROM venMovimientos 
INNER JOIN venclientes ON venMovimientos.Cliente_Id= venClientes.genEntidades
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =venMovimientos.venMovimientos
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
	venClieHabitual.Sucursal = venClientes.SucursalPredeter
inner join venVendedores ON venVendedores.venVendedores = venClieHabitual.Vendedor_Id
INNER JOIN genProvincias ON venClieHabitual.Provincia_Id_Fact = genProvincias.genProvincias
INNER JOIN genPaises ON venClieHabitual.Pais_Id_Fact = genPaises.genPaises
INNER JOIN venCondPago ON venCondPago.venCondPago = venClieHabitual.CondPagoCli_Id
WHERE
	conAsientos.Empresa_Id =@Empresa and conAsientos.Anulado = 0 And
	conAsientos.Posteado = 1 and 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and
	(@TodasLasSucursales = 1 Or venMovimientos.Sucursal = @Sucursal) And
	venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta And
	conAsientos.Fecha < @FechaDesde and
	@Pendiente = 0 and
	genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
GROUP BY genMonedas.Moneda_Id,  venVendedores.Vendedor_Id, venVendedores.Nombre, 
	venClientes.Cliente_Id, venClientes.RazonSocial, venClieHabitual.Sucursal, venClieHabitual.NombreFantasia,
		venClieHabitual.Telefonos, venClieHabitual.EMail, 
		venClieHabitual.Contactos,
		venClieHabitual.Direccion1_Fact, venClieHabitual.CodPostal_Fact, venClieHabitual.Localidad_Fact,
		genProvincias.Descripcion, genPaises.Descripcion, venCondPago.Descripcion, venMovimientos.Cliente_Id
Having SUM(genMovCuotas.Importe *venTipoMov.Signo ) <> 0
ORDER BY 1,3, 7, 16

