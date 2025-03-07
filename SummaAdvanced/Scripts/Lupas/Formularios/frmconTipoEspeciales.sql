Exec Borra_cuerpoForm 'frmconTipoEspeciales'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmconTipoEspeciales')
UPDATE disFormularios SET 
	Alto = 480,
	Ancho = 640,
	Arriba = 15,
	BotonCopiar = 1,
	BotonEliminar = 1,
	BotonGuardar = 0,
	BotonImprimir = 0,
	BotonNuevo = 1,
	BotonPostear = 1,
	BotonRptImprimir = 0,
	BotonRptPdf = 0,
	BotonRptVer = 0,
	BotonRptXls = 0,
	ClaseCommon = 'ContabilidadCommon.conTipoEspecialesDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumconTipoEspecialesAction',
	ClaseEnumEsp = Null,
	ClaseEventos = 'ContabilidadFEEventos.conTipoEspeciales',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ContabilidadExchange.conTipoEspecialesActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Tipos_Especiales',
	DllCommon = 'ContabilidadCommon',
	DllCommonEsp = Null,
	DllEventos = 'ContabilidadFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ContabilidadExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmconTipoEspeciales',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 15,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'conTipoEspeciales',
	TipoEspecial = Null,
	Titulo = 'Tipos_Especiales',
	UltimaModif = '20200629 19:53:03:180',
	Usuario_Id = 1,
	Version = Null
	WHERE Formulario_Id ='frmconTipoEspeciales'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(480, 640, 15, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 'ContabilidadCommon.conTipoEspecialesDS', Null, 'EnumconTipoEspecialesAction', Null, 'ContabilidadFEEventos.conTipoEspeciales', Null, 'ContabilidadExchange.conTipoEspecialesActionExchange', Null, Null, 'Tipos_Especiales', 'ContabilidadCommon', Null, 'ContabilidadFEEventos', Null, 'ContabilidadExchange', Null, Null, 'frmconTipoEspeciales', Null, 0, 0, 15, 'D', 1, 'conTipoEspeciales', Null, 'Tipos_Especiales', '20200629 19:53:03:180', 1, Null)
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmconTipoEspeciales')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmconTipoEspeciales')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 480, 640, 'T,L', 15, 1, 0, 0, 'frmconTipoEspeciales', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'Tipos_Especiales', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 441, 624, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmconTipoEspeciales', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 415, 616, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 98, 'L', 1, 1, 0, 1, 'ctrTipoEspe_Id', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'TipoEspe_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 200, 'L', 1, 1, 0, 2, 'ctrDescripcion', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 1, 32767, 5, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'Descripcion', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 205, 606, 'L', 0, 1, 0, 6, 'grdconTipoEspecialesCuerpo', 1, 'Solapa_Datos', Null, 0, 0, Null, 2, 1, @disFormularios, 1, 0, 0, 5, Null, 6, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioGridView', 'Tipos_contables', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 415, 616, 'L', 22, 1, 0, 0, 'Solapa_1', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 6, Null, 1, Null, 0, 1, 0, 'Tipos_contables', Null, 0, 'System.Windows.Forms.TabPage', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 200, 'L', 1, 1, 0, 2, 'ctrrpo23Tipo_Id', 1, 'Solapa_1', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 8, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Tipo_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmconTipoEspeciales', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmconTipoEspeciales', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 10, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmconTipoEspeciales', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 11, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('grdconTipoEspecialesCuerpo', 0, @disFormularios, 'conTipoEspecialesCuerpo', 'SummaAdvDisenio.Controles.DisenioGridView')
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'DescripcionTipoEspeciales', 'ctrrpo23DescripcionTipoEspecia', 0, @disFormularios, 'conTipoEspecialesCuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('D', 'DescripcionTiposContables', 'ctrrpo23Tipo_Id', 0, @disFormularios, 'conTipoEspecialesCuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'Tipo_Id', 'ctrrpo23Tipo_Id', 0, @disFormularios, 'conTipoEspecialesCuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'TipoEspe_Id', 'ctrrpo23TipoEspe_Id', 0, @disFormularios, 'conTipoEspecialesCuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Descripcion', 'ctrDescripcion', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'TipoEspe_Id', 'ctrTipoEspe_Id', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
--disControlesSolapa
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 13, 'Solapa_1', @disFormularios, Null, Null, 1, 'conTipoEspecialesCuerpo', 'Medium', 0, 0, 'EdicionFilaGrilla')
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 6, 'Solapa_Datos', @disFormularios, Null, Null, 0, Null, 'Medium', 0, 0, 'Ninguno')
--disControlesFilaSolapa
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 5, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 6, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 7, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 8, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 9, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 10, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 11, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_1', 12, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(250, 'Solapa_Datos', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 5, @disFormularios, 'A')
--disControlesColumnaSolapa
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_Datos', @disFormularios, 'P')
--disControlesGrilla
INSERT INTO disControlesGrilla(AccionNuevoValorNodo, AnchoColPorContenido, AnchoColumnasFijas, AnchoMinimo, AutoFormateable, ColFormatoNumericoFila, ColumnasFijas, ColumnasOcultas, ColumnasSoloLectura, ColumnasTotalizarCantidad, ColumnasTotalizarMaximo, ColumnasTotalizarMinimo, ColumnasTotalizarPromedio, ColumnasTotalizarSuma, Control_Id, EditaEnGrilla, EsArbol, EsGrillaAdjuntos, FilasAMostrar, Formulario_Id, NombreColCalculoTotal, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, RegistrosxPagina, TotalizaColumnas) VALUES('Ninguna', 0, Null, 0, 0, Null, Null, Null, Null, Null, Null, Null, Null, Null, 'grdconTipoEspecialesCuerpo', 0, 0, 0, 0, @disFormularios, Null, 1, 1, 1, 0, 0)
--disControlesGrillaColumnas
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdconTipoEspecialesCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'DescripcionTiposContables', 1, 0, 1, Null, Null, 'String', 'DescripcionTiposContables', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdconTipoEspecialesCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Tipo_Id', 0, 0, 0, Null, Null, 'String', 'Tipo_Id', 0, 0, 0, 0, 0, 1)
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(2, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 5, 'Tipo_Id', Null, Null, 'String', 100, Null, 'ctrrpo23Tipo_Id', 'Normal', 32767, 0, Null, 0, Null, @disFormularios, dbo.FuncFKlupIdentidades('conTiposContables'), Null, 0, 0, 0)
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 5, 'TipoEspe_Id', Null, Null, 'String', 70, Null, 'ctrTipoEspe_Id', 'Normal', 32767, 1, Null, 1, Null, @disFormularios, dbo.FuncFKlupIdentidades('conTipoEspeciales'), Null, 0, 0, 0)
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrTipoEspe_Id', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmconTipoEspeciales', 0, @disFormularios, 1, 0, 'Eliminar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmconTipoEspeciales', 0, @disFormularios, 1, 0, 'Guardar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmconTipoEspeciales', 0, @disFormularios, 1, 0, 'Post_Load')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '96F3145D-8F1B-4D03-BB20-CC16EEC4BE2B', Null, Null, 'ctrTipoEspe_Id', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'D233AE1F-020B-4180-88FD-3D0CAB5156EE', Null, Null, 'frmconTipoEspeciales', Null, Null, 0, @disFormularios, 1, 0, 2, 'Eliminar', 'Eliminar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '59E9A605-FBF0-4984-AD8E-86F415CB2F74', Null, Null, 'frmconTipoEspeciales', Null, Null, 0, @disFormularios, 1, 0, 3, 'Guardar', 'Guardar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('EstablecerFoco', '0748825a-087a-4517-833c-a1d171c219a6', Null, Null, 'frmconTipoEspeciales', 'ctrTipoEspe_Id', Null, 0, @disFormularios, 0, 0, 4, Null, 'Post_Load', Null)
--disControlesTexto
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrDescripcion', @disFormularios, 0)
