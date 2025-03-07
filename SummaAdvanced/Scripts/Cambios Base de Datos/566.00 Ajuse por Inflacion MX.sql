
Create Table conRubrosAxi(
	conRubrosAxi Int Identity Not NULL,
	RubroAxi_Id Int NOT NULL, 
	Descripcion VarChar(120) NOT NULL, 
	Rubro_Id Char(1) NOT NULL,
	Empresa_Id Int NULL, 
	Posteado Bit NOT NULL, 
	Inactivo Bit NOT NULL,
	Primary key(conRubrosAxi))
GO


Create Unique Index AkconRubrosAxi ON conRubrosAxi (RubroAxi_Id) 
GO


Alter table conRubrosAxi add Constraint fkconRubrosAxiRubro 
	Foreign Key(Rubro_Id) References conRubros (Rubro_Id)

insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(1,'Bancos e inversiones','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(2,'Clientes','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(3,'Deudores Diversos','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(4,'Cuentas Incobrables','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(5,'Saldos a Favor ISR e IVA','1',1,0)

insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(51,'Proveedores','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(52,'Acreedores Bancarios','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(53,'Acreedores Diversos','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(54,'Impuestos por Pagar','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(55,'SAR Interno Patron','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(56,'PTU por Pagar','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(57,'Aport p/fut Aum Cap.','2',1,0)
GO

Alter table conCuentas Add RubroAxi_Id Int 
GO

Alter table conCuentas Add Constraint FkconCuentasAxi Foreign Key(RubroAxi_Id)
REFERENCES conRubrosAxi (RubroAxi_Id)

INSERT INTO genVersion(Version) Values(566.00)
go
