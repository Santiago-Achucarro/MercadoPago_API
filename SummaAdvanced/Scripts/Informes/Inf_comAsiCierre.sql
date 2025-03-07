--EXEC Inf_comAsiCierre '20220101','20220630',1,0

DROP PROCEDURE Inf_comAsiCierre
GO
CREATE PROCEDURE Inf_comAsiCierre(
@FechaDesde DateTime,
@FechaHasta DateTime,
@Empresa_Id Int,
@Detallado Bit
)
AS
SELECT comMovProv.TipoMov comTipoMov, conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
comProveedores.Proveed_Id, vcomMovProv.Comprobante, 
comMovTipos.Descripcion+ 'Cta. Cte. '+CONVERT(CHAR(10),@FechaDesde,103)+' al '+CONVERT(CHAR(10),@FechaHasta,103) Descripcion,
comProveedores.Proveed_Id+' '+vcomMovProv.Comprobante Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC, conAsientos.conAsientos  
INTO ##_Final
FROM comMovProv 
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN vComMovprov ON comMovProv.comMovProv = vcomMovProv.comMovProv
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov	
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
comMovProv.FacturaTesoreria = 0 AND
conAsientos.Empresa_Id = @Empresa_Id AND
NOT EXISTS (SELECT 1 FROM comMovProvDevenga WHERE comMovProv.comMovProv = comMovProvDevenga.comMovProv)
UNION ALL
SELECT comMovProv.TipoMov, conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
comProveedores.Proveed_Id, vcomMovProv.Comprobante, 
comMovTipos.Descripcion+ ' Mostrador '+CONVERT(CHAR(10),@FechaDesde,103)+' al '+CONVERT(CHAR(10),@FechaHasta,103) Descripcion,
comProveedores.Proveed_Id+' '+vcomMovProv.Comprobante Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC, conAsientos.conAsientos  
FROM comMovProv 
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN vComMovprov ON comMovProv.comMovProv = vcomMovProv.comMovProv
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov	
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
comMovProv.FacturaTesoreria = 1 AND
conAsientos.Empresa_Id = @Empresa_Id
UNION ALL
SELECT '99' TipoMov, conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber, 
comProveedores.Proveed_Id, '' Comprobante, 
'DIFERENCIAS DE CAMBIO AL CIERRE '+CONVERT(CHAR(10),@FechaDesde,103)+' al '+CONVERT(CHAR(10),@FechaHasta,103) Descripcion,
comProveedores.Proveed_Id+' '+CONVERT(CHAR(10),conAsientos.Fecha,103) Leyenda,
comAsiCierre.Fecha, comAsiCierre.Fecha as FechaDC , conAsientos.conAsientos  
FROM comAsiCierre
INNER JOIN comAsiCierreCr ON comAsiCierre.Asiento_Id = comAsiCierreCr.Asiento_Id
INNER JOIN conAsientos ON comAsiCierre.Asiento_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos AND
	comAsiCierreCr.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN genMonedas ON comAsiCierre.Moneda_Id = genMonedas.genMonedas
INNER JOIN comProveedores ON comAsiCierrecr.Proveed_id = comProveedores.genEntidades
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @Empresa_Id
UNION ALL
SELECT '54', conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
comProveedores.Proveed_Id, vcomMovProv.Comprobante, 
comMovTipos.Descripcion+ ' Aplicaciones en Cta. Cte. '+CONVERT(CHAR(10),@FechaDesde,103)+' al '+CONVERT(CHAR(10),@FechaHasta,103) Descripcion,
comProveedores.Proveed_Id+' '+vcomMovProv.Comprobante Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC, conAsientos.conAsientos  
FROM genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON genCancMov.Asiento_Id = comMovProv.comMovProv
INNER JOIN vcomMovProv ON comMovProv.comMovProv = vcomMovProv.comMovProv
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov	
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE genCancMov.AsientoApli_Id IS NOT NULL AND
conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @Empresa_Id
UNION ALL
SELECT comMovProv.TipoMov, conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
comProveedores.Proveed_Id, vcomMovProv.Comprobante, 
'Seguros Devengados '+CONVERT(CHAR(10),@FechaDesde,103)+' al '+CONVERT(CHAR(10),@FechaHasta,103) Descripcion,
' Seguros Devengados'+CONVERT(CHAR(10),conAsientos.Fecha,103)+' al '+CONVERT(CHAR(10),conAsientos.Fecha,103) Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC, conAsientos.conAsientos  
FROM comMovProvDevenga 
INNER JOIN conAsientos ON comMovProvDevenga.comMovProv = conAsientos.conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN comMovProv ON comMovProvDevenga.comMovProv = comMovProv.comMovProv
INNER JOIN vComMovprov ON comMovProvDevenga.comMovProv = vcomMovProv.comMovProv
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov	
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa_Id 
UNION ALL
SELECT '100', conMovCont.TipoMov, conCuentas.Cuenta_Id,
conCuentas.Descripcion DescCuenta, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id,
ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, 
CASE WHEN conMovCont.TipoMov = 1 THEN conMovCont.Importe ELSE 0 END Debe,
CASE WHEN conMovCont.TipoMov = 2 THEN conMovCont.Importe ELSE 0 END Haber,
comProveedores.Proveed_Id,' ' Comprobante, 
'Recepciones de Servicios '+CONVERT(CHAR(10),@FechaDesde,103)+' al '+CONVERT(CHAR(10),@FechaHasta,103) Descripcion,
'Recepciones de Servicios '+CONVERT(CHAR(10),conAsientos.Fecha,103)+' al '+CONVERT(CHAR(10),conAsientos.Fecha,103) Leyenda,
conAsientos.Fecha, Convert(smalldatetime, ' ') as FechaDC, conAsientos.conAsientos  
FROM comOrdenComp 
INNER JOIN comOCCuerpo ON comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp
INNER JOIN comOcReceCuerpo ON comOCCuerpo.comOrdenComp = comOcReceCuerpo.comOrdenComp AND
	comOCCuerpo.Renglon_OC = comOcReceCuerpo.Renglon_OC
INNER JOIN conAsientos ON comOcReceCuerpo.comOcRecepcion = conAsientos.conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos AND
	conMovCont.Renglon = comOcReceCuerpo.conRenglon
INNER JOIN comProveedores ON comOrdenComp.Proveed_Id = comProveedores.genEntidades
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
LEFT JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
LEFT JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
WHERE conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa_Id 
ORDER BY 1,12,13,2,3	


DECLARE @TableTemp TABLE(comTipoMov VARCHAR(1), TipoMov SMALLINT, Cuenta_Id VARCHAR(25), DescCuenta VARCHAR(80), 
	Centro1_Id VARCHAR(8), Centro2_Id VARCHAR(8), Debe qMonedaD2, Haber qMonedaD2, Descripcion VARCHAR(80), Comprobante VARCHAR(120),
	Leyenda VARCHAR(220), Fecha qFecha, FechaDC qFecha, Proveed_Id VARCHAR(15))

DECLARE @pcomTipoMov VARCHAR(1), @pTipoMov SMALLINT, @pCuenta_Id VARCHAR(25), @pDescCuenta VARCHAR(80), 
	@pCentro1_Id VARCHAR(8), @pCentro2_Id VARCHAR(8), @pDebe qMonedaD2, @pHaber qMonedaD2, @pDescripcion VARCHAR(80), @pComprobante VARCHAR(120),
	@pLeyenda VARCHAR(220), @pFecha qFecha, @pFechaDC qFecha, @pProveed_Id VARCHAR(15)



IF (@Detallado = 0)
	BEGIN
		SELECT comTipoMov, TipoMov, Cuenta_id, DescCuenta, Centro1_id, Centro2_id, SUM(Debe) AS Debe, SUM(Haber) AS Haber,  
		Descripcion, Fecha,'' as Comprobante , ' ' as Leyenda , ''  as FechaDC , '' as Proveed_id
		INTO ##_Cursor
		FROM ##_Final
		GROUP BY comTipoMov, TipoMov, Cuenta_id, DescCuenta, Centro1_id, Centro2_id, Descripcion, Fecha
		ORDER BY comTipoMov, TipoMov, Cuenta_id, Centro1_id, Centro2_id

		DECLARE CursorFinal CURSOR FOR   
		SELECT comTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
			Leyenda, Fecha, FechaDC, Proveed_Id
		FROM ##_Cursor;  

		OPEN CursorFinal 

		FETCH NEXT FROM CursorFinal   
		INTO @pcomTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
			@pLeyenda, @pFecha, @pFechaDC, @pProveed_Id

		WHILE @@FETCH_STATUS = 0  
		BEGIN  
			INSERT INTO @TableTemp (comTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
				Leyenda, Fecha, FechaDC, Proveed_Id) 
			VALUES (@pcomTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pProveed_Id)

			FETCH NEXT FROM CursorFinal   
			INTO @pcomTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pProveed_Id
		END
		CLOSE CursorFinal
		DEALLOCATE CursorFinal 

		DROP TABLE ##_Cursor
	END
ELSE
	BEGIN
		DECLARE CursorFinal CURSOR FOR   
		SELECT comTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
			Leyenda, Fecha, FechaDC, Proveed_Id
		FROM ##_Final;  

		OPEN CursorFinal 

		FETCH NEXT FROM CursorFinal   
		INTO @pcomTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
			@pLeyenda, @pFecha, @pFechaDC, @pProveed_Id

		WHILE @@FETCH_STATUS = 0  
		BEGIN  
			INSERT INTO @TableTemp (comTipoMov, TipoMov, Cuenta_Id, DescCuenta, Centro1_Id, Centro2_Id, Debe, Haber, Descripcion, Comprobante ,
				Leyenda, Fecha, FechaDC, Proveed_Id) 
			VALUES (@pcomTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pProveed_Id)

			FETCH NEXT FROM CursorFinal   
			INTO @pcomTipoMov, @pTipoMov, @pCuenta_Id, @pDescCuenta, @pCentro1_Id, @pCentro2_Id, @pDebe, @pHaber, @pDescripcion, @pComprobante ,
				@pLeyenda, @pFecha, @pFechaDC, @pProveed_Id
		END
		CLOSE CursorFinal
		DEALLOCATE CursorFinal 
	END

DROP TABLE ##_Final

SELECT * FROM @TableTemp
GO

DROP PROCEDURE Inf_comAsiCierreAux
Go
CREATE PROCEDURE Inf_comAsiCierreAux
AS
SELECT ' ' comTipoMov, 0 TipoMov, ' ' Cuenta_Id, ' ' DescCuenta, ' ' Centro1_Id, ' ' Centro2_Id, 0 Debe, 0 Haber,
	' ' Descripcion, ' ' Comprobante, ' ' Leyenda, GETDATE() Fecha, GETDATE() FechaDC, ' ' Proveed_Id
GO


--Imnpuestos Al Vencimiento
/*
SELECT '0' ComTipoMov, 1 TipoMov, A.Cuenta_Reversion Cuenta_Id, '' Centro1_Id, '' Centro2_Id,
ROUND(A.ImpPago * (A.Importe_Impuestos / A.ImpFactura) * (A.Importe_Ap / A.ImpFactura),2)
FROM (SELECT genCancMov.FechaAplicacion, vtesMovimientos.Segmento Comprobante,
tesIdentifica.Cartera_Id, comMovImpuestos.Importe_Impuesto*conAsientos.Cambio Importe_Impuestos,
comImpuestos.Impuesto_Id, comImpuestos.Descripcion, conMovCont.Importe ImpPago, comMovProv.Importe ImpFactura,
genCancMov.Importe_Ap, genCancMov.Importe, genCancMov.Importe*0 ImporteADescontar,
comMovTipos.TipoMov, conCuentas.Cuenta_Id, conCuentas.Descripcion DescCta,
conCtaReversion.Cuenta_Id Cuenta_Reversion, ISNULL(conCtaReversion.Descripcion,'') DescCtaReversion, comProveedores.Proveed_Id,
comProveedores.RazonSocial, comMovProv.Fecha_CCP, genCancMov.FechaAplicacion Fecha,
Convert(smalldatetime, ' ') as FechaDC
FROM comMovProv 
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov
INNER JOIN comMovImpuestos ON comMovProv.comMovProv = comMovImpuestos.comMovProv
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN comImpuestos ON comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos
INNER JOIN genCancMov ON conAsientos.conAsientos = genCancMov.Asiento_Id_Ap
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = genCancMov.Asiento_Id
INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos 
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesMovimientos.tesMovimientos AND
	tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON comImpuestos.CtaDebe = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
LEFT JOIN conCuentas conCtaReversion ON comImpuestos.CtaReversion = conCtaReversion.conCuentas
WHERE tesIdentifica.Cartera_Id <> 'PRO' AND
comImpuestos.PorAcreditacion = 1 AND
(comMovTipos.TipoMov = 'P' OR comProveedores.Ganancias <> 1) AND
genCancMov.FechaAplicacion BETWEEN  @FechaDesde AND @FechaHasta AND
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa_Id
UNION ALL 
SELECT genCancMov.FechaAplicacion, vtesMovimientos.Segmento Comprobante,
tesIdentifica.Cartera_Id, comMovImpuestos.Importe_Impuesto*conAsientos.Cambio Importe_Impuestos,
comImpuestos.Impuesto_Id, comImpuestos.Descripcion, conMovCont.Importe ImpPago, comMovProv.Importe ImpFactura,
genCancMov.Importe_Ap, genCancMov.Importe, genCancMov.Importe*0 ImporteADescontar,
comMovTipos.TipoMov, conCuentas.Cuenta_Id, conCuentas.Descripcion DescCta,
conCtaReversion.Cuenta_Id, ISNULL(conCtaReversion.Descripcion,'') DescCtaReversion, comProveedores.Proveed_Id,
comProveedores.RazonSocial, comMovProv.Fecha_CCP, genCancMov.FechaAplicacion Fecha,
Convert(smalldatetime, ' ') as FechaDC
FROM comMovProv 
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov
INNER JOIN comMovImpuestos ON comMovProv.comMovProv = comMovImpuestos.comMovProv
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN comImpuestos ON comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos
INNER JOIN genCancMov ON conAsientos.conAsientos = genCancMov.Asiento_Id_Ap
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = genCancMov.Asiento_Id
INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos 
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesMovimientos.tesMovimientos AND
	tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON comImpuestos.CtaDebe = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
LEFT JOIN conCuentas conCtaReversion ON comImpuestos.CtaReversion = conCtaReversion.conCuentas
INNER JOIN tesRengConcilEsp ON tesRengMovi.tesMovimientos = tesRengConcilEsp.tesMovimientos AND
	tesRengMovi.conRenglon = tesRengConcilEsp.conRenglon
INNER JOIN tesConciliacion ON tesRengConcilEsp.NumeroConc = tesConciliacion.NumeroConc AND
	tesRengConcilEsp.tesIdentifica = tesConciliacion.tesIdentifica 
WHERE tesIdentifica.Cartera_Id <> 'PRO' AND
comImpuestos.PorAcreditacion = 1 AND
(comMovTipos.TipoMov = 'P' OR comProveedores.Ganancias <> 1) AND
genCancMov.FechaAplicacion > tesConciliacion.FechaConciliacion AND
genCancMov.FechaAplicacion BETWEEN  @FechaDesde AND @FechaHasta AND
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa_Id 
UNION ALL 
SELECT genCancMov.FechaAplicacion, vtesMovimientos.Segmento Comprobante,
tesIdentifica.Cartera_Id, comMovImpuestos.Importe_Impuesto*conAsientos.Cambio Importe_Impuestos,
comImpuestos.Impuesto_Id, comImpuestos.Descripcion, conMovCont.Importe ImpPago, comMovProv.Importe ImpFactura,
genCancMov.Importe_Ap, genCancMov.Importe, genCancMov.Importe*0 ImporteADescontar,
comMovTipos.TipoMov, conCuentas.Cuenta_Id, conCuentas.Descripcion DescCta,
conCtaReversion.Cuenta_Id, ISNULL(conCtaReversion.Descripcion,'') DescCtaReversion, comProveedores.Proveed_Id,
comProveedores.RazonSocial, comMovProv.Fecha_CCP, genCancMov.FechaAplicacion Fecha,
Convert(smalldatetime, ' ') as FechaDC
FROM comMovProv 
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov
INNER JOIN comMovImpuestos ON comMovProv.comMovProv = comMovImpuestos.comMovProv
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN comImpuestos ON comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos
INNER JOIN genCancMov ON conAsientos.conAsientos = genCancMov.Asiento_Id_Ap
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = genCancMov.Asiento_Id
INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos 
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesMovimientos.tesMovimientos AND
	tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON comImpuestos.CtaDebe = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
LEFT JOIN conCuentas conCtaReversion ON comImpuestos.CtaReversion = conCtaReversion.conCuentas
INNER JOIN tesRengConcilEsp ON tesRengMovi.tesMovimientos = tesRengConcilEsp.tesMovimientos AND
	tesRengMovi.conRenglon = tesRengConcilEsp.conRenglon
INNER JOIN tesConciliacion ON tesRengConcilEsp.NumeroConc = tesConciliacion.NumeroConc AND
	tesRengConcilEsp.tesIdentifica = tesConciliacion.tesIdentifica 
WHERE tesIdentifica.Cartera_Id <> 'PRO' AND
comImpuestos.PorAcreditacion = 1 AND
(comMovTipos.TipoMov = 'P' OR comProveedores.Ganancias <> 1) AND
genCancMov.FechaAplicacion <= tesConciliacion.FechaConciliacion AND
genCancMov.FechaAplicacion BETWEEN  @FechaDesde AND @FechaHasta AND
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa_Id 
UNION ALL
SELECT genCancMov.FechaAplicacion, vComMovprov.Comprobante,
'' Cartera_Id, comMovImpuestos.Importe_Impuesto*conAsientos.Cambio Importe_Impuestos,
comImpuestos.Impuesto_Id, comImpuestos.Descripcion, genCancMov.Importe*conAsientos.Cambio ImpPago, 
comMovProv.Importe*conAsientos.Cambio ImpFactura,
genCancMov.Importe, genCancMov.Importe*0, genCancMov.Importe*0 ImporteADescontar,
comMovTipos.TipoMov, conCuentas.Cuenta_Id, conCuentas.Descripcion DescCta,
conCtaReversion.Cuenta_Id, ISNULL(conCtaReversion.Descripcion,'') DescCtaReversion, comProveedores.Proveed_Id,
comProveedores.RazonSocial, comMovProv.Fecha_CCP, genCancMov.FechaAplicacion Fecha,
Convert(smalldatetime, ' ') as FechaDC
FROM comMovProv 
INNER JOIN comMovImpuestos ON comMovProv.comMovProv = comMovImpuestos.comMovProv
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN comImpuestos ON comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos
INNER JOIN genCancMov ON conAsientos.conAsientos = genCancMov.Asiento_Id
INNER JOIN comMovProv comMovProv_Ap ON genCancMov.Asiento_Id_Ap = comMovProv_Ap.comMovProv
INNER JOIN vComMovprov ON comMovProv_Ap.comMovProv = vComMovprov.comMovProv
INNER JOIN comMovTipos ON comMovProv_Ap.TipoMov = comMovTipos.TipoMov
INNER JOIN conCuentas ON comImpuestos.CtaDebe = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
LEFT JOIN conCuentas conCtaReversion ON comImpuestos.CtaReversion = conCtaReversion.conCuentas
WHERE comMovTipos.TipoMov = 'Y' AND	
genCancMov.FechaAplicacion BETWEEN  @FechaDesde AND @FechaHasta AND
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa_Id) A */

/*
SELECT tesConciliacion.FechaConciliacion, vtesMovimientos.Segmento Comprobante, tesIdentifica.Cartera_Id, 
conMovCont.Importe/(1+comImpuestos.Porcentaje/100)*comImpuestos.Porcentaje/100 Importe_Impuestos,	
comImpuestos.Impuesto_Id, comImpuestos.Descripcion, 
conMovCont.Importe ImpPago, conMovCont.Importe ImpFactura,
conMovCont.Importe Importe_Ap, genCancMov.Importe*0 ImporteADescontar,
'ANT' TipoMov, conCuentas.Cuenta_Id, conCuentas.Descripcion DescCta,
conCtaReversion.Cuenta_Id, ISNULL(conCtaReversion.Descripcion,'') DescCtaReversion, comProveedores.Proveed_Id,
comProveedores.RazonSocial, conAsientos.Fecha Fecha_CCP, tesConciliacion.FechaConciliacion Fecha,
Convert(smalldatetime, ' ') as FechaDC
FROM comMovProv 
INNER JOIN comMovTipos ON comMovProv.TipoMov = comMovTipos.TipoMov
INNER JOIN comMovImpuestos ON comMovProv.comMovProv = comMovImpuestos.comMovProv
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN comImpuestos ON comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos
INNER JOIN genCancMov ON conAsientos.conAsientos = genCancMov.Asiento_Id_Ap
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = genCancMov.Asiento_Id
INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos 
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesMovimientos.tesMovimientos AND
	tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON comImpuestos.CtaDebe = conCuentas.conCuentas
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
LEFT JOIN conCuentas conCtaReversion ON comImpuestos.CtaReversion = conCtaReversion.conCuentas
INNER JOIN tesRengConcilEsp ON tesRengMovi.tesMovimientos = tesRengConcilEsp.tesMovimientos AND
	tesRengMovi.conRenglon = tesRengConcilEsp.conRenglon
INNER JOIN tesConciliacion ON tesRengConcilEsp.NumeroConc = tesConciliacion.NumeroConc AND
	tesRengConcilEsp.tesIdentifica = tesConciliacion.tesIdentifica 
WHERE tesIdentifica.Cartera_Id <> 'PRO' AND
--comImpuestos.PorAcreditacion = 1 AND
(comMovTipos.TipoMov = 'P' OR comProveedores.Ganancias = 1) AND
genCancMov.FechaAplicacion > tesConciliacion.FechaConciliacion AND
genCancMov.FechaAplicacion BETWEEN '20200101' AND '20221231'
*/
