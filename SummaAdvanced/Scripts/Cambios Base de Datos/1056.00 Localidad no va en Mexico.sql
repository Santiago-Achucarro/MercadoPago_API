if Exists(select 1 from genInstalacion where Dominio_Id = 'MX')
	DELETE FROM suePersLocalidad
GO


Create Table stkMoviLega(
	stkMoviCabe BigInt NOT NULL, 
	Legajo BigInt NOT NULL,
	Primary KEY(stkMoviCabe)
)
GO
 
Alter Table stkMoviLega Add Constraint fkstkMoviLegaCabe
	Foreign Key(stkMoviCabe) References stkMoviCabe
GO

Alter Table stkMoviLega Add Constraint fkstkMoviLegaEmple
	Foreign Key(Legajo) References suePersonal
GO


INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id)
VALUES('EEMP','E','Entradas desde Empleados',1,1,null)
GO

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id)
VALUES('SEMP','S','Salidas para Empleados',1,1,null)
GO

insert into genVersion(Version) Values(1056.00)
GO