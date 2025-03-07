Exec Borra_cuerpoForm 'frmsueLiqPersImporte'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmsueLiqPersImporte')
UPDATE disFormularios SET 
	Alto = 697,
	Ancho = 1024,
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
	ClaseCommon = 'SueldosCommon.sueLiqPersImportesDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumsueLiqPersImportesAction',
	ClaseEnumEsp = Null,
	ClaseEventos = '',
	ClaseEventosEsp = Null,
	ClaseExchange = 'SueldosExchange.sueLiqPersImportesActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Carga_de_Importes_Por_Empleado',
	DllCommon = 'SueldosCommon',
	DllCommonEsp = Null,
	DllEventos = 'SueldosFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'SueldosExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmsueLiqPersImporte',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 3,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'sueLiqPersImportes',
	TipoEspecial = Null,
	Titulo = 'Carga_de_Importes_Por_Empleado',
	UltimaModif = '20200629 19:52:58:113',
	Usuario_Id = 1,
	Version = 'V2'
	WHERE Formulario_Id ='frmsueLiqPersImporte'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(697, 1024, 58, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 'SueldosCommon.sueLiqPersImportesDS', Null, 'EnumsueLiqPersImportesAction', Null, '', Null, 'SueldosExchange.sueLiqPersImportesActionExchange', Null, Null, 'Carga_de_Importes_Por_Empleado', 'SueldosCommon', Null, 'SueldosFEEventos', Null, 'SueldosExchange', Null, Null, 'frmsueLiqPersImporte', Null, 0, 0, 3, 'D', 1, 'sueLiqPersImportes', Null, 'Carga_de_Importes_Por_Empleado', '20200629 19:52:58:113', 1, 'V2')
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmsueLiqPersImporte')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmsueLiqPersImporte')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 697, 1064, 'T,L', 58, 1, 0, 0, 'frmsueLiqPersImporte', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 3, 0, 0, Null, 0, Null, 0, 0, 1, 'Carga_de_Importes_Por_Empleado', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 658, 1008, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmsueLiqPersImporte', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 632, 1000, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 328, 'L', 1, 1, 0, 2, 'ctrLegajo', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Legajo', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 35, 162, 'L', 1, 1, 2, 1, 'ctrFecha', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 5, Null, 0, Null, 0, 0, 1, 'Hoy', Null, 0, 'SummaAdvDisenio.Controles.DisenioDatePicker', 'Fecha', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 81, 1034, 'L', 1, 1, 0, 6, 'grdCuerpo', 1, 'Solapa_Datos', Null, 0, 0, Null, 1, 1, @disFormularios, 1, 0, 0, 1, Null, 6, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioGridView', 'Titulo', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 632, 1000, 'L', 22, 1, 0, 0, 'soledCuerpo', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 6, Null, 1, Null, 0, 1, 0, 'Editar_Cuerpo', Null, 0, 'System.Windows.Forms.TabPage', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmsueLiqPersImporte', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 8, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 328, 'L', 1, 1, 0, 2, 'ctrrpo6Importe_Id', 1, 'soledCuerpo', Null, 0, 0, 'Default', 0, 1, @disFormularios, 0, 0, 1, 1, Null, 8, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Importe_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 38, 162, 'L', 1, 1, 0, 1, 'ctrrpo6Valor', 1, 'soledCuerpo', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 1, 5, 9, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor', 'Valor', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmsueLiqPersImporte', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmsueLiqPersImporte', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 10, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('grdCuerpo', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioGridView')
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('D', 'DescripcionImporte', 'ctrrpo6Importe_Id', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'DescripcionLegajo', 'ctrrpo6DescripcionLegajo', 0, @disFormularios, 'Cuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Empresa_Id', 'ctrrpo6Empresa_Id', 0, @disFormularios, 'Cuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Fecha_Desde', 'ctrrpo6Fecha_Desde', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'Importe_Id', 'ctrrpo6Importe_Id', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Legajo', 'ctrrpo6Legajo', 0, @disFormularios, 'Cuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Usuario_Id', 'ctrrpo6Usuario_Id', 0, @disFormularios, 'Cuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Valor', 'ctrrpo6Valor', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('D', 'DescripcionLegajo', 'ctrLegajo', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Fecha', 'ctrFecha', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'Legajo', 'ctrLegajo', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
--disControlesSolapa
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 12, 'Solapa_Datos', @disFormularios, Null, Null, 0, Null, 'Medium', 0, 0, 'Ninguno')
INSERT INTO disControlesSolapa(CantColumnas, CantFilas, Control_Id, Formulario_Id, FormularioPopup_Id, Parametros, Posicion, TablaPrimaria, TamanioPopup, TieneBtnCerrar, TieneBtnGuardar, TipoPopup) VALUES(6, 12, 'soledCuerpo', @disFormularios, Null, Null, 1, 'Cuerpo', 'Medium', 0, 0, 'EdicionFilaGrilla')
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
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 0, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 1, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 2, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 3, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 4, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 5, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 6, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 7, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 8, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 9, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 10, @disFormularios, 'A')
INSERT INTO disControlesFilaSolapa(Alto, Control_Id, Fila, Formulario_Id, TipoValor) VALUES(40, 'soledCuerpo', 11, @disFormularios, 'A')
--disControlesColumnaSolapa
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'Solapa_Datos', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 0, 'soledCuerpo', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 1, 'soledCuerpo', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 2, 'soledCuerpo', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 3, 'soledCuerpo', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(16, 4, 'soledCuerpo', @disFormularios, 'P')
INSERT INTO disControlesColumnaSolapa(Ancho, Columna, Control_Id, Formulario_Id, TipoValor) VALUES(20, 5, 'soledCuerpo', @disFormularios, 'P')
--disControlesGrilla
INSERT INTO disControlesGrilla(AccionNuevoValorNodo, AnchoColPorContenido, AnchoColumnasFijas, AnchoMinimo, AutoFormateable, ColFormatoNumericoFila, ColumnasFijas, ColumnasOcultas, ColumnasSoloLectura, ColumnasTotalizarCantidad, ColumnasTotalizarMaximo, ColumnasTotalizarMinimo, ColumnasTotalizarPromedio, ColumnasTotalizarSuma, Control_Id, EditaEnGrilla, EsArbol, EsGrillaAdjuntos, FilasAMostrar, Formulario_Id, NombreColCalculoTotal, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, RegistrosxPagina, TotalizaColumnas) VALUES('Ninguna', 0, Null, 0, 0, Null, Null, Null, Null, Null, Null, Null, Null, Null, 'grdCuerpo', 1, 0, 0, 0, @disFormularios, Null, 0, 0, 1, 0, 0)
--disControlesGrillaColumnas
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'DescripcionImporte', 1, 0, 1, Null, Null, 'String', 'DescripcionImporte', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Fecha_Desde', 3, 0, 0, Null, Null, 'DateTime', 'Fecha_Desde', 0, 0, 0, 0, 0, 0)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Importe_Id', 0, 0, 1, Null, Null, 'Int32', 'Importe_Id', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('derecha', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Valor', 2, 0, 0, Null, Null, 'Decimal', 'Valor', 0, 0, 0, 0, 0, 1)
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(2, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Normal', 'Alfanumerico', 32767, 'Legajo', Null, Null, 'String', 100, Null, 'ctrLegajo', 'Normal', 32767, 0, Null, 0, 'Empresa_Id;equals;{gEmpresa};N', @disFormularios, dbo.FuncFKlupIdentidades('suePersonal'), Null, 0, 0, 0)
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Normal', 'Alfanumerico', 32767, 'Importe_Id', Null, Null, 'String', 100, Null, 'ctrrpo6Importe_Id', 'Normal', 32767, 0, Null, 0, Null, @disFormularios, dbo.FuncFKlupIdentidades('sueImpNombre'), Null, 0, 0, 0)
--disControlesNumerico
INSERT INTO disControlesNumerico(BotonSpin, Control_Id, Decimales, EsPorcentaje, Formulario_Id, SpinIncremento, ValorMaximo, ValorMinimo) VALUES(0, 'ctrrpo6Valor', 2, 0, @disFormularios, 1, 99999.99000000, -99999.99000000)
--disControlesFecha
INSERT INTO disControlesFecha(Control_Id, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, Formulario_Id, ValorMaximo, ValorMinimo) VALUES('ctrFecha', Null, Null, Null, @disFormularios, 'En_Blanco', 'En_Blanco')
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrFecha', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrLegajo', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmsueLiqPersImporte', 0, @disFormularios, 1, 0, 'Guardar')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '929748c6-9ad1-49ab-8d13-760c5f17748a', Null, Null, 'ctrFecha', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '34454d37-e430-41f0-9194-e0f8bd9817fc', Null, Null, 'ctrLegajo', Null, Null, 0, @disFormularios, 1, 0, 2, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'd5880e0c-1d09-450a-b07f-dbef3c2d2881', Null, Null, 'frmsueLiqPersImporte', Null, Null, 0, @disFormularios, 1, 0, 3, 'Guardar', 'Guardar', Null)
--disFormulariosComentarios
INSERT INTO disFormulariosComentarios(Comentario, FechaRegistro, FechaRegistroOrig, FechaUltModif, Formulario_Id, FormularioRegOrig_Id) VALUES('AJ Habilitado false', '20200414 13:58:34:673', '20200414 13:58:34:673', '20200414 13:58:34:673', @disFormularios, 'frmsueLiqPersImporte')
