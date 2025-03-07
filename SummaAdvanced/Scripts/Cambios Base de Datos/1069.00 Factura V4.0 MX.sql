ALTER TABLE venClientes Add Regimen VarChar(5)
go

Update venClientes set Regimen = '601'
GO

Update venClientes set Regimen = '610' where exists(select 1 from genEntidades where
	genEntidades.genEntidades = venClientes.genEntidades and 
	genEntidades.Cuit = 'XEXX010101000')
GO

Update venClientes set Regimen = '612' where exists(select 1 from genEntidades where
	genEntidades.genEntidades = venClientes.genEntidades and 
	LEN(trim(genEntidades.Cuit)) = 13 and
	Cuit NOT IN('XEXX010101000','XEXA010101000'))
GO



Update venClientes set Regimen = '616' where exists(select 1 from genEntidades where
	genEntidades.genEntidades = venClientes.genEntidades  AND 
	Cuit IN('XEXX010101000','XEXA010101000'))


GO	

INSERT INTO genVersion(Version) Values(1069.00)
go




