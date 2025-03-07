IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venOperadores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud, OrdenMenuFormulario)
       Values('venOperadores','Operadores camiones','Operador_Id,NombreOperador,Inactivo,Posteado,Empresa_Id','venOperadores','','','Operador_Id','NombreOperador', '', '',0,'512A0')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Operadores camiones', CamposSelect='Operador_Id,NombreOperador,Inactivo,Posteado,Empresa_Id', FromSelect='venOperadores', WhereSelect='', OrderByDefault='', CamposClaves='Operador_Id', CampoDescripcion='NombreOperador', CharCasing='', Mascara='', MaximaLongitud=0, 
		OrdenMenuFormulario = '512A0'
     WHERE Identidad_Id='venOperadores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venOperadores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venOperadores'),'Operador_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venOperadores'),'NombreOperador')
