IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueArchivosTxt')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueArchivosTxt','ArchivosTxt','Archivo_Id,Descripcion','sueArchivosTxt','','','Archivo_Id','Descripcion','S14050')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='ArchivosTxt', CamposSelect='Archivo_Id,Descripcion', FromSelect='sueArchivosTxt', WhereSelect='', OrderByDefault='', CamposClaves='Archivo_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario= 'S14050'
     WHERE Identidad_Id='sueArchivosTxt'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueArchivosTxt')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueArchivosTxt'),'Archivo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueArchivosTxt'),'Descripcion')

