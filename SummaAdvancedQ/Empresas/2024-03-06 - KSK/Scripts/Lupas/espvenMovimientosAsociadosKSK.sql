IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espvenMovimientosAsociadosKSK')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('espvenMovimientosAsociadosKSK', 'Movimientos de Compras', 
		'Fecha, Cliente_Id, RazonSocial, venTipomov, SubTipoMov_Id, MueveStock, Formulario_Id, Anulado,Vendedor_Id', 
		'vEspvenMovimientosAsociadosKSK', '', 'Fecha Desc', '', '', 'venMovimientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha,Cliente_Id,RazonSocial,venTipomov,SubTipoMov_Id,MueveStock,Formulario_Id,Anulado,Vendedor_Id', 
	 FromSelect='vEspvenMovimientosAsociadosKSK', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'venMovimientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='espvenMovimientosAsociadosKSK'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK'),'Anulado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espvenMovimientosAsociadosKSK'),'Vendedor_Id')
GO


