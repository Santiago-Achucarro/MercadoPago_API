
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 43.00)
begin

	
Alter table disFormularios Add Especializacion VarChar(80);

INSERT INTO genVersion(Version) Values(43.00);

END