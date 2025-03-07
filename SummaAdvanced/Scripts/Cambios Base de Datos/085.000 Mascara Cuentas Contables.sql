
Alter Table genInstalacion Add conDigiCta Smallint 
Alter Table genInstalacion Add conDigiSubCta Smallint 
Alter Table genInstalacion Add contMascaraCuenta VarChar(25)
GO

Update genInstalacion SET conDigiCta = (select nValor from genGlobales where Nombre_Var = 'CONTDIGICTA' and Empresa_id = 1)
Update genInstalacion SET conDigiSubCta = (select nValor from genGlobales where Nombre_Var = 'CONTDIGISUBCTA' and Empresa_id = 1)
Update genInstalacion SET contMascaraCuenta = (select cValor from genGlobales where Nombre_Var = 'CONTMASCARACUENTA' and Empresa_id = 1)
GO


Alter Table genInstalacion Alter Column conDigiCta Smallint  NOT NULL
Alter Table genInstalacion Alter Column conDigiSubCta Smallint  NOT NULL
Alter Table genInstalacion Alter Column contMascaraCuenta VarChar(25) NOT NULL
GO

INSERT INTO genVersion (Version) Values(85.000)
GO


        
		