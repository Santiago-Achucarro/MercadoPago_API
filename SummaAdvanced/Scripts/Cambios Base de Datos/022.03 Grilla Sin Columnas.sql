
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 22.03)
begin

Alter Table discontrolesGrilla add AutoFormateable bit;

end
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 22.03)
begin

Update disControlesGrilla set AutoFormateable = 0;
Alter Table discontrolesGrilla alter column AutoFormateable bit NOT NULL;

INSERT INTO genVersion(Version) Values(22.03);

end

