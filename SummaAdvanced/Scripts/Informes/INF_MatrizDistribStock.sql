-- INF_MatrizDistribStock 1 ,50,30, 15,4,1, 6, 3, '20180101','20180630'
drop PROCEDURE INF_MatrizDistribStock
GO
CREATE PROCEDURE INF_MatrizDistribStock
(
	@Empresa Int, 
	@T INT, 
	@A INT, 
	@B INT,
	@C INT,
	@D INT, 
	@MASDEX INT,
	@MENOSDX INT,
	@FechaDesde DateTime, 
	@FechaHasta DateTime
)
AS
SET NOCOUNT ON
DECLARE @Total INT 
DECLARE @Tn INT
DECLARE @An INT
DECLARE @Bn INT
DECLARE @Cn INT
DECLARE @Dn INT


select 	stkProductos.stkProductos,
	isnull((select COUNT(1) 
		from venMovimientos INNER JOIN  conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIn genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON
		venMovConStockCr.venMovimientos = venMovimientos.venMovimientos and
		venMovConStockCr.Producto_Id = stkProductos.stkProductos
		where
			conAsientos.Fecha between @FechaDesde And @FechaHasta and 
			conAsientos.Anulado = 0 and
			genAsiSegmentos.Empresa_Id = @Empresa),0) as Cantidad,
			SUM(ISNULL(stkExistencia.Cantidad ,0) * stkProductos.CostoUltCompra) Monto
			INTO #Temp1
		from stkProductos left join stkExistencia ON
		stkProductos.stkProductos = stkExistencia.Producto_Id
		Where
			stkProductos.Clase in ('E','-') AND 
			ISNULL(stkProductos.Empresa_Id, @Empresa)= @Empresa and 
			stkProductos.Inactivo = 0 and stkProductos.Posteado = 1
GROUP BY stkProductos.stkProductos


SET @Total = (SELECT COUNT(1) FROM #TEMP1)
SET @Tn= @Total * @T / 100
SET @An= @Total * (@T+@A) / 100
SET @Bn= @Total * (@T+@A+@B) / 100
SET @Cn= @Total * (@T+@A+@B+@C) / 100
SET @Dn= @Total * (@T+@A+@B+@C+@D) / 100

SELECT 	1 AS Orden,  'T' AS Tipo,
		ISNULL(SUM(CASE WHEN Cantidad >= @MASDEX then Monto else 0 end),0) as MasDe, 
		ISNULL(SUM(CASE WHEN Cantidad < @MASDEX and Cantidad >= @MENOSDX  then Monto else 0 end),0) as Entre, 
		ISNULL(SUM(CASE WHEN Cantidad < @MENOSDX  then Monto else 0 end),0) as MenosDe 
FROM (
select ROW_NUMBER() OVER( ORDER BY Monto desc ) as N,
	Cantidad,Monto
from #TEMP1) AS xxx
Where N <= @Tn
UNION ALL
SELECT 2 AS Orden,  'A' AS Tipo,
		ISNULL(SUM(CASE WHEN Cantidad >= @MASDEX then Monto else 0 end),0) as MasDe, 
		ISNULL(SUM(CASE WHEN Cantidad < @MASDEX and Cantidad >= @MENOSDX  then Monto else 0 end),0) as Entre, 
		ISNULL(SUM(CASE WHEN Cantidad < @MENOSDX  then Monto else 0 end),0) as MenosDe 
FROM (
select ROW_NUMBER() OVER( ORDER BY Monto desc ) as N,
	Cantidad,Monto
from #TEMP1) AS xxx
Where N BETWEEN @Tn+1 AND @An 

UNION ALL
SELECT 3 AS Orden, 'B' AS Tipo,
		ISNULL(SUM(CASE WHEN Cantidad >= @MASDEX then Monto else 0 end),0) as MasDe, 
		ISNULL(SUM(CASE WHEN Cantidad < @MASDEX and Cantidad >= @MENOSDX  then Monto else 0 end),0) as Entre, 
		ISNULL(SUM(CASE WHEN Cantidad < @MENOSDX then Monto else 0 end),0) as MenosDe 
FROM (
select ROW_NUMBER() OVER( ORDER BY Monto desc ) as N,
	Cantidad,Monto
from #TEMP1) AS xxx
Where N BETWEEN @An+1 AND @Bn 
UNION ALL
SELECT 4 AS Orden, 'C' AS Tipo,
		ISNULL(SUM(CASE WHEN Cantidad >= @MASDEX then Monto else 0 end),0) as MasDe, 
		ISNULL(SUM(CASE WHEN Cantidad < @MASDEX and Cantidad >= @MENOSDX  then Monto else 0 end),0) as Entre, 
		ISNULL(SUM(CASE WHEN Cantidad < @MENOSDX  then Monto else 0 end),0) as MenosDe 
FROM (
select ROW_NUMBER() OVER( ORDER BY Monto desc ) as N,
	Cantidad,Monto
from #TEMP1) AS xxx
Where N BETWEEN @Bn+1 AND @Cn 
UNION ALL
SELECT 4 AS Orden, 'D' AS Tipo,
		ISNULL(SUM(CASE WHEN Cantidad >= @MASDEX then Monto else 0 end),0) as MasDe, 
		ISNULL(SUM(CASE WHEN Cantidad < @MASDEX and Cantidad >= @MENOSDX  then Monto else 0 end),0) as Entre, 
		ISNULL(SUM(CASE WHEN Cantidad < @MENOSDX  then Monto else 0 end),0) as MenosDe 
FROM (
select ROW_NUMBER() OVER( ORDER BY Monto desc ) as N,
	Cantidad,Monto
from #TEMP1) AS xxx
Where N BETWEEN @Cn+1 AND @Dn 

order by 1


GO



