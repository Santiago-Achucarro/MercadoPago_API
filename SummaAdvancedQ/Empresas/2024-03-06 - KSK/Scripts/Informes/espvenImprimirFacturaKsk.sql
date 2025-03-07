
CREATE or alter PROCEDURE espvenImprimirFacturaKsk
@segVentas varchar(20)

-- exec Inf_espvenImprimirFacturaKsk 'F-B-0010-00000022'


as

select
a.Segmento, a.Fecha, a.venTipomov, a.SubTipomov_Id, a.Cliente_Id, a.RazonSocial, a.Importe, a.Importe,
b.Producto_Id, e.Descripcion,
b.CantFacturada, b.Medida_Id, b.PrecioForm, d.*
from vVenMovimientos a 
inner join vvenMovConStockCr b on a.venMovimientos = b.venMovimientos	
inner join venClientes c on a.Cliente_Id = c.Cliente_Id
inner join venClieHabitual d on c.genEntidades = d.genEntidades and d.Sucursal = 1
inner join stkProductos e on b.Producto_Id = e.Producto_Id
where LTRIM(segVentas) = @segVentas