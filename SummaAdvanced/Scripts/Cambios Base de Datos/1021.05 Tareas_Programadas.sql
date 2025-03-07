CREATE TABLE genTareas(
	genTareas int NOT NULL,
	Tarea_Id varchar(80) NOT NULL,
	Descripcion varchar(200) NOT NULL,
	CONSTRAINT XPKgenTareas PRIMARY KEY CLUSTERED (genTareas)
)
GO
CREATE UNIQUE NONCLUSTERED INDEX XAK1genTareas ON genTareas (Tarea_Id ASC)
GO

CREATE TABLE genTareasParametros(
	Tarea_Id int NOT NULL,
	Parametro varchar(40) NOT NULL,
	Descripcion varchar(200) NOT NULL,
	Obligatorio SiNo, 
	CONSTRAINT XPKgenTareasParametros PRIMARY KEY CLUSTERED (Tarea_Id, Parametro)
)
GO
ALTER TABLE genTareasParametros ADD FOREIGN KEY(Tarea_Id) REFERENCES genTareas (genTareas)
GO



CREATE TABLE genTiposEjecucionTarea(
	TipoEjecucionTarea_Id varchar(2) NOT NULL,
	Descripcion varchar(30) NOT NULL,
	CONSTRAINT XPKgenTiposEjecucionTarea PRIMARY KEY CLUSTERED (TipoEjecucionTarea_Id)
)
GO

INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('1', 'UNICA VEZ')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('2', 'REPETITIVA')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('3', 'DIARIAMENTE')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('4', 'SEMANALMENTE')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('5', 'MENSUALMENTE')


CREATE TABLE genTareasProgramadas(
	genTareasProgramadas int IDENTITY(1,1) NOT NULL,
	TareaProgramada_Id varchar(80) NOT NULL,
	Descripcion varchar(200) NOT NULL,
	Tarea_Id int NOT NULL,
	FechaInicio qFechaHora NOT NULL,
	HoraInicio varchar(5) NOT NULL,
	FechaFin qFechaHora NULL,
	HoraFin varchar(5) NULL,
	TipoEjecucionTarea_Id varchar(2) NOT NULL,
	Empresa_Id int, 
	Inactivo Sino NOT NULL,
	Usuario_Id int NOT NULL,
	Posteado Sino NOT NULL
	CONSTRAINT XPKgenTareasProgramadas PRIMARY KEY CLUSTERED (genTareasProgramadas)
)
GO
CREATE UNIQUE NONCLUSTERED INDEX XAK1genTareasProgramadas ON genTareasProgramadas (TareaProgramada_Id ASC)
GO

ALTER TABLE genTareasProgramadas ADD FOREIGN KEY(Empresa_Id) REFERENCES genEmpresas (genEmpresas)
GO

ALTER TABLE genTareasProgramadas ADD FOREIGN KEY(Usuario_Id) REFERENCES genUsuarios (genUsuarios)
GO

ALTER TABLE genTareasProgramadas ADD FOREIGN KEY(TipoEjecucionTarea_Id) REFERENCES genTiposEjecucionTarea (TipoEjecucionTarea_Id)
GO

ALTER TABLE genTareasProgramadas ADD FOREIGN KEY(Tarea_Id) REFERENCES genTareas (genTareas)
GO

CREATE TABLE genTareasProgParametros(
	TareaProgramada_Id int NOT NULL,
	Parametro varchar(40) NOT NULL,
	Valor varchar(80)
	CONSTRAINT XPKgenTareasProgParametros PRIMARY KEY CLUSTERED (TareaProgramada_Id, Parametro)
)
GO

ALTER TABLE genTareasProgParametros ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgramadas (genTareasProgramadas)
GO



CREATE TABLE genTareasProgConRepeticion(
	TareaProgramada_Id int NOT NULL,
	Valor int NOT NULL,
	UnidadMedida varchar(15) NOT NULL
	CONSTRAINT XPKgenTareasProgConRepeticion PRIMARY KEY CLUSTERED (TareaProgramada_Id)
)
GO

ALTER TABLE genTareasProgConRepeticion ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgramadas (genTareasProgramadas)
GO

CREATE TABLE genTareasProgDiarias(
	TareaProgramada_Id int NOT NULL,
	Valor int NOT NULL
	CONSTRAINT XPKgenTareasProgDiarias PRIMARY KEY CLUSTERED (TareaProgramada_Id)
)
GO

ALTER TABLE genTareasProgDiarias ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgramadas (genTareasProgramadas)
GO

CREATE TABLE genTareasProgSemanales(
	TareaProgramada_Id int NOT NULL,
	Valor int NOT NULL,
	Lunes SiNo NOT NULL,
	Martes SiNo NOT NULL,
	Miercoles SiNo NOT NULL,
	Jueves SiNo NOT NULL,
	Viernes SiNo NOT NULL,
	Sabado SiNo NOT NULL,
	Domingo SiNo NOT NULL,
	CONSTRAINT XPKgenTareasProgSemanales PRIMARY KEY CLUSTERED (TareaProgramada_Id)
)
GO

ALTER TABLE genTareasProgSemanales ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgramadas (genTareasProgramadas)
GO

CREATE TABLE genTareasProgMensuales(
	TareaProgramada_Id int NOT NULL,
	Enero SiNo NOT NULL,
	Febrero SiNo NOT NULL,
	Marzo SiNo NOT NULL,
	Abril SiNo NOT NULL,
	Mayo SiNo NOT NULL,
	Junio SiNo NOT NULL,
	Julio SiNo NOT NULL,
	Agosto SiNo NOT NULL,
	Septiembre SiNo NOT NULL,
	Octubre SiNo NOT NULL,
	Noviembre SiNo NOT NULL,
	Diciembre SiNo NOT NULL,
	CONSTRAINT XPKgenTareasProgMensuales PRIMARY KEY CLUSTERED (TareaProgramada_Id)
)
GO
ALTER TABLE genTareasProgMensuales ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgramadas (genTareasProgramadas)
GO

CREATE TABLE genTareasProgMensualesXDia(
	TareaProgramada_Id int NOT NULL,
	Dia_1 SiNo NOT NULL,
	Dia_2 SiNo NOT NULL,
	Dia_3 SiNo NOT NULL,
	Dia_4 SiNo NOT NULL,
	Dia_5 SiNo NOT NULL,
	Dia_6 SiNo NOT NULL,
	Dia_7 SiNo NOT NULL,
	Dia_8 SiNo NOT NULL,
	Dia_9 SiNo NOT NULL,
	Dia_10 SiNo NOT NULL,
	Dia_11 SiNo NOT NULL,
	Dia_12 SiNo NOT NULL,
	Dia_13 SiNo NOT NULL,
	Dia_14 SiNo NOT NULL,
	Dia_15 SiNo NOT NULL,
	Dia_16 SiNo NOT NULL,
	Dia_17 SiNo NOT NULL,
	Dia_18 SiNo NOT NULL,
	Dia_19 SiNo NOT NULL,
	Dia_20 SiNo NOT NULL,
	Dia_21 SiNo NOT NULL,
	Dia_22 SiNo NOT NULL,
	Dia_23 SiNo NOT NULL,
	Dia_24 SiNo NOT NULL,
	Dia_25 SiNo NOT NULL,
	Dia_26 SiNo NOT NULL,
	Dia_27 SiNo NOT NULL,
	Dia_28 SiNo NOT NULL,
	Dia_29 SiNo NOT NULL,
	Dia_30 SiNo NOT NULL,
	Dia_31 SiNo NOT NULL,
	Ultimo SiNo NOT NULL,
	CONSTRAINT XPKgenTareasProgMensualesXDia PRIMARY KEY CLUSTERED (TareaProgramada_Id)
)
GO
ALTER TABLE genTareasProgMensualesXDia ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgMensuales (TareaProgramada_Id)
GO


CREATE TABLE genTareasProgMensualesXDiaSemana(
	TareaProgramada_Id int NOT NULL,
	Primero SiNo NOT NULL,
	Segundo SiNo NOT NULL,
	Tercero SiNo NOT NULL,
	Cuarto SiNo NOT NULL,
	Ultimo SiNo NOT NULL,
	Lunes SiNo NOT NULL,
	Martes SiNo NOT NULL,
	Miercoles SiNo NOT NULL,
	Jueves SiNo NOT NULL,
	Viernes SiNo NOT NULL,
	Sabado SiNo NOT NULL,
	Domingo SiNo NOT NULL,
	CONSTRAINT XPKgenTareasProgMensualesXDiaSemana PRIMARY KEY CLUSTERED (TareaProgramada_Id)
)
GO

ALTER TABLE genTareasProgMensualesXDiaSemana ADD FOREIGN KEY(TareaProgramada_Id) REFERENCES genTareasProgMensuales (TareaProgramada_Id)
GO

INSERT INTO genVersion(Version) Values(1021.05);
GO

