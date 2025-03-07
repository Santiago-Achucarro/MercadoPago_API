IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueLiquidacionLega')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, 
	 OrderByDefault, CamposClaves, VistaSeg, CampoPKVistaSeg,CampoDescripcion, CampoFKTablaSeg)
       Values('sueLiquidacionLega', 'Liquidacion', 'Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado,Legajo',
		'vsueLiquidacionesLega', '', 'FechaInicial Desc', '', 'genAsiSegmentos', 'Asiento_Id', '', 'vsueLiquidacion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion', 
	 CamposSelect = 'Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado,Legajo', 
	 FromSelect = 'vsueLiquidacionesLega', 
	 WhereSelect = '', 
	 OrderByDefault = 'FechaInicial Desc', 
	 CamposClaves = '', 
	 CampoFKTablaSeg = 'vsueLiquidacion',
	 VistaSeg = 'genAsiSegmentos',
	 CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id = 'sueLiquidacionLega'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id = dbo.FuncFklupIdentidades('sueLiquidacionLega')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionLega'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionLega'),'FechaInicial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionLega'),'FechaFinal')