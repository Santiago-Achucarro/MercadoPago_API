ALTER TABLE tesIdBancoPropio ADD RepoCheq_Id INT NULL
GO

ALTER TABLE tesIdBancoPropio ADD RepoCheqDif_Id INT NULL
GO

ALTER TABLE tesIdBancoPropio
	ADD CONSTRAINT R_4059 FOREIGN KEY (RepoCheq_Id) REFERENCES genReportes(genReportes)
go




ALTER TABLE tesIdBancoPropio
	ADD CONSTRAINT R_4060 FOREIGN KEY (RepoCheqDif_Id) REFERENCES genReportes(genReportes)
go


Insert Into genVersion (Version) Values (69.11)
Go
