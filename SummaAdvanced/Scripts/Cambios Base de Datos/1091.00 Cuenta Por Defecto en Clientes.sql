ALTER TABLE venClientesCtas add ParaPedidos bit 
ALTER TABLE venClientesCtas add ParaFactura bit 
GO

uPDATE venClientesCtas SET ParaFactura = 0 , ParaPedidos = 0
GO

ALTER TABLE venClientesCtas Alter Column ParaPedidos bit NOT NULL
ALTER TABLE venClientesCtas Alter Column ParaFactura bit NOT NULL
GO

UPDATE venClientesCtas SET ParaFactura =1 , ParaPedidos =1 where
	exists(select 1 
		from venClientes INNER JOIN venClieHabitual ON 
		venClientes.genEntidades =venClieHabitual.genEntidades and 
		venClientes.SucursalPredeter = venClieHabitual.Sucursal
		inner join venListasPrecios ON venListasPrecios.venListasPrecios = venClieHabitual.ListaPrecio_Id
		WHERE
		venClientes.genEntidades = venClientesCtas.Cliente_Id AND
		venListasPrecios.Moneda_Id = venClientesCtas.Moneda_Id)

GO

update venClientesCtas set ParaFactura = 1 , ParaPedidos = 1
where	not exists(select 1 from venClientesCtas c1 where 
	c1.Cliente_Id  = venClientesCtas.Cliente_Id and 
	c1.ParaFactura= 1)
GO

INSERT INTO genVersion(Version) Values(1091.00)
GO
