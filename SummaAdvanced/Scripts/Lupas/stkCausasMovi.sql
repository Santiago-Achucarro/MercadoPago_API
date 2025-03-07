IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCausasMovi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkCausasMovi','Causa_de_Movimiento','Causa_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkCausasMovi','','','Causa_Id','Descripcion','2160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causa_de_Movimiento', CamposSelect='Causa_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkCausasMovi', WhereSelect='', OrderByDefault='', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2160'
     WHERE Identidad_Id='stkCausasMovi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCausasMovi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMovi'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMovi'),'Descripcion')
