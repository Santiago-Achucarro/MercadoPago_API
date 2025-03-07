
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 26.00)
begin



alter table disControlesDownLoad add ExtensionArchivo varchar(10);
alter table disControlesDownLoad add EsUrl bit;

end

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 26.00)
begin

INSERT INTO genVersion(Version) Values(26.00);

Update disControlesDownLoad set ExtensionArchivo = '', EsUrl = 0;

alter table disControlesDownLoad alter column ExtensionArchivo varchar(10) not null;
alter table disControlesDownLoad alter column EsUrl bit not null;

end

