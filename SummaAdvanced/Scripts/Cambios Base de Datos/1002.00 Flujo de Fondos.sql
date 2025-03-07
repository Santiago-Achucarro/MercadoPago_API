/*
DROP TABLE tesFFDepositos
DROP TABLE tesFFSegmentos
DROP TABLE tesFFCobClientes
DROP TABLE tesFFCobranzaOtros
DROP TABLE tesFFPagosOtros
DROP TABLE tesFFPagosProvedores
DROP TABLE tesFlujoFondo
*/


CREATE TABLE tesFlujoFondo(
	tesFlujoFondo BigInt Identity NOT NULL, 
	FechaDesde DateTime NOT NULL, 
	FechaHasta DateTime NOT NULL, 
	DetallaClientes Bit NOT NULL, 
	DetallaProveedores Bit NOT NULL, 
	Usuario_Id Int NOT NULL, 
	FechaRegistro DateTime NOT NULL, 
	Periodo Char(1) NOT NULL, /* Diario , Semanal, Mensual */ 
	Primary Key(tesFlujoFondo))
GO

Alter table tesFlujoFondo add Constraint 
	FktesFlujoFondoUsu Foreign Key (Usuario_Id)
	References  genUsuarios (genUsuarios)
GO

CREATE TABLE tesFFSegmentos(
	Empresa_Id INT NOT NULL, 
	Segmento_Id Int NOT NULL, 
	Segmento1N Int NOT NULL, 
	Segmento2N Int NOT NULL, 
	Segmento3N Int NOT NULL, 
	Segmento4N Int NOT NULL, 
	Segmento1C VarChar(20) NOT NULL, 
	Segmento2C VarChar(20) NOT NULL, 
	Segmento3C VarChar(20) NOT NULL, 
	Segmento4C VarChar(20) NOT NULL, 
	tesFlujoFondo BigInt NOT NULL, 
	PRIMARY KEY(Empresa_Id, Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C, Segmento4C))
GO

Alter table tesFFSegmentos add Constraint 
	FktesFFSegmentosEmp Foreign Key (Empresa_Id)
	References  genEmpresas
GO

Alter table tesFFSegmentos add Constraint 
	FktesFFSegmentosSeg Foreign Key (Segmento_Id)
	References  genSegmentos
GO

Alter table tesFFSegmentos add Constraint 
	FktesFFSegmentosFF Foreign Key (tesFlujoFondo)
	References  tesFlujoFondo
GO

CREATE TABLE tesFFPagosProvedores(
	tesFlujoFondo BigInt NOT NULL,
	Fecha DateTime NOT NULL,
	Proveed_Id BigInt NOT NULL,
	Moneda_Id Int NOT NULL, 
	Monto Numeric(18,2) NOT NULL, 
	PRIMARY KEY(tesFlujoFondo, Fecha, Proveed_Id, Moneda_Id))
GO

Alter table tesFFPagosProvedores add Constraint 
	FktesFFPagosProvedoresFF Foreign Key (tesFlujoFondo)
	References  tesFlujoFondo
GO

Alter table tesFFPagosProvedores add Constraint 
	FktesFFPagosProvedoresProv Foreign Key (Proveed_Id)
	References  comProveedores
GO

Alter table tesFFPagosProvedores add Constraint 
	FktesFFPagosProvedoresMoneda Foreign Key (Moneda_Id)
	References  genMonedas
GO

-- Si es Sueldos los caso por la Fecha de pago en Nominas
CREATE TABLE tesFFPagosOtros(
	tesFlujoFondo BigInt NOT NULL,
	Fecha DateTime NOT NULL,
	Renglon Int NOT NULL, 
	Descripcion VarChar(200) NOT NULL,
	Tipo Char(1) NOT NULL, /* I= Impuestos - S = Sueldos y O = Otros */ 
	Impuesto_Id INT, 
	Moneda_Id Int NOT NULL, 
	Monto Numeric(18,2) NOT NULL, 
	PRIMARY KEY(tesFlujoFondo,Fecha, Renglon))
GO

Alter table tesFFPagosOtros add Constraint 
	FktesFFPagosOtrosFF Foreign Key (tesFlujoFondo)
	References  tesFlujoFondo
GO


Alter table tesFFPagosOtros add Constraint 
	FktesFFPagosOtrosMoneda Foreign Key (Moneda_Id)
	References  genMonedas
GO

CREATE TABLE tesFFCobClientes(
	tesFlujoFondo BigInt NOT NULL,
	Fecha DateTime NOT NULL,
	Cliente_Id BigInt NOT NULL,
	Moneda_Id Int NOT NULL, 
	Monto Numeric(18,2) NOT NULL, 
	PRIMARY KEY(tesFlujoFondo, Fecha, Cliente_Id, Moneda_Id))
GO

Alter table tesFFCobClientes add Constraint 
	FktesFFCobClientesFF Foreign Key (tesFlujoFondo)
	References  tesFlujoFondo
GO

Alter table tesFFCobClientes add Constraint 
	FktesFFCobClientesClie Foreign Key (Cliente_Id)
	References  venClientes
GO


Alter table tesFFCobClientes add Constraint 
	FktesFFCobClientesMoneda Foreign Key (Moneda_Id)
	References  genMonedas
GO

CREATE TABLE tesFFCobranzaOtros(
	tesFlujoFondo BigInt NOT NULL,
	Fecha DateTime NOT NULL,
	Renglon Int NOT NULL, 
	Descripcion VarChar(200) NOT NULL,
	Moneda_Id Int NOT NULL, 
	Monto Numeric(18,2) NOT NULL, 
	PRIMARY KEY(tesFlujoFondo, Fecha, Renglon))
GO

Alter table tesFFCobranzaOtros add Constraint 
	FktesFFCobranzaOtrosFF Foreign Key (tesFlujoFondo)
	References  tesFlujoFondo
GO

Alter table tesFFCobranzaOtros add Constraint 
	FktesFFCobranzaOtrosMoneda Foreign Key (Moneda_Id)
	References  genMonedas
GO


CREATE TABLE tesFFDepositos(
	tesFlujoFondo BigInt NOT NULL,
	Fecha DateTime NOT NULL,
	Cliente_Id BigInt ,
	Moneda_Id Int NOT NULL, 
	Monto Numeric(18,2) NOT NULL, 
	PRIMARY KEY(tesFlujoFondo, Fecha, Cliente_Id))
GO

Alter table tesFFDepositos add Constraint 
	FktesFFDepositosFF Foreign Key (tesFlujoFondo)
	References  tesFlujoFondo
GO

Alter table tesFFDepositos add Constraint 
	FktesFFDepositosClie Foreign Key (Cliente_Id)
	References  venClientes
GO

Alter table tesFFDepositos add Constraint 
	FktesFFDepositosMoneda Foreign Key (Moneda_Id)
	References  genMonedas
GO

INSERT INTO genVersion (Version) Values(1002.00)
GO


	

	