--inf_proUsoUnProducto 'CH-105-100EP',1

DROP PROCEDURE inf_proUsoUnProducto
GO

CREATE PROCEDURE inf_proUsoUnProducto
(
	@Producto_Id VarChar(25),
	@Empresa_Id Int
)

as

SELECT proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionReceta, 
	proRecetasProd.Cantidad, stkUniMed.Medida_Id, 
		proRecetasProd.EntradaSalida as ProduccionConsumo
from proRecetas INNER JOIN proRecetasProd ON
proRecetas.proRecetas =  proRecetasProd.Receta_Id
INNER JOIN stkProductos ON
stkProductos.stkProductos = proRecetasProd.Producto_Id 
INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed = proRecetasProd.Medida_Id
WHERE
	stkProductos.Producto_Id = @Producto_Id AND
	isnull(proRecetas.Empresa_Id,@Empresa_Id) = @Empresa_Id
ORDER BY 1

GO



