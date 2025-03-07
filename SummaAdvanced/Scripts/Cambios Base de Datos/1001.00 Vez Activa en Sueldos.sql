CREATE Table sueVezActiva(
	Empresa_Id Int NOT NULL,
	Anio Int NOT NULL, 
	Mes Int NOT NULL, 
	Quin Int NOT NULL, 
	Decena Int NOT NULL, 
	Semana Int NOT NULL,
	Vez Int Not null, 
	Grupo_Id Int NOT NULL,
	Primary key(Empresa_Id))
GO


insert into genVersion (Version) Values(1001.00)
GO