DROP PROCEDURE inf_stkRemiClie
go
CREATE PROCEDURE inf_stkRemiClie
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
SELECT stkRemitos.stkMoviCabe, venClientes.Cliente_Id, stkRemitos.Sucursal, 
venClientes.RazonSocial, venClieHabitual.Direccion1_Entr,venClieHabitual.Direccion2_Entr, 
PaisClie.Descripcion as PaisClie,ProvClie.Descripcion as ProvClie, genEntidades.Cuit,
venClieHabitual.Localidad_Entr,venClieHabitual.NroExterior_Entr,venClieHabitual.NroInterior_Entr,
venClieHabitual.CodPostal_Entr, venClieHabitual.Telefonos, IsNull(gensegmentos.Segmento_Id, '') Segmento_Id,
venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion DescripcionListasPrecios,
genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda, stkRemitos.HojaRuta_Id,
dbo.Segmento(stkHojaSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, stkHojaSegmentos.Segmento2C,
stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N, 
stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N) HojaRuta, venCondfiscal.Descripcion Condfiscal, 
isnull(stkpedidos.Sucursal_pe,'') Sucursal_pe, isnull(stkpedidos.numero_pe,'') Numero_pe, 
ISNULL(stkPedidos.Transportista,' ') Transportista, ISNULL(stkPedidos.DireccionTrans,'') DireccionTrans, 
venClieHabitual.NombreFantasia, ISNULL(stkPedidos.CliOrdenCompra,' ') CliOrdenCompra
FROM stkRemitos
INNER JOIN venClieHabitual On stkRemitos.Cliente_Id = venClieHabitual.genEntidades And
	stkRemitos.Sucursal = venClieHabitual.Sucursal
INNER JOIN venClientes On venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN genSegmentos On stkRemitos.Segmento_Id = genSegmentos.genSegmentos
LEFT JOIN venListasPrecios On venListasPrecios.venListasPrecios = stkRemitos.ListaPrecio_Id
LEFT JOIN genMonedas On genMonedas.genMonedas = venListasPrecios.Moneda_Id
LEFT JOIN stkHojaSegmentos On stkHojaSegmentos.stkHojaDeRuta = stkRemitos.HojaRuta_Id
INNER JOIN genPaises PaisClie on PaisClie.genPaises=venClieHabitual.Pais_Id_Entr
INNER JOIN genProvincias ProvClie on ProvClie.genProvincias=venClieHabitual.Provincia_Id_Entr
INNER JOIN genEntidades on venClieHabitual.genEntidades=genEntidades.genEntidades
INNER JOIN venCondfiscal on 
venCondfiscal.venCondfiscal = venClientes.CondFisc_Id 
LEFT JOIN (SELECT venPediSegmentos.Empresa_id,segmento1c Sucursal_pe,segmento1n Numero_pe, 
stkmovicabe Movicabe, count(*) total, venFormaEntrega.RazonSocial Transportista, 
venFormaEntrega.Direccion DireccionTrans, venPedidos.CliOrdenCompra
FROM venPediRemitidos
INNER JOIN venPediSegmentos ON venPediRemitidos.venpedidos = venPediSegmentos.venPedidos
INNER JOIN venPedidos ON venPediSegmentos.venPedidos = venPedidos.venPedidos
INNER JOIN venFormaEntrega ON venPedidos.FormaEntrega_Id = venFormaEntrega.venFormaEntrega
WHERE venPediSegmentos.Empresa_Id = @pEmpresa_Id
GROUP BY venPediSegmentos.Empresa_id, segmento1c,segmento1n, stkmovicabe, 
venFormaEntrega.RazonSocial, venFormaEntrega.Direccion, venPedidos.CliOrdenCompra) AS  stkPedidos ON
stkpedidos.MoviCabe = stkremitos.stkmovicabe
WHERE (stkmovicabe = @pstkMoviCabe)
GO



