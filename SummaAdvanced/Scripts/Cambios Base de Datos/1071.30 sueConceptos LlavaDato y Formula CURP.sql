

insert into genLexico (SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato)
values
('SUELEXICO','CURP','CURP',103,'C')
go


insert into genLexico (SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato)
values
('SUELEXICO','DOC','Documento',103,'C')
go


update sueConceptos set LlevaDato =0 where Formula not Like '%DATO()%'
go
update sueConceptos set LlevaDato =1 where Formula  Like '%DATO()%'
go


insert into genVersion(Version) Values(1071.30)
GO