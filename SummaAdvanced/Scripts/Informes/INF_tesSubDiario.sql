-- INF_tesSubDiario '20170101','20171231',1
DROP PROCEDURE INF_tesSubDiario
GO
CREATE PROCEDURE INF_tesSubDiario @FechaDesde DateTime, @FechaHasta DateTime, @Empresa int
AS
SELECT conAsientos.Fecha, conAsientos.conAsientos, conMovCont.Renglon,  
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	tesSubTiposMov.Descripcion, 
	IsNull(comProveedores.Proveed_id, IsNull(venClientes.Cliente_Id, '')) Codigo, 
	IsNull(comProveedores.RazonSocial, IsNull(venClientes.RazonSocial, '')) RazonSocial, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta, 
	ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, ISNULL(conCentro1.Descripcion,' ') AS DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id, ISNULL(conCentro2.Descripcion,' ') AS DescripcionCentro2, 
	Case When conMovCont.Tipomov=1 THEN conMovCont.Importe ELSE 0 END Debe, 
	Case When conMovCont.Tipomov=2 THEN conMovCont.Importe ELSE 0 END Haber,
	conMovCont.Clase
FROm tesMovimientos
INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos
Left Join (comMovProv INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id) On tesMovimientos.tesMovimientos = comMovProv.comMovProv
Left Join (venMovimientos Inner Join venClientes On venMovimientos.Cliente_Id = venClientes.genEntidades) On tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
left OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
left OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa And
	conAsientos.Fecha between @FechaDesde and @FechaHasta 
ORDER BY 1,2,3
GO
