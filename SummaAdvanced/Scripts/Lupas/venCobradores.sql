IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCobradores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venCobradores','Cobradores','Cobrador_Id,Nombre,Inactivo,Posteado,Empresa_Id','venCobradores','','','Cobrador_Id','Nombre','51220')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cobradores', CamposSelect='Cobrador_Id,Nombre,Inactivo,Posteado,Empresa_Id', FromSelect='venCobradores', WhereSelect='', OrderByDefault='', CamposClaves='Cobrador_Id', CampoDescripcion='Nombre',
		OrdenMenuFormulario = '51220'
     WHERE Identidad_Id='venCobradores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCobradores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCobradores'),'Cobrador_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCobradores'),'Nombre')
