IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosPlantilla')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosPlantilla','Plantillas','Plantilla_Id,Descripcion,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion','stkProductosPlantilla','','','Plantilla_Id','Descripcion','21a0')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Plantillas', CamposSelect='Plantilla_Id,Descripcion,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion', FromSelect='stkProductosPlantilla', WhereSelect='', OrderByDefault='', CamposClaves='Plantilla_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '21a0'
     WHERE Identidad_Id='stkProductosPlantilla'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosPlantilla')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosPlantilla'),'Plantilla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosPlantilla'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosPlantilla'),'Medida_Id')
