--INF_proOrdencabe 1,'PORD',1032,0,0,0,'0001','','',''
--EMP Le agregue el numero de pedido al sp para el informe.17/05/2023
DROP PROCEDURE INF_proOrdencabe
GO
CREATE PROCEDURE INF_proOrdencabe  (
    @Empresa_Id int, 
    @Segmento_Id VarChar(10), 
    @Segmento1N int,
    @Segmento2N int,
    @Segmento3N int,
    @Segmento4N int,
    @Segmento1C VarChar(20),
    @Segmento2C VarChar(20),
    @Segmento3C VarChar(20),
    @Segmento4C VarChar(20)

    )
	
    AS
    SELECT proOrdenSegmento.proOrden, 
    dbo.Segmento(proOrdenSegmento.Segmento_Id, proOrdenSegmento.Segmento1C,
    proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C, 
    proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, 
    proOrdenSegmento.Segmento4N) AS SegmentoStr, 
    genSegmentos.Segmento_Id, proOrdenSegmento.Segmento1C,
    proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C, 
    proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N, 
    proOrden.FechaEmision, proOrden.FechaNecesidad,stkProductos.Producto_Id, proOrden.Cantidad,
	stkproductos.Descripcion, proRecetas.Receta_Id, proRecetas.Descripcion, 
	stkUniMed.Medida_Id, stkUniMed.Descripcion, proOrden.Factor, 
	stkUniMedProd.Medida_Id MedidaProducto,  stkUniMedProd.Descripcion DescripcionMedProd, proOrden.CtroProd_Id,
	proRecetasprod.Observaciones ObservacionReceta, isnull(proOrden.FechaFin,Getdate()) AS FechaFin,  
	proOrden.Observaciones,dbo.Segmento(venPediSegmentos.Segmento_Id,venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,venPediSegmentos.Segmento2N,
	venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) SegmentoPediStr
    FROM proOrdenSegmento
    INNER JOIN genSegmentos ON proOrdenSegmento.Segmento_Id = genSegmentos.genSegmentos
    INNER JOIN proOrden ON proOrden.proOrden = proOrdenSegmento.proOrden
	INNER JOIN stkProductos ON proOrden.Producto_Id = stkproductos.stkProductos
	INNER JOIN proRecetas on proOrden.Receta_Id = proRecetas.proRecetas
	INNER JOIN stkUniMed on proOrden.Medida_id = stkUnimed.stkUniMed
	INNER JOIN stkUniMed stkUniMedProd on stkproductos.Medida_Id = stkUniMedProd.stkUniMed
	INNER JOIN proRecetasProd on proRecetas.proRecetas = proRecetasProd.Receta_Id and 
			   proRecetasProd.EntradaSalida = 'P'
	LEFT JOIN proOrdenPedido ON proOrdenPedido.proOrden = proOrden.proOrden
	LEFT JOIN venPediSegmentos on venPediSegmentos.venPedidos = proOrdenPedido.venPedidos

	WHERE
			proOrdenSegmento.Empresa_Id = @Empresa_Id And
            genSegmentos.Segmento_Id =  @Segmento_Id and
            proOrdenSegmento.Segmento1C = @Segmento1C and 
            proOrdenSegmento.Segmento2C = @Segmento2C and 
            proOrdenSegmento.Segmento3C = @Segmento3C and 
            proOrdenSegmento.Segmento4C = @Segmento4C and 
            proOrdenSegmento.Segmento1N = @Segmento1N and 
            proOrdenSegmento.Segmento2N = @Segmento2N and  
            proOrdenSegmento.Segmento3N = @Segmento3N and  
            proOrdenSegmento.Segmento4N = @Segmento4N 


GO

--INF_proOrdencuerpo 1,'PORD',1032,0,0,0,'0001','','',''
--EMP Se agrega en el cuerpo los lotes que la empresa puede o no asignar en la orden de produccion.17/05/2023
DROP PROCEDURE INF_proOrdenCuerpo
GO
CREATE PROCEDURE INF_proOrdenCuerpo (
	@Empresa_Id int, 
	@Segmento_Id VarChar(10), 
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
	)
	AS
	SELECT proOrdenProd.Renglon, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, MedidaOrden.Medida_Id as MedidaMov, 
		proOrdenProd.Cantidad, proOrdenprod.Deposito_Id, stkDepositos.Descripcion,
		isnull(proOrdenProdSerie.Serie,'') Serie, isnull(proOrdenProdSerie.Cantidad,proOrdenProd.Cantidad) CantidadSerie
	FROM proOrdenProd 
		INNER JOIN proOrdenSegmento ON proOrdenProd.proOrden = proOrdenSegmento.proOrden
		INNER JOIN genSegmentos ON proOrdenSegmento.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON stkProductos.stkProductos = proOrdenProd.Producto_Id
		INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
		INNER JOIN stkUniMed AS MedidaOrden ON MedidaOrden.stkUniMed = proOrdenProd.Medida_Id
		INNER JOIN stkDepositos on proOrdenProd.Deposito_Id = stkDepositos.stkDepositos
		LEFT JOIN proOrdenProdSerie on proOrdenProdSerie.proOrden = proOrdenProd.proOrden and 
				  proOrdenProdSerie.Renglon = proOrdenProd.Renglon
	WHERE
		proOrdenSegmento.Empresa_Id = @Empresa_Id And
		genSegmentos.Segmento_Id =  @Segmento_Id and
		proOrdenSegmento.Segmento1C = @Segmento1C and 
		proOrdenSegmento.Segmento2C = @Segmento2C and 
		proOrdenSegmento.Segmento3C = @Segmento3C and 
		proOrdenSegmento.Segmento4C = @Segmento4C and 
		proOrdenSegmento.Segmento1N = @Segmento1N and 
		proOrdenSegmento.Segmento2N = @Segmento2N and  
		proOrdenSegmento.Segmento3N = @Segmento3N and  
		proOrdenSegmento.Segmento4N = @Segmento4N  and 
		proOrdenprod.EntradaSalida = 'C'
	ORDER BY 1

GO


