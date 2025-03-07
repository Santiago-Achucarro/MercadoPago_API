IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 13.00)
begin

INSERT INTO genVersion(Version) Values(13.00);

Alter table genEmpresas Drop Column FechaCierreImportaciones;

Alter table genEmpresas Add FechaCalculoStock DateTime;

update genEmpresas set FechaCalculoStock = FechaCierreStock;

Alter table genEmpresas ALTER COLUMN FechaCalculoStock DateTime NOT NULL;

Drop procedure genEmpresasSetFechaImportaciones;


end