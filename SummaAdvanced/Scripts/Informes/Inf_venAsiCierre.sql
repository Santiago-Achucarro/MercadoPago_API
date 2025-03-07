--EXEC Inf_venAsiCierre '20220101','20220131',1,0

DROP PROCEDURE Inf_venAsiCierre
GO
CREATE PROCEDURE Inf_venAsiCierre(
@FechaDesde DateTime,
@FechaHasta DateTime,
@Empresa_Id Int,
@Detallado Bit
)
AS

SELECT venTipoMov.venTipoMov, conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
venTipoMov.Descripcion,   
vVenMovimientos.Segmento Comprobante, vVenMovimientos.Segmento+' '+CONVERT(CHAR(10),conAsientos.Fecha,103) Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC , '' as Cliente_id, conAsientos.conAsientos 
INTO ##_Final
FROM conAsientos 
INNER JOIN venMovimientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN vvenMovimientos ON venMovimientos.venMovimientos = vvenMovimientos.venMovimientos
INNER JOIN venTipoMov ON venMovimientos.venTipoMov = venTipoMov.venTipoMov
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @Empresa_Id AND conMovCont.Importe > 0
UNION ALL
SELECT '(' venTipoMov, conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber, 
'Dif. Cambio '+genMonedas.Descripcion,   
'' Comprobante, '' Leyenda,
conAsientos.Fecha, venAsiCierre.Fecha as FechaDC, venClientes.Cliente_Id, conAsientos.conAsientos 
FROM venAsiCierre
INNER JOIN venAsiCierreCr ON venAsiCierre.Asiento_Id = venAsiCierreCr.Asiento_Id
INNER JOIN conAsientos ON venAsiCierre.Asiento_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos AND
	venAsiCierreCr.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN genMonedas ON venAsiCierre.Moneda_Id = genMonedas.genMonedas
INNER JOIN venClientes ON venAsiCierreCr.Cliente_Id = venClientes.genEntidades
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @Empresa_Id
UNION ALL 
SELECT 'APL', conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
'Aplicaciones en Cta. Cte.',   
vVenMovimientos.Segmento Comprobante,'APL '+ vVenMovimientos.Segmento Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC , '' as Cliente_id, conAsientos.conAsientos 
FROM genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN venMovimientos ON genCancMov.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN vvenMovimientos ON venMovimientos.venMovimientos = vvenMovimientos.venMovimientos
INNER JOIN venTipoMov ON venMovimientos.venTipoMov = venTipoMov.venTipoMov
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE genCancMov.AsientoApli_Id IS NOT NULL AND
conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @Empresa_Id
ORDER BY 1,9,11, 12, 2, 3, 5, 6

DECLARE @TableTemp TABLE(venTipoMov VARCHAR(1), TipoMov SMALLINT, Cuenta_Id VARCHAR(25), DescCuenta VARCHAR(80), 
	Centro1_Id VARCHAR(8), Centro2_Id VARCHAR(8), Debe qMonedaD2, Haber qMonedaD2, Descripcion VARCHAR(80), Comprobante VARCHAR(120),
	Leyenda VARCHAR(220), Fecha qFecha, FechaDC qFecha, Cliente_Id VARCHAR(15))

DECLARE @pvenTipoMov VARCHAR(1), @pTipoMov SMALLINT, @pCuenta_Id VARCHAR(25), @pDescCuenta VARCHAR(80), 
	@pCentro1_Id VARCHAR(8), @pCentro2_Id VARCHAR(8), @pDebe qMonedaD2, @pHaber qMonedaD2, @pDescripcion VARCHAR(80), @pComprobante VARCHAR(120),
	@pLeyenda VARCHAR(220), @pFecha qFecha, @pFechaDC qFecha, @pCliente_Id VARCHAR(15)



IF (@Detallado = 0)
	BEGIN
		SELECT venTipoMov, TipoMov, Cuenta_id, DescCuenta, Centro1_id, Centro2_id, SUM(Debe) AS Debe, SUM(Haber) AS Haber,  
		Descripcion, Fecha,'' as Comprobante , ' ' as Leyenda , ''  as FechaDC , '' as Cliente_id
		INTO ##_Cursor
		FROM ##_Final
		GROUP BY venTipoMov, TipoMov, Cuenta_id, DescCuenta, Centro1_id, Centro2_id, Descripcion, Fecha
		ORDER BY venTipoMov, TipoMov, Cuenta_id, Centro1_id, Centro2_id

		DECLARE CursorFinal CURSOR FOR   
		SELECT venTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
			Leyenda, Fecha, FechaDC, Cliente_Id
		FROM ##_Cursor;  

		OPEN CursorFinal 

		FETCH NEXT FROM CursorFinal   
		INTO @pvenTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
			@pLeyenda, @pFecha, @pFechaDC, @pCliente_Id

		WHILE @@FETCH_STATUS = 0  
		BEGIN  
			INSERT INTO @TableTemp (venTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
				Leyenda, Fecha, FechaDC, Cliente_Id) 
			VALUES (@pvenTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pCliente_Id)

			FETCH NEXT FROM CursorFinal   
			INTO @pvenTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pCliente_Id
		END
		CLOSE CursorFinal
		DEALLOCATE CursorFinal 

		DROP TABLE ##_Cursor
	END
ELSE
	BEGIN
		DECLARE CursorFinal CURSOR FOR   
		SELECT venTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
			Leyenda, Fecha, FechaDC, Cliente_Id
		FROM ##_Final;  

		OPEN CursorFinal 

		FETCH NEXT FROM CursorFinal   
		INTO @pvenTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
			@pLeyenda, @pFecha, @pFechaDC, @pCliente_Id

		WHILE @@FETCH_STATUS = 0  
		BEGIN  
			INSERT INTO @TableTemp (venTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
				Leyenda, Fecha, FechaDC, Cliente_Id) 
			VALUES (@pvenTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pCliente_Id)

			FETCH NEXT FROM CursorFinal   
			INTO @pvenTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pCliente_Id
		END
		CLOSE CursorFinal
		DEALLOCATE CursorFinal 
	END
DROP TABLE ##_Final

SELECT * FROM @TableTemp
GO

DROP PROCEDURE Inf_venAsiCierreAux
Go
CREATE PROCEDURE Inf_venAsiCierreAux
AS
SELECT ' ' venTipoMov, 0 TipoMov, ' ' Cuenta_Id, ' ' DescCuenta, ' ' Centro1_Id, ' ' Centro2_Id, 0 Debe, 0 Haber,
	' ' Descripcion, ' ' Comprobante, ' ' Leyenda, GETDATE() Fecha, GETDATE() FechaDC, ' ' Cliente_Id
GO