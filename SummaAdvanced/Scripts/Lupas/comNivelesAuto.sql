IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comNivelesAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('comNivelesAuto','Niveles_de_Autorizacion_OC','NivelAuto_Id,Descripcion,Empresa_Id,Inactivo','comNivelesAuto','','','NivelAuto_Id','Descripcion','1336')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Niveles_de_Autorizacion_OC', CamposSelect='NivelAuto_Id,Descripcion,Empresa_Id,Inactivo', FromSelect='comNivelesAuto', WhereSelect='', OrderByDefault='', CamposClaves='NivelAuto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '1336'
     WHERE Identidad_Id='comNivelesAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comNivelesAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comNivelesAuto'),'NivelAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comNivelesAuto'),'Descripcion')
