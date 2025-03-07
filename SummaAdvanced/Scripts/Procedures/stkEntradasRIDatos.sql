-- stkEntradasRIDatos 1,'STOCK', 0,0,0,0,' ',' ',' ',' ','REQIN',1,0,0,0,'0001',' ',' ',' '


drop procedure stkEntradasRIDatos
go
create procedure stkEntradasRIDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20), 
@pSegmento_id_RI VarChar(10), 
@pSegmento1N_RI int,
@pSegmento2N_RI int,
@pSegmento3N_RI int,
@pSegmento4N_RI int,
@pSegmento1C_RI VarChar(20),
@pSegmento2C_RI VarChar(20),
@pSegmento3C_RI VarChar(20),
@pSegmento4C_RI VarChar(20)
)
AS
SET NOCOUNT ON 

DECLARE @pstkMoviCabe bigint

SET @pstkMoviCabe = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id) and
	Segmento1N =@pSegmento1N and
	Segmento2N = @pSegmento2N and
	Segmento3N = @pSegmento3N and
	Segmento4N = @pSegmento4N and
	Segmento1C = @pSegmento1C and
	Segmento2C = @pSegmento2C and 
	Segmento3C = @pSegmento3C and 
	Segmento4C = @pSegmento4C )

SELECT stkMoviCabe.stkMoviCabe,
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, Cast(0 As Bit) DistribuyeContrapartida,
	conAsientos.Posteado, conAsientos.Fecha, conAsientos.FechaRegistro, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones,  disFormularios.Formulario_Id Formulario,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	stkSubTipoMov.SubTipoMov_Id, stkSubTipoMov.Descripcion as DescripcionSubTipoMov, 
	stkMoviCabe.ModificaCosto, 	stkMoviCabe.Signo, stkSubTipoMov.Tipomov, ' ' as Proveed_Id
FROM stkMoviCabe 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = stkMoviCabe.stkMoviCabe)
INNER JOIN stkSubTipoMov  ON (stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = stkMoviCabe.stkMoviCabe
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_id = genSegmentos.genSegmentos
WHERE (stkMoviCabe = @pstkMoviCabe)


if @pstkMoviCabe is null
BEGIN
-- Traigo el Entregado de la RI --
SELECT comRISegmento.Empresa_Id, genSegmentos.Segmento_Id, 
	comRISegmento.Segmento1N, comRISegmento.Segmento2N,
	comRISegmento.Segmento3N, comRISegmento.Segmento4N,
	comRISegmento.Segmento1C, comRISegmento.Segmento2C,
	comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comReqInterno.Fecha, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres 
	
From comRISegmento 
INNER JOIN comReqInterno on comRISegmento.comReqInterno = comReqInterno.comReqInterno
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comRISegmento.Segmento_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comReqInterno.Usuario_Id
WHERE 
	
	comRISegmento.Empresa_Id =@pEmpresa_id and 
	genSegmentos.Segmento_Id = @pSegmento_id_RI and
	comRISegmento.Segmento1N =@pSegmento1N_RI and
	comRISegmento.Segmento2N = @pSegmento2N_RI and
	comRISegmento.Segmento3N = @pSegmento3N_RI and
	comRISegmento.Segmento4N = @pSegmento4N_RI and
	comRISegmento.Segmento1C = @pSegmento1C_RI and
	comRISegmento.Segmento2C = @pSegmento2C_RI and 
	comRISegmento.Segmento2C = @pSegmento2C_RI and 
	comRISegmento.Segmento3C = @pSegmento3C_RI and 
	comRISegmento.Segmento4C = @pSegmento4C_RI 
ORDER BY 2




SELECT Convert(bigint, 0) AS stkMoviCabe, comRICuerpo.Renglon_RI Renglon, 0 RenglonReferencia, 
	comRICuerpo.FechaNecesidad Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	comRIArticulo.Factor, 0.00 as Cantidad, 	0.00  as CantidadForm, 
	comRICuerpo.Precio as CostoUnitario, 
	comRIArticulo.PrecioOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna, 
	stkMedidaAlterna.Descripcion DescripcionMedidaAlterna,
	comRICuerpo.Cantidad*0 As CantidadAlternaForm, ' ' Observaciones, 0.00 as Descuento, 0 as conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	' ' as Centro1Debe, ' ' as DescripcionCentro1Debe,
	' ' as Centro2Debe, ' ' as DescripcionCentro2Debe,
	' ' as ClaseDebe, comRICuerpo.Precio*0  as ImporteContableDebe, 
	0 as conRenglonHaber, 
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conCentro1Haber.Centro1_Id  as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_Id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	' '  as ClaseHaber, comRICuerpo.Precio*0 as ImporteContableHaber, 
	comRICuerpo.Renglon_RI, comRIArticulo.CantidadOriginal as CantidadRI, comRICuerpo.CantidadRecibida, 
	comRICuerpo.Precio, '' Despacho_Id
FROM comRISegmento 
INNER JOIN comRICuerpo ON comRISegmento.comReqInterno = comRICuerpo.comReqInterno
INNER JOIN comRIArticulo ON comRICuerpo.comReqInterno = comRIArticulo.comReqInterno and comRICuerpo.Renglon_RI = comRIArticulo.Renglon_RI
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = comRIArticulo.Deposito_Id)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = comRIArticulo.Producto_Id)
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comRICuerpo.Medida_Id)
Inner Join comReqInterno On comReqInterno.comReqInterno = comRISegmento.comReqInterno
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = stkProductos.CtaCompra
LEFT OUTER JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = comRICuerpo.Centro1_id
LEFT OUTER JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = comRICuerpo.Centro2_id
left outer Join conCuentas as conCuentasHaber ON stkProductos.CtaConsumo = conCuentasHaber.conCuentas
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkProductos.MedidaAlterna
left JOIN stkArtiUM on
stkArtiUM.Producto_Id = stkProductos.stkProductos and 
stkArtiUM.Medida_Id = comRICuerpo.Medida_Id
WHERE 
	comRICuerpo.CantidadRecibida > 0 and 
	comRISegmento.Empresa_Id =@pEmpresa_id and 
	comRISegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_RI) and
	comRISegmento.Segmento1N =@pSegmento1N_RI and
	comRISegmento.Segmento2N = @pSegmento2N_RI and
	comRISegmento.Segmento3N = @pSegmento3N_RI and
	comRISegmento.Segmento4N = @pSegmento4N_RI and
	comRISegmento.Segmento1C = @pSegmento1C_RI and
	comRISegmento.Segmento2C = @pSegmento2C_RI and 
	comRISegmento.Segmento3C = @pSegmento3C_RI and 
	comRISegmento.Segmento4C = @pSegmento4C_RI 
ORDER BY 2


END

ELSE
-- Cuerpo
-- Traigo el comprobante que se está consultando --
BEGIN

SELECT comRISegmento.Empresa_Id, genSegmentos.Segmento_Id, 
	comRISegmento.Segmento1N, comRISegmento.Segmento2N,
	comRISegmento.Segmento3N, comRISegmento.Segmento4N,
	comRISegmento.Segmento1C, comRISegmento.Segmento2C,
	comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comReqInterno.Fecha, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres 

From comRISegmento 
INNER JOIN comReqInterno on comRISegmento.comReqInterno = comReqInterno.comReqInterno
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comRISegmento.Segmento_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comReqInterno.Usuario_Id


WHERE 
	Exists(select 1 from stkMoviRi where
		stkMoviRi.stkMoviCabe = @pstkMoviCabe and 
		stkMoviRi.comReqInterno =	comReqInterno.comReqInterno)
ORDER BY 2


SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, 0 RenglonReferencia, stkMoviCuerpo.Fecha,
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
	stkMoviRi.Renglon_RI, comRIArticulo.CantidadOriginal as CantidadRI, isNull(comRICuerpo.CantidadRecibida, 0) Cantidad_Recibida, 
	comRICuerpo.Precio, comDespachos.Despacho_Id
FROM stkMoviCabe 
INNER JOIN stkMoviCuerpo ON (stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe) 
Left JOIN (stkMoviRi
INNER JOIN comRICuerpo ON comRICuerpo.comReqInterno = stkMoviRi.comReqInterno and comRICuerpo.Renglon_RI = stkMoviRi.Renglon_RI
Inner Join comRIArticulo On comRIArticulo.comReqInterno = stkMoviRi.comReqInterno And comRIArticulo.Renglon_RI = stkMoviRi.Renglon_RI)
	  ON stkMoviRi.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and stkMoviRi.Renglon = stkMoviCuerpo.Renglon
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = stkMoviCuerpo.Producto_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont.Renglon = stkMoviCuerpo.conRenglonDebe)
INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont2.Renglon = stkMoviCuerpo.conRenglonHaber)
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
WHERE (stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe)
ORDER BY 2
END


Exec genAtributosGeneralesIdentityDatos @pstkMoviCabe, 'stkMoviCabe' 

Exec stkMoviSerieDatos @pstkMoviCabe

Exec stkMoviDespaDatos @pstkMoviCabe

Exec stkMoviUbicacionDatos @pstkMoviCabe
 
RETURN @@Error 

GO
