-- Inf_comImpPagados 1, '20200101','20200630', ' ','zzzz',' ','ZZZZ'

DROP PROCEDURE Inf_comImpPagados
GO
CREATE PROCEDURE Inf_comImpPagados
(
	@Empresa_id int, 
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ImpuestoDesde VarChar(5),
	@ImpuestoHasta VarChar(5), 
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15)
)
AS

SELECT comImpuestos.Impuesto_Id, comImpuestos.Descripcion AS DescripcionImpuesto,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genEntidades.Cuit AS Rfc, 
	conAsientos.Fecha, asiPago.Fecha as FechaCobra,
	dbo.Segmento(genAsiSegmentosC.Segmento_Id, genAsiSegmentosC.Segmento1C, 
	genAsiSegmentosC.Segmento2C, genAsiSegmentosC.Segmento3C, genAsiSegmentosC.Segmento4C, 
	genAsiSegmentosC.Segmento1N, genAsiSegmentosC.Segmento2N, genAsiSegmentosC.Segmento3N, 
	genAsiSegmentosC.Segmento4N) as Pago,
	asiFactura.Fecha AS FechaFactura,
	dbo.Segmento(genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C, 
	genAsiSegmentosF.Segmento2C, genAsiSegmentosF.Segmento3C, genAsiSegmentosF.Segmento4C, 
	genAsiSegmentosF.Segmento1N, genAsiSegmentosF.Segmento2N, genAsiSegmentosF.Segmento3N, 
	genAsiSegmentosF.Segmento4N) as Factura, 
	tesIdentifica.Cartera_Id, 
	SUM(comMovImpAcredita.BaseImponible) AS BaseImponible , 
	SUM(comMovImpAcredita.Monto) AS Monto , 
	SUM(comMovImpAcredita.DifCambio) AS DifCambio, 
	SUM(comMovImpAcredita.TotalPago) AS TotalPago, 
		comMovProv.ClaveFiscal
	
FROM 
	comMovImpAcredita inner join comMovprov ON 
	comMovImpAcredita.comMovProv = comMovprov.comMovprov
	INNER JOIN comProveedores ON
	comProveedores.genEntidades = comMovProv.Proveed_Id
	INNER JOIN conAsientos asiFactura ON
	asiFactura.conAsientos = comMovProv.comMovProv
	inner join conAsientos ON
	conAsientos.conAsientos = comMovImpAcredita.Asiento_Id
	inner join tesMovimientos ON
	tesMovimientos.tesMovimientos = comMovImpAcredita.tesMovimientos
	inner join conAsientos AS asiPago ON
	asiPago.conAsientos = tesMovimientos.tesMovimientos
	inner join genAsiSegmentos AS genAsiSegmentosf ON
	genAsiSegmentosf.Asiento_Id = comMovProv.comMovProv
	INNER JOIN genAsiSegmentos as genAsiSegmentosC ON
	genAsiSegmentosC.Asiento_Id = tesMovimientos.tesMovimientos
	INNER JOIN comImpuestos ON
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_Id
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = comMovImpAcredita.Cartera_Id
	INNER JOIN genEntidades ON
	genEntidades.genEntidades = comProveedores.genEntidades 

WHERE
	conAsientos.Anulado = 0 and 
	asiFactura.Anulado = 0 and 
	asiPago.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_id And 
	comProveedores.Proveed_Id between @ProveedDesde And @ProveedHasta and 
	comImpuestos.Impuesto_Id between @ImpuestoDesde And @ImpuestoHasta AND 
	conAsientos.Fecha between @FechaDesde And @FechaHasta
group by comImpuestos.Impuesto_Id, comImpuestos.Descripcion ,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genEntidades.Cuit , 
	conAsientos.Fecha, asiPago.Fecha ,
	genAsiSegmentosC.Segmento_Id, genAsiSegmentosC.Segmento1C, 
	genAsiSegmentosC.Segmento2C, genAsiSegmentosC.Segmento3C, genAsiSegmentosC.Segmento4C, 
	genAsiSegmentosC.Segmento1N, genAsiSegmentosC.Segmento2N, genAsiSegmentosC.Segmento3N, 
	genAsiSegmentosC.Segmento4N,
	asiFactura.Fecha ,
	genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C, 
	genAsiSegmentosF.Segmento2C, genAsiSegmentosF.Segmento3C, genAsiSegmentosF.Segmento4C, 
	genAsiSegmentosF.Segmento1N, genAsiSegmentosF.Segmento2N, genAsiSegmentosF.Segmento3N, 
	genAsiSegmentosF.Segmento4N, 
	tesIdentifica.Cartera_Id, comMovProv.ClaveFiscal
UNION ALL
SELECT comImpuestos.Impuesto_Id, comImpuestos.Descripcion AS DescripcionImpuesto,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genEntidades.Cuit AS Rfc, 
	conAsientos.Fecha, asiPago.Fecha as FechaCobra,
	dbo.Segmento(genAsiSegmentosC.Segmento_Id, genAsiSegmentosC.Segmento1C, 
	genAsiSegmentosC.Segmento2C, genAsiSegmentosC.Segmento3C, genAsiSegmentosC.Segmento4C, 
	genAsiSegmentosC.Segmento1N, genAsiSegmentosC.Segmento2N, genAsiSegmentosC.Segmento3N, 
	genAsiSegmentosC.Segmento4N) as Pago,
	asiFactura.Fecha AS FechaFactura,
	dbo.Segmento(genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C, 
	genAsiSegmentosF.Segmento2C, genAsiSegmentosF.Segmento3C, genAsiSegmentosF.Segmento4C, 
	genAsiSegmentosF.Segmento1N, genAsiSegmentosF.Segmento2N, genAsiSegmentosF.Segmento3N, 
	genAsiSegmentosF.Segmento4N) as Factura, 
	' 'Cartera_Id, 
	SUM(comMovImpuestos.Base_Imponible) Base_Imponible, 
	SUM(comMovImpuestos.Importe_Impuesto), 0, SUM(comMovprov.Importe),
	comMovProv.ClaveFiscal
	
FROM 
	comMovprov 	
	INNER JOIN comProveedores ON
	comProveedores.genEntidades = comMovProv.Proveed_Id
	INNER JOIN conAsientos asiFactura ON
	asiFactura.conAsientos = comMovProv.comMovProv
	INNER JOIN tesRengMovicomMovProv ON
	tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
	inner join conAsientos ON
	conAsientos.conAsientos = tesRengMovicomMovProv.tesMovimientos
	inner join tesMovimientos ON
	tesMovimientos.tesMovimientos = tesRengMovicomMovProv.tesMovimientos
	inner join conAsientos AS asiPago ON
	asiPago.conAsientos = tesMovimientos.tesMovimientos
	inner join genAsiSegmentos AS genAsiSegmentosf ON
	genAsiSegmentosf.Asiento_Id = comMovProv.comMovProv
	INNER JOIN genAsiSegmentos as genAsiSegmentosC ON
	genAsiSegmentosC.Asiento_Id = tesMovimientos.tesMovimientos
	INNER JOIN comMovImpuestos ON 
	comMovImpuestos.comMovProv =  comMovProv.comMovProv
	INNER JOIN comImpuestos ON
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	INNER JOIN genEntidades ON
	genEntidades.genEntidades = comProveedores.genEntidades 
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	asiFactura.Anulado = 0 and 
	asiFactura.Posteado = 1 and 
	asiPago.Anulado = 0 and 
	asiPago.Posteado = 1 and 
	comImpuestos.PorAcreditacion = 1 and 
	conAsientos.Empresa_Id = @Empresa_id And 
	comProveedores.Proveed_Id between @ProveedDesde And @ProveedHasta and 
	comImpuestos.Impuesto_Id between @ImpuestoDesde And @ImpuestoHasta AND 
	conAsientos.Fecha between @FechaDesde And @FechaHasta
group by comImpuestos.Impuesto_Id, comImpuestos.Descripcion ,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genEntidades.Cuit , 
	conAsientos.Fecha, asiPago.Fecha ,
	genAsiSegmentosC.Segmento_Id, genAsiSegmentosC.Segmento1C, 
	genAsiSegmentosC.Segmento2C, genAsiSegmentosC.Segmento3C, genAsiSegmentosC.Segmento4C, 
	genAsiSegmentosC.Segmento1N, genAsiSegmentosC.Segmento2N, genAsiSegmentosC.Segmento3N, 
	genAsiSegmentosC.Segmento4N,
	asiFactura.Fecha ,
	genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C, 
	genAsiSegmentosF.Segmento2C, genAsiSegmentosF.Segmento3C, genAsiSegmentosF.Segmento4C, 
	genAsiSegmentosF.Segmento1N, genAsiSegmentosF.Segmento2N, genAsiSegmentosF.Segmento3N, 
	genAsiSegmentosF.Segmento4N, 
	comMovProv.ClaveFiscal
order by 1,3,5 
GO



