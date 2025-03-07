IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 34.02)
begin
	Alter table comMovProv Alter Column TipoCtaProv Int Null;

	INSERT INTO genVersion(Version) Values(34.02);

end
Go
