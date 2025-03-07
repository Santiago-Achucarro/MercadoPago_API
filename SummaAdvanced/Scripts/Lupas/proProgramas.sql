
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proProgramas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, CampoDescripcion, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoFKTablaSeg,VistaSeg,CampoPKVistaSeg)
       Values('proProgramas','Programas de Produccion','Descripcion, Fecha, Deposito_Id, Usuario_Id, Empresa',
	   '','vproProgramas','', 'Fecha Desc','', 'proProgramas','proProgramasSegmentos','proProgramas')
ELSE

Begin
     UPDATE lupIdentidades SET Descripcion ='Programas de Produccion', 
	 CamposSelect=' Descripcion, Fecha, Deposito_Id, Usuario_Id, Empresa', 
	 FromSelect='vproProgramas', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc',
	 CamposClaves='', 
	 CampoFKTablaSeg='proProgramas',
	 VistaSeg='proProgramasSegmento',
	 CampoPKVistaSeg='proProgramas'
     WHERE Identidad_Id='proProgramas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proProgramas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proProgramas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proProgramas'),'Deposito_Id')