
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 43.05)
begin
Alter Table discontrolesGrilla ADD EsArbol bit DEFAULT 0 NOT NULL;

INSERT INTO genVersion(Version) Values(43.05);

end

go


