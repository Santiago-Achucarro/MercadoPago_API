-- FM 25/08/2022 13057. Las primeras columnas son de cómo ingresó el cheque. Las otras del estado actual --
--Exec inf_tesCheqBusqueda '', 'zzzzz', '20220801', '20291231', '20220812', '20220812', 0, 999999999, '', 'zzzzzz', '', 'zzzzzzz', '', 'zzzzzzz', '', '', 'zzzzzz', '1', 0, 1

drop procedure inf_tesCheqBusqueda
go
create procedure inf_tesCheqBusqueda
(
@CarteraDesde varchar(5),
@CarteraHasta varchar(5),
@FechaDesde datetime,
@FechaHasta datetime,
@FechaDesde2 datetime,
@FechaHasta2 datetime,
@NumChequeDesde int,
@NumChequeHasta int,
@ClienteDesde VarChar(15),
@ClienteHasta VarChar(15),
@CobradorDesde VarChar(5),
@CobradorHasta VarChar(5),
@CuentaBancoDesde varchar(15),
@CuentaBancoHasta varchar(15),
@Proveed VarChar(15),
@BancoDesde VarChar(3),
@BancoHasta VarChar(3),
@Tipo VARCHAR(1),
@Rechazado SINO,
@Empresa_Id int
)
AS
SELECT DISTINCT tesCheqTerceros.numCheque, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion DescCartera,
	tesBancos.Banco_Id, tesBancos.Descripcion DescBanco, tesCheqTerceros.Clearing, 
	tesCheqTerceros.Estado_Id, tesCheqTerceros.FechaVencimiento, isNull(tesCheqTerceros.FechaAcreditacion, '') FechaAcreditacion,
	isNull(tesCheqTerceros.FechaConciliacion, '') FechaConciliacion, tesCheqTerceros.sucBanco, tesCheqTerceros.cuentaBanco, 
	tesCheqTerceros.ClearingDias, conMovCont.Importe, conAsientos.Fecha FechaIng, tesSubTiposMov.SubTipo_Id SubTipoIng, vtesMovimientos.Segmento ComprobanteIng,
	ISNULL(venCobradores.Cobrador_Id,'') Cobrador_id, ISNULL(venCobradores.Nombre,'') NombreCob,
	ISNULL(venClientes.Cliente_Id,'') Cliente_id, ISNULL(venClientes.RazonSocial,'') RazonSocial,
	isNull(tesSalida.Fecha, '') FechaUltMov, tesSalida.SubTipo_Id TipoMovUlt, tesSalida.Segmento ComprobUltMov,
	ISNULL(tesSalida.Proveed_Id,'') Proveed_id, ISNULL(tesSalida.RazonSocial,'') RazonProv
FROM tesCheqTerceros
	INNER JOIN tesCTlink ON tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros AND tesCTlink.Secuencia = 1
	INNER JOIN tesRengMovi ON tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos AND tesCTlink.conRenglon = tesRengMovi.conRenglon
	INNER JOIN conMovCont ON tesRengMovi.tesMovimientos = conMovCont.conAsientos AND tesRengMovi.conRenglon = conMovCont.Renglon
	INNER JOIN tesMovimientos ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesSubTiposMov ON tesMovimientos.SubTipo_Id = tesSubTiposMov.tesSubTiposMov
	INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos AND conAsientos.Empresa_Id= @Empresa_Id
	INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos
	INNER JOIN tesBancos ON tesCheqTerceros.Banco_Id = tesBancos.tesBancos
	INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN tesCheqTerceros T3 ON tesCheqTerceros.tesCheqTerceros = T3.tesCheqTerceros
	INNER JOIN (tesCTlink TCTL Inner Join conAsientos ca On ca.conAsientos = TCTL.tesMovimientos And ca.Anulado = 0 And ca.Posteado = 1 )  
				ON tesCheqTerceros.tesCheqTerceros = TCTL.tesCheqTerceros AND TCTL.Secuencia = T3.SecuenciaActual
	Left Join (venMovimientos Inner Join venCobradores On venCobradores.venCobradores = venMovimientos.Cobrador_Id) On venMovimientos.venMovimientos = tesCTlink.tesMovimientos
	Left Join venClientes On venClientes.genEntidades = tesCheqTerceros.Cliente_Id
	LEFT OUTER JOIN (Select ts.tesMovimientos, Fecha, SubTipo_Id, Segmento, comProveedores.Proveed_Id, comProveedores.RazonSocial 
					From vtesMovimientos ts
					Inner Join comMovprov On comMovProv.comMovProv = ts.tesMovimientos
					INNER JOIN comProveedores ON comMovprov.Proveed_Id = comProveedores.genEntidades
					Union All
					Select ts.tesMovimientos, Fecha, SubTipo_Id, Segmento, '' Proveed_Id, '' RazonSocial
					From vtesMovimientos ts
					Left Join comMovprov On comMovProv.comMovProv = ts.tesMovimientos
					Where comMovProv.comMovProv Is Null 
			) tesSalida ON tesSalida.tesMovimientos = TCTL.tesMovimientos And TCTL.Secuencia > 1
WHERE conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
	tesIdentifica.Cartera_id BETWEEN @CarteraDesde AND @CarteraHasta AND
	(
	(@Tipo = '1' AND tesCheqTerceros.numCheque BETWEEN @NumChequeDesde AND @NumChequeHasta AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '2' AND conAsientos.Fecha BETWEEN @FechaDesde2 AND @FechaHasta2 AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '3' AND conAsientos.Fecha BETWEEN @FechaDesde2 AND @FechaHasta2) OR
	(@Tipo = '4' AND venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '5' AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '6' AND tesCheqTerceros.CuentaBanco BETWEEN @CuentaBancoDesde AND @CuentaBancoHasta AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '7' AND tesSalida.Proveed_Id = @Proveed AND conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '8' AND tesBancos.Banco_Id BETWEEN @BancoDesde AND @BancoHasta AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta) OR
	(@Tipo = '9' AND venCobradores.Cobrador_Id BETWEEN @CobradorDesde AND @CobradorHasta AND tesCheqTerceros.FechaVencimiento BETWEEN @FechaDesde AND @FechaHasta)) AND
		(@Rechazado = 0 OR (@Rechazado = 1 AND tesCheqTerceros.Estado_Id IN ('R','D')))
	
ORDER BY tesIdentifica.Cartera_Id, tesCheqTerceros.numCheque, tesCheqTerceros.FechaVencimiento 
	