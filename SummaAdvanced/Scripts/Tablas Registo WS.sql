create database Registro
go
use Registro
go
create table swsTablasPlanas
(
    Clase varchar(200),
    Accion_Id varchar(200),
    Tabla varchar(200),
    EsTablaPlana bit,
    constraint swsTablasPlanasPK primary key (Clase, Accion_Id, Tabla)
)
create table swsControlesUsados
(
    Clase varchar(200),
    Accion_Id varchar(200),
    Tabla varchar(200),
    Control_Id varchar(200),
    Usado bit,
    CONSTRAINT swsControlesUadosPK Primary key (Clase, Accion_Id, Tabla, Control_Id),
    constraint swsControlesTablasFK foreign key (Clase, Accion_Id, Tabla) references swsTablasPlanas(Clase, Accion_Id, Tabla)
)


