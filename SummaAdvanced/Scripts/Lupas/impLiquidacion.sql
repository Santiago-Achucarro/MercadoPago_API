



IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impLiquidacion')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('impLiquidacion','Liquidacion Impuestos','conAsientos,Impuesto_Id,FechaPago,FechaDesde,FechaHasta,TotalaPagar,SePaga,Empresa,Pendiente,Descripcion','vimpLiquidacion','','FechaPago Desc','','', 'conAsientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion Impuestos', 
		CamposSelect='conAsientos,Impuesto_Id,FechaPago,FechaDesde,FechaHasta,TotalaPagar,SePaga,Empresa,Pendiente,Descripcion', 
		FromSelect='vimpLiquidacion', 
		WhereSelect='', OrderByDefault='FechaPago Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'conAsientos',
		 VistaSeg = 'genAsiSegmentos', 
		 CampoPKVistaSeg = 'Asiento_Id'
		     WHERE Identidad_Id='impLiquidacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impLiquidacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'FechaPago')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'TotalaPagar')




