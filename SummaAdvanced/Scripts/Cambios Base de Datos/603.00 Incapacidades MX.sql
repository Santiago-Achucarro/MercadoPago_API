Insert into genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) values(1605, 'MX', '01', 'Riesgo de trabajo')
Insert into genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) values(1605, 'MX', '02', 'Enfermedad en general')
Insert into genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) values(1605, 'MX', '03', 'Maternidad')
Insert into genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) values(1605, 'MX', '04', 'Licencia por cuidados m�dicos de hijos diagnosticados con c�ncer')

Alter table sueConceptos Alter Column TipoIncapacidad VarChar(2)
GO

GO
INSERT INTO genVersion(Version) Values(603.00)
GO


