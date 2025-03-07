create table swsAcciones
(
    Accion_Id varchar(200),
    CONSTRAINT swsAccionesPK PRIMARY key (Accion_Id),
    CONSTRAINT swsAccionesFK FOREIGN key (Accion_Id) REFERENCES sisAccionesConfig(Accion_Id)
)

create table swsUsuarios
(
    Usuario_Id INT,
    Password varchar(50),
    CONSTRAINT swsUsuariosFK  FOREIGN key (Usuario_Id) REFERENCES genUsuarios(genUsuarios),
    CONSTRAINT swsUsuariosPK PRIMARY key (Usuario_Id)
)

create table swsTokens
(
    Token varchar(40),
    Empresa_Id int,
    Usuario_Id int,
    ValidThru datetime,
    constraint swsTokensEmpresaFK foreign key (Empresa_Id) references genEmpresas(genEmpresas),
    constraint swsTokensUsuarioFK foreign key (Usuario_Id) references genUsuarios(genUsuarios),
    constraint swsTokensPK PRIMARY key (Token)
)

create table swsPermisos
(
    Usuario_Id int,
    Accion_Id varchar(200),
    constraint swsPermisosUsuarioFK foreign key (Usuario_Id) REFERENCES swsUsuarios(Usuario_Id),
    constraint swsPermisosAccionFK foreign key (Accion_Id) references swsAcciones(Accion_Id),
    CONSTRAINT swsPermisosPK PRIMARY key (Usuario_Id, Accion_Id)
)

insert into genVersion (Version) Values(1000.02)
GO