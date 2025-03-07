-- UNIFICADO
Delete from genMenus 
GO

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1000',1 ,'Compras', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1100',2 ,'Entidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1110',3 ,'Proveedores', 'C',dbo.FuncFKdisFormularios('frmcomProveedores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1120',3 ,'Condiciones_de_Pago', 'C',dbo.FuncFKdisFormularios('frmcomConPago'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1130',3 ,'Forma de Entrega', 'C',dbo.FuncFKdisFormularios('frmcomForEntre'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1140',3 ,'Tipo_de_Proveedores', 'C',dbo.FuncFKdisFormularios('frmcomProvTipos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1150',3 ,'Regiones', 'C',dbo.FuncFKdisFormularios('frmcomRegiones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1160',3 ,'Importar_de_Xls', 'C',dbo.FuncFKdisFormularios('frmcomProvXls'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1200',2 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1210',3 ,'Nacionales', 'S',NULL,'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121010',4 ,'Facturas_Orden_Compra', 'C',dbo.FuncFKdisFormularios('frmcomFacturaOC'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121020',4 ,'Facturas_Sin_Stock', 'C',dbo.FuncFKdisFormularios('frmcomMovProvSinStock'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121030',4 ,'Facturas_Con_Stock', 'C',dbo.FuncFKdisFormularios('frmcomMovProvConStock'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121040',4 ,'Comprobante_Varias_OC', 'C',dbo.FuncFKdisFormularios('frmcomFacturasVariasOC'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121045',4 ,'Facturas_con_devengamiento', 'C',dbo.FuncFKdisFormularios('frmcomMovProvDevenga'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121050',4 ,'Deferencias_de_Precios', 'C',dbo.FuncFKdisFormularios('frmcomMovProvDifPrec'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121060',4 ,'Facturas_Remitos_Pendientes', 'C',dbo.FuncFKdisFormularios('frmcomMovProvRemiPend'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121070',4 ,'Saldos_Iniciales', 'C',dbo.FuncFKdisFormularios('frmcomProvSaldoIni'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('121090',4 ,'Ajustes_Estado_de_Cuenta', 'C',dbo.FuncFKdisFormularios('frmcomAjusteEdoCta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('1210100',4 ,'Importar_XML_CFDI', 'C',dbo.FuncFKdisFormularios('frmcomCFDISat'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('1210110',4 ,'Eliminar_CFDI', 'C',dbo.FuncFKdisFormularios('frmcomCFDISatRango'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('1210120',4 ,'Importar_XML_CFDI_Sat', 'C',dbo.FuncFKdisFormularios('frmcomSolicitudesSat'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1220',3 ,'Importaciones', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('122010',4 ,'Definicion_de_Despachos_de_Importacion', 'C',dbo.FuncFKdisFormularios('frmcomDespachos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('122020',4 ,'Ordenes_de_Embarque', 'C',dbo.FuncFKdisFormularios('frmcomEmbarques'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('122030',4 ,'Facturas_de_Embarque', 'C',dbo.FuncFKdisFormularios('frmcomFacturasEmbarque'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('122035',4 ,'Facturas_del_Embarque_por_OE', 'C',dbo.FuncFKdisFormularios('frmcomFacturasOEEmbarque'),'D', 0, 'AR')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('122040',4 ,'Consulta_Cierre_de_Embarque', 'C',dbo.FuncFKdisFormularios('frmcomEmbarqueEdtoCta'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1230',3 ,'Habilitacion_Pagos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('123010',4 ,'Habilitacion_de_Pagos_Individuales ', 'C',dbo.FuncFKdisFormularios('frmcomHabilitarPagos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('123020',4,'Habilitacion_de_Pagos_Masivos ', 'C',dbo.FuncFKdisFormularios('frmcomHabilitarPagosMasivos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('123050',4,'Recepcion Complemento de Pago', 'C',dbo.FuncFKdisFormularios('frmcomMovProvXml'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1240',3 ,'Cerrar_Periodos', 'C',dbo.FuncFKdisFormularios('frmComprasCerrar'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1300',2 ,'Ordenes_de_Compra', 'S',NULL,'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1310',3 ,'Ingreso_de_Ordenes_de_Compra', 'C',dbo.FuncFKdisFormularios('frmcomOrdenComp'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1315',3 ,'Consulta_de_Ordenes_de_Compra', 'C',dbo.FuncFKdisFormularios('frmcomOrdenCompCons'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1320',3 ,'Autorizacion_Ordenes_de_Compra', 'C',dbo.FuncFKdisFormularios('frmcomOrdenCompPendAuto'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1330',3 ,'Tipo_de_Ordenes_de_Compra', 'C',dbo.FuncFKdisFormularios('frmcomTipoPermi'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1340',3 ,'Niveles_de_autorizacion', 'C', dbo.FuncFKdisFormularios('frmcomNivelesAuto'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1350',3 ,'Esquemas_de_autorizacion', 'C', dbo.FuncFKdisFormularios('frmcomEsquemaAuto'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1360',3 ,'Recepcion_Servicios', 'C',dbo.FuncFKdisFormularios('frmcomOCRecepcion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1370',3 ,'Reversion_Recepcion_Servicios', 'C',dbo.FuncFKdisFormularios('frmcomOCRevRecepcion'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1400',2 ,'Requerimientos_Internos', 'S',NULL,'D', 0) 
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1410',3 ,'Requerimientos_Internos', 'C', dbo.FuncFKdisFormularios('frmcomRequisitosInternos'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1420',3 ,'Tipo_de_Requerimientos_Internos', 'C', dbo.FuncFKdisFormularios('frmcomTipoPermiRI'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1430',3 ,'Categorias', 'C', dbo.FuncFKdisFormularios('frmcomCategorias'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1440',3 ,'Consolidacion', 'C',dbo.FuncFKdisFormularios('frmcomRIConciliacion'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1450',3 ,'Autorizacion', 'C',dbo.FuncFKdisFormularios('frmcomRIPendAuto'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1500',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1510',3 ,'Estados_de_Cuenta', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('151010',4 ,'Consulta_Estado_de_Cuenta', 'C',dbo.FuncFkdisFormularios('frmcomConsEdoCtaProveedores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('151020',4 ,'Informe_Estado_de_Cuenta', 'C',dbo.FuncFkdisFormularios('rptcomEdocta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('151030',4 ,'Posicion_Financiera', 'C',dbo.FuncFkdisFormularios('rptComPosfinancieraDeta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('151050',4 ,'Saldo_de_Proveedores', 'C',dbo.FuncFkdisFormularios('rptcomSaldosProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('151055',4 ,'Ranking_de_Proveedores', 'C',dbo.FuncFkdisFormularios('rptRankProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('151056',4 ,'Informe_de_Pagos_Habilitados', 'C',dbo.FuncFkdisFormularios('rptcomPagosHabi'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Pais,Especial) Values('151060',4 ,'Informe_de_Compras_de_Proveedores_Menores', 'C',dbo.FuncFkdisFormularios('rptcomFactProvMenores'),'D',Null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Pais,Especial) Values('151070',4 ,'frmcomConsEdoCtaProveedoresTes', 'C',dbo.FuncFkdisFormularios('frmcomConsEdoCtaProveedoresTes'),'D',Null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Pais,Especial) Values('151080',4 ,'Aplicaciones', 'C',dbo.FuncFkdisFormularios('rptcomAplicaciones'),'D',Null, 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1520',3 ,'Contables', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152010',4 ,'Saldo_Por_Cuenta', 'C',dbo.FuncFkdisFormularios('rptComSaldoXCuenta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152020',4 ,'Sub_Diario_De_Compras', 'C',dbo.FuncFkdisFormularios('rptComSubDiario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152030',4 ,'Sub_Mayor_De_Compras', 'C',dbo.FuncFkdisFormularios('rptComSubMayor'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152040',4 ,'Facturas_A_Recibir', 'C',dbo.FuncFkdisFormularios('rptComFactARecibirNac'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152050',4 ,'Analisis_de_Facturas_a_Recibir_Importaciones', 'C',dbo.FuncFkdisFormularios('rptComFactARecibirImp'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('152060',4 ,'Comprobantes_Registrados', 'C',dbo.FuncFkdisFormularios('rptcomCompRegistrados'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152070',4 ,'Composicion_de_Saldos_Compras', 'C',dbo.FuncFkdisFormularios('rptcomCompSaldo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('152080',4 ,'CFDI', 'C',dbo.FuncFkdisFormularios('rptcomCFDISat'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('152090',4 ,'Cierres_Embarques', 'C',dbo.FuncFkdisFormularios('rptcomEmbCierre'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1520A0',4 ,'Detalle_Cierre_Compras', 'C',dbo.FuncFkdisFormularios('rptcomCierreDeta'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1530',3 ,'Compras', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153010',4 ,'Catalogo_de_Proveedores', 'C',dbo.FuncFkdisFormularios('rptcomCatProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153020',4 ,'Ordenes_de_Compra', 'C',dbo.FuncFkdisFormularios('rptcomOrdenCompra'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153030',4 ,'Ultimas_Compras_por_Producto', 'C',dbo.FuncFkdisFormularios('rptcomUltimasCompras'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153040',4 ,'Prevision_de_Compras', 'C',dbo.FuncFKdisFormularios('rptcomPrevCompras'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153050',4 ,'Costos_Importaciones', 'C',dbo.FuncFKdisFormularios('rptcomCostosImportacion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('15305A0',4 ,'Analisis_Costos_Importaciones', 'C',dbo.FuncFKdisFormularios('rptcomAnalisisCostosImpo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153060',4 ,'Requerimiento_Interno', 'C',dbo.FuncFKdisFormularios('rptcomReqInternoDet'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('153070',4 ,'Requerimientos_Comprados', 'C',dbo.FuncFKdisFormularios('rptcomOrdenCompRI'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('1540',3 ,'Cierre_Contable_de_Periodos ', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('154010',4 ,'Asientos_de_Compras', 'C',dbo.FuncFKdisFormularios('rptcomAsiCierre'),'D', 0)




INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2000', 1, 'Inventario', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2100', 2, 'Entidades', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2110', 3, 'Producto', 'C' ,dbo.FuncFKdisFormularios('frmstkProductos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2120', 3, 'Unidades_de_Medida', 'C' ,dbo.FuncFKdisFormularios('frmstkUniMed'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2130', 3, 'Tipos_de_Producto', 'C' ,dbo.FuncFKdisFormularios('frmstkTipos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2135', 3, 'Familia_de_Producto', 'C' ,dbo.FuncFKdisFormularios('frmstkFamilias'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2137', 3, 'Grupo_de_Producto', 'C' ,dbo.FuncFKdisFormularios('frmstkGrupos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2140', 3, 'Almacenes', 'C', dbo.FuncFKdisFormularios('frmstkDepositos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2145', 3, 'Ubicaciones por Defecto', 'C', dbo.FuncFKdisFormularios('frmstkUbiAlmaenDefecto'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2150', 3, 'Maximos_y_Minimos', 'C', dbo.FuncFKdisFormularios('frmstkMaxMin'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2160', 3, 'Causas_de_Movimiento', 'C', dbo.FuncFKdisFormularios('frmstkCausasMovi'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2180', 3, 'Configuracion_Sub_Tipos', 'C', dbo.FuncFKdisFormularios('frmstkSubTipoMov'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2190', 3, 'Migrar_Productos_Xls', 'C', dbo.FuncFKdisFormularios('frmstkImportarXLSProductos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('21a0', 3, 'Plantillas_de_Producto', 'C' ,dbo.FuncFKdisFormularios('frmstkProductosPlantilla'),	'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) VALUES('219010', 3, 'Limites_COT', 'C', dbo.FuncFKdisFormularios('frmstkCOTArLimites'),'D', 0,'AR')

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2200', 2, 'Movimientos', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2210', 3, 'Entradas', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221010', 4, 'Orden_de_Compra', 'C' ,dbo.FuncFKdisFormularios('frmstkEntradasOc'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221020', 4, 'Orden_de_Embarque', 'C' ,dbo.FuncFKdisFormularios('frmstkEntradasEmbarque'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221030', 4, 'Cambio_de_Deposito', 'C' ,dbo.FuncFKdisFormularios('frmstkEntradasCD'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221035', 4, 'Cambio_de_Deposito_con_Remitos', 'C' ,dbo.FuncFKdisFormularios('frmstkEntradasCDREM'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221040', 4, 'Solicitud_Cambio_de_Deposito', 'C' ,dbo.FuncFKdisFormularios('frmstkSolicitudCD'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221050', 4, 'Ingresos_Otras_causas', 'C' ,dbo.FuncFKdisFormularios('frmstkMoviCabeEntradasCausa'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221060', 4, 'Entradas_Cancelacion_Remision', 'C' ,dbo.FuncFKdisFormularios('frmstkEntradasRemito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221070', 4, 'Quitar_Remito_Pendiente', 'C' ,dbo.FuncFKdisFormularios('frmstkRemiCancPend'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('221080', 4, 'Ingresos_por_Remitos_de_Proveedores', 'C' ,dbo.FuncFKdisFormularios('frmstkMoviProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('221090',4 ,'Entradas_Por_Requerimiento_Interno', 'C',dbo.FuncFKdisFormularios('frmstkEntradasRI'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('2210A0',4 ,'Devoluciones', 'C',dbo.FuncFKdisFormularios('frmstkDevolucionesClie'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('2210B0',4 ,'Devoluciones_Material_Personal', 'C',dbo.FuncFKdisFormularios('frmstkMoviCabeEntradasEmple'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2220', 3, 'Egresos', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222010', 4, 'Cambio_de_Almacen', 'C' ,dbo.FuncFKdisFormularios('frmstkEnTransitoCD'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2220105', 4, 'Cambio_de_Almacen_con_Remitos', 'C' ,dbo.FuncFKdisFormularios('frmstkEnTransitoCDREM'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222020', 4, 'Egresos_Otras_causas', 'C' ,dbo.FuncFKdisFormularios('frmstkMoviCabeSalidasCausa'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222030', 4, 'Devolucion_al_Proveedor', 'C' ,dbo.FuncFKdisFormularios('frmstkDevolucionesProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222040', 4, 'Remitos_a_clientes', 'C' ,dbo.FuncFKdisFormularios('frmstkSalidasRemito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222045', 4, 'Conformacion_de_Remitos', 'C' ,dbo.FuncFKdisFormularios('frmstkRemiConforma'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222050', 4, 'Cambio_Deposito_Directo', 'C' ,dbo.FuncFKdisFormularios('frmstkEnTransitoCDDirecto'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222060', 4, 'Hoja_de_ruta', 'C' ,dbo.FuncFKdisFormularios('frmstkHojaDeRuta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('222070', 4, 'Cierre_Hoja_de_ruta', 'C' ,dbo.FuncFKdisFormularios('frmstkHojaRutaCerrar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) VALUES('222075', 4, 'Generacion_COT', 'C' ,dbo.FuncFKdisFormularios('frmstkCOTAr'),'D', 0, 'AR')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('222080',4 ,'Salidas_Por_Requerimiento_Interno', 'C',dbo.FuncFKdisFormularios('frmstkSalidasRI'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('222090',4 ,'Remision_Facturas_Pendientes', 'C',dbo.FuncFKdisFormularios('frmstkRemisionFactura'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('2220A0',4 ,'Entrega_Material_Personal', 'C', dbo.FuncFKdisFormularios('frmstkMoviCabeSalidasEmpleado'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2230', 3, 'Cierre_de_Periodos', 'C', dbo.FuncFKdisFormularios('frmstockCerrar'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2240', 3, 'Inventarios', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('224010', 4, 'Planificacion', 'C' ,dbo.FuncFKdisFormularios('frmstkInventario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('224040', 4, 'Aprobacion', 'C' ,dbo.FuncFKdisFormularios('frmstkInvMoviStk'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('224050', 4, 'Revalorizacion_Manual', 'C' ,dbo.FuncFKdisFormularios('frmstkRevaluoManual'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2300', 2, 'Informes', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2310', 3, 'Movimientos', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231010', 4, 'Analisis_de_Movimientos_de_Stock', 'C', dbo.FuncFKdisFormularios('rptstkAnaMoviStock'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231015', 4, 'Consulta_de_Movimientos_de_Stock', 'C', dbo.FuncFKdisFormularios('frmstkconsKardex'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231020', 4, 'Seguimiento_de_Despachos_Importacion', 'C', dbo.FuncFKdisFormularios('rptstkSeguimientoDespa'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231030', 4, 'Seguimientos_de_Numeros_de_Serie/Lote', 'C', dbo.FuncFKdisFormularios('rptstkSeguimientoSerie'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231040', 4, 'Reposicion de Stock', 'C', dbo.FuncFKdisFormularios('rptstkReposicion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231050', 4, 'Exceso de Stock', 'C', dbo.FuncFKdisFormularios('rptstkExceso'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231060', 4, 'Otros Movimientos', 'C', dbo.FuncFKdisFormularios('rptstkOtrosMovimientos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('231070', 4, 'Traspasos Pendientes', 'C', dbo.FuncFKdisFormularios('rptstkTraspasosPend'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2320', 3, 'Inventarios', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232010',4 ,'Stock_por_Almacen', 'C',dbo.FuncFKdisFormularios('rptStkxAlmacen'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232020',4 ,'Productos_con_Stock _Negativo', 'C',dbo.FuncFKdisFormularios('rptStockNegativo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232030',4 ,'Productos_sin_Movimientos', 'C',dbo.FuncFKdisFormularios('rptStkProdSinMovimientos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232040',4 ,'Consulta_de_Stock', 'C',dbo.FuncFKdisFormularios('frmstkExistenciasXDeposito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232045',4 ,'Consulta_de_Stock_por_lote', 'C',dbo.FuncFKdisFormularios('frmstkExistenciasXDepositoXLot'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232050',4 ,'Informe_Inventario_Ingresado', 'C',dbo.FuncFKdisFormularios('rptstkInvIngresado'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232060',4 ,'Informe_de_Ajustes_Necesarios', 'C',dbo.FuncFKdisFormularios('rptstkInvAjustes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232070',4 ,'Stock_por_Ubicacion', 'C',dbo.FuncFKdisFormularios('rptstkXDeposito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('232080',4 ,'Informe_Stock_Serie', 'C',dbo.FuncFKdisFormularios('rptstkExistLoteSerie'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('232090',4 ,'Analisis_de_Inventarios', 'C',dbo.FuncFKdisFormularios('rptstkAnaInventarios'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('2320A0',4 ,'Materiales_En_Poder_de_Empleados', 'C',dbo.FuncFKdisFormularios('rptstkMaterialEnPers'),'D', null, 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2330', 3, 'Estadisticos', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('233010',4 ,'Rotacion', 'C',dbo.FuncFKdisFormularios('rptStkRotacion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('233020',4 ,'Ranking De Consumo', 'C',dbo.FuncFKdisFormularios('rptStkRankConsumo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('233030',4 ,'Maximos y Minimos', 'C',dbo.FuncFKdisFormularios('rptstkMaxMin'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('233040',4 ,'Matriz_de_Distribucion', 'C',dbo.FuncFKdisFormularios('rptMatrizDistribMonto'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('2340', 3, 'Contables', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('234010',4 ,'Sub_Diario_de_Stock', 'C',dbo.FuncFKdisFormularios('rptStkSubDiario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('234020',4 ,'Mayor_De_Stock', 'C',dbo.FuncFKdisFormularios('rptStkSubMayor'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('234030',4 ,'Stock_A_Fecha', 'C',dbo.FuncFKdisFormularios('rptStkAFecha'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('234040',4 ,'Mercancias_En_Transito', 'C',dbo.FuncFKdisFormularios('rptstkMercTransLoc'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('234050',4 ,'Mercancias_En_Transito_Importacion', 'C',dbo.FuncFKdisFormularios('rptstkMercTransImp'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('234060',4 ,'Remitos_Pendientes_de_Facturar', 'C',dbo.FuncFKdisFormularios('rptstkRemiPendFact'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('2350',3 ,'Catalogos', 'S',null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('235010',4 ,'Productos', 'C',dbo.FuncFKdisFormularios('rptstkProductos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('235020',4 ,'Ensambles', 'C',dbo.FuncFKdisFormularios('rptstkEnsambles'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('2390',3 ,'Consultas', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('239010',4 ,'Consulta_Drill_Down_Remitos', 'C',dbo.FuncFKdisFormularios('frmstkRemitosConsDrilDown'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3000',1 ,'Contabilidad', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3100',2 ,'Entidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3110',3 ,'Cuentas_Contables', 'C',dbo.FuncFKdisFormularios('frmconCuentasActualizacion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3120',3 ,'SubCuentas', 'C',dbo.FuncFKdisFormularios('frmconSubCuentas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3125',3 ,'Centros_de_Costos', 'C',dbo.FuncFKdisFormularios('frmconCentro1'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3130',3 ,'Centros_Alternativos', 'C',dbo.FuncFKdisFormularios('frmconCentro2'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3135',3 ,'Grupos_de_Centros', 'C',dbo.FuncFKdisFormularios('frmconGruposCont'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3140',3 ,'Bases_de_Distribucion', 'C',dbo.FuncFKdisFormularios('frmconBaseDistri'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('3145',3 ,'Rubros_para_Ajuste_por_Inflacion', 'C',dbo.FuncFKdisFormularios('frmconRubroAxi'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3150',3 ,'Indices_de_Ajuste', 'C',dbo.FuncFKdisFormularios('frmconIndicesAjustes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3155',3 ,'Valores_Indices_de_Ajuste', 'C',dbo.FuncFKdisFormularios('frmconIndAjus'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3160',3 ,'Rubros', 'C',dbo.FuncFKdisFormularios('frmconRubros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('3165',3 ,'Filas_Cuadro_Gastos', 'C',dbo.FuncFKdisFormularios('frmconCuadro1Filas'),'D','AR', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3170',3 ,'Parametros_EF', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('317010',4 , 'Rubros_Estados_Financieros', 'C',dbo.FuncFKdisFormularios('frmconSituPatri'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('317020',4 ,'Tipo_Contables', 'C',dbo.FuncFKdisFormularios('frmconTiposContables'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('317030',4 ,'Tipos_Especiales', 'C',dbo.FuncFKdisFormularios('frmconTipoEspeciales'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('317040',4 ,'Grupos_Anexos', 'C',dbo.FuncFKdisFormularios('frmconAnexosGrupos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('317060',4 ,'Origen_y_Aplicacion_de_Recursos', 'C',dbo.FuncFKdisFormularios('frmconOrigAplicReng'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('317070',4 ,'Anexo_de_Previsiones', 'C',dbo.FuncFKdisFormularios('frmconRubrosPrevi'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('317080',4 ,'Origenes_Anexos', 'C',dbo.FuncFKdisFormularios('frmconAnexosOrigenes'),'D', null, 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3200',2 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3210',3 ,'Asientos_Contables', 'C',dbo.FuncFKdisFormularios('frmconAsientos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3220',3 ,'Asientos_Contables_Reservados', 'C',dbo.FuncFKdisFormularios('frmconAsientosReservados'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3225',3 ,'Invertir_Asiento_Contable', 'C',dbo.FuncFKdisFormularios('frmconAsientosInver'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3230',3 ,'Asientos_Tipos', 'C',dbo.FuncFKdisFormularios('frmconAsientosTipo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3250',3 ,'Ejercicios', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('325010',4 ,'Ejercicios_Definicion', 'C',dbo.FuncFKdisFormularios('frmconEjercicios'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('325020',4 ,'Apertura_Cierre_Periodos', 'C',dbo.FuncFKdisFormularios('frmconPeriodos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('325030',4 ,'Generar_Asiento_Apertura_Cierre', 'C',dbo.FuncFKdisFormularios('frmconAsiApeCierre'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('325040',4 ,'Marcar_Asiento_Apertura', 'C',dbo.FuncFKdisFormularios('frmconAsientosApertura'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('3260',3 ,'Contabilidad_Electronica_MX', 'C',dbo.FuncFKdisFormularios('frmconCatalogoElectroMX'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3270',3 ,'Actualizar_Cuentas_Movimientos', 'C',dbo.FuncFKdisFormularios('frmconAcutalizarCuentaMovimien'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3300',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3310',3 ,'Contabilidad', 'S',NULL,'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331010',4 ,'Balanza_de_Comprobacion', 'C',dbo.FuncFKdisFormularios('rptBalance'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331020',4 ,'Mayor_Contable', 'C',dbo.FuncFKdisFormularios('rptconMayor'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331030',4 ,'Mayor_Contable_Real', 'C',dbo.FuncFKdisFormularios('rptconMayorRes'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331040',4 ,'Sub_Diario', 'C',dbo.FuncFKdisFormularios('rptconSubDiario'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331050',4 ,'Sub_Diario_Resumido', 'C',dbo.FuncFKdisFormularios('rptconSubDiarioRes'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331060',4 ,'Consulta_Fechas_Cierres', 'C',dbo.FuncFKdisFormularios('frmconFechasCierres'),'D', null, 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('331070',4 ,'Balanza_Por_Centro', 'C',dbo.FuncFKdisFormularios('rptconBalanzaXCentro'),'D', null, 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('331100',4 ,'Determinacion_Ajuste_Por_Inflacion', 'C',dbo.FuncFKdisFormularios('rptconInfAxiMx'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('331110',4 ,'Compras_Ejercicio', 'C',dbo.FuncFKdisFormularios('rptconComprasEjercicio'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('331120',4 ,'Asientos_Desbalanceados', 'C',dbo.FuncFKdisFormularios('rptconPolizaDescuadrada'),'D', 0, 'MX')


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('3340',3 ,'Catalogos', 'S',NULL,'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('334010',4 ,'Catalogo_de_Centro1', 'C',dbo.FuncFKdisFormularios('rptconCentro1'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('334020',4 ,'Catalogo_de_Centro2', 'C',dbo.FuncFKdisFormularios('rptconCentro2'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Reporte_Id, Especial) Values('334030',4 ,'Catalogo_de_Cuentas', 'C',dbo.FuncFKdisFormularios('rptconCuentas'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('334040',4 ,'Grupos_de_Centros', 'C',dbo.FuncFKdisFormularios('rptconGruposCont'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3320',3 ,'Estados_Financieros', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('332010',4 ,'Situacion_Patrimonial', 'C',dbo.FuncFKdisFormularios('rptconSituPatri'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('332030',4 ,'Estado_de_Resultados', 'C',dbo.FuncFKdisFormularios('rptconEdoRes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('332080',4 ,'Consulta_Estados_Financieros', 'C', dbo.FuncFKdisFormularios('frmconEstadoRes'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('3330',3 ,'Definibles', 'S', NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('333010',4 ,'Impresion_Definibles', 'C', dbo.FuncFKdisFormularios('frmconinfDefGenerar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('333020',4 ,'Definicion', 'C', dbo.FuncFKdisFormularios('frmconinfDefinibles'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4000',1 ,'Impuestos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4100',2 ,'Entidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4110',3 ,'Compras', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('411010',4 ,'Impuestos_de_Compras', 'C',dbo.FuncFKdisFormularios('frmcomImpuestos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('411020',4 ,'Libro_Impuestos', 'C',dbo.FuncFKdisFormularios('frmcomLibros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('411030',4 ,'Condiciones_Fiscales', 'C',dbo.FuncFKdisFormularios('frmcomCondFiscal'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('411040',4 ,'Origenes_Fiscales', 'C',dbo.FuncFKdisFormularios('frmcomOrigenesFiscales'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4120',3 ,'Ventas', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('412010',4 ,'Impuestos', 'C',dbo.FuncFKdisFormularios('frmvenImpuestos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('412020',4 ,'Libro_Impuestos', 'C',dbo.FuncFKdisFormularios('frmvenLibros'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('412030',4 ,'Condicion_Fiscal', 'C',dbo.FuncFKdisFormularios('frmvenCondFiscal'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4130',3 ,'Inventarios', 'S',NULL,'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('413010',4 ,'Por Ventas', 'C',dbo.FuncFKdisFormularios('frmstkCondFisVenta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('413020',4 ,'Por Compras', 'C',dbo.FuncFKdisFormularios('frmstkCondFisCompra'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('41430',4 ,'Formulas_de_Impuestos', 'C', dbo.FuncFKdisFormularios('frmImpImpuestos'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4140',3 ,'Generales', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('414010',4 ,'Jurisdicciones', 'C',dbo.FuncFKdisFormularios('frmimpJurisdicciones'),'D', 0,'AR')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('414020',4 ,'Definicion_padrones', 'C',dbo.FuncFKdisFormularios('frmimpPadron'),'D', 0,'AR')


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4200',2 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4205',3 ,'Liquidacion_de_Impuestos', 'C', dbo.FuncFKdisFormularios('frmImpLiquidacion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4210',3 ,'DIOT', 'C', 'MX', dbo.FuncFKdisFormularios('frmcomComprasPagadas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4215',3 ,'Cierre_Retencion', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpCierreRetencion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4260',3 ,'Timbrado_de_Retenciones', 'C', 'MX', dbo.FuncFKdisFormularios('frmimpRetencionesCFDI'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4270',3 ,'Cerrar_Mes', 'C', 'MX', dbo.FuncFKdisFormularios('frmimpCierre'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('4285',3 ,'Importar_Listas_Negras', 'C',dbo.FuncFKdisFormularios('frmcomListaNegraMX'),'D', 0, 'MX')


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4300',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4310',3 ,'Ventas', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('431010',4 ,'Libros_Iva_Ventas', 'C',dbo.FuncFKdisFormularios('rptvenLibros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('431020',4 ,'Impuestos_Cobrados', 'C',dbo.FuncFKdisFormularios('rptvenImpCobrados'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('431030',4 ,'Corte_de_Documentacion', 'C',dbo.FuncFKdisFormularios('rptvenCorteDocu'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('431040',4 ,'Control de CFDIS Emitidos', 'C',dbo.FuncFKdisFormularios('rptimpControlCfdi'),'D', 0, 'MX')





INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4320',3 ,'Compras', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('432010',4 ,'Libros_Iva_Compras', 'C',dbo.FuncFKdisFormularios('rptcomLibros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('432020',4 ,'Impuestos_Pagados', 'C',dbo.FuncFKdisFormularios('rptcomImpPagados'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('432030',4 ,'Control de CFDIS Recibidos', 'C',dbo.FuncFKdisFormularios('rptimpControlSAT'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('432040',4 ,'Proveedores en Lista Negra', 'C',dbo.FuncFKdisFormularios('rptimpProveListaNegra'),'D', 0, 'MX')

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4330',3 ,'Contables', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('433010',4 ,'Sub_Diario', 'C', dbo.FuncFKdisFormularios('rptimpSubDiario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('433020',4 ,'Sub_Mayor', 'C', dbo.FuncFKdisFormularios('rptimpSubMayor'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id,Pais, Orientacion,Especial) Values('4400',2 ,'Generacion_de_Archivos', 'S',NULL,'AR','D', 0)
--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4420',3 ,'Arba', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpArbaTxt'),'D', 0)
--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4430',3 ,'CABA', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpCABATxt'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('443010',3 ,'Padrones', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPadronTxt'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4440',3 ,'Exportacion_Sifere', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpSifere'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450',3 ,'Exportacion_Citi_compras_ventas', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpCiti'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445010',3 ,'Exportacion_Sicore', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpSicore'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445020',3 ,'Exportacion_Arciba', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpArciba'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445030',3 ,'Modificacion_Alicuota_Arba', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpArbaTxtModif'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445040',3 ,'Ret_Perc_Iva', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpRetPercIva'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445050',3 ,'eSicol', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpeSicol'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450200',3 ,'Exportacion_Retenciones_Bs_As', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpRetPba'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450205',3 ,'Exportacion_Percepciones_Bs_As', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPercPba'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445065',3 ,'Exportacion_Percep_/_Retencion_Tucuman', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPercRetTucuman'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445070',3 ,'Exportacion_Percep_/_Retencion_Entre_Rios', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPercRetEntreRios'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('445075',3 ,'Sircar', 'C',dbo.FuncFKdisFormularios('frmimpSircar'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('445080',3 ,'Percepciones_Salta', 'C',dbo.FuncFKdisFormularios('frmimpPercSalta'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4450851',3 ,'Retenciones_IVA_Limpieza_y_Seguridad', 'C',dbo.FuncFKdisFormularios('frmimpRetIvaLimpSeg'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('4450852',3 ,'Retenciones_SUSS', 'C',dbo.FuncFKdisFormularios('frmimpRetSuss'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450853',3 ,'Exportacion_Percep_/_Retencion_Misiones', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpRetPercMisiones'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450854',3 ,'Exportacion_Percepciones_Rio_Negro', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPercRioNegro'),'D', 1)





INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5000',1 ,'Ventas', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5100',2 ,'Entidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5110',3 ,'Clientes', 'C',dbo.FuncFKdisFormularios('frmvenClientes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5115',3 ,'Limite_Credito', 'C',dbo.FuncFKdisFormularios('frmvenLimiteCredito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5120',3 ,'Atributos_de_clientes', 'S',Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51210',4 ,'Vendedores', 'C',dbo.FuncFKdisFormularios('frmvenVendedores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51220',4 ,'Cobradores', 'C',dbo.FuncFKdisFormularios('frmvenCobradores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51230',4 ,'F_Entrega', 'C',dbo.FuncFKdisFormularios('frmvenFormaEntrega'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51240',4 ,'Condicion_Pago', 'C',dbo.FuncFKdisFormularios('frmvenCondPago'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51250',4 ,'Categorias_Credito', 'C',dbo.FuncFKdisFormularios('frmvenCategCredito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51260',4 ,'Tipo_Cliente', 'C',dbo.FuncFKdisFormularios('frmvenTiposClie'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51270',4 ,'Zona', 'C',dbo.FuncFKdisFormularios('frmvenZona'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51280',4 ,'Region', 'C',dbo.FuncFKdisFormularios('frmvenRegion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('51290',4 ,'Actualizacion de camiones', 'C',dbo.FuncFKdisFormularios('frmvenCamiones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('512A0', 4,'Operadores', 'C',dbo.FuncFKdisFormularios('frmvenOperadores'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('512B0',4 ,'Propietarios o Arrenatarios', 'C',dbo.FuncFKdisFormularios('frmvenPropArrenda'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5130',3 ,'SubTipoMov', 'C',dbo.FuncFKdisFormularios('frmvenSubTipoMov'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5160',3 ,'Listas_de_Precios', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('516010',4 ,'Definicion_listas_precios', 'C',dbo.FuncFKdisFormularios('frmvenListasPrecios'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('516020',4 ,'Copiar_listas_precios', 'C',dbo.FuncFKdisFormularios('frmvenListasCopiar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('516030',4 ,'Aplicar_coeficiente_listas_precios', 'C',dbo.FuncFKdisFormularios('frmvenListasCoeficiente'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('516040',4 ,'Importar_Listas_de_Excel', 'C',dbo.FuncFKdisFormularios('frmvenListasPrecXLS'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('516050',4 ,'Bonificaciones_Temporales', 'C',dbo.FuncFKdisFormularios('frmvenBonifTemporal'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5170',3 ,'Importacion_desde_Excel', 'C',dbo.FuncFKdisFormularios('frmvenClieXLS'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5180',3 ,'Tablas_Descuento', 'C',dbo.FuncFKdisFormularios('frmvenLPTabla'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5200',2 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5210',3 ,'Pedidos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('521010',4 ,'Ingreso_de_Pedidos', 'C',dbo.FuncFKdisFormularios('frmvenPedidos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('521015',4 ,'Desechado_del_pendiente', 'C',dbo.FuncFKdisFormularios('frmvenPedidosDesechar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('521020',4 ,'Autorizacion_Limite_de_Credito', 'C',dbo.FuncFKdisFormularios('frmvenPediAutoriza'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('521025',4 ,'Validacion_Comercial', 'C',dbo.FuncFKdisFormularios('frmvenPedidosVCAutoriza'),'I', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('521040',4 ,'Configuracion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52105010',5 ,'Niveles_de_Autorizacion', 'C',dbo.FuncFKdisFormularios('frmvenNivelesAuto'),'I', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52105020',5 ,'Esquemas_de_Autorizacion', 'C',dbo.FuncFKdisFormularios('frmvenEsquemaAuto'),'I', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('521030',4 ,'Repartos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52103020',5 ,'Generacion_manual_de_Repartos', 'C',dbo.FuncFKdisFormularios('frmvenReparto'),'I', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52103030',5 ,'Generacion_remitos_facturas', 'C',dbo.FuncFKdisFormularios('frmvenGeneraRemitoFactura'),'I', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52103040',5 ,'Facturacion_de_un_Pedido', 'C',dbo.FuncFKdisFormularios('frmvenFacturacionPedido'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52103050',5 ,'Facturacion_Anticipos', 'C',dbo.FuncFKdisFormularios('frmvenPedidosFactuAnticipo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52103060',5 ,'Cierre_de_reparto', 'C',dbo.FuncFKdisFormularios('frmvenRepartoCierre'),'I', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('52103070',5 ,'Actualizaci�n de camiones', 'C',dbo.FuncFKdisFormularios('frmvenCamiones'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5220',3 ,'Facturacion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522010',4 ,'Codificados', 'C',dbo.FuncFKdisFormularios('frmvenMovimientosConStock'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522020',4 ,'No_Codificados', 'C',dbo.FuncFKdisFormularios('frmvenMovimientosSinStock'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522030',4 ,'Ajustes_Estado_de_Cuenta', 'C',dbo.FuncFKdisFormularios('frmvenAjuEdoCta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522035',4 ,'Carta_Porte', 'C',dbo.FuncFKdisFormularios('frmvenCartaPorte'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522035A',4 ,'Carta_Porte_Libre', 'C',dbo.FuncFKdisFormularios('frmvenCartaPorteLibre'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522040',4 ,'Facturacion_Remito_Pendiente', 'C',dbo.FuncFKdisFormularios('frmvenFacturacionRemito'),'D', 0)

--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5230',3 ,'Repartos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522050',4 ,'Saldos_Iniciales', 'C',dbo.FuncFKdisFormularios('frmvenClientesSaldoIni'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('522060',4 ,'Nota_De_Credito_Por_Devolucion', 'C',dbo.FuncFKdisFormularios('frmstkNotasCreditoXDevolucion'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522070',4 ,'Generar_Factura_Global', 'C',dbo.FuncFKdisFormularios('frmvenCanjeNotas'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522080',4 ,'Anulacion_de_Facturas_No_Registradas', 'C',dbo.FuncFKdisFormularios('frmvenFactAnulHasta'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522090',4 ,'Conformacion_Facturas', 'C',dbo.FuncFKdisFormularios('frmvenMovConforma'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522100',4 ,'ReImprimir_Comprobantes', 'C',dbo.FuncFKdisFormularios('frmvenImprimirComprobante'),'D', 0, null)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522110',4 ,'Enviar_Cancelaciones_SAT', 'C',dbo.FuncFKdisFormularios('frmvenEnviarCancelaciones'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('522120',4 ,'Comprobantes_preGuardados', 'C',dbo.FuncFKdisFormularios('frmvenMovPreGuardados'),'D', 0, 'AR')




INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5230',3 ,'Cierre_de_Ventas', 'C',dbo.FuncFKdisFormularios('frmVentasCerrar'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5240',3 ,'Cotizaciones', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('524010',4 ,'Cotizaciones', 'C',dbo.FuncFKdisFormularios('frmvenCotizaciones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531070',4 ,'Consulta Pedidos Pendientes Cliente', 'C',dbo.FuncFKdisFormularios('frmvenConsPedidosClie'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5250',3 ,'Abonos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('525010',4 ,'Actualizacion_Abonos', 'C',dbo.FuncFKdisFormularios('frmvenAbonos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('525020',4 ,'Facturacion_Abonos', 'C',dbo.FuncFKdisFormularios('frmvenAbonosFacturacion'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5300',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5310',3 ,'Pedidos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531000',4 ,'Consulta_de_Pedidos', 'C',dbo.FuncFKdisFormularios('frmvenPedidosCons'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531010',4 ,'Pedidos_Retenidos_por_Credito', 'C',dbo.FuncFKdisFormularios('rptvenPediRetxCred'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531020',4 ,'Pedidos_Autorizados', 'C',dbo.FuncFKdisFormularios('rptvenPediAutorizados'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531030',4 ,'Pendientes_por_Vendedor', 'C',dbo.FuncFKdisFormularios('rptvenPediPendxVend'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531040',4 ,'Estado_de_Pedidos', 'C',dbo.FuncFKdisFormularios('rptvenPedEstados'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531045',4 ,'Atriculos_Pedidos_Pendientes_Res', 'C',dbo.FuncFKdisFormularios('rptvenPedArtPendRes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531050',4 ,'Atriculos_Pedidos_Pendientes_Deta', 'C',dbo.FuncFKdisFormularios('rptvenPedArtPendDeta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531060',4 ,'Pedidos_Ingresados_por_Cliente', 'C',dbo.FuncFKdisFormularios('rptvenPedCliente'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('531080',4 ,'Ranking_De_Pedidos_De_Clientes', 'C',dbo.FuncFKdisFormularios('rptvenPedRankCliente'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5320',3 ,'Reparto', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('532020',4 ,'Mercancia_Autorizada', 'C',dbo.FuncFKdisFormularios('rptvenMercAutorizada'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('532030',4 ,'Hoja_de_Ruta', 'C',dbo.FuncFKdisFormularios('rptvenHojaRuta'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5340',3 ,'Estado_de_Cuenta', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534010',4 ,'Consulta_Estado_de_Cuenta', 'C',dbo.FuncFKdisFormularios('frmvenConsEdoCtaClientes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534020',4 ,'Informe_Estado_de_Cuenta', 'C',dbo.FuncFKdisFormularios('rptvenEdoCta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534030',4 ,'Aplicaciones', 'C',dbo.FuncFKdisFormularios('rptvenAplicaciones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534040',4 ,'Saldos_de_Clientes', 'C',dbo.FuncFKdisFormularios('rptvenSaldosClie'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534050',4 ,'Posicion_Financiera', 'C',dbo.FuncFKdisFormularios('rptvenPosFinanciera'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534060',4 ,'Limites_de_Credito', 'C',dbo.FuncFKdisFormularios('rptvenLimiteCredito'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534070',4 ,'Analisis_Mora', 'C',dbo.FuncFKdisFormularios('rptvenAnaMora'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('534080',4 ,'Aplicacion_y_pendientes', 'C',dbo.FuncFKdisFormularios('rptvenFactuApliPend'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5350',3 ,'Contables_y_Fiscales', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('535010',4 ,'Subdiario_de_Ventas', 'C',dbo.FuncFKdisFormularios('rptvenSubDiario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('535020',4 ,'Informe_Sub_Mayor_de_Ventas', 'C',dbo.FuncFKdisFormularios('rptvenSubMayor'),'D', 0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('535030',4 ,'Composicion_de_Saldos_Ventas', 'C',dbo.FuncFKdisFormularios('rptvenCompSaldos'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('535050',4 ,'Deuda_por_cuenta_contable', 'C',dbo.FuncFKdisFormularios('rptvenSaldoXCuenta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('535060',4 ,'Consulta_Movimientos_Anulados', 'C',dbo.FuncFKdisFormularios('frmvenMoviAnuladas'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('535070',4 ,'Consulta_comprobantes_en_Afip', 'C',dbo.FuncFKdisFormularios('frmvenConsultaFE'),'D', 0, 'AR')

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5360',3 ,'Facturacion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536010',4 ,'Facturas_con_Productos_Pendientes', 'C',dbo.FuncFKdisFormularios('rptvenFactProdPend'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) 	Values('536015',4 ,'Control_de_Entregas', 'C',dbo.FuncFKdisFormularios('rptvenControlEntrega'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536020',4 ,'Remitos_Pendientes_de_Facturar', 'C',dbo.FuncFKdisFormularios('rptvenRemiPendFact'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536030',4 ,'Remitos_y_Facturas_Asociadas', 'C',dbo.FuncFKdisFormularios('rptvenRemiFactAsoc'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536040',4 ,'Ventas_por_Periodo', 'C',dbo.FuncFKdisFormularios('rptvenVentasPeriodo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536050',4 ,'Ventas_por_Cliente', 'C',dbo.FuncFKdisFormularios('rptVentaXCliente'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536060',4 ,'Comisiones_De_Vendedores', 'C',dbo.FuncFKdisFormularios('rptvenComisVendedores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('536070',4 ,'Comisiones_De_Cobradores', 'C',dbo.FuncFKdisFormularios('rptvenComisCobradores'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5370',3 ,'Estadisticos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537010',4 ,'Ventas_por_Producto', 'C',dbo.FuncFKdisFormularios('rptvenVentasProducto'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537020',4 ,'Contribucion_Marginal', 'C',dbo.FuncFKdisFormularios('rptvenContribMarg'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537030',4 ,'Ranking_de_Clientes', 'C',dbo.FuncFKdisFormularios('rptvenRankCli'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537040',4 ,'Por_SubTipo_de_Movimiento', 'C',dbo.FuncFKdisFormularios('rptvenMovimientoXSubTipoMov'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537060',4 ,'Unidades_Vendidas', 'C',dbo.FuncFKdisFormularios('rptvenUnidadesVend'),'I', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537050',4 ,'Grafico_de_Ventas', 'C', dbo.FuncFKdisFormularios('frmvenGraVentas'),'D', 0)
-- V3
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537070',4 ,'Indicadores', 'C', dbo.FuncFKdisFormularios('frmvenIndicadores'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('537075',3 ,'Abonos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5370750',4 ,'Informe de abonos', 'C',dbo.FuncFKdisFormularios('rptvenAbonos'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5380',3 ,'Catalogos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('538010',4 ,'Clientes', 'C',dbo.FuncFKdisFormularios('rptvenClientes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('538020',4 ,'Vendedores', 'C',dbo.FuncFKdisFormularios('rptvenVendedores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('538030',4 ,'Listas_de_Precios', 'C',dbo.FuncFKdisFormularios('rptvenListaPrecios'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5390',3 ,'Cotizaciones', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('539010',4 ,'Productos_Cotizados', 'C',dbo.FuncFKdisFormularios('rptvenProdCotizados'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('539900',3 ,'Consultas', 'S', Null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('539910',4 ,'Consulta_Drill_Down_Ventas', 'C',dbo.FuncFKdisFormularios('frmvenMovimientosConsDrilDown'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('539920',4 ,'Consulta_Drill_Down_Pedidos', 'C',dbo.FuncFKdisFormularios('frmvenPedidosConsultaDrillDown'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5400',3 ,'Cierre_Contable_de_Periodos ', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('540010',4 ,'Asientos_de_Ventas', 'C',dbo.FuncFKdisFormularios('rptvenAsiCierre'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6000',1 ,'Tesoreria', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6100',2 ,'Entidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6110',3 ,'Efectivo', 'C',dbo.FuncFKdisFormularios('frmtesIdEfectivo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('6115',3 ,'Gastos_por_Comprobar', 'C', dbo.FuncFKdisFormularios('frmtesIdAntGC'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6120',3 ,'Cheques_Clientes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('612010',4 ,'Cheques_Clientes', 'C',dbo.FuncFKdisFormularios('frmtesIdCheques'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('612020', 4,'Bancos', 'C',dbo.FuncFKdisFormularios('frmtesBancos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('612030',4 ,'Clearing', 'C',dbo.FuncFKdisFormularios('frmtesClearing'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('612040',4 ,'Causas_Rechazo', 'C',dbo.FuncFKdisFormularios('frmtesCausasRechazo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6130',3 ,'Cuentas_Bancarias', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('613010', 4,'Cuentas_Bancarias', 'C',dbo.FuncFKdisFormularios('frmtesIdBancoProp'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('613020', 4,'Ingreso_de_Chequeras', 'C',dbo.FuncFKdisFormularios('frmtesChequeras'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6140',3 ,'Varios', 'C',dbo.FuncFKdisFormularios('frmtesIdFondoFijo'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6150',3 ,'Tarjetas_de_Clientes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('615010',4 ,'Tarjetas_de_Credito', 'C',dbo.FuncFKdisFormularios('frmtesIdTarjetas3'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('615015',4 ,'Promociones', 'C',dbo.FuncFKdisFormularios('frmtesT3Promociones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('615020',4 ,'Tipos_de_Tarjetas', 'C',dbo.FuncFKdisFormularios('frmtesIdTarjetas3Tipo'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6160',3 ,'Varios', 'C',dbo.FuncFKdisFormularios('frmtesIdVarios'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6170',3 ,'Facturas_Proveedores', 'C',dbo.FuncFKdisFormularios('frmtesIdFactProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('6180',3 ,'Retenciones_a_Proveedores', 'C',dbo.FuncFKdisFormularios('frmtesIdRetProv'),'D', 'AR', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('6190',3 ,'Retenciones_de_clientes', 'C',dbo.FuncFKdisFormularios('frmtesIdRetClie'),'D', 'AR', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('6195',3 ,'Tabla_Ganancias', 'C',dbo.FuncFKdisFormularios('frmtesGanancias'),'D', 'AR', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('6197',3 ,'Sub_Tipos', 'C',dbo.FuncFKdisFormularios('frmtesSubTipoMov'),'D', null, 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('61980',3 ,'Talonarios_de_Cobranzas', 'S',NULL,'D', 0)
GO
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6198010',4 ,'Ingreso_de_Talonarios', 'C',dbo.FuncFKdisFormularios('frmtesTalonarios'),'D', 0)
GO
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6198020',4 ,'Asignacion_de_Talonarios_A_Cobradores', 'C',dbo.FuncFKdisFormularios('frmtesTalonCobrador'),'D', 0)
GO
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6198030',4 ,'Ingreso_de_Comprobantes_Oficiales_Anulados', 'C',dbo.FuncFKdisFormularios('frmtesRecOfiAnul'),'D', 0)
GO

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6200',2 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6210',3 ,'Ingresos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('621010',4 ,'Cobranzas_Clientes', 'C',dbo.FuncFKdisFormularios('frmtesCobranzas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('621020',4 ,'Otros_Ingresos', 'C',dbo.FuncFKdisFormularios('frmtesOtrosIngresos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('621030',4 ,'Otros_Ingresos', 'C',dbo.FuncFKdisFormularios('frmtesCobranzaProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('621040',4 ,'Timbrado_Cobranzas', 'C',dbo.FuncFKdisFormularios('frmtesCFDICobranza'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('621050',4 ,'Depositos_por_Identificar', 'C',dbo.FuncFKdisFormularios('frmtesIngDepPorIdent'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('621060',4 ,'Identificacion_Depositos', 'C',dbo.FuncFKdisFormularios('frmtesIdentificacionDepositos'),'D', 0,'MX')


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6220',3 ,'Egresos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('622010',4 ,'Pagos_a_Proveedores', 'C',dbo.FuncFKdisFormularios('frmtesPagosProveedores'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('622020',4 ,'Otros_Egresos', 'C',dbo.FuncFKdisFormularios('frmtesOtrosEgresos'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('622030',4 ,'Pagos_a_Clientes', 'C',dbo.FuncFKdisFormularios('frmtesPagosClie'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion, Pais, Especial) Values('622050',4 ,'Reversion_Pago_a_Proveedores', 'C',dbo.FuncFKdisFormularios('frmtesReversionOP'),'D', null, 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('622060',4 ,'Pago_de_Impuestos', 'C', dbo.FuncFKdisFormularios('frmtesPagoImpuestos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('622070',4 ,'Pago_de_Sueldos', 'C', dbo.FuncFKdisFormularios('frmtesPagoSueldos'),'D', 0)




INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6230',3 ,'Bancarios', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623010',4 ,'Debitos', 'C',dbo.FuncFKdisFormularios('frmtesDebitosBancarios'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623020',4 ,'Creditos', 'C',dbo.FuncFKdisFormularios('frmtesCreditosBancarios'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623030',4 ,'DepositosBancarios', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62303010',5 ,'Efectivo', 'C',dbo.FuncFKdisFormularios('frmtesDepositoEfectivo'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62303020',5 ,'Cheques', 'C',dbo.FuncFKdisFormularios('frmtesDepositoCheques'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623040',4 ,'Cheques_Rechazados', 'C',dbo.FuncFKdisFormularios('frmtesIngChequesRechazados'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623050',4 ,'Cheques_Rechazados_Canje', 'C',dbo.FuncFKdisFormularios('frmtesChequesRechCanje'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623060',4 ,'Conciliacion', 'C',dbo.FuncFKdisFormularios('frmtesConciliacion'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623065',4 ,'Movimientos_Reg_Banco_no_la_Empresa', 'C',dbo.FuncFKdisFormularios('frmtesPartidasInCon'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623070',4 ,'Anulacion De Cheques', 'C',dbo.FuncFKdisFormularios('frmtesCheqPropAnul'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('623080',4 ,'Asignaci�n de RFC y Cuenta a Pagos a Proveedores', 'C',dbo.FuncFKdisFormularios('frmtesDepositosXBanco'),'D',0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('623090',4 ,'Modificaci�n Cheques de Terceros', 'C',dbo.FuncFKdisFormularios('frmtesCheqTercerosCambioDatos'),'D',0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6240',3 ,'Otros', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('624010',4 ,'Apertura_de_caja', 'C',dbo.FuncFKdisFormularios('frmtesAperturaCaja'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('624020',4 ,'Cierre_de_Mes', 'C',dbo.FuncFKdisFormularios('frmtesoreriaCerrar'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('624030',4 ,'Arqueos_Iniciales', 'S',NULL,'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62403010',5 ,'Bancos', 'C',dbo.FuncFKdisFormularios('frmtesAISaldos'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62403020',5 ,'Otros', 'C',dbo.FuncFKdisFormularios('frmtesSaldoInicial'),'D',0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('624040',4 ,'Anticipo_Gastos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62404010',5 ,'Solicitantes', 'C',dbo.FuncFKdisFormularios('frmtesSolicitantes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62404020',5 ,'Solicitud', 'C',dbo.FuncFKdisFormularios('frmtesSolicitud'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62404030',5 ,'Autorizacion', 'C',dbo.FuncFKdisFormularios('frmtesSolicitudAutoriza'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62404040',5 ,'Pago', 'C',dbo.FuncFKdisFormularios('frmtesSolicitudPago'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62404050',5 ,'Rendicion', 'C',dbo.FuncFKdisFormularios('frmtesSolicitudRendicion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('62404060',5 ,'informes Solicitudes', 'C',dbo.FuncFKdisFormularios('rpttesSolAnticipos'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6250',3 ,'Flujo de Fondos', 'C',dbo.FuncFKdisFormularios('frmtesFlujoFondo'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6300',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6310',3 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631010',4 ,'Identifica', 'C',dbo.FuncFKdisFormularios('rpttesMovimientosXCartera'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631020',4 ,'Rendicion_de_Caja', 'C',dbo.FuncFKdisFormularios('rpttesRendicionCaja'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631030',4 ,'Conciliacion_Bancaria', 'C',dbo.FuncFKdisFormularios('rpttesConcBancaria'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631040',4 ,'Libro_de_Banco', 'C',dbo.FuncFKdisFormularios('rpttesLibroBanco'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631050',4 ,'Ingresos_Por_Cobranzas', 'C',dbo.FuncFKdisFormularios('rpttesIngCobranzas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631060',4 ,'Pagos_Emitidos', 'C',dbo.FuncFKdisFormularios('rpttesPagosEmitidos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631070',4 ,'Impresion_de_cheques', 'C',dbo.FuncFKdisFormularios('rpttesCheqPropImpresion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631080',4 ,'Estado_de_Cuenta', 'C',dbo.FuncFKdisFormularios('rpttesEstadoCuenta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631090',4 ,'SubTipoMov', 'C',dbo.FuncFKdisFormularios('rpttesMovPorSubTipo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('631100',4 ,'Retenciones', 'C',dbo.FuncFKdisFormularios('rpttesRetenciones'),'D', 0, 'AR')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631110',4 ,'Reimpresion', 'C',dbo.FuncFKdisFormularios('frmtesImpresionComp'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('631120',4 ,'Talonarios_Asignados', 'C',dbo.FuncFKdisFormularios('rpttesTalonarios'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('631130',4 ,'Retenciones', 'C',dbo.FuncFKdisFormularios('rpttesRetenciones'),'D', 0,'AR')

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6310A0',4 ,'Control_Cobranzas', 'C',dbo.FuncFKdisFormularios('rpttesCobranzasRes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6310B0',4 ,'Rendicion_Cobranzas', 'C',dbo.FuncFKdisFormularios('rpttesRendCobra'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6320',3 ,'Carteras', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('632010',4 ,'Cheques_de_Clientes', 'C',dbo.FuncFKdisFormularios('rpttesChequesClientes'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('632020',4 ,'Cheques_Emitidos', 'C',dbo.FuncFKdisFormularios('rpttesChequesEmitidos'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('632040',4 ,'Cheques_Devueltos', 'C',dbo.FuncFKdisFormularios('rpttesChequesDevueltos'),'D',0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('632050',4 ,'Busqueda_de_Cheques', 'C',dbo.FuncFKdisFormularios('rpttesCheqBusqueda'),'D',0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('6330',3 ,'Contables', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('633010',4 ,'Sub_Diario', 'C',dbo.FuncFKdisFormularios('rpttesSubDiario'),'D',0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('633020',4 ,'Sub_Mayor', 'C',dbo.FuncFKdisFormularios('rpttesSubMayor'),'D',0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('633030',4 ,'Tipos_de_Cambio', 'C',dbo.FuncFKdisFormularios('rpttesTiposCambio'),'D',0)
insert into genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('633040',4 ,'Saldo_Bancario', 'C',dbo.FuncFKdisFormularios('frmtesIdentificaSaldo'),'D',0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7000',1 ,'Generalidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7100',2 ,'Entidades', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7110',3 ,'Empresas', 'C',dbo.FuncFKdisFormularios('frmgenEmpresas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7120',3 ,'Usuarios', 'C',dbo.FuncFKdisFormularios('frmgenUsuarios'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7130',3 ,'Grupos', 'C',dbo.FuncFKdisFormularios('frmgenGrupos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7140',3 ,'Paises', 'C',dbo.FuncFKdisFormularios('frmgenPaises'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7150',3 ,'Provincias', 'C',dbo.FuncFKdisFormularios('frmgenProvincias'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7160',3 ,'Sucursales', 'C',dbo.FuncFKdisFormularios('frmgenSucursalesEmpr'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7180',3 ,'Monedas', 'C',dbo.FuncFKdisFormularios('frmgenMonedas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7190',3 ,'Dias_Festivos', 'C',dbo.FuncFKdisFormularios('frmgenDiasFestivos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7200',2 ,'Otros', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7210',3 ,'Permisos', 'C',dbo.FuncFKdisFormularios('frmgenPermisos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7220',3 ,'Copiar Permisos', 'C',dbo.FuncFKdisFormularios('frmgenPermisosCopia'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7225',3 ,'Tareas_Programadas', 'C',dbo.FuncFKdisFormularios('frmgenTareasProgramadas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7230',3 ,'Segmentos', 'C',dbo.FuncFKdisFormularios('frmgenSegmentos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7240',3 ,'Definicion_Primer_Numero', 'C',dbo.FuncFKdisFormularios('frmgenPrimerNumero'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7250',3 ,'Copia_Primer_Numero', 'C',dbo.FuncFKdisFormularios('frmgenContadorCopia'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) VALUES('7260',3 ,'Configuracion_Factura_Electronica', 'C',dbo.FuncFKdisFormularios('frmgenConfiguracionFE'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) VALUES('7265',3 ,'Configuracion_DescargaFacturas', 'C',dbo.FuncFKdisFormularios('frmgenConfiguracionDescargaFacs'),'D', 0,'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7270',3 ,'Mensajes', 'C',dbo.FuncFKdisFormularios('frmgenMensajes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) VALUES('7275',3 ,'Configuracion_Factura_Electronica', 'C',dbo.FuncFKdisFormularios('frmgenCertificadosFeAr'),'D', 0,'AR')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) VALUES('72750',3 ,'Auditoria_de_procesos', 'C',dbo.FuncFKdisFormularios('frmgenLogRequestTodos'),'D', 0,'AR')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7280',3 ,'Configuracion_de_Seguridad', 'C',dbo.FuncFKdisFormularios('frmgenVariablesUsuario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7290',3 ,'Atributos_Generales', 'C',dbo.FuncFKdisFormularios('frmgenAtriGralesClases'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7295', 3 ,'Seteos_Controles', 'C',dbo.FuncFKdisFormularios('frmgenControlesSeteos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, FrmEspecial, Inactivo) VALUES('7297',3 ,'Crear_Nueva_Instancia', 'C',null,'D', 0, 'webfrmInstancia.aspx',1)
--INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7285', 3 ,'ReAplicar', 'C',dbo.FuncFKdisFormularios('frmgenReAplicar'),'D', 0)








INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7300',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7310',3 ,'Permisos_Por_Usuario', 'C',dbo.FuncFKdisFormularios('rptgenPermisos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7320',3 ,'Usuarios_Por_Grupo', 'C',dbo.FuncFKdisFormularios('rptgenUsuGrupo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7350',3 ,'Tareas_Programadas', 'C',dbo.FuncFKdisFormularios('frmgenTareasProgramadasTodas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) VALUES('7351',3 ,'Tareas_Programadas_Errores', 'C',dbo.FuncFKdisFormularios('frmgenTareasProgramadasErrores'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7400',2 ,'Atributos_Valores_XLS', 'C',dbo.FuncFKdisFormularios('frmgenAtributosValoresXLS'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7500',2 ,'WebService', 'S',null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7510',3 ,'Usuarios', 'C',dbo.FuncFkdisFormularios('frmswsUsuarios'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7520',3 ,'Permisos', 'C',dbo.FuncFkdisFormularios('frmswsPermisos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('7530', 3 ,'Woo_Commerce', 'S',null,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('753010', 4 ,'Configuracion_Api', 'C',dbo.FuncFKdisFormularios('frmwooConfigApi'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8000',1 ,'Activo_Fijo', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8100',2 ,'Activo_Fijo', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8110',3 ,'Actualizacion_Activos', 'C',dbo.FuncFKdisFormularios('frmafiActivoFijo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8115',3 ,'Alta_desde_Otros_Sistema', 'C',dbo.FuncFKdisFormularios('frmActivoFijoOtros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8120',3 ,'Rubros_Activo_Fijo', 'C',dbo.FuncFKdisFormularios('frmafiRubros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8130',3 ,'Generar_Depreciaciones', 'C',dbo.FuncFKdisFormularios('frmAfiCrearDepre'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8140',3 ,'Bajas', 'C',dbo.FuncFKdisFormularios('frmAfiBajas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8150',3 ,'Informe_Depreciaciones', 'C',dbo.FuncFKdisFormularios('rptAfiDepreciaciones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8155',3 ,'Informe_de_Bajas', 'C',dbo.FuncFKdisFormularios('rptAfiBajas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8160',3 ,'Importar_Xls', 'C',dbo.FuncFKdisFormularios('frmAfiImportarXls'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8170',2 ,'Responsables', 'C',dbo.FuncFKdisFormularios('frmafiResponasables'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8200',2 ,'Activo_Diferido', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8210',3 ,'Actualizacion_Activos', 'C',dbo.FuncFKdisFormularios('frmafiActivoDiferido'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8215',3 ,'Alta_desde_Otros_Sistema', 'C',dbo.FuncFKdisFormularios('frmActivoDiferidoOtros'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8220',3 ,'Rubros_Activo_Diferido', 'C',dbo.FuncFKdisFormularios('frmafiRubrosCD'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8230',3 ,'Generar_Amortizaciones', 'C',dbo.FuncFKdisFormularios('frmAfiCrearDepreCD'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8240',3 ,'Bajas', 'C',dbo.FuncFKdisFormularios('frmAfiBajasCD'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8250',3 ,'Informe_Amortizaciones', 'C',dbo.FuncFKdisFormularios('rptAfiDepreciacionesCD'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('8300',2 ,'Cierre_Mes', 'C',dbo.FuncFKdisFormularios('frmAfiCerrar'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9000',1 ,'Produccion', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9100',2 ,'Entidades', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9110',3 ,'Recetas', 'C',dbo.FuncFKdisFormularios('frmproRecetas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9120',3 ,'Centro_Productivo', 'C',dbo.FuncFKdisFormularios('frmproCentroProductivo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9130',3 ,'Recursos', 'C',dbo.FuncFKdisFormularios('frmproRecursos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9140',3 ,'Trabajos_Terceros', 'C',dbo.FuncFKdisFormularios('frmproTrabajo3'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9150',3 ,'Variables_Globales', 'C',dbo.FuncFKdisFormularios('frmproVarGlobales'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9160',3 ,'Causas', 'C',dbo.FuncFKdisFormularios('frmproCausas'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9200',2 ,'Movimientos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9210',3 ,'Recetas', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('921010',4 ,'Copiar_Recetas', 'C',dbo.FuncFKdisFormularios('frmproRecetasCopiar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('921020',4 ,'Cambio_Producto_A_x_B', 'C',dbo.FuncFKdisFormularios('frmproRecetasCambioProd'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('921030',4 ,'Importar_Recetas_de_Excel', 'C',dbo.FuncFKdisFormularios('frmproRecetasXLS'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9220',3 ,'Planificacion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('922010',4 ,'Programas_de_Produccion', 'C',dbo.FuncFKdisFormularios('frmproProgramaProduccion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('922020',4 ,'Generar Ordenes Desde un Programa', 'C',dbo.FuncFKdisFormularios('frmproOrdenesGenerar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('922030',4 ,'Pasar_a_Produccion', 'C',dbo.FuncFKdisFormularios('frmproPasarAProduccion'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9230',3 ,'Ordenes_de_Produccion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('923010',4 ,'Actualizacion_Ordenes', 'C',dbo.FuncFKdisFormularios('frmproOrdenes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('923020',4 ,'Programa_Trabajos_de_Terceros', 'C',dbo.FuncFKdisFormularios('frmproPrograma'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('923030',4 ,'Programar_Recursos', 'C',dbo.FuncFKdisFormularios('frmproProgramaSubRecursos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('923040',4 ,'Cerrar_Ordenes', 'C',dbo.FuncFKdisFormularios('frmproOrdenCerrar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('923050',4 ,'Limpiar_Ordenes', 'C',dbo.FuncFKdisFormularios('frmproOrdenLimpiar'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9300',2 ,'Informes', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9310',3 ,'Recetas', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('931010',4 ,'Recetas', 'C',dbo.FuncFKdisFormularios('rptproRecetas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('931020',4 ,'Explosion_Recetas', 'C',dbo.FuncFKdisFormularios('frmproExplotar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('931030',4 ,'Cadena_de_Produccion', 'C',dbo.FuncFKdisFormularios('rptproCadenaProduccion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('931040',4 ,'Uso_de_un_Producto', 'C',dbo.FuncFKdisFormularios('rptproUsoUnProducto'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9320',3 ,'Planificacion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('932010',4 ,'Informe_de_Programa', 'C',dbo.FuncFKdisFormularios('rptproPrograma'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('932020',4 ,'Explosion_de_un_Programa', 'C',dbo.FuncFKdisFormularios('rptproProgramaExplotar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('932030',4 ,'Faltantes_de_Stock_para_Produccion', 'C',dbo.FuncFKdisFormularios('rptproFaltantes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('932040',4 ,'MPR', 'C',dbo.FuncFKdisFormularios('rptproFechasMrp'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9330',3 ,'Ordenes_de_Produccion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933010',4 ,'Trabajos_por_Centro_Productivo', 'C',dbo.FuncFKdisFormularios('rptproTrabajosCP'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933020',4 ,'Trabajos_por_Centro_Productivo_Detallado', 'C',dbo.FuncFKdisFormularios('rptproTrabajosCPDeta'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933030',4 ,'Trabajo_ por_Recurso', 'C',dbo.FuncFKdisFormularios('rptproTrabajosRecu'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933040',4 ,'Trabajo_ por_Proveedor', 'C',dbo.FuncFKdisFormularios('rptproTrabajosProv'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933050',4 ,'Consumos_para_el_Proveedor_Interno', 'C',dbo.FuncFKdisFormularios('rptproConsMateriales'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933060',4 ,'Origen_de_Ordenes_de_Produccion', 'C',dbo.FuncFKdisFormularios('rptproOrdenOrigen'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('933070',4 ,'Movimientos_de_Stock_por_Orden_de_Produccion', 'C',dbo.FuncFKdisFormularios('rptproMovStockOrden'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9340',3 ,'Produccion', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('934010',4 ,'Producciones_Pendientes', 'C',dbo.FuncFKdisFormularios('rptproProduccionesPend'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('934020',4 ,'Producciones_del_Periodo', 'C',dbo.FuncFKdisFormularios('rptproProduccionesPeriodo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('934030',4 ,'Eficiencia', 'C',dbo.FuncFKdisFormularios('rptproEficiencia'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('934040',4 ,'Ineficiencias_por_Causa', 'C',dbo.FuncFKdisFormularios('rptproCausasMov'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9350',3 ,'Costos', 'S',NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('935010',4 ,'Costos', 'C',dbo.FuncFKdisFormularios('rptproCostos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('935020',4 ,'Costos_por_Orden_de_Produccion', 'C',dbo.FuncFKdisFormularios('rptproCostosPorOrden'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S000',1 ,'Sueldos', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S100',2 ,'Entidades', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S110',3 ,'Empleados', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11010',4 ,'Empleados', 'C',dbo.FuncFKdisFormularios('frmsuePersonal'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11020',4 ,'Categorias', 'C',dbo.FuncFKdisFormularios('frmsueCategorias'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11030',4 ,'Tipo_Pago', 'C',dbo.FuncFKdisFormularios('frmsueTipoPago'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11040',4 ,'Convenios', 'C',dbo.FuncFKdisFormularios('frmsueConvenio'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11050',4 ,'Puestos', 'C',dbo.FuncFKdisFormularios('frmsuePuestos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11060',4 ,'Importar_Empleados_de_Excel', 'C',dbo.FuncFKdisFormularios('frmsuePersonalXLS'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11070',4 ,'Periodicidad', 'C',dbo.FuncFKdisFormularios('frmsuePeriodicidad'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S11080',4 ,'Relaciones_familiares', 'C',dbo.FuncFKdisFormularios('frmsueFamiliares'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S120',3 ,'Atributos_Liquidacion', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S12010',4 ,'Grupos', 'C',dbo.FuncFKdisFormularios('frmsueGrupos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S12020',4 ,'Conceptos', 'C',dbo.FuncFKdisFormularios('frmsueConceptos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S12030',4 ,'Propiedades_de_Conceptos', 'C',dbo.FuncFKdisFormularios('frmsueConceptosPropTodos'),'D', 0)



INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S130',3 ,'Datos_Variables', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S13010',4 ,'Activar_Conceptos_por_Empleado', 'C',dbo.FuncFKdisFormularios('frmsueVariables'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S13020',4 ,'Activar_Conceptos_por_Rango_de_Empleados', 'C',dbo.FuncFKdisFormularios('frmsueVariablesMasivas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S13030',4 ,'Inactivar_Conceptos_por_Rango_de_Empleados', 'C',dbo.FuncFKdisFormularios('frmsueVariablesMasivoEliminar'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S13040',4 ,'Copiar Conceptos', 'C',dbo.FuncFKdisFormularios('frmsueVariablesCopiar'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S140',3 ,'Atributos_Generales', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14010',4 ,'Plantilla_de_Sueldos', 'C', dbo.FuncFKdisFormularios('frmsuePlantilla'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14020',4 ,'NombresGlobales', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S1402010',5 ,'Nombre_Variables_Globales', 'C',dbo.FuncFKdisFormularios('frmsueVarGlobales'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S1402020',5 ,'Nombre_Importes_Personal', 'C',dbo.FuncFKdisFormularios('frmsueImpNombre'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S1402030',5 ,'Nombre_Importes_Categorias', 'C',dbo.FuncFKdisFormularios('frmsueCateNombre'),'D', 0)

--
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14030',4 ,'Variables_Globales', 'C',dbo.FuncFKdisFormularios('frmsueLiqVarGlobales'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14040',4 ,'Tablas_Generales', 'C',dbo.FuncFKdisFormularios('frmsueTablas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14050',4 ,'Tablas_Ganancias', 'C',dbo.FuncFKdisFormularios('frmsueGanancias'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14060',4 ,'ArchivosTxt', 'C', dbo.FuncFKdisFormularios('frmsueArchivosTxt'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14070',4 ,'Tabla de Vacaciones', 'C', dbo.FuncFKdisFormularios('frmsueTablasVacaciones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S14080',4 ,'Generar_ArchivosTxt', 'C', dbo.FuncFKdisFormularios('frmsueGenerarArchivosTxt'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S200',2 ,'Movimientos', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S2010',3 ,'Empleados', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S201010',4 ,'Liquidacion_Variables_Globales', 'C',dbo.FuncFKdisFormularios('frmsueLiqPersImporte'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S201020',4 ,'Liquidacion_Variables_Globales', 'C',dbo.FuncFKdisFormularios('frmsueLiqPersImportesHistorico'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S201030',4 ,'Liquidacion_Variables_Globales_Historico', 'C',dbo.FuncFKdisFormularios('frmsueLiqVarGlobalesHistorico'),'D', 0)
--Calculo automatico de importes
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S201040',4 ,'Importar_Importes_de_Excel', 'C',dbo.FuncFKdisFormularios('frmsueLiqPersImporteXLS'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S201050',4 ,'Liquidacion_Nombres_Importes_Historico', 'C',dbo.FuncFKdisFormularios('frmsueLiqCategoHistorico'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S201070',4 ,'Carga de D�as Correspondientes de Vacaciones', 'C',dbo.FuncFKdisFormularios('frmsueVacCorresponden'),'D', 0)

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S2020',3 ,'Novedades', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S202010',4 ,'Ingreso de Dato por Empleado', 'C',dbo.FuncFKdisFormularios('frmsueDatos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S202020',4 ,'Ingreso_de_Dato_por_Concepto', 'C', dbo.FuncFKdisFormularios('frmsueDatoXConcepto'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S202030',4 ,'Ingreso_de_Dato_Desde_Excel', 'C', dbo.FuncFKdisFormularios('frmsueDatoXLS'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('S202040',4 ,'Actualizacion_de_Descuento_por_Tope', 'C', dbo.FuncFKdisFormularios('frmsueConcAcum'),'D', 0, 'MX')

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S2030',3 ,'Liquidacion', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S203010',4 ,'Liquidacion_de_Sueldos', 'C', dbo.FuncFKdisFormularios('frmsueLiquidacion'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S203020',4 ,'Habilitacion_de_Pagos', 'C', dbo.FuncFKdisFormularios('frmsuePagosHabi'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial, Pais) Values('S203030',4 ,'Timbrado_de_Recibos', 'C', dbo.FuncFKdisFormularios('frmsueTimbradoRecibos'),'D', 0, 'MX')
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S203050',4 ,'Carga_De_Vacaciones', 'C', dbo.FuncFKdisFormularios('frmsueVacTomadas'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S2040',3 ,'Cerrar_Sueldos', 'C', dbo.FuncFKdisFormularios('frmsueCierre'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S300',2 ,'Informes', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S310',3 ,'Liquidacion', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31010',4 ,'Conceptos_Resumido', 'C', dbo.FuncFKdisFormularios('rptsueConceptosRes'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31020',4 ,'Conceptos_Detallado', 'C', dbo.FuncFKdisFormularios('rptsueConceptosDet'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31030',4 ,'Nomina', 'C', dbo.FuncFKdisFormularios('rptsueNomina'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31040',4 ,'Netos_a_Pagar', 'C', dbo.FuncFKdisFormularios('rptsueNetos'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31050',4 ,'Descuentos_Por_Tope', 'C', dbo.FuncFKdisFormularios('rptsueConcDesc'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31060',4 ,'Recibos_De_Sueldos', 'C', dbo.FuncFKdisFormularios('rptsueRecibo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31070',4 ,'Consulta_Recibos_Sueldos', 'C', dbo.FuncFKdisFormularios('frmsueConsRecibo'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31080',4 ,'Acumulados_Anuales', 'C', dbo.FuncFKdisFormularios('rptsueAcumAnual'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31090',4 ,'Saldo_Vacaciones', 'C', dbo.FuncFKdisFormularios('rptsueVacaciones'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S31100',4 ,'Libro_De_Sueldos', 'C', dbo.FuncFKdisFormularios('rptsueLibro'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S320',3 ,'Catalogos', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S32010',4 ,'Empleados', 'C', dbo.FuncFKdisFormularios('rptsueEmpleados'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S32020',4 ,'Conceptos', 'C', dbo.FuncFKdisFormularios('rptsueConceptos'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S330',3 ,'Contables', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S33010',4 ,'Sub_Diario', 'C', dbo.FuncFKdisFormularios('rptsueSubDiario'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S33020',4 ,'Sub_Mayor', 'C', dbo.FuncFKdisFormularios('rptsueSubMayor'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S33030',4 ,'Detalle_de_Asiento_por_Concepto', 'C', dbo.FuncFKdisFormularios('rptsueDetAsiConc'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S33040',4 ,'Plantilla_de_Sueldos', 'C', dbo.FuncFKdisFormularios('rptsuePlantillaDetalle'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S33050',4 ,'Plantilla_de_Sueldos', 'C', dbo.FuncFKdisFormularios('rpt_suePlantilla'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial,Pais) Values('S33060',4 ,'Cfdis', 'C', dbo.FuncFKdisFormularios('rptsueNominaCFDI'),'D', 0,'MX')

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S400',3 ,'Definibles', 'S',NULL,'D', 0) 
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S410',4 ,'Definicion', 'C', dbo.FuncFKdisFormularios('frmsueInfDefinibles'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('S420',4 ,'Impresion', 'C', dbo.FuncFKdisFormularios('rptsueInfDefinibles'),'D', 0)


-- estas se llaman desde otro form
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('Z000',1 ,'Otros', 'S', NULL,'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('Z100',2 ,'Aplicar', 'C', dbo.FuncFKdisFormularios('frmvenAplicaciones'),'D', 0)


INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('5260',3 ,'Cierre_Comisiones_de_Ventas', 'C',dbo.FuncFKdisFormularios('frmVentasComiCerrar'),'D', 0)
GO

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('9170',3 ,'Turnos_de_Trabajo', 'C',dbo.FuncFKdisFormularios('frmproTurnos'),'D', 0)
go


