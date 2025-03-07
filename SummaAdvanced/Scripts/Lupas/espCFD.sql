IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espCFD')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espCFD','FOLIOS CFDI','NroMOV,FechaRegistro,Proveed_Id','espCFD','','FechaRegistro,Proveed_Id','NroMOV','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='FOLIOS CFDI', CamposSelect='NroMOV,FechaRegistro,Proveed_Id', FromSelect='espCFD', WhereSelect='', OrderByDefault='FechaRegistro,Proveed_Id', CamposClaves='NroMOV', CampoDescripcion=''
     WHERE Identidad_Id='espCFD'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espCFD')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('espCFD'),'NroMOV')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('espCFD'),'FechaRegistro')
