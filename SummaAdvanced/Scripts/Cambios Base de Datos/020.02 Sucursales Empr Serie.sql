
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 20.02)
begin

INSERT INTO genVersion(Version) Values(20.02);
-- RevisarCuenta Contable
alter table genSucursalesEmpr add Serie varchar(25)
end
go
