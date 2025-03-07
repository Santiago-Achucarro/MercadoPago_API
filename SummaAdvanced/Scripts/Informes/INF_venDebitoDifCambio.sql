--EXEC INF_venDebitoDifCambio  '20210101','20231231','00159','00159',1

DROP PROCEDURE INF_venDebitoDifCambio 
GO
CREATE PROCEDURE INF_venDebitoDifCambio (
	@FechaDesde DateTime, 
	@FechaHasta  DateTime, 
	@ClienteDesde VarChar(15), 
	@ClienteHasta VarChar(15), 
	@Cobranza bit
)
AS
SELECT vVenMovimientos.Segmento Comp_DC, conAsientosDC.Fecha FechaDC,
CASE WHEN conAsientos.Cambio > 1 THEN conAsientos.Cambio ELSE conAsientos.CambioMonedaOriginal END Cambio,
vgenCancMov.Segmento Comp, conAsientos.Fecha, vgenCancMov.SegmentoAp, conAsientosAP.Fecha FechaAP,
CASE WHEN conAsientosAP.Cambio > 1 THEN conAsientosAP.Cambio ELSE conAsientosAP.CambioMonedaOriginal END CambioAP,
dbo.Func_TipoCambio(2,getdate(),1) CambioDia, venClientes.Cliente_Id, venClientes.RazonSocial,
vgenCancMov.Importe_Ap,ISNULL((SELECT SUM(Importe) FROM conMovCont WHERE conAsientos = vgenCancMov.AsieDifCambio_Id
AND TipoMov = 1)*vVenMovimientos.Signo,0) Importe
FROM vgenCancMov
INNER JOIN vvenMovimientos ON vgenCancMov.AsieDifCambio_Id = vvenMovimientos.venMovimientos
INNER JOIN venClientes ON vVenMovimientos.Cliente_Id = venClientes.Cliente_Id
INNER JOIN conAsientos conAsientosDC ON vVenMovimientos.venMovimientos = conAsientosDC.conAsientos
INNER JOIN conAsientos conAsientos ON vgenCancMov.Asiento_Id = conAsientos.conAsientos
INNER JOIN conAsientos conAsientosAP ON vgenCancMov.Asiento_Id_Ap = conAsientosAP.conAsientos
WHERE conAsientosAP.Fecha BETWEEN @FechaDesde AND @FechaHasta AND
venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta
UNION ALL
SELECT '' Comp_DC, '' FechaDC, 1 Cambio,
vgenCancMov.Segmento Comp, conAsientos.Fecha, vgenCancMov.SegmentoAp, conAsientosAP.Fecha FechaAP,
CASE WHEN conAsientosAP.Cambio > 1 THEN conAsientosAP.Cambio ELSE conAsientosAP.CambioMonedaOriginal END CambioAP,
dbo.Func_TipoCambio(2,getdate(),1) CambioDia, venClientes.Cliente_Id, venClientes.RazonSocial,
vgenCancMov.Importe_Ap,ISNULL((SELECT SUM(Importe) FROM conMovCont WHERE conAsientos = vgenCancMov.AsieDifCambio_Id
AND TipoMov = 1),0) Importe
FROM vgenCancMov
INNER JOIN vvenMovimientos ON vgenCancMov.Asiento_Id = vvenMovimientos.venMovimientos
INNER JOIN venClientes ON vVenMovimientos.Cliente_Id = venClientes.Cliente_Id
--INNER JOIN conAsientos conAsientosDC ON vVenMovimientos.venMovimientos = conAsientosDC.conAsientos
INNER JOIN conAsientos conAsientos ON vgenCancMov.Asiento_Id = conAsientos.conAsientos
INNER JOIN conAsientos conAsientosAP ON vgenCancMov.Asiento_Id_Ap = conAsientosAP.conAsientos
INNER JOIN venMovimientos ON conAsientosAP.conAsientos = venMovimientos.venMovimientos
WHERE conAsientosAP.Fecha BETWEEN @FechaDesde AND @FechaHasta AND
venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND
vgenCancMov.AsieDifCambio_Id IS NULL AND
venMovimientos.venTipoMov = 'C' AND 
1 = @Cobranza 
ORDER BY conAsientosAP.Fecha
GO