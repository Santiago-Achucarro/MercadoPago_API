IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conRubros')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('conRubros','Rubros','Rubro_Id,Descripcion','conRubros','','','Rubro_Id','Descripcion','3160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Rubros', CamposSelect='Rubro_Id,Descripcion', FromSelect='conRubros', WhereSelect='', OrderByDefault='', CamposClaves='Rubro_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '3160'
     WHERE Identidad_Id='conRubros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conRubros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conRubros'),'Rubro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conRubros'),'Descripcion')
