IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conRubrosAxi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conRubrosAxi','Rubros Axi','RubroAxi_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conRubrosAxi','','','RubroAxi_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Rubros Axi', CamposSelect='RubroAxi_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conRubrosAxi', WhereSelect='', OrderByDefault='', CamposClaves='RubroAxi_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conRubrosAxi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conRubrosAxi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conRubrosAxi'),'RubroAxi_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conRubrosAxi'),'Descripcion', 0)
