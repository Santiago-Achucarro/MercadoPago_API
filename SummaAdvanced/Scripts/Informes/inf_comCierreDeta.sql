-- exec inf_comCierreDeta '20210401','20210430',1
drop PROCEDURE inf_comCierreDeta
go

CREATE PROCEDURE inf_comCierreDeta(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_id int
)

as
SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, genMonedas.Moneda_Id, 
	conAsientos.Cambio,
	 ISNULL((SELECT SUM(comMovProv.importe*comMovTipos.Signo) 
	from comMovProv 
		INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comMovProv.comMovProv 
		INNER JOIN comMovTipos ON  comMovTipos.TipoMov = comMovProv.TipoMov
		where
			conAsientosP.Anulado = 0 and
			conAsientosP.Posteado = 1 and 
			conAsientosP.Empresa_id = @Empresa_id and 
			conAsientosP.Empresa_Id = @Empresa_id and 
			conAsientosP.Fecha <= @FechaHasta and
			commovprov.Proveed_Id = comProveedores.genEntidades and 
			conAsientosP.Moneda_Id = genMonedas.genMonedas),0) SaldoMonExtran,
			-- saldo pro
			ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
			FROM comMovProv 
				INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comMovProv.comMovProv
				INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND conMovCont.Clase IN ('PRO')
				INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id  
				WHERE 
				genMonedas.genMonedas = conCuentas.Moneda_id AND 
				comMovProv.Proveed_Id= comProveedores.genEntidades and 
				conAsientosP.Anulado = 0 and 
				conAsientosP.Empresa_Id = @Empresa_Id and 
				conAsientosP.Fecha <= @FechaHasta ),0) + 
		--APLICACIONES
		isnull((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
			FROM commovprov 
			INNER JOIN genCancMov ON genCancMov.Asiento_Id = comMovProv.comMovProv 
			INNER JOIN conAsientos  conAsientosP ON conAsientosP.conAsientos = genCancMov.AsientoApli_Id
			INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientosP.conAsientos AND conMovCont.Clase IN ('PRO')
			INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
			WHERE 
			genMonedas.genMonedas = conCuentas.Moneda_id AND 
			comMovProv.Proveed_Id= comProveedores.genEntidades and 
			genCancMov.Importacion = 0 and 
			conAsientosP.Anulado = 0 and 
			conAsientosP.Empresa_Id = @Empresa_Id and 
			conAsientosP.Fecha <= @FechaHasta ),0) +
-- DIFERENCIA EN CAMBIOS
	ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM commovprov 
		INNER JOIN genCancMov ON  genCancMov.Asiento_Id = comMovProv.comMovProv 
		INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsieDifCambio_Id
		INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND conMovCont.Clase IN ('PRO')
		INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovProv.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 0 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta),0) +
	-- CIERRE DE MES
	ISNULL((SELECT 	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM comAsiCierreCr 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comAsiCierreCr.Asiento_id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovcont.Renglon = comAsiCierreCr.conRenglon and conMovCont.Clase IN ('PRO')
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comAsiCierreCr.Proveed_Id= comProveedores.genEntidades and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaDesde),0) +
	isnull((SELECT SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as ImporteonedaOriginal 
		FROM commovprov 
			INNER JOIN genCancMov ON genCancMov.Asiento_Id = comMovProv.comMovProv 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsientoApli_Id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('PRO')
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
			INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
						genCancMovApliImpor.Renglon = conMovCont.Renglon and 
						genCancMovApliImpor.EsDelAp = 0
		WHERE 
		genMonedas.genMonedas = conCuentas.Moneda_id AND 
		comMovprov.Proveed_Id= comProveedores.genEntidades and 
		genCancMov.Importacion = 1 and 
		conAsientosP.Anulado = 0 and 
		conAsientosP.Empresa_Id = @Empresa_Id and 
		conAsientosP.Fecha <= @FechaHasta),0) +
	-- IMPORTACIONES AP
	ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
	
	FROM commovprov 
	INNER JOIN genCancMov ON  genCancMov.Asiento_Id_Ap = comMovProv.comMovProv 
	INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsientoApli_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('PRO')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
	INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
					genCancMovApliImpor.Renglon = conMovCont.Renglon and 
					genCancMovApliImpor.EsDelAp = 1
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovprov.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 1 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta),0) +
ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
FROM commovprov 
INNER JOIN genCancMov ON  genCancMov.Asiento_Id = comMovProv.comMovProv 
INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsieDifCambio_Id
INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('PRO')
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
				genCancMovApliImpor.Renglon = conMovCont.Renglon and 
				genCancMovApliImpor.EsDelAp = 0
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovprov.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 1 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta ),0) +
-- IMPROTACIONES DC AP
ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
	FROM commovprov 
	INNER JOIN genCancMov ON genCancMov.Asiento_Id_Ap = comMovProv.comMovProv 
	INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsieDifCambio_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('PRO')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
	INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
				genCancMovApliImpor.Renglon = conMovCont.Renglon and 
				genCancMovApliImpor.EsDelAp = 1
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovprov.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 1 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta ),0) AS SaldoProvedores, 

			ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
			FROM comMovProv 
				INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comMovProv.comMovProv
				INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND conMovCont.Clase IN ('ANTPR')
				INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id  
				WHERE 
				genMonedas.genMonedas = conCuentas.Moneda_id AND 
				comMovProv.Proveed_Id= comProveedores.genEntidades and 
				conAsientosP.Anulado = 0 and 
				conAsientosP.Empresa_Id = @Empresa_Id and 
				conAsientosP.Fecha <= @FechaHasta ),0) + 
		--APLICACIONES
		isnull((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
			FROM commovprov 
			INNER JOIN genCancMov ON genCancMov.Asiento_Id = comMovProv.comMovProv 
			INNER JOIN conAsientos  conAsientosP ON conAsientosP.conAsientos = genCancMov.AsientoApli_Id
			INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientosP.conAsientos AND conMovCont.Clase IN ( 'ANTPR')
			INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
			WHERE 
			genMonedas.genMonedas = conCuentas.Moneda_id AND 
			comMovProv.Proveed_Id= comProveedores.genEntidades and 
			genCancMov.Importacion = 0 and 
			conAsientosP.Anulado = 0 and 
			conAsientosP.Empresa_Id = @Empresa_Id and 
			conAsientosP.Fecha <= @FechaHasta ),0) +
-- DIFERENCIA EN CAMBIOS
	ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM commovprov 
		INNER JOIN genCancMov ON  genCancMov.Asiento_Id = comMovProv.comMovProv 
		INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsieDifCambio_Id
		INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND conMovCont.Clase IN ('ANTPR')
		INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovProv.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 0 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta),0) +
	-- CIERRE DE MES
	ISNULL((SELECT 	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM comAsiCierreCr 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comAsiCierreCr.Asiento_id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovcont.Renglon = comAsiCierreCr.conRenglon and 
				conMovCont.Clase IN ('ANTPR')
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comAsiCierreCr.Proveed_Id= comProveedores.genEntidades and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaDesde),0) +
	isnull((SELECT SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as ImporteonedaOriginal 
		FROM commovprov 
			INNER JOIN genCancMov ON genCancMov.Asiento_Id = comMovProv.comMovProv 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsientoApli_Id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('ANTPR')
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
			INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
						genCancMovApliImpor.Renglon = conMovCont.Renglon and 
						genCancMovApliImpor.EsDelAp = 0
		WHERE 
		genMonedas.genMonedas = conCuentas.Moneda_id AND 
		comMovprov.Proveed_Id= comProveedores.genEntidades and 
		genCancMov.Importacion = 1 and 
		conAsientosP.Anulado = 0 and 
		conAsientosP.Empresa_Id = @Empresa_Id and 
		conAsientosP.Fecha <= @FechaHasta),0) +
	-- IMPORTACIONES AP
	ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
	
	FROM commovprov 
	INNER JOIN genCancMov ON  genCancMov.Asiento_Id_Ap = comMovProv.comMovProv 
	INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsientoApli_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('ANTPR')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
	INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
					genCancMovApliImpor.Renglon = conMovCont.Renglon and 
					genCancMovApliImpor.EsDelAp = 1
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovprov.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 1 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta),0) +
ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
FROM commovprov 
INNER JOIN genCancMov ON  genCancMov.Asiento_Id = comMovProv.comMovProv 
INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsieDifCambio_Id
INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ( 'ANTPR')
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
				genCancMovApliImpor.Renglon = conMovCont.Renglon and 
				genCancMovApliImpor.EsDelAp = 0
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovprov.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 1 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta ),0) +
-- IMPROTACIONES DC AP
ISNULL((SELECT  SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
	FROM commovprov 
	INNER JOIN genCancMov ON genCancMov.Asiento_Id_Ap = comMovProv.comMovProv 
	INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.AsieDifCambio_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovCont.Clase IN ('ANTPR')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
	INNER JOIN genCancMovApliImpor ON genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
				genCancMovApliImpor.Renglon = conMovCont.Renglon and 
				genCancMovApliImpor.EsDelAp = 1
	WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comMovprov.Proveed_Id= comProveedores.genEntidades and 
	genCancMov.Importacion = 1 and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha <= @FechaHasta ),0) AS SaldoAnticipos, 
	ISNULL((SELECT 	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM comAsiCierreCr 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comAsiCierreCr.Asiento_id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovcont.Renglon = comAsiCierreCr.conRenglon and 
				conMovCont.Clase IN ('PRO', 'ANTPR')
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comAsiCierreCr.Proveed_Id= comProveedores.genEntidades and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha between @FechaDesde and @FechaHasta),0) Cierre, 

	ISNULL((SELECT 	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM comAsiCierreCr 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comAsiCierreCr.Asiento_id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovcont.Renglon = comAsiCierreCr.conRenglon and 
				conMovCont.Clase IN ('PRO', 'ANTPR') and conmovcont.TipoMov = 2
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comAsiCierreCr.Proveed_Id= comProveedores.genEntidades and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha between @FechaDesde and @FechaHasta),0) Perdida,
		ISNULL((SELECT 	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) 
		FROM comAsiCierreCr 
			INNER JOIN conAsientos conAsientosP ON conAsientosP.conAsientos = comAsiCierreCr.Asiento_id
			INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientosP.conAsientos AND  conMovcont.Renglon = comAsiCierreCr.conRenglon and 
				conMovCont.Clase  IN ('PRO', 'ANTPR') and conmovcont.TipoMov = 1
			INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_id 
WHERE 
	genMonedas.genMonedas = conCuentas.Moneda_id AND 
	comAsiCierreCr.Proveed_Id= comProveedores.genEntidades and 
	conAsientosP.Anulado = 0 and 
	conAsientosP.Empresa_Id = @Empresa_Id and 
	conAsientosP.Fecha between @FechaDesde and @FechaHasta),0) Ganancia

from comAsiCierre
INNER JOIN conAsientos ON  conAsientos.conAsientos = comAsiCierre.Asiento_Id
inner join genMonedas ON  genMonedas.genMonedas = comAsiCierre.Moneda_Id
iNNER JOIN comAsiCierreCr ON  comAsiCierreCr.Asiento_Id = comAsiCierre.Asiento_Id
INNER JOIN comProveedores ON  comProveedores.genEntidades =  comAsiCierreCr.Proveed_id
INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
where
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	conAsientos.Empresa_Id = @Empresa_id
GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial, genMonedas.Moneda_Id, 
genMonedas.genMonedas, comProveedores.genEntidades, conAsientos.Cambio
ORDER BY 3,1
GO

