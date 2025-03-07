IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 10.01)
begin

INSERT INTO genVersion(Version) Values(10.01);


Alter table venMovimientosCFDIR Alter Column TipoRelacion char(2) null;
End


