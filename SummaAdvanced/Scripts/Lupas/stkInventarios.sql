IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkInventarios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkInventarios','Inventarios','FechaInventario,Deposito_Id,Descripcion, Empresa','vstkInventarios','','FechaInventario','','', 'stkInventarios','stkInvenSegmentos', 'stkInventarios')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Inventarios', 
		CamposSelect='FechaInventario,Deposito_Id,Descripcion,Empresa', 
		FromSelect='vstkInventarios', 
		WhereSelect='', OrderByDefault='FechaInventario', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'stkInventarios',
		 VistaSeg = 'stkInvenSegmentos', 
		 CampoPKVistaSeg = 'stkInventarios'
		     WHERE Identidad_Id='stkInventarios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkInventarios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkInventarios'),'FechaInventario')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkInventarios'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkInventarios'),'Descripcion')

go

