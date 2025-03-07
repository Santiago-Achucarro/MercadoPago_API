
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCotizaciones')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, CampoDescripcion, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoFKTablaSeg,VistaSeg,CampoPKVistaSeg)
       Values('venCotizaciones','Cotizaciones Ventas','RazonSocial,Fecha,Moneda_Id,Cliente_Id, ImporteTotal, Empresa, Estado, vvenCotizaciones.venCotizaciones,Vendedor_Id','','vvenCotizaciones','', 'Fecha','', 'venCotizaciones','venCotizSegmento','venCotizaciones')
ELSE

Begin
     UPDATE lupIdentidades SET Descripcion ='Cotizaciones Ventas', 
	 CamposSelect='RazonSocial,Fecha,Moneda_Id,Cliente_Id, ImporteTotal, Empresa, Estado, vvenCotizaciones.venCotizaciones, Vendedor_Id', 
	 FromSelect='vvenCotizaciones', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc, venCotizaciones Desc',	
	 CamposClaves='', 
	 CampoFKTablaSeg='venCotizaciones',
	 VistaSeg='venCotizSegmento',
	 CampoPKVistaSeg='venCotizaciones'
     WHERE Identidad_Id='venCotizaciones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCotizaciones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'ImporteTotal')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Estado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Vendedor_Id')



