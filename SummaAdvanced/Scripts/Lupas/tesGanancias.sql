IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesGanancias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesGanancias','Tabla_Ganancias','Tabla_Id,Descripcion,Inactivo,Posteado,Empresa_Id','tesGanancias','','','Tabla_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tabla_Ganancias', CamposSelect='Tabla_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesGanancias', WhereSelect='', OrderByDefault='', CamposClaves='Tabla_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesGanancias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesGanancias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesGanancias'),'Tabla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesGanancias'),'Descripcion')
