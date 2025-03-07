IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comRIEstados')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comRIEstados','Estados de Requisitos Internos','EstadoRI_Id,Descripcion','comRIEstados','','','EstadoRI_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados de Requisitos Internos', CamposSelect='EstadoRI_Id,Descripcion', FromSelect='comRIEstados', WhereSelect='', OrderByDefault='', CamposClaves='EstadoRI_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comRIEstados'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comRIEstados')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comRIEstados'),'EstadoRI_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comRIEstados'),'Descripcion')
