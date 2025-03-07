-- EXEC Inf_comOrdenCompRI ' ','zzz','20200101','20201130',' ','zz',' ','ZZZ',1  WITH RECOMPILE


DROP Procedure Inf_comOrdenCompRI
GO
CREATE Procedure Inf_comOrdenCompRI(

	@ProveedorDesde VarChar(15),
	@ProveedorHasta VarChar(15),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ProductoDesde VarChar(25), 
	@ProductoHasta VarChar(25),
	@SolicitoDesde VarChar(25),
	@SolicitoHasta VarChar(25),
	@Empresa_Id Int
)
AS
select dbo.Segmento( comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, 
comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, 
comOCSegmentos.Segmento4N) as OrdenCompra, 
comOCCuerpo.Renglon_OC,
comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
ISNULL(stkProductos.Producto_Id,'') AS Producto_Id, 
ISNULL(stkProductos.Descripcion, comOCMemo.Detalle) as Descripcion, 
comOCCuerpo.Cantidad, comOCCuerpo.Precio, 
Convert(Numeric(18,2), comOCCuerpo.Cantidad * comOCCuerpo.Precio) as SubTotal, 
dbo.Segmento( comRISegmento.Segmento_Id, comRISegmento.Segmento1C, 
comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, 
comRISegmento.Segmento4N) as Requicision, 
comRICuerpo.Cantidad as Pedidos, genUsuarios.Usuario_Id as Solicito
from comOCSegmentos 
INNER JOIN comOrdenComp ON comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_Id
INNER JOIN comOCCuerpo ON  comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comOCRI ON comOCRI.comOrdenComp =comOCCuerpo.comOrdenComp AND 
		comOCRI.Renglon_OC =comOCCuerpo.Renglon_OC
INNER JOIN comRICuerpo ON comRICuerpo.comReqInterno = comOCRI.comReqInterno and 
		comRICuerpo.Renglon_RI = comOCRI.Renglon_RI
LEFT JOIN (comOCArticulo  inner join stkProductos 
	ON stkProductos.stkProductos  = comOCArticulo.Producto_Id)
	ON comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp AND 
			comOCCuerpo.Renglon_OC =  comOCArticulo.Renglon_OC
Left join comOCMemo ON comOCCuerpo.comOrdenComp = comOCMemo.comOrdenComp AND 
			comOCCuerpo.Renglon_OC =  comOCMemo.Renglon_OC
Inner join comRISegmento on comRISegmento.comReqInterno =comOCRI.comReqInterno
INNER JOIN comReqInterno ON comReqInterno.comReqInterno = comOCRI.comReqInterno
INNER JOIN genUsuarios ON genUsuarios.genUsuarios =comReqInterno.Usuario_Id
Where
	comProveedores.Proveed_Id BETWEEN @ProveedorDesde AND @ProveedorHasta AND 
	comOCSegmentos.Empresa_Id = @Empresa_Id AND 
	comOrdenComp.Fecha Between @FechaDesde and @FechaHasta and 
	comOrdenComp.Estado_Id != 'R' and 
	ISNULL(stkProductos.Producto_Id,' ') Between @ProductoDesde and @ProductoHasta and 
	genUsuarios.Usuario_Id Between @SolicitoDesde and @SolicitoHasta
ORDER BY 1,2
GO




