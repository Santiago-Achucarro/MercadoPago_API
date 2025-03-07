DROP PROCEDURE comEmbCuerpoGuardar
GO
CREATE PROCEDURE comEmbCuerpoGuardar
(
@pcomEmbarques bigint,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pCantidadRecibida qCantidadD8,
@pCantidadFacturada qCantidadD8,
@pPrecioCalculadoOriginal qMonedaD8,
@pPrecioCalculado qMonedaD8,
@pRenglonDebe int ,
@pRenglonHaber int 
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comEmbCuerpo WHERE (comEmbarques = @pcomEmbarques) AND (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)))
BEGIN 
	UPDATE comEmbCuerpo
	SET		Cantidad = @pCantidad,
		CantidadOriginal = @pCantidadOriginal,
		CantidadRecibida = @pCantidadRecibida,
		CantidadFacturada = @pCantidadFacturada,
		PrecioCalculadoOriginal = @pPrecioCalculadoOriginal,
		PrecioCalculado = @pPrecioCalculado,
		RenglonDebe = @pRenglonDebe,
		RenglonHaber = @pRenglonHaber
	WHERE (comEmbarques = @pcomEmbarques) AND (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)
END 
ELSE 
BEGIN 
	INSERT INTO comEmbCuerpo
	(
		comEmbarques,
		comOrdenComp,
		Renglon_OC,
		Cantidad,
		CantidadOriginal,
		CantidadRecibida,
		CantidadFacturada,
		PrecioCalculadoOriginal,
		PrecioCalculado,
		RenglonDebe,
		RenglonHaber
	)
	VALUES 
	(
		@pcomEmbarques,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantidad,
		@pCantidadOriginal,
		@pCantidadRecibida,
		@pCantidadFacturada,
		@pPrecioCalculadoOriginal,
		@pPrecioCalculado,
		@pRenglonDebe,
		@pRenglonHaber
	)
END 

GO

DROP PROCEDURE comEmbCuerpoDatos
GO
CREATE PROCEDURE comEmbCuerpoDatos
(
@pcomEmbarques bigint,
@pcomOrdenComp int = Null,
@pRenglon_OC int = Null
)
AS
SET NOCOUNT ON 

SELECT comEmbCuerpo.comEmbarques, comEmbCuerpo.comOrdenComp, 
	dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C,comOCSegmentos.Segmento2C, 
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N,
	comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) AS SegmentoStr,

	-- No se usa y no está en el DS --
	--dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
	--genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
	--genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS SegmentoStrEmb,

	comEmbCuerpo.Renglon_OC, 
	stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProductos, comOCArticulo.Factor,
	comOCArticulo.CantidadOriginal CantidadOcOriginal, comOcArticulo.PrecioOriginal PrecioOcOriginal, comOCCuerpo.Precio PrecioOc,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion DescripcionDepositos, stkUniMed.Medida_Id,
	comEmbCuerpo.Cantidad, comEmbCuerpo.CantidadOriginal, comEmbCuerpo.CantidadRecibida, comEmbCuerpo.CantidadFacturada,
	comEmbCuerpo.PrecioCalculadoOriginal, comEmbCuerpo.PrecioCalculado, comEmbCuerpo.RenglonDebe, comEmbCuerpo.RenglonHaber,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveed
	/*, conCuentasDebe.Cuenta_Id, conCuentasDebe.Descripcion DescripcionCuentaDebe,*/

FROM comEmbCuerpo 
INNER JOIN comEmbarques  ON (comEmbarques.comEmbarques = comEmbCuerpo.comEmbarques)
INNER JOIN comOCCuerpo  ON (comOCCuerpo.comOrdenComp = comEmbCuerpo.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comEmbCuerpo.Renglon_OC)
Inner Join comOCArticulo On comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp And comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
Inner Join stkProductos On stkProductos.stkProductos = comOCArticulo.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
inner join comOCSegmentos on comOCSegmentos.comOrdenComp = comEmbCuerpo.comOrdenComp
inner join comOrdenComp on comOrdenComp.comOrdenComp=comEmbCuerpo.comOrdenComp
inner join comProveedores on comProveedores.genEntidades=comOrdenComp.Proveed_Id
INNER JOIN genAsiSegmentos ON comEmbarques.comEmbarques = genAsiSegmentos.Asiento_Id
/*
Inner Join conMovCont conMovContDebe On conMovContDebe.conAsientos = comEmbCuerpo.comEmbarques And
	conMovContDebe.Renglon = comEmbCuerpo.RenglonDebe
Inner Join conCuentas conCuentasDebe On conCuentasDebe.conCuentas = conMovContDebe.Cuenta_Id
Left Join conCentro1 conCentro1Debe On conCentro1Debe.conCentro1 = conMovContDebe.Centro1_Id
Left Join conCentro2 conCentro2Debe On conCentro2Debe.conCentro2 = conMovContDebe.Centro2_Id
Inner Join conMovCont conMovContHaber On conMovContHaber.conAsientos = comEmbCuerpo.comEmbarques And
	conMovContHaber.Renglon = comEmbCuerpo.RenglonHaber
Inner Join conCuentas conCuentasHaber On conCuentasHaber.conCuentas = conMovContDebe.Cuenta_Id
Left Join conCentro1 conCentro1Haber On conCentro1Haber.conCentro1 = conMovContDebe.Centro1_Id
Left Join conCentro2 conCentro2Haber On conCentro2Haber.conCentro2 = conMovContDebe.Centro2_Id
*/
WHERE comEmbCuerpo.comEmbarques = @pcomEmbarques
AND comEmbCuerpo.comOrdenComp = IsNull(@pcomOrdenComp, comEmbCuerpo.comOrdenComp)
AND comEmbCuerpo.Renglon_OC = IsNull(@pRenglon_OC, comEmbCuerpo.Renglon_OC)
ORDER BY comEmbCuerpo.comOrdenComp, comEmbCuerpo.Renglon_OC
 
RETURN @@Error 

GO


DROP PROCEDURE comEmbCuerpoEliminar
GO
CREATE PROCEDURE comEmbCuerpoEliminar
(
@pcomEmbarques int,
@pcomOrdenComp int = Null,
@pRenglon_OC int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comEmbCuerpo 
WHERE comEmbCuerpo.comEmbarques = @pcomEmbarques
AND comEmbCuerpo.comOrdenComp = IsNull(@pcomOrdenComp, comEmbCuerpo.comOrdenComp)
AND comEmbCuerpo.Renglon_OC = IsNull(@pRenglon_OC, comEmbCuerpo.Renglon_OC)
 
RETURN @@Error 

GO

DROP PROCEDURE comEmbCuerpoRecibir
GO

CREATE PROCEDURE comEmbCuerpoRecibir
(
@pcomEmbarques int,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
As

UPDATE comEmbCuerpo Set CantidadRecibida = CantidadRecibida + @pCantidad
	Where comEmbarques = @pcomEmbarques And
		comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC	
GO

DROP PROCEDURE comEmbCuerpoFacturar
GO

CREATE PROCEDURE comEmbCuerpoFacturar
(
@pcomEmbarques int,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
As

UPDATE comEmbCuerpo Set CantidadFacturada = CantidadFacturada + @pCantidad
	Where comEmbarques = @pcomEmbarques And
		comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC	
GO

DROP PROCEDURE comOCEmbCuerpoTraeOC
GO
CREATE PROCEDURE comOCEmbCuerpoTraeOC (
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

SELECT comOCCuerpo.comOrdenComp,  comOCCuerpo.Renglon_OC, 
	dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C,comOCSegmentos.Segmento2C, 
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N,
	comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) AS SegmentoStr,
	stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProductos, comOCArticulo.Factor,
	comOCArticulo.CantidadOriginal CantidadOcOriginal, comOcArticulo.PrecioOriginal PrecioOcOriginal, 
	comOCCuerpo.Precio PrecioOc, (comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Embarcada) / comOCArticulo.Factor AS CantidadPendiente,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion DescripcionDepositos, stkUniMed.Medida_Id
FROM 
comOCCuerpo Inner Join comOCArticulo On comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp And comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
Inner Join stkProductos On stkProductos.stkProductos = comOCArticulo.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
inner join comOCSegmentos on comOCSegmentos.comOrdenComp = comOCCuerpo.comOrdenComp
inner join genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
WHERE 
	comOCCuerpo.Cantidad > comOCCuerpo.Cantidad_Embarcada AND 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	comOCSegmentos.Segmento1N = @pSegmento1N and 
	comOCSegmentos.Segmento2N = @pSegmento2N and 
	comOCSegmentos.Segmento3N = @pSegmento3N and 
	comOCSegmentos.Segmento4N = @pSegmento4N and 
	comOCSegmentos.Segmento1C = @pSegmento1C and 
	comOCSegmentos.Segmento2C = @pSegmento2C and 
	comOCSegmentos.Segmento3C = @pSegmento3C and 
	comOCSegmentos.Segmento4C = @pSegmento4C and
	comOCSegmentos.Empresa_Id = @pEmpresa_Id
ORDER BY 2

 
GO