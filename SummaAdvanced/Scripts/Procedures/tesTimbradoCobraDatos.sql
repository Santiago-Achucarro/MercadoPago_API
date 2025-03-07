-- tesTimbradoCobraDatos 1, '20180101','20180630',' ','ZZZ'
DROP PROCEDURE tesTimbradoCobraDatos
GO
CREATE PROCEDURE tesTimbradoCobraDatos(
	@Empresa_Id INT, 
	@FechaDesde DateTime, 
	@FechaHata DateTime, 
	@ClienteDesde VarChar(15), 
	@ClienteHasta VarChar(15),
	@UnTimbrePorCob bit,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4)
	)

AS

SELECT @FechaDesde as FechaDesde, @FechaHata as FechaHasta, 
	@ClienteDesde as ClienteDesde, ' ' as DescripcionClienteDesde,
	@ClienteHasta as ClienteHasta, ' ' as DescripcionClienteHasta, 
	GETDATE() as Fecha, @UnTimbrePorCob as UnTimbrePorCob, @SucursalDesde SucursalDesde, @SucursalHasta SucursalHasta, '' RazonCancelacionSAT, 
		'' DescripcionCancelacionSAT


SELECT 	' ' Segmento_Id , ' ' Segmento1C, ' ' Segmento2C,  ' ' Segmento3C,  ' ' Segmento4C, 
		0 Segmento1N, 0 Segmento2N,  0 Segmento3N,  0 Segmento4N, ' ' Motivo, CAST(0 as bit) EnviaAlSat
		


SELECT distinct tesMovimientos.tesMovimientos, venClientes.Cliente_Id, 
	conAsientos.Fecha,
	genMonedas.Moneda_Id, dbo.Segmento( genAsiSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante, 
	CAST(1 as bit) as Marca, 
	venMovimientos.Importe as Monto
from tesMovimientos INNER JOIN conAsientos ON
	tesMovimientos.tesMovimientos = conAsientos.conAsientos
	inner join venMovimientos ON
	venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
	inner join venClientes ON
	venClientes.genEntidades = venMovimientos.Cliente_Id
	inner join genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN genAsiSegmentos on 
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id_Ap = tesMovimientos.tesMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos = genCancMov.Asiento_Id
	inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	(venMovimientosMetodoPago.NMetodoPago = 'PPD'  or venMovimientosMetodoPago.MetodoPago in ('99',' ')) and
	venClientes.Cliente_Id between @ClienteDesde And @ClienteHasta and 
	conAsientos.Fecha between @FechaDesde And @FechaHata and
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	not exists(select 1 from TesCFDICobranzaCuerpo inner join tesCFDICobranza ON 
	TesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza
	 Where
	 tesCFDICobranza.Anulada = ' ' AND 
	TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos)
	order by 2,3

SELECT 	' ' Segmento_Id , ' ' Segmento1C, ' ' Segmento2C,  ' ' Segmento3C,  ' ' Segmento4C, 
		0 Segmento1N, 0 Segmento2N,  0 Segmento3N,  0 Segmento4N 

SELECT 	' ' Segmento_Id , ' ' Segmento1C, ' ' Segmento2C,  ' ' Segmento3C,  ' ' Segmento4C, 
		0 Segmento1N, 0 Segmento2N,  0 Segmento3N,  0 Segmento4N, '' as SegmentoSTR
GO

	
DROP PROCEDURE tesCdfiCobranzaTieneRel
GO
CREATE PROCEDURE tesCdfiCobranzaTieneRel(
	@tesMovmientos Bigint
)
AS

SELECT tesCFDICobranzaCuerpo.tesCFDICobranza
FROM tesCFDICobranzaCuerpo inner join tesCFDICobranza ON
tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza
Where
tesCFDICobranzaCuerpo.tesMovimientos = @tesMovmientos AND 
tesCFDICobranza.Anulada <> ' '
ORDER BY  1 DESC
	
go