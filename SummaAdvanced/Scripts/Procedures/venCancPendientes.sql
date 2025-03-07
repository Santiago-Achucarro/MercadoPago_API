DROP PROCEDURE venCancPendientes
GO
CREATE PROCEDURE venCancPendientes(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa Int
	)
AS

SELECT @FechaDesde as FechaDesde , @FechaHasta as FechaHasta
	
SELECT venMovimientos.venMovimientos 
FROM venMovimientos INNER JOIN conAsientosAnul ON
venMovimientos.venMovimientos = conAsientosAnul.Asiento_Id
inner join conAsientos ON
conAsientos.conAsientos = venMovimientos.venMovimientos
Where
conAsientos.Empresa_Id = @Empresa AND 
conAsientosAnul.TipoEnvio != 'A' AND
conAsientosAnul.FechaAnulacion between @FechaDesde and @FechaHasta
ORDER BY 1
GO	


