IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 11.01)
begin

	INSERT INTO genVersion(Version) Values(11.01);

	Alter table venImpuestos Alter Column Formulacalc varChar(max) Not Null;
End
