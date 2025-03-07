IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueLiquidacion')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, 
	 OrderByDefault, CamposClaves, VistaSeg, 	CampoPKVistaSeg,CampoDescripcion, CampoFKTablaSeg)
       Values('sueLiquidacion','Liquidacion','vsueLiquidacion,Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado',
		'vsueLiquidaciones','','FechaInicial','','genAsiSegmentos','Asiento_Id','','vsueLiquidacion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion', 
	 CamposSelect='Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado', 
	 FromSelect='vsueLiquidaciones', 
	 WhereSelect='', 
	 OrderByDefault='FechaInicial desc', 
	 CamposClaves='', 
	 CampoFKTablaSeg='vsueLiquidacion',
	 VistaSeg='genAsiSegmentos',
	 CampoPKVistaSeg='Asiento_Id'
     WHERE Identidad_Id='sueLiquidacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueLiquidacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacion'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacion'),'FechaInicial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacion'),'FechaFinal')
