Exec Borra_cuerpoForm 'LGCfrmstkMoviSerieSalidasSolap'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='LGCfrmstkMoviSerieSalidasSolap')
UPDATE disFormularios SET 
	Alto = 503,
	Ancho = 640,
	Arriba = 15,
	BotonCopiar = 0,
	BotonEliminar = 0,
	BotonGuardar = 0,
	BotonImprimir = 0,
	BotonNuevo = 0,
	BotonPostear = 0,
	BotonRptImprimir = 0,
	BotonRptPdf = 0,
	BotonRptVer = 0,
	BotonRptXls = 0,
	ClaseCommon = 'StockCommon.grdMoviSerieDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumstkMoviCabeAction',
	ClaseEnumEsp = Null,
	ClaseEventos = 'StockFEEventos.stkMoviSerieSalidasSolapa',
	ClaseEventosEsp = Null,
	ClaseExchange = 'StockExchange.stkMoviCabeActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'POPUP DE SERIE SALIDA SIN EMPRESA',
	DllCommon = 'StockCommon',
	DllCommonEsp = Null,
	DllEventos = 'StockFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'StockExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'LGCfrmstkMoviSerieSalidasSolap',
	FormularioPadre_Id = dbo.FuncFKdisFormularios('frmstkMoviSerieSalidasSolapa'),
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 15,
	PosicionInicial = 'D',
	Posteado = 0,
	Tabla_Id = '',
	TipoEspecial = Null,
	Titulo = 'POPUP DE SERIE SALIDA SIN EMPRESA',
	UltimaModif = '20200703 19:12:14:013',
	Usuario_Id = 1,
	Version = 'V2'
	WHERE Formulario_Id ='LGCfrmstkMoviSerieSalidasSolap'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(503, 640, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'StockCommon.grdMoviSerieDS', Null, 'EnumstkMoviCabeAction', Null, 'StockFEEventos.stkMoviSerieSalidasSolapa', Null, 'StockExchange.stkMoviCabeActionExchange', Null, Null, 'POPUP DE SERIE SALIDA SIN EMPRESA', 'StockCommon', Null, 'StockFEEventos', Null, 'StockExchange', Null, Null, 'LGCfrmstkMoviSerieSalidasSolap', dbo.FuncFKdisFormularios('frmstkMoviSerieSalidasSolapa'), 0, 0, 15, 'D', 0, '', Null, 'POPUP DE SERIE SALIDA SIN EMPRESA', '20200703 19:12:14:013', 1, 'V2')
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('LGCfrmstkMoviSerieSalidasSolap')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='LGCfrmstkMoviSerieSalidasSolap')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 503, 640, 'T,L', 15, 1, 0, 0, 'LGCfrmstkMoviSerieSalidasSolap', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 1, 0, 15, 0, 0, Null, 0, Null, 0, 0, 1, 'POPUP DE SERIE SALIDA SIN EMPRESA', Null, 0, 'frm', Null, 1)
