CREATE TABLE tesDepoPorIdent(
	tesMovimientos bigInt NOT NULL, 
	venMovimientos BigInt NULL, 
	Primary KEY(tesMovimientos))
GO

ALTER TABLE tesDepoPorIdent ADD Constraint fktesDepoPorIdentTM
	FOREIGN KEY (tesMovimientos) References tesMovimientos
GO

ALTER TABLE tesDepoPorIdent ADD Constraint fktesDepoPorIdentVM
	FOREIGN KEY (venMovimientos) References venMovimientos
GO


CREATE TABLE tesDepoPorIdentImp(
	tesMovimientos bigInt NOT NULL, 
	Impuesto_Id INT not null, 
	BaseImponible Numeric(18,2) NOT NULL,
	Importe Numeric(18,2) NOT NULL,
	Primary KEY(tesMovimientos, Impuesto_Id))
GO

ALTER TABLE tesDepoPorIdentImp ADD Constraint fktesDepoPorIdentImpTM
	FOREIGN KEY (tesMovimientos) References tesMovimientos
GO

ALTER TABLE tesDepoPorIdentImp ADD Constraint fktesDepoPorIdentImpImp
	FOREIGN KEY (Impuesto_Id) References venImpuestos
GO

insert into tesSubTiposMov(SubTipo_Id,Descripcion,TipoMov,CantCopias,genReportes)
VALUES('DNI','Depositos por Identificar','I',1, dbo.FuncFKgenReportes('TESMOVIMIENTOSDH'))

/*
insert into tesSubTiposMov(SubTipo_Id,Descripcion,TipoMov,CantCopias,genReportes)
VALUES('IDE','Identificaciond de Depositos','I',1, dbo.FuncFKgenReportes('TESMOVIMIENTOSDH'))
*/


insert into genVersion (Version) Values(1053)
GO
	