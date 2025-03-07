
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 22.00)
begin

INSERT INTO genVersion(Version) Values(22.00);

Alter table genEmpresas add FechaCierreImpuestos DateTime


end