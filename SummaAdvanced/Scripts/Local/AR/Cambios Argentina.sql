If Not Exists(Select 1 From genControlesSeteos Where genControlesSeteos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomconPago') And Control_Id = 'ctrCantidadCuotas')
	Insert Into genControlesSeteos (Formulario_Id, Control_Id, Orden, Valor, ModificoValor, Deshabilitar, Ocultar, SeteadoPorSistema, Usuario_Id, FechaUltModif) Values (dbo.FuncFKdisFormularios('frmcomconPago'), 'ctrCantidadCuotas', 10, '1', 1, 0, 1, 1, 1, GETDATE())
Go

Update genMenus Set Inactivo = 1 Where Orden = '522060' -- NC x devoluciï¿½n --
Go

Update genMenus Set Inactivo = 1 Where Orden = '6250' -- Flujo de fondos --
Go

If Not Exists(select 1 from genAtributosGenerales where AtributoNro=1 and tabla_id ='VenImpuestos')
	  insert into genAtributosGenerales (AtributoNro, Tabla_id, Descripcion, tipo, EnGrilla) values (1,'VenImpuestos','Nro.Resolución Sicore', 'N', 1)
Go

If Not Exists(Select 1 From genControlesSeteos Where genControlesSeteos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomMovProvConStock') And Control_Id = 'ctrrpo9Descuento')
	Insert Into genControlesSeteos (Formulario_Id, Control_Id, Orden, Valor, ModificoValor, Deshabilitar, Ocultar, SeteadoPorSistema, Usuario_Id, FechaUltModif) Values (dbo.FuncFKdisFormularios('frmcomMovProvConStock'), 'ctrrpo9Descuento', 10, '', 1, 1, 1, 1, 1, GETDATE())
Go
