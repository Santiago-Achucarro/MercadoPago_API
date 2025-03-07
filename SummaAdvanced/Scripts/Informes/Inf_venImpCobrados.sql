-- Inf_venImpCobrados 5, '20220401','20220430', ' ','zzzz',' ','ZZZZ'

DROP PROCEDURE Inf_venImpCobrados
GO
CREATE PROCEDURE Inf_venImpCobrados
(
	@Empresa_id int, 
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ImpuestoDesde VarChar(5),
	@ImpuestoHasta VarChar(5), 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15)
)
AS

SELECT venImpuestos.Impuesto_Id, venImpuestos.Descripcion AS DescripcionImpuesto,
	ISNULL(venClientes.Cliente_Id,'') Cliente_Id, 
	ISNULL(venClientes.RazonSocial,'Deposito No Identificado') RazonSocial, 
	conAsientos.Fecha, asiCobranza.Fecha as FechaCobra,
	dbo.Segmento(genAsiSegmentosC.Segmento_Id, genAsiSegmentosC.Segmento1C, 
	genAsiSegmentosC.Segmento2C, genAsiSegmentosC.Segmento3C, genAsiSegmentosC.Segmento4C, 
	genAsiSegmentosC.Segmento1N, genAsiSegmentosC.Segmento2N, genAsiSegmentosC.Segmento3N, 
	genAsiSegmentosC.Segmento4N) as Cobranza,
	ISNULL(asiFactura.Fecha,@FechaDesde)   AS FechaFactura,
	isnull(dbo.Segmento(genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C, 
	genAsiSegmentosF.Segmento2C, genAsiSegmentosF.Segmento3C, genAsiSegmentosF.Segmento4C, 
	genAsiSegmentosF.Segmento1N, genAsiSegmentosF.Segmento2N, genAsiSegmentosF.Segmento3N, 
	genAsiSegmentosF.Segmento4N),'') as Factura, 
	tesIdentifica.Cartera_Id, Banco.Cartera_Id as Banco, 
	venMovImpTraslado.BaseImponible, venMovImpTraslado.Monto+ venMovImpTraslado.DifCambio Monto, 
	venMovImpTraslado.DifCambio, 	venMovImpTraslado.TotalCobro,
	ISNULL(venMovimientosFiscal.ClaveFiscal,'') AS UUID
	
FROM 
	venMovImpTraslado LEFT join venMovimientos ON 
	venMovImpTraslado.venMovimientos = venMovimientos.venMovimientos
	left JOIN venClientes ON
	venClientes.genEntidades = venMovimientos.Cliente_Id
	left JOIN conAsientos asiFactura ON
	asiFactura.conAsientos = venMovimientos.venMovimientos
	inner join conAsientos ON
	conAsientos.conAsientos = venMovImpTraslado.Asiento_Id
	inner join tesMovimientos ON
	tesMovimientos.tesMovimientos = venMovImpTraslado.tesMovimientos
	inner join conAsientos AS asiCobranza ON
	asiCobranza.conAsientos = tesMovimientos.tesMovimientos
	left join genAsiSegmentos AS genAsiSegmentosf ON
	genAsiSegmentosf.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN genAsiSegmentos as genAsiSegmentosC ON
	genAsiSegmentosC.Asiento_Id = tesMovimientos.tesMovimientos
	INNER JOIN venImpuestos ON
	venImpuestos.venImpuestos = venMovImpTraslado.Impuesto_Id
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = venMovImpTraslado.Cartera_Id
	left join tesIdentifica as Banco ON 
	Banco.tesIdentifica = venMovImpTraslado.Banco_Id
	LEFT join venMovimientosFiscal ON  venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
WHERE
	conAsientos.Anulado = 0 and 
	ISNULL(asiFactura.Anulado,0) = 0 and 
	asiCobranza.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_id And 
	ISNULL(venClientes.Cliente_Id,'') between @ClienteDesde And @ClienteHasta and 
	venImpuestos.Impuesto_Id between @ImpuestoDesde And @ImpuestoHasta AND 
	conAsientos.Fecha between @FechaDesde And @FechaHasta 
order by 1,3,5 
GO

