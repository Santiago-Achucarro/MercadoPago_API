--Update genMenus set Formulario_Id = dbo.FuncFKdisFormularios('LCGfrmstkProductos'), Especial = 1 Where  Formulario_Id = dbo.FuncFKdisFormularios('frmstkProductos')
--Update genMenus set Formulario_Id = dbo.FuncFKdisFormularios('LCGfrmvenListasPrecios'), Especial = 1 Where Formulario_Id = dbo.FuncFKdisFormularios('frmvenListasPrecios')
--update genMenus set Formulario_Id=dbo.FuncFKdisFormularios('frmespUsuarios'), Especial = 1 where Formulario_Id=dbo.FuncFKdisFormularios('frmgenUsuarios')
--update genMenus set Formulario_Id=dbo.FuncFKdisFormularios('frmespFormaEntrega'), Especial = 1 where Formulario_Id=dbo.FuncFKdisFormularios('frmvenFormaEntrega')
--Update genMenus set Formulario_Id = dbo.FuncFKdisFormularios('LCGfrmstkProductos'), Especial = 1 Where  Formulario_Id = dbo.FuncFKdisFormularios('frmstkProductos')
--Update genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('lcgfrmcomOrdenComp'), Especial = 1 Where Formulario_Id = dbo.FuncFKdisFormularios('frmcomOrdenComp')

--Update genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('LCGfrmvenCotizaciones'), Especial = 1 Where Formulario_Id = dbo.FuncFKdisFormularios('frmvenCotizaciones')
--Update genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('LCGfrmvenPedidos'), Especial = 1 Where Formulario_Id = dbo.FuncFKdisFormularios('frmvenPedidos')
--delete from genMenus where Formulario_Id = dbo.FuncFKdisFormularios('frmvenMovimientosConStock')

--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51561',3 ,'Configuracion_Punto_Venta', 'C',dbo.FuncFKdisFormularios('frmespConfPtoVtaKSK'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522011',4 ,'Punto_Venta', 'C',dbo.FuncFKdisFormularios('frmespvenMovPtoVtaKSK'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522012',4 ,'Facturación de Tickets', 'C',dbo.FuncFKdisFormularios('frmespvenComandasKSK'),'D', 1)
--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522012',4 ,'Autoriza_Punto_Venta', 'C',dbo.FuncFKdisFormularios('frmespvenPVAutorizaKSK'),'D', 1)

--INSERT INTO genMenus (Orden, Nive		l, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('219012',3 ,'Actualizacion_Colores', 'C',dbo.FuncFKdisFormularios('frmespColoresKSK'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5310703',4 ,'Informe_de_clienteKSK', 'C',dbo.FuncFKdisFormularios('rptespvenClientesKSK'),'D', 1)
--Update genMenus Set Formulario_Id = dbo.FuncFKdisFormularios('frmespstkProductosKSK') Where Orden = '2110'
--GO

--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('21a1', 3, 'Colores', 'C' ,dbo.FuncFKdisFormularios('frmespstkColorKSK'),'D', 0)
--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('21a2', 3, 'Talles', 'C' ,dbo.FuncFKdisFormularios('frmespstkTalleKSK'),'D', 0)

--UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespstkProductosKSK') WHERE Orden = '2110'

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7161',3 ,'Asignar_Sucursal_Al_Equipo', 'C',dbo.FuncFKdisFormularios('espgenSucursalCookieKSK'),'D', 1)


-- Gustavo 12/05/2023
--UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespvenClieContactoKSK') WHERE Orden = '5110'
-- redirecciono un formulario viejo al nuevo que hice
--UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespvenClientesKSK') WHERE Formulario_Id = dbo.FuncFKdisFormularios('frmespvenClieContactoKSK')

--UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmesptesT3PromocionesKSK') WHERE Orden = '615015'


-- Gustavo 7/5/2023 - Campos para distribuir los descuentos en las tarjetas entre el banco y la empresa
--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('615010',4 ,'Tarjetas_de_Credito', 'C',dbo.FuncFKdisFormularios('frmtesIdTarjetas3'),'D', 0)
--UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmtesIdTarjetas3') WHERE Orden = '615010'
--Update genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmtesT3Promociones'), Especial = 1 Where Formulario_Id = dbo.FuncFKdisFormularios('frmesptesT3PromocionesKSK')
 Update genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmesptesT3PromocionesKSK'), Especial = 1 Where Formulario_Id = dbo.FuncFKdisFormularios('frmtesT3Promociones')
 UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespvenClientesKSK') WHERE Formulario_Id = dbo.FuncFKdisFormularios('frmvenclientes')

 INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5510002',4 ,'Informe Clientes KSK', 'C',dbo.FuncFKdisFormularios('rptespvenClieEspecialKsk'),'D', 1)
  INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5510003',4 ,'Informe Clientes KSK', 'C',dbo.FuncFKdisFormularios('rptespvenClieEspecialKsk'),'D', 1)


--ALTER INDEX XPKgenMenus ON genMenus
--REBUILD

Update genMenus Set Inactivo = 0 Where Orden in ('2240', '224010', '224040', '224050')

Update genMenus Set Inactivo = 0 Where Orden in  ('6150', '615010', '615015', '615020')

UPDATE genMenus SET Inactivo = 0 WHERE ORDEN = '443010'

UPDATE genMenus SET Inactivo = 0 WHERE Orden = '536060'  -- Inoforme de comisiones de vendedores

-- Consulta de stock y precios
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('2390101',4 ,'Consulta_Dinamica_de_Stock_y_Precios', 'C',dbo.FuncFKdisFormularios('frmespstkExistenciasXDepositoKS'),'D', 1)
--UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespstkexistenciaxdepositoKS') WHERE Orden = '2390101'  

-- Pagar por MP 08/12/2023
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6210301',4 ,'Cobrar_Facturas_Por_Mercado_Pago', 'C',dbo.FuncFKdisFormularios('frmesptesMPCobranzaKSK'),'D', 1)

