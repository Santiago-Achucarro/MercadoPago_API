drop procedure inf_comOrdenCompCuerpo
go
create procedure inf_comOrdenCompCuerpo
(
@Empresa_Id int,
@Segmento_Id VarChar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
set nocount on
DECLARE @pComOrdenComp as Int
SET @pComOrdenComp = (SELECT comOrdenComp 
	FROM comOCSegmentos WHERE 
	(Empresa_Id = @Empresa_Id) AND 
	(Segmento_Id = dbo.FuncFkgenSegmentos(@Segmento_Id)) AND 
	(Segmento1N = @Segmento1N) AND 
	(Segmento2N = @Segmento2N) AND 
	(Segmento3N = @Segmento3N) AND 
	(Segmento4N = @Segmento4N) AND 
	(Segmento1C = @Segmento1C) AND 
	(Segmento2C = @Segmento2C) AND 
	(Segmento3C = @Segmento3C) AND 
	(Segmento4C = @Segmento4C))
SELECT comOCArticulo.comOrdenComp, comOCArticulo.Renglon_OC, stkProductos.Producto_Id,
	stkProductos.Descripcion + isnull(comOCCuerpo.Observaciones,'') 
	as DescripcionProductos, comOCArticulo.Factor, comOCArticulo.CantidadOriginal, comOCArticulo.PrecioOriginal,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	comOCCuerpo.Cantidad, comOCCuerpo.Cantidad_Recibida, comOcCuerpo.Cantidad_Embarcada,
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega, comOCCuerpo.Precio, comOCCuerpo.Pendiente,
	comOCCuerpo.Cantidad_Creditos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2
FROM comOCArticulo 
INNER JOIN comOCCuerpo  ON (comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comOCArticulo.Renglon_OC)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = comOCArticulo.Producto_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = comOCArticulo.Deposito_Id)
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOCCuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comOCCuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comOCCuerpo.Centro2_Id)
where (comOCArticulo.comOrdenComp = @pcomOrdenComp)
AND (comOCArticulo.Renglon_OC = comOCArticulo.Renglon_oc)
union
SELECT comOCMemo.comOrdenComp, comOCMemo.Renglon_OC,'' as Producto_Id, comOCMemo.Detalle as DescripcionProductos,1 as Factor,
comOCCuerpo.Cantidad as CantidadOriginal,comOCCuerpo.Precio as PrecioOriginal,null as Deposito_Id,'' as DescripcionDepositos,
	comOCCuerpo.Cantidad, comOCCuerpo.Cantidad_Recibida, comOcCuerpo.Cantidad_Embarcada,
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega, comOCCuerpo.Precio, comOCCuerpo.Pendiente,
	comOCCuerpo.Cantidad_Creditos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2
FROM comOCMemo 
INNER JOIN comOCCuerpo  ON (comOCCuerpo.comOrdenComp = comOCMemo.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comOCMemo.Renglon_OC)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comOCMemo.Cuenta_Id)
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOCCuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comOCCuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comOCCuerpo.Centro2_Id)
WHERE (comOCMemo.comOrdenComp = @pcomOrdenComp)
AND (comOCMemo.Renglon_OC = comOCMemo.Renglon_oc)
go
