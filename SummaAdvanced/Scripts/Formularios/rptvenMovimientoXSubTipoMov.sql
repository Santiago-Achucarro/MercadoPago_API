Exec Borra_cuerpoForm 'rptvenMovimientoXSubTipoMov'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='rptvenMovimientoXSubTipoMov')
UPDATE disFormularios SET 
	Alto = 600,
	Ancho = 980,
	Arriba = 58,
	BotonCopiar = 0,
	BotonEliminar = 0,
	BotonGuardar = 0,
	BotonImprimir = 0,
	BotonNuevo = 0,
	BotonPostear = 0,
	BotonRptImprimir = 1,
	BotonRptPdf = 1,
	BotonRptVer = 1,
	BotonRptXls = 1,
	ClaseCommon = 'VentasReportesCommon.venMovimientosXSubTipoMovDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumcomImpuestosAction',
	ClaseEnumEsp = Null,
	ClaseEventos = '',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ComprasExchange.comImpuestosActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = 'rptvenMovimientoXSubTipoM',
	Descripcion = 'Por SubTipo de Movimiento',
	DllCommon = 'VentasReportesCommon',
	DllCommonEsp = Null,
	DllEventos = 'VentasFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ComprasExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'rptvenMovimientoXSubTipoMov',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 3,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = '',
	TipoEspecial = Null,
	Titulo = 'Por_SubTipo_de_Movimiento',
	UltimaModif = '20210616 11:25:50:187',
	Usuario_Id = 1,
	Version = Null
	WHERE Formulario_Id ='rptvenMovimientoXSubTipoMov'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(600, 980, 58, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 'VentasReportesCommon.venMovimientosXSubTipoMovDS', Null, 'EnumcomImpuestosAction', Null, '', Null, 'ComprasExchange.comImpuestosActionExchange', Null, 'rptvenMovimientoXSubTipoM', 'Por SubTipo de Movimiento', 'VentasReportesCommon', Null, 'VentasFEEventos', Null, 'ComprasExchange', Null, Null, 'rptvenMovimientoXSubTipoMov', Null, 0, 0, 3, 'D', 1, '', Null, 'Por_SubTipo_de_Movimiento', '20210616 11:25:50:187', 1, Null)
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('rptvenMovimientoXSubTipoMov')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='rptvenMovimientoXSubTipoMov')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 600, 980, 'T,L', 15, 1, 0, 0, 'rptvenMovimientoXSubTipoMov', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'Por_SubTipo_de_Movimiento', Null, 0, 'rpt', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 561, 964, 'L', 0, 1, 0, 0, 'Solapas', 1, 'rptvenMovimientoXSubTipoMov', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 535, 956, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 279, 'L', 4, 1, 0, 1, 'ctrvenSubTipoMovDesde', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 0, 10, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'venSubTipoMovDesde', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 279, 'L', 5, 1, 1, 1, 'ctrvenSubTipoMovHasta', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 0, 4, Null, 5, Null, 0, Null, 0, 0, 1, 'ZZZZZZZZZZZZZZZZZ', Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'venSubTipoMovHasta', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 35, 120, 'L', 10, 1, 0, 1, 'ctrFechaDesde', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 0, 4, Null, 6, Null, 0, Null, 0, 0, 1, 'Primer_Dia_Mes', Null, 0, 'SummaAdvDisenio.Controles.DisenioDatePicker', 'FechaDesde', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 35, 120, 'L', 6, 1, 1, 1, 'ctrFechaHasta', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 0, 5, Null, 7, Null, 0, Null, 0, 0, 1, 'Hoy', Null, 0, 'SummaAdvDisenio.Controles.DisenioDatePicker', 'FechaHasta', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'rptvenMovimientoXSubTipoMov', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 7, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'rptvenMovimientoXSubTipoMov', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 8, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 17, 71, 'L', 11, 1, 0, 1, 'ctrDetallado', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 2, 1, @disFormularios, 1, 0, 0, 30, Null, 8, Null, 0, Null, 0, 0, 1, 'Detallado', Null, 0, 'SummaAdvDisenio.Controles.DisenioCheck', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'rptvenMovimientoXSubTipoMov', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Detallado', 'ctrDetallado', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioCheck')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'FechaDesde', 'ctrFechaDesde', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'FechaHasta', 'ctrFechaHasta', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'venSubTipoMovDesde', 'ctrvenSubTipoMovDesde', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'venSubTipoMovHasta', 'ctrvenSubTipoMovHasta', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
--disControlesSolapa
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 12, 'Solapa_Datos', @disFormularios, Null, Null, 0, Null, 'Medium', 0, 0, 'Ninguno')
--disControlesFilaSolapa
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 5, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 6, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 7, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 8, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 9, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 10, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 11, @disFormularios, 'A')
--disControlesColumnaSolapa
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_Datos', @disFormularios, 'P')
--disControlesCheckBox
INSERT INTO disControlesCheckBox(Checked, Control_Id, Formulario_Id) VALUES(0, 'ctrDetallado', @disFormularios)
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(1, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 32767, 'venSubTipoMovDesde', Null, Null, 'String', 100, Null, 'ctrvenSubTipoMovDesde', 'Normal', 32767, 1, Null, 0, Null, @disFormularios, dbo.FuncFKlupIdentidades('venSubTipoMov'), Null, 0, 0, 0)
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 32767, 'venSubTipoMovHasta', Null, 'ZZZZZZZZZZZZZZZZZ', 'String', 100, Null, 'ctrvenSubTipoMovHasta', 'Normal', 32767, 1, Null, 0, Null, @disFormularios, dbo.FuncFKlupIdentidades('venSubTipoMov'), Null, 0, 0, 0)
--disControlesFecha
INSERT INTO disControlesFecha(Control_Id, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, Formulario_Id, ValorMaximo, ValorMinimo) VALUES('ctrFechaDesde', Null, Null, Null, @disFormularios, 'En_Blanco', 'En_Blanco')
INSERT INTO disControlesFecha(Control_Id, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, Formulario_Id, ValorMaximo, ValorMinimo) VALUES('ctrFechaHasta', Null, Null, Null, @disFormularios, 'En_Blanco', 'En_Blanco')
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenMovimientoXSubTipoMov', 1, @disFormularios, 1, 0, 'met_MostrarReporte')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenMovimientoXSubTipoMov', 0, @disFormularios, 1, 0, 'rptImprimir')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenMovimientoXSubTipoMov', 0, @disFormularios, 1, 0, 'rptPdf')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenMovimientoXSubTipoMov', 0, @disFormularios, 1, 0, 'rptVer')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenMovimientoXSubTipoMov', 0, @disFormularios, 1, 0, 'rptXls')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('CondicionCliente', '380c6c89-7485-4913-8737-1ebfb8a52b12', Null, Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 3, 'ctrDetallado', 'met_MostrarReporte', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('MostrarReporte', '66d1ad2c-6657-410c-939e-b4d555cc64a4', '380c6c89-7485-4913-8737-1ebfb8a52b12', Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 4, 'venMovimientosXSubTipoMov', 'met_MostrarReporte', 'true')
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('MostrarReporte', 'ad77d19b-669d-4d43-81f8-fc52c601804a', '380c6c89-7485-4913-8737-1ebfb8a52b12', Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 5, 'venMovimientosXSubTipoMovResumen', 'met_MostrarReporte', 'false')
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', 'c48e14fd-5304-45e1-9b9b-5383df198418', Null, Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 2, 'met_MostrarReporte', 'rptImprimir', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', '2b945407-ea39-4153-9e9e-7e08a5619090', Null, Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 6, 'met_MostrarReporte', 'rptPdf', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', '861ed238-25a1-49cc-94c0-d4af60900e14', Null, Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 1, 'met_MostrarReporte', 'rptVer', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', '1af9c8d9-7a22-4905-9819-41aff7481106', Null, Null, 'rptvenMovimientoXSubTipoMov', Null, Null, 0, @disFormularios, 1, 0, 7, 'met_MostrarReporte', 'rptXls', Null)
--disFormulariosComentarios
INSERT INTO disFormulariosComentarios(Comentario, FechaRegistro, FechaRegistroOrig, FechaUltModif, Formulario_Id, FormularioRegOrig_Id) VALUES('AJ no lleva tabla de atributos', '20200413 19:10:13:353', '20200413 19:10:13:353', '20200413 19:10:13:353', @disFormularios, 'rptvenMovimientoXSubTipoMov')
