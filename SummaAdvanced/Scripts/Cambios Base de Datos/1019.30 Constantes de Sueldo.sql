alter table sueVarGlobales add Codigo varchar(20) null
alter table sueTabTitulo add Codigo varchar(20) null
alter table sueGanTitulo add Codigo varchar(20) null

alter table sueLiqVarGlobales add Ver int null
alter table sueTabla add Ver int null
alter table sueGanancias add Ver int null

Insert Into genVersion (Version) Values (1019.30)
Go