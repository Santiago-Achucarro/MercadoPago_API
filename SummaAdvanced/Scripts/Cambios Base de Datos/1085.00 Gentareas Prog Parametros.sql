if NOT exists(select 1 from sysobjects where name ='genTareasProgParametros' and type = 'U')
BEGIN
CREATE TABLE genTareasProgParametros(
	TareaProgramada_Id int NOT NULL,
	Parametro varchar(40) NOT NULL,
	Valor varchar(80)
	CONSTRAINT XPKgenTareasProgParametros PRIMARY KEY CLUSTERED (TareaProgramada_Id, Parametro)
);


ALTER TABLE genTareasProgMensualesXDiaSemana ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgMensuales (TareaProgramada_Id);
ALTER TABLE genTareasProgramadas alter column 	FechaFin qFechaHora NULL;
ALTER TABLE genTareasProgramadas alter column HoraFin varchar(5) NULL;

END
GO

insert into genVersion (Version) VALUES(1085.00)
go
