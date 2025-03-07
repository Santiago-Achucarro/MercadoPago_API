Exec Borra_cuerpoForm 'frmgenConfiguracionDescargaFac'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmgenConfiguracionDescargaFac')
UPDATE disFormularios SET 
	Alto = 600,
	Ancho = 980,
	Arriba = 58,
	BotonCopiar = 1,
	BotonEliminar = 0,
	BotonGuardar = 0,
	BotonImprimir = 0,
	BotonNuevo = 1,
	BotonPostear = 1,
	BotonRptImprimir = 0,
	BotonRptPdf = 0,
	BotonRptVer = 0,
	BotonRptXls = 0,
	ClaseCommon = 'ComprasCommon.comPFXDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumcomPFXAction',
	ClaseEnumEsp = Null,
	ClaseEventos = '',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ComprasExchange.comPFXActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Configuracion Descarga Facturas',
	DllCommon = 'ComprasCommon',
	DllCommonEsp = Null,
	DllEventos = 'ComprasFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ComprasExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmgenConfiguracionDescargaFac',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 3,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'genGlobales',
	TipoEspecial = Null,
	Titulo = 'Configuracion_Descarga_Facturas',
	UltimaModif = '20181224 00:00:00:000',
	Usuario_Id = 1,
	Version = Null
	WHERE Formulario_Id ='frmgenConfiguracionDescargaFac'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(600, 980, 58, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 'ComprasCommon.comPFXDS', Null, 'EnumcomPFXAction', Null, '', Null, 'ComprasExchange.comPFXActionExchange', Null, Null, 'Configuracion Descarga Facturas', 'ComprasCommon', Null, 'ComprasFEEventos', Null, 'ComprasExchange', Null, Null, 'frmgenConfiguracionDescargaFac', Null, 0, 0, 3, 'D', 1, 'genGlobales', Null, 'Configuracion_Descarga_Facturas', '20181224 00:00:00:000', 1, Null)
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmgenConfiguracionDescargaFac')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmgenConfiguracionDescargaFac')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 600, 980, 'T,L', 58, 1, 0, 0, 'frmgenConfiguracionDescargaFac', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 3, 0, 0, Null, 0, Null, 0, 0, 1, 'Configuracion_Descarga_Facturas', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 561, 964, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmgenConfiguracionDescargaFac', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 535, 956, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 314, 'L', 1, 1, 0, 2, 'ctrArchivoPFX', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, 32767, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'ArchivoPFX', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 314, 'L', 1, 1, 2, 2, 'ctrClavePFX', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, 32767, 5, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'ClavePFX', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 33, 314, 'L', 1, 1, 0, 2, 'ctrUploadKey', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 0, 1, Null, 6, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioUpLoad', 'UploadKey', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 314, 'L', 1, 1, 2, 2, 'ctrClaveKey', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 1, 32767, 7, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtEditor', 'ClaveKey', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmgenConfiguracionDescargaFac', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 7, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmgenConfiguracionDescargaFac', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 8, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 33, 314, 'L', 1, 1, 0, 2, 'ctrUploadCer', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 2, 1, @disFormularios, 1, 0, 0, 1, Null, 8, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioUpLoad', 'UploadCer', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmgenConfiguracionDescargaFac', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ArchivoPFX', 'ctrArchivoPFX', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ClaveKey', 'ctrClaveKey', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'ClavePFX', 'ctrClavePFX', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioTxtEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('C', 'UploadCer', 'ctrUploadCer', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioUpLoad')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('C', 'UploadKey', 'ctrUploadKey', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioUpLoad')
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
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmgenConfiguracionDescargaFac', 0, @disFormularios, 1, 0, 'Guardar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmgenConfiguracionDescargaFac', 0, @disFormularios, 1, 0, 'Post_Load')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '3089f569-3069-4454-ad24-423f5c963e98', Null, Null, 'frmgenConfiguracionDescargaFac', Null, Null, 0, @disFormularios, 1, 0, 2, 'Guardar', 'Guardar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '16d417a9-e78d-49a7-92ca-2adfc6007f82', Null, Null, 'frmgenConfiguracionDescargaFac', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Post_Load', Null)
--disControlesTexto
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrArchivoPFX', @disFormularios, 0)
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrClaveKey', @disFormularios, 0)
INSERT INTO disControlesTexto(CharCasing, Control_Id, Formulario_Id, MultiplesLineas) VALUES('Normal', 'ctrClavePFX', @disFormularios, 0)
--disControlesUpLoad
INSERT INTO disControlesUpLoad(ColumnaNombreInterno, Control_Id, ExtensionesPermitidas, Formulario_Id, GuardaCaminoCompleto) VALUES(Null, 'ctrUploadCer', Null, @disFormularios, 0)
INSERT INTO disControlesUpLoad(ColumnaNombreInterno, Control_Id, ExtensionesPermitidas, Formulario_Id, GuardaCaminoCompleto) VALUES(Null, 'ctrUploadKey', Null, @disFormularios, 0)
