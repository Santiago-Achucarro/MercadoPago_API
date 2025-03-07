--impPercRioNegro 1, '20230101','20230430'

DROP PROCEDURE impPercRioNegro
GO
CREATE PROCEDURE impPercRioNegro
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
AS

SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta


SELECT RIGHT(REPLICATE('0',5)+LTRIM(RTRIM(CONVERT(VARCHAR(5),CAST(ROW_NUMBER() OVER(ORDER BY venMovimientos.venMovimientos DESC) AS DECIMAL(5,0)),1))),5)+','+
	CASE WHEN venMovimientos.venTipoMov IN ('F','I') THEN CASE WHEN genAsisegmentos.Segmento3C = 'E' THEN '005' ELSE '001' END ELSE '' END +
	CASE WHEN venMovimientos.venTipoMov IN ('R','E') THEN CASE WHEN genAsisegmentos.Segmento3C = 'E' THEN '106' ELSE '102' END ELSE '' END +
	CASE WHEN venMovimientos.venTipoMov IN ('D','B') THEN CASE WHEN genAsisegmentos.Segmento3C = 'E' THEN '006' ELSE '002' END ELSE '' END +
	CASE WHEN venMovimientos.venTipoMov = 'X' THEN '120' ELSE '' END + CASE WHEN venMovimientos.venTipoMov = 'Y' THEN '020' ELSE '' END +
	--IIF(venMovimientos.venTipoMov = 'F' OR venMovimientos.venTipoMov = 'I', IIF(genAsisegmentos.Segmento3C = 'E','005','001'),'')+
	--IIF(venMovimientos.venTipoMov = 'R' OR venMovimientos.venTipoMov = 'E', IIF(genAsisegmentos.Segmento3C = 'E','106','102'),'')+
	--IIF(venMovimientos.venTipoMov = 'D' OR venMovimientos.venTipoMov = 'B', IIF(genAsisegmentos.Segmento3C = 'E','006','002'),'')+
	--IIF(venMovimientos.venTipoMov = 'X','120','')+IIF(venMovimientos.venTipoMov = 'Y','020','')+','+
	CASE WHEN genAsisegmentos.Segmento3C IN  ('A','B','C','E','M') THEN genAsisegmentos.Segmento3C ELSE 'Z' END +','+
	--IIF(genAsisegmentos.Segmento3C IN ('A','B','C','E','M'),genAsisegmentos.Segmento3C,'Z')+','+
	RIGHT('0000'+LTRIM(RTRIM(genAsiSegmentos.Segmento2C)),4)+RIGHT('00000000'+LTRIM(RTRIM(CONVERT(VARCHAR(8),genAsiSegmentos.Segmento1N))),8)+','+
	LTRIM(RTRIM(CAST(REPLACE(genEntidades.Cuit, '-', '') AS VARCHAR(11))))+','+
	CONVERT(CHAR(10),conAsientos.Fecha,103)+','+
	LTRIM(RTRIM(CONVERT(VARCHAR(12),CAST(ISNULL(venMovImpuestos.BaseImponibleMonedaNac*venTipoMov.Signo,0) AS DECIMAL(12,2)),1)))+','+
	LTRIM(RTRIM(CONVERT(VARCHAR(6),CAST(ISNULL(venMovImpuestos.Porcentaje,0) AS DECIMAL(6,2)),1)))+','+
	LTRIM(RTRIM(CONVERT(VARCHAR(12),CAST(ISNULL(conMovCont.Importe*venTipoMov.Signo,0) AS DECIMAL(12,2)),1)))+','+
	'010,916' Registro
FROM venMovImpuestos
	INNER JOIN venMovimientos ON venMovImpuestos.venMovimientos = venMovimientos.venMovimientos 
	INNER JOIN venTipoMov ON venMovimientos.venTipoMov = venTipoMov.venTipoMov
	INNER JOIN genEntidades ON venMovimientos.Cliente_Id = genEntidades.genEntidades
	INNER JOIN venImpuestos ON venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos
	INNER JOIN conMovCont ON venMovImpuestos.venMovimientos = conMovCont.conAsientos AND 
		venMovImpuestos.conRenglon = conMovCont.Renglon
	INNER JOIN conAsientos ON venMovImpuestos.venMovimientos = conAsientos.conAsientos 
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
WHERE conMovcont.Importe > 0 AND 
	venImpuestos.TipoImpuesto = 1916 AND conAsientos.Anulado = 0 AND 
	conAsientos.Fecha Between @pFechaDesde And @pFechaHasta and 
	conAsientos.Empresa_Id = @pEmpresa_Id
GO



