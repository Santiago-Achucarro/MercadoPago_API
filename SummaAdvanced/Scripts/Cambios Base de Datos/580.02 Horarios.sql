CREATE TABLE genDiasLogin (
  Lunes SiNo,
  Martes SiNo,
  Miercoles SiNo,
  Jueves SiNo,
  Viernes SiNo,
  Sabado SiNo,
  Domingo SiNo,
  Festivos SiNo,
  Usuario_Id int,
  HoraDesde char(5),
  HoraHasta char(5)
  
)
go
create table genDiasFestivos (
    Fecha DATETIME not null,
    Descripcion varchar(30),
	Primary KEY(Fecha)

)

ALTER TABLE genDiasLogin
	ADD CONSTRAINT genDiasLoginUsuarioFK FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
  go

alter table genUsuarios ADD
RestringeHorarios SiNo not null
CONSTRAINT D_genUsuarios_RestringeHorarios
 DEFAULT (0)

insert into genVersion (Version) values (580.02)
