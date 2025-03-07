--impSicore 1,'20230401','20230430'
--EMP Se agrega un union para las percepciones que se genera en ventas y el codigo de impuesto 2102 17/05/2023
--tambien se tiene en cuenta el atributo 1 de impuestos que se carga el reso.sicore.
DROP PROCEDURE impSicore
GO
CREATE PROCEDURE impSicore
(
@pEmpresa_Id INT,
@pFechaDesde DATETIME,
@pFechaHasta DATETIME
)
AS

SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta

SELECT conAsientos.Fecha, tesIdRetProv.NroResSicore, genEntidades.Cuit,
conMovCont.Importe, rTrim(genAsiSegmentos.Segmento1C)+rTrim(genAsiSegmentos.Segmento3C) TipoMov,
genAsiSegmentos.Segmento2C Sucursal, genAsiSegmentos.Segmento1N Comprobante, 
tesRetProvSegmento.Segmento1N, tesRengMoviRetProv.BaseImponible Gravado, genTiposDoc.TipoDoc,
comProveedores.Ganancias, tesIdRetProv.TipoImpuesto, tesRengMoviRetProv.Porcentaje, 
tesRengMoviRetProv.BaseImponible, genPaises.Pais_Id PaisProv, gp.Pais_Id PaisEmpr,
(SELECT sum(Importe) Importe FROM conMovCont cmc WHERE cmc.conAsientos = conMovCont.conAsientos AND
cmc.TipoMov = 1) ImporteTotal, genEmpresas.RazonSocial, genEmpresas.Cuit CuitEmpr
FROM TesMovimientos  
INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos
INNER JOIN TesRengMovi ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN TesIdRetProv ON 	TesIdRetProv.Cartera_Id = TesRengMovi.Cartera_Id 
INNER JOIN comMovProv ON TesMovimientos.tesMovimientos = comMovProv.comMovProv
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN genEntidades ON comProveedores.genEntidades = genEntidades.genEntidades
INNER JOIN genTiposDoc ON genEntidades.TipoDoc = genTiposDoc.TipoDoc AND
	       genTiposDoc.Dominio_Id = 'AR'
INNER JOIN tesRengMoviRetProv ON tesRengMoviRetProv.tesMovimientos = TesRengMovi.tesMovimientos AND
	       tesRengMoviRetProv.conRenglon = TesRengMovi.conRenglon
INNER JOIN tesMoviGravado ON TesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = TesRengMovi.tesMovimientos AND
	       conMovCont.Renglon = TesRengMovi.conRenglon
INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
INNER JOIN tesRetProvSegmento ON tesRengMoviRetProv.tesMovimientos = tesRetProvSegmento.tesMovimientos AND
	       tesRengMoviRetProv.conRenglon = tesRetProvSegmento.conRenglon
INNER JOIN impTipoImpuesto ON TesIdRetProv.TipoImpuesto = impTipoImpuesto.TipoImpuesto AND
	       impTipoImpuesto.Referencia03 = 'RET' AND impTipoImpuesto.Referencia02 IN ('GAN')
INNER JOIN genPaises ON comProveedores.Pais = genPaises.genPaises
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genPaises gp ON genEmpresas.Pais_Id = gp.genPaises
WHERE conAsientos.Fecha BETWEEN @pFechaDesde and @pFechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @pEmpresa_Id 
UNION ALL
SELECT conAsientos.Fecha, round(Isnull(a.Nrosicore,0),0) NroSicore, genEntidades.Cuit,
conMovCont.Importe, rTrim(genAsiSegmentos.Segmento1C)+rTrim(genAsiSegmentos.Segmento3C) TipoMov,
genAsiSegmentos.Segmento2C Sucursal, genAsiSegmentos.Segmento1N Comprobante, 
genAsiSegmentos.Segmento1N, venMovimpuestos.BaseImponible Gravado, genTiposDoc.TipoDoc,
cast(1 as bit) Ganancias, venImpuestos.TipoImpuesto, venMovImpuestos.Porcentaje,
venMovImpuestos.BaseImponible, genPaises.Pais_Id PaisProv, gp.Pais_Id PaisEmpr,
(SELECT sum(Importe) Importe FROM conMovCont cmc WHERE cmc.conAsientos = conMovCont.conAsientos AND
cmc.TipoMov = 1) ImporteTotal, genEmpresas.RazonSocial, genEmpresas.Cuit CuitEmpr
FROM venMovimientos
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
INNER JOIN venMovimpuestos ON venMovimientos.venMovimientos = venMovImpuestos.venMovimientos
INNER JOIN venImpuestos ON venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN genEntidades ON venClientes.genEntidades = genEntidades.genEntidades
INNER JOIN genTiposDoc ON genEntidades.TipoDoc = genTiposDoc.TipoDoc AND
	  	   genTiposDoc.Dominio_Id = 'AR'
INNER JOIN conMovCont ON conMovCont.conAsientos = venMovimientos.venMovimientos AND
		   conMovCont.Renglon = venMovimpuestos.conRenglon
INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
INNER JOIN impTipoImpuesto ON venImpuestos.TipoImpuesto = impTipoImpuesto.TipoImpuesto AND
		   impTipoImpuesto.Referencia03 = 'RET' AND impTipoImpuesto.TipoImpuesto = 2102
INNER JOIN venClieHabitual on venCliehabitual.genEntidades = venClientes.genEntidades and venClientes.SucursalPredeter = venClieHabitual.Sucursal
INNER JOIN genPaises ON venClieHabitual.Pais_Id_Entr = genPaises.genPaises
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genPaises gp ON genEmpresas.Pais_Id = gp.genPaises
INNER JOIN (select venImpuestos.venImpuestos,ValorN Nrosicore from genAtributosGenerales
INNER JOIN genAtributosValores on genAtributosGenerales.AtributoNro = genAtributosValores.AtributoNro and 
		   genAtributosGenerales.Tabla_Id = genAtributosValores.Tabla_Id
Inner Join venImpuestos on genAtributosValores.Identity_Id = venImpuestos.venImpuestos
		   WHERE genAtributosGenerales.Tabla_Id='venImpuestos') A on A.venImpuestos = venImpuestos.venImpuestos
WHERE conAsientos.Fecha BETWEEN @pFechaDesde and @pFechaHasta AND 
conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
conAsientos.Empresa_Id = @pEmpresa_Id 
ORDER BY Fecha
GO




