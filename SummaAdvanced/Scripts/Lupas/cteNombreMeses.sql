IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'cteNombreMeses')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('cteNombreMeses','Meses','Valor, Descripcion','vcteNombreMeses','','Valor','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Meses', 
	 CamposSelect='Valor, Descripcion', 
	 FromSelect='vcteNombreMeses', 
	 WhereSelect='', 
	 OrderByDefault='Valor', 
	 CamposClaves='Valor'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='cteNombreMeses'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('cteNombreMeses')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteNombreMeses'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteNombreMeses'),'Descripcion')
GO
