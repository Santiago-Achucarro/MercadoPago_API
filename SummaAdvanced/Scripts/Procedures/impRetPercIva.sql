--impRetPercIva 1, '20220501','20220708'
DROP PROCEDURE impRetPercIva
GO
CREATE PROCEDURE impRetPercIva
(
@pEmpresa_Id INT,
@pFechaDesde DATETIME,
@pFechaHasta DATETIME
)
AS


SELECT @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones

-- Retenciones de clientes --
SELECT conAsientos.Fecha, tesIdRetClien.NroResSicore, ltrim(rtrim(genEntidades.Cuit)) Cuit, conMovcont.Importe*(-2 * TipoMov + 3) Importe, 
	tesRengMoviRetClie.ComprobanteRet, ltrim(rtrim(tesRengMoviRetClie.SucursalRet)) SucursalRet, tesRengMoviRetClie.BaseImponible, tesIdRetClien.TipoImpuesto,
	tesRengMoviRetClie.Porcentaje
FROM TesMovimientos  
INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos
INNER JOIN TesRengMovi ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN TesIdRetClien ON TesIdRetClien.Cartera_Id = TesRengMovi.Cartera_Id 
INNER JOIN venMovimientos ON TesMovimientos.tesMovimientos = venMovimientos.venMovimientos
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN genEntidades ON venClientes.genEntidades = genEntidades.genEntidades
INNER JOIN genTiposDoc ON genEntidades.TipoDoc = genTiposDoc.TipoDoc AND
	genTiposDoc.Dominio_Id = 'AR'
INNER JOIN tesRengMoviRetClie ON tesRengMoviRetclie.tesMovimientos = TesRengMovi.tesMovimientos AND
	tesRengMoviRetclie.conRenglon = TesRengMovi.conRenglon
--INNER JOIN tesMoviGravado ON TesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = TesRengMovi.tesMovimientos AND
	conMovCont.Renglon = TesRengMovi.conRenglon
INNER JOIN impTipoImpuesto ON TesIdRetClien.TipoImpuesto = impTipoImpuesto.TipoImpuesto AND
	impTipoImpuesto.TipoImpuesto = 2101
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE conAsientos.Fecha BETWEEN @pFechaDesde and @pFechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @pEmpresa_Id 
ORDER BY Fecha

-- Percepciones de proveedores --
Select genEntidades.Cuit, 493 Resolucion, conMovCont.Importe, genAsiSegmentos.Segmento1C Sucursal, genAsiSegmentos.Segmento1N Comprobante,
	genAsiSegmentos.Segmento2C TipoMov, genAsiSegmentos.Segmento4C Letra, conAsientos.Fecha
From comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Inner Join comProveedores On comMovProv.Proveed_Id = comProveedores.genEntidades
Inner Join genEntidades On genEntidades.genEntidades = comProveedores.genEntidades
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join comMovImpuestos On comMovImpuestos.comMovProv = comMovProv.comMovProv
Inner Join conMovCont On conMovCont.conAsientos = comMovImpuestos.comMovProv And conMovCont.Renglon = comMovImpuestos.conRenglon
Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Where conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And comImpuestos.TipoImpuesto = 2101 And
conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Fecha Between @pFechaDesde And @pFechaHasta
Go
