IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 16.02)
begin

INSERT INTO genVersion(Version) Values(16.02);

alter table venSubTipoMov add Reporte_Id int
ALTER TABLE comTipoPermi add Reporte_Id int

END

