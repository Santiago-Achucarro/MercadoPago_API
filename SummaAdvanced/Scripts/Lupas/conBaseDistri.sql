IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conBaseDistri')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conBaseDistri','Bases de Distribucion','Base_Id,Descripcion,Medida_Id,Inactivo,Posteado,Empresa_Id','conBaseDistri','','Base_Id','Base_Id','Descripcion','3140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Bases de Distribucion', CamposSelect='Base_Id,Descripcion,Medida_Id,Inactivo,Posteado,Empresa_Id', FromSelect='conBaseDistri', WhereSelect='', OrderByDefault='Base_Id', CamposClaves='Base_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '3140'
     WHERE Identidad_Id='conBaseDistri'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conBaseDistri')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conBaseDistri'),'Base_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conBaseDistri'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conBaseDistri'),'Medida_Id')
