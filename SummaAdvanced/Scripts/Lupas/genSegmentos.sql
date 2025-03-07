IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genSegmentos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('genSegmentos','Segmentos','Segmento_Id,Descripcion,Inactivo,Posteado, EsSueldos','genSegmentos','','','Segmento_Id','Descripcion','7230')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Segmentos', CamposSelect='Segmento_Id,Descripcion,Inactivo,Posteado,EsSueldos', FromSelect='genSegmentos', WhereSelect='', OrderByDefault='', CamposClaves='Segmento_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7230'
     WHERE Identidad_Id='genSegmentos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genSegmentos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentos'),'Segmento_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentos'),'Descripcion')
