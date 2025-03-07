CREATE TABLE genAtriGralesClases
( 
	Tabla_Id varchar(60) NOT NULL,
	Descripcion varchar(80) NOT NULL,
	CONSTRAINT XPKgenAtriGralesClases PRIMARY KEY  CLUSTERED (Tabla_Id ASC)
)
GO

INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('afiActivoFijo','Actualizacion_Activo_Fijo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('afiRubros','Rubros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comCategorias','Categorias')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comCondFiscal','Condicion_Fiscal_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comConPago','Condiciones_de_Pago')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comDespachos','Despachos_de_importacion')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comEmbarques','Embarques')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comEsquemaAuto','Esquema_de_autorizaciones_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comForEntre','Formas_de_Entrega_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comImpuestos','Impuestos_de_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comLIbros','Definicion_Libro_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comMovProv','Movimientos_de_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comNivelesAuto','Niveles_de_Autorizacion_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comOrdenComp','Ordenes_de_Compra')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comOrigenesFiscales','Origenes_Fiscales_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comProveedores','Proveedores')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comProvTipos','Tipos_de_Proveedores')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comRegiones','Regiones_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comReqInternos','Requerimientos_Internos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comTipoPermi','Tipo_Ordenes_Compra')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comTipoPermiRI','Tipos_de_Requerimiento')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conAsientosTipo','Asientos_Tipo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conBaseDistri','Bases_de_Distribucion')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conCentro1','Centro_de_Costos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conCentro2','Centro_Alternativo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conGruposCont','Grupos_de_Centros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conIndicesAjustes','Indices_de_ajuste')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conRubros','Rubros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conSubCuentas','SubCuentas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genEmpresas','Empresas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genMonedas','Monedas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genPaises','Paises')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genSucursalesEmpr','Sucursales_de_la_empresa')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genUsuarios','Usuarios')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impImpuestos','Impuestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impJurisdicciones','Jurisdicciones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impLiquidacion','Liquidacion_de_Impuestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impPadron','Definicion_Padrones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proCausas','Causas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proCentroProductivo','Centro_Productivo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proRecetas','Recetas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proRecuersos','Recursos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proTrabajo3','Trabajos_Terceros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkCausasMovi','Causas_de_otros_movimientos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkCondfisCompra','Condicion_Fiscal_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkCondfisVenta','Condicion_Fiscal_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkDepositos','Depositos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkEnTransito','Ingreso_por_Cambio_Deposito')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkFamilias','Familias')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkGrupos','Grupos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkHojaDeRuta','Hoja_de_ruta')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkInventarios','Inventarios_Físicos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkMoviCabe','Movimientos_de_Stock')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkProductosPlantilla','Plantillas_de_Productos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkTipos','Tipos_Stock')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkUniMed','Unidades_de_Medida')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueArchivosTxt','Configuracion_Archivos_de_Texto_Sueldos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueCategorias','Categorías')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueConvenio','Convenio')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueGrupos','Grupos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueLiquidacion','Liquidacion_de_Sueldos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('suePersonal','Personal')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('suePuestos','Puestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueTablaVacacion','Tablas_de_Vacaciones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueTipoPago','Tipos_de_Pago')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesBancos','Bancos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesCausasRechazo','Causas_de_Rechazo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesChequeras','Chequeras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesClearing','Clearing')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesGanancias','Tabla_Ganancias')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesIdentifica','Movimientos_de_Identificadores_Tesoreria')
GO

INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesMovimientos','Movimientos_de_Tesoreria')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesSubTiposMov','SubTipo_de_Moivimientos_Tesoreria')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCamiones','Actualizacion_de_camiones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCategCredito','Categoria_de_Credito')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCobradores','Cobradores')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCondFiscal','Condicion_Fiscal')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCondPago','Condiciones_de_Pago')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCotizaciones','Cotizaciones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venFormaEntrega','Formas_de_Entrega_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venImpuestos','Impuestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venLibros','Libro_impuesto_ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venListasPrecios','Listas_de_precios')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venMovimientos','Movimientos_de_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venPedidos','Actualizacion_Pedidos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venRegion','Regiones_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venReparto','Actualizacion_de_repartos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venTiposClie','Tipos_Clientes')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venZona','Zonas_Ventas')
GO

INSERT INTO genVersion (Version) Values(1005.14)
GO
