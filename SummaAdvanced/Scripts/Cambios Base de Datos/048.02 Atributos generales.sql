





IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 48.02)
begin

	Alter table genAtributosGenerales Add EnGrilla Sino null;

end
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 48.02)
begin

	Update genAtributosGenerales Set EnGrilla = 1;

	Alter table genAtributosGenerales Alter column EnGrilla Sino Not Null;

	INSERT INTO genVersion(Version) Values(48.02);

END