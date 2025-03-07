IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'afiResponsables')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('afiResponsables','Responsables','Responsable_Id,Descripcion,Posteado,Inactivo','afiResponsables','','','Responsable_Id','Descripcion', 'Upper', '',15)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Responsables', CamposSelect='Responsable_Id,Descripcion,Posteado,Inactivo', FromSelect='afiResponsables', WhereSelect='', OrderByDefault='', CamposClaves='Responsable_Id', CampoDescripcion='Descripcion', CharCasing='Upper', Mascara='', MaximaLongitud=15
     WHERE Identidad_Id='afiResponsables'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('afiResponsables')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Responsable_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Inactivo')
