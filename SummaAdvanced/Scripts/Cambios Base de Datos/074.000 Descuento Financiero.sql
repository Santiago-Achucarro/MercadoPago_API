INSERT INTO genVersion (Version) Values(74.000)
GO

Alter Table comMovProv add RenglonDtoFin Int NULL
GO

ALTER TABLE comMovProv
	ADD CONSTRAINT R_4068 FOREIGN KEY (comMovProv,RenglonDtoFin) REFERENCES conMovCont(conAsientos,Renglon)
go


Alter table genEmpresas Add TipoDtoFin Char(1) 
Alter table genEmpresas Add MontoDtoFinanciero Numeric(19,2)
Alter table genEmpresas Add CtaDtoFinPos int
Alter table genEmpresas Add CtaDtoFinNeg int

ALTER TABLE genEmpresas
	ADD CONSTRAINT R_4069 FOREIGN KEY (CtaDtoFinPos) REFERENCES conCuentas(conCuentas)
go

ALTER TABLE genEmpresas
	ADD CONSTRAINT R_4070 FOREIGN KEY (CtaDtoFinNeg) REFERENCES conCuentas(conCuentas)
go

