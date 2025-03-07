IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 13.02)
begin

INSERT INTO genVersion(Version) Values(13.02);
create table stkInvMoviStk
(stkMoviCabe bigint not null,
stkInventarios int not null,
primary key(stkMoviCabe)
);
alter table stkInvMoviStk add foreign key(stkMoviCabe) references stkMoviCabe;
alter table stkInvMoviStk add foreign key(stkInventarios) references stkInventarios;
insert into stkSubTipoMov (SubTipoMov_Id,TipoMov,Descripcion,Consumo,CantCopias,Reporte_Id) values('INVE','E','Inventario_Entrada',0,1,null);
insert into stkSubTipoMov (SubTipoMov_Id,TipoMov,Descripcion,Consumo,CantCopias,Reporte_Id) values('INVS','S','Inventario_Salida',0,1,null);
alter table genEmpresas add CtaAjuStockPos int;
alter table genEmpresas add CtaAjuStockNeg int;
end
