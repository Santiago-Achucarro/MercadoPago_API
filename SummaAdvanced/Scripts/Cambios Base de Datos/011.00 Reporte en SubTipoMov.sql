IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 11.00)
begin

INSERT INTO genVersion(Version) Values(11.00);

Alter table stkSubTipoMov add Reporte_Id Int;

end