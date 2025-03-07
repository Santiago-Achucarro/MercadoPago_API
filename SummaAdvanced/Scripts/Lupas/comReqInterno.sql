IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comReqInterno')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('comReqInterno','Requisitos Internos','Fecha,EstadoRI_Id,TipoPermiRI_Id,Empresa,Proveed_Id,RazonSocial,GeneraOC','vcomReqInterno','','Fecha Desc','','', 'comReqInterno','comRISegmento', 'comReqInterno')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Requisitos Internos', 
		CamposSelect='Fecha,EstadoRI_Id,TipoPermiRI_Id,Empresa,Proveed_Id,RazonSocial,GeneraOC', 
		FromSelect='vcomReqInterno', 
		WhereSelect='', OrderByDefault='Fecha Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'comReqInterno',
		 VistaSeg = 'comRISegmento', 
		 CampoPKVistaSeg = 'comReqInterno'
		     WHERE Identidad_Id='comReqInterno'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comReqInterno')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'TipoPermiRI_Id')

