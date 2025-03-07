ALTER Table proOrden Add Usuario_Id INT
GO
UPDATE proOrden SET Usuario_Id = 1
GO
ALTER Table proOrden Alter Column Usuario_Id INT NOT NULL
GO

ALTER TABLE proOrden
	ADD CONSTRAINT V2R_4276 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go

INSERT INTO genVersion(Version) VALUES(520.000)
GO