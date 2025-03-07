CREATE TABLE stkUbiAlmacenDefecto(
	Empresa_Id Int NOT NULL,
	Deposito_Id int NOT NULL, 
	Producto_Id Int NOT NULL, 
	Ubicacion_Id int NOT NULL, 
	Usuario_Id Int NOT NULL,
	Primary Key(Empresa_Id, Deposito_Id, Producto_Id))
GO

Alter table stkUbiAlmacenDefecto add Constraint fkstkUbiAlmacenDefectoDep
	Foreign Key (Deposito_Id) References stkDepositos
GO
Alter table stkUbiAlmacenDefecto add Constraint fkstkUbiAlmacenDefectoEmp
	Foreign Key (Empresa_Id) References genEmpresas
GO

Alter table stkUbiAlmacenDefecto add Constraint fkstkUbiAlmacenDefectoProd
	Foreign Key (Producto_Id) References stkProductos
GO


Alter table stkUbiAlmacenDefecto add Constraint fkstkUbiAlmacenDefectoUbi
	Foreign Key (Ubicacion_Id) References stkUbicaciones
GO

Alter table stkUbiAlmacenDefecto add Constraint fkstkUbiAlmacenDefectoUsu
	Foreign Key (Usuario_Id) References genUsuarios
GO


Alter table stkHojaDeRuta add Chofer VarChar(100) 
GO

INSERT INTO genVersion(Version) Values(1047.00)
GO



	