-- Inf_stkHojaDeRuta 1,'HOJADERUTA',1,0,0,0,'CCG',' ',' ',' '
--SELECT * FROM stkRemitos WHERE HojaRuta_Id IS NOT NULL
DROP Procedure Inf_stkHojaDeRuta
GO
Create Procedure Inf_stkHojaDeRuta
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)

AS

SELECT 
dbo.Segmento(stkHojaSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, 
stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, 
stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N, stkHojaSegmentos.Segmento3N, 
stkHojaSegmentos.Segmento4N) AS HojaDeRuta, 
venClieHabitual.CodPostal_Entr as CodigoPostal, 
venClientes.Cliente_Id, venClientes.RazonSocial, venClieHabitual.NombreFantasia, 
venClieHabitual.Direccion1_Entr as Calle, venClieHabitual.NroExterior_Entr AS NroExterior, 
venClieHabitual.NroInterior_Entr AS NroInterior, venClieHabitual.Direccion2_Entr as Colonia, 
venClieHabitual.Localidad_Entr AS Localidad, genProvincias.Descripcion as Estado, 
genPaises.Descripcion AS Pais,
'Remito' as Tipo, 
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
genAsiSegmentos.Segmento4N) AS Comprobante, 
conAsientos.Fecha, venCamiones.Patente_Id, venCamiones.Descripcion as DescripcionCamion, 
Acoplado.Patente_Id PatenteAcoplado , Acoplado.Descripcion as DescripcionAcoplado, 
venFormaEntrega.FormaEntrega_Id , venFormaEntrega.RazonSocial as DescripcionFormaEntrega
, stkHojaDeRuta.FechaRegistro, stkHojaDeRuta.Chofer
from stkHojaSegmentos 
	INNER JOIN stkHojaDeRuta ON stkHojaDeRuta.stkHojaDeRuta = stkHojaSegmentos.stkHojaDeRuta
	INNER JOIN stkRemitos ON  stkRemitos.HojaRuta_Id = stkHojaDeRuta.stkHojaDeRuta
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = stkHojaSegmentos.Segmento_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = stkRemitos.stkMoviCabe 
	INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = stkRemitos.Cliente_Id AND 
								  venClieHabitual.Sucursal =  stkRemitos.Sucursal
	INNER JOIN venClientes ON  venClientes.genEntidades = venClieHabitual.genEntidades
	INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Entr
	INNER JOIN genPaises ON genPaises.genPaises = venClieHabitual.Pais_Id_Entr
	LEFT JOIN venCamiones ON venCamiones.venCamiones = stkHojaDeRuta.Patente_Id
	LEFT JOIN venCamiones as Acoplado ON Acoplado.venCamiones = stkHojaDeRuta.PatenteAcoplado
	LEFT JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
WHERE
	genSegmentos.Segmento_Id = @pSegmento_Id AND 
	stkHojaSegmentos.Segmento1C = @pSegmento1C AND
	stkHojaSegmentos.Segmento2C = @pSegmento2C AND
	stkHojaSegmentos.Segmento3C = @pSegmento3C AND
	stkHojaSegmentos.Segmento4C = @pSegmento4C AND
	stkHojaSegmentos.Segmento1N = @pSegmento1N AND
	stkHojaSegmentos.Segmento2N = @pSegmento2N AND
	stkHojaSegmentos.Segmento3N = @pSegmento3N AND
	stkHojaSegmentos.Segmento4N = @pSegmento4N AND
	stkHojaSegmentos.Empresa_Id = @pEmpresa_Id
UNION ALL
SELECT 
dbo.Segmento(stkHojaSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, 
stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, 
stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N, stkHojaSegmentos.Segmento3N, 
stkHojaSegmentos.Segmento4N) AS HojaDeRuta, 
venClieHabitual.CodPostal_Entr as CodigoPostal, 
venClientes.Cliente_Id, venClientes.RazonSocial, venClieHabitual.NombreFantasia, 
venClieHabitual.Direccion1_Entr as Calle, venClieHabitual.NroExterior_Entr AS NroExterior, 
venClieHabitual.NroInterior_Entr AS NroInterior, venClieHabitual.Direccion2_Entr as Colonia, 
venClieHabitual.Localidad_Entr AS Localidad, genProvincias.Descripcion as Estado, 
genPaises.Descripcion AS Pais,
'Factura' as Tipo, 
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
genAsiSegmentos.Segmento4N) AS Comprobante, 
conAsientos.Fecha, venCamiones.Patente_Id, venCamiones.Descripcion as DescripcionCamion, 
Acoplado.Patente_Id PatenteAcoplado , Acoplado.Descripcion as DescripcionAcoplado, 
venFormaEntrega.FormaEntrega_Id , venFormaEntrega.RazonSocial as DescripcionFormaEntrega
, stkHojaDeRuta.FechaRegistro, stkHojaDeRuta.Chofer
from stkHojaSegmentos 
	INNER JOIN stkHojaDeRuta ON stkHojaDeRuta.stkHojaDeRuta = stkHojaSegmentos.stkHojaDeRuta
	INNER JOIN stkHojaDeRutaCuerpo ON stkHojaDeRuta.stkHojaDeRuta = stkHojaDeRutaCuerpo.stkHojaDeRuta
	INNER JOIN venMovimientos ON  venMovimientos.venMovimientos = stkHojaDeRutaCuerpo.conAsientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = stkHojaSegmentos.Segmento_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id AND 
								  venClieHabitual.Sucursal =  venMovimientos.Sucursal
	INNER JOIN venClientes ON  venClientes.genEntidades = venClieHabitual.genEntidades
	INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Entr
	INNER JOIN genPaises ON genPaises.genPaises = venClieHabitual.Pais_Id_Entr
	LEFT JOIN venCamiones ON venCamiones.venCamiones = stkHojaDeRuta.Patente_Id
	LEFT JOIN venCamiones as Acoplado ON Acoplado.venCamiones = stkHojaDeRuta.PatenteAcoplado
	LEFT JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venMovimientos.FormaEntrega_Id
WHERE
	genSegmentos.Segmento_Id = @pSegmento_Id AND 
	stkHojaSegmentos.Segmento1C = @pSegmento1C AND
	stkHojaSegmentos.Segmento2C = @pSegmento2C AND
	stkHojaSegmentos.Segmento3C = @pSegmento3C AND
	stkHojaSegmentos.Segmento4C = @pSegmento4C AND
	stkHojaSegmentos.Segmento1N = @pSegmento1N AND
	stkHojaSegmentos.Segmento2N = @pSegmento2N AND
	stkHojaSegmentos.Segmento3N = @pSegmento3N AND
	stkHojaSegmentos.Segmento4N = @pSegmento4N AND
	stkHojaSegmentos.Empresa_Id = @pEmpresa_Id
ORDER BY 2,6,7

GO

