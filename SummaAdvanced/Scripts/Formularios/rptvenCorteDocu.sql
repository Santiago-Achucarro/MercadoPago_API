Exec Borra_cuerpoForm 'rptvenCorteDocu'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='rptvenCorteDocu')
UPDATE disFormularios SET 
	Alto = 600,
	Ancho = 980,
	Arriba = 15,
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
	ClaseCommon = 'VentasReportesCommon.venCorteDocuDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumcomImpuestosAction',
	ClaseEnumEsp = Null,
	ClaseEventos = '',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ComprasExchange.comImpuestosActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = 'rptvenCorteDocu',
	Descripcion = 'Corte de Documentacion',
	DllCommon = 'VentasReportesCommon',
	DllCommonEsp = Null,
	DllEventos = 'VentasFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ComprasExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'rptvenCorteDocu',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 15,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = '',
	TipoEspecial = Null,
	Titulo = 'Corte_de_Documentacion',
	UltimaModif = '20201217 15:30:40:667',
	Usuario_Id = 1,
	Version = Null
	WHERE Formulario_Id ='rptvenCorteDocu'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(600, 980, 15, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 'VentasReportesCommon.venCorteDocuDS', Null, 'EnumcomImpuestosAction', Null, '', Null, 'ComprasExchange.comImpuestosActionExchange', Null, 'rptvenCorteDocu', 'Corte de Documentacion', 'VentasReportesCommon', Null, 'VentasFEEventos', Null, 'ComprasExchange', Null, Null, 'rptvenCorteDocu', Null, 0, 0, 15, 'D', 1, '', Null, 'Corte_de_Documentacion', '20201217 15:30:40:667', 1, Null)
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('rptvenCorteDocu')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='rptvenCorteDocu')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 600, 980, 'T,L', 15, 1, 0, 0, 'rptvenCorteDocu', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'Corte_de_Documentacion', Null, 0, 'rpt', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 561, 964, 'L', 0, 1, 0, 0, 'Solapas', 1, 'rptvenCorteDocu', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 535, 956, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 35, 120, 'L', 2, 1, 0, 1, 'ctrpFechaHasta', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 0, 8, Null, 4, Null, 0, Null, 0, 0, 1, 'Hoy', Null, 0, 'SummaAdvDisenio.Controles.DisenioDatePicker', 'pFechaHasta', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'rptvenCorteDocu', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 5, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'rptvenCorteDocu', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 6, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'rptvenCorteDocu', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 7, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'pFechaHasta', 'ctrpFechaHasta', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioDatePicker')
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
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(1, 'Solapas', @disFormularios)
--disControlesFecha
INSERT INTO disControlesFecha(Control_Id, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, Formulario_Id, ValorMaximo, ValorMinimo) VALUES('ctrpFechaHasta', Null, Null, Null, @disFormularios, 'En_Blanco', 'En_Blanco')
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenCorteDocu', 1, @disFormularios, 1, 0, 'met_Reporte')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenCorteDocu', 0, @disFormularios, 1, 0, 'rptImprimir')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenCorteDocu', 0, @disFormularios, 1, 0, 'rptPdf')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenCorteDocu', 0, @disFormularios, 1, 0, 'rptVer')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('rptvenCorteDocu', 0, @disFormularios, 1, 0, 'rptXls')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('MostrarReporte', '0a63a0c0-c9c2-46d3-8a47-d06622468305', Null, Null, 'rptvenCorteDocu', Null, Null, 0, @disFormularios, 1, 0, 1, 'venCorteDocumentacion', 'met_Reporte', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', '4FCC4475-B3E0-4730-8EC7-FF6C2C89894C', Null, Null, 'rptvenCorteDocu', Null, Null, 0, @disFormularios, 1, 0, 1, 'met_Reporte', 'rptImprimir', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', '156BE816-40B7-4AF7-8AA5-1287FA4EE3F1', Null, Null, 'rptvenCorteDocu', Null, Null, 0, @disFormularios, 1, 0, 1, 'met_Reporte', 'rptPdf', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', 'EE6A6F93-3CB1-425E-9CF2-612FEB444076', Null, Null, 'rptvenCorteDocu', Null, Null, 0, @disFormularios, 1, 0, 1, 'met_Reporte', 'rptVer', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('InvocarMetodo', 'B49D6D36-F3E8-4C6C-B16B-C6E0AE87346A', Null, Null, 'rptvenCorteDocu', Null, Null, 0, @disFormularios, 1, 0, 1, 'met_Reporte', 'rptXls', Null)
