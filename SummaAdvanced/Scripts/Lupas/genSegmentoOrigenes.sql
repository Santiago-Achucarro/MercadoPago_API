IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genSegmentoOrigenes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genSegmentoOrigenes','Origenes de Segmentos','OriSeg_Id,Descripcion','genSegmentoOrigenes','','','OriSeg_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origenes de Segmentos', CamposSelect='OriSeg_Id,Descripcion', FromSelect='genSegmentoOrigenes', WhereSelect='', OrderByDefault='', CamposClaves='OriSeg_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genSegmentoOrigenes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genSegmentoOrigenes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentoOrigenes'),'OriSeg_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentoOrigenes'),'Descripcion')
