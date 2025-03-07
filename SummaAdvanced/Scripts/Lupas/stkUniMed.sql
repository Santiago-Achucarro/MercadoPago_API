IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkUniMed')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkUniMed','Unidades_De_Medida','Medida_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkUniMed','','Medida_Id','Medida_Id','Descripcion','2120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Unidades_De_Medida', CamposSelect='Medida_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkUniMed', WhereSelect='', OrderByDefault='Medida_Id', CamposClaves='Medida_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2120'
     WHERE Identidad_Id='stkUniMed'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkUniMed')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkUniMed'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkUniMed'),'Descripcion')
