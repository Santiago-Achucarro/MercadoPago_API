
UPDATE genGlobales set mValor = 'MgAyADIAMAA0ADUAOgA1ADIAMQAwADEAMAA6ADUAMgAyADAAOQAwADoANQAzADEAMAAwADAAOgA1ADMAMQAwADcAMAA6ADUAMwA0ADAAMQAwADoANQAzADQAMAAyADAA' where Nombre_Var = 'GENCLIENTESMENU'
GO

Alter table venLibros Alter Column Empresa_Id Int NULL
GO

Alter table comLibros Alter Column Empresa_Id Int NULL
GO

INSERT INTO genVersion(Version) Values(1011.00)
GO