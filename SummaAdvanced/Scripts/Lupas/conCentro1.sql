IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro1')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro1','Centro de Costos','Centro1_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable','conCentro1','','','Centro1_Id','Descripcion','3125')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Costos', CamposSelect='Centro1_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable', FromSelect='conCentro1', WhereSelect='', OrderByDefault='', CamposClaves='Centro1_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '3125'
     WHERE Identidad_Id='conCentro1'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro1')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1'),'Centro1_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1'),'Nivel')

