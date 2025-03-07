IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conTiposSAT')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conTiposSAT','Tipos SAT','TipoSat_Id,Descripcion','conTiposSAT','','TipoSat_Id','TipoSat_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos SAT', CamposSelect='TipoSat_Id,Descripcion', FromSelect='conTiposSAT', WhereSelect='', OrderByDefault='TipoSat_Id', CamposClaves='TipoSat_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conTiposSAT'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conTiposSAT')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposSAT'),'TipoSat_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposSAT'),'Descripcion')
