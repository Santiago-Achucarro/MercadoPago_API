insert into genVersion (Version) values (50.02)
drop table conCuentasSinSC
go
create table conCuentasSinSC

(
    Cuenta_Id int NOT NULL,
    Descripcion varchar(80) NULL,
	foreign key (Cuenta_Id) references conCuentas(conCuentas)
);

insert into conCuentasSinSC (Cuenta_Id,Descripcion)
select conCuentas.conCuentas, Descripcion from conCuentas where Rubro_Id in('5','6') and Imputable=0 and nivel >=3