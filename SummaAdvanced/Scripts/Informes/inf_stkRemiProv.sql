--exec  inf_stkRemitos 5,'STOCK',24961,0,0,0,'E','LCC',' ',' '

DROP procedure inf_stkRemitos
GO
create procedure inf_stkRemitos
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
Declare @pstkMoviCabe bigint = (Select Asiento_id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )



SELECT stkMoviProv.stkMoviCabe, comProveedores.Proveed_Id, 
	comProveedores.RazonSocial as DescripcionProveedores,
	stkMoviProv.RemitoProv, stkMoviProv.FechaRemito, 
	 genEntidades.Cuit, comProveedores.Direccion1, comProveedores.Direccion2, 
	comProveedores.Localidad, comProveedores.CodigoPostal, comProveedores.EMail
	,genProvincias.Descripcion as Provincia, genPaises.Descripcion as Pais
FROM stkMoviProv 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkMoviProv.stkMoviCabe)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = stkMoviProv.Proveed_Id)
INNER JOIN genEntidades ON  genEntidades.genEntidades = comProveedores.genEntidades
INNER JOIN genProvincias ON  genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON  genPaises.genPaises = comProveedores.Pais
WHERE 
(stkMoviProv.stkMoviCabe = @pstkMoviCabe)