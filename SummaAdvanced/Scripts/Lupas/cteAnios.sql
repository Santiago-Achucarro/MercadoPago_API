IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'cteAnios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('cteAnios','Anios','Valor, Descripcion','vcteAnios','','Valor','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anios', 
	 CamposSelect='Valor, Descripcion', 
	 FromSelect='vcteAnios', 
	 WhereSelect='', 
	 OrderByDefault='Valor', 
	 CamposClaves='Valor'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='cteAnios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('cteAnios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteAnios'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteAnios'),'Descripcion')
GO
