DROP PROCEDURE inf_stkRemiCD
go
CREATE PROCEDURE inf_stkRemiCD
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

SELECT stkEnTransito.stkMoviCabe, '' Cliente_Id, 0 Sucursal, 
stkDepositos.Descripcion RazonSocial, stkDepositos.Direccion Direccion1_Entr, '' Direccion2_Entr, 
PaisClie.Descripcion as PaisClie,ProvClie.Descripcion as ProvClie, genEmpresas.Cuit,
stkDepositos.Localidad Localidad_Entr,  '' NroExterior_Entr, '' NroInterior_Entr,
stkDepositos.CodigoPostal CodPostal_Entr, '' Telefonos, IsNull(gensegmentos.Segmento_Id, '') Segmento_Id,
'' ListaPrecio_Id, '' DescripcionListasPrecios, '' Moneda_Id, '' DescripcionMoneda, 0 HojaRuta_Id,
'' HojaRuta, '' Condfiscal, '' Sucursal_pe, '' Numero_pe, '' Transportista, '' DireccionTrans, 
stkDepositos.Descripcion NombreFantasia, '' CliOrdenCompra
FROM stkEnTransito
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkEnTransito.stkMoviCabe
Inner Join stkDepositos On stkDepositos.stkDepositos = stkEnTransito.Deposito_Id
INNER JOIN genSegmentos On genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
Inner Join genEmpresas On genEmpresas.genEmpresas = @pEmpresa_Id
--LEFT JOIN venListasPrecios On venListasPrecios.venListasPrecios = stkRemitos.ListaPrecio_Id
--LEFT JOIN genMonedas On genMonedas.genMonedas = venListasPrecios.Moneda_Id
--LEFT JOIN stkHojaSegmentos On stkHojaSegmentos.stkHojaDeRuta = stkRemitos.HojaRuta_Id
INNER JOIN genPaises PaisClie on PaisClie.genPaises=genEmpresas.Pais_Id
INNER JOIN genProvincias ProvClie on ProvClie.genProvincias = stkDepositos.Provincia_Id
--INNER JOIN genEntidades on venClieHabitual.genEntidades=genEntidades.genEntidades
--INNER JOIN venCondfiscal on venCondfiscal.venCondfiscal = venClientes.CondFisc_Id 

WHERE (stkmovicabe = @pstkMoviCabe)
GO



