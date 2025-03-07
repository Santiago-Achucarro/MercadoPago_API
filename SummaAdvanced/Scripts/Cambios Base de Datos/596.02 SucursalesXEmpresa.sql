create TABLE genUsuariosSucursal
(
    Usuario_Id int,
    Sucursal_Id int,
    Empresa_Id int,
    constraint FKUsuario_UsuarioSucursal foreign key (Usuario_Id) references genUsuarios(genUsuarios),
    constraint FKSucursal_UsuarioSucursal foreign key (Sucursal_Id) references genSucursalesEmpr(genSucursalesEmpr),
    constraint FKEmpresa_UsuarioSucursal foreign key (Empresa_Id) references genEmpresas(genEmpresas)
)
insert into genVersion(version)values(596.02)