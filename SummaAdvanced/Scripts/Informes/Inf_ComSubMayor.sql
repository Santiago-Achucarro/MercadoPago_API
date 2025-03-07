-- Inf_ComSubMayor '20170101','20170831',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ', 1,1
DROP PROCEDURE Inf_ComSubMayor
GO

CREATE PROCEDURE [dbo].[Inf_ComSubMayor] @FechaDesde DateTime, @FechaHasta DateTime, 
	@CuentaDesde VarChar(25),@CuentaHasta VarChar(25),
	@Centro1Desde VarChar(8),@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),@Centro2Hasta VarChar(8),
	@ProveedDesde VarChar(15), @ProveedHasta VarChar(15), 
	@Empresa int, 
	@IncluPagos Bit
AS
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm comMovProv 
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	(@IncluPagos=1 or comMovTipos.Tipomov NOT IN ('P','C')) and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON comMovProv.comMovProv = genCancMov.Asiento_Id
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
Where
	genCancMov.Importacion = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON comMovProv.comMovProv = genCancMov.Asiento_Id
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
Where
	genCancMov.Importacion = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 

UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	'Embarque' Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm comEmbarques 
INNER JOIN conAsientos ON comEmbarques.comEmbarques = conAsientos.conAsientos
INNER JOIN (select  comEmbCuerpo.comEmbarques, max(comOrdenComp.Proveed_Id) Proveed_Id
	from  comEmbCuerpo, comOrdenComp 
	Where
	comOrdenComp.comOrdenComp = comEmbCuerpo.comOrdenComp
	GROUP BY comEmbCuerpo.comEmbarques ) AS comEmbCuerpo ON comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques
INNER JOIN comProveedores ON comProveedores.genEntidades = comEmbCuerpo.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 
-- IMPORTACIONES APLICACION
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON comMovProv.comMovProv = genCancMov.Asiento_Id
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 0
Where
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 

UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON comMovProv.comMovProv = genCancMov.Asiento_Id_Ap
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 1
Where
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 
-- DIF CAMBIO IMPORTACIONES
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON comMovProv.comMovProv = genCancMov.Asiento_Id
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 0
Where
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 

UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	comMovTipos.Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm genCancMov 
INNER JOIN conAsientos ON genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN comMovProv ON comMovProv.comMovProv = genCancMov.Asiento_Id_Ap
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
INNER JOIN genCancMovApliImpor ON 
genCancMovApliImpor.conAsientos = conmovcont.conAsientos and 
genCancMovApliImpor.Renglon = conmovcont.Renglon and
genCancMovApliImpor.EsDelAp = 1
Where
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta 
Union All
-- Recepciones OC --
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	'Recepcion OC' Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm comOcReceCuerpo 
INNER JOIN conAsientos ON comOcReceCuerpo.comOcRecepcion = conAsientos.conAsientos
Inner Join comOrdenComp On comOrdenComp.comOrdenComp = comOcReceCuerpo.comOrdenComp
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id 
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Renglon = comOcReceCuerpo.conRenglon
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	'Recepcion OC' Descripcion, 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm comAsiCierreCr INNER JOIN conAsientos ON
comAsiCierreCr.Asiento_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON 
conMovCont.conAsientos = comAsiCierreCr.Asiento_Id AND 
conMovCont.Renglon = comAsiCierreCr.conRenglon
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN comProveedores ON
comProveedores.genEntidades = comAsiCierreCr.Proveed_id 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
left join conCentro1 ON conCentro1.conCentro1 = conmovcont.Centro1_Id
left join conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro1_Id

Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and
	isnull(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
	isnull(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta and 
	comProveedores.Proveed_id BETWEEN @ProveedDesde AND @ProveedHasta



ORDER BY 1,3,4,5

GO

