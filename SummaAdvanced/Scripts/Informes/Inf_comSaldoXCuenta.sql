-- Inf_comSaldoXCuenta '20200331',1
-- Inf_comSaldoXCuenta '20191231',1
DROP PROCEDURE Inf_comSaldoXCuenta
GO
CREATE PROCEDURE Inf_comSaldoXCuenta (
	@FechaHasta DateTime, 
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Empresa int
)
AS
SELECT  Cuenta_Id, Descripcion, Proveed_id, RazonSocial, 
	SUM(Monto) as Monto
FROM (

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,1 as Origen
FROm comMovProv INNER JOIN conAsientos ON
comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
Where
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR') and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
union all

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,2
FROm genCancmov INNER JOIN conAsientos ON
genCancmov.AsientoApli_id = conAsientos.conAsientos
INNER JOIN  comMovProv ON  
comMovProv.comMovProv = genCancmov.Asiento_id
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
Where
NOT EXISTS(SELECT 1 FROM genCancMovApliImpor where
	genCancMovApliImpor.conAsientos = genCancMov.Asiento_Id) and 
NOT EXISTS(SELECT 1 FROM genCancMovApliImpor where
	genCancMovApliImpor.conAsientos = genCancMov.Asiento_Id_ap) and 
gencancmov.Importacion = 0 AND 
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR') and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0

UNION ALL

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,3
FROm genCancmov INNER JOIN conAsientos ON
genCancmov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN  comMovProv ON  
comMovProv.comMovProv = genCancmov.Asiento_id
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
Where
genCancMov.Importacion = 0 and
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR')  and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,4
FROm genCancmov INNER JOIN conAsientos ON
genCancmov.AsientoApli_id = conAsientos.conAsientos
INNER JOIN  comMovProv ON  
comMovProv.comMovProv = genCancmov.Asiento_id
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 0
Where
genCancMov.Importacion = 1 and
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR')  and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,5
FROm genCancmov INNER JOIN conAsientos ON
genCancmov.AsientoApli_id = conAsientos.conAsientos
INNER JOIN  comMovProv ON  
comMovProv.comMovProv = genCancmov.Asiento_id_Ap
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 1
Where
genCancMov.Importacion = 1 and
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR')  and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,6
FROm genCancmov INNER JOIN conAsientos ON
genCancmov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN  comMovProv ON  
comMovProv.comMovProv = genCancmov.Asiento_id
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 0
Where
genCancMov.Importacion = 1 and
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR')  and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,7
FROm genCancmov INNER JOIN conAsientos ON
genCancmov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN  comMovProv ON  
comMovProv.comMovProv = genCancmov.Asiento_id_Ap
INNER JOIN conMovCont ON 
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON
comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 1
Where
genCancMov.Importacion = 1 and
comMovProv.FacturaTesoreria = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR')  and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
	,8
FROm comAsiCierreCr INNER JOIN conAsientos ON
comAsiCierreCr.Asiento_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON 
conMovCont.conAsientos = comAsiCierreCr.Asiento_Id AND 
conMovCont.Renglon = comAsiCierreCr.conRenglon
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comAsiCierreCr.Proveed_id 
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('PRO', 'ANTPR')  and 
	comProveedores.Proveed_Id between 	@ProveedDesde and 	@ProveedHasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial
having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
) AS XXX
GROUP BY Cuenta_Id, Descripcion, Proveed_id, RazonSocial
HAVING SUM(Monto) <> 0

ORDER BY 1,4
GO



