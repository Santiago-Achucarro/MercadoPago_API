IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 33.02)
begin

Alter table genEmpresas Add CFAjusCtaCte int ;
ALTER TABLE genEmpresas
	ADD CONSTRAINT R_3993 FOREIGN KEY (CFAjusCtaCte) REFERENCES stkCondFisVenta(stkCondFisVenta);

INSERT INTO genVersion(Version) Values(33.02);

end
