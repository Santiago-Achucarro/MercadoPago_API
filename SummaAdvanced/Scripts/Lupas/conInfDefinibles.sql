IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conInfDefinibles')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conInfDefinibles','Informes Definibles','Informe_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conInfDefinibles','','Informe_Id','Informe_Id','Descripcion','333020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Informes Definibles', CamposSelect='Informe_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conInfDefinibles', WhereSelect='', OrderByDefault='Informe_Id', CamposClaves='Informe_Id', 
		CampoDescripcion='Descripcion', OrdenMenuFormulario = '333020'
     WHERE Identidad_Id='conInfDefinibles'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conInfDefinibles')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Informe_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Descripcion', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Inactivo', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Posteado', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Empresa_Id', 0)
