IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro2SinPorAster')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro2SinPorAster','Centro de Costos Alternativo','Centro2_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable','conCentro2','Centro2_Id Not In (''%'', ''*'')','','Centro2_Id','Descripcion','3130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Costos Alternativo', CamposSelect='Centro2_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable', FromSelect='conCentro2', WhereSelect='Centro2_Id Not In (''%'', ''*'')', OrderByDefault='', CamposClaves='Centro2_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3130'
     WHERE Identidad_Id='conCentro2SinPorAster'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro2SinPorAster')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2SinPorAster'),'Centro2_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2SinPorAster'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2SinPorAster'),'Nivel')