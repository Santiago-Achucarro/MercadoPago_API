Alter table stkInventarios Add Centro1_Id integer  Null, Centro2_Id integer Null
Go

ALTER TABLE stkInventarios
	ADD CONSTRAINT R_4066 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go

ALTER TABLE stkInventarios
	ADD CONSTRAINT R_4067 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go

Insert into genVersion (Version) Values (73.10)
Go
