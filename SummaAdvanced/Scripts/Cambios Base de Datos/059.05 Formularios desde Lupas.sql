IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 59.05)
begin
alter table lupIdentidades add OrdenMenuFormulario varchar(10)

INSERT INTO genVersion(Version) Values(59.05);
end
GO
