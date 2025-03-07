
-- stkEntradasEmbarqueDatos 1, 'STK',0,0,0,0,' ',' ',' ',' ','EMB',2,0,0,0,'0004',' ',' ',' ', 'E0001E'
-- stkEntradasEmbarqueDatos 1, 'STOCK',82,0,0,0,'E','0002',' ',' ','EMB',0,0,0,0,' ',' ',' ',' ', ' '


Drop procedure stkEntradasEmbarqueDatos
Go
Create procedure stkEntradasEmbarqueDatos
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
@pSegmento_Id_Emb VarChar(10), 
@pSegmento1N_Emb int,
@pSegmento2N_Emb int,
@pSegmento3N_Emb int,
@pSegmento4N_Emb int,
@pSegmento1C_Emb VarChar(20),
@pSegmento2C_Emb VarChar(20),
@pSegmento3C_Emb VarChar(20),
@pSegmento4C_Emb VarChar(20),
@pProveed_Id varChar(25)
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
	stkMoviCabe.ModificaCosto, 	stkMoviCabe.Signo, stkSubTipoMov.Tipomov, ' ' as Proveed_Id, ' ' Cliente_Id
FROM stkMoviCabe 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = stkMoviCabe.stkMoviCabe)
INNER JOIN stkSubTipoMov  ON (stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = stkMoviCabe.stkMoviCabe
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_id = genSegmentos.genSegmentos
WHERE (stkMoviCabe = @pstkMoviCabe)


-- Busco el cuerpo de un movimiento ya existente --
SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, stkMoviOC.Renglon_OC RenglonReferencia, stkMoviCuerpo.Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad,
	stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal,
	stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion as DescripcionMedidaAlterna,
	stkMoviCuerpo.CantidadAlternaForm,
	stkMoviCuerpo.Observaciones, stkMoviCuerpo.Descuento, stkMoviCuerpo.conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	conMovContDebe.Clase as ClaseDebe, conMovContDebe.Importe as ImporteContableDebe, 
	stkMoviCuerpo.conRenglonHaber, 
	conCuentasHaber.Cuenta_id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conCentro1Haber.Centro1_id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber, comDespachos.Despacho_Id,
	stkMoviOc.comOrdenComp,
	stkMoviCuerpo.Cantidad*0 CantidadEmb, comEmbCuerpo.CantidadOriginal CantidadOriginalEmb, stkMoviCuerpo.Cantidad*0 CantidadRecibidaEmb,
	stkMoviCuerpo.CostoUnitario PrecioSinGastos,  '' PegarSeries
FROM stkMoviCuerpo 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe)
Inner JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id)
Inner JOIN stkProductos  ON (stkProductos.stkProductos = stkMoviCuerpo.Producto_Id)
Inner JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id)
INNER JOIN conMovCont as conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.cuenta_id 
LEFT JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = conMovContDebe.Centro1_id
LEFT JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = conMovContDebe.Centro2_id
INNER JOIN conMovCont as conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.cuenta_id 
LEFT JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = conMovContHaber.Centro1_id
LEFT JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = conMovContHaber.Centro2_id
LEFT JOIN stkUniMed stkMedidaAlterna ON stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
Left Join stkMoviDespa On stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And stkMoviDespa.Renglon = stkMoviCuerpo.Renglon
Left Join comDespachos On comDespachos.comDespachos = stkMoviDespa.Despacho_Id
Inner Join stkMoviEmbarque On stkMoviEmbarque.stkMoviCabe = stkMoviCabe.stkMoviCabe
Inner Join stkMoviOC On stkMoviOC.stkMoviCabe = stkMoviCabe.stkMoviCabe And stkMoviOC.Renglon = stkMoviCuerpo.Renglon
Inner Join comEmbCuerpo On comEmbCuerpo.comOrdenComp = stkMoviOC.comOrdenComp And 
	comEmbCuerpo.Renglon_OC = stkMoviOC.Renglon_OC and 
	comEmbCuerpo.comEmbarques = stkMoviEmbarque.comEmbarques
WHERE stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe
union all
-- Armo el cuerpo seg?n el cuerpo pendiente de la OE --
SELECT Cast(0 As bigint) stkMoviCabe, 
	Cast(ROW_NUMBER() OVER( ORDER BY comOrdenComp.comOrdenComp, comEmbCuerpo.Renglon_OC) as int) - 1 Renglon, 
	comEmbCuerpo.Renglon_OC RenglonReferencia, comOCCuerpo.Fecha_Entrega Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, comOCArticulo.Factor, comOcCuerpo.Cantidad*0 Cantidad,
	0 CantidadForm, comEmbCuerpo.PrecioCalculado CostoUnitario, comEmbCuerpo.PrecioCalculadoOriginal as PrecioOriginal,
	stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion as DescripcionMedidaAlterna,
	comOCCuerpo.Cantidad*0 CantidadAlternaForm,
	'' Observaciones, 0 Descuento, 0 conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	'' ClaseDebe, 0 ImporteContableDebe, 0 conRenglonHaber, 
	'' CuentaHaber, '' DescripcionCuentaHaber, '' Centro1Haber, '' DescripcionCentro1Haber,
	'' Centro2Haber, '' DescripcionCentro2Haber, '' ClaseHaber, 0 ImporteContableHaber, '' Despacho_Id,
	comOrdenComp.comOrdenComp, 
	comEmbCuerpo.Cantidad CantidadEmb, comEmbCuerpo.CantidadOriginal CantidadOriginalEmb, comEmbCuerpo.CantidadRecibida CantidadRecibidaEmb, 
	comOCCuerpo.Precio PrecioSinGastos, '' PegarSeries
FROM comEmbCuerpo
Inner Join comOrdenComp On comOrdenComp.comOrdenComp = comEmbCuerpo.comOrdenComp
Inner Join comOcCuerpo On comOCCuerpo.comOrdenComp = comEmbCuerpo.comOrdenComp And comOCCuerpo.Renglon_OC = comEmbCuerpo.Renglon_OC
Inner Join comOCArticulo On comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp And comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
Inner JOIN stkDepositos ON stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
Inner JOIN stkProductos ON stkProductos.stkProductos = comOCArticulo.Producto_Id
Inner JOIN stkUniMed ON stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = stkProductos.CtaCompra
LEFT JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = comOCCuerpo.Centro1_id
LEFT JOIN conCentro2 as conCentro2Debe ON conCentro2Debe.conCentro2 = comOCCuerpo.Centro2_id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comEmbCuerpo.comEmbarques
Left Join stkUniMed stkMedidaAlterna ON stkMedidaAlterna.stkUniMed = stkProductos.MedidaAlterna
WHERE 
comOrdenComp.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And
comEmbCuerpo.Cantidad > comEmbCuerpo.CantidadRecibida And 
genAsiSegmentos.Empresa_Id = @pEmpresa_id And 
genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id_Emb) And
genAsiSegmentos.Segmento1N = @pSegmento1N_Emb And
genAsiSegmentos.Segmento2N = @pSegmento2N_Emb And
genAsiSegmentos.Segmento3N = @pSegmento3N_Emb And
genAsiSegmentos.Segmento4N = @pSegmento4N_Emb And
genAsiSegmentos.Segmento1C = @pSegmento1C_Emb And
genAsiSegmentos.Segmento2C = @pSegmento2C_Emb And 
genAsiSegmentos.Segmento3C = @pSegmento3C_Emb And 
genAsiSegmentos.Segmento4C = @pSegmento4C_Emb and 
@pstkMoviCabe IS NULL
ORDER BY 2

Select genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, comProveedores.Proveed_Id, comProveedores.RazonSocial,
	stkMoviEmbarque.RemitoProv, comDespachos.Despacho_Id
From stkMoviEmbarque
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviEmbarque.comEmbarques
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join comProveedores On comProveedores.genEntidades = stkMoviEmbarque.Proveed_Id
Inner Join comDespachos On comDespachos.comDespachos = stkMoviEmbarque.Despacho_Id
Where stkMoviEmbarque.stkMoviCabe = @pstkMoviCabe

Exec genAtributosGeneralesIdentityDatos @pstkMoviCabe, 'stkMoviCabe' 

Exec stkMoviSerieDatos @pstkMoviCabe

Exec stkMoviDespaDatos @pstkMoviCabe

-- V2
Exec stkMoviUbicacionDatos @pstkMoviCabe

Go

