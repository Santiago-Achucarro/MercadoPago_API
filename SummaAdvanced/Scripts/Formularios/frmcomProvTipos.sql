Exec Borra_cuerpoForm 'frmcomProvTipos'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmcomProvTipos')
UPDATE disFormularios SET 
	Alto = 480,
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
	ClaseCommon = 'ComprasCommon.comProvTiposDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumcomProvTiposAction',
	ClaseEnumEsp = Null,
	ClaseEventos = 'ComprasFEEventos.comProvTipos',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ComprasExchange.comProvTiposActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = 'frmcomProvTipos',
	Descripcion = 'Tipos_de_Proveedores',
	DllCommon = 'ComprasCommon',
	DllCommonEsp = Null,
	DllEventos = 'ComprasFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ComprasExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmcomProvTipos',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 3,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'comProvTipos',
	TipoEspecial = Null,
	Titulo = 'Tipos_de_Proveedores',
	UltimaModif = '20201217 15:30:40:663',
	Usuario_Id = 1,
	Version = Null
	WHERE Formulario_Id ='frmcomProvTipos'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(480, 640, 58, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 'ComprasCommon.comProvTiposDS', Null, 'EnumcomProvTiposAction', Null, 'ComprasFEEventos.comProvTipos', Null, 'ComprasExchange.comProvTiposActionExchange', Null, 'frmcomProvTipos', 'Tipos_de_Proveedores', 'ComprasCommon', Null, 'ComprasFEEventos', Null, 'ComprasExchange', Null, Null, 'frmcomProvTipos', Null, 0, 0, 3, 'D', 1, 'comProvTipos', Null, 'Tipos_de_Proveedores', '20201217 15:30:40:663', 1, Null)
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmcomProvTipos')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmcomProvTipos')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 480, 640, 'T,L', 58, 1, 0, 0, 'frmcomProvTipos', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 3, 0, 0, Null, 0, Null, 0, 0, 1, 'Tipos_de_Proveedores', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 441, 624, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmcomProvTipos', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 415, 616, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 98, 'L', 1, 1, 0, 1, 'ctrProvTipo_Id', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'ProvTipo_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 98, 'L', 1, 1, 1, 1, 'ctrProvTipo_Id_Nueva', 1, 'Solapa_Datos', Null, 0, 1, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, 5, 5, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'ProvTipo_Id_Nueva', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 200, 'L', 1, 1, 0, 2, 'ctrDescripcion', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 1, 35, 6, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'Descripcion', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 17, 64, 'L', 4, 1, 0, 1, 'ctrInactivo', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 2, 1, @disFormularios, 1, 0, 0, 5, Null, 7, Null, 0, Null, 0, 0, 1, 'Inactivo', Null, 0, 'SummaAdvDisenio.Controles.DisenioCheck', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 17, 109, 'L', 3, 1, 0, 1, 'ctrPTodasEmpresas', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 3, 1, @disFormularios, 1, 0, 0, 3, Null, 8, Null, 0, Null, 0, 0, 1, 'PTodasEmpresas', Null, 0, 'SummaAdvDisenio.Controles.DisenioCheck', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 415, 616, 'L', 22, 1, 0, 0, 'Solapa_Atri', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 8, Null, 1, Null, 0, 1, 0, 'Atributos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmcomProvTipos', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmcomProvTipos', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 10, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 81, 606, 'L', 1, 1, 0, 6, 'grdgenAtributosGenerales', 1, 'Solapa_Atri', Null, 0, 0, Null, 0, 1, @disFormularios, 1, 0, 0, 1, Null, 10, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioGridView', 'Atributos', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmcomProvTipos', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 11, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('grdgenAtributosGenerales', 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioGridView')
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'AtributoNro', 'ctrgenAtributoNro', 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Descripcion', 'ctrgenDescripcion', 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ValorC', 'ctrgenValorC', 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ValorF', 'ctrgenValorF', 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ValorN', 'ctrgenValorN', 0, @disFormularios, 'genAtributosGenerales', 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'comProvTipos', 'ctrcomProvTipos', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Descripcion', 'ctrDescripcion', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'DescripcionUsuario', 'ctrDescripcionUsuario', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Empresa_Id', 'ctrEmpresa_Id', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Inactivo', 'ctrInactivo', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioCheck')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Posteado', 'ctrPosteado', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'ProvTipo_Id', 'ctrProvTipo_Id', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ProvTipo_Id_Nueva', 'ctrProvTipo_Id_Nueva', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'PTodasEmpresas', 'ctrPTodasEmpresas', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioCheck')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Usuario_Id', 'ctrUsuario_Id', 0, @disFormularios, 'Principal', 'NoUsado')
--disControlesSolapa
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 12, 'Solapa_Atri', @disFormularios, Null, Null, 1, Null, 'Medium', 0, 0, 'AtributosGenerales')
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 6, 'Solapa_Datos', @disFormularios, Null, Null, 0, Null, 'Medium', 0, 0, 'Ninguno')
--disControlesFilaSolapa
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 5, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 6, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 7, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 8, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 9, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 10, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Atri', 11, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'Solapa_Datos', 5, @disFormularios, 'A')
--disControlesColumnaSolapa
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_Atri', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_Atri', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_Atri', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_Atri', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_Atri', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_Atri', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_Datos', @disFormularios, 'P')
--disControlesCheckBox
INSERT INTO disControlesCheckBox(Checked, Control_Id, Formulario_Id) VALUES(0, 'ctrInactivo', @disFormularios)
INSERT INTO disControlesCheckBox(Checked, Control_Id, Formulario_Id) VALUES(0, 'ctrPTodasEmpresas', @disFormularios)
--disControlesGrilla
INSERT INTO disControlesGrilla(AccionNuevoValorNodo, AnchoColPorContenido, AnchoColumnasFijas, AnchoMinimo, AutoFormateable, ColFormatoNumericoFila, ColumnaColorFondoFila, ColumnaColorTextoFila, ColumnasFijas, ColumnasOcultas, ColumnasSoloLectura, ColumnasTotalizarCantidad, ColumnasTotalizarMaximo, ColumnasTotalizarMinimo, ColumnasTotalizarPromedio, ColumnasTotalizarSuma, Control_Id, EditaEnGrilla, EsArbol, EsGrillaAdjuntos, FilasAMostrar, Formulario_Id, NombreColCalculoTotal, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, RegistrosxPagina, TotalizaColumnas) VALUES('Ninguna', 0, Null, 0, 0, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, 'grdgenAtributosGenerales', 0, 0, 0, 0, @disFormularios, Null, 1, 1, 1, 0, 0)
--disControlesGrillaColumnas
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, ColumnaColorFondoCelda, ColumnaColorTextoCelda, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, Null, Null, 0, 'grdgenAtributosGenerales', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'AtributoNro', 0, 0, 0, Null, Null, 'Int32', 'AtributoNro', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, ColumnaColorFondoCelda, ColumnaColorTextoCelda, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, Null, Null, 0, 'grdgenAtributosGenerales', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Descripcion', 1, 0, 0, Null, Null, 'String', 'Descripcion', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, ColumnaColorFondoCelda, ColumnaColorTextoCelda, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, Null, Null, 0, 'grdgenAtributosGenerales', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'ValorC', 2, 0, 0, Null, Null, 'String', 'ValorC', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, ColumnaColorFondoCelda, ColumnaColorTextoCelda, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, Null, Null, 0, 'grdgenAtributosGenerales', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'ValorF', 3, 0, 0, Null, Null, 'DateTime', 'ValorF', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, ColumnaColorFondoCelda, ColumnaColorTextoCelda, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, Null, Null, 0, 'grdgenAtributosGenerales', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'ValorN', 4, 0, 0, Null, Null, 'Decimal', 'ValorN', 0, 0, 0, 0, 0, 1)
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(2, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Upper', 'Alfanumerico', 5, 'ProvTipo_Id', Null, Null, 'String', 100, Null, 'ctrProvTipo_Id', 'Normal', 32767, 1, Null, 1, Null, @disFormularios, dbo.FuncFKlupIdentidades('comProvTipos'), Null, 0, 0, 0)
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrProvTipo_Id', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmcomProvTipos', 0, @disFormularios, 1, 0, 'Eliminar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmcomProvTipos', 0, @disFormularios, 1, 0, 'Guardar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmcomProvTipos', 0, @disFormularios, 0, 0, 'Post_Load')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'EF048DC8-E3CA-464D-B029-6A0B061BC094', Null, Null, 'ctrProvTipo_Id', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'A857F7EF-E482-4310-9C8A-FFF8FF78685E', Null, Null, 'frmcomProvTipos', Null, Null, 0, @disFormularios, 1, 0, 2, 'Eliminar', 'Eliminar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '19006AFB-A253-478A-ADB1-B22C83E94C24', Null, Null, 'frmcomProvTipos', Null, Null, 0, @disFormularios, 1, 0, 3, 'Guardar', 'Guardar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('EstablecerFoco', '139aaa23-c4a6-4816-9bb5-e13e7fdb8596', Null, Null, 'frmcomProvTipos', 'ctrProvTipo_Id', Null, 0, @disFormularios, 0, 0, 4, Null, 'Post_Load', Null)
--disControlesTexto
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, Mascara, MultiplesLineas) VALUES('Normal', 'ctrDescripcion', @disFormularios, Null, 0)
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, Mascara, MultiplesLineas) VALUES('Normal', 'ctrProvTipo_Id_Nueva', @disFormularios, Null, 0)
--disFormulariosComentarios
INSERT INTO disFormulariosComentarios(Comentario, FechaRegistro, FechaRegistroOrig, FechaUltModif, Formulario_Id, FormularioRegOrig_Id) VALUES('FM - EstablecerFoco', '20190616 20:07:05:697', '20190616 20:07:05:697', '20190616 20:07:05:697', @disFormularios, Null)
INSERT INTO disFormulariosComentarios(Comentario, FechaRegistro, FechaRegistroOrig, FechaUltModif, Formulario_Id, FormularioRegOrig_Id) VALUES('AO - Agregué la solapa "Atributos"', '20200918 11:00:33:040', '20200918 11:00:33:040', '20200918 11:00:33:040', @disFormularios, 'frmcomProvTipos')
