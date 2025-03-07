IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesConciliacion')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesConciliacion','Conciliacion','NumeroConc,FechaConciliacion,tesIdentifica,Empresa_Id','vtesConciliacion','','NumeroConc','NumeroConc','NumeroConc')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Conciliacion', 
	 CamposSelect='NumeroConc,FechaConciliacion,tesIdentifica,Empresa_Id', 
	 FromSelect='vtesConciliacion', 
	 WhereSelect='', 
	 OrderByDefault='NumeroConc', 
	 CamposClaves='NumeroConc', CampoDescripcion='NumeroConc'
     WHERE Identidad_Id='tesConciliacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesConciliacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesConciliacion'),'NumeroConc')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesConciliacion'),'FechaConciliacion')

