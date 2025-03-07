IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venPropietarioArrenda')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud, OrdenMenuFormulario)
       Values('venPropietarioArrenda','Propietarios Arrendatarios','PropArre_Id,Nombre','venPropietarioArrenda','','','PropArre_Id','Nombre', '', '',0,'512B0')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Propietarios Arrendatarios', CamposSelect='PropArre_Id,Nombre', FromSelect='venPropietarioArrenda', WhereSelect='', OrderByDefault='', CamposClaves='PropArre_Id', CampoDescripcion='Nombre', CharCasing='', Mascara='', MaximaLongitud=0,
	 OrdenMenuFormulario = '512B0'
     WHERE Identidad_Id='venPropietarioArrenda'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venPropietarioArrenda')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPropietarioArrenda'),'PropArre_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPropietarioArrenda'),'Nombre')
