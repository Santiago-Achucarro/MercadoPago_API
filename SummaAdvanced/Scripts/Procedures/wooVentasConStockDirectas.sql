--wooVentasConStockDirectas 1,'',0,0,0,0,'','','',''
DROP PROCEDURE wooVentasConStockDirectas
GO
CREATE PROCEDURE wooVentasConStockDirectas
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
SET NOCOUNT ON
declare @pIdentity bigint
set @pIdentity=(select Asiento_Id from genAsiSegmentos where 
genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
exec venMovimientosConStockDatos @pEmpresa_Id, @pSegmento_Id, @pSegmento1N, @pSegmento2N, @pSegmento3N, @pSegmento4N, @pSegmento1C, @pSegmento2C, @pSegmento3C, @pSegmento4C
--select ' ' as ParaPegar


declare @Efectivo VarChar(5) = isnull((SELECT CVALOR FROM genGlobales where Nombre_Var='TESCARTEFE' and Empresa_Id=@pEmpresa_Id),'PESOS')
declare @Cheque VarChar(5) = isnull((SELECT CVALOR FROM genGlobales where Nombre_Var='TESCARTCHEQUES' and Empresa_Id=@pEmpresa_Id),'CHEQU')
declare @Tarjeta VarChar(5) = isnull((SELECT CVALOR FROM genGlobales where Nombre_Var='TESCARTTARJ' and Empresa_Id=@pEmpresa_Id),'TARJ')

declare @Dolares VarChar(5) = isnull((SELECT CVALOR FROM genGlobales where Nombre_Var='TESCARTUSD' and Empresa_Id=@pEmpresa_Id),'USD')

SELECT 
	sum(case when tesIdentifica.Cartera_Id= @Efectivo THEN conMovCont.ImporteMonedaOriginal ELSE 0 END) as Efectivo, 
	sum(case when tesIdentifica.Cartera_Id= @Cheque THEN conMovCont.ImporteMonedaOriginal ELSE 0 END) as Cheque, 
	sum(case when tesIdentifica.Cartera_Id = @Tarjeta THEN conMovCont.ImporteMonedaOriginal ELSE 0 END) as Tarjeta,
	cast(0 as bit) as Credito,
	sum(case when tesIdentifica.Cartera_Id = @Dolares THEN conMovCont.ImporteMonedaOriginal ELSE 0 END) as USD,
	sum(case when tesIdentifica.Cartera_Id NOT IN(@Efectivo, @Tarjeta, @Cheque, @Dolares) THEN conMovCont.ImporteMonedaOriginal ELSE 0 END) as Otro, 
	tesCheqTerceros.numCheque ,tesCheqTerceros.FechaVencimiento as FechaCheque, 
	tesBancos.Banco_Id, tesBancos.Descripcion as DescripcionBanco,
	venMovimientosMetodoPago.MetodoPago, genEntidadesBasicasValor.Descripcion as DescripcionMetodoPago

from genCancMov inner join genAsiSegmentos ON 
genAsiSegmentos.Asiento_Id = genCancMov.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
inner join tesRengMovi ON tesRengMovi.tesMovimientos = genCancMov.Asiento_Id_ap
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and
conMovCont.Renglon = tesRengMovi.conRenglon INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica =  tesRengMovi.Cartera_Id
LEFT JOIN (tesCTlink INNER JOIN tesCheqTerceros ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros
INNER JOIN tesBancos ON tesBancos.tesBancos = tesCheqTerceros.Banco_Id) 
on tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos and tesCTlink.conRenglon = tesRengMovi.conRenglon
left join venMovimientosMetodoPago on venMovimientosMetodoPago.venMovimientos=genAsiSegmentos.Asiento_Id
left join genEntidadesBasicasValor on venMovimientosMetodoPago.MetodoPago=genEntidadesBasicasValor.Clave and 
genEntidadesBasicasValor.Entidad_Id=6 and genEntidadesBasicasValor.Dominio_Id='MX'
Where
genAsiSegmentos.Asiento_Id=@pIdentity
GROUP BY tesCheqTerceros.numCheque ,tesCheqTerceros.FechaVencimiento ,	tesBancos.Banco_Id, 
	tesBancos.Descripcion , MetodoPago, genEntidadesBasicasValor.Descripcion

	select venClieHabitual.Direccion1_Entr, Direccion2_Entr, Localidad_Entr, PaisEntr.Pais_Id as Pais_Id_Entr, PaisEntr.Descripcion as DescripcionPais_Entr,
	CodPostal_Entr, NroInterior_Entr, NroExterior_Entr, ProvinciaEntr.Provincia_Id as Provincia_Id_Entr, ProvinciaEntr.Descripcion as DescripcionProvincia_Entr,
	venClientes.Cliente_Id, venClientes.RazonSocial, venClieHabitual.Direccion1_Fact, Direccion2_Fact, Localidad_Fact,
	PaisFact.Pais_Id as Pais_Id_Fact, PaisFact.Descripcion as DescripcionPais_Fact, Email, venVendedores.Vendedor_Id, venVendedores.Nombre, CodPostal_Fact,
	venClieHabitual.NroInterior_Fact, venClieHabitual.NroExterior_Fact, ProvinciaFact.Provincia_Id as Provincia_Id_Fact, 
	ProvinciaFact.Descripcion as DescripcionProvincia_Fact, venClieHabitual.Telefonos, genEntidades.Cuit, venCondFiscal.CondFisc_Id, 
	venCondFiscal.Descripcion as DescripcionCondFiscal, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago
	
	from venClientes 
	inner join venMovimientos on venMovimientos.Cliente_Id=venClientes.genEntidades
	inner join venClieHabitual on venClieHabitual.genEntidades= venClientes.genEntidades
	inner join genPaises PaisFact on PaisFact.genPaises=venClieHabitual.Pais_Id_Fact
	inner join genPaises PaisEntr on PaisEntr.genPaises=venClieHabitual.Pais_Id_Entr
	inner join venVendedores on venClieHabitual.Vendedor_Id=venVendedores.venVendedores
	inner join genProvincias ProvinciaFact on ProvinciaFact.genProvincias=venClieHabitual.Provincia_Id_Fact
	inner join genProvincias ProvinciaEntr on ProvinciaEntr.genProvincias=venClieHabitual.Provincia_Id_Entr
	inner join genEntidades on genEntidades.genEntidades=venClientes.genEntidades
	inner join venCondFiscal on venClientes.CondFisc_Id=venCondFiscal.venCondFiscal
	inner join venCondPago on venCondPago.venCondPago=venClieHabitual.CondPagoCli_Id
	where venMovimientos.venMovimientos=@pIdentity

GO
