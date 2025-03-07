IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 58.05)
begin
alter table disFormularios add Version varchar(10)
INSERT INTO genVersion(Version) Values(58.05);
end
GO
