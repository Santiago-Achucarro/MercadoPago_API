alter table comDespachos Add TomaCambioTes bit 
GO
update comDespachos set TomaCambioTes = 0
GO

alter table comDespachos ALTER COLUMN TomaCambioTes bit NOT NULL
GO

insert into genVersion(Version) Values(612.00)
GO

