Exec Borra_cuerpoForm 'frmsueVariables'
--disFormularios
IF Exists(SELECT 1 FROM disFormularios WHERE Formulario_Id ='frmsueVariables')
UPDATE disFormularios SET 
	Alto = 600,
	Ancho = 980,
	Arriba = 58,
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
	ClaseCommon = 'SueldosCommon.sueVariableDS',
	ClaseCommonEsp = Null,
	ClaseEnum = 'EnumsueVariableAction',
	ClaseEnumEsp = Null,
	ClaseEventos = 'SueldosFEEventos.sueVariables',
	ClaseEventosEsp = Null,
	ClaseExchange = 'SueldosExchange.sueVariableActionExchange',
	ClaseExchangeEsp = Null,
	CodigoLnk = Null,
	Descripcion = 'Activar_Conceptos_por_Empleado',
	DllCommon = 'SueldosCommon',
	DllCommonEsp = Null,
	DllEventos = 'SueldosFEEventos',
	DllEventosEsp = Null,
	DllExchange = 'SueldosExchange',
	DllExchangeEsp = Null,
	Especializacion = Null,
	Formulario_Id = 'frmsueVariables',
	FormularioPadre_Id = null ,
	GuardaeImprime = 0,
	Inactivo = 0,
	Izquierda = 3,
	PosicionInicial = 'D',
	Posteado = 1,
	Tabla_Id = 'sueVariables',
	TipoEspecial = Null,
	Titulo = 'Activar_Conceptos_por_Empleado',
	UltimaModif = '20200629 19:53:03:180',
	Usuario_Id = 1,
	Version = 'V2'
	WHERE Formulario_Id ='frmsueVariables'
ELSE
	INSERT INTO disFormularios(Alto, Ancho, Arriba, BotonCopiar, BotonEliminar, BotonGuardar, BotonImprimir, BotonNuevo, BotonPostear, BotonRptImprimir, BotonRptPdf, BotonRptVer, BotonRptXls, ClaseCommon, ClaseCommonEsp, ClaseEnum, ClaseEnumEsp, ClaseEventos, ClaseEventosEsp, ClaseExchange, ClaseExchangeEsp, CodigoLnk, Descripcion, DllCommon, DllCommonEsp, DllEventos, DllEventosEsp, DllExchange, DllExchangeEsp, Especializacion, Formulario_Id, FormularioPadre_Id, GuardaeImprime, Inactivo, Izquierda, PosicionInicial, Posteado, Tabla_Id, TipoEspecial, Titulo, UltimaModif, Usuario_Id, Version) VALUES(600, 980, 58, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 'SueldosCommon.sueVariableDS', Null, 'EnumsueVariableAction', Null, 'SueldosFEEventos.sueVariables', Null, 'SueldosExchange.sueVariableActionExchange', Null, Null, 'Activar_Conceptos_por_Empleado', 'SueldosCommon', Null, 'SueldosFEEventos', Null, 'SueldosExchange', Null, Null, 'frmsueVariables', Null, 0, 0, 3, 'D', 1, 'sueVariables', Null, 'Activar_Conceptos_por_Empleado', '20200629 19:53:03:180', 1, 'V2')
Declare @disFormularios int 
set @disFormularios = dbo.FuncFKdisFormularios('frmsueVariables')
--disControles
IF NOT Exists(SELECT 1 FROM disControles Where Formulario_Id =  @disFormularios and Control_Id ='frmsueVariables')
	INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', Null, 600, 980, 'T,L', 58, 1, 0, 0, 'frmsueVariables', 1, Null, Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 3, 0, 0, Null, 0, Null, 0, 0, 1, 'Activar_Conceptos_por_Empleado', Null, 0, 'frm', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 561, 964, 'L', 0, 1, 0, 0, 'Solapas', 1, 'frmsueVariables', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 0, Null, 1, Null, 1, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioTabControl', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 535, 956, 'L', 22, 1, 0, 0, 'Solapa_Datos', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 2, Null, 1, Null, 0, 0, 0, 'Datos', Null, 0, 'System.Windows.Forms.TabPage', Null, 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 314, 'L', 1, 1, 0, 2, 'ctrLegajo', 1, 'Solapa_Datos', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 4, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Legajo', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 81, 952, 'L', 1, 1, 0, 6, 'grdCuerpo', 1, 'Solapa_Datos', Null, 0, 0, Null, 1, 1, @disFormularios, 1, 0, 0, 1, Null, 5, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioGridView', 'Conceptos', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 535, 956, 'L', 22, 1, 0, 0, 'soledCuerpo', 1, 'Solapas', Null, 0, 0, Null, 0, 0, @disFormularios, 1, 0, 0, 4, Null, 5, Null, 1, Null, 0, 1, 0, 'Editar_Cuerpo', Null, 0, 'System.Windows.Forms.TabPage', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar1', 1, 'frmsueVariables', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 7, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 314, 'L', 1, 1, 0, 2, 'ctrrpo6Grupo_Id', 1, 'soledCuerpo', Null, 0, 0, 'Default', 0, 1, @disFormularios, 1, 0, 1, 1, Null, 7, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Grupo_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar2', 1, 'frmsueVariables', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 8, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', 'Izquierda', 37, 314, 'L', 1, 1, 0, 2, 'ctrrpo6Concepto_Id', 1, 'soledCuerpo', Null, 0, 0, 'Default', 1, 1, @disFormularios, 1, 0, 1, 1, Null, 8, Null, 0, Null, 0, 0, 1, Null, Null, 0, 'SummaAdvDisenio.Controles.DisenioLupaAdv', 'Concepto_Id', 1)
INSERT INTO disControles(Alineacion, AlineacionLabel, Alto, Ancho, Ancla, Arriba, ClickNuevoBlanquea, Columna, ColumnasExtension, Control_Id, ControlaCambios, ControlParent_Id, ControlSegmento, Embebido, EsCodigoNuevo, Estilo, Fila, FilasExtension, Formulario_Id, Habilitado, Heredado, IgualaAnchoColumna, Izquierda, MaximaLongitud, NroControl, Paises, Requerido, SegmentoOrigen, SoloLectura, TabOrden, TabStop, Texto, TextoControlVacio, TextoFijo, TipoControl, TituloLabel, Visible) VALUES('', '', 0, 0, '', 0, 1, 0, 0, 'var_Auxiliar3', 1, 'frmsueVariables', Null, 0, 0, Null, 0, 0, @disFormularios, 0, 0, 0, 0, Null, 9, Null, 1, Null, 0, -1, 0, Null, Null, 0, 'Variable', Null, 0)
--disTablas
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('grdCuerpo', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioGridView')
INSERT INTO disTablas(Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 0, @disFormularios, 'Principal', Null)
--disTablasColumnas
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'Concepto_Id', 'ctrrpo6Concepto_Id', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('D', 'DescripcionConceptos', 'ctrrpo6Concepto_Id', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('D', 'DescripcionGrupos', 'ctrrpo6Grupo_Id', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'DescripcionUsuario', 'ctrrpo6DescripcionUsuario', 0, @disFormularios, 'Cuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'FechaRegistro', 'ctrrpo6FechaRegistro', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioDatePicker')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('1', 'Grupo_Id', 'ctrrpo6Grupo_Id', 0, @disFormularios, 'Cuerpo', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Legajo', 'ctrrpo6Legajo', 0, @disFormularios, 'Cuerpo', '')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Usuario_Id', 'ctrrpo6Usuario_Id', 0, @disFormularios, 'Cuerpo', 'NoUsado')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES('D', 'DescripcionLegajo', 'ctrLegajo', 0, @disFormularios, 'Principal', 'SummaAdvDisenio.Controles.DisenioLupaAdv')
INSERT INTO disTablasColumnas(AdicionalControl, Columna_Id, Control_Id, EsEspecializacion, Formulario_Id, Tabla_Id, TipoControl) VALUES(Null, 'Existe', 'ctrExiste', 0, @disFormularios, 'Principal', 'NoUsado')
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
INSERT INTO disControlesGrilla(AccionNuevoValorNodo, AnchoColPorContenido, AnchoColumnasFijas, AnchoMinimo, AutoFormateable, ColFormatoNumericoFila, ColumnasFijas, ColumnasOcultas, ColumnasSoloLectura, ColumnasTotalizarCantidad, ColumnasTotalizarMaximo, ColumnasTotalizarMinimo, ColumnasTotalizarPromedio, ColumnasTotalizarSuma, Control_Id, EditaEnGrilla, EsArbol, EsGrillaAdjuntos, FilasAMostrar, Formulario_Id, NombreColCalculoTotal, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, RegistrosxPagina, TotalizaColumnas) VALUES('Ninguna', 0, Null, 0, 0, Null, Null, Null, Null, Null, Null, Null, Null, Null, 'grdCuerpo', 0, 0, 0, 0, @disFormularios, Null, 1, 1, 1, 50, 0)
--disControlesGrillaColumnas
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('derecha', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 1, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Concepto_Id', 3, 0, 0, Null, Null, 'Int32', 'Concepto_Id', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 300, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'DescripcionConceptos', 4, 0, 1, Null, Null, 'String', 'DescripcionConceptos', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'DescripcionGrupos', 1, 0, 1, Null, Null, 'String', 'DescripcionGrupos', 0, 0, 0, 0, 0, 0)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'FechaRegistro', 2, 0, 0, Null, Null, 'DateTime', 'FechaRegistro', 0, 0, 0, 0, 0, 0)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('derecha', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 1, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Grupo_Id', 0, 0, 0, Null, Null, 'Int32', 'Grupo_Id', 0, 0, 0, 0, 0, 1)
INSERT INTO disControlesGrillaColumnas(Alineacion, Ancho, AnchoMinimo, AnchoVariable, AutoNumerico, CongelarTamanio, Control_Id, ControlColumna_Id, EsParamAccionBoton, EsPrimaryKey, Formato, Formulario_Id, Heredado, Identidad_Id, ItemsCombo, ModoOrdenamiento, ModoTamanioVariable, NombreCampo, Posicion, Requerido, SoloLectura, Texto, TextoColumnaVacia, TipoDato, Titulo, TotalizarCantidad, TotalizarMaximo, TotalizarMinimo, TotalizarPromedio, TotalizarSuma, Visible) VALUES('izquierda', 100, 5, 1, 0, 0, 'grdCuerpo', Null, 0, 0, Null, @disFormularios, 0, Null, Null, 'Automatic', 'NotSet', 'Legajo', 5, 0, 0, Null, Null, 'Int64', 'Legajo', 0, 0, 0, 0, 0, 0)
--disControlesGrupoSolapa
INSERT INTO disControlesGrupoSolapa(CantSolapas, Control_Id, Formulario_Id) VALUES(2, 'Solapas', @disFormularios)
--disControlesLupa
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Normal', 'Alfanumerico', 8, 'Legajo', Null, Null, 'String', 100, Null, 'ctrLegajo', 'Normal', 32767, 0, Null, 1, 'Inactivo;equals;0;S@Posteado;equals;1;S', @disFormularios, dbo.FuncFKlupIdentidades('suePersonal'), Null, 0, 0, 0)
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Normal', 'Numerico', 6, 'Concepto_Id', Null, Null, 'String', 100, Null, 'ctrrpo6Concepto_Id', 'Normal', 32767, 0, Null, 0, 'Inactivo;equals;0;S@Posteado;equals;1;S', @disFormularios, dbo.FuncFKlupIdentidades('sueConceptos'), Null, 0, 0, 0)
INSERT INTO disControlesLupa(AdicionalesCampos, AdicionalesControles, AdicionalesParametros, CamposClave, CantMaxRegAMostrar, CodigoCharCasing, CodigoMask, CodigoMaxLength, CodigoNombreColumna, CodigoRegExpression, CodigoTexto, CodigoTipo, CodigoWidth, ColumnaGrillaDescripcion, Control_Id, DescripcionCharCasing, DescripcionMaxLength, DescripcionOculta, DescripcionTexto, EsLaEntidadDelForm, Filtros, Formulario_Id, Identidad_Id, OrderBy, PermiteNoExistentes, TraePrimerRegistro, UsaAccion) VALUES(Null, Null, Null, 1, 70, 'Normal', 'Numerico', 4, 'Grupo_Id', Null, Null, 'String', 100, Null, 'ctrrpo6Grupo_Id', 'Normal', 32767, 0, Null, 0, 'Posteado;equals;1;S@Inactivo;equals;0;S@Empresa_Id;isnullOrEqualTo;{gEmpresa};S', @disFormularios, dbo.FuncFKlupIdentidades('sueGrupos'), Null, 0, 0, 0)
--disEventos
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrLegajo', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('ctrrpo6Grupo_Id', 0, @disFormularios, 1, 0, 'Change')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmsueVariables', 0, @disFormularios, 1, 0, 'Eliminar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmsueVariables', 0, @disFormularios, 1, 0, 'Guardar')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('frmsueVariables', 0, @disFormularios, 1, 0, 'Post_Load')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('grdCuerpo', 0, @disFormularios, 1, 0, 'EjecutarValidarFila')
INSERT INTO disEventos(Control_Id, EsMetodo, Formulario_Id, Habilitado, Heredado, TipoEvento) VALUES('grdCuerpo', 0, @disFormularios, 1, 0, 'InicioEdicionFila')
--disAcciones
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '1f9c132b-04ba-4480-ad56-c58d1e72cae6', Null, Null, 'ctrLegajo', Null, Null, 0, @disFormularios, 1, 0, 1, 'Datos', 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('AsignarValor', '0ec54bfc-6cfc-4220-bb92-f3c49fe4cfce', Null, Null, 'ctrrpo6Grupo_Id', 'var_Auxiliar1', 'ctrrpo6Grupo_Id', 0, @disFormularios, 1, 0, 2, Null, 'Change', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', '987ded83-6e75-4dca-a7df-1073473d03d7', Null, Null, 'frmsueVariables', Null, Null, 0, @disFormularios, 1, 0, 3, 'Eliminar', 'Eliminar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('Ejecutar', 'd84ef7e8-5c18-4e26-bccc-34d833ca0c7f', Null, Null, 'frmsueVariables', Null, Null, 0, @disFormularios, 1, 0, 4, 'Guardar', 'Guardar', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('EstablecerFoco', '62a5c622-40cd-490c-a3ad-7c956ff1c563', Null, Null, 'frmsueVariables', 'ctrLegajo', Null, 0, @disFormularios, 0, 0, 7, Null, 'Post_Load', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('ValidarFilaGrilla', '4b8af48c-0e8f-4f94-821c-8aea583e47ef', Null, Null, 'grdCuerpo', Null, Null, 0, @disFormularios, 1, 0, 5, 'Validar', 'EjecutarValidarFila', Null)
INSERT INTO disAcciones(Accion, Accion_Id, AccionPadre_Id, AdicionalInfo, Control_Id, ControlDestino_Id, ControlTexto_Id, EsEspecializacion, Formulario_Id, Habilitado, Heredado, OrdenAccion, Texto, TipoEvento, ValorCondicion) VALUES('AsignarValor', '2bc229a0-ecaa-4f8c-ab88-3fc040493980', Null, Null, 'grdCuerpo', 'ctrrpo6Grupo_Id', 'var_Auxiliar1', 0, @disFormularios, 1, 0, 6, Null, 'InicioEdicionFila', Null)
--disFormulariosComentarios
INSERT INTO disFormulariosComentarios(Comentario, FechaRegistro, FechaRegistroOrig, FechaUltModif, Formulario_Id, FormularioRegOrig_Id) VALUES('FM - EstablecerFoco, filtros en lupas', '20191017 14:31:19:833', '20191017 14:31:19:833', '20191017 14:31:19:833', @disFormularios, Null)
