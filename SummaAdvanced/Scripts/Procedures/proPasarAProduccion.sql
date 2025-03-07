-- proPasarAProduccionDatos ' ', 'ZZZ','20190801', '20190831', 1

DROP Procedure proPasarAProduccionDatos 
GO
Create Procedure proPasarAProduccionDatos 
(
	@CentroProdDesde VarChar(8),
	@CentroProdHasta VarChar(8),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id Int
)

AS

Select @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, @FechaHasta as FechaProduccion, 
	@CentroProdDesde as CentroProdDesde,  @CentroProdHasta as CentroProdHasta

SELECT Cast(0 as Bit) as Marca, 
	proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCentro,
	proOrden.proOrden, 
	dbo.Segmento(proOrdenSegmento.Segmento_Id,   proOrdenSegmento.Segmento1C, 
	proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C, 
	proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N,
	proOrdenSegmento.Segmento4N) as Segmento_Str,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	proOrden.CantidadIngresada as Cantidad, stkUniMed.Medida_Id


FROM proOrden
INNER JOIN proOrdenSegmento ON proOrden.proOrden = proOrdenSegmento.proOrden
INNER JOIN stkProductos ON stkProductos.stkProductos = proOrden.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = proOrden.Medida_Id
INNER JOIN proRecetas ON proRecetas.proRecetas = proOrden.Receta_Id
INNER JOIN proCentroProductivo ON proCentroProductivo.proCentroProductivo = proOrden.CtroProd_Id
Where
	proOrden.FechaProduccion IS NULL AND 
	proOrdenSegmento.Empresa_Id = @Empresa_Id and 
	proCentroProductivo.CtroProd_Id BETWEEN @CentroProdDesde AND @CentroProdHasta AND
	proOrden.FechaEmision BETWEEN @FechaDesde And @FechaHasta
ORDER BY 2,5
GO


DROP Procedure proPasarAProduccionGuardar
GO
Create Procedure proPasarAProduccionGuardar
(
	@proOrden INT, 
	@FechaProduccion DateTime, 
	@pUsuario_Id Int

)
AS

Update proOrden SET FechaProduccion = @FechaProduccion, Usuario_Id = @pUsuario_Id 
Where
	proOrden = @proOrden
GO
