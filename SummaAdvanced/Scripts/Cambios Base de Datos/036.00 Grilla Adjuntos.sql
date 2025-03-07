
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 36.00)
begin

Alter Table discontrolesGrilla add EsGrillaAdjuntos bit;

end
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 36.00)
begin

Update disControlesGrilla set EsGrillaAdjuntos = 0;
Alter Table discontrolesGrilla alter column EsGrillaAdjuntos bit NOT NULL;

INSERT INTO genVersion(Version) Values(36.00);

end

