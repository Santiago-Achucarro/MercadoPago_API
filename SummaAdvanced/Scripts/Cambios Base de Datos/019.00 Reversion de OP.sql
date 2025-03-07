IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 19.00)
begin

INSERT INTO genVersion(Version) Values(19.00);


INSERT INTO comMovTipos (Tipomov, Descripcion, Signo) Values('Q','Reversion OP', -1)

END


