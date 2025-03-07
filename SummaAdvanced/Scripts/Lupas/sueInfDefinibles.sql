IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueInfDefinibles')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('sueInfDefinibles','Informes Definibles','Informe_Id,Descripcion,Posteado,Inactivo,Empresa_Id','sueInfDefinibles','','','Informe_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Informes Definibles', CamposSelect='Informe_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='sueInfDefinibles', WhereSelect='', OrderByDefault='', CamposClaves='Informe_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='sueInfDefinibles'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueInfDefinibles')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Informe_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Empresa_Id')

