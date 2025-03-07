IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genlocalidades')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genlocalidades','Localidades Mx','c_Localidad,Descripcion,c_Estado','genlocalidades','','','c_Localidad','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Localidades Mx', CamposSelect='c_Localidad,Descripcion,c_Estado', FromSelect='genlocalidades', WhereSelect='', OrderByDefault='', CamposClaves='c_Localidad', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genlocalidades'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genlocalidades')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genlocalidades'),'c_Localidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genlocalidades'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genlocalidades'),'c_Estado')
