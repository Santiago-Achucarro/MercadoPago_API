IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 61.05)
begin
alter table genMenus add genMenus int identity not null;

INSERT INTO genVersion(Version) Values(61.05);

END
GO
