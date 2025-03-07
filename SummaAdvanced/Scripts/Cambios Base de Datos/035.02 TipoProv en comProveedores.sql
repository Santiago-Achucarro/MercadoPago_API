IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 35.02)
begin

Insert into genVersion (Version) Values (35.02);

Alter table comProveedores Add ProvTipo_Id Integer Null;

ALTER TABLE comProveedores
	ADD CONSTRAINT R_4005 FOREIGN KEY (ProvTipo_Id) REFERENCES comProvTipos(comProvTipos);

End
