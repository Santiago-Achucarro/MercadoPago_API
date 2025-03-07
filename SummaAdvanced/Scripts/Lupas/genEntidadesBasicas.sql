IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genEntidadesBasicas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genEntidadesBasicas','Entidades Basicas','Clave,Descripcion,Dominio_Id,Entidad_Id','genEntidadesBasicasValor','','Clave','Clave','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Entidades Basicas', CamposSelect='Clave,Descripcion,Dominio_Id,Entidad_Id', FromSelect='genEntidadesBasicasValor', WhereSelect='', OrderByDefault='Clave', CamposClaves='Clave', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genEntidadesBasicas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genEntidadesBasicas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genEntidadesBasicas'),'Clave')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genEntidadesBasicas'),'Descripcion')
