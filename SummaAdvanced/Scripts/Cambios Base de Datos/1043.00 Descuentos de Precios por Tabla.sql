CREATE TABLE venLPTabla(
	Tabla_Id Int NOT NULL,
	Descripcion VarChar(120) NOT NULL, 
	Primary Key(Tabla_Id))
GO


CREATE TABLE venLPTabCuerpo(
	Tabla_Id Int NOT NULL,
	Hasta Numeric(18,2) NOT NULL, 
	Valor Numeric(18,2)  NOT NULL, 
	Primary Key(Tabla_Id, Hasta))
GO


Alter Table venLPTabCuerpo ADD Constraint fkvenLPTabCuerpoC
	Foreign Key(Tabla_Id) References venLPTabla
GO

insert into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)
VALUES('VENTASLISTASPRECIOS','TABLA','TABLA DE DESCUENTO <Tab>,<Monto>',168,'N')
GO


INSERT INTO genVersion(Version) Values(1043)
GO
