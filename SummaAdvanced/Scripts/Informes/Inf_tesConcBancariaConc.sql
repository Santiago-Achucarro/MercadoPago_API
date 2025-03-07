

-- Inf_tesConcBancariaConc 'BX870', '20200301', '20200331', 1
DROP PROCEDURE Inf_tesConcBancariaConc
GO

CREATE PROCEDURE Inf_tesConcBancariaConc
(
	@Cartera_Id VarChar(5), 
	@FechaDesde DateTime,
	@FechaHasta DateTime, 
	@Empresa_Id Int
)
AS
SELECT conAsientos.Fecha,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion,  tesSubTiposMov.SubTipo_Id,
	ISNULL(tesCheqProp.aLaOrden,tesSubTiposMov.Descripcion) as DescripcionMOV,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	case when tesRengMovi.TipomovCont = 1 then 	tesRengConcilEsp.Importe else 0 end  Debe,
	case when tesRengMovi.TipomovCont = 2 then 	tesRengConcilEsp.Importe else 0 end  Haber,
	tesRengConcilEsp.NumeroConc, conAsientos.Observaciones, 
	ISNULL(ISNULL(venClientes.Cliente_id, comProveedores.Proveed_id),' ') as Entidad, 
	ISNULL(ISNULL(venClientes.RazonSocial, comProveedores.RazonSocial),' ') as DescripcionEntidad,
	ISNULL(tesCheqProp.Chequera_Id,0) Chequera_Id, ISNULL(tesCheqProp.numCheque,0) numCheque
From tesIdentifica 
INNER JOIN tesRengMovi ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN tesRengConcilEsp ON tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and
					tesRengConcilEsp.conRenglon =tesRengMovi.conRenglon
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos 
INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov =tesMovimientos.SubTipo_Id
LEFT JOIN (comMovprov INNER JOIN comProveedores ON comMovprov.Proveed_id = comProveedores.genEntidades) ON 
comMovprov.comMovprov = conASientos.conAsientos
LEFT JOIN (venMovimientos INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades) ON 
venMovimientos.venMovimientos = conASientos.conAsientos

LEFT JOIN (tesBPlink INNER JOIN tesCheqProp ON tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp) ON 
	tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos AND
	tesRengMovi.conRenglon = tesBPlink.conRenglon
WHERE
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	tesIdentifica.Cartera_Id = @Cartera_Id 
ORDER BY 1,2
	