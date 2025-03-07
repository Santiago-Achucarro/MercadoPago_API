Exec Borra_cuerpoForm 'frmconRubros'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmconRubros')
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
	ClaseCommon = 'ContabilidadCommon.conRubrosDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumconRubrosAction',
	ClaseEnumEsp = Null,
	ClaseEventos = 'ContabilidadFEEventos.conRubros',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ContabilidadExchange.conRubrosActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Rubros',
	DllCommon = 'ContabilidadCommon',
	DllCommonEsp = Null,
	DllEventos = 'ContabilidadFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ContabilidadExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmconRubros',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 15,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'conRubros',
	TipoEspecial = Null,
	Titulo = 'Rubros',
	UltimaModif = '20180816 00:00:00:000',
	Usuario_Id = 1,
	Version = Null
	WHERE Formulario_Id ='frmconRubros'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(480, 640, 15, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 'ContabilidadCommon.conRubrosDS', Null, 'EnumconRubrosAction', Null, 'ContabilidadFEEventos.conRubros', Null, 'ContabilidadExchange.conRubrosActionExchange', Null, Null, 'Rubros', 'ContabilidadCommon', Null, 'ContabilidadFEEventos', Null, 'ContabilidadExchange', Null, Null, 'frmconRubros', Null, 0, 0, 15, 'D', 1, 'conRubros', Null, 'Rubros', '20180816 00:00:00:000', 1, Null)
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmconRubros')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmconRubros')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 480, 640, 'T,L', 15, 1, 0, 0, 'frmconRubros', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'Rubros', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 441, 624, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmconRubros', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 415, 616, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 298, 'L', 0, 1, 0, 1, 'ctrRubro_Id', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 5, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Rubro_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 298, 'L', 0, 1, 0, 1, 'ctrDescripcion', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 5, 35, 5, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'Descripcion', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 298, 'L', 0, 1, 0, 1, 'ctrTipo', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 2, 1, @disFormularios, 1, 0, 1, 5, Null, 6, Null, 0, Null, 0, 0, 1, 'Tipo', Null, 0, 'SummaAdvDisenio.Controles.DisenioComboBox', 'Tipo', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmconRubros', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 7, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmconRubros', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 8, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmconRubros', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Descripcion', 'ctrDescripcion', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'Rubro_Id', 'ctrRubro_Id', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Tipo', 'ctrTipo', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioComboBox')
--disControlesSolapa
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 6, 'Solapa_Datos', @disFormularios, Null, Null, 0, Null, 'Medium', 0, 0, 'Ninguno')
--disControlesFilaSolapa
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 5, @disFormularios, 'A')
--disControlesColumnaSolapa
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 0, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 5, 'Solapa_Datos', @disFormularios, 'P')
--disControlesCombo
INSERT INTO disControlesCombo(CheckBoxes, Control_Id, EsOptionGroup, Formulario_Id, Identidad, Identidad_Id, MultiSeleccion, OptionGroupHorizontal) VALUES(0, 'ctrTipo', 0, @disFormularios, Null, Null, 0, 0)
--disControlesComboItems
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Activo', @disFormularios, 'string', 'ACT')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Capital_Contable', @disFormularios, 'string', 'CAP')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Costos', @disFormularios, 'string', 'COS')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Gastos', @disFormularios, 'string', 'GAS')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Ingresos', @disFormularios, 'string', 'ING')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Otros_Egresos', @disFormularios, 'string', 'OE')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Otros_Ingresos', @disFormularios, 'string', 'OI')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Orden', @disFormularios, 'string', 'ORD')
INSERT INTO disControlesComboItems(Control_Id, Descripcion, Formulario_Id, Tipo, Valor) VALUES('ctrTipo', 'Pasivo', @disFormularios, 'string', 'PAS')
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(1, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 1, 'Rubro_Id', Null, Null, 'String', 100, Null, 'ctrRubro_Id', 'Normal', 32767, 1, Null, 1, Null, @disFormularios, dbo.FuncFKlupIdentidades('conRubros'), Null, 0, 0, 0)
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrRubro_Id', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmconRubros', 0, @disFormularios, 1, 0, 'Eliminar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmconRubros', 0, @disFormularios, 1, 0, 'Guardar')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '3BED5F67-B0EE-496E-823B-F7C6224B0F74', Null, Null, 'ctrRubro_Id', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'B3A5A90A-B133-4E1F-89D3-34F67387BD24', Null, Null, 'frmconRubros', Null, Null, 0, @disFormularios, 1, 0, 3, 'Eliminar', 'Eliminar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'C9991F1D-DAF5-4920-A81E-3F8DBF73BABB', Null, Null, 'frmconRubros', Null, Null, 0, @disFormularios, 1, 0, 2, 'Guardar', 'Guardar', Null)
--disControlesTexto
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrDescripcion', @disFormularios, 0)
