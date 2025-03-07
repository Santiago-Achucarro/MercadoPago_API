IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueLiquidacionHabi')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, VistaSeg, 
		CampoPKVistaSeg,CampoDescripcion)
       Values('sueLiquidacionHabi','Liquidacion','vsueLiquidacion,Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado',
		'vsueLiquidacionesHabi','','','','genAsiSegmentos','Asiento_Id','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion', 
	 CamposSelect='Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado', 
	 FromSelect='vsueLiquidacionesHabi', 
	 WhereSelect='', 
	 OrderByDefault='FechaInicial', 
	 CamposClaves='', 
	 CampoFKTablaSeg='vsueLiquidacion',
	 VistaSeg='genAsiSegmentos',
	 CampoPKVistaSeg='Asiento_Id'
     WHERE Identidad_Id='sueLiquidacionHabi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueLiquidacionHabi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionHabi'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionHabi'),'FechaInicial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionHabi'),'FechaFinal')
GO