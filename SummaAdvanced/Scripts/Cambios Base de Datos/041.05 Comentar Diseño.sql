IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 41.05)
begin
ALTER TABLE disEventos ADD Habilitado Sino null;
ALTER TABLE disAcciones ADD Habilitado Sino null;
end
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 41.05)
begin
update disEventos
set Habilitado = 1;

update disAcciones
set Habilitado = 1;

ALTER TABLE disEventos Alter column Habilitado Sino not null;
ALTER TABLE disAcciones Alter column Habilitado Sino not null;

INSERT INTO genVersion(Version) Values(41.05);


end
