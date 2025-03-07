IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venNivelesAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venNivelesAuto','Niveles_de_Autorizacion_NP','NivelAuto_Id,Descripcion,Empresa_Id,Inactivo','venNivelesAuto','','','NivelAuto_Id','Descripcion','52105010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Niveles_de_Autorizacion_NP', CamposSelect='NivelAuto_Id,Descripcion,Empresa_Id,Inactivo', FromSelect='venNivelesAuto', WhereSelect='', OrderByDefault='', CamposClaves='NivelAuto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '52105010'
     WHERE Identidad_Id='venNivelesAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venNivelesAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venNivelesAuto'),'NivelAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venNivelesAuto'),'Descripcion')
