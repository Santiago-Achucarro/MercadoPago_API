Alter table sueCategorias Drop column Sindicalizado
GO

Alter table sueCategorias Drop Constraint V2R_4432
GO
Alter table sueCategorias Drop column TablaVac_Id
GO


Alter table sueConvenio ADD Sindicalizdo SiNo null
GO
Update sueConvenio set Sindicalizdo = 0
GO

Alter table sueConvenio Alter Column Sindicalizdo SiNo NOT NULL
GO

Alter table sueConvenio ADD TablaVac_Id Int 
GO

ALTER TABLE sueConvenio
	ADD CONSTRAINT V2R_4433 FOREIGN KEY (TablaVac_Id) REFERENCES sueTablaVacacion(sueTablaVacacion)
GO

Alter table sueVacCorresponden add Saldo Int 
GO

UPDATE sueVacCorresponden SET Saldo = Dias
GO

Alter table sueVacCorresponden Alter Column Saldo Int NOT NULL
GO

INSERT INTO genVersion (Version)  Values(539.00)
GO

