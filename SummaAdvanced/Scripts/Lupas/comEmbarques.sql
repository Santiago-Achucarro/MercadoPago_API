IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comEmbarques')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('comEmbarques', 'Embarques de Compras', 'FechaEmbarque,Empresa,Estado_Id,Anulado', 'vcomEmbarques', '', 'FechaEmbarque', '', '', 'comEmbarques', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Embarques de Compras', 
	 CamposSelect='FechaEmbarque,Empresa,Estado_Id, Anulado', 
	 FromSelect='vcomEmbarques', 
	 WhereSelect='', 
	 OrderByDefault='FechaEmbarque DESC', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'comEmbarques',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='comEmbarques'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comEmbarques')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEmbarques'),'FechaEmbarque')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEmbarques'),'Anulado')
GO

--select * from comEmbarques

