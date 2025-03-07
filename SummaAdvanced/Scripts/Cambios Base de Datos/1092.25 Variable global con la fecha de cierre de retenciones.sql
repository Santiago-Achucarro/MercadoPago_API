INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
SELECT genEmpresas,'ImpCierreRetenciones','Fecha cierre retenciones Pagos Proveedores', 'F',12,0,'IMP','',0,0,NULL, NULL, '20191231' FROM GENEMPRESAS
Go

insert into genVersion(Version) values(1092.25)