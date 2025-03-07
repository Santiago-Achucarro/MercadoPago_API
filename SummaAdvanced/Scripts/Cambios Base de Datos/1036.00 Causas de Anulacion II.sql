INSERT INTO  genEntidadesBasicas(Entidad_Id, Descripcion) Values(504, 'Causas Cancelacion')
GO

INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '01','Sustitucion')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '02','Error en Precio')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '03','El Cliente no lo quiere')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '04','Otras')
GO

INSERT INTO genVersion(Version) Values(1036.00)
go