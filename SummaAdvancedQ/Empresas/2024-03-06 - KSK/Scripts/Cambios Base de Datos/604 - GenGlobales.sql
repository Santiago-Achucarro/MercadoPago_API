select b.name + ',' from sysobjects a inner join syscolumns b on a.id = b.id where a.name = 'GenGlobales' order by b.colorder

insert into GenGlobales (Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10)
values (1,	'ESPVENCLIENTECONSFINAL1','Cliente Local Consumidor Final', 	'C', 	15,	0,	NULL,	'11111111',	NULL,	NULL,	'VEN',	'False',	NULL	, NULL)

select * from genGlobales

insert into GenGlobales (Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10)
values (1,	'ESPVENAPIDIRECCION','Direccion de la Api de la Fiscal', 	'C', 	50,	0,	NULL,	'http://192.168.100.120:7123/api',	NULL,	NULL,	'VEN',	'False',	NULL	, NULL)


Insert into genVersionEmpresas (Version) Values (604)
GO

