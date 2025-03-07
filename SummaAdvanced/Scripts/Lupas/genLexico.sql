IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genLexico')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genLexico','Formulas','Funcion,Descripcion,SetFunciones,TipoDato','genLexico','','','Funcion','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Formulas', CamposSelect='Funcion,Descripcion,SetFunciones,TipoDato', FromSelect='genLexico', WhereSelect='', OrderByDefault='', CamposClaves='Funcion', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genLexico'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genLexico')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLexico'),'Funcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLexico'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLexico'),'TipoDato')
