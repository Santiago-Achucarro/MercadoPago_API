IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venLPTabla')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('venLPTabla','Tabla Descuentos','Tabla_Id,Descripcion','venLPTabla','','Tabla_Id','Tabla_Id','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tabla Descuentos', CamposSelect='Tabla_Id,Descripcion', FromSelect='venLPTabla', WhereSelect='', OrderByDefault='Tabla_Id', CamposClaves='Tabla_Id', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='venLPTabla'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venLPTabla')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLPTabla'),'Tabla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLPTabla'),'Descripcion')
GO
