-- proPendientesProd '20190820', 1, '20190820'
DROP PROCEDURE proPendientesProd
go
CREATE PROCEDURE proPendientesProd(

	@FechaHasta DateTime, 
	@Empresa_Id Int,
	@Fecha DateTime = NULL

)

as

select Producto_Id, Descripcion, 	Medida_Id, Deposito_Id,
	CtroProd_Id, DescripcionCentroProd,
	CostoUltCompra, Existencia,  Fecha, 
	SUM(Consumo) as Consumo, SUM(Produccion) as Produccion
from (
	SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
		stkUniMed.Medida_Id, stkDepositos.Deposito_Id, 
		(Convert(numeric(18,4), proOrdenProd.Cantidad 	* proOrden.Cantidad / (proOrden.Cantidad - proOrden.CantidadTerminada) *
			case when proOrdenProd.EntradaSalida ='P' THEN 1 ELSE 0 END )) as Produccion,
		(Convert(numeric(18,4), proOrdenProd.Cantidad 	* proOrden.Cantidad / (proOrden.Cantidad - proOrden.CantidadTerminada) *
			case when proOrdenProd.EntradaSalida ='P' THEN 0 ELSE 1 END )) as Consumo, 
			proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionReceta, 
			proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion DescripcionCentroProd, 
			stkProductos.CostoUltCompra, stkExistencia.Cantidad as Existencia, 
			ISNULL(@Fecha, proOrden.FechaNecesidad) as Fecha

	From proOrden 
	INNER JOIN proOrdenProd ON proOrden.proOrden = proOrdenProd.proOrden
	INNER JOIN stkProductos ON stkProductos.stkProductos = proOrdenProd.Producto_Id
	INNER JOIN stkUniMed ON stkUniMed.stkUniMed = proOrdenProd.Medida_Id
	INNER JOIN proOrdenSegmento ON proOrdenSegmento.proOrden = proOrden.proOrden
	INNER JOIN stkDepositos ON stkDepositos.stkDepositos =  proOrdenProd.Deposito_Id
	INNER JOIN proRecetas ON proRecetas.proRecetas = proOrden.Receta_Id
	INNER JOIN proCentroProductivo ON proCentroProductivo.proCentroProductivo = proOrden.CtroProd_Id
	LEFT JOIN stkExistencia ON stkExistencia.Deposito_Id= proOrdenProd.Deposito_Id and stkExistencia.Producto_Id = proOrdenProd.Producto_Id
	Where
		proOrden.Cantidad > proOrden.CantidadTerminada And
		proOrdenSegmento.Empresa_Id = @Empresa_Id and 
		proOrden.FechaNecesidad < @FechaHasta

	) as xxx

group by Producto_Id, Descripcion, 	Medida_Id, Deposito_Id,
	CtroProd_Id, DescripcionCentroProd,	CostoUltCompra, Existencia,  Fecha 
HAVING 	sum(Consumo - Produccion) <> 0
ORDER BY 1,4