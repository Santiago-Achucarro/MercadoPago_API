IF exists(SELECT Dominio_Id FROM genInstalacion where Dominio_Id = 'MX')
	update genLexico set Token = 103 where Funcion ='DIASAG'

INSERT INTO genVersion(Version) Values(1066.00)
GO
