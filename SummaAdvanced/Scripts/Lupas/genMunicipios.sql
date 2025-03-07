IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMunicipios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genMunicipios','Municipios Mx','c_Municipio,Descripcion,c_Estado','genMunicipios','','','c_Municipio','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Municipios Mx', CamposSelect='c_Municipio,Descripcion,c_Estado', FromSelect='genMunicipios', WhereSelect='', OrderByDefault='', CamposClaves='c_Municipio', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genMunicipios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMunicipios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMunicipios'),'c_Municipio')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMunicipios'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMunicipios'),'c_Estado')
