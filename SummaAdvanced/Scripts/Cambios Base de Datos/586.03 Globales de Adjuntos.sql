
insert into  genGlobales (Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,mValor,SubSistema,
SoloLectura,lupIdentidad,WhereF10)
select genEmpresas, 'PATHADJUNTOSCLIE','Ruta de adjuntos de clientes','C',120,0,null,null,null,null,'VEN',0,null,null
from genEmpresas
go

insert into  genGlobales (Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,mValor,SubSistema,
SoloLectura,lupIdentidad,WhereF10)
select genEmpresas,'PATHADJUNTOSCONFORMAS','Ruta de adjuntos de clientes','C',120,0,null,null,null,null,'VEN',0,null,null
from genEmpresas
GO

INSERT INTO genVersion (Version) Values('586.03')
GO
