-- EXEC inf_venFacturaCanje '20210101','20220228',1
DROP procedure inf_venFacturaCanje
GO

create procedure inf_venFacturaCanje(
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Empresa_Id int
)
AS

SELECT vgenAsiSegmentos.Segmento, conAsientos.Fecha,
	venClientes.Cliente_Id, venClientes.RazonSocial,
	venMovimientos.Importe,
	venMovimientos.Importe -
	ISNULL((SELECT SUM(Importe) FROM venMovImpuestos 
	WHERE
		venMovImpuestos.venMovimientos = venMovimientos.venMovimientos),0) AS SubTotal,
	ISNULL((SELECT SUM(Importe) FROM venMovImpuestos 
	WHERE
		venMovImpuestos.venMovimientos = venMovimientos.venMovimientos),0) AS IVA,
	MIN(conAsientosn.fecha) as Desde,
	MAX(conAsientosn.fecha) as Hasta
from 
	conAsientos 
		INNER JOIN vgenAsiSegmentos ON conAsientos.conAsientos = vgenAsiSegmentos.Asiento_Id
	INNER JOIN venMovimientos ON  venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join venCanjeNotas ON  venCanjeNotas.venMovimientosFC = conAsientos.conAsientos
	INNER JOIN conAsientos  conAsientosN ON conAsientosN.conAsientos =venCanjeNotas.venMovimientos
	INNER JOIN venClientes ON  venClientes.genEntidades = venMovimientos.Cliente_Id
where
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id
group by vgenAsiSegmentos.Segmento, conAsientos.Fecha,
	venMovimientos.Importe, venMovimientos.venMovimientos,
	venClientes.Cliente_Id, venClientes.RazonSocial
ORDER BY 1