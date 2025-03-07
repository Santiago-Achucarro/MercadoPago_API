--INF_stkInvIngresado 1, 'INV',1,0,0,0,'0001',' ',' ',' '


DROP PROCEDURE INF_stkInvIngresado
GO
CREATE PROCEDURE INF_stkInvIngresado(
@Empresa Int, 
@Segmento_Id VarChar(10),
@Segmento1N INT,
@Segmento2N INT,
@Segmento3N INT,
@Segmento4N INT,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)

as

select dbo.Segmento(stkInvenSegmentos.Segmento_Id, 
	stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C, 
	stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C,
	stkInvenSegmentos.Segmento1N, stkInvenSegmentos.Segmento2N, 
	stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N) AS InventarioSeg, 
	stkInventarios.FechaInventario, genUsuarios.Apellido_y_Nombres as UsuarioRespozable, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkInventCuerpo.Cantidad, 
	stkProductos.ClaseAlterna, stkInventCuerpo.CantidadAlterna, 
	isnull(stkUmAlterna.Medida_Id,  ' ') as MedidaAlterna
	

 from 
	stkInvenSegmentos inner join stkInventarios ON
	stkInvenSegmentos.stkInventarios = stkInventarios.stkInventarios
	INNER JOIN genUsuarios ON 
	genUsuarios.genUsuarios =stkInventarios.UsuRespo_Id
	INNER JOIN stkInventCuerpo on
	stkInventCuerpo.stkInventarios = stkInventarios.stkInventarios
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkInventCuerpo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = stkInvenSegmentos.Segmento_Id
	LEFT JOIN stkUniMed as stkUmAlterna ON
	stkUmAlterna.stkUniMed = stkProductos.Medida_Id
	Where
		genSegmentos.Segmento_Id = @Segmento_Id and
		stkInvenSegmentos.Segmento1N = @Segmento1N and
		stkInvenSegmentos.Segmento2N = @Segmento2N and
		stkInvenSegmentos.Segmento3N = @Segmento3N and
		stkInvenSegmentos.Segmento4N = @Segmento4N and
		stkInvenSegmentos.Segmento1C = @Segmento1C and
		stkInvenSegmentos.Segmento2C = @Segmento2C and
		stkInvenSegmentos.Segmento3C = @Segmento3C and
		stkInvenSegmentos.Segmento4C = @Segmento4C and
		stkInvenSegmentos.Empresa_Id = @Empresa
		
order by 4
GO

