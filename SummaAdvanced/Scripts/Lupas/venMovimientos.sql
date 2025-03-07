IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venMovimientos')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('venMovimientos', 'Movimientos de Compras', 
		'Fecha, Cliente_Id, RazonSocial, venTipomov, SubTipoMov_Id, MueveStock, Formulario_Id, Anulado,Vendedor_Id', 
		'vvenMovimientos', '', 'Fecha Desc', '', '', 'venMovimientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha,Cliente_Id,RazonSocial,venTipomov,SubTipoMov_Id,MueveStock,Formulario_Id,Anulado,Vendedor_Id', 
	 FromSelect='vvenMovimientos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'venMovimientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='venMovimientos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venMovimientos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Anulado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Vendedor_Id')
GO