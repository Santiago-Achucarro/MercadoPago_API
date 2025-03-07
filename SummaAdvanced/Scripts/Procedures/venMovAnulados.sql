
DROP PROCEDURE venMovAnulados
GO
CREATE PROCEDURE venMovAnulados(
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Empresa_Id Int
	)
	as


Select @FechaDesde FechaDesde, 	@FechaHasta FechaHasta, 
	@ClienteDesde ClienteDesde, @ClienteHasta ClienteHasta, ' ' as PDF, ' '  NombreArchivo


SELECT venMovimientos.venMovimientos, 
	dbo.Segmento( genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Comprobante,
	conAsientos.Fecha as FechaEmision, conAsientosAnul.FechaAnulacion, 
	venclientes.Cliente_Id, venClientes.RazonSocial, genUsuarios.Usuario_Id , venMovimientosFiscal.Acuse, 
	case when conAsientos.Anulado = 1 then 'Anulado' else 'Solicitado' end as Estado, 
	venMovimientos.Importe as Monto
from venMovimientos 
INNER JOIN genAsiSegmentos on venMovimientos.venMovimientos = genAsiSegmentos.Asiento_Id
INNER JOIN venClientes ON  venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN conAsientos ON  conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN conAsientosAnul ON conAsientosAnul.Asiento_Id = conAsientos.conAsientos
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = conAsientosAnul.Usuario_Id
INNER JOIN venMovimientosFiscal ON venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
WHERE
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Posteado = 1 and 
	(conAsientos.Anulado= 1 or venMovimientosFiscal.Acuse is not null) and 
	conAsientosAnul.FechaAnulacion  BETWEEN @FechaDesde and @FechaHasta and 
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta
ORDER BY 2

