INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('21a1', 3, 'Colores', 'C' ,dbo.FuncFKdisFormularios('frmespstkColorTest'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('21a2', 3, 'Talles', 'C' ,dbo.FuncFKdisFormularios('frmespstkTalleTest'),'D', 0)

UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespstkProductosTest') WHERE Orden = '2110'
UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespvenCondFiscal') WHERE Orden = '412030'
UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespvenMovimientosConStockTe') WHERE Orden = '522010'
UPDATE genMenus SET Formulario_Id = dbo.FuncFKdisFormularios('frmespvenPedidosTest') WHERE Orden = '521010'
