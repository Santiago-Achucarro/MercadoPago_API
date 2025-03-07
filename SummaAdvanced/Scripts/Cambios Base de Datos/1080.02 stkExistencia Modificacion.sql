alter table stkexistencia add UltimaModificacion datetime

create table wooUltActualizacionStock 
(
    Fecha datetime,
    Empresa_Id int,
    constraint wooUltActualizacionStockFKEmpresa foreign key (Empresa_Id) references genEmpresas(genEmpresas)
)
go

alter table wooorders add 
venMovimientos bigint
go

alter table wooOrdersLineItemProperties add
Renglon int
go

insert into genversion (version) values (1080.02)
go

