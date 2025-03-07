
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 47.05)
begin
Alter Table discontrolesGrilla add AccionNuevoValorNodo varchar(30) NOT NULL Default 'Ninguna';



INSERT INTO genVersion(Version) Values(47.05);

end

go

