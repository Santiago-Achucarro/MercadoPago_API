IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCanjeNotas')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('venCanjeNotas', 'venCanjeNotas', 
		'Fecha, Cliente_Id, RazonSocial, venTipomov, SubTipoMov_Id, MueveStock, Formulario_Id, Anulado,Vendedor_Id', 
		'vvenCanjeNotas', '', 'Fecha Desc', '', '', 'venMovimientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha,Cliente_Id,RazonSocial,venTipomov,SubTipoMov_Id,MueveStock,Formulario_Id,Anulado,Vendedor_Id', 
	 FromSelect='vvenCanjeNotas', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'venMovimientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='venCanjeNotas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCanjeNotas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'Anulado')
GO