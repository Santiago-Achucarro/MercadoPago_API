IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 8.00)
begin
	INSERT INTO genVersion (Version) Values (8.00);

	Create table stkProductosCostos (
				Producto_Id Int NOT NULL, 
				Empresa_Id int NOT NULL,
				CostoPromPond Numeric(19,8) NOT NULL,
				CostoUltCompra Numeric(19,8) NOT NULL,
				CostoStandard  Numeric(19,8) NOT NULL,
				Usuario_Id Int NOT NULL, 
				FechaUltModif DateTime NOT NULL,
				MonedaUltCompra Int NOT NULL,
				PrecioUltCompra Numeric(19,8) NOT NULL,
				Fecha_Ult_Compra DateTime NOT NULL,
				PRIMARY KEY(Producto_Id, Empresa_Id));

	
	Alter table stkProductosCostos add Foreign key(Empresa_Id) References genEmpresas;
	Alter table stkProductosCostos add Foreign key(Usuario_Id) References genUsuarios;
	Alter table stkProductosCostos add Foreign key(Producto_Id) References stkProductos;
	Alter table stkProductosCostos add Foreign key(MonedaUltCompra) References genMonedas;

	Alter Table genEmpresas Add Centro1De VarChar(3); 
	Alter Table genEmpresas Add Centro2De VarChar(3); 

	ALter table comTipoPermi Add Importaciones Bit; 
	UPDATE comTipoPermi SET Importaciones = 0;
	ALter table comTipoPermi Alter Column Importaciones Bit NOT NULL;

end




