
--- exec stkEntradasCancRemiPend 1, 'STOCK',0,0,0,0,' ',' ',' ',' ','REM', 45397,0,0,0,'CCG',' ',' ',' '
DROP PROCEDURE stkEntradasCancRemiPend
GO
CREATE PROCEDURE stkEntradasCancRemiPend
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
@pSegmento4C VarChar(20),
@pSegmento_IdRemi VarChar(10), 
@pSegmento1NRemi int,
@pSegmento2NRemi int,
@pSegmento3NRemi int,
@pSegmento4NRemi int,
@pSegmento1CRemi VarChar(20),
@pSegmento2CRemi VarChar(20),
@pSegmento3CRemi VarChar(20),
@pSegmento4CRemi VarChar(20)

)
AS

DECLARE @pStkmoviCabe Bigint

SET @pStkmoviCabe = (SELECT Asiento_Id FROM genAsiSegmentos 
			INNER JOIN genSegmentos ON genSegmentos.genSegmentos =genAsiSegmentos.Segmento_Id
			Where
				genSegmentos.Segmento_Id = @pSegmento_Id and 
				genAsiSegmentos.Segmento1N = @pSegmento1N and
				genAsiSegmentos.Segmento2N = @pSegmento2N and
				genAsiSegmentos.Segmento3N = @pSegmento3N and
				genAsiSegmentos.Segmento4N = @pSegmento4N and
				genAsiSegmentos.Segmento1C = @pSegmento1C and
				genAsiSegmentos.Segmento2C = @pSegmento2C and
				genAsiSegmentos.Segmento3C = @pSegmento3C and
				genAsiSegmentos.Segmento4C = @pSegmento4C and
				genAsiSegmentos.Empresa_Id = @pEmpresa_Id)

Exec stkMoviCabeSoloDatos @pStkmoviCabe


if @pstkMoviCabe is null
BEGIN

-- Traigo el pendiente de recepción de la OC --
SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	conAsientos.Fecha, venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, Cast(0.00 as Numeric(18,2)) as Total
From genAsiSegmentos
INNER JOIN stkRemitos on genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN venClientes ON venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos =genAsiSegmentos.Asiento_Id 
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE 
	genAsiSegmentos.Empresa_Id =@pEmpresa_id and 
	genSegmentos.Segmento_Id = @pSegmento_IdRemi and
	genAsiSegmentos.Segmento1N =@pSegmento1NRemi and
	genAsiSegmentos.Segmento2N = @pSegmento2NRemi and
	genAsiSegmentos.Segmento3N = @pSegmento3NRemi and
	genAsiSegmentos.Segmento4N = @pSegmento4NRemi and
	genAsiSegmentos.Segmento1C = @pSegmento1CRemi and
	genAsiSegmentos.Segmento2C = @pSegmento2CRemi and 
	genAsiSegmentos.Segmento3C = @pSegmento3CRemi and 
	genAsiSegmentos.Segmento4C = @pSegmento4CRemi
ORDER BY 2




SELECT Convert(bigint, 0) AS stkMoviCabe, stkMoviCuerpo.Renglon,  stkMoviCuerpo.Renglon RenglonReferencia, 
	conAsientos.Fecha Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad*0  as Cantidad,
	stkMoviCuerpo.Cantidad*0 as CantidadForm, stkMoviCuerpo.CostoUnitario as CostoUnitario, 
	stkMoviCuerpo.PrecioOriginal PrecioOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna, 
	stkMedidaAlterna.Descripcion DescripcionMedidaAlterna,
	stkMoviCuerpo.CantidadAlternaForm As CantidadAlternaForm, stkMoviCuerpo.Observaciones, stkMoviCuerpo.Descuento, 
	0 as conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	' '  as Centro1Debe, ' ' as DescripcionCentro1Debe,
	' ' as Centro2Debe, ' ' as DescripcionCentro2Debe,
	' ' as ClaseDebe, stkMoviCuerpo.Cantidad*0  as ImporteContableDebe, 
	0 as conRenglonHaber, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	' ' as Centro1Haber, ' ' as DescripcionCentro1Haber,
	' ' as Centro2Haber, ' ' as DescripcionCentro2Haber,
	' '  as ClaseHaber, stkMoviCuerpo.Cantidad*0 as ImporteContableHaber, 
	stkMoviCuerpo.Renglon Renglon_oc, stkMoviCuerpo.Cantidad as CantidadOC, stkRemiPendFact.CantidadPendiente  , 
	 stkMoviCuerpo.PrecioOriginal Precio, ISNULL((SELECT MAX(comDespachos.Despacho_Id) from 
		stkMoviDespa INNER JOIN comDespachos ON 
		stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		stkMoviDespa.Renglon = stkMoviCuerpo.Renglon and 
		comDespachos.comDespachos = stkMoviDespa.Despacho_Id) ,	 '') Despacho_Id
FROM 
genAsiSegmentos Inner join genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
Inner join stkMoviCabe ON stkMoviCabe.stkMoviCabe = genAsiSegmentos.Asiento_Id
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN stkDepositos  ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkProductos  ON stkMoviCuerpo.Producto_Id =  stkProductos.stkProductos
INNER JOIN stkUniMed  ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
Inner Join stkRemitos On stkRemitos.stkMoviCabe = stkMoviCabe.stkMoviCabe
Inner join conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
Left Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN conMovCont conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe and 
										conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conMovCont conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe and 
										conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.Cuenta_Id
INNER JOIN conCuentas conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.Cuenta_Id
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkProductos.MedidaAlterna
INNER join stkRemiPendFact ON stkRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
							 stkRemiPendFact.Renglon = 	stkMoviCuerpo.Renglon
WHERE 
	stkRemiPendFact.CantidadPendiente  > 0 and 
	genAsiSegmentos.Empresa_Id =@pEmpresa_id and 
	genSegmentos.Segmento_Id = @pSegmento_idRemi and
	genAsiSegmentos.Segmento1N =@pSegmento1NRemi and
	genAsiSegmentos.Segmento2N = @pSegmento2NRemi and
	genAsiSegmentos.Segmento3N = @pSegmento3NRemi and
	genAsiSegmentos.Segmento4N = @pSegmento4NRemi and
	genAsiSegmentos.Segmento1C = @pSegmento1CRemi and
	genAsiSegmentos.Segmento2C = @pSegmento2CRemi and 
	genAsiSegmentos.Segmento3C = @pSegmento3CRemi and 
	genAsiSegmentos.Segmento4C = @pSegmento4CRemi 
ORDER BY 2


END

ELSE
-- Cuerpo
-- Traigo el comprobante que se está consultando --
BEGIN


-- Traigo el pendiente de recepción de la OC --
SELECT  genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	conAsientos.Fecha, venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, (stkMoviCuerpo.CantidadForm * stkMoviCuerpo.PrecioOriginal) as Total
From genAsiSegmentos
INNER JOIN stkRemitos on genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN venClientes ON venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos =genAsiSegmentos.Asiento_Id 
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN stkEntradasCancRemi ON 
	stkEntradasCancRemi.stkMoviCabeRemi = stkRemitos.stkMoviCabe 
INNER JOIN stkMoviCuerpo ON  stkMoviCuerpo.stkMoviCabe = stkEntradasCancRemi.stkMoviCabeEntrada and 
	stkMoviCuerpo.Renglon = stkEntradasCancRemi.RenglonEntrada

WHERE 
	stkEntradasCancRemi.stkMoviCabeEntrada = @pStkmoviCabe


SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, stkEntradasCancRemi.RenglonRemi RenglonReferencia, stkMoviCuerpo.Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkProductos.Producto_Id, 
	stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad,
	stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal,
	stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion DescripcionMedidaAlterna,
	stkMoviCuerpo.CantidadalternaForm, stkMoviCuerpo.Observaciones, stkMoviCuerpo.Descuento, 
	stkMoviCuerpo.conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_Id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_Id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	conMovContDebe.Clase as ClaseDebe, conMovContDebe.Importe as ImporteContableDebe, 
	stkMoviCuerpo.conRenglonHaber, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conCentro1Haber.Centro1_id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber , 
	stkEntradasCancRemi.RenglonRemi  Renglon_oc, 
	stkEntradasCancRemi.Cantidad as CantidadOC,  stkEntradasCancRemi.Cantidad CantidadPendiente,
	stkMoviCuerpo.PrecioOriginal  as Precio, comDespachos.Despacho_Id
FROM stkMoviCabe 
INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
INNER JOIN stkEntradasCancRemi ON stkEntradasCancRemi.stkMoviCabeEntrada = stkMoviCuerpo.stkMoviCabe AND 
					stkEntradasCancRemi.RenglonEntrada = stkMoviCuerpo.Renglon
INNER JOIN stkDepositos  ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
LEFT JOIN stkProductos  ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
LEFT JOIN stkUniMed  ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN conMovCont  ON (conMovCont.conAsientos = stkMoviCuerpo.stkMoviCabe) AND 
						(conMovCont.Renglon = stkMoviCuerpo.conRenglonDebe)
INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = stkMoviCuerpo.stkMoviCabe) AND 
						(conMovCont2.Renglon = stkMoviCuerpo.conRenglonHaber)
INNER JOIN conMovCont as conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.cuenta_id 
LEFT OUTER  JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = conMovContDebe.Centro1_id
LEFT OUTER  JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = conMovContDebe.Centro2_id
INNER JOIN conMovCont as conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.cuenta_id 
LEFT OUTER JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = conMovContHaber.Centro1_id
LEFT OUTER JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = conMovContHaber.Centro2_id
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
left join (stkMoviDespa  INNER JOIN comDespachos ON stkMoviDespa.Despacho_Id = comDespachos.comDespachos) ON 
	stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
	stkMoviDespa.Renglon = stkMoviCuerpo.Renglon
WHERE 
(stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe)
ORDER BY 2
END



Exec genAtributosGeneralesIdentityDatos @pstkMoviCabe, 'stkMoviCabe' 

Exec stkMoviSerieDatos @pstkMoviCabe

Exec stkMoviDespaDatos @pstkMoviCabe
	-- PARA V2
Exec stkMoviUbicacionDatos  @pStkMoviCabe


