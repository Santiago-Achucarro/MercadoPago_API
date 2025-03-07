


-- INF_ControlEntrega  ' ','zzz','20100101','20200131','20100101','20200131','20100101','20200131','20100101','20200131',1
DROP PROCEDURE INF_ControlEntrega 
GO
CREATE PROCEDURE INF_ControlEntrega 
(
	@FormaEntregaDesde VarChar(5),
	@FormaEntregaHasta VarChar(5),
	@FechaFacturaDesde DateTime,
	@FechaFacturaHasta DateTime,
	@FechaAutorizaDesde DateTime,
	@FechaAutorizaHasta DateTime,
	@FechaPedidoDesde DateTime,
	@FechaPedidoHasta DateTime,
	@FechaConformeDesde DateTime,
	@FechaConformeHasta DateTime,
	@Empresa_Id INT 
)
as

SELECT venFormaEntrega.FormaEntrega_id,  venFormaEntrega.razonsocial AS FormaEnterega,  
	venMovConforma.FechaConforma, venMovConforma.FechaRegistro,  
		dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N ) AS Factura,
		conAsientos.Fecha, venClientes.Cliente_id,  venClieHabitual.NombreFantasia, 
		venClieHabitual.Localidad_Entr,  genProvincias.Provincia_Id Provincia_id_Entr, 
			venPedidos.Fecha FechaPedido,  venPedidos.FechaAutorizo FechaAutoriza,
 Datediff(d,Venpedidos.Fecha,Venpedidos.FechaAutorizo) as DPediAut, 
 Datediff(d,Venpedidos.FechaAutorizo,conAsientos.Fecha) as DAutFact,
 Datediff(d,conAsientos.Fecha, VenMovConforma.FechaConforma) as DFactEnt,
 Datediff(d,VenMovConforma.FechaConforma, VenMovConforma.FechaRegistro) as DEntRec,
 Datediff(d,VenPedidos.Fecha, VenMovConforma.FechaConforma) as DPediEnt,
 Datediff(d,Venpedidos.FechaAutorizo, VenMOvConforma.FechaConforma) as DAutEn
FROM venClientes 
INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venClientes.genEntidades
INNER JOIN venMovimientos ON venMovimientos.Cliente_Id = venClieHabitual.genEntidades and 
				venMovimientos.Sucursal = venClieHabitual.Sucursal

INNER JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venMovimientos.FormaEntrega_Id
INNER JOIN venMovConforma ON venMovConforma.venMovimientos = venMovimientos.venMovimientos
INNER JOIN (SELECT Distinct venMovimientos, venPedidos FROM  venMovConStockCrPed)  AS venMovConStockCrPed ON 
	venMovConStockCrPed.venMovimientos = venMovimientos.venMovimientos
INNER JOIN venPedidos ON  venPedidos.venPedidos = venMovConStockCrPed.venPedidos
INNER JOIN venPediSegmentos ON venPediSegmentos.venPedidos = venPedidos.venPedidos
INNER JOIN conAsientos ON conAsientos.conAsientos =venMovimientos.venMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Entr
WHERE  
	conAsientos.Empresa_Id = @Empresa_Id and 
	venFormaEntrega.FormaEntrega_Id Between @FormaEntregaDesde and 	@FormaEntregaHasta and
	conAsientos.Fecha between @FechaFacturaDesde and @FechaFacturaHasta and 
	venPedidos.FechaAutorizo Between @FechaAutorizaDesde and @FechaAutorizaHasta and
	venPedidos.Fecha Between @FechaPedidoDesde and @FechaPedidoHasta and
	venMovConforma.FechaConforma BETWEEN @FechaConformeDesde AND @FechaConformeHasta 
Order by 1,3

go