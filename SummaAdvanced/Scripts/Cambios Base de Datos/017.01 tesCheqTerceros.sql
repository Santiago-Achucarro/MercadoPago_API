IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 17.01)
begin

INSERT INTO genVersion(Version) Values(17.01);

Alter table tesCheqTerceros Add Empresa_Id Int;
Update tesCheqTerceros Set Empresa_Id = 1 Where Not BancoConc Is Null;

ALTER TABLE tesCheqTerceros
	ADD CONSTRAINT R_3963 FOREIGN KEY (Empresa_Id,BancoConc,NumeroConc) REFERENCES tesConciliacion(Empresa_Id,tesIdentifica,NumeroConc);

End