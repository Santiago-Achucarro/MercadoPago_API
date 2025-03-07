Alter table venMovConStockCr Add Centro1_Id integer  NULL
Go
Alter table venMovConStockCr Add Centro2_Id integer  NULL
Go

ALTER TABLE venMovConStockCr
	ADD CONSTRAINT R_4062 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go

ALTER TABLE venMovConStockCr
	ADD CONSTRAINT R_4063 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go

Alter table venPediCuerpo Add Centro1_Id integer  NULL
Go
Alter table venPediCuerpo Add Centro2_Id integer  NULL
Go


ALTER TABLE venPediCuerpo
	ADD CONSTRAINT R_4064 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go

ALTER TABLE venPediCuerpo
	ADD CONSTRAINT R_4065 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go

Insert Into genVersion (Version) Values (71.10)
Go

