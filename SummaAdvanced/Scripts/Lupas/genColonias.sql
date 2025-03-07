IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genColonias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genColonias','Colonias Mx','c_Colonia,c_CodigoPostal,NombreAsentamiento','genColonias','','','c_Colonia','NombreAsentamiento', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Colonias Mx', CamposSelect='c_Colonia,c_CodigoPostal,NombreAsentamiento', FromSelect='genColonias', WhereSelect='', OrderByDefault='', CamposClaves='c_Colonia', CampoDescripcion='NombreAsentamiento', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genColonias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genColonias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genColonias'),'c_Colonia')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genColonias'),'c_CodigoPostal')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genColonias'),'NombreAsentamiento')
