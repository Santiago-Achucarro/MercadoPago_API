IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comordencomp')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('comordencomp','Ordenes de Compra','Proveed_Id,RazonSocial,Fecha,Estado_Id,CondPago_Id,Moneda_Id, Monto,Observaciones,TipoPermi_Id,TipoCuerpo,Empresa,Importaciones,vcomOrdencomp.comOrdenComp ','vcomOrdencomp','','Fecha Desc','','', 'comOrdenComp','comOCSegmentos', 'comOrdenComp')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ordenes de Compra', 
		CamposSelect='Proveed_Id,RazonSocial,Fecha,Estado_Id,CondPago_Id,Moneda_Id, Monto,Observaciones, TipoPermi_Id,TipoCuerpo,Empresa,Importaciones,vcomOrdencomp.comOrdenComp ', 
		FromSelect='vcomOrdencomp', 
		WhereSelect='', OrderByDefault='Fecha Desc, comOrdenComp Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'comOrdenComp',
		 VistaSeg = 'comOCSegmentos', 
		 CampoPKVistaSeg = 'comOrdenComp'
		     WHERE Identidad_Id='comordencomp'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comordencomp')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'TipoPermi_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Monto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Observaciones')


