IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vconMetodos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vconMetodos','Metodos de Ajuste Contable','Metodo_Id,Descripcion,Dominio_Id','vconMetodos','','Metodo_Id','Metodo_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Metodos de Ajuste Contable', CamposSelect='Metodo_Id,Descripcion,Dominio_Id', FromSelect='vconMetodos', WhereSelect='', OrderByDefault='Metodo_Id', CamposClaves='Metodo_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vconMetodos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vconMetodos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vconMetodos'),'Metodo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vconMetodos'),'Descripcion')

