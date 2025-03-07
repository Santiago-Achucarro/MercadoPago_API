Exec Borra_cuerpoForm 'frmcomForEntre'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmcomForEntre')
UPDATE disFormularios SET 
	Alto = 518,
	Ancho = 640,
	Arriba = 58,
	BotonCopiar = 1,
	BotonEliminar = 1,
	BotonGuardar = 1,
	BotonImprimir = 0,
	BotonNuevo = 1,
	BotonPostear = 1,
	BotonRptImprimir = 0,
	BotonRptPdf = 0,
	BotonRptVer = 0,
	BotonRptXls = 0,
	ClaseCommon = 'ComprasCommon.comForEntreDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumcomForEntreAction',
	ClaseEnumEsp = Null,
	ClaseEventos = '',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ComprasExchange.comForEntreActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Formas_de_Entrega',
	DllCommon = 'ComprasCommon',
	DllCommonEsp = Null,
	DllEventos = 'ComprasFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ComprasExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmcomForEntre',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 3,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'comForEntre',
	TipoEspecial = Null,
	Titulo = 'Formas_de_Entrega',
	UltimaModif = '20200629 19:53:03:180',
	Usuario_Id = 1,
	Version = 'V2'
	WHERE Formulario_Id ='frmcomForEntre'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(518, 640, 58, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 'ComprasCommon.comForEntreDS', Null, 'EnumcomForEntreAction', Null, '', Null, 'ComprasExchange.comForEntreActionExchange', Null, Null, 'Formas_de_Entrega', 'ComprasCommon', Null, 'ComprasFEEventos', Null, 'ComprasExchange', Null, Null, 'frmcomForEntre', Null, 0, 0, 3, 'D', 1, 'comForEntre', Null, 'Formas_de_Entrega', '20200629 19:53:03:180', 1, 'V2')
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmcomForEntre')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmcomForEntre')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 518, 640, 'T,L', 15, 1, 0, 0, 'frmcomForEntre', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'Formas_de_Entrega', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 479, 624, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmcomForEntre', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 453, 616, 'L', 22, 1, 0, 0, 'Solapa_1', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Solapa_1', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 98, 'L', 1, 1, 0, 1, 'ctrFormaEnt_Id', 1, 'Solapa_1', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'FormaEnt_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 98, 'L', 1, 1, 1, 1, 'ctrFormaEnt_Id_Nueva', 1, 'Solapa_1', Null, 0, 1, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, 5, 5, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'FormaEnt_Id_Nueva', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 17, 64, 'L', 6, 1, 2, 1, 'ctrInactivo', 1, 'Solapa_1', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 0, 15, Null, 6, Null, 0, Null, 0, 0, 1, 'Inactivo', Null, 0, 'SummaAdvDisenio.Controles.DisenioCheck', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 17, 109, 'L', 6, 1, 3, 1, 'ctrPTodasEmpresas', 1, 'Solapa_1', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 0, 19, Null, 7, Null, 0, Null, 0, 0, 1, 'PTodasEmpresas', Null, 0, 'SummaAdvDisenio.Controles.DisenioCheck', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmcomForEntre', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 7, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmcomForEntre', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 8, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 200, 'L', 1, 1, 0, 2, 'ctrDescripcion', 1, 'Solapa_1', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 1, 35, 8, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'Descripcion', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmcomForEntre', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioGridView')
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'AtributoNro', Null, 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Descripcion', Null, 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ValorC', Null, 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ValorF', Null, 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ValorN', Null, 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'comForEntre', 'ctrcomForEntre', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Descripcion', 'ctrDescripcion', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'DescripcionUsuario', 'ctrDescripcionUsuario', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Empresa_Id', 'ctrEmpresa_Id', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'FormaEnt_Id', 'ctrFormaEnt_Id', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'FormaEnt_Id_Nueva', 'ctrFormaEnt_Id_Nueva', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Inactivo', 'ctrInactivo', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioCheck')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Posteado', 'ctrPosteado', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'PTodasEmpresas', 'ctrPTodasEmpresas', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioCheck')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Usuario_Id', 'ctrUsuario_Id', 0, @disFormularios, 'Principal', 'NoUsado')
--disControlesSolapa
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 12, 'Solapa_1', @disFormularios, Null, Null, 0, Null, 'Medium', 0, 0, 'Ninguno')
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
--disControlesColumnaSolapa
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_1', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_1', @disFormularios, 'P')
--disControlesCheckBox
INSERT INTO disControlesCheckBox(Checked, Control_Id, Formulario_Id) VALUES(0, 'ctrInactivo', @disFormularios)
INSERT INTO disControlesCheckBox(Checked, Control_Id, Formulario_Id) VALUES(0, 'ctrPTodasEmpresas', @disFormularios)
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(1, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 5, 'FormaEnt_Id', Null, Null, 'String', 100, Null, 'ctrFormaEnt_Id', 'Normal', 32767, 1, Null, 1, Null, @disFormularios, dbo.FuncFKlupIdentidades('comForEntre'), Null, 0, 0, 0)
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrFormaEnt_Id', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmcomForEntre', 0, @disFormularios, 1, 0, 'Eliminar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmcomForEntre', 0, @disFormularios, 1, 0, 'Guardar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmcomForEntre', 0, @disFormularios, 1, 0, 'Post_Load')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'e33bf777-4fa4-4f4b-a3a6-b3f410f2bc65', Null, Null, 'ctrFormaEnt_Id', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '3b45a508-4ca3-4523-964c-9f90c7caaf39', Null, Null, 'frmcomForEntre', Null, Null, 0, @disFormularios, 1, 0, 2, 'Eliminar', 'Eliminar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '3b095ecd-be21-44df-90f0-3d853fb6519b', Null, Null, 'frmcomForEntre', Null, Null, 0, @disFormularios, 1, 0, 3, 'Guardar', 'Guardar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('EstablecerFoco', '842d3d63-1c71-4a35-b4e1-bc86622d712d', Null, Null, 'frmcomForEntre', 'ctrFormaEnt_Id', Null, 0, @disFormularios, 0, 0, 4, Null, 'Post_Load', Null)
--disControlesTexto
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrDescripcion', @disFormularios, 0)
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrFormaEnt_Id_Nueva', @disFormularios, 0)
--disFormulariosComentarios
INSERT INTO disFormulariosComentarios(Comentario, FechaRegistro, FechaRegistroOrig, FechaUltModif, Formulario_Id, FormularioRegOrig_Id) VALUES('FM - EstablecerFoco()', '20200405 13:01:22:863', '20200405 13:01:22:863', '20200405 13:01:22:863', @disFormularios, 'frmcomForEntre')
