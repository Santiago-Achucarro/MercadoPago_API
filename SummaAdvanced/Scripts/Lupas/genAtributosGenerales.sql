IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genAtributosGenerales')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genAtributosGenerales','Atributos de las tablas','AtributoNro,Descripcion,Tabla_Id,Tipo,EnGrilla','genAtributosGenerales','','','AtributoNro','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Atributos de las tablas', CamposSelect='AtributoNro,Descripcion,Tabla_Id,Tipo,EnGrilla', FromSelect='genAtributosGenerales', WhereSelect='', OrderByDefault='', CamposClaves='AtributoNro', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genAtributosGenerales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genAtributosGenerales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genAtributosGenerales'),'AtributoNro')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genAtributosGenerales'),'Descripcion')
