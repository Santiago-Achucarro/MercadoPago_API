IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'cteMeses')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('cteMeses','Meses','Valor, Descripcion','vcteMeses','','Valor','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Meses', 
	 CamposSelect='Valor, Descripcion', 
	 FromSelect='vcteMeses', 
	 WhereSelect='', 
	 OrderByDefault='Valor', 
	 CamposClaves='Valor'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='cteMeses'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('cteMeses')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteMeses'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteMeses'),'Descripcion')
GO
