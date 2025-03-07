create table venLogCorreos(
	venLogCorreos bigint Identity NOT NULL,
	FechaHora DateTime NOT NULL,
	Para VarChar(max) NOT NULL,
	venMovimientos bigInt NOT NULL,
	Respuesta VarChar(max) NOT NULL,
	Primary Key(venLogCorreos))
go

INSERT INTO genVersion(Version) Values(1074.00)
GO