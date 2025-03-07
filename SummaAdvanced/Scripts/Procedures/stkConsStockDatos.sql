

-- Exec stkConsStockDatos 'coe01b01', '100-01-02',1
drop procedure stkConsStockDetalle
go
create procedure stkConsStockDetalle
AS
 select '' as Entidad_Id, '' as Descripcion,
		 0.00 as Cantidad,
         '' as SegmentoSTR
		 select '' as TipoConsulta, '' as Producto_Id, '' as Deposito_Id, getdate() as Fecha

go


DROP PROCEDURE stkConsStockDatos
GO
CREATE PROCEDURE stkConsStockDatos(
	@Producto_id VarChar(25),
	@Deposito_Id VarChar(15),
	@Empresa Int
)
AS
Declare @Fecha DateTime 
SET @Fecha =dbo.FechaSinHora(dbo.FechaActual())
select @Producto_id as Producto_Id, @Deposito_Id as Deposito_Id

SELECT Fecha, Producto_Id, Descripcion, SUM(Existencia) as Existencia, 
	SUM(Compras) as Compras, SUM(Embarques) as Embarques,	
		SUM(Pedidos) as Pedidos, SUM(Transito) as TransitoLocal,
		SUM(Existencia+Compras+Embarques-Pedidos+Transito) as Final, @Deposito_Id as Deposito_Id
FROM (

SELECT  @Fecha as Fecha, stkProductos.Producto_Id, stkProductos.Descripcion,	
	ISNULL(stkExistencia.Cantidad,0.00) as Existencia, 
		ISNULL((SELECT SUM(comOcCuerpo.Cantidad-case when stkDepositos.consCompra_Venta = 1 then 
		comOcCuerpo.CantidadConsignada else comOcCuerpo.Cantidad_Recibida end )
		from comOrdenComp inner join comOcCuerpo ON
		comOrdenComp.comOrdenComp = comOcCuerpo.comOrdenComp 
		INNER JOIN comOCArticulo ON
		comOcCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comOcCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN comOCSegmentos ON
		comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		Where
			stkDepositos.Deposito_Id = @Deposito_Id and 
			comOcCuerpo.Pendiente = 1 AND 
			comOcCuerpo.Cantidad > case when stkDepositos.consCompra_Venta = 1 then 
		comOcCuerpo.CantidadConsignada else comOcCuerpo.Cantidad_Recibida end  and 
			NOT EXISTS(SELECT 1 FROM comEmbcuerpo WHERE
				comEmbcuerpo.comOrdenComp = comOcCuerpo.comOrdenComp and 
				comEmbcuerpo.Renglon_OC = comOcCuerpo.Renglon_OC) AND
			comOrdenComp.Estado_Id in ( 'A','P','E' ) AND 
			comOCArticulo.Producto_Id = stkProductos.stkProductos AND 
			comOCSegmentos.Empresa_Id = @Empresa AND 
			comOcCuerpo.Fecha_Entrega <= @Fecha),0) as Compras, 

	ISNULL((SELECT SUM(comEmbCuerpo.Cantidad -comEmbCuerpo.CantidadRecibida)
		from comEmbarques inner join comEmbCuerpo ON
		comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques
		INNER JOIN comOCArticulo ON
		comEmbCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comEmbCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = comEmbarques.comEmbarques
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		Where
			stkDepositos.Deposito_Id = @Deposito_Id and 
			conAsientos.Anulado = 0 and 
			comEmbarques.Estado_Id = 'P' AND 
			comEmbCuerpo.Cantidad > comEmbCuerpo.CantidadRecibida and 
			comOCArticulo.Producto_Id = stkProductos.stkProductos AND 
			conAsientos.Empresa_Id = @Empresa AND 
			comEmbarques.FechaArribo <= @Fecha),0) as Embarques, 

	ISNULL((SELECT SUM(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida)
		FROM venPedidos INNER JOIN venPediCuerpo on 
			venPedidos.venPedidos =venPediCuerpo.venPedidos
			INNER JOIN stkDepositos ON 
			stkDepositos.stkDepositos = venPediCuerpo.Deposito_Id
			WHERE
			stkDepositos.Deposito_Id = @Deposito_Id and 
			venPedidos.Estado  IN('P','A') AND 
			venPediCuerpo.Pendiente = 1 AND
			venPediCuerpo.CantidadPedida > venPediCuerpo.CantidadRemitida AND
			venPediCuerpo.Producto_Id = stkProductos.stkProductos AND 
			venPedidos.Empresa_Id = @Empresa AND 
			venPediCuerpo.FechaEntrega <= @Fecha),0) as Pedidos,
	ISNULL((SELECT SUM(stkmovicuerpo.Cantidad) 
		from stkEntransito inner join stkMoviCuerpo ON 
		stkEntransito.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = stkEntransito.Deposito_Id
		inner join conAsientos ON
		conAsientos.conAsientos = stkEntransito.stkMoviCabe 
		WHERE
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			conAsientos.Empresa_Id = @Empresa and 
			stkEntransito.stkMoviCabeEntr is null  AND
			stkDepositos.Deposito_Id = @Deposito_Id and 
			stkMoviCuerpo.Producto_Id = stkProductos.stkProductos),0) AS Transito
	FROM stkProductos
	LEFT JOIN (stkExistencia INNER JOIN stkDepositos ON 
		stkExistencia.Deposito_Id = stkDepositos.stkDepositos and
		stkDepositos.Deposito_Id = @Deposito_Id and 
		stkExistencia.Empresa_Id = @Empresa) ON
		stkExistencia.Producto_Id = stkProductos.stkProductos 

where 
	stkProductos.Producto_Id =@Producto_id 
UNION ALL -- COMPRAS

SELECT  comOcCuerpo.Fecha_Entrega Fecha, stkProductos.Producto_Id, stkProductos.Descripcion,	
	0 as Existencia, SUM(comOcCuerpo.Cantidad-case when stkDepositos.consCompra_Venta = 1 then 
		comOcCuerpo.CantidadConsignada else comOcCuerpo.Cantidad_Recibida end ) AS Compras, 
		0 as Embarques, 0 as Pedidos, 0 as Transito
		from 	comOrdenComp inner join comOcCuerpo ON
		comOrdenComp.comOrdenComp = comOcCuerpo.comOrdenComp 
		INNER JOIN comOCArticulo ON
		comOcCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comOcCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN comOCSegmentos ON
		comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp 
		INNER JOIN stkProductos ON
		comOCArticulo.Producto_Id = stkProductos.stkProductos 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		Where
			stkDepositos.Deposito_Id = @Deposito_Id and 
			stkProductos.Producto_Id =@Producto_id  AND 
			comOcCuerpo.Pendiente = 1 AND 
			comOcCuerpo.Cantidad > case when stkDepositos.consCompra_Venta = 1 then 
		comOcCuerpo.CantidadConsignada else comOcCuerpo.Cantidad_Recibida end  and 
			NOT EXISTS(SELECT 1 FROM comEmbcuerpo WHERE
				comEmbcuerpo.comOrdenComp = comOcCuerpo.comOrdenComp and 
				comEmbcuerpo.Renglon_OC = comOcCuerpo.Renglon_OC) AND
			comOrdenComp.Estado_Id in ( 'A','P' ) AND 
			comOCSegmentos.Empresa_Id = @Empresa AND 
			comOcCuerpo.Fecha_Entrega > @Fecha
GROUP BY comOcCuerpo.Fecha_Entrega , stkProductos.Producto_Id, stkProductos.Descripcion
UNION ALL -- EMBARQUES

SELECT  comEmbarques.FechaArribo Fecha, stkProductos.Producto_Id, stkProductos.Descripcion,	
	0 as Existencia, 0 as Compras , SUM(comEmbCuerpo.Cantidad-comEmbCuerpo.CantidadRecibida) as Embarques, 
		0 as Pedidos, 0 as Transito
			from comEmbarques inner join comEmbCuerpo ON
		comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques
		INNER JOIN comOCArticulo ON
		comEmbCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comEmbCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = comEmbarques.comEmbarques
		INNER JOIN stkProductos ON 
		comOCArticulo.Producto_Id = stkProductos.stkProductos 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		Where
			stkDepositos.Deposito_Id = @Deposito_Id and 
			stkProductos.Producto_Id =@Producto_id AND 
			conAsientos.Anulado = 0 and 
			comEmbarques.Estado_Id = 'P' AND 
			comEmbCuerpo.Cantidad > comEmbCuerpo.CantidadRecibida and 
			conAsientos.Empresa_Id = @Empresa AND 
			comEmbarques.FechaArribo > @Fecha
GROUP BY comEmbarques.FechaArribo , stkProductos.Producto_Id, stkProductos.Descripcion
UNION ALL -- PEDIDOS
SELECT  venPediCuerpo.FechaEntrega Fecha, stkProductos.Producto_Id, stkProductos.Descripcion,	
	0 as Existencia, 0 as Compras , 0 as Embarques, 
		 SUM(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida) as Pedidos, 0 as Transito
			FROM venPedidos INNER JOIN venPediCuerpo on 
			venPedidos.venPedidos =venPediCuerpo.venPedidos 
			INNER JOIN stkProductos ON 
			stkProductos.stkProductos =venPediCuerpo.Producto_Id
			INNER JOIN stkDepositos ON 
			stkDepositos.stkDepositos = venPediCuerpo.Deposito_Id
			WHERE
			stkDepositos.Deposito_Id = @Deposito_Id and 
			venPedidos.Estado  IN('P','A') AND 
			venPediCuerpo.Pendiente = 1 AND
			venPediCuerpo.CantidadPedida > venPediCuerpo.CantidadRemitida AND
			venPediCuerpo.Producto_Id = stkProductos.stkProductos AND 
			stkProductos.Producto_Id = @Producto_id AND 
			venPedidos.Empresa_Id = @Empresa AND 
			venPediCuerpo.FechaEntrega > @Fecha
GROUP BY venPediCuerpo.FechaEntrega, stkProductos.Producto_Id, stkProductos.Descripcion) AS XXX
GROUP BY Fecha, Producto_Id, Descripcion
ORDER BY 1

GO






drop PROCEDURE stkConsStockEnTransito
go
create PROCEDURE stkConsStockEnTransito
(
    @Producto_id varchar(25),
    @Deposito_Id varchar(5),
    @Empresa int
)
as
--transito
SELECT stkMoviCuerpo.Cantidad, Origen.Deposito_Id as Entidad_Id, Origen.Descripcion as Descripcion,
		dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
         genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR
		from stkEntransito inner join stkMoviCuerpo ON 
		stkEntransito.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = stkEntransito.Deposito_Id
		inner join conAsientos ON
		conAsientos.conAsientos = stkEntransito.stkMoviCabe 
        inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=stkMoviCuerpo.stkMoviCabe
        inner join stkProductos on stkProductos.stkProductos=stkMoviCuerpo.Producto_Id
		inner join stkDepositos as Origen ON  Origen.stkDepositos = stkMoviCuerpo.Deposito_Id
		WHERE
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			stkEntransito.stkMoviCabeEntr is null  AND
			conAsientos.Empresa_Id = @Empresa and 
			stkDepositos.Deposito_Id = @Deposito_Id and 
			stkProductos.Producto_Id = @Producto_id
go
    
    
    -- COMPRAS
drop PROCEDURE stkConsStockCompras
go
create PROCEDURE stkConsStockCompras
(
    @Producto_id varchar(25),
    @Deposito_Id varchar(5),
    @Fecha datetime,
    @Empresa int
)
as
-- COMPRAS

SELECT  
	 comOcCuerpo.Cantidad-comOcCuerpo.Cantidad_Recibida AS Cantidad, 
		comProveedores.Proveed_Id as Entidad_Id, comProveedores.RazonSocial as Descripcion,
		dbo.Segmento(comOCSegmentos.Segmento_Id,comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
         comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as SegmentoSTR
		from 	comOrdenComp inner join comOcCuerpo ON
		comOrdenComp.comOrdenComp = comOcCuerpo.comOrdenComp 
		INNER JOIN comOCArticulo ON
		comOcCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comOcCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN comOCSegmentos ON
		comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp 
		INNER JOIN stkProductos ON
		comOCArticulo.Producto_Id = stkProductos.stkProductos 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
        inner join comProveedores on comProveedores.genEntidades=comOrdenComp.Proveed_Id
		Where
			stkDepositos.Deposito_Id = @Deposito_Id and 
			stkProductos.Producto_Id =@Producto_id  AND 
			comOcCuerpo.Pendiente = 1 AND 
			comOcCuerpo.Cantidad > comOcCuerpo.Cantidad_Recibida and 
			NOT EXISTS(SELECT 1 FROM comEmbcuerpo WHERE
				comEmbcuerpo.comOrdenComp = comOcCuerpo.comOrdenComp and 
				comEmbcuerpo.Renglon_OC = comOcCuerpo.Renglon_OC) AND
			comOrdenComp.Estado_Id in ( 'A','P' ) AND 
			comOCSegmentos.Empresa_Id = @Empresa AND 
			(comOcCuerpo.Fecha_Entrega = @Fecha or (@Fecha< dbo.FechaActual() and comOCCuerpo.Fecha_Entrega<=@Fecha))
go


-- EMBARQUES
drop PROCEDURE stkConsStockEmbarques
go
create PROCEDURE stkConsStockEmbarques
(
    @Producto_id varchar(25),
    @Deposito_Id varchar(5),
    @Fecha datetime,
    @Empresa int
)
as
SELECT 	
	 comEmbCuerpo.Cantidad-comEmbCuerpo.CantidadRecibida as Cantidad,
     comProveedores.Proveed_Id as Entidad_Id, comProveedores.RazonSocial as Descripcion,
		dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
         genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR
			from comEmbarques inner join comEmbCuerpo ON
		comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques
		INNER JOIN comOCArticulo ON
		comEmbCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comEmbCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = comEmbarques.comEmbarques
		INNER JOIN stkProductos ON 
		comOCArticulo.Producto_Id = stkProductos.stkProductos 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
        inner join comOrdenComp on comEmbCuerpo.comOrdenComp=comOrdenComp.comOrdenComp
        inner join comProveedores on comOrdenComp.Proveed_Id=comProveedores.genEntidades
        inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=comEmbarques.comEmbarques
		Where
			stkDepositos.Deposito_Id = @Deposito_Id and 
			stkProductos.Producto_Id =@Producto_id AND 
			conAsientos.Anulado = 0 and 
			comEmbarques.Estado_Id = 'P' AND 
			comEmbCuerpo.Cantidad > comEmbCuerpo.CantidadRecibida and 
			conAsientos.Empresa_Id = @Empresa AND 
			(comEmbarques.FechaArribo = @Fecha or (@Fecha< dbo.FechaActual() and comEmbarques.FechaArribo<=@Fecha))

go


-- PEDIDOS
drop PROCEDURE stkConsStockPedidos
go
create PROCEDURE stkConsStockPedidos
(
    @Producto_id varchar(25),
    @Deposito_Id varchar(5),
    @Fecha datetime,
	@Vendedor_id VarChar(5) = NULL,
    @Empresa int
)
as
SELECT  venClientes.Cliente_Id as Entidad_Id, venClientes.RazonSocial as Descripcion,
		 venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida as Cantidad,
         dbo.Segmento(venPediSegmentos.Segmento_Id,venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
         venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) as SegmentoSTR
			FROM venPedidos INNER JOIN venPediCuerpo on 
			venPedidos.venPedidos =venPediCuerpo.venPedidos 
			INNER JOIN stkProductos ON 
			stkProductos.stkProductos =venPediCuerpo.Producto_Id
			INNER JOIN stkDepositos ON 
			stkDepositos.stkDepositos = venPediCuerpo.Deposito_Id
			inner join venClientes on venClientes.genEntidades=venPedidos.Cliente_Id
            inner join venPediSegmentos on venPediSegmentos.venPedidos=venPedidos.venPedidos
			INNER JOIN venVendedores ON venVendedores.venVendedores = venPedidos.Vendedor_Id
            WHERE
			stkDepositos.Deposito_Id = @Deposito_Id and 
			venPedidos.Estado  IN('P','A') AND 
			venPediCuerpo.Pendiente = 1 AND
			venPediCuerpo.CantidadPedida > venPediCuerpo.CantidadRemitida AND
			stkProductos.Producto_Id = @Producto_id AND 
			venVendedores.Vendedor_Id = ISNULL(@Vendedor_id, venVendedores.Vendedor_Id) AND 
			venPedidos.Empresa_Id = @Empresa AND 
			(venPediCuerpo.FechaEntrega = @Fecha or (@Fecha<dbo.FechaActual() and venPediCuerpo.FechaEntrega<=@Fecha))
            

go