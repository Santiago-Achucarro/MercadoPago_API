IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 45.00)
begin


CREATE TABLE venClieContacto
(
	Cliente_Id BigInt NOT NULL,
	Sucursal Int  NOT NULL,
	NroContacto int NOT NULL,
	Nombre VarChar(120) NOT NULL,
	Puesto VarChar(100) NOT NULL,
	Email VarChar(120) NOT NULL,
	Telefono VarChar(30) NOT NULL,
	Interno Varchar(20) NOT NULL,
	Movil VarChar(30) NOT NULL,
	EnviaFacturas SiNo,
	EnviaRecibo SiNo,
	EnviaPedido SiNo,
	Observaciones VarChar(max),
	Inactivo SiNo,
	Primary key (Cliente_Id, Sucursal, NroContacto));


Alter table genEmpresas Add  EnviaPedido bit; 

END
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 45.00)
begin


Update genEmpresas set EnviaPedido =0;

Alter table genEmpresas Alter Column EnviaPedido bit NOT NULL;  


INSERT INTO genVersion(Version) Values(45.00);

END
go
