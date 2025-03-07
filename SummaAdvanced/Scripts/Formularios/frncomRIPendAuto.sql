Exec Borra_cuerpoForm 'frncomRIPendAuto'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frncomRIPendAuto')
UPDATE disFormularios SET 
	Alto = 503,
	Ancho = 640,
	Arriba = 15,
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
	ClaseCommon = 'ComprasCommon.comReqInternoPendAutoDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumcomReqInternoPendAutoAction',
	ClaseEnumEsp = Null,
	ClaseEventos = '',
	ClaseEventosEsp = Null,
	ClaseExchange = 'ComprasExchange.comReqInternoPendAutoActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Autorizacion de Requerimientos Internos',
	DllCommon = 'ComprasCommon',
	DllCommonEsp = Null,
	DllEventos = 'ComprasFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'ComprasExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frncomRIPendAuto',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 15,
	PosicionInicial = 'D',
	Posteado = 0,
	Tabla_Id = 'comReqInterno',
	TipoEspecial = Null,
	Titulo = 'Autorizacion_de_Requerimientos_Internos',
	UltimaModif = '20200519 09:21:33:047',
	Usuario_Id = 1,
	Version = 'V2'
	WHERE Formulario_Id ='frncomRIPendAuto'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(503, 640, 15, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 'ComprasCommon.comReqInternoPendAutoDS', Null, 'EnumcomReqInternoPendAutoAction', Null, '', Null, 'ComprasExchange.comReqInternoPendAutoActionExchange', Null, Null, 'Autorizacion de Requerimientos Internos', 'ComprasCommon', Null, 'ComprasFEEventos', Null, 'ComprasExchange', Null, Null, 'frncomRIPendAuto', Null, 0, 0, 15, 'D', 0, 'comReqInterno', Null, 'Autorizacion_de_Requerimientos_Internos', '20200519 09:21:33:047', 1, 'V2')
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frncomRIPendAuto')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frncomRIPendAuto')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 503, 640, 'T,L', 15, 1, 0, 0, 'frncomRIPendAuto', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'Autorizacion_de_Requerimientos_Internos', Null, 0, 'frm', Null, 1)
