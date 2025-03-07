Alter table tesIdRetProv Drop column Formulario
Go

Alter table tesIdRetProv Add Reporte_Id Int
go

ALTER TABLE tesIdRetProv
	ADD CONSTRAINT R_4035 FOREIGN KEY (Reporte_Id) REFERENCES genReportes(genReportes)
go

Insert Into genVersion (Version) Values (66.10)
Go

