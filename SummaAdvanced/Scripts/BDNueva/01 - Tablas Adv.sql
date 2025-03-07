
CREATE TYPE CodigoPostal
	FROM VARCHAR(15) NOT NULL
go



CREATE TYPE QCantidad
	FROM NUMERIC(15,4) NOT NULL
go



CREATE TYPE qCantidadD8
	FROM NUMERIC(19,8) NOT NULL
go



CREATE TYPE qCuit
	FROM VARCHAR(25) NOT NULL
go



CREATE TYPE qFecha
	FROM DATETIME NOT NULL
go



CREATE TYPE qFechaHora
	FROM DATETIME NOT NULL
go



CREATE TYPE qFormula
	FROM VARCHAR(240) NOT NULL
go



CREATE TYPE QMemo
	FROM VARCHAR(MAX) NULL
go



CREATE TYPE qMonedaD2
	FROM NUMERIC(15,2) NOT NULL
go



CREATE TYPE qMonedaD4
	FROM NUMERIC(17,4) NOT NULL
go



CREATE TYPE qMonedaD8
	FROM NUMERIC(19,8) NOT NULL
go



CREATE TYPE qPorcentaje
	FROM NUMERIC(5,2) NOT NULL
go



CREATE TYPE Sino
	FROM BIT NOT NULL
go



CREATE TYPE Sucursal
	FROM CHAR(4) NOT NULL
go



CREATE TYPE SucursalN
	FROM INT NOT NULL
go



CREATE DEFAULT FechaHora_Actual
	AS getdate()
go



CREATE RULE MayorCero
	AS @col >= 0
go



CREATE RULE MayorOIgualCero
	AS @col >= 0
go



CREATE TABLE afiActivoFijo
( 
	afiActivoFijo        integer IDENTITY ( 1,1 ) ,
	ActivoFijo_Id        varchar(15)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Descripcion          varchar(max)  NOT NULL ,
	FechaAlta            qFecha ,
	FechaIniDepre        qFecha ,
	FechaBaja            qFecha  NULL ,
	ValorInicial         qMonedaD2 ,
	ValorFiscal          qMonedaD2 ,
	VidaUtil             integer  NOT NULL ,
	VidaUtilRestante     integer  NOT NULL ,
	PorResidual          qPorcentaje ,
	AmortAcumulada       qMonedaD2 ,
	Rubro_Id             integer  NULL ,
	Cantidad             QCantidad ,
	CtaValorOrigen_Id    integer  NULL ,
	CtaAmortAcum_Id      integer  NULL ,
	CtaAmortizacion_Id   integer  NULL ,
	Tipo                 varchar(2)  NOT NULL ,
	ValorInicialSI       qMonedaD2 ,
	AmortAcumSI          qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	FechaCarga           qFechaHora ,
	CONSTRAINT XPKafiActivoFijo PRIMARY KEY  CLUSTERED (afiActivoFijo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1afiActivoFijo ON afiActivoFijo
( 
	ActivoFijo_Id         ASC,
	Empresa_Id            ASC
)
go




exec sp_bindefault 'FechaHora_Actual', 'afiActivoFijo.FechaCarga'
go



CREATE TABLE afiBajas
( 
	conAsientos          bigint  NOT NULL ,
	Causa                varchar(max)  NOT NULL ,
	Cantidad             QCantidad ,
	Monto                qMonedaD2 ,
	MontoFiscal          qMonedaD2 ,
	MontoDepreciacion    qMonedaD2 ,
	CONSTRAINT XPKafiBajas PRIMARY KEY  CLUSTERED (conAsientos ASC)
)
go



CREATE TABLE afiCentros
( 
	ActivoFijo_Id        integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKafiCentros PRIMARY KEY  CLUSTERED (ActivoFijo_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE AficonMovcont
( 
	conAsientos          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	ActivoFijo_Id        integer  NULL ,
	Inactivo             Sino ,
	CONSTRAINT XPKAficonMovcont PRIMARY KEY  CLUSTERED (conAsientos ASC,Renglon ASC)
)
go



CREATE TABLE afiModulos
( 
	Asiento_Id           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	ActivoFijo_Id        integer  NULL ,
	CONSTRAINT XPKafiModulos PRIMARY KEY  CLUSTERED (Asiento_Id ASC,Renglon ASC)
)
go



CREATE TABLE afiMovimientos
( 
	afiActivoFijo        integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	conAsientos          bigint  NOT NULL ,
	TipoMov              varchar(2)  NOT NULL ,
	CONSTRAINT XPKafiMovimientos PRIMARY KEY  CLUSTERED (afiActivoFijo ASC,Renglon ASC,conAsientos ASC)
)
go



CREATE TABLE afiResponsableActivo
( 
	Responsable_Id       integer  NOT NULL ,
	Activofijo_Id        integer  NOT NULL ,
	FechaAsignacion      qFecha ,
	Cantidad             QCantidad ,
	CONSTRAINT XPKafiResponsableActivo PRIMARY KEY  CLUSTERED (Responsable_Id ASC,Activofijo_Id ASC,FechaAsignacion ASC)
)
go



CREATE TABLE AfiResponsables
( 
	afiResponsables      integer IDENTITY ( 1,1 ) ,
	Responsable_Id       varchar(15)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Posteado             Sino ,
	Inactivo             Sino ,
	CONSTRAINT XPKAfiResponsables PRIMARY KEY  CLUSTERED (afiResponsables ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1AfiResponsables ON AfiResponsables
( 
	Responsable_Id        ASC
)
go



CREATE TABLE afiRubros
( 
	afiRubros            integer IDENTITY ( 1,1 ) ,
	Rubro_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(120)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	VidaUtil             integer  NOT NULL ,
	VidaUtilFiscal       integer  NOT NULL ,
	CtaValorOrigen_Id    integer  NULL ,
	CtaAmortAcum_Id      integer  NULL ,
	CtaAmortizacion_Id   integer  NULL ,
	Tipo                 varchar(2)  NOT NULL ,
	Digitos              smallint  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaAlta            qFechaHora ,
	Posteado             Sino ,
	CONSTRAINT XPKafiRubros PRIMARY KEY  CLUSTERED (afiRubros ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1afiRubros ON afiRubros
( 
	Rubro_Id              ASC
)
go



CREATE TABLE comAsiCierre
( 
	Asiento_Id           bigint  NOT NULL ,
	Fecha                qFecha ,
	Moneda_Id            integer  NOT NULL ,
	CONSTRAINT XPKcomAsiCierre PRIMARY KEY  CLUSTERED (Asiento_Id ASC)
)
go



CREATE TABLE comAsiCierreCr
( 
	Asiento_Id           bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Proveed_id           bigint  NOT NULL ,
	CONSTRAINT XPKcomAsiCierreCr PRIMARY KEY  CLUSTERED (Asiento_Id ASC,conRenglon ASC)
)
go



CREATE TABLE comAsiSegmentosAnul
( 
	FechaAnulacion       qFechaHora ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Asiento_Id           bigint  NULL ,
	CONSTRAINT XPKgenAsiSegmentosAnul PRIMARY KEY  CLUSTERED (FechaAnulacion ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC,Segmento_Id ASC)
)
go



CREATE TABLE comCategorias
( 
	comCategorias        integer IDENTITY ( 1,1 ) ,
	Categoria_Id         varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	Empresa_id           integer  NULL ,
	CONSTRAINT XPKcomCategorias PRIMARY KEY  CLUSTERED (comCategorias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comCategorias ON comCategorias
( 
	Categoria_Id          ASC
)
go



CREATE TABLE comCFDISat
( 
	UUID                 char(36)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	RFCEmisor            char(13)  NOT NULL ,
	Fecha                qFecha ,
	Monto                qMonedaD2 ,
	Folio                varchar(25)  NULL ,
	Serie                varchar(100)  NOT NULL ,
	Subido               Sino ,
	XML                  varchar(max)  NULL ,
	Usuario              integer  NULL ,
	FechaCarga           qFecha  NULL ,
	TipoDeComprobante    char(1)  NULL ,
	CONSTRAINT XPKcomCFDISat PRIMARY KEY  CLUSTERED (UUID ASC)
)
go



CREATE TABLE comCFDISatPago
( 
	UUID                 char(36)  NOT NULL ,
	Renglon              integer  NOT NULL ,
	UUIDR                varchar(36)  NOT NULL ,
	Monto                qMonedaD2 ,
	Moneda               varchar(3)  NOT NULL ,
	CONSTRAINT XPKcomCFDISatPago PRIMARY KEY  CLUSTERED (UUID ASC,Renglon ASC)
)
go



CREATE TABLE comCondFiscal
( 
	comCondFiscal        integer IDENTITY ,
	CondFiscal_Id        varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CodigoFiscal         varchar(3)  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomcondFiscal PRIMARY KEY  CLUSTERED (comCondFiscal ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comCondFiscal ON comCondFiscal
( 
	CondFiscal_Id         ASC
)
go



CREATE TABLE comConPago
( 
	comConPago           integer IDENTITY ,
	CondPago_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Desde                varchar(2)  NOT NULL ,
	Dias                 integer  NOT NULL ,
	CantidadCuotas       integer  NOT NULL ,
	AplicaFactCredito    Sino ,
	AdmiteFactPagoAdel   Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomCondPAgo PRIMARY KEY  CLUSTERED (comConPago ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comConPago ON comConPago
( 
	CondPago_Id           ASC
)
go



CREATE TABLE comDespachos
( 
	comDespachos         integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	Despacho_Id          varchar(20)  NOT NULL ,
	Origen               varchar(35)  NULL ,
	Aduana               varchar(35)  NULL ,
	Fecha                qFecha  NULL ,
	Aduana_Id            char(2)  NULL ,
	Anio                 char(2)  NULL ,
	Patente              char(4)  NULL ,
	Pedimento            numeric(7,0)  NULL ,
	Cambio               qMonedaD4 ,
	FechaModificacion    qFechaHora  NOT NULL ,
	Moneda_Id            integer  NULL ,
	TomaCambioTes        Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKcomDespachos PRIMARY KEY  CLUSTERED (comDespachos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comDespachos ON comDespachos
( 
	Despacho_Id           ASC
)
go



CREATE TABLE comEliminaPendOC
( 
	comOrdenComp         integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Fecha                qFecha ,
	Asiento_Id           bigint  NULL ,
	CONSTRAINT XPKcomEliminaPendOC PRIMARY KEY  CLUSTERED (comOrdenComp ASC)
)
go



CREATE TABLE comEmbarques
( 
	comEmbarques         bigint  NOT NULL ,
	TipoTransporte       char(1)  NOT NULL ,
	NroOrdenExterior     varchar(20)  NOT NULL ,
	FechaEmbarque        qFecha ,
	FechaArribo          qFecha ,
	PesoTotal            QCantidad ,
	Estado_Id            char(1)  NOT NULL ,
	CONSTRAINT XPKcomEmbarque PRIMARY KEY  CLUSTERED (comEmbarques ASC)
)
go



CREATE TABLE comEmbAsiCierre
( 
	comEmbarques         bigint  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	Cambio               qMonedaD8 ,
	CONSTRAINT XPKcomEmbAsiCierre PRIMARY KEY  CLUSTERED (comEmbarques ASC,stkMoviCabe ASC)
)
go



CREATE TABLE comEmbCuerpo
( 
	comEmbarques         bigint  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	CantidadRecibida     qCantidadD8 ,
	CantidadFacturada    qCantidadD8 ,
	PrecioCalculadoOriginal qMonedaD8 ,
	PrecioCalculado      qMonedaD8 ,
	RenglonDebe          integer  NOT NULL ,
	RenglonHaber         integer  NOT NULL ,
	CONSTRAINT XPKcomEmbCuerpo PRIMARY KEY  CLUSTERED (comEmbarques ASC,comOrdenComp ASC,Renglon_OC ASC)
)
go



CREATE TABLE comEmbEstado
( 
	Estado_Id            char(1)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CONSTRAINT XPKcomEmbEstado PRIMARY KEY  CLUSTERED (Estado_Id ASC)
)
go



CREATE TABLE comEmbGastoMovProv
( 
	comMovProv           bigint  NOT NULL ,
	comRenglon           integer  NOT NULL ,
	comEmbarques         bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	CONSTRAINT XPKcomEmbGastoMovProv PRIMARY KEY  CLUSTERED (comMovProv ASC,comRenglon ASC)
)
go



CREATE TABLE comEmbGastos
( 
	comEmbarques         bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Detalle              varchar(50)  NOT NULL ,
	ImporteOriginal      qMonedaD2 ,
	Importe              qMonedaD2 ,
	Moneda_Id            integer  NOT NULL ,
	CantidadImporte      char(1)  NOT NULL ,
	CONSTRAINT XPKcomEmbGastos PRIMARY KEY  CLUSTERED (comEmbarques ASC,Renglon ASC)
)
go



CREATE TABLE comEsquemaAuto
( 
	comEsquemaAuto       integer IDENTITY ( 1,1 ) ,
	EsquemaAuto_Id       varchar(10)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomEsquemaAuto PRIMARY KEY  CLUSTERED (comEsquemaAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comEsquemaAuto ON comEsquemaAuto
( 
	EsquemaAuto_Id        ASC
)
go



CREATE TABLE comEsquemaAutoReng
( 
	EsquemaAuto_Id       integer  NOT NULL ,
	Orden                integer  NOT NULL ,
	NivelAuto_Id         integer  NULL ,
	Formula              QMemo ,
	CONSTRAINT XPKcomEsquemaAutoReng PRIMARY KEY  CLUSTERED (EsquemaAuto_Id ASC,Orden ASC)
)
go



CREATE TABLE comFactuReceOc
( 
	comMovProv           bigint  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	comOcRecepcion       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKcomFactuReceOc PRIMARY KEY  CLUSTERED (comMovProv ASC,comOrdenComp ASC,Renglon_OC ASC,comOcRecepcion ASC,conRenglon ASC)
)
go



CREATE TABLE comFactuReceStk
( 
	comMovProv           bigint  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKcomFactuReceStk PRIMARY KEY  CLUSTERED (comMovProv ASC,comOrdenComp ASC,Renglon_OC ASC,stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE comForEntre
( 
	comForEntre          integer IDENTITY ,
	FormaEnt_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomFormaEntrega PRIMARY KEY  CLUSTERED (comForEntre ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comForEntre ON comForEntre
( 
	FormaEnt_Id           ASC
)
go



CREATE TABLE comImpuestos
( 
	comImpuestos         integer IDENTITY ,
	Impuesto_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          char(35)  NOT NULL ,
	TipoImpuesto         integer  NOT NULL ,
	Formulacalc          varchar(240)  NOT NULL ,
	CtaDebe              integer  NULL ,
	CtaHaber             integer  NULL ,
	CtaReversion         integer  NULL ,
	Porcentaje           numeric(5,2)  NOT NULL ,
	Fecha_Desde          qFecha ,
	Fecha_Hasta          qFecha ,
	Depende_de           char(1)  NOT NULL ,
	VaAlCosto            Sino ,
	PorAcreditacion      Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomImpuestos PRIMARY KEY  CLUSTERED (comImpuestos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comImpuestos ON comImpuestos
( 
	Impuesto_Id           ASC
)
go



CREATE TABLE comLibros
( 
	comLibros            integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NULL ,
	Libro_Id             varchar(10)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CONSTRAINT XPKcomLIbros PRIMARY KEY  CLUSTERED (comLibros ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comLIbros ON comLibros
( 
	Libro_Id              ASC,
	Empresa_Id            ASC
)
go



CREATE TABLE comLibrosColumnas
( 
	comLibros            integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Titulo               varchar(20)  NOT NULL ,
	CONSTRAINT XPKcomLibrosColumnas PRIMARY KEY  CLUSTERED (comLibros ASC,Columna ASC)
)
go



CREATE TABLE comLibrosImpuestos
( 
	comLibros            integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	TipoRenglon          char(2)  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	CONSTRAINT XPKvenLibrosImpustos PRIMARY KEY  CLUSTERED (comLibros ASC,Columna ASC,TipoRenglon ASC,Impuesto_Id ASC)
)
go



CREATE TABLE comListaNegraMX
( 
	RFC                  varchar(13)  NOT NULL ,
	RazonSocial          varchar(500)  NOT NULL ,
	Situacion            varchar(50)  NOT NULL ,
	CONSTRAINT XPKcomListaNegraMX PRIMARY KEY  CLUSTERED (RFC ASC)
)
go



CREATE TABLE comMovDetalle
( 
	comMovProv           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Detalle              varchar(250)  NOT NULL ,
	Importe              qMonedaD2 ,
	Cuenta_Id            integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Base_Id              integer  NULL ,
	CONSTRAINT XPKcomMovDetalle PRIMARY KEY  CLUSTERED (comMovProv ASC,Renglon ASC)
)
go



CREATE TABLE comMovDetalleCont
( 
	comMovProv           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	CONSTRAINT XPKcomMovDetalleCont PRIMARY KEY  CLUSTERED (comMovProv ASC,Renglon ASC,conRenglon ASC)
)
go



CREATE TABLE comMovImpAcredita
( 
	Asiento_Id           bigint  NOT NULL ,
	RenglonDebe          integer  NOT NULL ,
	RenglonHaber         integer  NULL ,
	comMovProv           bigint  NULL ,
	tesMovimientos       bigint  NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	BaseImponible        qMonedaD2 ,
	Monto                qMonedaD2 ,
	TotalPago            qMonedaD2 ,
	Origen               char(1)  NOT NULL ,
	DifCambio            qMonedaD2 ,
	RenDifCambio         integer  NULL ,
	CONSTRAINT XPKcomMovImpAcredita PRIMARY KEY  CLUSTERED (Asiento_Id ASC,RenglonDebe ASC)
)
go



CREATE NONCLUSTERED INDEX IDXcomMovImpAcreditaAsi ON comMovImpAcredita
( 
	RenglonHaber          ASC,
	Asiento_Id            ASC
)
go



CREATE NONCLUSTERED INDEX IDXcomMovImpAcreditaAsidc ON comMovImpAcredita
( 
	Asiento_Id            ASC,
	RenDifCambio          ASC
)
go



CREATE TABLE comMovImpuestos
( 
	comMovProv           bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Porcentaje           numeric(5,2)  NOT NULL ,
	Base_Imponible       qMonedaD2 ,
	Importe_Impuesto     qMonedaD2 ,
	CONSTRAINT XPKcomMovImpuestos PRIMARY KEY  CLUSTERED (comMovProv ASC,conRenglon ASC)
)
go



CREATE TABLE comMovpAnexo
( 
	Asiento_Id           bigint  NOT NULL ,
	ProvAnexo            bigint  NOT NULL ,
	tesRengMovi_Id       bigint  NOT NULL ,
	RenglonRengMovi      integer  NOT NULL ,
	Fecha_Ane            qFecha ,
	FechaFiscal          qFecha ,
	CondFiscal_Id        integer  NULL ,
	Origen_Id            integer  NULL ,
	VieneDeFiscal        Sino ,
	XMLFiscal            varchar(max)  NULL ,
	ClaveFiscal          varchar(36)  NULL ,
	conRenglonProv       integer  NULL ,
	TipoCompFE           integer  NULL ,
	tesMovimientos       bigint  NULL ,
	CONSTRAINT XPKcomMovpAnexo PRIMARY KEY  CLUSTERED (Asiento_Id ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comMovpAnexo ON comMovpAnexo
( 
	tesRengMovi_Id        ASC,
	RenglonRengMovi       ASC
)
go



CREATE TABLE comMovpAnexoCont
( 
	Asiento_Id           bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	CONSTRAINT XPKcomMovpAnexoCont PRIMARY KEY  CLUSTERED (Asiento_Id ASC,conRenglon ASC)
)
go



CREATE TABLE comMovpAnexoDetalle
( 
	Asiento_Id           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Importe              qMonedaD2 ,
	Cuenta_Id            integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Base_Id              integer  NULL ,
	Detalle              varchar(250)  NULL ,
	CONSTRAINT XPKcomMovpAnexoDetalle PRIMARY KEY  CLUSTERED (Asiento_Id ASC,Renglon ASC)
)
go



CREATE TABLE comMovPOC
( 
	comMovProv           bigint  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	Factor               qCantidadD8 ,
	Cambio               qMonedaD8 ,
	CONSTRAINT XPKcomMovPOc PRIMARY KEY  CLUSTERED (comMovProv ASC,comOrdenComp ASC,Renglon_OC ASC)
)
go



CREATE TABLE comMovProv
( 
	comMovProv           bigint  NOT NULL ,
	Proveed_Id           bigint  NULL ,
	TipoMov              char(1)  NULL ,
	TipoCtaProv          integer  NULL ,
	Fecha_CCP            qFecha ,
	Base_Ganancias       qMonedaD2 ,
	Importacion          Sino ,
	ComCondPago_Id       integer  NULL ,
	CondFiscal_Id        integer  NULL ,
	Origen_Id            integer  NULL ,
	FechaFiscal          qFecha  NULL ,
	ClaveFiscal          varchar(36)  NULL ,
	VieneDeFiscal        Sino  NULL ,
	XMLFiscal            text  NOT NULL ,
	Importe              qMonedaD2 ,
	Saldo                qMonedaD2 ,
	TipoCompFE           integer  NULL ,
	FacturaTesoreria     Sino ,
	RenglonDtoFin        integer  NULL ,
	CONSTRAINT XPKcomMovProv PRIMARY KEY  CLUSTERED (comMovProv ASC)
)
go



CREATE TABLE comMovProvAnexoImp
( 
	Asiento_Id           bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	Base_Imponible       qMonedaD2 ,
	Importe_Impuesto     qMonedaD2 ,
	CONSTRAINT XPKcomMovImpAnexop PRIMARY KEY  CLUSTERED (Asiento_Id ASC,conRenglon ASC)
)
go



CREATE TABLE comMovProvDPreFactDir
( 
	comMovProv           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	stkMoviCabe          bigint  NULL ,
	RenglonStk           integer  NULL ,
	CantidadOriginal     qCantidadD8 ,
	Cantidad             qCantidadD8 ,
	Descuento            qPorcentaje ,
	Monto                qMonedaD8 ,
	CONSTRAINT XPKcomMovProvDPre PRIMARY KEY  CLUSTERED (comMovProv ASC,Renglon ASC)
)
go



CREATE TABLE comMovProvDPreOC
( 
	comMovProv           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	comMovProvFactOrig   bigint  NULL ,
	comOrdenComp         integer  NULL ,
	Renglon_OC           integer  NULL ,
	CantidadOriginal     qCantidadD8 ,
	Cantidad             qCantidadD8 ,
	Descuento            qPorcentaje ,
	Monto                qMonedaD8 ,
	CONSTRAINT XPKcomMovProvDPreOC PRIMARY KEY  CLUSTERED (comMovProv ASC,Renglon ASC)
)
go



CREATE TABLE comMovProvEmb
( 
	comMovProv           bigint  NOT NULL ,
	comEmbarques         bigint  NOT NULL ,
	CONSTRAINT XPKcomMovProvEmb PRIMARY KEY  CLUSTERED (comMovProv ASC,comEmbarques ASC)
)
go



CREATE TABLE comMovTipos
( 
	TipoMov              char(1)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Signo                smallint  NOT NULL ,
	CONSTRAINT XPKcomMovTipos PRIMARY KEY  CLUSTERED (TipoMov ASC)
)
go



CREATE TABLE comNivelesAuto
( 
	comNivelesAuto       integer IDENTITY ( 1,1 ) ,
	NivelAuto_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomNivelesAuto PRIMARY KEY  CLUSTERED (comNivelesAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comNivelesAuto ON comNivelesAuto
( 
	NivelAuto_Id          ASC
)
go



CREATE TABLE comNivelesAutoUsu
( 
	NivelAuto_Id         integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKcomNivelesAutoUsu PRIMARY KEY  CLUSTERED (NivelAuto_Id ASC,Usuario_Id ASC)
)
go



CREATE TABLE comOcAntiRecepcion
( 
	comAntiRecepcion     bigint  NOT NULL ,
	comOcRecepcion       bigint  NULL ,
	CONSTRAINT XPKcomOcAntiRecepcion PRIMARY KEY  CLUSTERED (comAntiRecepcion ASC)
)
go



CREATE TABLE comOCArticulo
( 
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Factor               qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	PrecioOriginal       qMonedaD8 ,
	Deposito_Id          integer  NULL ,
	CONSTRAINT XPKcomOCArticulo PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Renglon_OC ASC)
)
go



CREATE TABLE comOCAutorizando
( 
	comOrdenComp         integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	NivelAuto_Id         integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFechaHora  NULL ,
	TipoApro             char(1)  NOT NULL ,
	ResultadoFormula     varchar(max)  NULL ,
	CONSTRAINT XPKcomOCAutorizando PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Secuencia ASC)
)
go



CREATE TABLE comOCCuerpo
( 
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	Cantidad_Recibida    qCantidadD8 ,
	Cantidad_Embarcada   qCantidadD8 ,
	Cantidad_Facturada   qCantidadD8 ,
	Cantidad_Creditos    qCantidadD8 ,
	CantidadConsignada   qCantidadD8 ,
	Fecha_Entrega        qFecha ,
	Precio               qMonedaD8 ,
	Pendiente            Sino ,
	Medida_Id            integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Observaciones        QMemo ,
	CONSTRAINT XPKncomOCcuerpo PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Renglon_OC ASC)
)
go



CREATE TABLE comOcEstados
( 
	Estado_Id            char(1)  NOT NULL ,
	Descripcion          varchar(25)  NOT NULL ,
	CONSTRAINT XPKcomOcEstados PRIMARY KEY  CLUSTERED (Estado_Id ASC)
)
go



CREATE TABLE comOCMemo
( 
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Detalle              varchar(2000)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	CONSTRAINT XPKcomOcMemo PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Renglon_OC ASC)
)
go



CREATE TABLE comOcMovProv
( 
	comOrdenComp         integer  NOT NULL ,
	comMovProv           bigint  NOT NULL ,
	AnticipoNC           Sino  NOT NULL ,
	Importe              qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	DadoRestado          Sino ,
	CONSTRAINT XPKcomOcMovProv PRIMARY KEY  CLUSTERED (comOrdenComp ASC,comMovProv ASC,AnticipoNC ASC)
)
go



CREATE TABLE comOcReceCuerpo
( 
	comOcRecepcion       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	Observaciones        QMemo  NULL ,
	CantFactPendiente    qCantidadD8 ,
	CONSTRAINT XPKcomOcReceCuerpo PRIMARY KEY  CLUSTERED (comOcRecepcion ASC,conRenglon ASC)
)
go



CREATE TABLE comOCRI
( 
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKcomOCRI PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Renglon_OC ASC,comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comOCSegmentos
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	CONSTRAINT XPKgenOCSegmentos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genOCSegmentos ON comOCSegmentos
( 
	Segmento1C            ASC,
	Segmento2C            ASC,
	Segmento3C            ASC,
	Segmento4C            ASC,
	Segmento2N            ASC,
	Segmento3N            ASC,
	Segmento4N            ASC,
	Segmento1N            ASC,
	Empresa_Id            ASC
)
go



CREATE TABLE comOrdenComp
( 
	comOrdenComp         integer IDENTITY ,
	Fecha                qFecha ,
	Proveed_Id           bigint  NULL ,
	TipoPermi_Id         integer  NULL ,
	Moneda_Id            integer  NULL ,
	Autorizo             integer  NULL ,
	CondPago_Id          integer  NULL ,
	Impreso              Sino ,
	Observaciones        QMemo  NULL ,
	Estado_Id            char(1)  NOT NULL ,
	Saldo_Anticipo       qMonedaD2 ,
	ImporteImpuestos     qMonedaD2 ,
	Saldo_NC             qMonedaD2 ,
	Cambio               qMonedaD8 ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomOrdenComp PRIMARY KEY  CLUSTERED (comOrdenComp ASC)
)
go



CREATE TABLE comOrigenesFiscales
( 
	comOrigenesFiscales  integer IDENTITY ,
	Origen_Id            smallint  NOT NULL ,
	Descripcion          varchar(70)  NOT NULL ,
	Dominio_Id           char(2)  NULL ,
	CONSTRAINT XPKcomOrigCred PRIMARY KEY  CLUSTERED (comOrigenesFiscales ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comOrigCred ON comOrigenesFiscales
( 
	Origen_Id             ASC
)
go



CREATE TABLE comPagosAnticipo
( 
	comPagosAnticipo     bigint IDENTITY ( 1,1 ) ,
	Proveed_Id           bigint  NOT NULL ,
	Importe              qMonedaD2 ,
	Moneda_Id            integer  NOT NULL ,
	TipoCtaProv          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	comEmbarques         bigint  NULL ,
	FechaPago            qFecha  NULL ,
	CONSTRAINT XPKcomPagosAnticipo PRIMARY KEY  CLUSTERED (comPagosAnticipo ASC)
)
go



CREATE TABLE comPagosHabilitados
( 
	comMovProv           bigint  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaHabilitacion    qFechaHora ,
	ImporteHabilitado    qMonedaD2 ,
	tesMovimientos       bigint  NULL ,
	Importe1             qMonedaD2 ,
	Importe2             qMonedaD2 ,
	Importe3             qMonedaD2 ,
	CONSTRAINT XPKcomPagosHabilitados PRIMARY KEY  CLUSTERED (comMovProv ASC,Secuencia ASC)
)
go



CREATE TABLE comProvAnexo
( 
	genEntidades         bigint  NOT NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	Direccion1           varchar(35)  NOT NULL ,
	Direccion2           varchar(35)  NOT NULL ,
	Localidad            varchar(35)  NOT NULL ,
	Cod_Postal           varchar(10)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	CondFiscal_Id        integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKcomProvAnexo PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go



CREATE TABLE comProvCtasContrap
( 
	Proveed_Id           bigint  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Detalle              varchar(35)  NOT NULL ,
	CONSTRAINT XPKcomProvCtasCont PRIMARY KEY  CLUSTERED (Proveed_Id ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE comProveedores
( 
	genEntidades         bigint  NOT NULL ,
	Proveed_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	NombreLegal          varchar(120)  NOT NULL ,
	Direccion1           varchar(100)  NOT NULL ,
	Direccion2           varchar(100)  NOT NULL ,
	Localidad            varchar(30)  NOT NULL ,
	CodigoPostal         CodigoPostal  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Pais                 integer  NULL ,
	Telefono             varchar(100)  NOT NULL ,
	Region_Id            integer  NULL ,
	CondPago_Id          integer  NULL ,
	FormaEnt_Id          integer  NULL ,
	Origen_Id            integer  NULL ,
	Contacto             varchar(20)  NOT NULL ,
	EMail                varchar(60)  NOT NULL ,
	Fax                  varchar(30)  NOT NULL ,
	Fecha_Alta           datetime  NOT NULL 
	CONSTRAINT today1
		 DEFAULT  getdate(),
	FechaUltActiv        datetime  NOT NULL ,
	Letra_Fact           char(1)  NOT NULL ,
	Observaciones        QMemo  NULL ,
	CondFiscal_Id        integer  NULL ,
	Ganancias            Sino ,
	IBrutos              varchar(20)  NOT NULL ,
	Especializacion      char(1)  NOT NULL ,
	EsAduana             Sino ,
	TipoCuenta           char(2)  NOT NULL ,
	NroCuenta            varchar(17)  NOT NULL ,
	CBU                  varchar(22)  NOT NULL ,
	Interbanking         qFechaHora  NULL ,
	Banco_Id             integer  NULL ,
	ProvTipo_Id          integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomProveedores PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comProveedores ON comProveedores
( 
	Proveed_Id            ASC
)
go



CREATE TABLE comProveedoresCtasPasivo
( 
	genEntidades         bigint  NOT NULL ,
	TipoCtaProv          integer  NOT NULL ,
	Moneda_Id            integer  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	ctaPagoXAdelantado   integer  NULL ,
	CtaAnticipo          integer  NULL ,
	CONSTRAINT XPKcomProveedoresCtasPasivo PRIMARY KEY  CLUSTERED (genEntidades ASC,TipoCtaProv ASC,Moneda_Id ASC)
)
go



CREATE TABLE comProveedoresImpuestos
( 
	Proveed_Id           bigint  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	CONSTRAINT XPKcomProveedoreImpuestos PRIMARY KEY  CLUSTERED (Proveed_Id ASC,Impuesto_Id ASC)
)
go



CREATE TABLE comProveedoresRetencion
( 
	Proveed_Id           bigint  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Exencion             qPorcentaje ,
	FechaHasta           qFecha  NULL ,
	CONSTRAINT XPKcomProveedoresRetencion PRIMARY KEY  CLUSTERED (Proveed_Id ASC,Cartera_Id ASC)
)
go



CREATE TABLE comProveedoresTipoPasivo
( 
	TipoCtaProv          integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	CONSTRAINT XPKcomProveedoresTipoPasivo PRIMARY KEY  CLUSTERED (TipoCtaProv ASC)
)
go



CREATE TABLE comProvTipos
( 
	comProvTipos         integer IDENTITY ,
	ProvTipo_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomProvTipos PRIMARY KEY  CLUSTERED (comProvTipos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comProvTipos ON comProvTipos
( 
	ProvTipo_Id           ASC
)
go



CREATE TABLE comRegiones
( 
	comRegiones          integer IDENTITY ,
	Region_Id            varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcomRegiones PRIMARY KEY  CLUSTERED (comRegiones ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comRegiones ON comRegiones
( 
	Region_Id             ASC
)
go



CREATE TABLE comRemiPendFact
( 
	comMovProv           bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	stkMoviCabe          bigint  NULL ,
	Renglon              integer  NULL ,
	CantidadFacturado    qCantidadD8 ,
	PrecioFacturado      qCantidadD8 ,
	CantidadOriginalFact qCantidadD8 ,
	CONSTRAINT XPKcomRemiPendFact PRIMARY KEY  CLUSTERED (comMovProv ASC,RenglonCuerpo ASC)
)
go



CREATE TABLE comReqInterno
( 
	comReqInterno        integer IDENTITY ( 1,1 ) ,
	Fecha                qFecha ,
	TipoPermi_Id         integer  NULL ,
	Observaciones        QMemo ,
	Proveed_Id           bigint  NULL ,
	EstadoRI_Id          char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomReqInterno PRIMARY KEY  CLUSTERED (comReqInterno ASC)
)
go



CREATE TABLE comRetProv
( 
	Proveed_Id           bigint  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Exencion             qPorcentaje ,
	Hasta                qFecha ,
	CONSTRAINT XPKcomRetProv PRIMARY KEY  CLUSTERED (Proveed_Id ASC,Cartera_Id ASC)
)
go



CREATE TABLE comRIArticulo
( 
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Factor               qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	PrecioOriginal       qMonedaD4 ,
	Deposito_Id          integer  NULL ,
	CONSTRAINT XPKcomRIArticulo PRIMARY KEY  CLUSTERED (comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comRIAutorizando
( 
	comReqInterno        integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	NivelAuto_Id         integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFechaHora  NULL ,
	TipoApro             char(1)  NOT NULL ,
	ResultadoFormula     QMemo ,
	CONSTRAINT XPKcomRIAutorizando PRIMARY KEY  CLUSTERED (comReqInterno ASC,Secuencia ASC)
)
go



CREATE TABLE comRICuerpo
( 
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	FechaNecesidad       qFecha ,
	Cantidad             qCantidadD8 ,
	Precio               qMonedaD4 ,
	CantidadRecibida     qCantidadD8 ,
	Observaciones        QMemo ,
	Pendiente            Sino ,
	Cuenta_Id            integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Medida_Id            integer  NULL ,
	CONSTRAINT XPKcomRICuerpo PRIMARY KEY  CLUSTERED (comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comRIDesechado
( 
	comReqInterno        integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Fecha                qFechaHora ,
	CONSTRAINT XPKcomRIDesechado PRIMARY KEY  CLUSTERED (comReqInterno ASC)
)
go



CREATE TABLE comRIEstados
( 
	EstadoRI_Id          char(1)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	CONSTRAINT XPKcomRIEstados PRIMARY KEY  CLUSTERED (EstadoRI_Id ASC)
)
go



CREATE TABLE comRIMemo
( 
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	SubCategoria_Id      integer  NULL ,
	Detalle              QMemo ,
	CONSTRAINT XPKcomRIMemo PRIMARY KEY  CLUSTERED (comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comRISegmento
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	comReqInterno        integer  NULL ,
	CONSTRAINT XPKcomRISegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE comSolicitudesSat
( 
	Solicitud            integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NULL ,
	FechaDesde           qFecha ,
	FechaHasta           qFecha ,
	Emitidos             Sino  NULL ,
	Descargados          Sino  NULL ,
	Fecha                qFecha  NULL ,
	UltimaRespuestaSat   varchar(100)  NULL ,
	SolicitudSat         varchar(100)  NULL ,
	MetaDatos            Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomSolicitudesSat PRIMARY KEY  CLUSTERED (Solicitud ASC)
)
go



CREATE TABLE comSubCategorias
( 
	comSubCategorias     integer IDENTITY ( 1,1 ) ,
	SubCategoria_Id      varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Categoria_Id         integer  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	CONSTRAINT XPKcomSubCategorias PRIMARY KEY  CLUSTERED (comSubCategorias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comSubCategorias ON comSubCategorias
( 
	SubCategoria_Id       ASC
)
go



CREATE TABLE comTipoPermi
( 
	comTipoPermi         integer IDENTITY ,
	TipoPermi_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	TipoCuerpo           char(1)  NOT NULL ,
	RequiereAutorizacion Sino ,
	Importaciones        Sino ,
	Reporte_Id           integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	EsquemaAuto_Id       integer  NULL ,
	CONSTRAINT XPKcomTipoPermi PRIMARY KEY  CLUSTERED (comTipoPermi ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comTipoPermi ON comTipoPermi
( 
	TipoPermi_Id          ASC
)
go



CREATE TABLE comTipoPermiRI
( 
	comTipoPermiRI       integer IDENTITY ( 1,1 ) ,
	TipoPermiRI_Id       varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	EsquemaAuto_Id       integer  NULL ,
	TipoCuerpo           char(1)  NOT NULL ,
	Reporte_Id           integer  NULL ,
	TipoRI               char(1)  NOT NULL ,
	UsuarioAutorizado_Id integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	GeneraOC             Sino ,
	CONSTRAINT XPKcomTipoPermiRI PRIMARY KEY  CLUSTERED (comTipoPermiRI ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comTipoPermiRI ON comTipoPermiRI
( 
	TipoPermiRI_Id        ASC
)
go



CREATE TABLE conAnexoGrupoTipos
( 
	GrupoAne_Id          varchar(5)  NOT NULL ,
	Tipo_Id              varchar(5)  NOT NULL ,
	CONSTRAINT XPKconAnexoGrupoTipos PRIMARY KEY  CLUSTERED (GrupoAne_Id ASC,Tipo_Id ASC)
)
go



CREATE TABLE conAnexosGrupos
( 
	GrupoAne_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Orden                smallint  NOT NULL ,
	Origen               smallint  NULL ,
	Description          varchar(60)  NOT NULL ,
	CONSTRAINT XPKconAnexosGrupos PRIMARY KEY  CLUSTERED (GrupoAne_Id ASC)
)
go



CREATE TABLE conAnexosOrigenes
( 
	Origen               smallint  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	TipoRubro            varchar(3)  NOT NULL ,
	CONSTRAINT XPKconAnexosOrigenes PRIMARY KEY  CLUSTERED (Origen ASC)
)
go



CREATE TABLE conAsientos
( 
	conAsientos          bigint IDENTITY ,
	Empresa_Id           integer  NOT NULL ,
	Fecha                qFecha ,
	FechaRegistro        datetime  NOT NULL 
	CONSTRAINT today
		 DEFAULT  getdate(),
	Usuario_Id           integer  NOT NULL ,
	Moneda_Id            integer  NULL ,
	Cambio               qMonedaD8 ,
	CambioMonedaOriginal qMonedaD8 ,
	Formulario_Id        integer  NULL ,
	Especial             varchar(3)  NOT NULL ,
	Sucursal             integer  NULL ,
	Anulado              Sino ,
	Observaciones        QMemo  NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKconAsientos PRIMARY KEY  CLUSTERED (conAsientos ASC)
)
go



CREATE NONCLUSTERED INDEX XIE1conAsientos ON conAsientos
( 
	Empresa_Id            ASC,
	Fecha                 ASC
)
go



CREATE NONCLUSTERED INDEX idxConAsientos1 ON conAsientos
( 
	Empresa_Id            ASC,
	Anulado               ASC,
	Fecha                 ASC
)
INCLUDE( conAsientos,Especial )
go



CREATE NONCLUSTERED INDEX idxAsientosVivos ON conAsientos
( 
	Anulado               ASC,
	Posteado              ASC,
	Fecha                 ASC
)
go



CREATE NONCLUSTERED INDEX idxconAsientosFormu1 ON conAsientos
( 
	Empresa_Id            ASC,
	Formulario_Id         ASC
)
go



CREATE TABLE conAsientosAnul
( 
	Asiento_Id           bigint  NOT NULL ,
	FechaAnulacion       qFecha ,
	Usuario_Id           integer  NOT NULL ,
	TipoEnvio            char(1)  NOT NULL ,
	Causa                varchar(5)  NULL ,
	CONSTRAINT XPKconAsientosAnul PRIMARY KEY  CLUSTERED (Asiento_Id ASC)
)
go



CREATE TABLE conAsientosCon
( 
	conAsientos          bigint  NOT NULL ,
	LeyendaLibroDiario   varchar(100)  NOT NULL ,
	CONSTRAINT XPKconAsientosCon PRIMARY KEY  CLUSTERED (conAsientos ASC)
)
go



CREATE TABLE conAsientosInver
( 
	Asiento_Id           bigint  NOT NULL ,
	Asiento_Id_Inver     bigint  NOT NULL ,
	CONSTRAINT XPKconAsientosInver PRIMARY KEY  CLUSTERED (Asiento_Id ASC,Asiento_Id_Inver ASC)
)
go



CREATE TABLE conAsientosTipo
( 
	AsiTipo_Id           int  NOT NULL ,
	Empresa_Id           integer  NULL ,
	LeyendaLibroDiario   varchar(100)  NOT NULL ,
	Reservada            Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKconAsientosTipo PRIMARY KEY  CLUSTERED (AsiTipo_Id ASC)
)
go



CREATE TABLE conAsieReversion
( 
	Asiento_Id           bigint  NOT NULL ,
	Asiento_Rever        bigint  NOT NULL ,
	CONSTRAINT XPKconAsieReversion PRIMARY KEY  CLUSTERED (Asiento_Id ASC)
)
go



CREATE TABLE conAsieTipoCuerpo
( 
	AsiTipo_Id           int  NOT NULL ,
	Renglon              smallint  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	LeyendaLibroMayor    varchar(100)  NOT NULL ,
	Haber                qMonedaD2 ,
	Debe                 qMonedaD2 ,
	CONSTRAINT XPKconAsieTipoCuer PRIMARY KEY  CLUSTERED (AsiTipo_Id ASC,Renglon ASC)
)
go



CREATE TABLE conBaseCentro
( 
	Base_Id              integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Valor                QCantidad  NOT NULL ,
	CONSTRAINT XPKconBaseCentro PRIMARY KEY  CLUSTERED (Base_Id ASC,Centro1_Id ASC)
)
go



CREATE TABLE conBaseDistri
( 
	conBaseDistri        integer IDENTITY ,
	Base_Id              varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Medida_Id            varchar(3)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKconBaseDistri PRIMARY KEY  CLUSTERED (conBaseDistri ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conBaseDistri ON conBaseDistri
( 
	Base_Id               ASC
)
go



CREATE TABLE conCentro1
( 
	conCentro1           integer IDENTITY ,
	Centro1_Id           varchar(8)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Nivel                smallint  NOT NULL ,
	Imputable            Sino ,
	Notas                QMemo  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKconcentro1 PRIMARY KEY  CLUSTERED (conCentro1 ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conCentro1 ON conCentro1
( 
	Centro1_Id            ASC
)
go



CREATE TABLE conCentro2
( 
	conCentro2           integer IDENTITY ,
	Centro2_Id           varchar(8)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Nivel                smallint  NOT NULL ,
	Imputable            Sino ,
	Notas                QMemo  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKconcentro2 PRIMARY KEY  CLUSTERED (conCentro2 ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conCentro2 ON conCentro2
( 
	Centro2_Id            ASC
)
go



CREATE TABLE conCuadro1Filas
( 
	conCuadro1Filas      integer IDENTITY ,
	Cuadro1Fila_Id       integer  NOT NULL ,
	Descripcion          varchar(40)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKconCuadro1Filas PRIMARY KEY  CLUSTERED (conCuadro1Filas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conCuadro1Filas ON conCuadro1Filas
( 
	Cuadro1Fila_Id        ASC
)
go



CREATE TABLE conCuentas
( 
	conCuentas           integer IDENTITY ,
	Cuenta_Id            varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Tipo_Id              varchar(5)  NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Rubro_Id             char(1)  NULL ,
	Imputable            Sino ,
	Nivel                integer  NOT NULL ,
	Naturaleza           char(1)  NOT NULL ,
	Base_Id              integer  NULL ,
	Grupo_Id             integer  NULL ,
	Cuadro1Fila_Id       integer  NULL ,
	ReservadaPor         varchar(3)  NULL ,
	Fecha_Reserva        qFecha  NULL ,
	SubCuenta_Id         integer  NULL ,
	NoSeReserva          Sino ,
	Rubro_Balance        varchar(15)  NULL ,
	Ajustable            Sino ,
	Notas                QMemo  NULL ,
	Moneda_Id            integer  NULL ,
	Indice_Id            integer  NULL ,
	Metodo               smallint  NOT NULL ,
	EliminaConsolida     Sino ,
	Inactivo             Sino ,
	TipoSAT_Id           varchar(25)  NULL ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	RubroAxi_Id          integer  NULL ,
	Description          varchar(80)  NOT NULL ,
	CONSTRAINT XPKconcuentas PRIMARY KEY  CLUSTERED (conCuentas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conCuentas ON conCuentas
( 
	Cuenta_Id             ASC
)
go



CREATE TABLE conCuentasSinSC
( 
	Cuenta_Id            integer  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	CONSTRAINT XPKconCuentasSinSC PRIMARY KEY  CLUSTERED (Cuenta_Id ASC)
)
go



CREATE TABLE conEjercicio
( 
	Ejercicio            smallint  NOT NULL ,
	Fecha                qFecha ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKconEjercicio PRIMARY KEY  CLUSTERED (Ejercicio ASC)
)
go



CREATE TABLE conGrupoCentro
( 
	Grupo_Id             integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	CONSTRAINT XPKcongrupo_centro PRIMARY KEY  CLUSTERED (Grupo_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE conGruposCont
( 
	conGruposCont        integer IDENTITY ,
	Grupo_Id             varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKcongrupos_cont PRIMARY KEY  CLUSTERED (conGruposCont ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1congrupos_cont ON conGruposCont
( 
	Grupo_Id              ASC
)
go



CREATE TABLE conIndAjusCuerpo
( 
	Indice_Id            integer  NOT NULL ,
	Ejercicio            smallint  NOT NULL ,
	Periodo              smallint  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Indice               qMonedaD4 ,
	CONSTRAINT XPKconIndAjusCuerpo PRIMARY KEY  CLUSTERED (Indice_Id ASC,Ejercicio ASC,Periodo ASC,Empresa_Id ASC)
)
go



CREATE TABLE conIndicesAjustes
( 
	conIndicesAjuste     integer IDENTITY ,
	Indice_Id            varchar(5)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CONSTRAINT XPKconIndicesAjustes PRIMARY KEY  CLUSTERED (conIndicesAjuste ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conIndicesAjustes ON conIndicesAjustes
( 
	Indice_Id             ASC
)
go



CREATE TABLE conInfDefCuentas
( 
	Informe_Id           integer  NOT NULL ,
	Fila                 integer  NOT NULL ,
	CuentaDesde          varchar(25)  NOT NULL ,
	CuentaHasta          varchar(25)  NOT NULL ,
	CONSTRAINT XPKconInfDefCuentas PRIMARY KEY  CLUSTERED (Informe_Id ASC,Fila ASC,CuentaDesde ASC)
)
go



CREATE TABLE conInfDefFilas
( 
	Informe_Id           integer  NOT NULL ,
	Fila                 integer  NOT NULL ,
	Nivel                integer  NOT NULL ,
	Titulo               varchar(100)  NOT NULL ,
	Tipo                 char(2)  NOT NULL ,
	Fuente               char(1)  NOT NULL ,
	InvierteSigno        Sino ,
	Centro1Desde         varchar(8)  NOT NULL ,
	Centro1Hasta         varchar(8)  NOT NULL ,
	Centro2Desde         varchar(8)  NOT NULL ,
	Centro2Hasta         varchar(8)  NOT NULL ,
	CONSTRAINT XPKconInfDefFilas PRIMARY KEY  CLUSTERED (Informe_Id ASC,Fila ASC)
)
go



CREATE TABLE conInfDefinibles
( 
	conInfDefinibles     integer IDENTITY ( 1,1 ) ,
	Informe_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKconInfDefinibles PRIMARY KEY  CLUSTERED (conInfDefinibles ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conInfDefinibles ON conInfDefinibles
( 
	Informe_Id            ASC
)
go



CREATE TABLE conMovCont
( 
	conAsientos          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	LeyendaLibroMayor    varchar(100)  NOT NULL ,
	Importe              qMonedaD2 ,
	ImporteMonedaOriginal qMonedaD2 ,
	TipoMov              numeric(1)  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Clase                varchar(5)  NOT NULL ,
	CONSTRAINT XPKconMovCont PRIMARY KEY  CLUSTERED (conAsientos ASC,Renglon ASC)
)
go



CREATE TABLE conMovContCon
( 
	conAsientos          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	LeyendaLibroMayor    varchar(100)  NOT NULL ,
	Importe              qMonedaD2 ,
	TipoMov              numeric(1)  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	ReferenciaT          QMemo ,
	Referencia1          varchar(100)  NULL ,
	Referencia2          varchar(100)  NULL ,
	Referencia3          varchar(100)  NULL ,
	Referencia4          varchar(100)  NULL ,
	Referencia5          varchar(100)  NULL ,
	Base_Id              integer  NULL ,
	CONSTRAINT XPKconMovContCon PRIMARY KEY  CLUSTERED (conAsientos ASC,Renglon ASC)
)
go



CREATE TABLE conOrigAplicCtas
( 
	GrupoOAF_Id          varchar(5)  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	NetoDebeHaber        char(1)  NOT NULL ,
	CONSTRAINT XPKconOrigAplicCtas PRIMARY KEY  CLUSTERED (GrupoOAF_Id ASC,Cuenta_Id ASC)
)
go



CREATE TABLE conOrigAplicReng
( 
	GrupoOAF_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Destino              integer  NOT NULL ,
	Origen               integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	CONSTRAINT XPKconOrigAplicReng PRIMARY KEY  CLUSTERED (GrupoOAF_Id ASC)
)
go



CREATE TABLE conPeriodos
( 
	Empresa_Id           integer  NOT NULL ,
	Ejercicio            smallint  NOT NULL ,
	Periodo              smallint  NOT NULL ,
	Fecha_Desde          datetime  NOT NULL ,
	Fecha_Hasta          datetime  NOT NULL ,
	Estado               char(1)  NOT NULL ,
	CONSTRAINT XPKconperiodos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Ejercicio ASC,Periodo ASC)
)
go



CREATE TABLE conRubros
( 
	Rubro_Id             char(1)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Tipo                 char(3)  NOT NULL ,
	CONSTRAINT XPKconrubros PRIMARY KEY  CLUSTERED (Rubro_Id ASC)
)
go



CREATE TABLE conRubrosAxi
( 
	conRubrosAxi         integer IDENTITY ( 1,1 ) ,
	RubroAxi_Id          integer  NOT NULL ,
	Descripcion          varchar(120)  NOT NULL ,
	Rubro_Id             char(1)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Posteado             Sino ,
	Inactivo             Sino ,
	CONSTRAINT XPKconRubrosAxi PRIMARY KEY  CLUSTERED (conRubrosAxi ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conRubrosAxi ON conRubrosAxi
( 
	RubroAxi_Id           ASC
)
go



CREATE TABLE conRubrosPrevi
( 
	RubroPrevi_Id        varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	ActivoPasivo         char(1)  NOT NULL ,
	Corriente            Sino ,
	Orden                integer  NOT NULL ,
	CONSTRAINT XPKconRubrosPrevi PRIMARY KEY  CLUSTERED (RubroPrevi_Id ASC)
)
go



CREATE TABLE conRubrosPreviCtas
( 
	RubroPrevi_Id        varchar(5)  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	CONSTRAINT XPKconRubrosPreviCtas PRIMARY KEY  CLUSTERED (RubroPrevi_Id ASC,Cuenta_Id ASC)
)
go



CREATE TABLE conSituPatri
( 
	Rubro_Balance        varchar(15)  NOT NULL ,
	Rubro_Id             char(1)  NOT NULL ,
	Descripcion          char(35)  NOT NULL ,
	Orden                int  NOT NULL ,
	CONSTRAINT XPKconsitupatri PRIMARY KEY  CLUSTERED (Rubro_Balance ASC)
)
go



CREATE TABLE conSubCuentas
( 
	conSubCuentas        integer IDENTITY ,
	SubCuenta_Id         varchar(14)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Base_Id              integer  NULL ,
	Cuadro1Fila_Id       integer  NULL ,
	Ajustable            Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	Description          varchar(50)  NOT NULL ,
	CONSTRAINT XPKconSubCuentas PRIMARY KEY  CLUSTERED (conSubCuentas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conSubCuentas ON conSubCuentas
( 
	SubCuenta_Id          ASC
)
go



CREATE TABLE conTipoEspeciales
( 
	TipoEspe_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CONSTRAINT XPKconTipoEspeciales PRIMARY KEY  CLUSTERED (TipoEspe_Id ASC)
)
go



CREATE TABLE conTipoEspecialesCuerpo
( 
	TipoEspe_Id          varchar(5)  NOT NULL ,
	Tipo_Id              varchar(5)  NOT NULL ,
	CONSTRAINT XPKconTipoEspecialesCuerpo PRIMARY KEY  CLUSTERED (TipoEspe_Id ASC,Tipo_Id ASC)
)
go



CREATE TABLE conTiposContables
( 
	Tipo_Id              varchar(5)  NOT NULL ,
	Descripcion          varchar(45)  NOT NULL ,
	Rubro_Balance        varchar(15)  NOT NULL ,
	Destino              char(10)  NOT NULL ,
	Corriente            char(1)  NOT NULL ,
	Reservado            Sino ,
	Rubro_Id             char(1)  NOT NULL ,
	DescripcionUsu       varchar(45)  NOT NULL ,
	CONSTRAINT XPKcontiposcontabl PRIMARY KEY  CLUSTERED (Tipo_Id ASC)
)
go



CREATE TABLE conTiposSAT
( 
	TipoSAT_Id           varchar(25)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	Rubro                char(3)  NOT NULL ,
	Circulante           Sino ,
	Imputable            Sino ,
	CONSTRAINT XPKconTiposSAT PRIMARY KEY  CLUSTERED (TipoSAT_Id ASC)
)
go



CREATE TABLE disAcciones
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoEvento           varchar(30)  NOT NULL ,
	OrdenAccion          smallint  NOT NULL ,
	Accion               varchar(30)  NOT NULL ,
	ControlDestino_Id    varchar(200)  NULL ,
	Texto                varchar(256)  NULL ,
	ControlTexto_Id      varchar(200)  NULL ,
	ValorCondicion       varchar(30)  NULL ,
	Accion_Id            varchar(100)  NOT NULL ,
	AccionPadre_Id       varchar(100)  NULL ,
	Heredado             Sino  NOT NULL ,
	Habilitado           Sino ,
	EsEspecializacion    Sino ,
	AdicionalInfo        varchar(80)  NULL ,
	CONSTRAINT XPKdisAcciones PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,TipoEvento ASC,OrdenAccion ASC)
)
go



CREATE TABLE disAccionesDescargaEsp
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoEvento           varchar(30)  NOT NULL ,
	Accion               varchar(30)  NOT NULL ,
	ControlDestino_Id    varchar(200)  NULL ,
	Texto                varchar(256)  NOT NULL ,
	CONSTRAINT XPKdisAccionesDescargaEsp PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disAccionesTablasaActualizar
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoEvento           varchar(30)  NOT NULL ,
	OrdenAccion          smallint  NOT NULL ,
	Tabla_Id             varchar(40)  NOT NULL ,
	CONSTRAINT XPKdisAccionesTablasaActualizar PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,TipoEvento ASC,OrdenAccion ASC,Tabla_Id ASC)
)
go



CREATE TABLE disAccionesTablasaEnviar
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoEvento           varchar(30)  NOT NULL ,
	OrdenAccion          smallint  NOT NULL ,
	Tabla_Id             varchar(40)  NOT NULL ,
	CONSTRAINT XPKdisAccionesTablasaEnviar PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,TipoEvento ASC,OrdenAccion ASC,Tabla_Id ASC)
)
go



CREATE TABLE disControles
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	NroControl           integer  NOT NULL ,
	ControlParent_Id     varchar(200)  NULL ,
	TipoControl          varchar(50)  NOT NULL ,
	Alto                 integer  NOT NULL ,
	Ancho                integer  NOT NULL ,
	Arriba               smallint  NOT NULL ,
	Izquierda            smallint  NOT NULL ,
	Texto                varchar(80)  NULL ,
	Visible              Sino ,
	Habilitado           Sino ,
	Alineacion           varchar(7)  NOT NULL ,
	TabStop              Sino ,
	TabOrden             smallint  NOT NULL ,
	Requerido            Sino ,
	Embebido             Sino ,
	Ancla                varchar(8)  NOT NULL ,
	EsCodigoNuevo        Sino ,
	Paises               varchar(60)  NULL ,
	Fila                 integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	FilasExtension       integer  NOT NULL ,
	ColumnasExtension    integer  NOT NULL ,
	MaximaLongitud       integer  NULL ,
	ClickNuevoBlanquea   Sino ,
	ControlaCambios      Sino ,
	SoloLectura          Sino ,
	TextoFijo            Sino ,
	TextoControlVacio    varchar(40)  NULL ,
	Estilo               varchar(200)  NULL ,
	TituloLabel          varchar(50)  NULL ,
	AlineacionLabel      varchar(10)  NULL ,
	IgualaAnchoColumna   Sino ,
	ControlSegmento      varchar(200)  NULL ,
	Heredado             Sino ,
	SegmentoOrigen       smallint  NULL ,
	CONSTRAINT XPKdisControles PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesBoton
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	ControlAsociado_Id   varchar(200)  NULL ,
	AsociadoAFilaGrilla  Sino  NULL ,
	Icono                varchar(40)  NULL ,
	CONSTRAINT XPKdisControlesBoton PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesBotonLupa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	ControlAsociado_Id   varchar(200)  NULL ,
	Icono                varchar(40)  NULL ,
	CamposClave          smallint  NOT NULL ,
	CantMaxRegAMostrar   integer  NOT NULL ,
	OrderBy              varchar(40)  NULL ,
	UsaAccion            Sino ,
	Identidad_Id         integer  NOT NULL ,
	Filtros              varchar(250)  NULL ,
	AdicionalesCampos    varchar(250)  NULL ,
	AdicionalesControles varchar(250)  NULL ,
	AdicionalesParametros varchar(20)  NULL ,
	ReemplazaEnDestino   Sino 
	CONSTRAINT Cero_162501985
		 DEFAULT  0,
	CONSTRAINT XPKdisControlesBotonLupa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesBotonSegmento
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	ControlAsociado_Id   varchar(200)  NULL ,
	Icono                varchar(40)  NULL ,
	Identidad_Id         integer  NULL ,
	Filtros              varchar(250)  NULL ,
	CONSTRAINT XPKdisControlesBotonSegmento PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesCheckBox
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Checked              Sino ,
	CONSTRAINT XPKdisControlesCheckBox PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesColumnaSolapa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Columna              integer  NOT NULL ,
	Ancho                integer  NOT NULL ,
	TipoValor            char(1)  NOT NULL ,
	CONSTRAINT XPKdisControlesColumnaSolapa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,Columna ASC)
)
go



CREATE TABLE disControlesCombo
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	MultiSeleccion       Sino ,
	CheckBoxes           Sino ,
	Identidad            varchar(40)  NULL ,
	Identidad_Id         integer  NULL ,
	EsOptionGroup        Sino ,
	OptionGroupHorizontal Sino ,
	CONSTRAINT XPKdisControlesCombo PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesComboItems
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Valor                varchar(30)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Tipo                 varchar(20)  NOT NULL ,
	Orden                integer  NOT NULL 
	CONSTRAINT Cero_1490204581
		 DEFAULT  0,
	CONSTRAINT XPKdisControlesComboItems PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,Valor ASC)
)
go



CREATE TABLE disControlesFecha
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	ValorMinimo          varchar(30)  NULL ,
	ValorMaximo          varchar(30)  NULL ,
	DiasDiferenciaFecha  integer  NULL ,
	DiasDiferenciaFechaMaxima integer  NULL ,
	DiasDiferenciaFechaMinima integer  NULL ,
	EsFechaHora          Sino 
	CONSTRAINT Cero_601394935
		 DEFAULT  0,
	ValorHora            varchar(5)  NULL ,
	CONSTRAINT XPKdisControlesFecha PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesFilaSolapa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Fila                 integer  NOT NULL ,
	Alto                 integer  NOT NULL ,
	TipoValor            char(1)  NOT NULL ,
	CONSTRAINT XPKdisControlesFilaSolapa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,Fila ASC)
)
go



CREATE TABLE disControlesGrafico
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	SubTitulo            varchar(50)  NULL ,
	Leyenda              varchar(10)  NOT NULL ,
	Tipo                 varchar(30)  NOT NULL ,
	SubTipo              varchar(30)  NOT NULL ,
	PermiteCambiarSubTipo Sino  NULL ,
	TituloEjevalores     varchar(80)  NULL ,
	CONSTRAINT XPKdisControlesGrafico PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesGraficoTorta
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	ValoresASeparar      smallint  NULL ,
	UbicacionTituloPorcion varchar(40)  NULL ,
	FormatoTituloPorcion varchar(10)  NULL ,
	CONSTRAINT XPKdisControlesGraficoTorta PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesGrilla
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	PermiteAgregarFilas  Sino ,
	PermiteBorrarFilas   Sino ,
	PermiteEditarCeldas  Sino ,
	EditaEnGrilla        Sino  NOT NULL ,
	RegistrosxPagina     integer  NOT NULL ,
	AutoFormateable      Sino ,
	EsGrillaAdjuntos     Sino  NULL ,
	EsArbol              Sino ,
	AccionNuevoValorNodo varchar(30)  NOT NULL 
	CONSTRAINT Ninguno_1774153271
		 DEFAULT  'Ninguna',
	ColumnasOcultas      varchar(256)  NULL ,
	FilasAMostrar        integer  NOT NULL 
	CONSTRAINT Cero_125256508
		 DEFAULT  0,
	AnchoMinimo          integer  NOT NULL 
	CONSTRAINT Cero_842412450
		 DEFAULT  0,
	AnchoColumnasFijas   varchar(20)  NULL ,
	NombreColCalculoTotal varchar(30)  NULL ,
	ColFormatoNumericoFila varchar(30)  NULL ,
	TotalizaColumnas     Sino 
	CONSTRAINT Cero_1806837298
		 DEFAULT  0,
	ColumnasFijas        varchar(256)  NULL ,
	ColumnasSoloLectura  varchar(256)  NULL ,
	ColumnasTotalizarCantidad varchar(256)  NULL ,
	ColumnasTotalizarMinimo varchar(256)  NULL ,
	ColumnasTotalizarMaximo varchar(256)  NULL ,
	ColumnasTotalizarPromedio varchar(256)  NULL ,
	ColumnasTotalizarSuma varchar(256)  NULL ,
	AnchoColPorContenido Sino 
	CONSTRAINT Cero_655063181
		 DEFAULT  0,
	ColumnaColorFondoFila varchar(35)  NULL ,
	ColumnaColorTextoFila varchar(35)  NULL ,
	PermiteCambiarOrden  Sino 
	CONSTRAINT Uno_285604317
		 DEFAULT  0,
	PermiteOrdenMultiCols Sino 
	CONSTRAINT Cero_797600133
		 DEFAULT  0,
	CONSTRAINT XPKdisControlesGrilla PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesGrillaColumnas
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	NombreCampo          varchar(40)  NOT NULL ,
	Posicion             integer  NOT NULL ,
	Titulo               varchar(40)  NOT NULL ,
	TipoDato             varchar(20)  NOT NULL ,
	Formato              varchar(30)  NULL ,
	Visible              Sino ,
	ControlColumna_Id    varchar(200)  NULL ,
	Ancho                integer  NOT NULL ,
	AnchoVariable        Sino ,
	Alineacion           varchar(20)  NOT NULL ,
	SoloLectura          Sino ,
	ModoTamanioVariable  varchar(25)  NOT NULL ,
	CongelarTamanio      Sino ,
	AnchoMinimo          integer  NOT NULL ,
	ModoOrdenamiento     varchar(25)  NULL ,
	TextoColumnaVacia    varchar(40)  NULL ,
	Texto                varchar(80)  NULL ,
	EsParamAccionBoton   Sino ,
	Heredado             Sino ,
	Requerido            Sino ,
	AutoNumerico         Sino ,
	EsPrimaryKey         Sino ,
	ItemsCombo           varchar(256)  NULL ,
	Identidad_Id         integer  NULL ,
	TotalizarCantidad    Sino 
	CONSTRAINT Cero_1021248994
		 DEFAULT  0,
	TotalizarMinimo      Sino 
	CONSTRAINT Cero_1969846779
		 DEFAULT  0,
	TotalizarMaximo      Sino 
	CONSTRAINT Cero_2137618931
		 DEFAULT  0,
	TotalizarSuma        Sino 
	CONSTRAINT Cero_477191318
		 DEFAULT  0,
	TotalizarPromedio    Sino 
	CONSTRAINT Cero_1173360358
		 DEFAULT  0,
	ColumnaColorFondoCelda varchar(35)  NULL ,
	ColumnaColorTextoCelda varchar(35)  NULL ,
	CONSTRAINT XPKdisControlesGrillaColumnas PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,NombreCampo ASC)
)
go



CREATE TABLE disControlesGrillaPivot
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	URLServidor          varchar(200)  NOT NULL ,
	Catalogo             varchar(100)  NOT NULL ,
	Cubo                 varchar(100)  NOT NULL ,
	Measures             varchar(200)  NOT NULL ,
	Filas                varchar(200)  NOT NULL ,
	Columnas             varchar(200)  NOT NULL ,
	CONSTRAINT XPKdisControlesGrillaPivot PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesGrupoSolapa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	CantSolapas          integer  NOT NULL ,
	CONSTRAINT XPKdisControlesGrupoSolapa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesIndicador
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Tipo                 varchar(30)  NOT NULL ,
	CONSTRAINT XPKdisControlesIndicador PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesLink
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Link                 varchar(25)  NULL ,
	CONSTRAINT XPKdisControlesLink PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesListaAdjuntos
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	PermiteAgregarArchivo Sino ,
	PermiteBorrarArchivo Sino ,
	MuestraDescripciones Sino ,
	PermiteDescargar     Sino ,
	CantidadMaxima       integer  NULL ,
	ExtensionesPermitidas varchar(40)  NULL ,
	TamanioMaximo        integer  NULL ,
	CONSTRAINT XPKdisControlesListaAdjuntos PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesLupa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	CamposClave          smallint  NOT NULL ,
	CantMaxRegAMostrar   integer  NOT NULL ,
	EsLaEntidadDelForm   Sino ,
	OrderBy              varchar(40)  NULL ,
	TraePrimerRegistro   Sino ,
	UsaAccion            Sino ,
	DescripcionCharCasing varchar(6)  NOT NULL ,
	DescripcionMaxLength smallint  NOT NULL ,
	DescripcionTexto     varchar(256)  NULL ,
	DescripcionOculta    Sino ,
	ColumnaGrillaDescripcion varchar(80)  NULL ,
	Identidad_Id         integer  NOT NULL ,
	Filtros              varchar(250)  NULL ,
	CodigoTipo           varchar(20)  NOT NULL ,
	CodigoCharCasing     varchar(6)  NOT NULL ,
	CodigoMask           varchar(40)  NULL ,
	CodigoRegExpression  varchar(50)  NULL ,
	CodigoMaxLength      smallint  NOT NULL ,
	CodigoTexto          varchar(256)  NULL ,
	CodigoWidth          integer  NOT NULL ,
	CodigoNombreColumna  varchar(40)  NOT NULL ,
	AdicionalesCampos    varchar(250)  NULL ,
	AdicionalesControles varchar(250)  NULL ,
	AdicionalesParametros varchar(250)  NULL ,
	PermiteNoExistentes  Sino ,
	Mascara              varchar(40)  NULL ,
	CONSTRAINT XPKdisControlesLupa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesNumerico
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Decimales            smallint  NOT NULL ,
	BotonSpin            Sino ,
	SpinIncremento       smallint  NOT NULL ,
	ValorMinimo          qCantidadD8  NULL ,
	ValorMaximo          qCantidadD8  NULL ,
	EsPorcentaje         Sino ,
	LLevaSeparadorGrupo  Sino 
	CONSTRAINT Uno_17917575
		 DEFAULT  1,
	CONSTRAINT XPKdisControlesNumerico PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesParametros
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoDato             varchar(25)  NOT NULL ,
	CONSTRAINT XPKdisControlesParametros PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesReferencia
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	FormularioPopup_Id   integer  NULL ,
	TieneBtnCerrar       Sino ,
	TieneBtnGuardar      Sino ,
	TablaPrimaria        varchar(40)  NULL ,
	Parametros           varchar(512)  NULL ,
	TamanioPopup         varchar(20)  NOT NULL ,
	CONSTRAINT XPKdisControlesReferencia PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesRefSolapa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	ControlSolapaRef_Id  varchar(200)  NOT NULL ,
	CONSTRAINT XPKdisControlesRefSolapa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesSegmento
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Segmento_Id          integer  NULL ,
	Identidad_Id         integer  NOT NULL ,
	EsLaEntidadDelForm   Sino ,
	Filtros              varchar(250)  NULL ,
	CONSTRAINT XPKdisControlesSegmento PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesSolapa
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Posicion             integer  NOT NULL ,
	CantFilas            integer  NOT NULL ,
	CantColumnas         integer  NOT NULL ,
	FormularioPopup_Id   integer  NULL ,
	TieneBtnCerrar       Sino ,
	TieneBtnGuardar      Sino ,
	TablaPrimaria        varchar(40)  NULL ,
	Parametros           varchar(512)  NULL ,
	TipoPopup            varchar(20)  NOT NULL ,
	TamanioPopup         varchar(20)  NOT NULL ,
	CONSTRAINT XPKdisControlesSolapa PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesTexto
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	MultiplesLineas      Sino ,
	CharCasing           varchar(6)  NOT NULL ,
	Mascara              varchar(40)  NULL ,
	CONSTRAINT XPKdisControlesTexto PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disControlesUpLoad
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	GuardaCaminoCompleto Sino ,
	ColumnaNombreInterno varchar(40)  NULL ,
	ExtensionesPermitidas varchar(40)  NULL ,
	CONSTRAINT XPKdisControlesUpLoad PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disEventos
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoEvento           varchar(30)  NOT NULL ,
	EsMetodo             Sino ,
	Heredado             Sino ,
	Habilitado           Sino ,
	CONSTRAINT XPKdisEventos PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC,TipoEvento ASC)
)
go



CREATE TABLE disFormularios
( 
	disFormularios       integer IDENTITY ( 1,1 ) ,
	Formulario_Id        varchar(30)  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Alto                 integer  NOT NULL ,
	Ancho                integer  NOT NULL ,
	Arriba               smallint  NOT NULL ,
	Izquierda            smallint  NOT NULL ,
	Titulo               varchar(80)  NOT NULL ,
	PosicionInicial      char(1)  NOT NULL ,
	BotonNuevo           Sino ,
	BotonGuardar         Sino ,
	BotonPostear         Sino ,
	BotonEliminar        Sino ,
	BotonImprimir        Sino ,
	GuardaeImprime       Sino ,
	Tabla_Id             varchar(60)  NOT NULL ,
	DllCommon            varchar(80)  NOT NULL ,
	ClaseCommon          varchar(80)  NOT NULL ,
	DllExchange          varchar(80)  NOT NULL ,
	ClaseExchange        varchar(80)  NOT NULL ,
	ClaseEnum            varchar(80)  NOT NULL ,
	DllEventos           varchar(80)  NOT NULL ,
	ClaseEventos         varchar(80)  NOT NULL ,
	UltimaModif          qFechaHora 
	CONSTRAINT today_373212810
		 DEFAULT  getdate(),
	FormularioPadre_Id   integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	Posteado             Sino ,
	BotonRptVer          Sino ,
	BotonRptImprimir     Sino ,
	BotonRptPdf          Sino ,
	BotonRptXls          Sino ,
	Especializacion      varchar(80)  NULL ,
	DllCommonEsp         varchar(80)  NULL ,
	ClaseCommonEsp       varchar(80)  NULL ,
	DllExchangeEsp       varchar(80)  NULL ,
	ClaseExchangeEsp     varchar(80)  NULL ,
	ClaseEnumEsp         varchar(80)  NULL ,
	DllEventosEsp        varchar(80)  NULL ,
	ClaseEventosEsp      varchar(80)  NULL ,
	Version              varchar(10)  NULL ,
	BotonCopiar          Sino 
	CONSTRAINT Uno_98950057
		 DEFAULT  1,
	TipoEspecial         char(1)  NULL ,
	CodigoLnk            varchar(25)  NULL ,
	AnulaAccionesEliminarDefault Sino 
	CONSTRAINT Cero_1460868602
		 DEFAULT  0,
	CONSTRAINT XPKdisFormularios PRIMARY KEY  CLUSTERED (disFormularios ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1disFormularios ON disFormularios
( 
	Formulario_Id         ASC
)
go



CREATE TABLE disFormulariosComentarios
( 
	Formulario_Id        integer  NOT NULL ,
	FechaRegistro        qFechaHora ,
	FechaRegistroOrig    qFechaHora ,
	FechaUltModif        qFecha ,
	Comentario           QMemo  NOT NULL ,
	FormularioRegOrig_Id varchar(30)  NULL ,
	Comentario_Id        integer  NULL ,
	TipoComentario       char(1)  NULL ,
	CONSTRAINT XPKdisFormulariosComentarios PRIMARY KEY  CLUSTERED (Formulario_Id ASC,FechaRegistro ASC)
)
go



CREATE TABLE disFormulariosParametros
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	TipoDato             varchar(25)  NOT NULL ,
	CONSTRAINT XPKdisFormulariosParametros PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Control_Id ASC)
)
go



CREATE TABLE disRelacionesTablas
( 
	Formulario_Id        integer  NOT NULL ,
	TablaMaster_Id       varchar(40)  NOT NULL ,
	TablaDetalle_Id      varchar(40)  NOT NULL ,
	ColumnaMaster_Id     varchar(100)  NOT NULL ,
	ColumnaMaster2_Id    varchar(100)  NULL ,
	ColumnaMaster3_Id    varchar(100)  NULL ,
	ColumnaDetalle_Id    varchar(100)  NOT NULL ,
	ColumnaDetalle2_Id   varchar(100)  NULL ,
	ColumnaDetalle3_Id   varchar(100)  NULL ,
	CONSTRAINT XPKdisRelacionesTablas PRIMARY KEY  CLUSTERED (Formulario_Id ASC,TablaMaster_Id ASC,TablaDetalle_Id ASC)
)
go



CREATE TABLE disTablas
( 
	Formulario_Id        integer  NOT NULL ,
	Tabla_Id             varchar(40)  NOT NULL ,
	TipoControl          varchar(50)  NULL ,
	Control_Id           varchar(200)  NULL ,
	EsEspecializacion    Sino ,
	CONSTRAINT XPKdisTablas PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Tabla_Id ASC)
)
go



CREATE TABLE disTablasColumnas
( 
	Formulario_Id        integer  NOT NULL ,
	Tabla_Id             varchar(40)  NOT NULL ,
	Columna_Id           varchar(100)  NOT NULL ,
	TipoControl          varchar(50)  NOT NULL ,
	Control_Id           varchar(200)  NULL ,
	AdicionalControl     varchar(10)  NULL ,
	EsEspecializacion    Sino ,
	CONSTRAINT XPKdisTablasColumnas PRIMARY KEY  CLUSTERED (Formulario_Id ASC,Tabla_Id ASC,Columna_Id ASC)
)
go



CREATE TABLE genAdjuntos
( 
	Tabla_Id             varchar(60)  NOT NULL ,
	Identity_Id          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Guid                 varchar(36)  NOT NULL ,
	NombreArchivo        varchar(200)  NOT NULL ,
	Extension            varchar(10)  NOT NULL ,
	CONSTRAINT XPKgenAdjuntos PRIMARY KEY  CLUSTERED (Tabla_Id ASC,Identity_Id ASC,Renglon ASC)
)
go



CREATE TABLE genAlertas
( 
	AlertaId             integer IDENTITY ( 1,1 ) ,
	Usuario_Id           integer  NULL ,
	FechaEmision         qFechaHora ,
	FechaLeido           qFechaHora ,
	Mensaje              varchar(max)  NOT NULL ,
	Liga                 varchar(254)  NOT NULL ,
	CONSTRAINT XPKgenAlertas PRIMARY KEY  CLUSTERED (AlertaId ASC)
)
go



CREATE TABLE genAsiSegmentos
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	Asiento_Id           bigint  NOT NULL ,
	CONSTRAINT XPKgenMovSegmentos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genMovSegmentos ON genAsiSegmentos
( 
	Asiento_Id            ASC,
	Segmento_Id           ASC
)
go



CREATE TABLE genAtributosGenerales
( 
	AtributoNro          integer  NOT NULL ,
	Tabla_Id             varchar(60)  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	EnGrilla             Sino ,
	CONSTRAINT XPKgenAtributosGenerales PRIMARY KEY  CLUSTERED (AtributoNro ASC,Tabla_Id ASC)
)
go



CREATE TABLE genAtributosValores
( 
	Identity_Id          bigint  NOT NULL ,
	AtributoNro          integer  NOT NULL ,
	Tabla_Id             varchar(60)  NOT NULL ,
	ValorN               numeric(28,8)  NULL ,
	ValorC               varchar(255)  NULL ,
	ValorF               datetime  NULL ,
	CONSTRAINT XPKgenAtributosValores PRIMARY KEY  CLUSTERED (Identity_Id ASC,AtributoNro ASC,Tabla_Id ASC)
)
go



CREATE TABLE genAtriGralesClases
( 
	Tabla_Id             varchar(60)  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	CONSTRAINT XPKgenAtriGralesClases PRIMARY KEY  CLUSTERED (Tabla_Id ASC)
)
go



CREATE TABLE genCancMov
( 
	Asiento_Id           bigint  NOT NULL ,
	CuotaNro             smallint  NOT NULL ,
	Asiento_Id_Ap        bigint  NOT NULL ,
	CuotaNro_Ap          smallint  NOT NULL ,
	NroAplicacion        integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	FechaAplicacion      qFecha ,
	Importe              qMonedaD2 ,
	Importe_Ap           qMonedaD2 ,
	AsientoApli_Id       bigint  NULL ,
	Importacion          Sino ,
	AsieDifCambio_Id     bigint  NULL ,
	EsVentaContado       Sino ,
	EsAplicOriginal      Sino ,
	CONSTRAINT XPKgenCancMov PRIMARY KEY  CLUSTERED (Asiento_Id ASC,CuotaNro ASC,Asiento_Id_Ap ASC,CuotaNro_Ap ASC,NroAplicacion ASC)
)
go



CREATE NONCLUSTERED INDEX idxgencanmovApli ON genCancMov
( 
	AsientoApli_Id        ASC,
	AsieDifCambio_Id      ASC
)
go



CREATE NONCLUSTERED INDEX idxgencanmovdc ON genCancMov
( 
	AsieDifCambio_Id      ASC
)
go



CREATE NONCLUSTERED INDEX idxgencanmovAp ON genCancMov
( 
	Asiento_Id_Ap         ASC
)
go



CREATE TABLE genCancMovApliImpor
( 
	conAsientos          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	EsDelAp              Sino ,
	CONSTRAINT XPKgenCancMovApliImpor PRIMARY KEY  CLUSTERED (conAsientos ASC,Renglon ASC)
)
go



CREATE TABLE genClaveComunes
( 
	Clave                varchar(50)  NOT NULL ,
	CONSTRAINT XPKgenClaveComunes PRIMARY KEY  CLUSTERED (Clave ASC)
)
go



CREATE TABLE genClavesComunes
( 
	Clave                varchar(50)  NOT NULL ,
	CONSTRAINT XPKgenClavesComunes PRIMARY KEY  CLUSTERED (Clave ASC)
)
go



CREATE TABLE genColonias
( 
	c_Colonia            varchar(4)  NOT NULL ,
	c_CodigoPostal       varchar(5)  NOT NULL ,
	NombreAsentamiento   varchar(200)  NOT NULL ,
	CONSTRAINT XPKgenColonias PRIMARY KEY  CLUSTERED (c_Colonia ASC,c_CodigoPostal ASC)
)
go



CREATE TABLE genContadorSegmento
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	PrimerNumero         integer  NOT NULL ,
	Cai                  varchar(20)  NULL ,
	FechaCai             qFecha ,
	NumeroDesde          integer  NULL ,
	NumeroHasta          integer  NULL ,
	FechaAutoSRI         qFecha  NULL ,
	FechaDesde           qFecha  NULL ,
	Usuario_Id           integer  NOT NULL ,
	TieneColumnaAutomatica Sino ,
	CONSTRAINT XPKvenMovContadores PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE genControlesSeteos
( 
	Formulario_Id        integer  NOT NULL ,
	Control_Id           varchar(200)  NOT NULL ,
	Orden                integer  NOT NULL ,
	Valor                varchar(80)  NULL ,
	ModificoValor        Sino ,
	Deshabilitar         Sino ,
	Ocultar              Sino ,
	SeteadoPorSistema    Sino ,
	Usuario_Id           integer  NULL ,
	FechaUltModif        qFechaHora ,
	CONSTRAINT XPKgenControlesSeteos PRIMARY KEY  CLUSTERED (Formulario_Id ASC)
)
go



CREATE TABLE genCulturas
( 
	Cultura              varchar(5)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CONSTRAINT XPKgenCulturas PRIMARY KEY  CLUSTERED (Cultura ASC)
)
go



CREATE TABLE genDiasFestivos
( 
	Fecha                datetime  NOT NULL ,
	Descripcion          varchar(30)  NOT NULL 
)
go



CREATE TABLE genDiasLogin
( 
	Lunes                Sino ,
	Martes               Sino ,
	Miercoles            Sino ,
	Jueves               Sino ,
	Viernes              Sino ,
	Sabado               Sino ,
	Domingo              Sino ,
	Festivos             Sino ,
	HoraDesde            char(5)  NOT NULL ,
	HoraHasta            char(5)  NOT NULL ,
	Usuario_Id           integer  NULL 
)
go



CREATE TABLE genDominios
( 
	Dominio_Id           char(2)  NOT NULL ,
	Descripcion          char(100)  NOT NULL ,
	CONSTRAINT XPKgenDominios PRIMARY KEY  CLUSTERED (Dominio_Id ASC)
)
go



CREATE TABLE genEmpresas
( 
	genEmpresas          integer IDENTITY ,
	Empresa_Id           varchar(15)  NOT NULL ,
	Detalle              varchar(100)  NOT NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	Logo                 QMemo ,
	ExtensionArchivo     varchar(20)  NOT NULL ,
	Moneda_Id            integer  NULL ,
	Pais_Id              integer  NULL ,
	Cuit                 qCuit ,
	Calle                varchar(120)  NOT NULL ,
	NoExterior           varchar(20)  NOT NULL ,
	NoInterior           varchar(20)  NOT NULL ,
	Colonia              varchar(80)  NOT NULL ,
	Localidad            varchar(80)  NOT NULL ,
	Municipio            varchar(80)  NOT NULL ,
	Referencia           varchar(20)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	CodigoPostal         CodigoPostal ,
	FechaInicioSumma     qFecha ,
	FechaInicioSociedad  qFecha ,
	FechaCierreCompras   qFecha ,
	FechaCierreVentas    qFecha ,
	FechaCierreStock     qFecha ,
	FechaCalculoStock    qFecha ,
	FechaCierreTesoreria qFecha ,
	FechaCierreImpuestos qFecha  NULL ,
	FechaCierreActivoFijo qFecha ,
	FechaCalculoActivoFijo qFecha ,
	FechaCalculoActivoDiferido qFecha ,
	FechaCierreSueldos   qFecha ,
	NumeroIIBB           varchar(30)  NOT NULL ,
	IGJ                  varchar(20)  NOT NULL ,
	Actividad            varchar(80)  NOT NULL ,
	Regimen              varchar(60)  NOT NULL ,
	Telefono             varchar(120)  NULL ,
	CarpetaEspecial      varchar(200)  NULL ,
	UsaCantidadAlterna   Sino ,
	UsaDespachoImportacion Sino ,
	UsaSerie             Sino ,
	CtaMercaEnTransitoImpor integer  NULL ,
	TipoCosto            char(1)  NOT NULL ,
	TipoCosto2           char(1)  NOT NULL ,
	TipoCosto3           char(1)  NOT NULL ,
	CodLocalidad         varchar(10)  NULL ,
	CodColonia           varchar(10)  NULL ,
	CodMunicipio         varchar(10)  NULL ,
	CondFiscal           varchar(60)  NULL ,
	PaginaWeb            varchar(120)  NULL ,
	SucursalCentral      integer  NULL ,
	CtaMercTransito      integer  NULL ,
	CtaApliImportacion   integer  NULL ,
	Centro1De            varchar(3)  NULL ,
	Centro2De            varchar(3)  NULL ,
	CtaUtiCambioRealizada integer  NULL ,
	CtaPerCambioRealizada integer  NULL ,
	CtaUtiCambioProv     integer  NULL ,
	CtaPerCambioProv     integer  NULL ,
	CtaAjuStockPos       integer  NULL ,
	CtaAjuStockNeg       integer  NULL ,
	Servidor             varchar(100)  NULL ,
	Puerto               integer  NULL ,
	Correo               varchar(200)  NULL ,
	UsuarioCorreo        varchar(100)  NULL ,
	Clave                varchar(100)  NULL ,
	Seguridad            varchar(3)  NULL ,
	EnviaFacturas        Sino  NULL ,
	EnviaRecibo          Sino  NULL ,
	EnviaOC              Sino  NULL ,
	EnviaPedido          Sino ,
	ConfirmarEnviarPedidos Sino ,
	ConfirmarEnviarFacturas Sino ,
	ConfirmarEnviarRecibo Sino ,
	ConfirmarEnviarOC    Sino ,
	MailClientesSinMail  varchar(200)  NULL ,
	CFVenta_Id           integer  NULL ,
	Medida_Id            integer  NULL ,
	CFAjusCtaCte         integer  NULL ,
	TipoDtoFin           char(1)  NULL ,
	MontoDtoFinanciero   qMonedaD2  NULL ,
	CtaDtoFinPos         integer  NULL ,
	CtaDtoFinNeg         integer  NULL ,
	Firma                varchar(max)  NULL ,
	ImagenFirmaB64       varchar(max)  NULL ,
	CuentasDeposito      varchar(max)  NULL ,
	RemisionesAlCosto    Sino ,
	CtaRemisiones        integer  NULL ,
	ServidorRH           varchar(100)  NULL ,
	PuertoRH             integer  NULL ,
	CorreoRH             varchar(200)  NULL ,
	UsuarioCorreoRH      varchar(100)  NULL ,
	ClaveRH              varchar(100)  NULL ,
	SeguridadRH          varchar(3)  NOT NULL ,
	UsaServerRH          Sino 
	CONSTRAINT Cero_1346237126
		 DEFAULT  0,
	Usuario_Id           integer  NULL ,
	Inactivo             Sino ,
	TipoPermisoSCT       varchar(6)  NULL ,
	NroPermisoSCT        varchar(50)  NULL ,
	TrabajaSabado        Sino  NOT NULL ,
	TrabajaDomingo       Sino  NOT NULL ,
	CONSTRAINT XPKgenEmpresas PRIMARY KEY  CLUSTERED (genEmpresas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genEmpresas ON genEmpresas
( 
	Empresa_Id            ASC
)
go



CREATE TABLE genEntidades
( 
	genEntidades         bigint IDENTITY ,
	FechaAlta            qFechaHora ,
	Usuario_Id           integer  NOT NULL ,
	Cuit                 varchar(25)  NOT NULL ,
	TipoDoc              char(1)  NOT NULL ,
	IdFiscal             varchar(20)  NOT NULL ,
	CONSTRAINT XPKgenEntidades PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genEntidades ON genEntidades
( 
	Cuit                  ASC,
	TipoDoc               ASC,
	IdFiscal              ASC
)
go



CREATE TABLE genEntidadesBasicas
( 
	Entidad_Id           integer  NOT NULL ,
	Descripcion          varchar(150)  NOT NULL ,
	CONSTRAINT XPKgenEntidadesBasicas PRIMARY KEY  CLUSTERED (Entidad_Id ASC)
)
go



CREATE TABLE genEntidadesBasicasValor
( 
	Entidad_Id           integer  NOT NULL ,
	Dominio_Id           char(2)  NOT NULL ,
	Clave                varchar(20)  NOT NULL ,
	Descripcion          varchar(1000)  NOT NULL ,
	CONSTRAINT XPKgenEntidadesBasicasValor PRIMARY KEY  CLUSTERED (Entidad_Id ASC,Dominio_Id ASC,Clave ASC)
)
go



CREATE TABLE genFavoritosUsuarios
( 
	Usuario_Id           integer  NOT NULL ,
	OrdenFormularioMenu  varchar(10)  NOT NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKgenFavoritosUsuarios PRIMARY KEY  CLUSTERED (Usuario_Id ASC,OrdenFormularioMenu ASC)
)
go



CREATE TABLE genGlobales
( 
	Empresa_Id           integer  NOT NULL ,
	Nombre_Var           char(25)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	Longitud             smallint  NOT NULL ,
	Decimales            numeric(1,0)  NOT NULL ,
	nValor               numeric(18,4)  NULL ,
	cValor               varchar(200)  NULL ,
	fValor               qFecha  NULL ,
	mValor               varchar(max)  NULL ,
	SubSistema           char(3)  NOT NULL ,
	SoloLectura          Sino ,
	lupIdentidad         varchar(30)  NULL ,
	WhereF10             QMemo  NULL ,
	CONSTRAINT XPKvarglobales PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Nombre_Var ASC)
)
go



CREATE TABLE genGrupos
( 
	Grupo_Id             integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKgenGrupos PRIMARY KEY  CLUSTERED (Grupo_Id ASC,Usuario_Id ASC)
)
go



CREATE TABLE genInstalacion
( 
	Dominio_Id           char(2)  NULL ,
	Licencias            integer  NOT NULL ,
	RptServidor          varchar(200)  NULL ,
	RptCarpeta           varchar(200)  NULL ,
	RptUsuario           varchar(200)  NULL ,
	RptClave             varchar(200)  NULL ,
	RptDominio           varchar(200)  NULL ,
	UsoHorario           integer  NOT NULL ,
	Licencia             varchar(36)  NULL ,
	Clave                varchar(max)  NOT NULL ,
	FechaVencimiento     qFecha  NULL ,
	PorEmpresa           Sino ,
	TamanioHoja          varchar(15)  NULL ,
	LongitudClave        integer  NULL ,
	DiasDuracionClave    integer  NULL ,
	LoginGracia          integer  NULL ,
	CantIntentosFallidos integer  NULL ,
	ClaveSimbolos        Sino  NULL ,
	ClaveNumero          Sino  NULL ,
	ClaveMayuscula       Sino  NULL ,
	ClaveMinuscula       Sino  NULL ,
	ClaveComunes         Sino  NULL ,
	conDigiCta           smallint  NOT NULL ,
	conDigiSubCta        smallint  NOT NULL ,
	contMascaraCuenta    varchar(25)  NOT NULL ,
	TwoFactor            Sino  NULL ,
	EntrarSiFallaCorreo  Sino  NULL ,
	DuracionCookie       integer  NULL 
)
go



CREATE TABLE genJurisCoeficientes
( 
	genEntidades         bigint  NOT NULL ,
	Juris_Id             integer  NOT NULL ,
	Situacion            char(1)  NOT NULL ,
	Coeficiente          qMonedaD4 ,
	Exencion             qPorcentaje ,
	FechaHasta           qFecha  NULL ,
	CONSTRAINT XPKgenJurisCoeficientes PRIMARY KEY  CLUSTERED (genEntidades ASC,Juris_Id ASC)
)
go



CREATE TABLE genLexico
( 
	SetFunciones         varchar(20)  NOT NULL ,
	Funcion              varchar(15)  NOT NULL ,
	Descripcion          varchar(150)  NOT NULL ,
	Token                integer  NOT NULL ,
	TipoDato             char(1)  NOT NULL ,
	CONSTRAINT XPKgenLexico PRIMARY KEY  CLUSTERED (SetFunciones ASC,Funcion ASC)
)
go



CREATE TABLE genLinksAyuda
( 
	CodigoLnk            varchar(25)  NOT NULL ,
	Dominio_Id           varchar(2)  NOT NULL ,
	Descripcion          varchar(150)  NOT NULL ,
	Link                 varchar(500)  NOT NULL ,
	CONSTRAINT XPKgenLinksAyuda PRIMARY KEY  CLUSTERED (CodigoLnk ASC,Dominio_Id ASC)
)
go



CREATE TABLE genlocalidades
( 
	c_Estado             varchar(3)  NOT NULL ,
	c_Localidad          varchar(4)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	CONSTRAINT XPKgenlocalidades PRIMARY KEY  CLUSTERED (c_Estado ASC,c_Localidad ASC)
)
go



CREATE TABLE genLogRequest
( 
	genLogRequest        integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	NombreClase          varchar(254)  NOT NULL ,
	Tipo                 varchar(100)  NOT NULL ,
	Request              QMemo  NOT NULL ,
	RequestEsp           QMemo  NULL ,
	Accion               varchar(254)  NULL ,
	FechaRegistro        qFechaHora ,
	Formulario_Id        varchar(100)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Segmento_Id          integer  NULL ,
	Segmento1C           varchar(20)  NULL ,
	Segmento2C           varchar(20)  NULL ,
	Segmento3C           varchar(20)  NULL ,
	Segmento4C           varchar(20)  NULL ,
	Segmento1N           integer  NULL ,
	Segmento2N           integer  NULL ,
	Segmento3N           integer  NULL ,
	Segmento4N           integer  NULL ,
	CONSTRAINT XPKgenLogRequest PRIMARY KEY  CLUSTERED (genLogRequest ASC)
)
go



CREATE TABLE genMensajes
( 
	Mensaje_Id           integer IDENTITY ( 1,1 ) ,
	Mensaje              varchar(max)  NOT NULL ,
	Leido                qFechaHora  NULL ,
	Usuario_Id           integer  NULL ,
	UsuarioDestino       integer  NULL ,
	FechaEmision         qFechaHora ,
	FechaDesde           datetime  NULL ,
	FechaHasta           qFecha  NULL ,
	Parametros           varchar(max)  NULL ,
	Formulario_Id        integer  NULL ,
	Tipo                 varchar(20)  NULL ,
	SubTipo              varchar(20)  NULL ,
	CONSTRAINT XPKgenMensajes PRIMARY KEY  CLUSTERED (Mensaje_Id ASC)
)
go



CREATE TABLE genMenus
( 
	Orden                varchar(10)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nivel                integer  NOT NULL ,
	Opcion               varchar(100)  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	Formulario_Id        integer  NULL ,
	FrmEspecial          varchar(100)  NULL ,
	Pais                 varchar(100)  NULL ,
	Orientacion          char(1)  NOT NULL ,
	Reporte_Id           integer  NULL ,
	Especial             Sino ,
	genMenus             integer IDENTITY ( 1,1 ) ,
	CONSTRAINT XPKgenMenus PRIMARY KEY  CLUSTERED (Orden ASC)
)
go



CREATE TABLE genMenusOrden
( 
	Opcion               char(1)  NOT NULL ,
	Orden                varchar(10)  NOT NULL ,
	CONSTRAINT XPKgenMenusOrden PRIMARY KEY  CLUSTERED (Opcion ASC)
)
go



CREATE TABLE genMonedas
( 
	genMonedas           integer IDENTITY ,
	Moneda_Id            varchar(3)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(30)  NOT NULL ,
	Simbolo              varchar(5)  NOT NULL ,
	CodigoFiscal         varchar(25)  NULL ,
	CtaFactaRecibir      integer  NULL ,
	CtaFactaRecibirImp   integer  NULL ,
	CantidadDigitos      integer  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKgenMonedas PRIMARY KEY  CLUSTERED (genMonedas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genMonedas ON genMonedas
( 
	Moneda_Id             ASC
)
go



CREATE TABLE genMovCuotas
( 
	Asiento_Id           bigint  NOT NULL ,
	CuotaNro             smallint  NOT NULL ,
	FechaVencimiento     qFecha ,
	Importe              qMonedaD2 ,
	Saldo                qMonedaD2 ,
	CONSTRAINT XPKgenMovCuotas PRIMARY KEY  CLUSTERED (Asiento_Id ASC,CuotaNro ASC)
)
go



CREATE TABLE genMovimientos
( 
	Asiento_Id           bigint  NOT NULL ,
	genEntidades         bigint  NULL ,
	CantCuotas           smallint  NOT NULL ,
	CONSTRAINT XPKgenMovimientos PRIMARY KEY  CLUSTERED (Asiento_Id ASC)
)
go



CREATE TABLE genMunicipios
( 
	c_Estado             varchar(3)  NOT NULL ,
	c_Municipio          varchar(3)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	CONSTRAINT XPKgenMunicipios PRIMARY KEY  CLUSTERED (c_Estado ASC,c_Municipio ASC)
)
go



CREATE TABLE genPaises
( 
	genPaises            integer IDENTITY ,
	Pais_Id              smallint  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CodFiscal            varchar(3)  NULL ,
	Dominio_Id           char(2)  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvarPaises PRIMARY KEY  CLUSTERED (genPaises ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genPaises ON genPaises
( 
	Pais_Id               ASC
)
go



CREATE TABLE genPermisos
( 
	Usuario_Id           integer  NOT NULL ,
	Formulario_Id        integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Consultar            Sino ,
	Actualizar           Sino ,
	Borrar               Sino ,
	Postear              Sino ,
	ModificaCodigos      Sino ,
	CONSTRAINT XPKgenPermisos PRIMARY KEY  CLUSTERED (Usuario_Id ASC,Formulario_Id ASC)
)
go



CREATE TABLE genPermisosEsp
( 
	Permiso_Id           integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	CONSTRAINT XPKgenPermisosEsp PRIMARY KEY  CLUSTERED (Permiso_Id ASC)
)
go



CREATE TABLE genProvincias
( 
	genProvincias        integer IDENTITY ,
	Provincia_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CodFiscal            varchar(3)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvarpcia PRIMARY KEY  CLUSTERED (genProvincias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genProvincias ON genProvincias
( 
	Provincia_Id          ASC
)
go



CREATE TABLE genReportes
( 
	genReportes          integer IDENTITY ( 1,1 ) ,
	Reporte_Id           varchar(50)  NOT NULL ,
	Titulo               varchar(80)  NOT NULL ,
	Rpt                  varchar(200)  NOT NULL ,
	Carpeta              varchar(200)  NULL ,
	Estandar             Sino  NULL ,
	Local                Sino  NULL ,
	StoreProcedure       varchar(200)  NULL ,
	TamanioHoja          varchar(15)  NULL ,
	AnchoHoja            integer  NULL ,
	AltoHoja             integer  NULL ,
	TipoReporte          varchar(10)  NULL ,
	CONSTRAINT XPKgenReportes PRIMARY KEY  CLUSTERED (genReportes ASC)
)
go



CREATE TABLE genReportesSP
( 
	genReportes          integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	StoreProcedure       varchar(150)  NOT NULL ,
	DataTable            varchar(100)  NOT NULL ,
	CONSTRAINT XPKgenReportesSP PRIMARY KEY  CLUSTERED (genReportes ASC,Renglon ASC)
)
go



CREATE TABLE genSegmentoOrigenes
( 
	OriSeg_Id            smallint  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	CONSTRAINT XPKgenSegmentoOrigenes PRIMARY KEY  CLUSTERED (OriSeg_Id ASC)
)
go



CREATE TABLE genSegmentos
( 
	genSegmentos         integer IDENTITY ,
	Segmento_Id          varchar(10)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Digitos1N            integer  NOT NULL ,
	Digitos2N            integer  NOT NULL ,
	Digitos3N            integer  NOT NULL ,
	Digitos4N            integer  NOT NULL ,
	TieneColumnaAutomatica Sino ,
	Digitos1C            integer  NOT NULL ,
	Digitos2C            integer  NOT NULL ,
	Digitos3C            integer  NOT NULL ,
	Digitos4C            integer  NOT NULL ,
	Origen1N             smallint  NOT NULL ,
	Origen2N             smallint  NOT NULL ,
	Origen3N             smallint  NOT NULL ,
	Origen4N             smallint  NOT NULL ,
	Origen1C             smallint  NOT NULL ,
	Origen2C             smallint  NOT NULL ,
	Origen3C             smallint  NOT NULL ,
	Origen4C             smallint  NOT NULL ,
	Orden1N              smallint  NOT NULL ,
	Orden2N              smallint  NOT NULL ,
	Orden3N              smallint  NOT NULL ,
	Orden4N              smallint  NOT NULL ,
	Orden1C              smallint  NOT NULL ,
	Orden2C              smallint  NOT NULL ,
	Orden3C              smallint  NOT NULL ,
	Orden4C              smallint  NOT NULL ,
	HabilitaEdicion      Sino ,
	TamanioVariable      char(2)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	Posteado             Sino ,
	EsSueldos            Sino ,
	EmpiezaEnUno         Sino 
	CONSTRAINT Cero_1746666055
		 DEFAULT  0,
	CONSTRAINT XPKgenSegmentos PRIMARY KEY  CLUSTERED (genSegmentos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genSegmentos ON genSegmentos
( 
	Segmento_Id           ASC
)
go



CREATE TABLE genSegmentosForm
( 
	Segmento_Id          integer  NOT NULL ,
	OrdenFormulario      varchar(10)  NOT NULL ,
	CONSTRAINT XPKgenSegmentosForm PRIMARY KEY  CLUSTERED (Segmento_Id ASC)
)
go



CREATE TABLE genSegmentosNombres
( 
	Segmento_Id          integer  NOT NULL ,
	Nombre1N             varchar(35)  NOT NULL ,
	Nombre2N             varchar(35)  NOT NULL ,
	Nombre3N             varchar(35)  NOT NULL ,
	Nombre4N             varchar(35)  NOT NULL ,
	Nombre1C             varchar(35)  NOT NULL ,
	Nombre2C             varchar(35)  NOT NULL ,
	Nombre3C             varchar(35)  NOT NULL ,
	Nombre4C             varchar(35)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKvenSegmentosNombres PRIMARY KEY  CLUSTERED (Segmento_Id ASC)
)
go



CREATE TABLE genSemaforo
( 
	Semaforo             varchar(50)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	CONSTRAINT XPKgenSemaforo PRIMARY KEY  CLUSTERED (Semaforo ASC,Empresa_Id ASC)
)
go



CREATE TABLE genSucursalesEmpr
( 
	genSucursalesEmpr    integer IDENTITY ,
	Sucursal             Sucursal  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Pais_Id              integer  NULL ,
	DepositoVentas       integer  NULL ,
	DepositoPedidos      integer  NULL ,
	DepositoOC           integer  NULL ,
	FechaCaja            qFecha ,
	VaConCentral         Sino ,
	FacturaElectronica   bit  NOT NULL ,
	UsaWS                bit  NOT NULL ,
	TipoFE               varchar(5)  NULL ,
	Direccion            varchar(120)  NULL ,
	Localidad            varchar(60)  NULL ,
	Telefono             varchar(60)  NULL ,
	CodigoPostal         varchar(20)  NULL ,
	SucursalRemito       integer  NULL ,
	SucursalTesoreria    integer  NULL ,
	Serie                varchar(25)  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	RegPatronal          varchar(20)  NULL ,
	codColonia           varchar(4)  NULL ,
	codLocalidad         varchar(4)  NULL ,
	codMunicipio         varchar(3)  NULL ,
	CONSTRAINT XPKvarSucursalesEm PRIMARY KEY  CLUSTERED (genSucursalesEmpr ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genSucursalesEmpr ON genSucursalesEmpr
( 
	Sucursal              ASC
)
go



CREATE TABLE genTamanioHoja
( 
	TamanioHoja          varchar(2)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	AltoIn               QCantidad ,
	AnchoIn              QCantidad ,
	Altocm               QCantidad ,
	Anchicm              QCantidad ,
	AltoPx               integer  NOT NULL ,
	AnchoPx              integer  NOT NULL ,
	CONSTRAINT XPKgenTamanioHoja PRIMARY KEY  CLUSTERED (TamanioHoja ASC)
)
go



CREATE TABLE genTareaProgParametros
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Parametro            varchar(40)  NOT NULL ,
	Valor                varchar(80)  NULL ,
	CONSTRAINT XPKgenTareaProgParametros PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC,Parametro ASC)
)
go



CREATE TABLE genTareas
( 
	genTareas            integer IDENTITY ( 1,1 ) ,
	Tarea_Id             varchar(80)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	CONSTRAINT XPKgenTareas PRIMARY KEY  CLUSTERED (genTareas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genTareas ON genTareas
( 
	Tarea_Id              ASC
)
go



CREATE TABLE genTareasParametros
( 
	Tarea_Id             integer  NOT NULL ,
	Parametro            varchar(40)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	Obligatorio          Sino ,
	CONSTRAINT XPKgenTareasParametros PRIMARY KEY  CLUSTERED (Tarea_Id ASC,Parametro ASC)
)
go



CREATE TABLE genTareasProgConRepeticion
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Valor                integer  NOT NULL ,
	UnidadMedida         varchar(15)  NOT NULL ,
	CONSTRAINT XPKgenTareasProgConRepeticion PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC)
)
go



CREATE TABLE genTareasProgDiarias
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Valor                integer  NOT NULL ,
	CONSTRAINT XPKgenTareasProgDiarias PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC)
)
go



CREATE TABLE genTareasProgMensuales
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Enero                Sino ,
	Febrero              Sino ,
	Marzo                Sino ,
	Abril                Sino ,
	Mayo                 Sino ,
	Junio                Sino ,
	Julio                Sino ,
	Agosto               Sino ,
	Septiembre           Sino ,
	Octubre              Sino ,
	Noviembre            Sino ,
	Diciembre            Sino ,
	CONSTRAINT XPKgenTareasProgMensuales PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC)
)
go



CREATE TABLE genTareasProgMensualesXDia
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Dia_1                Sino ,
	Dia_2                Sino ,
	Dia_3                Sino ,
	Dia_4                Sino ,
	Dia_5                Sino ,
	Dia_6                Sino ,
	Dia_7                Sino ,
	Dia_8                Sino ,
	Dia_9                Sino ,
	Dia_10               Sino ,
	Dia_11               Sino ,
	Dia_12               Sino ,
	Dia_13               Sino ,
	Dia_14               Sino ,
	Dia_15               Sino ,
	Dia_16               Sino ,
	Dia_17               Sino ,
	Dia_18               Sino ,
	Dia_19               Sino ,
	Dia_20               Sino ,
	Dia_21               Sino ,
	Dia_22               Sino ,
	Dia_23               Sino ,
	Dia_24               Sino ,
	Dia_25               Sino ,
	Dia_26               Sino ,
	Dia_27               Sino ,
	Dia_28               Sino ,
	Dia_29               Sino ,
	Dia_30               Sino ,
	Dia_31               Sino ,
	Ultimo               Sino ,
	CONSTRAINT XPKgenTareasProgMensualesXDia PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC)
)
go



CREATE TABLE genTareasProgMensualesXDiaSemana
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Primero              Sino ,
	Segundo              Sino ,
	Tercero              Sino ,
	Cuarto               Sino ,
	Ultimo               Sino ,
	Lunes                Sino ,
	Martes               Sino ,
	Miercoles            Sino ,
	Jueves               Sino ,
	Viernes              Sino ,
	Sabado               Sino ,
	Domingo              Sino ,
	CONSTRAINT XPKgenTareasProgMensualesXDiaSemana PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC)
)
go



CREATE TABLE genTareasProgramadas
( 
	genTareasProgramadas integer IDENTITY ( 1,1 ) ,
	TareaProgramada_Id   varchar(80)  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	Tarea_Id             integer  NULL ,
	FechaInicio          qFechaHora ,
	HoraInicio           varchar(5)  NOT NULL ,
	FechaFin             qFechaHora ,
	HoraFin              varchar(5)  NOT NULL ,
	TipoEjecucionTarea_Id varchar(2)  NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKgenTareasProgramadas PRIMARY KEY  CLUSTERED (genTareasProgramadas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1genTareasProgramadas ON genTareasProgramadas
( 
	TareaProgramada_Id    ASC
)
go



CREATE TABLE genTareasProgSemanales
( 
	TareaProgramada_Id   integer  NOT NULL ,
	Valor                integer  NOT NULL ,
	Lunes                Sino ,
	Martes               Sino ,
	Miercoles            Sino ,
	Jueves               Sino ,
	Viernes              Sino ,
	Sabado               Sino ,
	Domingo              Sino ,
	CONSTRAINT XPKgenTareasProgSemanales PRIMARY KEY  CLUSTERED (TareaProgramada_Id ASC)
)
go



CREATE TABLE genTipoCambio
( 
	Moneda_Id            integer  NOT NULL ,
	Fecha                qFecha ,
	Empresa_Id           integer  NULL ,
	CambioCompra         qMonedaD8 ,
	CambioVenta          qMonedaD8 ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKgenTipoCambio PRIMARY KEY  CLUSTERED (Moneda_Id ASC,Fecha ASC)
)
go



CREATE TABLE genTiposCompAfip
( 
	Comprobante_Id       integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Segmento1N           integer  NULL ,
	Segmento2N           integer  NULL ,
	Segmento3N           integer  NULL ,
	Segmento4N           integer  NULL ,
	Segmento1C           varchar(20)  NULL ,
	Segmento2C           varchar(20)  NULL ,
	Segmento3C           varchar(20)  NULL ,
	Segmento4C           varchar(20)  NULL ,
	CONSTRAINT XPKvenTiposCompAfip PRIMARY KEY  CLUSTERED (Comprobante_Id ASC)
)
go



CREATE TABLE genTiposDoc
( 
	Dominio_Id           char(2)  NOT NULL ,
	TipoDoc              char(1)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CONSTRAINT XPKgenTiposDoc PRIMARY KEY  CLUSTERED (Dominio_Id ASC,TipoDoc ASC)
)
go



CREATE TABLE genTiposEjecucionTarea
( 
	TipoEjecucionTarea_Id varchar(2)  NOT NULL ,
	Descripcion          varchar(30)  NOT NULL ,
	CONSTRAINT XPKgenTiposEjecucionTarea PRIMARY KEY  CLUSTERED (TipoEjecucionTarea_Id ASC)
)
go



CREATE TABLE genUltPaginasVisitadasUsuarios
( 
	Usuario_Id           integer  NOT NULL ,
	OrdenFormularioMenu  varchar(10)  NOT NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKgenUltPaginasVisitadasUsuarios PRIMARY KEY  CLUSTERED (Usuario_Id ASC,OrdenFormularioMenu ASC)
)
go



CREATE TABLE genUsuarioPermisosEsp
( 
	Usuario_Id           integer  NOT NULL ,
	Permiso_Id           integer  NOT NULL ,
	CONSTRAINT XPKgenUsuarioPermisosEsp PRIMARY KEY  CLUSTERED (Usuario_Id ASC,Permiso_Id ASC)
)
go



CREATE TABLE genUsuarios
( 
	genUsuarios          integer IDENTITY ,
	Usuario_Id           varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Apellido_y_Nombres   varchar(36)  NOT NULL ,
	TipoUsuario          char(1)  NOT NULL ,
	Sucursal             integer  NULL ,
	Clave_de_Acceso      integer  NOT NULL ,
	Cargo                varchar(50)  NOT NULL ,
	UltCambioPass        qFecha ,
	Intentos             smallint  NOT NULL ,
	Email                varchar(150)  NULL ,
	UsuarioCarga         integer  NOT NULL ,
	PtoEmision           char(3)  NULL ,
	CambiarClave         Sino ,
	MalClave             smallint  NOT NULL ,
	EsSupervisor         Sino ,
	Cultura              varchar(5)  NULL ,
	MultiplesLogins      Sino ,
	Cliente_Id           bigint  NULL ,
	Proveed_Id           bigint  NULL ,
	Vendedor_Id          bigint  NULL ,
	Cobrador_Id          bigint  NULL ,
	Legajo               bigint  NULL ,
	RestringeHorarios    Sino ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Firma                varchar(max)  NULL ,
	ImagenFirmaB64       varchar(max)  NULL ,
	CONSTRAINT XPKvarusuarios PRIMARY KEY  CLUSTERED (genUsuarios ASC)
)
go



CREATE UNIQUE INDEX XAK1varUsuarios ON genUsuarios
( 
	Usuario_Id            ASC
)
go



CREATE TABLE genUsuariosLogueados
( 
	Token                varchar(36)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	UltEmpresa           integer  NOT NULL ,
	FechaLogin           qFecha ,
	Caduca               qFecha ,
	CONSTRAINT XPKgenUsuariosLogueados PRIMARY KEY  CLUSTERED (Token ASC)
)
go



CREATE TABLE genUsuariosSucursal
( 
	Usuario_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Sucursal_Id          integer  NOT NULL ,
	CONSTRAINT XPKgenUsuariosSucursal PRIMARY KEY  CLUSTERED (Usuario_Id ASC,Empresa_Id ASC)
)
go



CREATE TABLE genVersion
( 
	Version              numeric(8,2)  NOT NULL ,
	Fecha                qFechaHora ,
	CONSTRAINT XPKgenVersion PRIMARY KEY  CLUSTERED (Version ASC)
)
go




exec sp_bindefault 'FechaHora_Actual', 'genVersion.Fecha'
go



CREATE TABLE genVersionEmpresas
( 
	Version              numeric(18,3)  NOT NULL ,
	Fecha                qFecha ,
	CONSTRAINT XPKgenVersionEmpresa PRIMARY KEY  CLUSTERED (Version ASC)
)
go




exec sp_bindefault 'FechaHora_Actual', 'genVersionEmpresas.Fecha'
go



CREATE TABLE genWSFactElec
( 
	TipoFE               varchar(5)  NOT NULL ,
	Descripcion          varchar(25)  NOT NULL ,
	CONSTRAINT XPKgenWSFactElec PRIMARY KEY  CLUSTERED (TipoFE ASC)
)
go



CREATE TABLE impArbaTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Mes                  smallint  NOT NULL ,
	Regimen              char(1)  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	Alicuota             qPorcentaje ,
	Grupo                smallint  NOT NULL ,
	CONSTRAINT XPKimpArbaTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Mes ASC,Regimen ASC)
)
go



CREATE TABLE impCfdiMetaDatos
( 
	Uuid                 char(36)  NOT NULL ,
	RfcEmisor            varchar(13)  NOT NULL ,
	NombreEmisor         varchar(200)  NOT NULL ,
	RfcReceptor          varchar(13)  NOT NULL ,
	NombreReceptor       varchar(200)  NULL ,
	RfcPac               varchar(13)  NOT NULL ,
	FechaEmision         datetime  NOT NULL ,
	FechaCertificacionSat datetime  NOT NULL ,
	Monto                numeric(18,2)  NOT NULL ,
	EfectoComprobante    char(1)  NOT NULL ,
	Estatus              Sino ,
	FechaCancelacion     datetime  NULL ,
	FechaDescarga        datetime  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Empresa_Id           integer  NULL ,
	CONSTRAINT XPKimpCfdiMetaDatos PRIMARY KEY  CLUSTERED (Uuid ASC)
)
go



CREATE TABLE impFormulas
( 
	impImpuestos         integer  NOT NULL ,
	Renglon              smallint  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Detalle              varchar(80)  NOT NULL ,
	DebeHaberAmbos       char(1)  NOT NULL ,
	CONSTRAINT XPKimpFormulas PRIMARY KEY  CLUSTERED (impImpuestos ASC,Renglon ASC)
)
go



CREATE TABLE impImpuestos
( 
	impImpuestos         integer IDENTITY ( 1,1 ) ,
	Impuesto_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Posteado             Sino ,
	Inactivo             Sino ,
	TipoVencimiento      varchar(3)  NOT NULL ,
	DiaMesVence          smallint  NOT NULL ,
	AvisarNDias          smallint  NOT NULL ,
	ProximoVencimiento   qFecha ,
	CtaHaber_Id          integer  NULL ,
	CtaDebe_Id           integer  NULL ,
	PagoAnticipado       Sino ,
	SePaga               Sino ,
	VaAlCashFlow         Sino ,
	LiquidadoHasta       qFecha ,
	CONSTRAINT XPKimpImpuestos PRIMARY KEY  CLUSTERED (impImpuestos ASC)
)
go



CREATE TABLE impJurisdicciones
( 
	impJurisdicciones    integer IDENTITY ,
	Juris_Id             varchar(3)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(20)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKimpJurisdicciones PRIMARY KEY  NONCLUSTERED (impJurisdicciones ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1impJurisdicciones ON impJurisdicciones
( 
	Juris_Id              ASC
)
go



CREATE TABLE impLibrosTiposRenglon
( 
	TipoRenglon          char(2)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CONSTRAINT XPKimpTiposRenglon PRIMARY KEY  CLUSTERED (TipoRenglon ASC)
)
go



CREATE TABLE impLiquidacion
( 
	conAsientos          bigint  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	FechaDesde           qFecha ,
	FechaHasta           qFecha ,
	FechaPago            qFecha ,
	TotalAPagar          numeric(20,2)  NOT NULL ,
	Saldo                qMonedaD2 ,
	SePaga               Sino ,
	tesMovimientos       bigint  NULL ,
	CONSTRAINT XPKimpLiquidacion PRIMARY KEY  CLUSTERED (conAsientos ASC)
)
go



CREATE TABLE impPadron
( 
	impPadron            integer IDENTITY ( 1,1 ) ,
	Padron_Id            varchar(10)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Tabla                varchar(60)  NOT NULL ,
	Periodo              char(1)  NOT NULL ,
	ColCuit              varchar(20)  NOT NULL ,
	ColAnio              varchar(20)  NOT NULL ,
	ColPeriodo           varchar(20)  NOT NULL ,
	ColBusqueda          varchar(20)  NULL ,
	ColBusquedaValor     varchar(5)  NULL ,
	ColDevolucion        varchar(20)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKimpPadron PRIMARY KEY  CLUSTERED (impPadron ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1impPadron ON impPadron
( 
	Padron_Id             ASC
)
go



CREATE TABLE impRentasCapExentosTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Trimestre            smallint  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	AlicuotaPer          qPorcentaje ,
	AlicuotaRet          qPorcentaje ,
	GrupoPer             smallint  NOT NULL ,
	GrupoRet             smallint  NOT NULL ,
	CONSTRAINT XPKimpRentasCapExentosTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Trimestre ASC)
)
go



CREATE TABLE impRentasCapGralTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Mes                  smallint  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	Tipo                 char(1)  NOT NULL ,
	AlicuotaPer          qPorcentaje ,
	AlicuotaRet          qPorcentaje ,
	GrupoPer             smallint  NOT NULL ,
	GrupoRet             smallint  NOT NULL ,
	CONSTRAINT XPKimpRentasCapGralTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Mes ASC)
)
go



CREATE TABLE impRentasCapMagSupTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Mes                  smallint  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	AlicuotaPer          qPorcentaje ,
	AlicuotaRet          qPorcentaje ,
	GrupoPer             smallint  NOT NULL ,
	GrupoRet             smallint  NOT NULL ,
	CONSTRAINT XPKimpRentasCapMagSupTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Mes ASC)
)
go



CREATE TABLE impRentasCapRiesgoTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Trimestre            smallint  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	AlicuotaPer          qPorcentaje ,
	AlicuotaRet          qPorcentaje ,
	GrupoPer             smallint  NOT NULL ,
	GrupoRet             smallint  NOT NULL ,
	CONSTRAINT XPKimpRentasCapTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Trimestre ASC)
)
go



CREATE TABLE impRetCFDIArrenda
( 
	impRetencionesCFDI   integer  NOT NULL ,
	PagProvEfecPorFiduc  numeric(18,4)  NOT NULL ,
	RendimFideicom       numeric(18,4)  NOT NULL ,
	DeduccCorresp        numeric(18,4)  NOT NULL ,
	MontTotRet           numeric(18,4)  NOT NULL ,
	MontResFiscDistFibras numeric(18,4)  NOT NULL ,
	MontOtrosConceptDistr numeric(18,4)  NOT NULL ,
	DescrMontOtrosConceptDistr varchar(200)  NULL ,
	CONSTRAINT XPKimpRetCFDIArrenda PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIDetalle
( 
	impRetencionesCFDI   integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	BaseRet              numeric(18,4)  NOT NULL ,
	TipoImpuesto         varchar(2)  NOT NULL ,
	montoRet             numeric(18,4)  NOT NULL ,
	TipoPagoRet          varchar(17)  NULL ,
	CONSTRAINT XPKimpRetCFDIDetalle PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC,Renglon ASC)
)
go



CREATE TABLE impRetCFDIDividendos
( 
	impRetencionesCFDI   integer  NOT NULL ,
	CveTipDivOUtil       varchar(2)  NOT NULL ,
	MontISRAcredRetMexico numeric(18,4)  NOT NULL ,
	MontISRAcredRetExtranjero numeric(18,4)  NOT NULL ,
	MontRetExtDivExt     numeric(18,4)  NOT NULL ,
	TipoSocDistrDiv      char(20)  NOT NULL ,
	MontISRAcredNal      numeric(18,4)  NOT NULL ,
	MontDivAcumNal       numeric(18,4)  NOT NULL ,
	MontDivAcumExt       numeric(18,4)  NOT NULL ,
	ProporcionRem        numeric(10,6)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIDividendos PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIEnajAccion
( 
	impRetencionesCFDI   integer  NOT NULL ,
	ContratoIntermediacion varchar(300)  NOT NULL ,
	Ganancia             numeric(18,4)  NOT NULL ,
	Perdida              numeric(18,4)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIEnajAccion PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIFiedeEmpr
( 
	impRetencionesCFDI   integer  NOT NULL ,
	MontTotEntradasPeriodo numeric(18,4)  NOT NULL ,
	PartPropAcumDelFideicom numeric(18,4)  NOT NULL ,
	PropDelMontTot       numeric(10,6)  NOT NULL ,
	Concepto             varchar(100)  NOT NULL ,
	MontTotEgresPeriodo  numeric(18,4)  NOT NULL ,
	PartPropDelFideicom  numeric(18,4)  NOT NULL ,
	PropDelMontTotE      numeric(10,6)  NOT NULL ,
	ConseptoS            varchar(100)  NOT NULL ,
	MontRetRelPagFideic  numeric(18,4)  NOT NULL ,
	DescRetRelPagFideic  varchar(100)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIFiedeEmpr PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIIntereses
( 
	impRetencionesCFDI   integer  NOT NULL ,
	SistFinanciero       char(2)  NOT NULL ,
	RetiroAORESRetInt    char(2)  NOT NULL ,
	OperFinancDerivad    char(2)  NOT NULL ,
	MontIntNominal       numeric(18,4)  NOT NULL ,
	MontIntReal          numeric(18,4)  NOT NULL ,
	Perdida              numeric(18,4)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIIntereses PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIOperConDeriv
( 
	impRetencionesCFDI   integer  NOT NULL ,
	MontGanAcum          numeric(18,4)  NOT NULL ,
	MontPerdDed          numeric(18,4)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIOperConDeriv PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIPagosExtr
( 
	impRetencionesCFDI   integer  NOT NULL ,
	EsBenefEfectDelCobro varchar(2)  NOT NULL ,
	Pais_Id              integer  NULL ,
	ConceptoPago         varchar(1)  NOT NULL ,
	DescripcionConcepto  varchar(max)  NOT NULL ,
	BeneRFC              varchar(14)  NULL ,
	BeneCURP             varchar(18)  NULL ,
	NomDenRazSocB        varchar(300)  NULL ,
	BeneConceptoPago     varchar(1)  NULL ,
	BeneDescripcionConcepto xml  NULL ,
	CONSTRAINT XPKimpRetCFDIPagosExtr PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIPlanesRet
( 
	impRetencionesCFDI   integer  NOT NULL ,
	SistemaFinanc        char(2)  NOT NULL ,
	MontTotAportAnioInmAnterior numeric(18,4)  NOT NULL ,
	MontIntRealesDevengAniooInmAnt numeric(18,4)  NOT NULL ,
	HuboRetirosAnioInmAntPer char(2)  NOT NULL ,
	MontTotRetiradoAnioInmAntPer numeric(18,4)  NOT NULL ,
	MontTotExentRetiradoAnioInmAnt numeric(18,4)  NOT NULL ,
	MontTotExedenteAnioInmAnt numeric(18,4)  NOT NULL ,
	HuboRetirosAnioInmAnt char(2)  NOT NULL ,
	MontTotRetiradoAnioInmAnt numeric(18,4)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIPlanesRet PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIPremios
( 
	impRetencionesCFDI   integer  NOT NULL ,
	Provincia_Id         integer  NULL ,
	MontTotPago          numeric(18,4)  NOT NULL ,
	MontTotPagoGrav      numeric(18,4)  NOT NULL ,
	MontTotPagoExent     numeric(18,4)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDIPremios PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDISecFinan
( 
	impRetencionesCFDI   integer  NOT NULL ,
	IdFideicom           varchar(20)  NOT NULL ,
	NomFideicom          varchar(20)  NOT NULL ,
	DescripFideicom      varchar(20)  NOT NULL ,
	CONSTRAINT XPKimpRetCFDISecFinan PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetencionesCFDI
( 
	impRetencionesCFDI   integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	Folio                integer  NOT NULL ,
	Sello                varchar(max)  NOT NULL ,
	NumCert              varchar(20)  NOT NULL ,
	FechaExp             qFechaHora ,
	CveRetenc            varchar(2)  NOT NULL ,
	DescRetenc           varchar(100)  NOT NULL ,
	Nacionalidad         varchar(10)  NOT NULL ,
	RFC                  varchar(14)  NOT NULL ,
	RazonSocial          varchar(300)  NOT NULL ,
	CURP                 char(18)  NOT NULL ,
	NroRegIdTrib         char(20)  NOT NULL ,
	Ejercicio            integer  NOT NULL ,
	MesIni               smallint  NOT NULL ,
	MesFin               smallint  NOT NULL ,
	montoTotOperacion    numeric(18,3)  NOT NULL ,
	montoTotGrav         numeric(18,4)  NOT NULL ,
	montoTotExent        numeric(18,4)  NOT NULL ,
	montoTotRet          numeric(18,4)  NOT NULL ,
	Cancelado            Sino ,
	FechaCancelacion     qFechaHora  NULL ,
	FechaTimbre          varchar(19)  NULL ,
	SelloSAT             varchar(max)  NOT NULL ,
	NoCertificadoSAT     varchar(20)  NOT NULL ,
	UUID                 char(36)  NOT NULL ,
	RfcProvCertif        varchar(12)  NULL ,
	Leyenda              varchar(150)  NULL ,
	Usuario_Id           integer  NOT NULL ,
	FechaRegistro        qFechaHora ,
	Xml                  text  NULL ,
	CONSTRAINT XPKimpRetencionesCFDI PRIMARY KEY  CLUSTERED (impRetencionesCFDI ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1impRetencionesCFDI ON impRetencionesCFDI
( 
	Folio                 ASC,
	Empresa_Id            ASC
)
go




exec sp_bindefault 'FechaHora_Actual', 'impRetencionesCFDI.FechaExp'
go




exec sp_bindefault 'FechaHora_Actual', 'impRetencionesCFDI.FechaCancelacion'
go




exec sp_bindefault 'FechaHora_Actual', 'impRetencionesCFDI.FechaRegistro'
go



CREATE TABLE impTipoImpuesto
( 
	TipoImpuesto         integer  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	CodigoFiscal         varchar(3)  NULL ,
	Juris_Id             integer  NULL ,
	Referencia01         varchar(15)  NULL ,
	Referencia02         varchar(15)  NULL ,
	Referencia03         varchar(15)  NULL ,
	Referencia04         varchar(15)  NULL ,
	Referencia05         varchar(15)  NULL ,
	Referencia06         varchar(15)  NULL ,
	Referencia07         varchar(15)  NULL ,
	Referencia08         varchar(15)  NULL ,
	Referencia09         varchar(15)  NULL ,
	Referencia10         varchar(15)  NULL ,
	Dominio_Id           char(2)  NULL ,
	CONSTRAINT XPKvenTipoImpuestos PRIMARY KEY  CLUSTERED (TipoImpuesto ASC)
)
go



CREATE TABLE lupIdentidades
( 
	lupIdentidades       integer IDENTITY ( 1,1 ) ,
	Identidad_Id         varchar(30)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CamposSelect         QMemo ,
	FromSelect           QMemo ,
	WhereSelect          QMemo ,
	OrderByDefault       varchar(100)  NOT NULL ,
	CamposClaves         varchar(150)  NOT NULL ,
	CampoDescripcion     varchar(50)  NOT NULL ,
	CampoFKTablaSeg      varchar(50)  NULL ,
	VistaSeg             varchar(50)  NULL ,
	CampoPKVistaSeg      varchar(50)  NULL ,
	OrdenMenuFormulario  varchar(10)  NULL ,
	CharCasing           varchar(6)  NULL ,
	Mascara              varchar(40)  NULL ,
	MaximaLongitud       integer  NULL ,
	CONSTRAINT XPKlupIdentidades PRIMARY KEY  CLUSTERED (lupIdentidades ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1lupIdentidades ON lupIdentidades
( 
	Identidad_Id          ASC
)
go



CREATE TABLE lupIdentidadesColVisibles
( 
	Identidad_Id         integer  NOT NULL ,
	Campo                varchar(50)  NOT NULL ,
	Longitud             integer  NULL ,
	CondicionInicial     varchar(30)  NULL ,
	CONSTRAINT XPKlupIdentidadesColVisibles PRIMARY KEY  CLUSTERED (Identidad_Id ASC,Campo ASC)
)
go



CREATE TABLE lupIdentidadesParam
( 
	Identidad_Id         integer  NOT NULL ,
	Orden                smallint  NOT NULL ,
	NombreParametro      varchar(40)  NOT NULL ,
	TipoParametro        varchar(40)  NOT NULL ,
	CONSTRAINT XPKlupIdentidadesParam PRIMARY KEY  CLUSTERED (Identidad_Id ASC,Orden ASC)
)
go



CREATE TABLE lupUltConfigFiltrosIdentidadUsuario
( 
	Usuario_Id           integer  NOT NULL ,
	Identidad_Id         integer  NOT NULL ,
	Campo                varchar(50)  NOT NULL ,
	Operardor            varchar(15)  NOT NULL ,
	Valor                varchar(50)  NOT NULL ,
	CONSTRAINT XPKlupUltConfigFiltrosIdentidadUsuario PRIMARY KEY  CLUSTERED (Usuario_Id ASC,Identidad_Id ASC,Campo ASC)
)
go



CREATE TABLE proCausas
( 
	proCausas            integer IDENTITY ( 1,1 ) ,
	Causa_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproCausas PRIMARY KEY  CLUSTERED (proCausas ASC)
)
go



CREATE TABLE proCentroProductivo
( 
	proCentroProductivo  integer IDENTITY ( 1,1 ) ,
	CtroProd_Id          varchar(8)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CtaProdProceso       integer  NULL ,
	CONSTRAINT XPKproCentroProductivo PRIMARY KEY  CLUSTERED (proCentroProductivo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proCentroProductivo ON proCentroProductivo
( 
	CtroProd_Id           ASC
)
go



CREATE TABLE proMovCierreOrden
( 
	proMovCierreOrden    bigint  NOT NULL ,
	proOrden             integer  NULL ,
	Cantidad             qCantidadD8 ,
	Parcial              Sino ,
	Causa_Id             integer  NULL ,
	CONSTRAINT XPKproMovCierreOrden PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC)
)
go



CREATE TABLE proMovCierreRecursos
( 
	proMovCierreOrden    bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	SubRecurso_Id        integer  NULL ,
	Cantidad             qCantidadD8 ,
	Costo                qMonedaD4 ,
	CONSTRAINT XPKproMovCierreRecursos PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
)
go



CREATE TABLE proMovCierreTrabajos3
( 
	proMovCierreOrden    bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Trabajo3_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	Moneda_Id            integer  NOT NULL ,
	Proveed_Id           bigint  NOT NULL ,
	Precio               qMonedaD4 ,
	PrecioOriginal       qMonedaD4 ,
	CONSTRAINT XPKproMovCierreTrabajos3 PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
)
go



CREATE TABLE proOrden
( 
	proOrden             integer IDENTITY ( 1,1 ) ,
	Producto_Id          integer  NULL ,
	TamBatch             qCantidadD8 ,
	Receta_Id            integer  NULL ,
	Observaciones        varchar(max)  NOT NULL ,
	Anulado              Sino ,
	Cantidad             qCantidadD8 ,
	CantidadIngresada    qCantidadD8 ,
	FechaEmision         qFecha ,
	CantidadProgramada   qCantidadD8 ,
	FechaNecesidad       qFecha ,
	FechaProduccion      qFecha  NULL ,
	FechaFin             qFecha  NULL ,
	CantidadTerminada    qCantidadD8 ,
	CierreAutomatico     Sino  NOT NULL 
	CONSTRAINT Cero_991707419
		 DEFAULT  0,
	Medida_Id            integer  NULL ,
	Factor               qMonedaD8 ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKproOrden PRIMARY KEY  CLUSTERED (proOrden ASC)
)
go



CREATE TABLE proOrdenProd
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	EntradaSalida        char(1)  NOT NULL ,
	Medida_Id            integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	PorcentajeCosto      qPorcentaje ,
	Deposito_Id          integer  NULL ,
	TomaDepoT3           Sino ,
	CONSTRAINT XPKporOrdenProd PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go



CREATE TABLE proOrdenProdSerie
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproOrdenProdSerie PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC,Serie ASC)
)
go



CREATE TABLE proOrdenRecursos
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKporOrdenRecursos PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go



CREATE TABLE proOrdenSegmento
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	proOrden             integer  NULL ,
	CONSTRAINT XPKporOrdenSegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE proOrdenStock
( 
	proMovCierreOrden    bigint  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	CONSTRAINT XPKproCierreOrden PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,stkMoviCabe ASC)
)
go



CREATE TABLE proOrdenStockCosto
( 
	proMovCierreOrden    bigint  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	PorcentajeCosto      qPorcentaje ,
	CONSTRAINT XPKproOrdenStockCosto PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE proOrdenSubRecurso
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	SubRecurso_Id        integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproOrdenSubRecurso PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC,SubRecurso_Id ASC)
)
go



CREATE TABLE proOrdenTrabajos3
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	proTrabajo3          integer  NOT NULL ,
	Proveed_Id           bigint  NULL ,
	CONSTRAINT XPKporOrdenTrabajos3 PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go



CREATE TABLE proProductosReceta
( 
	Producto_Id          integer  NOT NULL ,
	Receta_Id            integer  NOT NULL ,
	Principal            Sino ,
	CONSTRAINT XPKproProductosReceta PRIMARY KEY  CLUSTERED (Producto_Id ASC,Receta_Id ASC)
)
go



CREATE TABLE proProgramaOrden
( 
	proProgramas         integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	proOrden             integer  NOT NULL ,
	CONSTRAINT XPKproProgramaOrden PRIMARY KEY  CLUSTERED (proProgramas ASC,Renglon ASC,proOrden ASC)
)
go



CREATE TABLE proProgramas
( 
	proProgramas         integer IDENTITY ( 1,1 ) ,
	Descripcion          varchar(80)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Fecha                qFecha ,
	FechaDesde           qFecha ,
	FechaHasta           qFecha ,
	Deposito_Id          integer  NULL ,
	ProductoDesde        varchar(25)  NOT NULL ,
	ProductoHasta        varchar(20)  NOT NULL ,
	Lunes                Sino ,
	Martes               Sino ,
	Miercoles            Sino ,
	Jueves               Sino ,
	Viernes              Sino ,
	Sabado               Sino ,
	Domingo              Sino ,
	GrupoDesde           varchar(15)  NOT NULL ,
	GrupoHasta           varchar(20)  NOT NULL ,
	FamiliaDesde         varchar(15)  NOT NULL ,
	FamiliaHasta         varchar(15)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproPrograma PRIMARY KEY  CLUSTERED (proProgramas ASC)
)
go



CREATE TABLE proProgramasCuerpo
( 
	proProgramas         integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Cantidad             qCantidadD8 ,
	Observaciones        varchar(20)  NULL ,
	FechaNecesidad       qFecha ,
	Confirmado           Sino ,
	Receta_Id            integer  NOT NULL ,
	CONSTRAINT XPKproProgramasCuerpo PRIMARY KEY  CLUSTERED (proProgramas ASC,Renglon ASC)
)
go



CREATE TABLE proProgramasSegmento
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	proProgramas         integer  NULL ,
	CONSTRAINT XPKproProgramasSegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE proRecetas
( 
	proRecetas           integer IDENTITY ( 1,1 ) ,
	Receta_Id            varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	CtroProd_Id          integer  NULL ,
	TamBatch             qCantidadD8 ,
	Agrupa               Sino ,
	Corte                Sino ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	FechaModificacion    qFechaHora ,
	CONSTRAINT XPKproRecetas PRIMARY KEY  CLUSTERED (proRecetas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecetas ON proRecetas
( 
	Receta_Id             ASC
)
go



CREATE TABLE proRecetasProd
( 
	Receta_Id            integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	EntradaSalida        char(1)  NOT NULL ,
	Medida_Id            integer  NULL ,
	Formula              varchar(max)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	PorcentajeCosto      qPorcentaje ,
	Deposito_Id          integer  NULL ,
	Observaciones        varchar(max)  NULL ,
	TomaDepoT3           Sino ,
	CONSTRAINT XPKproRecetasProd PRIMARY KEY  CLUSTERED (Receta_Id ASC,Renglon ASC)
)
go



CREATE TABLE proRecetasRecursos
( 
	proRecetas           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproRecetasRecursos PRIMARY KEY  CLUSTERED (proRecetas ASC,Renglon ASC)
)
go



CREATE TABLE proRecetasTrabajo3
( 
	Receta_Id            integer  NOT NULL ,
	Trabajo3_Id          integer  NOT NULL ,
	CONSTRAINT XPKproRecetasTrabajo3 PRIMARY KEY  CLUSTERED (Receta_Id ASC,Trabajo3_Id ASC)
)
go



CREATE TABLE proRecursos
( 
	proRecursos          integer IDENTITY ( 1,1 ) ,
	Recurso_Id           varchar(25)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Unidad_Id            integer  NULL ,
	Capacidad            qCantidadD8 ,
	Costo                qMonedaD4 ,
	UsaSubRecurso        Sino ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	Cuenta_Id            integer  NULL ,
	CONSTRAINT XPKproRecursos PRIMARY KEY  CLUSTERED (proRecursos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecursos ON proRecursos
( 
	Recurso_Id            ASC
)
go



CREATE TABLE proSubRecursos
( 
	proSubRecursos       integer IDENTITY ( 1,1 ) ,
	SubRecurso_Id        varchar(25)  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Capacidad            qCantidadD8 ,
	Costo                qMonedaD4 ,
	Predeterminado       Sino ,
	Inactivo             Sino ,
	CONSTRAINT XPKproRecursosRecurso PRIMARY KEY  CLUSTERED (proSubRecursos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecursosRecurso ON proSubRecursos
( 
	SubRecurso_Id         ASC
)
go



CREATE TABLE proTrabajo3
( 
	proTrabajo3          integer IDENTITY ( 1,1 ) ,
	Trabajo3_Id          varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproTrabajo3 PRIMARY KEY  CLUSTERED (proTrabajo3 ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proTrabajo3 ON proTrabajo3
( 
	Trabajo3_Id           ASC
)
go



CREATE TABLE proTrabajo3Prov
( 
	Trabajo3_Id          integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Proveedor_Id         bigint  NULL ,
	Moneda_Id            integer  NULL ,
	Precio               qMonedaD4 ,
	Medida_Id            integer  NULL ,
	Cantidad             qCantidadD8 ,
	Predeterminado       Sino ,
	Deposito_Id          integer  NULL ,
	CONSTRAINT XPKproTrabajo3Prov PRIMARY KEY  CLUSTERED (Trabajo3_Id ASC,Renglon ASC)
)
go



CREATE TABLE provarGlobales
( 
	Variable_Id          smallint  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Valor                qCantidadD8 ,
	CONSTRAINT XPKprovarGlobales PRIMARY KEY  CLUSTERED (Variable_Id ASC)
)
go



CREATE TABLE sisAccionesConfig
( 
	Accion_Id            varchar(200)  NOT NULL ,
	Descripcion          varchar(254)  NOT NULL ,
	Controlador          varchar(254)  NOT NULL ,
	ModoTransaccion      integer  NOT NULL ,
	CONSTRAINT XPKsisAccionesConfig PRIMARY KEY  CLUSTERED (Accion_Id ASC)
)
go



CREATE TABLE stkArtiUM
( 
	Producto_Id          integer  NOT NULL ,
	Medida_Id            integer  NOT NULL ,
	Factor               qCantidadD8 ,
	CodigoBarra          varchar(25)  NULL ,
	CONSTRAINT XPKstkArtiUM PRIMARY KEY  CLUSTERED (Producto_Id ASC,Medida_Id ASC)
)
go



CREATE TABLE stkCausasMovi
( 
	stkCausasMovi        integer IDENTITY ,
	Causa_Id             varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	EntSalAmb            char(1)  NOT NULL ,
	UsuarioAutorizado    integer  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKstkCausas PRIMARY KEY  CLUSTERED (stkCausasMovi ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkCausasMovi ON stkCausasMovi
( 
	Causa_Id              ASC
)
go



CREATE TABLE stkCFComImp
( 
	CFComp_Id            integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	CONSTRAINT XPKstkCFComImp PRIMARY KEY  CLUSTERED (CFComp_Id ASC,Impuesto_Id ASC)
)
go



CREATE TABLE stkCFVenImp
( 
	CFVenta_Id           integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	CONSTRAINT XPKstkCFVenImp PRIMARY KEY  CLUSTERED (CFVenta_Id ASC,Impuesto_Id ASC)
)
go



CREATE TABLE stkCondFisCompra
( 
	stkCondFisCompra     integer IDENTITY ,
	CFComp_Id            varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKstkCondFisCompra PRIMARY KEY  CLUSTERED (stkCondFisCompra ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkCondFisCompra ON stkCondFisCompra
( 
	CFComp_Id             ASC
)
go



CREATE TABLE stkCondFisVenta
( 
	stkCondFisVenta      integer IDENTITY ,
	CFVenta_Id           varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKstkCondFisVenta PRIMARY KEY  CLUSTERED (stkCondFisVenta ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkCondFisVenta ON stkCondFisVenta
( 
	CFVenta_Id            ASC
)
go



CREATE TABLE stkCOTAr
( 
	stkHojaDeRuta        integer  NOT NULL ,
	Provincia_Id         integer  NOT NULL ,
	Peso                 qCantidadD8 ,
	Importe              qMonedaD2 ,
	COT                  varchar(max)  NOT NULL ,
	CONSTRAINT XPKstkCOTAr PRIMARY KEY  CLUSTERED (stkHojaDeRuta ASC,Provincia_Id ASC)
)
go



CREATE TABLE stkDepoPorIdent
( 
	tesMovimientos       bigint  NOT NULL ,
	venMovimientos       bigint  NULL ,
	CONSTRAINT XPKstkDepoPorIdent PRIMARY KEY  CLUSTERED (tesMovimientos ASC)
)
go



CREATE TABLE stkDepoPorIdentImp
( 
	tesMovimientos       bigint  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	BaseImponible        numeric(18,2)  NOT NULL ,
	Importe              numeric(18,2)  NOT NULL ,
	CONSTRAINT XPKstkDepoPorIdentImp PRIMARY KEY  CLUSTERED (tesMovimientos ASC,Impuesto_Id ASC)
)
go



CREATE TABLE stkDepositos
( 
	stkDepositos         integer IDENTITY ,
	Deposito_Id          varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Sucursal             integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Direccion            varchar(35)  NOT NULL ,
	GrupoUsuarios        integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	AdmiteVentas         Sino ,
	Consignacion         Sino ,
	CuentaDeudCons       integer  NULL ,
	CuentaAcredCons      integer  NULL ,
	CtaBienesCambio      integer  NULL ,
	CtaMercEnCons        integer  NULL ,
	DepositoReal         integer  NULL ,
	consCompra_Venta     Sino ,
	Localidad            varchar(35)  NULL ,
	CodigoPostal         CodigoPostal  NULL ,
	Provincia_Id         integer  NULL ,
	Proveed_Id           bigint  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	UsaUbicacion         Sino ,
	c_ColoniaEntr        varchar(4)  NULL ,
	c_LocalidadEntr      varchar(4)  NULL ,
	c_MunicipioEntr      varchar(3)  NULL ,
	CONSTRAINT XPKE_22 PRIMARY KEY  CLUSTERED (stkDepositos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkDepositos ON stkDepositos
( 
	Deposito_Id           ASC
)
go



CREATE TABLE stkDevolucionesClie
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	venMovimientosFact   bigint  NULL ,
	venMovimientosNC     bigint  NULL ,
	RenglonCuerpo        integer  NULL ,
	RenglonNC            integer  NULL ,
	CONSTRAINT XPKstkDevolucionesClie PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE stkEliminaRemiPend
( 
	stkMoviCabe          bigint  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFecha ,
	CONSTRAINT XPKstkEliminaRemiPend PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkEntradasCancRemi
( 
	stkMoviCabeEntrada   bigint  NOT NULL ,
	RenglonEntrada       integer  NOT NULL ,
	stkMoviCabeRemi      bigint  NULL ,
	RenglonRemi          integer  NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkEntradasCancRemi PRIMARY KEY  CLUSTERED (stkMoviCabeEntrada ASC,RenglonEntrada ASC)
)
go



CREATE TABLE stkEnTransito
( 
	stkMoviCabe          bigint  NOT NULL ,
	stkMoviCabeEntr      bigint  NULL ,
	Deposito_Id          integer  NOT NULL ,
	CONSTRAINT XPKstkEnTransito PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE NONCLUSTERED INDEX idxStkEntransitoEntrada ON stkEnTransito
( 
	stkMoviCabeEntr       ASC
)
go



CREATE TABLE stkExistencia
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadReservada    qCantidadD8 ,
	CantidadAlterna      qCantidadD8 ,
	CONSTRAINT XPKstkExistencia PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC)
)
go



CREATE TABLE stkExistenciaDespa
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Despacho_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkExistenciaDespa PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC,Despacho_Id ASC)
)
go



CREATE TABLE stkExistenciaSerie
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qMonedaD8 ,
	CONSTRAINT XPKstkExistenciaSerie PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC,Serie ASC)
)
go



CREATE TABLE stkExistenciaUbi
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadReservada    qCantidadD8 ,
	CantidadAlterna      qCantidadD8 ,
	CONSTRAINT XPKstkExistenciaUbi PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE stkExistenciaUbiSerie
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qMonedaD8 ,
	CONSTRAINT XPKstkExistenciaUbiSerie PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC,Serie ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE stkFamilias
( 
	stkFamilias          integer IDENTITY ( 1,1 ) ,
	Familia_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKstkFamilias PRIMARY KEY  CLUSTERED (stkFamilias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkFamilias ON stkFamilias
( 
	Familia_Id            ASC
)
go



CREATE TABLE stkGrupos
( 
	stkGrupos            integer IDENTITY ( 1,1 ) ,
	Grupo_Id             varchar(15)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKstkGrupos PRIMARY KEY  CLUSTERED (stkGrupos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkGrupos ON stkGrupos
( 
	Grupo_Id              ASC
)
go



CREATE TABLE stkHojaDeRuta
( 
	stkHojaDeRuta        integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	FechaRegistro        qFechaHora ,
	Patente_Id           integer  NULL ,
	PatenteAcoplado      integer  NULL ,
	venReparto           integer  NULL ,
	FormaEntrega_Id      integer  NULL ,
	Estado               char(1)  NOT NULL ,
	Chofer               varchar(100)  NULL ,
	CONSTRAINT XPKstkHojaDeRuta PRIMARY KEY  CLUSTERED (stkHojaDeRuta ASC)
)
go




exec sp_bindefault 'FechaHora_Actual', 'stkHojaDeRuta.FechaRegistro'
go



CREATE TABLE stkHojaDeRutaCuerpo
( 
	stkHojaDeRuta        integer  NOT NULL ,
	conAsientos          bigint  NOT NULL ,
	CONSTRAINT XPKstkHoraDeRutaCuerpo PRIMARY KEY  CLUSTERED (stkHojaDeRuta ASC,conAsientos ASC)
)
go



CREATE TABLE stkHojaSegmentos
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	stkHojaDeRuta        integer  NULL ,
	CONSTRAINT XPKstkHojaSegmentos PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkHojaSegmentos ON stkHojaSegmentos
( 
	stkHojaDeRuta         ASC
)
go



CREATE TABLE stkInvenSegmentos
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	stkInventarios       integer  NOT NULL ,
	CONSTRAINT XPKstkInvenSegmentos PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkInvenSegmentos ON stkInvenSegmentos
( 
	Empresa_Id            ASC,
	Segmento1C            ASC,
	Segmento2C            ASC,
	Segmento3C            ASC,
	Segmento4C            ASC,
	Segmento2N            ASC,
	Segmento3N            ASC,
	Segmento4N            ASC,
	Segmento1N            ASC
)
go



CREATE TABLE stkInventarios
( 
	stkInventarios       integer IDENTITY ,
	Deposito_Id          integer  NULL ,
	FechaInventario      qFecha ,
	FechaCarga           qFechaHora ,
	FechaAutorizo        qFechaHora  NULL ,
	UsuarioAutorizo      integer  NULL ,
	UsuRespo_Id          integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKstkInventarios PRIMARY KEY  CLUSTERED (stkInventarios ASC)
)
go



CREATE TABLE stkInventCuerpo
( 
	stkInventarios       integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadAlterna      qCantidadD8 ,
	CONSTRAINT XPKstkInventCuerpo PRIMARY KEY  CLUSTERED (stkInventarios ASC,Producto_Id ASC)
)
go



CREATE TABLE stkInventDespacho
( 
	stkInventarios       integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Despacho_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkInventDespacho PRIMARY KEY  CLUSTERED (stkInventarios ASC,Producto_Id ASC,Despacho_Id ASC)
)
go



CREATE TABLE stkInventSerie
( 
	stkInventarios       integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkInventSerie PRIMARY KEY  CLUSTERED (stkInventarios ASC,Producto_Id ASC,Serie ASC)
)
go



CREATE TABLE stkInvMoviStk
( 
	stkMoviCabe          bigint  NOT NULL ,
	stkInventarios       integer  NULL ,
	CONSTRAINT XPKstkInvMoviStk PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMaxMin
( 
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Minimo               qCantidadD8 ,
	Maximo               qCantidadD8 ,
	CONSTRAINT XPKstkMaxMin PRIMARY KEY  CLUSTERED (Producto_Id ASC,Deposito_Id ASC,Empresa_Id ASC)
)
go



CREATE TABLE stkMoviCabe
( 
	stkMoviCabe          bigint  NOT NULL ,
	SubTipoMov_Id        varchar(5)  NOT NULL ,
	ModificaCosto        Sino ,
	Signo                smallint  NOT NULL ,
	CONSTRAINT XPKE_56 PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMoviCabeCentro
( 
	stkMoviCabe          bigint  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	CONSTRAINT XPKstkMoviCabeCentro PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMoviCausa
( 
	stkMoviCabe          bigint  NOT NULL ,
	Causa_Id             integer  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	CONSTRAINT XPKstkMoviCausa PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMoviConsigna
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkMoviConsigna PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,comOrdenComp ASC,Renglon_OC ASC)
)
go



CREATE TABLE stkMoviCRevaluo
( 
	stkMoviCabeReva      bigint  NOT NULL ,
	conAsientos          bigint  NULL ,
	CONSTRAINT XPKstkMoviCRevaluo PRIMARY KEY  CLUSTERED (stkMoviCabeReva ASC)
)
go



CREATE TABLE stkMoviCuerpo
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	stkMoviCabeComponente bigint  NULL ,
	RenglonComponente    integer  NULL ,
	Fecha                qFecha ,
	Deposito_Id          integer  NULL ,
	Producto_Id          integer  NULL ,
	Medida_Id            integer  NULL ,
	Factor               qCantidadD8 ,
	Cantidad             qCantidadD8 ,
	CantidadForm         qCantidadD8 ,
	CostoUnitario        qMonedaD8 ,
	PrecioOriginal       qMonedaD8 ,
	MedidaAlterna        integer  NULL ,
	CantidadAlternaForm  qCantidadD8 ,
	Observaciones        QMemo  NULL ,
	Descuento            qPorcentaje ,
	conRenglonDebe       integer  NOT NULL ,
	conRenglonHaber      integer  NOT NULL ,
	RenglonCombo         integer  NULL ,
	CONSTRAINT XPKstkMovimientos PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE NONCLUSTERED INDEX IdxMoviCuerpoInv1 ON stkMoviCuerpo
( 
	Producto_Id           ASC
)
INCLUDE( Deposito_Id )
go



CREATE TABLE stkMoviCuerpoCombo
( 
	stkMoviCabeComponente bigint  NOT NULL ,
	RenglonComponente    integer  NOT NULL ,
	stkMoviCabe          bigint  NULL ,
	Renglon              integer  NULL ,
	CONSTRAINT XPKstkMoviCuerpoCombo PRIMARY KEY  CLUSTERED (stkMoviCabeComponente ASC,RenglonComponente ASC)
)
go



CREATE TABLE stkMoviCuerpoPediCuerpo
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	CONSTRAINT XPKstkMoviCuerpoPediCuerpo PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE stkMoviCuerpoReva
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	PUC_Actual           qMonedaD8 ,
	PUC_Anterior         qMonedaD8 ,
	PPP_Actual           qMonedaD8 ,
	PPP_Anterior         qMonedaD8 ,
	STD_Actual           qMonedaD8 ,
	STD_Anterior         qMonedaD8 ,
	ImporteAjuste        qMonedaD2 ,
	ImporteAjusteCosto   qMonedaD2 ,
	Cantidad             qCantidadD8  NULL ,
	CONSTRAINT XPKstkMoviCuerpoReva PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE NONCLUSTERED INDEX idxstkCuerpoRevaProd ON stkMoviCuerpoReva
( 
	Producto_Id           ASC
)
go



CREATE TABLE stkMoviDespa
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Despacho_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkMoviDespa PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,Despacho_Id ASC)
)
go



CREATE TABLE stkMoviEmbarque
( 
	stkMoviCabe          bigint  NOT NULL ,
	comEmbarques         bigint  NOT NULL ,
	Proveed_Id           bigint  NOT NULL ,
	RemitoProv           varchar(20)  NOT NULL ,
	Despacho_Id          integer  NULL ,
	CONSTRAINT XPKstkMoviEmbarque PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMoviLega
( 
	stkMoviCabe          bigint  NOT NULL ,
	Legajo               bigint  NULL ,
	CONSTRAINT XPKstkMoviLega PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMoviOC
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	CantFactPendiente    qCantidadD8 ,
	CONSTRAINT XPKstkMoviOC PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE stkMoviProv
( 
	stkMoviCabe          bigint  NOT NULL ,
	RemitoProv           varchar(50)  NOT NULL ,
	Proveed_Id           bigint  NOT NULL ,
	FechaRemito          qFecha ,
	CONSTRAINT XPKstkMoviProv PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkMoviRI
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	comReqInterno        integer  NULL ,
	Renglon_RI           integer  NULL ,
	CONSTRAINT XPKstkMoviRI PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE stkMoviSerie
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkMoviSerie PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,Serie ASC)
)
go



CREATE TABLE stkMoviSerieUbicacion
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkMoviSerieUbicacion PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,Serie ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE stkMoviUbicacion
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadAlterna      qCantidadD8 ,
	CONSTRAINT XPKstkMoviUbicacion PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE stkProductos
( 
	stkProductos         integer IDENTITY ,
	Producto_Id          varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	DescripcionDetallada QMemo  NULL ,
	Description          QMemo ,
	Medida_Id            integer  NOT NULL ,
	MedidaAlterna        integer  NULL ,
	FactorAlterna        qCantidadD8 ,
	Clase                char(1)  NOT NULL ,
	ClaseAlterna         char(1)  NOT NULL ,
	CodigoBarra          varchar(25)  NOT NULL ,
	Tipo_Id              integer  NULL ,
	Familia_Id           integer  NULL ,
	Grupo_Id             integer  NULL ,
	TrabajaPorLotes      Sino ,
	conVencimiento       Sino ,
	Serializable         Sino ,
	UsaDespachoImportacion Sino ,
	UmVenta              integer  NULL ,
	CostoPromPond        qMonedaD8 ,
	CostoUltCompra       qMonedaD8 ,
	CostoReposicion      qMonedaD8 ,
	CostoStandard        qMonedaD8 ,
	CostoUltimoCierre    qMonedaD8 ,
	MonedaUltCompra      integer  NULL ,
	PrecioUltCompra      qMonedaD8 ,
	UMCompra             integer  NULL ,
	CtaCompra            integer  NULL ,
	CtaAjuInventario     integer  NULL ,
	CtaVenta             integer  NULL ,
	CtaCredito           integer  NULL ,
	CtaDescuento         integer  NULL ,
	CtaCosto             integer  NULL ,
	CtaVentaExt          integer  NULL ,
	CtaCreditoExt        integer  NULL ,
	CtaDescuentoExt      integer  NULL ,
	CtaCostoExt          integer  NULL ,
	Fcha_Ult_Compra      qFecha ,
	MargenExceso         qPorcentaje ,
	TiempoEntrega        smallint  NOT NULL ,
	Acepta_Ventas        Sino ,
	CFVenta_Id           integer  NULL ,
	Acepta_Compras       Sino ,
	CFComp_Id            integer  NULL ,
	Acepta_Comis_Vta     Sino ,
	DiasGarantia         smallint  NOT NULL ,
	Imagen               QMemo ,
	FechaUltModif        qFechaHora ,
	ImagenExtension      varchar(5)  NOT NULL ,
	CodigoFiscal         varchar(20)  NULL ,
	FraccionArancelaria  varchar(20)  NULL ,
	CtaConsumo           integer  NULL ,
	Observaciones        QMemo ,
	UrlProd              QMemo ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	ClaveSTCC            varchar(6)  NULL ,
	MaterialPeligroso    Sino 
	CONSTRAINT Cero_1045846687
		 DEFAULT  0,
	CveMaterialPeligroso varchar(6)  NULL ,
	Embalaje             varchar(6)  NULL ,
	PesoEnKg             numeric(18,4)  NULL ,
	CONSTRAINT XPKstkProductos PRIMARY KEY  CLUSTERED (stkProductos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkProductos ON stkProductos
( 
	Producto_Id           ASC
)
go



CREATE NONCLUSTERED INDEX idxStkProductosCFUM ON stkProductos
( 
	CFVenta_Id            ASC
)
INCLUDE( UmVenta )
go



CREATE NONCLUSTERED INDEX IdxProductosInv1 ON stkProductos
( 
	Producto_Id           ASC
)
INCLUDE( Tipo_Id,Familia_Id,Grupo_Id )
go



CREATE NONCLUSTERED INDEX IdxProductosInv2 ON stkProductos
( 
	Tipo_Id               ASC,
	Producto_Id           ASC
)
INCLUDE( Descripcion,Familia_Id,Grupo_Id )
go



CREATE NONCLUSTERED INDEX idxProductoINV3 ON stkProductos
( 
	Inactivo              ASC
)
INCLUDE( Empresa_Id,UmVenta,CFVenta_Id )
go



CREATE TABLE stkProductosCombo
( 
	Combo_Id             integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkProductosCombo PRIMARY KEY  CLUSTERED (Combo_Id ASC,Producto_Id ASC)
)
go



CREATE TABLE stkProductosCostoCierre
( 
	Empresa_Id           integer  NOT NULL ,
	Fecha                qFecha ,
	Producto_Id          integer  NOT NULL ,
	Costo                qMonedaD8 ,
	CONSTRAINT XPKstkProductosCostosCierre PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Fecha ASC,Producto_Id ASC)
)
go



CREATE TABLE stkProductosCostoCierreSucursal
( 
	Empresa_Id           integer  NOT NULL ,
	Fecha                qFecha ,
	Sucursal             integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Costo                qMonedaD8 ,
	CONSTRAINT XPKstkProductosCosto PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Fecha ASC,Sucursal ASC,Producto_Id ASC)
)
go



CREATE TABLE stkProductosCostos
( 
	Producto_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	MonedaUltCompra      integer  NULL ,
	CostoPromPond        qMonedaD8 ,
	CostoUltCompra       qMonedaD8 ,
	CostoStandard        qMonedaD8 ,
	FechaUltModif        qFechaHora ,
	PrecioUltCompra      qMonedaD8 ,
	Fecha_Ult_Compra     qFechaHora ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKstkProductosCostos PRIMARY KEY  CLUSTERED (Producto_Id ASC,Empresa_Id ASC)
)
go



CREATE TABLE stkProductosCostosSucursal
( 
	Sucursal             integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	MonedaUltCompra      integer  NULL ,
	CostoPromPond        qMonedaD8 ,
	CostoUltCompra       qMonedaD8 ,
	CostoStandard        qMonedaD8 ,
	FechaUltModif        qFechaHora ,
	PrecioUltCompra      qMonedaD8 ,
	Fecha_Ult_Compra     qFechaHora ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKstkProductosCostosSucursal PRIMARY KEY  CLUSTERED (Sucursal ASC,Producto_Id ASC,Empresa_Id ASC)
)
go



CREATE TABLE stkProductosPlantilla
( 
	stkProductosPlantilla integer IDENTITY ( 1,1 ) ,
	Plantilla_Id         varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Medida_Id            integer  NULL ,
	MedidaAlterna        integer  NULL ,
	FactorAlterna        qCantidadD8 ,
	Clase                char(1)  NOT NULL ,
	ClaseAlterna         char(1)  NOT NULL ,
	Tipo_Id              integer  NULL ,
	Familia_Id           integer  NULL ,
	Grupo_Id             integer  NULL ,
	TrabajaPorLotes      Sino ,
	conVencimiento       Sino ,
	Serializable         Sino ,
	UsaDespachoImportacion Sino ,
	UMVenta_Id           integer  NULL ,
	MonedaUltCompra      integer  NULL ,
	UMCompra_Id          integer  NULL ,
	CtaCompra            integer  NULL ,
	CtaAjuInventario     integer  NULL ,
	CtaVenta             integer  NULL ,
	CtaCredito           integer  NULL ,
	CtaDescuento         integer  NULL ,
	CtaCosto             integer  NULL ,
	CtaVentasExt         integer  NULL ,
	CtaCreditoExt        integer  NULL ,
	CtaDescuentoExt      integer  NULL ,
	CtaCostoExt          integer  NULL ,
	MargenExceso         qPorcentaje ,
	TiempoEntrega        smallint  NOT NULL ,
	Acepta_Ventas        Sino ,
	CFVenta_Id           integer  NULL ,
	Acepta_Compras       Sino ,
	CFCompra_Id          integer  NULL ,
	Acepta_Comis_Vta     Sino ,
	DiasGarantia         smallint  NOT NULL ,
	CodigoFiscal         varchar(20)  NULL ,
	FraccionArancelaria  varchar(20)  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CtaConsumo           integer  NULL ,
	CONSTRAINT XPKstkProductosPlantilla PRIMARY KEY  CLUSTERED (stkProductosPlantilla ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkProductosPlantilla ON stkProductosPlantilla
( 
	Plantilla_Id          ASC
)
go



CREATE TABLE stkRemiConforma
( 
	stkMoviCabe          bigint  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaConforma        qFecha ,
	FechaRegistro        qFechaHora ,
	Observaciones        QMemo ,
	CONSTRAINT XPKstkRemiConforma PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkRemiPendFact
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	CantidadPendiente    qCantidadD8 ,
	CONSTRAINT XPKstkRemiPendFac PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE stkRemiPendFactPro
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	CantidadPendiente    qCantidadD8 ,
	CONSTRAINT XPKstkRemiPendFactPro PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go



CREATE TABLE stkRemitos
( 
	stkMoviCabe          bigint  NOT NULL ,
	Cliente_Id           bigint  NULL ,
	Sucursal             SucursalN  NULL ,
	Segmento_Id          integer  NULL ,
	ListaPrecio_Id       integer  NULL ,
	HojaRuta_Id          integer  NULL ,
	FormaEntrega_Id      integer  NULL ,
	CONSTRAINT XPKstkRemitos PRIMARY KEY  CLUSTERED (stkMoviCabe ASC)
)
go



CREATE TABLE stkSerieVencimiento
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Vencimiento          qFecha ,
	CONSTRAINT XPKstkSerieVencimiento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Serie ASC)
)
go



CREATE TABLE stkSolicitudCD
( 
	stkSolicitudCD       bigint  NOT NULL ,
	DepositoDestino      integer  NULL ,
	Fecha                qFecha  NULL ,
	Estado               char(1)  NOT NULL ,
	Posteado             Sino 
	CONSTRAINT Uno_2102745814
		 DEFAULT  1,
	Usuario_Id           integer  NOT NULL 
	CONSTRAINT Uno_1556728010
		 DEFAULT  1,
	Observaciones        QMemo  NOT NULL 
	CONSTRAINT Blanco_693569966
		 DEFAULT  ' ',
	CONSTRAINT XPKstkSolicitudCD PRIMARY KEY  CLUSTERED (stkSolicitudCD ASC)
)
go



CREATE TABLE stkSolicitudCDCuerpo
( 
	stkSolicitudCD       bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	DepositoOrigen       integer  NULL ,
	Observaciones        QMemo ,
	Cantidad             qCantidadD8  NOT NULL ,
	CantidadPendiente    qCantidadD8  NOT NULL ,
	Medida_Id            integer  NULL ,
	CONSTRAINT XPKstkSolicitudCDCuerpo PRIMARY KEY  CLUSTERED (stkSolicitudCD ASC,Renglon ASC)
)
go



CREATE TABLE stkSolicitudCDSalida
( 
	stkSolicitudCD       bigint  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	CONSTRAINT XPKstkSolicitudCDSalida PRIMARY KEY  CLUSTERED (stkSolicitudCD ASC,stkMoviCabe ASC)
)
go



CREATE TABLE stkSolicitudCDSegmento
( 
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	stkSolicitudCD       bigint  NOT NULL ,
	CONSTRAINT XPKstkSolicitudCDSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC,Empresa_Id ASC)
)
go



CREATE TABLE stkSubTipoMov
( 
	SubTipoMov_Id        varchar(5)  NOT NULL ,
	TipoMov              varchar(2)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Consumo              Sino ,
	CantCopias           smallint  NOT NULL ,
	Reporte_Id           integer  NULL ,
	CONSTRAINT XPKstkSubTipoMov PRIMARY KEY  CLUSTERED (SubTipoMov_Id ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkSubTipoMov ON stkSubTipoMov
( 
	SubTipoMov_Id         ASC
)
go



CREATE TABLE stkTipos
( 
	stkTipos             integer IDENTITY ,
	Tipo_Id              varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKstkTipos PRIMARY KEY  CLUSTERED (stkTipos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkTipos ON stkTipos
( 
	Tipo_Id               ASC
)
go



CREATE TABLE stkTiposMov
( 
	TipoMov              varchar(2)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Signo                smallint  NOT NULL ,
	Reporte_Id           integer  NULL ,
	CONSTRAINT XPKstkTiposMov PRIMARY KEY  CLUSTERED (TipoMov ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkTiposMov ON stkTiposMov
( 
	TipoMov               ASC
)
go



CREATE TABLE stkUbiAlmacenDefecto
( 
	Empresa_Id           integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Ubicacion_Id         integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKstkUbiAlmacenDefecto PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Deposito_Id ASC,Producto_Id ASC)
)
go



CREATE TABLE stkUbicaciones
( 
	stkUbicaciones       integer IDENTITY ( 1,1 ) ,
	Ubicacion_Id         varchar(25)  NOT NULL ,
	Capacidad            QCantidad ,
	Usuario_Id           integer  NULL ,
	Inactivo             Sino ,
	CONSTRAINT XPKstkUbicaciones PRIMARY KEY  CLUSTERED (stkUbicaciones ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkUbicaciones ON stkUbicaciones
( 
	Ubicacion_Id          ASC
)
go



CREATE TABLE stkUniMed
( 
	stkUniMed            integer IDENTITY ,
	Medida_Id            varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Decimales            int  NOT NULL ,
	Mascara              varchar(16)  NOT NULL ,
	CodigoFiscal         varchar(10)  NULL ,
	UniExpor             varchar(5)  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKstkMedidas PRIMARY KEY  CLUSTERED (stkUniMed ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkUniMed ON stkUniMed
( 
	Medida_Id             ASC
)
go



CREATE TABLE sueArchivosTxt
( 
	sueArchivosTxt       integer IDENTITY ( 1,1 ) ,
	Archivo_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Resumen1             integer  NULL ,
	PosicionResumen1     char(1)  NOT NULL ,
	Resumen2             integer  NULL ,
	PosicionResumen2     char(1)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKsueArchivosTxt PRIMARY KEY  CLUSTERED (sueArchivosTxt ASC)
)
go



CREATE TABLE sueArchivosTxtCuerpo
( 
	sueArchivosTxt       integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Formula              QMemo  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	Longitud             smallint  NOT NULL ,
	Decimales            smallint  NOT NULL ,
	Relleno              varchar(2)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Orden                smallint  NOT NULL ,
	Formato              varchar(25)  NULL ,
	CONSTRAINT XPKsueArchivosTxtCuerpo PRIMARY KEY  CLUSTERED (sueArchivosTxt ASC,Columna ASC)
)
go



CREATE TABLE sueCategorias
( 
	sueCategorias        integer IDENTITY ( 1,1 ) ,
	Categoria_Id         varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Periodo_Id           char(1)  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueCategorias PRIMARY KEY  CLUSTERED (sueCategorias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueCategorias ON sueCategorias
( 
	Categoria_Id          ASC
)
go



CREATE TABLE sueCateNombre
( 
	CateNombre_Id        integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	PorEmpresa           Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueCateNombre PRIMARY KEY  CLUSTERED (CateNombre_Id ASC)
)
go



CREATE TABLE sueConcAcum
( 
	sueConcAcum          integer IDENTITY ( 1,1 ) ,
	Concepto_Id          integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Fecha                datetime  NOT NULL ,
	MontoTope            qMonedaD2 ,
	Descuento            qMonedaD2 ,
	Acumulado            qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	Anulado              Sino ,
	CONSTRAINT XPKsueConcAcum PRIMARY KEY  CLUSTERED (sueConcAcum ASC)
)
go



CREATE TABLE sueConcAcumSegmento
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	sueConcAcum          integer  NOT NULL ,
	CONSTRAINT XPKsueConcAcumSegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC,Segmento_Id ASC)
)
go



CREATE TABLE sueConcDescuento
( 
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	sueConcAcum          integer  NOT NULL ,
	Monto                qMonedaD2 ,
	CONSTRAINT XPKsueConcDescuento PRIMARY KEY  CLUSTERED (Legajo ASC,Concepto_Id ASC,sueLiquidacion ASC,sueConcAcum ASC)
)
go



CREATE TABLE sueConceptos
( 
	sueConceptos         integer IDENTITY ( 1,1 ) ,
	Concepto_Id          integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Formula              varchar(max)  NOT NULL ,
	LlevaDato            Sino ,
	CuentaDebe           integer  NULL ,
	CuentaHaber          integer  NULL ,
	SubCuentaDebe        integer  NULL ,
	SubCuentaHaber       integer  NULL ,
	Retroactivo          Sino  NOT NULL ,
	Extraordinario       Sino  NOT NULL ,
	TipoPercepcion       varchar(3)  NULL ,
	TipoDeduccion        varchar(3)  NULL ,
	TipoOtro             varchar(3)  NULL ,
	TipoHora             char(1)  NULL ,
	TipoIncapacidad      varchar(2)  NULL ,
	EsExento             Sino ,
	Signo                smallint  NOT NULL ,
	ColumnaRecibo        smallint  NOT NULL ,
	Observacion          QMemo ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueConceptos PRIMARY KEY  CLUSTERED (sueConceptos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueConceptos ON sueConceptos
( 
	Concepto_Id           ASC
)
go



CREATE TABLE sueConceptosProp
( 
	sueConceptosProp     integer IDENTITY ( 1,1 ) ,
	Propiedad            varchar(10)  NOT NULL ,
	Orden                integer  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Agrupamiento         varchar(20)  NOT NULL ,
	CONSTRAINT XPKsueConceptosProp PRIMARY KEY  CLUSTERED (sueConceptosProp ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueConceptos ON sueConceptosProp
( 
	Propiedad             ASC
)
go



CREATE TABLE sueConceptosPropValor
( 
	Concepto_Id          integer  NOT NULL ,
	Propiedad            integer  NOT NULL ,
	SiNo                 Sino ,
	CONSTRAINT XPKsueConceptosPropValor PRIMARY KEY  CLUSTERED (Concepto_Id ASC,Propiedad ASC)
)
go



CREATE TABLE sueConvenio
( 
	sueConvenio          integer IDENTITY ( 1,1 ) ,
	Convenio_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	TablaVac_Id          integer  NULL ,
	Sindicalizdo         Sino ,
	CONSTRAINT XPKsueTipoRelacion PRIMARY KEY  CLUSTERED (sueConvenio ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueTipoRelacion ON sueConvenio
( 
	Convenio_Id           ASC
)
go



CREATE TABLE sueDato
( 
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Dato                 QCantidad ,
	Dato2                QCantidad ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueDato PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC)
)
go



CREATE TABLE sueDatoRetro
( 
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	AnioRetro            smallint  NOT NULL ,
	MesRetro             smallint  NOT NULL ,
	Dato                 QCantidad ,
	Dato2                QCantidad ,
	CONSTRAINT XPKsueDatoRetro PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC,AnioRetro ASC,MesRetro ASC)
)
go



CREATE TABLE sueFamiliares
( 
	Legajo               bigint  NOT NULL ,
	TipoDoc              char(1)  NOT NULL ,
	NroDoc               varchar(25)  NOT NULL ,
	Relacion             char(1)  NOT NULL ,
	ApellidoyNombre      varchar(50)  NOT NULL ,
	Sexo                 char(1)  NOT NULL ,
	FechaNacimiento      qFecha ,
	ACargoDesde          qFecha ,
	FechaBaja            qFecha  NULL ,
	FechaCarga           qFecha ,
	Ganancias            Sino ,
	Incapacitado         Sino ,
	AdhObSocial          Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueFamiliares PRIMARY KEY  CLUSTERED (Legajo ASC,TipoDoc ASC,NroDoc ASC)
)
go



CREATE TABLE sueGanancias
( 
	TabGan_Id            integer  NOT NULL ,
	Hasta                qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	Minimo               qMonedaD2 ,
	Ver                  integer  NULL ,
	CONSTRAINT XPKsueGanancias PRIMARY KEY  CLUSTERED (TabGan_Id ASC,Hasta ASC)
)
go



CREATE TABLE sueGanTitulo
( 
	TabGan_Id            integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	Codigo               varchar(20)  NULL ,
	CONSTRAINT XPKsueGanTitulo PRIMARY KEY  CLUSTERED (TabGan_Id ASC)
)
go



CREATE TABLE sueGrupos
( 
	sueGrupos            integer IDENTITY ( 1,1 ) ,
	Grupo_Id             integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Segmento_Id          integer  NULL ,
	Periodo_Id           char(1)  NULL ,
	CtaSueldoAPagar      integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsueGrupos PRIMARY KEY  CLUSTERED (sueGrupos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueGrupos ON sueGrupos
( 
	Grupo_Id              ASC
)
go



CREATE TABLE sueImpNombre
( 
	Importe_Id           integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueImpNombre PRIMARY KEY  CLUSTERED (Importe_Id ASC)
)
go



CREATE TABLE sueInfDefFormulas
( 
	sueInfDefinibles     integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Alias                varchar(10)  NOT NULL ,
	Titulo               varchar(50)  NOT NULL ,
	Formula              varchar(max)  NOT NULL ,
	Formato              varchar(20)  NOT NULL ,
	Ancho                Numeric(6,2)  NOT NULL ,
	Orden                integer  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	CheckCero            Sino ,
	CONSTRAINT XPKsueInfDefFormulas PRIMARY KEY  CLUSTERED (sueInfDefinibles ASC,Columna ASC)
)
go



CREATE TABLE sueInfDefinibles
( 
	sueInfDefinibles     integer IDENTITY ( 1,1 ) ,
	Informe_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	AgrupadoPor          varchar(3)  NOT NULL ,
	TamanioHoja          varchar(2)  NULL ,
	Horizontal           Sino ,
	Um                   varchar(2)  NOT NULL ,
	LegajoDesde          integer  NOT NULL ,
	LegajoHasta          integer  NOT NULL ,
	SucursalDesde        varchar(4)  NOT NULL ,
	SucursalHasta        varchar(4)  NOT NULL ,
	ConvenioDesde        varchar(5)  NOT NULL ,
	ConvenioHasta        varchar(5)  NOT NULL ,
	AnchoNombre          integer  NOT NULL ,
	Centro1Desde         varchar(8)  NOT NULL ,
	Centro1Hasta         varchar(8)  NOT NULL ,
	Centro2Desde         varchar(8)  NOT NULL ,
	Centro2Hasta         varchar(8)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKsueInfDefinibles PRIMARY KEY  CLUSTERED (sueInfDefinibles ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueInfDefinibles ON sueInfDefinibles
( 
	Informe_Id            ASC
)
go



CREATE TABLE sueLiqEmpCatego
( 
	Categoria_Id         integer  NOT NULL ,
	CateNombre_Id        integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqEmpCatego PRIMARY KEY  CLUSTERED (Categoria_Id ASC,CateNombre_Id ASC,Empresa_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqImpCatego
( 
	Categoria_Id         integer  NOT NULL ,
	CateNombre_Id        integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqImpCatego PRIMARY KEY  CLUSTERED (Categoria_Id ASC,CateNombre_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqPersImportes
( 
	Legajo               bigint  NOT NULL ,
	Importe_Id           integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqPersImportes PRIMARY KEY  CLUSTERED (Legajo ASC,Importe_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiquidacion
( 
	sueLiquidacion       bigint  NOT NULL ,
	Grupo_Id             integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	FechaPago            qFecha ,
	FechaDeposito        qFecha  NULL ,
	PeriodoDeposito      varchar(20)  NULL ,
	CtaSueldosAPagar     integer  NOT NULL ,
	FechaInicial         qFecha  NULL ,
	FechaFinal           qFecha  NULL ,
	Periodo_Id           char(1)  NULL ,
	PorEmpleado          Sino ,
	Anio                 integer  NOT NULL ,
	Mes                  integer  NOT NULL ,
	Quincena             integer  NOT NULL ,
	Semana               integer  NOT NULL ,
	Decena               integer  NOT NULL ,
	Vez                  integer  NOT NULL ,
	FechaContabilizacion qFecha ,
	CONSTRAINT XPKsueLiquidacion PRIMARY KEY  CLUSTERED (sueLiquidacion ASC)
)
go



CREATE TABLE sueLiqVarEmpGlobales
( 
	VarGlobal_Id         integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqVarEmpGlobales PRIMARY KEY  CLUSTERED (VarGlobal_Id ASC,Empresa_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqVarGlobales
( 
	VarGlobal_Id         integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	Ver                  integer  NULL ,
	CONSTRAINT XPKsueLiqVarGlobales PRIMARY KEY  CLUSTERED (VarGlobal_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueMovCont
( 
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKsueMovCont PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE sueNominaCfdi
( 
	Folio                integer  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	SelloDigital         varchar(max)  NULL ,
	Xml                  varchar(max)  NULL ,
	NoCertificado        varchar(20)  NOT NULL ,
	UUID                 varchar(36)  NULL ,
	FechaTimbrado        varchar(19)  NULL ,
	SelloSat             varchar(max)  NULL ,
	noCertificadoSAT     varchar(20)  NULL ,
	Fecha                varchar(20)  NOT NULL ,
	Anulada              Sino ,
	RfcProvCertif        varchar(12)  NULL ,
	Leyenda              varchar(150)  NULL ,
	FechaCancelacion     datetime  NULL ,
	CONSTRAINT XPKsueNominaCfdi PRIMARY KEY  CLUSTERED (Folio ASC)
)
go



CREATE TABLE suePagosHabi
( 
	sueLiquidacion       bigint  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	FechaHabilitacion    qFecha  NULL ,
	Importe              qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePagosHabi PRIMARY KEY  CLUSTERED (sueLiquidacion ASC)
)
go



CREATE TABLE suePagosHabiPorEmpleado
( 
	sueLiquidacion       bigint  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	FechaHabilitacion    qFecha  NULL ,
	Importe              qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePagosHabiPorEmpleado PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Secuencia ASC,Legajo ASC)
)
go



CREATE TABLE suePeriodicidad
( 
	Periodo_Id           char(1)  NOT NULL ,
	Descripcion          varchar(30)  NOT NULL ,
	Dias                 qMonedaD4 ,
	Empresa_Id           integer  NULL ,
	FechaActiva          qFecha ,
	CodFiscal            varchar(2)  NULL ,
	CONSTRAINT XPKsuePeriodicidad PRIMARY KEY  CLUSTERED (Periodo_Id ASC)
)
go



CREATE TABLE suePeriodosSugeridos
( 
	Empresa_Id           integer  NOT NULL ,
	Anio                 integer  NOT NULL ,
	Mes                  integer  NOT NULL ,
	Quincena             integer  NOT NULL ,
	Semana               integer  NOT NULL ,
	Decena               integer  NOT NULL ,
	Vez                  integer  NOT NULL ,
	CONSTRAINT XPKsuePeriodosSugeridos PRIMARY KEY  CLUSTERED (Empresa_Id ASC)
)
go



CREATE TABLE suePersActividad
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Actividad_Id         varchar(3)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersActividad PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersAfore
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Afore_Id             varchar(5)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersAfore PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersAporteAdic
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Adicional            qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersAporteAdic PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersAporteVoluntario
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Voluntario           qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersAporteVoluntario PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersCatego
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Categoria_Id         integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsuePersCatego PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersCondServicio
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	CondServicio_Id      varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersCondServicio PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersContable
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersContable PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersContableDatos
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKsuePersContableDatos PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE suePersConvenio
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Convenio_Id          integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoRela PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersDomicilio
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Direccion1           varchar(100)  NOT NULL ,
	Direccion2           varchar(100)  NOT NULL ,
	NroExterior          varchar(10)  NOT NULL ,
	NroInterior          varchar(10)  NOT NULL ,
	Localidad            varchar(100)  NOT NULL ,
	CodigoPostal         varchar(40)  NOT NULL ,
	EntreCalle1          varchar(60)  NOT NULL ,
	EntreCalle2          varchar(60)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsuePersDomicilio PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersEstadoCivil
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	EstadoCivil_Id       varchar(3)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersEstadoCivil PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersLocalidad
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Localidad_Id         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersLocalidad PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersModContrata
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Modalidad_Id         varchar(3)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersModContrata PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersObraSocial
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	ObraSocial           varchar(6)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersObraSocial PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersonal
( 
	genEntidades         bigint  NOT NULL ,
	Legajo               int  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nombres              varchar(40)  NOT NULL ,
	ApellidoPaterno      varchar(30)  NOT NULL ,
	ApellidoMaterno      varchar(30)  NOT NULL ,
	NumeroDoc            varchar(20)  NOT NULL ,
	NroSegSocial         varchar(20)  NOT NULL ,
	Telefonos            varchar(120)  NOT NULL ,
	Celular              varchar(60)  NOT NULL ,
	FechaNacimiento      qFecha ,
	Sexo                 char(1)  NOT NULL ,
	Nacionalidad_Id      integer  NULL ,
	CodigoNatural        char(1)  NULL ,
	eMail                varchar(100)  NOT NULL ,
	FechaIngreso         qFecha ,
	FechaBaja            qFecha  NULL ,
	AniosReconocidos     integer  NOT NULL ,
	MesesReconocidos     integer  NOT NULL ,
	GrupoSanguineo       char(2)  NOT NULL ,
	RH                   char(1)  NOT NULL ,
	BancoSucursal        char(5)  NOT NULL ,
	BancoCuenta          char(15)  NOT NULL ,
	BancoTipoCta         char(3)  NOT NULL ,
	CuentaInactiva       Sino ,
	ClaveBancaria        varchar(25)  NOT NULL ,
	Observaciones        varchar(max)  NULL ,
	UMF                  varchar(3)  NOT NULL ,
	AvisarA              varchar(max)  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuepersonal PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1suepersonal ON suePersonal
( 
	Legajo                ASC
)
go



CREATE TABLE suePersonalInfo
( 
	Legajo               bigint  NOT NULL ,
	NroCreditoInfonavit  varchar(10)  NOT NULL ,
	TipoDescuento        smallint  NOT NULL ,
	Fecha                qFecha ,
	ValorDescuento       qMonedaD2 ,
	CONSTRAINT XPKsuePersonalInfo PRIMARY KEY  CLUSTERED (Legajo ASC)
)
go



CREATE TABLE suePersPuestos
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Puesto_Id            integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersPuestos PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersRebPromo
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Rebaja               qPorcentaje ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersRebPromo PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersRedZonal
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Reduccion            qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersRedZonal PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersSiniestrado
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Siniestro_Id         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersIncapacidad PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersSituacionRevi
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Situacion_Id         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersSituacionRevi PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersSucursal
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Sucursal             integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersSucursal PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoContrato
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoContrato         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoContrato PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoEmpleador
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoEmpleador_Id     varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoEmpleador PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoJornada
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoJornada          varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoJornada PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoPago
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoPago_Id          integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoPago PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoRegimen
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoRegimen          varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoRegimen PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoSDI
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoSDI              char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoSDI PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePlantilla
( 
	Centro1_Id           integer  NOT NULL ,
	Puesto_Id            integer  NOT NULL ,
	Cantidad             qMonedaD2 ,
	CONSTRAINT XPKsuePlantilla PRIMARY KEY  CLUSTERED (Centro1_Id ASC,Puesto_Id ASC)
)
go



CREATE TABLE suePuestos
( 
	suePuestos           integer IDENTITY ( 1,1 ) ,
	Puesto_Id            varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	RiesgoPuesto         varchar(2)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePuesto PRIMARY KEY  CLUSTERED (suePuestos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1suePuesto ON suePuestos
( 
	Puesto_Id             ASC
)
go



CREATE TABLE sueTabla
( 
	Fila                 qMonedaD2 ,
	Tabla_Id             integer  NOT NULL ,
	Valor                qMonedaD2 ,
	Ver                  integer  NULL ,
	CONSTRAINT XPKsueTabla PRIMARY KEY  CLUSTERED (Fila ASC,Tabla_Id ASC)
)
go



CREATE TABLE sueTablaVacacion
( 
	sueTablaVacacion     integer IDENTITY ( 1,1 ) ,
	TablaVac_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Dias                 integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKsueTablaVacacion PRIMARY KEY  CLUSTERED (sueTablaVacacion ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueTablaVacacion ON sueTablaVacacion
( 
	TablaVac_Id           ASC
)
go



CREATE TABLE sueTablaVacReng
( 
	TablaVac_Id          integer  NOT NULL ,
	Antiguedad           integer  NOT NULL ,
	Dias                 integer  NOT NULL ,
	CONSTRAINT XPKsueTablaVacReng PRIMARY KEY  CLUSTERED (TablaVac_Id ASC,Antiguedad ASC)
)
go



CREATE TABLE sueTabTitulo
( 
	Tabla_Id             integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	Codigo               varchar(20)  NULL ,
	CONSTRAINT XPKsueTabTitulo PRIMARY KEY  CLUSTERED (Tabla_Id ASC)
)
go



CREATE TABLE sueTerminada
( 
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Dato                 QCantidad  NOT NULL ,
	Dato2                QCantidad  NOT NULL ,
	Importe              qMonedaD2 ,
	Signo                smallint  NOT NULL ,
	CONSTRAINT XPKsueTerminada PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC)
)
go



CREATE TABLE sueTerminadaRetro
( 
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	AnioRetro            integer  NOT NULL ,
	MesRetro             integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKsueTermi PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC,AnioRetro ASC,MesRetro ASC)
)
go



CREATE TABLE sueTipoPago
( 
	sueTipoPago          integer IDENTITY ( 1,1 ) ,
	TipoPago_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsueTipoPago PRIMARY KEY  CLUSTERED (sueTipoPago ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueTipoPago ON sueTipoPago
( 
	TipoPago_Id           ASC
)
go



CREATE TABLE sueVacCorresponden
( 
	Legajo               bigint  NOT NULL ,
	Anio                 integer  NOT NULL ,
	Dias                 integer  NOT NULL ,
	Saldo                integer  NOT NULL ,
	CONSTRAINT XPKsueVacCorresponden PRIMARY KEY  CLUSTERED (Legajo ASC,Anio ASC)
)
go



CREATE TABLE sueVacTomadas
( 
	Legajo               bigint  NOT NULL ,
	Anio                 integer  NOT NULL ,
	FechaDesde           qFecha ,
	Dias                 integer  NOT NULL ,
	FechaHasta           qFecha ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsueVacTomadas PRIMARY KEY  CLUSTERED (Legajo ASC,Anio ASC,FechaDesde ASC)
)
go



CREATE TABLE sueVarGlobales
( 
	VarGlobal_Id         integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	PorEmpresa           Sino ,
	Usuario_Id           integer  NULL ,
	Codigo               varchar(20)  NULL ,
	CONSTRAINT XPKsueVarGlobNombres PRIMARY KEY  CLUSTERED (VarGlobal_Id ASC)
)
go



CREATE TABLE sueVariable
( 
	Legajo               bigint  NOT NULL ,
	Grupo_Id             integer  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueVariable PRIMARY KEY  CLUSTERED (Legajo ASC,Grupo_Id ASC,Concepto_Id ASC)
)
go



CREATE TABLE sueVezActiva
( 
	Empresa_Id           integer  NOT NULL ,
	Anio                 integer  NOT NULL ,
	Mes                  integer  NOT NULL ,
	Quin                 integer  NOT NULL ,
	Decena               integer  NOT NULL ,
	Semana               integer  NOT NULL ,
	Vez                  integer  NOT NULL ,
	Grupo_Id             integer  NOT NULL ,
	CONSTRAINT XPKsueVezActiva PRIMARY KEY  CLUSTERED (Empresa_Id ASC)
)
go



CREATE TABLE swsAcciones
( 
	Accion_Id            varchar(200)  NOT NULL ,
	CONSTRAINT XPKswsAcciones PRIMARY KEY  CLUSTERED (Accion_Id ASC)
)
go



CREATE TABLE swsPermisos
( 
	Usuario_Id           integer  NOT NULL ,
	Accion_Id            varchar(200)  NOT NULL ,
	CONSTRAINT XPKswsPermisos PRIMARY KEY  CLUSTERED (Usuario_Id ASC,Accion_Id ASC)
)
go



CREATE TABLE swsTokens
( 
	Token                varchar(40)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Usuario_Id           integer  NULL ,
	ValidThru            datetime  NOT NULL ,
	CONSTRAINT XPKswsTokens PRIMARY KEY  CLUSTERED (Token ASC)
)
go



CREATE TABLE swsUsuarios
( 
	Usuario_Id           integer  NOT NULL ,
	Password             varchar(50)  NOT NULL ,
	CONSTRAINT XPKswsUsuarios PRIMARY KEY  CLUSTERED (Usuario_Id ASC)
)
go



CREATE TABLE tesAICheques
( 
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	FechaVencimiento     datetime  NOT NULL ,
	Chequera_Id          int  NULL ,
	numCheque            integer  NOT NULL ,
	AlaOrden             varchar(120)  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKtesAICheques PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Empresa_Id ASC,Renglon ASC)
)
go



CREATE TABLE tesAIDepositos
( 
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	CarteraCheq_Id       integer  NOT NULL ,
	numCheque            integer  NOT NULL ,
	FechaVencimiento     datetime  NOT NULL ,
	Importe              qMonedaD2 ,
	Clearing             varchar(3)  NOT NULL ,
	Banco_Id             integer  NOT NULL ,
	Cliente_Id           bigint  NULL ,
	cuentaBanco          varchar(15)  NOT NULL ,
	sucBanco             varchar(15)  NOT NULL ,
	CONSTRAINT XPKtesAIDepositos PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Empresa_Id ASC,Renglon ASC)
)
go



CREATE TABLE tesAISaldos
( 
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	SaldoInicial         qMonedaD2 ,
	Cambio               qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        datetime  NOT NULL ,
	Confirmado           Sino ,
	CONSTRAINT XPKtesAISaldos PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Empresa_Id ASC)
)
go



CREATE TABLE tesBancos
( 
	tesBancos            integer IDENTITY ,
	Banco_Id             varchar(3)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(120)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	RFC                  char(14)  NULL ,
	CONSTRAINT XPKtesBancos PRIMARY KEY  CLUSTERED (tesBancos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesBancos ON tesBancos
( 
	Banco_Id              ASC
)
go



CREATE TABLE tesBPlink
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Estado_Id            char(1)  NOT NULL ,
	Secuencia            smallint  NOT NULL ,
	tesCheqProp          integer  NULL ,
	CONSTRAINT XPKtesDocLink PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesCausasRechazo
( 
	tesCausasRechazo     integer IDENTITY ( 1,1 ) ,
	Causa_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(150)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	FechaModificacion    qFecha ,
	Posteado             Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKtesCuasasRechazo PRIMARY KEY  CLUSTERED (tesCausasRechazo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesCuasasRechazo ON tesCausasRechazo
( 
	Causa_Id              ASC
)
go



CREATE TABLE tesCFDICobranza
( 
	tesCFDICobranza      integer IDENTITY ( 1,1 ) ,
	Cliente_Id           bigint  NOT NULL ,
	Moneda_Id            integer  NOT NULL ,
	Fecha                qFecha ,
	SelloDigital         varchar(max)  NOT NULL ,
	Xml                  varchar(max)  NOT NULL ,
	Cadena               varchar(max)  NOT NULL ,
	NoCertificado        varchar(20)  NOT NULL ,
	UUID                 varchar(36)  NOT NULL ,
	FechaTimbrado        varchar(20)  NOT NULL ,
	SelloSat             varchar(max)  NOT NULL ,
	NoCertificadoSat     varchar(20)  NOT NULL ,
	RfcProvCertif        varchar(13)  NULL ,
	Leyenda              varchar(max)  NULL ,
	Anulada              char(1)  NOT NULL ,
	Sucursal             integer  NULL ,
	FechaCancelacion     qFecha  NULL ,
	UsuarioCanc_Id       integer  NULL ,
	CONSTRAINT XPKtesCFDICobranza PRIMARY KEY  CLUSTERED (tesCFDICobranza ASC)
)
go



CREATE TABLE tesCFDICobranzaCuerpo
( 
	tesCFDICobranza      integer  NOT NULL ,
	tesMovimientos       bigint  NOT NULL ,
	CONSTRAINT XPKtesCFDICobranzaCuerpo PRIMARY KEY  CLUSTERED (tesCFDICobranza ASC,tesMovimientos ASC)
)
go



CREATE NONCLUSTERED INDEX XIE1tesCFDICobranzaCuerpo ON tesCFDICobranzaCuerpo
( 
	tesMovimientos        ASC
)
go



CREATE TABLE tesCFDICobranzaRel
( 
	tesCFDICobranza      integer  NOT NULL ,
	tesCFDICobranzaR     integer  NOT NULL ,
	CONSTRAINT XPKtesCFDICobranzaRel PRIMARY KEY  CLUSTERED (tesCFDICobranza ASC,tesCFDICobranzaR ASC)
)
go



CREATE TABLE tesCFDICobranzaSegmentos
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	tesCFDICobranza      integer  NULL ,
	CONSTRAINT XPKtesCFDICobranzaSegmentos PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE tesCheqProp
( 
	tesCheqProp          integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Chequera_Id          int  NOT NULL ,
	numCheque            int  NOT NULL ,
	FechaVencimiento     datetime  NOT NULL ,
	FechaDebito          datetime  NULL ,
	aLaOrden             varchar(120)  NOT NULL ,
	Estado_Id            char(1)  NOT NULL ,
	SecuenciaActual      smallint  NOT NULL ,
	Cuit                 qCuit  NULL ,
	CuentaDestino        varchar(50)  NULL ,
	BancoDestino         integer  NULL ,
	BancoDestinoExt      varchar(150)  NULL ,
	CONSTRAINT XPKtesCheqProp PRIMARY KEY  CLUSTERED (tesCheqProp ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesCheqProp ON tesCheqProp
( 
	Empresa_Id            ASC,
	Cartera_Id            ASC,
	Chequera_Id           ASC,
	numCheque             ASC
)
go



CREATE TABLE tesCheqPropAnul
( 
	tesCheqProp          integer  NOT NULL ,
	Fecha_Anul           datetime  NOT NULL ,
	Observaciones        varchar(15)  NOT NULL ,
	Importe              qMonedaD2 ,
	FechaOriginal        qFecha ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKtesCheqPropAnul PRIMARY KEY  CLUSTERED (tesCheqProp ASC)
)
go



CREATE TABLE tesCheqPropEstado
( 
	Estado_Id            char(1)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	CONSTRAINT XPKtesCheqPropEsta PRIMARY KEY  CLUSTERED (Estado_Id ASC)
)
go



CREATE TABLE tesCheqTerceros
( 
	tesCheqTerceros      integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NULL ,
	Cartera_Id           integer  NOT NULL ,
	Banco_Id             integer  NOT NULL ,
	Clearing             varchar(3)  NOT NULL ,
	SecuenciaActual      smallint  NOT NULL ,
	ClearingDias         smallint  NOT NULL ,
	FechaVencimiento     datetime  NOT NULL ,
	FechaAcreditacion    datetime  NULL ,
	FechaConciliacion    datetime  NULL ,
	sucBanco             varchar(15)  NOT NULL ,
	numCheque            int  NOT NULL ,
	Estado_Id            char(1)  NOT NULL ,
	Cliente_Id           bigint  NULL ,
	cuentaBanco          varchar(15)  NOT NULL ,
	BancoConc            integer  NULL ,
	NumeroConc           integer  NULL ,
	BancoConcVta         integer  NULL ,
	NumeroConcVta        integer  NULL ,
	CONSTRAINT XPKtesCheqTerceros PRIMARY KEY  CLUSTERED (tesCheqTerceros ASC)
)
go



CREATE INDEX XIE1tesCheqTerceros ON tesCheqTerceros
( 
	BancoConcVta          ASC,
	BancoConc             ASC
)
go



CREATE TABLE tesCheqTerEstado
( 
	Estado_Id            char(1)  NOT NULL ,
	Descripcion          char(35)  NOT NULL ,
	CONSTRAINT XPKtesCheqTerEstad PRIMARY KEY  CLUSTERED (Estado_Id ASC)
)
go



CREATE TABLE tesChequeras
( 
	Chequera_Id          int  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	TipoChequera         char(1)  NOT NULL ,
	Estado_Id            char(1)  NOT NULL ,
	Desde                int  NOT NULL ,
	Hasta                int  NOT NULL ,
	Proximo              int  NOT NULL ,
	FechaAlta            datetime  NOT NULL ,
	FechaBaja            datetime  NULL ,
	MotivoBaja           varchar(15)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKtesChequeras PRIMARY KEY  CLUSTERED (Chequera_Id ASC,Cartera_Id ASC,Empresa_Id ASC)
)
go



CREATE TABLE tesChequerasEstado
( 
	Estado_Id            char(1)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CONSTRAINT XPKtesChequerasEst PRIMARY KEY  CLUSTERED (Estado_Id ASC)
)
go



CREATE TABLE tesClearing
( 
	Clearing             varchar(3)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Dias                 int  NOT NULL ,
	cVariable            char(1)  NOT NULL ,
	CONSTRAINT XPKtesClering PRIMARY KEY  CLUSTERED (Clearing ASC)
)
go



CREATE TABLE tesConciliacion
( 
	Empresa_Id           integer  NOT NULL ,
	tesIdentifica        integer  NOT NULL ,
	NumeroConc           integer  NOT NULL ,
	FechaConciliacion    qFecha ,
	ExtractoCierre       qMonedaD2 ,
	ExtractoApertura     qMonedaD2 ,
	ContableApertura     qMonedaD2 ,
	ContableCierre       qMonedaD2 ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKtesConciliacion PRIMARY KEY  CLUSTERED (Empresa_Id ASC,tesIdentifica ASC,NumeroConc ASC)
)
go



CREATE TABLE tesCTlink
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Estado_Id            char(1)  NOT NULL ,
	Secuencia            smallint  NOT NULL ,
	tesCheqTerceros      integer  NULL ,
	CONSTRAINT XPKtesCTlink PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesDeposito
( 
	tesMovimientos       bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	FormaDePagoP         char(2)  NOT NULL ,
	NumOperacion         varchar(100)  NULL ,
	RfcEmisorCtaOrd      varchar(13)  NULL ,
	NomBancoOrdExt       varchar(300)  NULL ,
	CtaOrdenante         varchar(50)  NULL ,
	TipoCadPago          varchar(2)  NULL ,
	CertPago             varchar(max)  NULL ,
	CadPago              varchar(max)  NULL ,
	SelloPago            varchar(max)  NULL ,
	CONSTRAINT XPKtesDeposito PRIMARY KEY  CLUSTERED (tesMovimientos ASC,Renglon ASC)
)
go



CREATE TABLE tesFFCobClientes
( 
	tesFlujoFondo        bigint  NOT NULL ,
	Fecha                qFecha ,
	Cliente_Id           bigint  NOT NULL ,
	Moneda_Id            integer  NULL ,
	Monto                qMonedaD2 ,
	CONSTRAINT XPKtesFFCobClientes PRIMARY KEY  CLUSTERED (tesFlujoFondo ASC,Fecha ASC,Cliente_Id ASC)
)
go



CREATE TABLE tesFFCobranzasOtros
( 
	tesFlujoFondo        bigint  NOT NULL ,
	Fecha                qFecha ,
	Renglon              integer  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	Moneda_Id            integer  NULL ,
	Monto                qMonedaD2 ,
	CONSTRAINT XPKtesFFCobranzasOtros PRIMARY KEY  CLUSTERED (tesFlujoFondo ASC,Fecha ASC,Renglon ASC)
)
go



CREATE TABLE tesFFDepositos
( 
	tesFlujoFondo        bigint  NOT NULL ,
	Fecha                qFecha ,
	Cliente_Id           bigint  NOT NULL ,
	Monto                qMonedaD2 ,
	Moneda_Id            integer  NULL ,
	CONSTRAINT XPKtesFFDepositos PRIMARY KEY  CLUSTERED (tesFlujoFondo ASC,Fecha ASC,Cliente_Id ASC)
)
go



CREATE TABLE tesFFPagosOtros
( 
	tesFlujoFondo        bigint  NOT NULL ,
	Fecha                qFecha ,
	Renglon              integer  NOT NULL ,
	Descripcion          varchar(200)  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	Impuesto_Id          integer  NULL ,
	Monto                qMonedaD2 ,
	Moneda_Id            integer  NULL ,
	CONSTRAINT XPKtesFFPagosOtros PRIMARY KEY  CLUSTERED (tesFlujoFondo ASC,Fecha ASC,Renglon ASC)
)
go



CREATE TABLE tesFFPagosProveedores
( 
	tesFlujoFondo        bigint  NOT NULL ,
	Fecha                qFecha ,
	Proveed_Id           bigint  NOT NULL ,
	Moneda_Id            integer  NOT NULL ,
	Monto                qMonedaD2 ,
	CONSTRAINT XPKtesFFPagosProveedores PRIMARY KEY  CLUSTERED (tesFlujoFondo ASC,Fecha ASC,Proveed_Id ASC,Moneda_Id ASC)
)
go



CREATE TABLE tesFFSegmentos
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	tesFlujoFondo        bigint  NULL ,
	CONSTRAINT XPKtesFFSegmentos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE tesFlujoFondo
( 
	tesFlujoFondo        bigint IDENTITY ( 1,1 ) ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           char(18)  NOT NULL ,
	DetallaClientes      Sino ,
	DetallaProveedores   Sino ,
	FechaRegistro        qFechaHora ,
	Periodo              char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKtesFlujoFondo PRIMARY KEY  CLUSTERED (tesFlujoFondo ASC)
)
go



CREATE TABLE tesGanancias
( 
	tesGanancias         integer IDENTITY ,
	Tabla_Id             integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKtesGanancias PRIMARY KEY  CLUSTERED (tesGanancias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesGanancias ON tesGanancias
( 
	Tabla_Id              ASC
)
go



CREATE TABLE tesGanCuerpo
( 
	Tabla_Id             integer  NOT NULL ,
	Hasta                qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	Minimo               qMonedaD2 ,
	CONSTRAINT XPKtesGanCuerpo PRIMARY KEY  CLUSTERED (Tabla_Id ASC,Hasta ASC)
)
go



CREATE TABLE tesIdBancoPropio
( 
	Cartera_Id           integer  NOT NULL ,
	ChequeraPredeter     int  NULL ,
	Banco_Id             integer  NOT NULL ,
	CantRenglones        int  NOT NULL ,
	numCuenta            varchar(35)  NOT NULL ,
	CtaContDiferido      integer  NULL ,
	MaximoLibrado        qMonedaD2 ,
	ValorComision        qPorcentaje ,
	LimCredVtaCheques    qMonedaD2 ,
	CtaCorto             numeric(2)  NOT NULL ,
	Formulario_Id        integer  NOT NULL ,
	Referencia           varchar(150)  NOT NULL ,
	RepoCheq_Id          integer  NULL ,
	RepoCheqDif_Id       integer  NULL ,
	CONSTRAINT XPKtesIdCtacte PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdCajaAhorro
( 
	Cartera_Id           integer  NOT NULL ,
	numCuenta            varchar(35)  NOT NULL ,
	topeExtraccion       int  NOT NULL ,
	InteresPorc          numeric(5,2)  NOT NULL ,
	CONSTRAINT XPKtesIdCajaAhorro PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdCheqTerceros
( 
	Cartera_Id           integer  NOT NULL ,
	CtaChqRechazado      integer  NOT NULL ,
	CONSTRAINT XPKtesIdCheqTerceros PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdentifica
( 
	tesIdentifica        integer IDENTITY ,
	Cartera_Id           varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	TipoCartera          integer  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Moneda_Id            integer  NULL ,
	UsuarioAmo           integer  NULL ,
	ModiCent1            Sino ,
	ModiCent2            Sino ,
	CtaValEnTransito     integer  NULL ,
	Reservado            Sino ,
	VaAlCashFlow         Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	FormaDePagoP         varchar(2)  NULL ,
	OrdenPtoVta          integer  NULL ,
	CONSTRAINT XPKtesIdentifica PRIMARY KEY  CLUSTERED (tesIdentifica ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesIdentifica ON tesIdentifica
( 
	Cartera_Id            ASC
)
go



CREATE TABLE tesIdRetClien
( 
	Cartera_Id           integer  NOT NULL ,
	vaSubDiarioVta       Sino ,
	TipoImpuesto         integer  NULL ,
	NroResSicore         numeric(5)  NOT NULL ,
	CONSTRAINT XPKtesIdRetClien PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdRetProv
( 
	Cartera_Id           integer  NOT NULL ,
	Formula              varchar(300)  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	TipoImpuesto         integer  NULL ,
	NroResSicore         numeric(5)  NOT NULL ,
	TipoCtaProv          integer  NULL ,
	Concepto             QMemo  NULL ,
	Porcentaje           numeric(5,2)  NOT NULL ,
	UsuarioFirmante      varchar(30)  NOT NULL ,
	Minimo               qMonedaD2 ,
	GenRetxFact          Sino ,
	Reporte_Id           integer  NULL ,
	CONSTRAINT XPKtesIdRetencione PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdTarjetas3
( 
	Cartera_Id           integer  NOT NULL ,
	MaxCuotas            integer  NOT NULL ,
	Banco_Id             integer  NULL ,
	TipoTarjeta          integer  NULL ,
	CONSTRAINT XPKtesIdTarjetas3 PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdTarjetasTipo
( 
	tesIdTarjetasTipo    integer IDENTITY ( 1,1 ) ,
	TipoTarjeta          varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Clase                varchar(20)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKtesIdTarjetasTipo PRIMARY KEY  CLUSTERED (tesIdTarjetasTipo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesIdTarjetasTipo ON tesIdTarjetasTipo
( 
	TipoTarjeta           ASC
)
go



CREATE TABLE tesIdVarios
( 
	Cartera_Id           integer  NOT NULL ,
	Modi_Cuenta          Sino ,
	CONSTRAINT XPKtesIdVarios PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesMoviGravado
( 
	tesMovimientos       bigint  NOT NULL ,
	TipoCtaProv          integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKtesMoviGravado PRIMARY KEY  CLUSTERED (tesMovimientos ASC,TipoCtaProv ASC)
)
go



CREATE TABLE tesMoviImp
( 
	tesMovimientos       bigint  NOT NULL ,
	conAsientos          bigint  NULL ,
	CONSTRAINT XPKtesMoviImp PRIMARY KEY  CLUSTERED (tesMovimientos ASC)
)
go



CREATE TABLE tesMovimientos
( 
	tesMovimientos       bigint  NOT NULL ,
	SubTipo_Id           integer  NOT NULL ,
	Fecha_Real           qFecha ,
	CONSTRAINT XPKtesMovimientos PRIMARY KEY  CLUSTERED (tesMovimientos ASC)
)
go



CREATE TABLE tesMoviReversa
( 
	tesMovimientos       bigint  NOT NULL ,
	tesMoviReversa       bigint  NOT NULL ,
	CONSTRAINT XPKtesMoviReversa PRIMARY KEY  CLUSTERED (tesMovimientos ASC)
)
go



CREATE TABLE tesPartidasInCon
( 
	Cartera_Id           integer  NOT NULL ,
	Fecha                qFecha ,
	Comprobante          integer  NOT NULL ,
	Debe_Haber           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	Empresa_Id           integer  NOT NULL ,
	CONSTRAINT XPKtesPartidasInCon PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Fecha ASC,Comprobante ASC)
)
go



CREATE TABLE tesRengConcilEsp
( 
	Empresa_Id           integer  NOT NULL ,
	tesIdentifica        integer  NOT NULL ,
	NumeroConc           integer  NOT NULL ,
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKtesRengConcilEsp PRIMARY KEY  CLUSTERED (Empresa_Id ASC,tesIdentifica ASC,NumeroConc ASC,tesMovimientos ASC,conRenglon ASC)
)
go



CREATE NONCLUSTERED INDEX IXtesRengConcilEspTMR ON tesRengConcilEsp
( 
	tesMovimientos        ASC,
	conRenglon            ASC
)
go



CREATE TABLE tesRengConciliac
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Saldo                qMonedaD2 ,
	CONSTRAINT XPKtesRengConciliac PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesRengMovi
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Cambio               qMonedaD8 ,
	TipomovCont          numeric(1,0)  NOT NULL ,
	CONSTRAINT XPKtesRengMovi PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE NONCLUSTERED INDEX ixtesRengMoviTMC ON tesRengMovi
( 
	TipomovCont           ASC
)
INCLUDE( Cartera_Id )
go



CREATE NONCLUSTERED INDEX ixtesRengMovCiTMC ON tesRengMovi
( 
	Cartera_Id            ASC,
	TipomovCont           ASC
)
go



CREATE TABLE tesRengMovicomMovProv
( 
	tesMovimientos       bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	comMovProv           bigint  NULL ,
	CONSTRAINT XPKtesRengMoviMovProv PRIMARY KEY  CLUSTERED (tesMovimientos ASC,Renglon ASC)
)
go



CREATE TABLE tesRengMoviRetClie
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	SucursalRet          char(4)  NOT NULL ,
	ComprobanteRet       integer  NOT NULL ,
	BaseImponible        qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKtesRengMoviRetClie PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesRengMoviRetProv
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	Exencion             qPorcentaje ,
	BaseImponible        qMonedaD2 ,
	Acum                 qMonedaD2 ,
	TRet                 qMonedaD2 ,
	AcumTot              qMonedaD2 ,
	comMovProv           bigint  NULL ,
	CONSTRAINT XPKtesRengMoviRetProv PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesRetProvSegmento
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	conRenglon           integer  NULL ,
	CONSTRAINT XPKtesRetProvSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesRetProvSegmento ON tesRetProvSegmento
( 
	tesMovimientos        ASC,
	conRenglon            ASC
)
go



CREATE TABLE tesSolicitantes
( 
	genEntidades         bigint  NOT NULL ,
	Solicitante_Id       varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nombre               varchar(120)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Banco_Id             integer  NULL ,
	Cuenta               varchar(18)  NULL ,
	Usuario_Id           integer  NULL ,
	FechaCarga           qFechaHora ,
	CONSTRAINT XPKtesSolicitantes PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesSolicitantes ON tesSolicitantes
( 
	Solicitante_Id        ASC
)
go




exec sp_bindefault 'FechaHora_Actual', 'tesSolicitantes.FechaCarga'
go



CREATE TABLE tesSolicitud
( 
	tesSolicitud         bigint IDENTITY ( 1,1 ) ,
	Solicitante_Id       bigint  NULL ,
	Causa                varchar(max)  NOT NULL ,
	Fecha                qFechaHora ,
	Monto                qMonedaD2 ,
	Estado               char(1)  NOT NULL ,
	UsuarioAutorizo      integer  NULL ,
	FechaAutorizo        qFechaHora  NULL ,
	Usuario_Id           integer  NULL ,
	FechaCarga           qFechaHora ,
	Cartera_Id           integer  NOT NULL ,
	CONSTRAINT XPKtesSolicitud PRIMARY KEY  CLUSTERED (tesSolicitud ASC)
)
go




exec sp_bindefault 'FechaHora_Actual', 'tesSolicitud.FechaCarga'
go



CREATE TABLE tesSolPago
( 
	tesSolicitud         bigint  NOT NULL ,
	tesMovimientos       bigint  NOT NULL ,
	CONSTRAINT XPKtesSolPago PRIMARY KEY  CLUSTERED (tesSolicitud ASC,tesMovimientos ASC)
)
go



CREATE TABLE tesSolRendicion
( 
	tesMovimientos       bigint  NOT NULL ,
	tesSolicitud         bigint  NOT NULL ,
	CONSTRAINT XPKtesSolRendicion PRIMARY KEY  CLUSTERED (tesMovimientos ASC)
)
go



CREATE TABLE tesSolSegmentos
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	tesSolicitud         bigint  NULL ,
	CONSTRAINT XPKtesSolSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE tesSubTiposMov
( 
	tesSubTiposMov       integer IDENTITY ,
	SubTipo_Id           varchar(3)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	TipoMov              char(1)  NOT NULL ,
	CantCopias           smallint  NOT NULL ,
	genReportes          integer  NULL ,
	CONSTRAINT XPKtesSubTipos PRIMARY KEY  CLUSTERED (tesSubTiposMov ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesSubTiposMov ON tesSubTiposMov
( 
	SubTipo_Id            ASC
)
go



CREATE TABLE tesT3Link
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	tesTarjetas3         integer  NULL ,
	Secuencia            integer  NOT NULL ,
	Estado               char(1)  NULL ,
	CONSTRAINT XPKtesT3Link PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesT3Promociones
( 
	tesT3Promociones     integer IDENTITY ( 1,1 ) ,
	Promocion_Id         integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	VigenciaDesde        qFecha ,
	VigenciaHasta        qFecha ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKtesT3Promociones PRIMARY KEY  CLUSTERED (tesT3Promociones ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesT3Promociones ON tesT3Promociones
( 
	Promocion_Id          ASC
)
go



CREATE TABLE tesT3PromocionesCuotas
( 
	tesT3Promociones     integer  NOT NULL ,
	Cuota                integer  NOT NULL ,
	Coeficiente          qCantidadD8 ,
	CONSTRAINT XPKtesT3PromocionesCuotas PRIMARY KEY  CLUSTERED (tesT3Promociones ASC,Cuota ASC)
)
go



CREATE TABLE tesT3TerminalComercio
( 
	Terminal_Id          integer  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Comercio_Id          integer  NOT NULL ,
	CONSTRAINT XPKtesT3TerminalComercio PRIMARY KEY  CLUSTERED (Terminal_Id ASC,Cartera_Id ASC)
)
go



CREATE TABLE tesT3Terminales
( 
	tesT3Terminales      integer IDENTITY ( 1,1 ) ,
	Terminal_Id          integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Sucursal             integer  NULL ,
	Cartera_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKtesT3Terminales PRIMARY KEY  CLUSTERED (tesT3Terminales ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesT3Terminales ON tesT3Terminales
( 
	Terminal_Id           ASC
)
go



CREATE TABLE tesTarjetas3
( 
	tesTarjetas3         integer IDENTITY ( 1,1 ) ,
	Cartera_Id           integer  NULL ,
	Estado               char(1)  NULL ,
	Cuotas               integer  NOT NULL ,
	Cupon                integer  NOT NULL ,
	Lote                 integer  NOT NULL ,
	Comercio             integer  NOT NULL ,
	CONSTRAINT XPKtesTarjetas3 PRIMARY KEY  CLUSTERED (tesTarjetas3 ASC)
)
go



CREATE TABLE tesTarjetas3Estado
( 
	Estado               char(1)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	CONSTRAINT XPKtesTarjetas3Estado PRIMARY KEY  CLUSTERED (Estado ASC)
)
go



CREATE TABLE tesTarjetasPromociones
( 
	Cartera_Id           integer  NOT NULL ,
	Promocion_Id         integer  NOT NULL ,
	CONSTRAINT XPKtesTarjetasPromociones PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Promocion_Id ASC)
)
go



CREATE TABLE tesTiposId
( 
	tesTiposId           integer IDENTITY ( 1,1 ) ,
	TipoCartera          char(2)  NOT NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	FormaDePagoP         char(2)  NULL ,
	CONSTRAINT XPKtesTipos PRIMARY KEY  CLUSTERED (tesTiposId ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesTiposId ON tesTiposId
( 
	TipoCartera           ASC
)
go



CREATE TABLE venAsiCierre
( 
	Asiento_Id           bigint  NOT NULL ,
	Fecha                qFecha ,
	Moneda_Id            integer  NOT NULL ,
	CONSTRAINT XPKvenAsiCierre PRIMARY KEY  CLUSTERED (Asiento_Id ASC)
)
go



CREATE TABLE venAsiCierreCr
( 
	Asiento_Id           bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Cliente_Id           bigint  NOT NULL ,
	CONSTRAINT XPKvenAsiCierreCr PRIMARY KEY  CLUSTERED (Asiento_Id ASC,conRenglon ASC)
)
go



CREATE TABLE venCamiones
( 
	venCamiones          integer IDENTITY ( 1,1 ) ,
	Patente_Id           varchar(20)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	FormaEntrega_Id      integer  NULL ,
	CargaMaxima          qCantidadD8  NULL ,
	Tara                 qCantidadD8  NULL ,
	Marca                varchar(100)  NULL ,
	Inspeccion           qFecha  NULL ,
	EsAcoplado           Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	Posteado             Sino ,
	NroPoliza            varchar(30)  NULL ,
	NombreAseg           varchar(50)  NULL ,
	ConfVehicular        varchar(10)  NULL ,
	Modelo               integer  NULL ,
	TipoPermisoSCT       varchar(6)  NULL ,
	NroPermisoSCT        varchar(50)  NULL ,
	PropArre_Id          integer  NULL ,
	AseguraMedAmb        varchar(50)  NULL ,
	PolizaMedAmbiente    varchar(30)  NULL ,
	AseguraCarga         varchar(50)  NULL ,
	PolizaCarga          varchar(30)  NULL ,
	PrimaSeguro          numeric(18,2)  NULL ,
	CONSTRAINT XPKvenCamiones PRIMARY KEY  CLUSTERED (venCamiones ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venCamiones ON venCamiones
( 
	Patente_Id            ASC
)
go



CREATE TABLE venCanjeNotas
( 
	venMovimientos       bigint  NOT NULL ,
	venMovimientosNC     bigint  NOT NULL ,
	venMovimientosFC     bigint  NOT NULL ,
	CONSTRAINT XPKvenCangeNotas PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE NONCLUSTERED INDEX XIE1venCangeNotas ON venCanjeNotas
( 
	venMovimientosNC      ASC
)
go



CREATE NONCLUSTERED INDEX XIE2venCangeNotas ON venCanjeNotas
( 
	venMovimientosFC      ASC
)
go



CREATE TABLE venCartaPorteFact
( 
	venMovimientosFactCP bigint  NOT NULL ,
	venMovimientosFact   bigint  NULL ,
	CONSTRAINT XPKvenCartaPorteFact PRIMARY KEY  CLUSTERED (venMovimientosFactCP ASC)
)
go



CREATE TABLE venCategCredito
( 
	venCategCredito      integer IDENTITY ,
	CategCred_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	MaxDiasAtraso        smallint  NOT NULL ,
	PorcenDeudaVenci     qPorcentaje ,
	TipoCredito          numeric(1,0)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKclicredito PRIMARY KEY  CLUSTERED (venCategCredito ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venCategCredito ON venCategCredito
( 
	CategCred_Id          ASC
)
go



CREATE TABLE venCFDISat
( 
	UUID                 varchar(36)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	RFCReceptor          varchar(13)  NOT NULL ,
	Fecha                qFechaHora ,
	Monto                qMonedaD2 ,
	Impuestos            qMonedaD2 ,
	Folio                bigint  NOT NULL ,
	Serie                varchar(100)  NOT NULL ,
	XML                  QMemo ,
	Usuario              integer  NOT NULL ,
	FechaCarga           qFechaHora ,
	TipoComprobante      char(1)  NOT NULL ,
	CONSTRAINT XPKvenCFDISat PRIMARY KEY  CLUSTERED (UUID ASC)
)
go



CREATE TABLE venClieContacto
( 
	Cliente_Id           bigint  NOT NULL ,
	Sucursal             SucursalN 
	CONSTRAINT Cero_234624761
		 DEFAULT  0,
	NroContacto          integer  NOT NULL ,
	Nombre               varchar(120)  NOT NULL ,
	Puesto               varchar(100)  NOT NULL ,
	Email                varchar(120)  NOT NULL ,
	Telefono             varchar(30)  NOT NULL ,
	Interno              varchar(20)  NOT NULL ,
	Movil                varchar(30)  NOT NULL ,
	EnviaFacturas        Sino ,
	EnviaRecibo          Sino ,
	EnviaPedido          Sino ,
	Observaciones        varchar(max)  NULL ,
	Inactivo             Sino ,
	CONSTRAINT XPKvenClieContacto PRIMARY KEY  CLUSTERED (Cliente_Id ASC,Sucursal ASC,NroContacto ASC)
)
go



CREATE TABLE venClieEstados
( 
	venClieEstados       integer IDENTITY ,
	Estado_Id            varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Reservado            Sino ,
	ImpideOperaciones    Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvenClieEstados PRIMARY KEY  CLUSTERED (venClieEstados ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venClieEstados ON venClieEstados
( 
	Estado_Id             ASC
)
go



CREATE TABLE venClieHabitual
( 
	genEntidades         bigint  NOT NULL ,
	Sucursal             SucursalN  NOT NULL ,
	NombreFantasia       varchar(120)  NOT NULL ,
	Direccion1_Fact      varchar(50)  NOT NULL ,
	Direccion2_Fact      varchar(50)  NOT NULL ,
	Localidad_Fact       varchar(35)  NOT NULL ,
	CodPostal_Fact       CodigoPostal  NOT NULL ,
	Provincia_Id_Fact    integer  NULL ,
	Pais_Id_Fact         integer  NULL ,
	Telefonos            varchar(100)  NOT NULL ,
	Fax                  varchar(50)  NOT NULL ,
	EMail                varchar(50)  NOT NULL ,
	Direccion1_Entr      varchar(50)  NOT NULL ,
	Direccion2_Entr      varchar(50)  NOT NULL ,
	Localidad_Entr       varchar(35)  NOT NULL ,
	CodPostal_Entr       CodigoPostal  NOT NULL ,
	Provincia_Id_Entr    integer  NULL ,
	Pais_Id_Entr         integer  NULL ,
	TipoClie_Id          integer  NULL ,
	ListaPrecio_Id       integer  NULL ,
	FormaEntrega_Id      integer  NULL ,
	CondPagoCli_Id       integer  NULL ,
	Vendedor_Id          bigint  NULL ,
	Cobrador_Id          bigint  NULL ,
	Zona_Id              integer  NULL ,
	Region_Id            integer  NULL ,
	Contactos            varchar(50)  NOT NULL ,
	Usuario_Id_Alta      integer  NOT NULL ,
	FechaAlta            qFecha ,
	FechaUltContacto     qFecha ,
	FechaModificacion    qFecha ,
	Observaciones        QMemo  NULL ,
	Bonificacion1        qPorcentaje ,
	Bonificacion2        qPorcentaje ,
	Bonificacion3        qPorcentaje ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	ClieConsolida        bigint  NULL ,
	NroExterior_Fact     varchar(10)  NOT NULL ,
	NroInterior_Fact     varchar(10)  NOT NULL ,
	NroExterior_Entr     varchar(10)  NOT NULL ,
	NroInterior_Entr     varchar(10)  NOT NULL ,
	Reclamos             varchar(150)  NOT NULL ,
	MetodoDePago         varchar(50)  NOT NULL ,
	NumCuenta            varchar(150)  NOT NULL ,
	C_UsoCFDI            varchar(3)  NULL ,
	N_MetodoPago         varchar(3)  NULL ,
	UsaComplementoINE    Sino  NULL ,
	Inactivo             Sino ,
	LatitudGPS           numeric(19,13)  NULL ,
	LongitudGPS          numeric(19,13)  NULL ,
	c_ColoniaEntr        varchar(4)  NULL ,
	c_LocalidadEntr      varchar(4)  NULL ,
	c_MunicipioEntr      varchar(3)  NULL ,
	CONSTRAINT XPKvenClientes PRIMARY KEY  CLUSTERED (genEntidades ASC,Sucursal ASC)
)
go



CREATE TABLE venClientes
( 
	genEntidades         bigint  NOT NULL ,
	Cliente_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	SucursalPredeter     SucursalN  NOT NULL ,
	CondFisc_Id          integer  NULL ,
	LimiteCredito        qMonedaD2 ,
	MonedaLimCred        integer  NULL ,
	CategCred_Id         integer  NULL ,
	Bonificacion1        qPorcentaje ,
	Bonificacion2        qPorcentaje ,
	Bonificacion3        qPorcentaje ,
	Puntual              Sino ,
	Estado_Id            integer  NULL ,
	GeneraDebito         Sino ,
	Siempre              Sino ,
	CongelaCambio        Sino ,
	IBrutos              varchar(20)  NOT NULL ,
	Situacion            char(1)  NOT NULL ,
	Posteado             Sino ,
	FacturaCredito       Sino  NULL ,
	MontoFacturaCredito  qMonedaD2  NULL ,
	CbuBanco             varchar(22)  NULL ,
	CONSTRAINT XPKE_568 PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venClientes ON venClientes
( 
	Cliente_Id            ASC
)
go



CREATE TABLE venClientesCtas
( 
	Cliente_Id           bigint  NOT NULL ,
	Moneda_Id            integer  NOT NULL ,
	CuentaDxVtas         integer  NULL ,
	CtaFactAnticipo      integer  NULL ,
	CtaAnticipo          integer  NULL ,
	CONSTRAINT XPKvenClientesCtas PRIMARY KEY  CLUSTERED (Cliente_Id ASC,Moneda_Id ASC)
)
go



CREATE TABLE venCobradores
( 
	venCobradores        bigint  NOT NULL ,
	Cobrador_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nombre               varchar(35)  NOT NULL ,
	Comision             qPorcentaje ,
	LimiteComision       qMonedaD2 ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvenCobradores PRIMARY KEY  CLUSTERED (venCobradores ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venCobradores ON venCobradores
( 
	Cobrador_Id           ASC
)
go



CREATE TABLE venCompCartaPorte
( 
	venMovimientos       bigint  NOT NULL ,
	TranspInternac       varchar(2)  NOT NULL ,
	EntradaSalidaMerc    varchar(7)  NOT NULL ,
	ViaEntradaSalida     varchar(2)  NOT NULL ,
	TotalDistRec         numeric(5,2)  NOT NULL ,
	PesoBrutoTotal       numeric(18,3)  NOT NULL ,
	UnidadPeso           varchar(5)  NOT NULL ,
	PesoNetoTotal        numeric(18,3)  NOT NULL ,
	CargoPorTasacion     numeric(18,3)  NOT NULL ,
	Camion_Id            integer  NULL ,
	Remolque1            integer  NULL ,
	Remolque2            integer  NULL ,
	Operador_Id          integer  NULL ,
	CONSTRAINT XPKvenCompCartaPorte PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venCompCartaPorteDestinatario
( 
	venMovimientos       bigint  NOT NULL ,
	NumRegIdTrib         varchar(60)  NULL ,
	Nombre               varchar(300)  NULL ,
	Calle                varchar(100)  NOT NULL ,
	NumeroExterior       varchar(30)  NULL ,
	Numerointerior       varchar(30)  NULL ,
	Colonia              varchar(120)  NULL ,
	Localidad            varchar(120)  NULL ,
	Referencia           varchar(100)  NULL ,
	Municipio            varchar(120)  NULL ,
	Estado               varchar(30)  NULL ,
	Pais                 integer  NULL ,
	CodigoPostal         varchar(20)  NULL ,
	CONSTRAINT XPKvenCompCartaPorteDestinatario PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venCompCartaPorteDestino
( 
	venMovimientos       bigint  NOT NULL ,
	Ubicacion            integer  NOT NULL ,
	idDestino            integer  NOT NULL ,
	RFCDestinatario      varchar(14)  NULL ,
	NombreDestinatario   varchar(254)  NULL ,
	NumRegIdTrib         varchar(40)  NULL ,
	ResidenciaFiscal     integer  NULL ,
	NumEstacion          varchar(6)  NULL ,
	NombreEstacion       varchar(50)  NULL ,
	NavegacionTrafico    varchar(8)  NULL ,
	FechaHoraProgLlegada qFechaHora ,
	Calle                varchar(20)  NOT NULL ,
	NumeroExterior       varchar(30)  NULL ,
	Numerointerior       varchar(30)  NULL ,
	Colonia              varchar(120)  NULL ,
	Localidad            varchar(120)  NULL ,
	Referencia           varchar(100)  NULL ,
	Municipio            varchar(120)  NULL ,
	Estado               varchar(30)  NULL ,
	Pais                 integer  NULL ,
	CodigoPostal         varchar(20)  NULL ,
	CONSTRAINT XPKvenCompCartaPorteDestino PRIMARY KEY  CLUSTERED (venMovimientos ASC,Ubicacion ASC)
)
go



CREATE TABLE venCompCartaPorteMercancia
( 
	venMovimientos       bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	idDestino            integer  NOT NULL ,
	BienesTransp         varchar(10)  NULL ,
	ClaveSTCC            varchar(10)  NULL ,
	Descripcion          varchar(1000)  NULL ,
	Cantidad             numeric(18,6)  NOT NULL ,
	Medida_id            integer  NULL ,
	Dimensiones          varchar(20)  NULL ,
	MaterialPeligroso    varchar(2)  NULL ,
	CveMaterialPeligroso varchar(6)  NULL ,
	Embalaje             varchar(6)  NULL ,
	DescripEmbalaje      varchar(100)  NULL ,
	PesoEnKg             numeric(18,3)  NOT NULL ,
	ValorMercancia       numeric(18,2)  NOT NULL ,
	FraccionArancelaria  varchar(20)  NULL ,
	UUIDComercioExt      varchar(36)  NULL ,
	CONSTRAINT XPKvenCompCartaPorteMercancia PRIMARY KEY  CLUSTERED (venMovimientos ASC,Renglon ASC)
)
go



CREATE TABLE venCompCartaPorteOrigen
( 
	venMovimientos       bigint  NOT NULL ,
	Ubicacion            integer  NOT NULL ,
	idOrigen             integer  NOT NULL ,
	RFCRemitente         varchar(14)  NULL ,
	NombreRemitente      varchar(254)  NULL ,
	NumRegIdTrib         varchar(40)  NULL ,
	ResidenciaFiscal     integer  NULL ,
	NumEstacion          varchar(6)  NULL ,
	NombreEstacion       varchar(50)  NULL ,
	NavegacionTrafico    varchar(8)  NULL ,
	FechaHoraSalida      qFechaHora ,
	Calle                varchar(100)  NOT NULL ,
	NumeroExterior       varchar(30)  NULL ,
	Numerointerior       varchar(30)  NULL ,
	Colonia              varchar(120)  NULL ,
	Localidad            varchar(120)  NULL ,
	Referencia           varchar(120)  NULL ,
	Municipio            varchar(120)  NULL ,
	Estado               varchar(30)  NULL ,
	Pais                 integer  NULL ,
	CodigoPostal         varchar(20)  NULL ,
	CONSTRAINT XPKvenCompCartaPorteOrigen PRIMARY KEY  CLUSTERED (venMovimientos ASC,Ubicacion ASC)
)
go



CREATE TABLE venCompCartaPorteUbi
( 
	venMovimientos       bigint  NOT NULL ,
	Ubicacion            integer  NOT NULL ,
	TipoEstacion         varchar(2)  NULL ,
	DistanciaRecorrida   numeric(5,2)  NOT NULL ,
	CONSTRAINT XPKvenCompCartaPorteUbi PRIMARY KEY  CLUSTERED (venMovimientos ASC,Ubicacion ASC)
)
go



CREATE TABLE venCondFiscal
( 
	venCondFiscal        integer IDENTITY ,
	CondFisc_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Letra                char(1)  NOT NULL ,
	AplicaFactCredito    Sino ,
	Letra_Rf             char(1)  NOT NULL ,
	Discrimina           Sino ,
	FacturaElectronica   Sino ,
	CodigoFiscal         varchar(3)  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvenCondFiscal PRIMARY KEY  CLUSTERED (venCondFiscal ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venCondFiscal ON venCondFiscal
( 
	CondFisc_Id           ASC
)
go



CREATE TABLE venCondFiscImp
( 
	venCondFiscal        integer  NOT NULL ,
	venImpuestos         integer  NOT NULL ,
	CONSTRAINT XPKvenCondFiscImp PRIMARY KEY  CLUSTERED (venCondFiscal ASC,venImpuestos ASC)
)
go



CREATE TABLE venCondPago
( 
	venCondPago          integer IDENTITY ,
	CondPagoCli_Id       varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	CantCuotas           smallint  NOT NULL ,
	TipoVencimiento      char(2)  NOT NULL ,
	Dias                 int  NOT NULL ,
	DiasVencimiento      smallint  NOT NULL ,
	DiasDescFinanc       smallint  NOT NULL ,
	DescFinanc           qPorcentaje ,
	ImpPrimCuota         Sino ,
	EditaCuotas          Sino ,
	FactCredito          Sino ,
	TipoFiscal           varchar(5)  NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKclicondiciones PRIMARY KEY  CLUSTERED (venCondPago ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venCondPago ON venCondPago
( 
	CondPagoCli_Id        ASC
)
go



CREATE TABLE venCondPagoCuotas
( 
	CondPagoCli_Id       integer  NOT NULL ,
	Renglon              int  NOT NULL ,
	Dias                 int  NULL ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKVenCondPagoCuotas PRIMARY KEY  CLUSTERED (CondPagoCli_Id ASC,Renglon ASC)
)
go



CREATE TABLE venCotizaciones
( 
	venCotizaciones      integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	SubTipoMov_Id        integer  NOT NULL ,
	Fecha                qFecha ,
	Cliente_Id           bigint  NULL ,
	Sucursal             SucursalN  NULL 
	CONSTRAINT Cero_922999301
		 DEFAULT  0,
	Moneda_Id            integer  NULL ,
	MonedaFacturacion    integer  NULL ,
	CondPagoCli_Id       integer  NULL ,
	ListaPrecio_Id       integer  NULL ,
	Vendedor_Id          bigint  NULL ,
	FormaEntrega_Id      integer  NULL ,
	Estado               char(1)  NULL ,
	UsuarioAutoriz_Id    integer  NULL ,
	FechaAutorizo        qFechaHora  NULL ,
	Observaciones        QMemo ,
	ObservEstado         QMemo ,
	Motivo_Id            smallint  NULL ,
	ImporteTotal         qMonedaD2 ,
	Bonificacion1        qMonedaD2 ,
	Bonificacion2        qMonedaD2 ,
	Bonificacion3        qMonedaD2 ,
	Bonificacion4        qMonedaD2 ,
	Bonificacion5        qMonedaD2 ,
	Dato1                qMonedaD2 ,
	Dato2                qMonedaD2 ,
	Dato3                qMonedaD2 ,
	FechaUltMod          qFechaHora ,
	CliOrdenCompra       varchar(15)  NULL ,
	venNroPedido         varchar(15)  NULL ,
	FacturaAnticipo      Sino ,
	TrabaDespacho        Sino ,
	PorAnticipo          qPorcentaje ,
	Anticipo             qMonedaD2 ,
	AnticipoPendiente    qMonedaD2 ,
	ObsAnticipo          QMemo ,
	TipoPrecioForm       char(1)  NULL ,
	CongelaCambio        Sino ,
	Fecha_Registro       qFechaHora ,
	Cambio               qMonedaD8 ,
	Incoterm_Id          integer  NULL ,
	SoloEntrega          Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	MetodoPago           varchar(3)  NULL ,
	UsoCfdi              varchar(3)  NULL ,
	ClienteExistente     Sino ,
	Vigencia             qFecha  NOT NULL ,
	CONSTRAINT XPKvenCotizaciones PRIMARY KEY  CLUSTERED (venCotizaciones ASC)
)
go



CREATE TABLE venCotizAnul
( 
	Cotizacion_Id        integer  NOT NULL ,
	Fecha                qFechaHora ,
	Operacion            char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenCotizAnul PRIMARY KEY  CLUSTERED (Cotizacion_Id ASC)
)
go



CREATE TABLE venCotizCliente
( 
	Cotizacion_Id        integer  NOT NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	Direccion1           varchar(50)  NOT NULL ,
	Direccion2           varchar(50)  NOT NULL ,
	NroExterior          varchar(10)  NOT NULL ,
	NroInterior          varchar(10)  NOT NULL ,
	Localidad            varchar(35)  NOT NULL ,
	CodigoPostal         varchar(15)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Pais_Id              integer  NULL ,
	Telefono             varchar(100)  NOT NULL ,
	CUIT                 varchar(25)  NOT NULL ,
	Email                varchar(50)  NOT NULL ,
	CONSTRAINT XPKvenCotizCliente PRIMARY KEY  CLUSTERED (Cotizacion_Id ASC)
)
go



CREATE TABLE venCotizCuerpo
( 
	Cotizacion_Id        integer  NOT NULL ,
	Renglon_Co           integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Medida_Id            integer  NULL ,
	Deposito_Id          integer  NULL ,
	Factor               qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	CantidadPedida       qCantidadD8 ,
	CantidadRemitida     qCantidadD8 ,
	CantidadFacturada    qCantidadD8 ,
	PrecioForm           qMonedaD8 ,
	PrecioLista          qMonedaD8 ,
	PrecioVenta          qMonedaD8 ,
	FechaEntrega         qFecha ,
	Especial             Sino ,
	Bonificacion         qPorcentaje ,
	Observaciones        QMemo ,
	Pendiente            Sino ,
	ReservaMercaderia    Sino ,
	PrecioListaForm      qMonedaD8 ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	TipoPrecio           char(1)  NOT NULL ,
	CONSTRAINT XPKvenCotizCuerpo PRIMARY KEY  CLUSTERED (Cotizacion_Id ASC,Renglon_Co ASC)
)
go



CREATE TABLE venCotizFactuCuerpo
( 
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	venCotizaciones      integer  NULL ,
	Renglon_Co           integer  NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKvenCotizFactuCuerpo PRIMARY KEY  CLUSTERED (venMovimientos ASC,RenglonCuerpo ASC)
)
go



CREATE TABLE venCotizFactura
( 
	venMovimientos       bigint  NOT NULL ,
	venCotizaciones      integer  NULL ,
	CONSTRAINT XPKvenCotizFactura PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venCotizPediCuerpo
( 
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	venCotizaciones      integer  NULL ,
	Renglon_Co           integer  NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKvenCotizPediCuerpo PRIMARY KEY  CLUSTERED (venPedidos ASC,Renglon_Pe ASC)
)
go



CREATE TABLE venCotizPedidos
( 
	Cotizacion_Id        integer  NOT NULL ,
	Pedido_Id            integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKvenCotizPedidos PRIMARY KEY  CLUSTERED (Cotizacion_Id ASC,Pedido_Id ASC)
)
go



CREATE TABLE venCotizSegmento
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	venCotizaciones      integer  NULL ,
	CONSTRAINT XPKvenCotizSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE venEsquemaAuto
( 
	venEsquemaAuto       integer IDENTITY ( 1,1 ) ,
	EsquemaAuto_Id       varchar(10)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	CONSTRAINT XPKvenEsquemaAuto PRIMARY KEY  CLUSTERED (venEsquemaAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venEsquemaAuto ON venEsquemaAuto
( 
	EsquemaAuto_Id        ASC
)
go



CREATE TABLE venEsquemaAutoReng
( 
	EsquemaAuto_Id       integer  NOT NULL ,
	Orden                integer  NOT NULL ,
	Formula              varchar(max)  NOT NULL ,
	NivelAuto_Id         integer  NULL ,
	CONSTRAINT XPKvenEsquemaAutoReng PRIMARY KEY  CLUSTERED (EsquemaAuto_Id ASC,Orden ASC)
)
go



CREATE TABLE venFormaEntrega
( 
	venFormaEntrega      integer IDENTITY ,
	FormaEntrega_Id      varchar(3)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	RazonSocial          varchar(35)  NOT NULL ,
	Direccion            varchar(35)  NOT NULL ,
	Localidad            varchar(35)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Pais_Id              integer  NULL ,
	Telefono             varchar(35)  NOT NULL ,
	Cuit                 qCuit ,
	CondFisc_Id          integer  NULL ,
	Seguro               money  NOT NULL ,
	Contacto             varchar(20)  NOT NULL ,
	Cargo                varchar(20)  NOT NULL ,
	Email                varchar(80)  NULL ,
	ExcluirDelReparto    Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	UsaCartaPorte        Sino ,
	CONSTRAINT XPKcliexpresos PRIMARY KEY  CLUSTERED (venFormaEntrega ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venFormaEntrega ON venFormaEntrega
( 
	FormaEntrega_Id       ASC
)
go



CREATE TABLE venImpuestos
( 
	venImpuestos         integer IDENTITY ,
	Impuesto_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	TipoImpuesto         integer  NULL ,
	CodigoFiscal         varchar(20)  NULL ,
	UsaFormula           Sino ,
	Formulacalc          varchar(max)  NOT NULL ,
	Porcentaje           qPorcentaje ,
	Fecha_Desde          qFecha ,
	Fecha_Hasta          qFecha  NULL ,
	Depende_de           varchar(1)  NOT NULL ,
	PorVencimiento       Sino ,
	CtaReversion         integer  NULL ,
	Cuenta_Id            integer  NULL ,
	CtaDifCambio         integer  NULL ,
	ImpuestoXProducto    Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKCliImpuestos PRIMARY KEY  CLUSTERED (venImpuestos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venImpuestos ON venImpuestos
( 
	Impuesto_Id           ASC
)
go



CREATE TABLE venIncoterm
( 
	venIncoterm_int      integer IDENTITY ,
	Incoterm_Id          char(3)  NOT NULL ,
	Descripcion          varchar(65)  NOT NULL ,
	CONSTRAINT XPKvenIncoterm PRIMARY KEY  CLUSTERED (venIncoterm_int ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venIncoterm ON venIncoterm
( 
	Incoterm_Id           ASC
)
go



CREATE TABLE venLibros
( 
	venLibros            integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NULL ,
	Libro_Id             varchar(10)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	CONSTRAINT XPKvenLibro PRIMARY KEY  CLUSTERED (venLibros ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venLibro ON venLibros
( 
	Libro_Id              ASC,
	Empresa_Id            ASC
)
go



CREATE TABLE venLibrosColumnas
( 
	venLibros            integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Titulo               varchar(20)  NOT NULL ,
	CONSTRAINT XPKvenLibrosColumnas PRIMARY KEY  CLUSTERED (venLibros ASC,Columna ASC)
)
go



CREATE TABLE venLibrosImpuestos
( 
	venLibros            integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	TipoRenglon          char(2)  NOT NULL ,
	CONSTRAINT XPKvenLibrosImpuestos PRIMARY KEY  CLUSTERED (venLibros ASC,Columna ASC,Impuesto_Id ASC,TipoRenglon ASC)
)
go



CREATE TABLE venLibrosRetencion
( 
	venLibros            integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	CONSTRAINT XPKvenLibrosRetencion PRIMARY KEY  CLUSTERED (venLibros ASC,Columna ASC,Cartera_Id ASC)
)
go



CREATE TABLE venListasPrecBoniRec
( 
	ListaPrecio_Id       integer  NOT NULL ,
	NroBonifRecargo      smallint  NOT NULL ,
	Nombre               varchar(20)  NOT NULL ,
	Formula              qFormula ,
	UsaCtasProducto      Sino ,
	CtaBonificacion      integer  NULL ,
	CtaRecargo           integer  NULL ,
	CONSTRAINT XPKvenListasPrecBoniRec PRIMARY KEY  CLUSTERED (ListaPrecio_Id ASC,NroBonifRecargo ASC)
)
go



CREATE TABLE venListasPrecios
( 
	venListasPrecios     integer IDENTITY ,
	ListaPrecio_Id       varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Moneda_Id            integer  NULL ,
	LlevaImpuestoInclu   Sino ,
	UsuAutorizado        integer  NULL ,
	DecimalesPu          integer  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKclilistaprecios PRIMARY KEY  CLUSTERED (venListasPrecios ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venListasPrecios ON venListasPrecios
( 
	ListaPrecio_Id        ASC
)
go



CREATE TABLE venListasPrecProd
( 
	ListaPrecio_Id       integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Version              integer  NOT NULL ,
	PrecioLista          qMonedaD4 ,
	PrecioPromocion      qMonedaD4 ,
	AdmiteRegalo         Sino ,
	CONSTRAINT XPKvenListasPrecPr PRIMARY KEY  CLUSTERED (ListaPrecio_Id ASC,Producto_Id ASC,Version ASC)
)
go



CREATE NONCLUSTERED INDEX vstkProductosVenIX ON venListasPrecProd
( 
	Producto_Id           ASC
)
INCLUDE( PrecioLista )
go



CREATE TABLE venListasVersion
( 
	ListaPrecio_Id       integer  NOT NULL ,
	Version              integer  NOT NULL ,
	VigenciaDesde        qFecha ,
	VigenciaHasta        qFecha ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenListasVersion PRIMARY KEY  CLUSTERED (ListaPrecio_Id ASC,Version ASC)
)
go



CREATE TABLE venLPTabCuerpo
( 
	Tabla_Id             integer  NOT NULL ,
	Hasta                numeric(18,2)  NOT NULL ,
	Valor                numeric(18,2)  NOT NULL ,
	CONSTRAINT XPKvenLPTabCuerpo PRIMARY KEY  CLUSTERED (Tabla_Id ASC,Hasta ASC)
)
go



CREATE TABLE venLPTabla
( 
	Tabla_Id             integer  NOT NULL ,
	Descripcion          varchar(120)  NOT NULL ,
	CONSTRAINT XPKvenLPTabla PRIMARY KEY  CLUSTERED (Tabla_Id ASC)
)
go



CREATE TABLE venMovConforma
( 
	venMovimientos       bigint  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaConforma        datetime  NOT NULL ,
	FechaRegistro        qFechaHora ,
	Observaciones        QMemo ,
	CONSTRAINT XPKvenMovConforma PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go




exec sp_bindefault 'FechaHora_Actual', 'venMovConforma.FechaRegistro'
go



CREATE TABLE venMovConStock
( 
	venMovimientos       bigint  NOT NULL ,
	ListaPrecio_Id       integer  NOT NULL ,
	TipoPrecioForm       char(1)  NOT NULL ,
	CONSTRAINT XPKvenMovConStock PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMovConStockCr
( 
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Deposito_Id          integer  NULL ,
	Medida_Id            integer  NULL ,
	Factor               qCantidadD8 ,
	CantFacturada        qCantidadD8 ,
	CantEntregada        qCantidadD8 ,
	CantPendiente        qCantidadD8 ,
	CantOriginal         qCantidadD8 ,
	MedidaAlterna        integer  NULL ,
	CantEntregadaForm    qCantidadD8 ,
	CantidadAlternaForm  qCantidadD8 ,
	TipoPrecio           char(1)  NOT NULL ,
	PrecioForm           qMonedaD8 ,
	PrecioSinIva         qMonedaD8 ,
	PrecioLista          qMonedaD8 ,
	PrecioVenta          qMonedaD8 ,
	PrecioFormImpuesto   qMonedaD8 ,
	PrecioFormImpuestoBon qMonedaD8 ,
	PrecioFormImpuestoTot qMonedaD8 ,
	ComiPorce            qPorcentaje ,
	Bonificacion         qPorcentaje ,
	Observaciones        QMemo  NULL ,
	FechaEntrega         qFecha ,
	SubTotal             qMonedaD2 ,
	SubTotalFormImpuesto qMonedaD2 ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	CONSTRAINT XPKvenMovConStockC PRIMARY KEY  CLUSTERED (venMovimientos ASC,RenglonCuerpo ASC)
)
go



CREATE INDEX XIE1venMovConStockCr ON venMovConStockCr
( 
	CantPendiente         ASC
)
go



CREATE TABLE venMovConStockCrCtas
( 
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	CONSTRAINT XPKvenMovConStockCrCtas PRIMARY KEY  CLUSTERED (venMovimientos ASC,RenglonCuerpo ASC,Renglon ASC)
)
go



CREATE TABLE venMovConStockCrPed
( 
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	venReparto           integer  NULL ,
	CONSTRAINT XPKvenMovConStockCrPed PRIMARY KEY  CLUSTERED (venPedidos ASC,Renglon_Pe ASC,venMovimientos ASC,RenglonCuerpo ASC)
)
go



CREATE TABLE venMovCSImpuestos
( 
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Importe              qMonedaD2 ,
	ImporteMonedaNac     qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	BaseImponible        qMonedaD2 ,
	BaseImponibleMonedaNac qMonedaD2 ,
	CONSTRAINT XPKvenMovCSImpuestos PRIMARY KEY  CLUSTERED (venMovimientos ASC,RenglonCuerpo ASC,Impuesto_Id ASC)
)
go



CREATE TABLE venMovDetalle
( 
	venMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Detalle              QMemo  NOT NULL ,
	CFVenta_Id           integer  NULL ,
	Cantidad             qMonedaD8 ,
	Medida_Id            integer  NULL ,
	ImporteUnitario      qMonedaD8 ,
	SubTotal             qMonedaD2 ,
	ImporteUnitarioDelImpuesto qMonedaD8 ,
	SubTotalFormImpuesto qMonedaD2 ,
	CodigoFiscal         varchar(20)  NULL ,
	Producto_Id          varchar(25)  NULL ,
	CONSTRAINT XPKvenMovDetalle PRIMARY KEY  CLUSTERED (venMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE venMoviAnticipo
( 
	venMovimientos       bigint  NOT NULL ,
	Porcentaje           qPorcentaje ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKvenMoviAnticipo PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMoviCompAsoc
( 
	venMoviAsociado      bigint  NOT NULL ,
	venMoviFactura       bigint  NOT NULL ,
	CONSTRAINT XPKvenMoviCompAsoc PRIMARY KEY  CLUSTERED (venMoviAsociado ASC)
)
go



CREATE TABLE venMovimientos
( 
	venMovimientos       bigint  NOT NULL ,
	Cliente_Id           bigint  NULL ,
	Sucursal             SucursalN  NULL ,
	venSubTipoMov_Id     integer  NULL ,
	venTipoMov           char(1)  NOT NULL ,
	CondPagoCli_Id       integer  NULL ,
	Vendedor_Id          bigint  NULL ,
	Cobrador_Id          bigint  NULL ,
	FormaEntrega_Id      integer  NULL ,
	CondFisc_Id          integer  NULL ,
	Importe              qMonedaD2 ,
	Saldo                qMonedaD2 ,
	SubTotal             qMonedaD2 ,
	SubTotalBonif        qMonedaD2 ,
	Comision1            numeric(6,2)  NOT NULL ,
	Comision2            numeric(6,2)  NOT NULL ,
	Bonificacion1        qMonedaD2 ,
	Bonificacion2        qMonedaD2 ,
	Bonificacion3        qMonedaD2 ,
	Bonificacion4        qMonedaD2 ,
	Bonificacion5        qMonedaD2 ,
	Dato1                qMonedaD4 ,
	Dato2                qMonedaD4 ,
	Dato3                qMonedaD4 ,
	CobraAbasto          Sino ,
	CambioFijo           Sino ,
	ComprobanteDesde     int  NULL ,
	TipoPago             integer  NOT NULL ,
	Incoterm_Id          integer  NULL ,
	CONSTRAINT XPKvenMovimientos PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMovimientosCFDIR
( 
	venMovimientos       bigint  NOT NULL ,
	venMovimientosR      bigint  NOT NULL ,
	TipoRelacion         char(2)  NULL ,
	CONSTRAINT XPKvenMovimientosCFDIR PRIMARY KEY  CLUSTERED (venMovimientos ASC,venMovimientosR ASC)
)
go



CREATE TABLE venMovimientosCRExpMx
( 
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	CantidadAduana       numeric(18,3)  NOT NULL ,
	UnidadAduana         varchar(2)  NOT NULL ,
	ValorUnitarioAduana  qMonedaD2 ,
	ValorDolares         qMonedaD2 ,
	CONSTRAINT XPKvenMovimientosCRE PRIMARY KEY  CLUSTERED (venMovimientos ASC,RenglonCuerpo ASC)
)
go



CREATE TABLE venMovimientosExpMX
( 
	venMovimientos       bigint  NOT NULL ,
	Motivo_id            varchar(2)  NULL ,
	TipoOperacion        char(1)  NOT NULL ,
	ClaveDePedimento     char(2)  NOT NULL ,
	CertificadoOrigen    integer  NOT NULL ,
	NumCertificadoOrigen varchar(40)  NULL ,
	NumeroExportadorConfiable varchar(50)  NULL ,
	Subdivision          integer  NOT NULL ,
	Observaciones        varchar(20)  NULL ,
	TipoCambioUSD        qMonedaD4  NULL ,
	TotalUSD             qMonedaD2  NULL ,
	UsaProv              Sino ,
	PropNumRegIdTrib     varchar(20)  NULL ,
	PropResidenciaFiscal char(3)  NULL ,
	ReceptorNumRegIdTrib varchar(40)  NULL ,
	Destinatario_id      bigint  NULL ,
	SucursalDest         SucursalN  NULL 
	CONSTRAINT Cero_169694040
		 DEFAULT  0,
	CONSTRAINT XPKvenMovimimientosExpMX PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMovimientosFiscal
( 
	venMovimientos       bigint  NOT NULL ,
	ClaveFiscal          varchar(36)  NULL ,
	Fecha                qFecha  NULL ,
	Letra                char(1)  NULL ,
	Comprobante_Id       integer  NULL ,
	EsFactElec           Sino  NULL ,
	Motivo               QMemo ,
	XMLFiscal            text  NULL ,
	SelloDigital         varchar(max)  NULL ,
	FechaString          varchar(20)  NULL ,
	SelloFiscal          varchar(max)  NULL ,
	NoCertificadoFiscal  varchar(20)  NULL ,
	NoCertificadoPropio  varchar(20)  NULL ,
	FechaAutorizacion    qFecha  NULL ,
	FechaDesde           qFecha  NULL ,
	NumeroDesde          integer  NULL ,
	NumeroHasta          integer  NULL ,
	RfcProvCertif        varchar(13)  NULL ,
	Leyenda              varchar(50)  NULL ,
	TipoProceso          varchar(10)  NULL ,
	TipoComite           varchar(18)  NULL ,
	idContabilidad       numeric(6,0)  NOT NULL ,
	Acuse                varchar(max)  NULL ,
	CONSTRAINT XPKvenMovimientosFiscal PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMovimientosFiscalINE
( 
	venMovimientos       bigint  NOT NULL ,
	ClaveIdentidad       varchar(3)  NOT NULL ,
	idContabilidad       numeric(6,0)  NOT NULL ,
	Ambito               varchar(9)  NULL ,
	CONSTRAINT XPKvenMovimientosFiscalINE PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMovimientosMetodoPago
( 
	venMovimientos       bigint  NOT NULL ,
	MetodoPago           varchar(50)  NULL ,
	CuentaPago           varchar(150)  NULL ,
	NMetodoPago          varchar(3)  NULL ,
	UsoCfdi              char(3)  NULL ,
	CONSTRAINT XPKvenMovimientosMetodoPago PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venMovImpTraslado
( 
	venMovImpTraslado    bigint IDENTITY ( 1,1 ) ,
	Asiento_Id           bigint  NOT NULL ,
	RenglonDebe          integer  NOT NULL ,
	RenglonHaber         integer  NULL ,
	venMovimientos       bigint  NULL ,
	tesMovimientos       bigint  NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Cliente_Id           bigint  NULL ,
	Cartera_Id           integer  NOT NULL ,
	Banco_Id             integer  NULL ,
	BaseImponible        qMonedaD2 ,
	Monto                qMonedaD2 ,
	TotalCobro           qMonedaD2 ,
	DifCambio            qMonedaD2 ,
	RenDifCambio         integer  NULL ,
	CONSTRAINT XPKvenMovImpTrasladado PRIMARY KEY  CLUSTERED (venMovImpTraslado ASC)
)
go



CREATE NONCLUSTERED INDEX venMovImpTrasladoIK ON venMovImpTraslado
( 
	Asiento_Id            ASC,
	RenglonDebe           ASC
)
go



CREATE NONCLUSTERED INDEX IDXvenMovImpTrasladoAsi ON venMovImpTraslado
( 
	Asiento_Id            ASC,
	RenglonHaber          ASC,
	RenglonDebe           ASC,
	RenDifCambio          ASC
)
go



CREATE NONCLUSTERED INDEX IDXvenMovImpTrasladoAsiDebe ON venMovImpTraslado
( 
	Asiento_Id            ASC,
	RenglonDebe           ASC
)
go



CREATE NONCLUSTERED INDEX IDXvenMovImpTrasladoAsiDC ON venMovImpTraslado
( 
	Asiento_Id            ASC,
	RenDifCambio          ASC
)
go



CREATE TABLE venMovImpuestos
( 
	venMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	BaseImponible        qMonedaD2 ,
	Importe              qMonedaD2 ,
	BaseImponibleMonedaNac qMonedaD2 ,
	CONSTRAINT XPKvenMovImpuestos PRIMARY KEY  CLUSTERED (venMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE venMoviPredial
( 
	venMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	CuentaPredial        varchar(20)  NOT NULL ,
	CONSTRAINT XPKvenMoviPrediarl PRIMARY KEY  CLUSTERED (venMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE venMovSSImpuestos
( 
	venMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Importe              qMonedaD2 ,
	ImporteMonedaNac     qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	BaseImponible        qMonedaD2 ,
	BaseImponibleMonedaNac qMonedaD2 ,
	CONSTRAINT XPKvenMovSSImpuestos PRIMARY KEY  CLUSTERED (venMovimientos ASC,conRenglon ASC,Impuesto_Id ASC)
)
go



CREATE TABLE venMovStkHist
( 
	venMovimientos       bigint  NOT NULL ,
	RenglonCuerpo        integer  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	FacturaRemito        char(1)  NOT NULL ,
	CONSTRAINT XPKvenMovStkHist PRIMARY KEY  CLUSTERED (venMovimientos ASC,RenglonCuerpo ASC,stkMoviCabe ASC,Renglon ASC)
)
go



CREATE NONCLUSTERED INDEX idxvenMovStkHistCabe ON venMovStkHist
( 
	stkMoviCabe           ASC,
	Renglon               ASC
)
go



CREATE TABLE venNivelesAuto
( 
	venNivelesAuto       integer IDENTITY ( 1,1 ) ,
	NivelAuto_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenNivelesAuto PRIMARY KEY  CLUSTERED (venNivelesAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venNivelesAuto ON venNivelesAuto
( 
	NivelAuto_Id          ASC
)
go



CREATE TABLE venNivelesAutoUsu
( 
	Usuario_Id           integer  NOT NULL ,
	NivelAuto_Id         integer  NOT NULL ,
	CONSTRAINT XPKvenNivelesAutoUsu PRIMARY KEY  CLUSTERED (Usuario_Id ASC,NivelAuto_Id ASC)
)
go



CREATE TABLE venNPAutorizando
( 
	venPedidos           integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFechaHora  NULL ,
	TipoApro             char(1)  NOT NULL ,
	NivelAuto_Id         integer  NULL ,
	ResultadoFormula     varchar(max)  NULL ,
	CONSTRAINT XPKvenNPAutorizando PRIMARY KEY  CLUSTERED (venPedidos ASC,Secuencia ASC)
)
go



CREATE TABLE venOperadores
( 
	venOperadores        integer IDENTITY ( 1,1 ) ,
	Operador_Id          varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	RfcOperador          varchar(20)  NOT NULL ,
	NumLicencia          varchar(16)  NOT NULL ,
	NombreOperador       varchar(254)  NOT NULL ,
	NumRegIdTribOperador varchar(40)  NOT NULL ,
	ResidenciaFiscalOperador integer  NULL ,
	Calle                varchar(100)  NOT NULL ,
	NumeroExterior       varchar(30)  NULL ,
	Numerointerior       varchar(20)  NULL ,
	Colonia              varchar(120)  NULL ,
	Localidad            varchar(120)  NULL ,
	Referencia           varchar(100)  NULL ,
	Municipio            varchar(120)  NULL ,
	Estado               varchar(30)  NULL ,
	Pais                 integer  NULL ,
	CodigoPostal         varchar(20)  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenOperadores PRIMARY KEY  CLUSTERED (venOperadores ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX AkvenOperadores ON venOperadores
( 
	Operador_Id           ASC
)
go



CREATE TABLE venPediAnticipos
( 
	Pedido_Id            integer  NOT NULL ,
	venMovimientos       bigint  NOT NULL ,
	Importe              qMonedaD2 ,
	Signo                smallint  NOT NULL ,
	CONSTRAINT XPKvenPediAnticipos PRIMARY KEY  CLUSTERED (Pedido_Id ASC,venMovimientos ASC)
)
go



CREATE TABLE venPediCuerpo
( 
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Medida_Id            integer  NULL ,
	Deposito_Id          integer  NULL ,
	Factor               qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	CantidadPedida       qCantidadD8 ,
	CantidadRemitida     qCantidadD8 ,
	CantidadFacturada    qCantidadD8 ,
	PrecioForm           qMonedaD8 ,
	PrecioSinIva         qMonedaD8 ,
	PrecioLista          qMonedaD8 ,
	PrecioListaForm      qMonedaD8 ,
	PrecioVenta          qCantidadD8 ,
	TipoPrecio           char(1)  NOT NULL ,
	SubTotal             qMonedaD2 ,
	FechaEntrega         qFecha ,
	Especial             Sino ,
	Bonificacion         qPorcentaje ,
	Observaciones        QMemo  NULL ,
	Pendiente            Sino ,
	ReservaMercaderia    Sino ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	CONSTRAINT XPKvenPedidosReng PRIMARY KEY  CLUSTERED (venPedidos ASC,Renglon_Pe ASC)
)
go



CREATE INDEX XIE1venPediCuerpo ON venPediCuerpo
( 
	Pendiente             ASC
)
go



CREATE TABLE venPedidos
( 
	venPedidos           integer IDENTITY ,
	Empresa_Id           integer  NOT NULL ,
	SubTipoMov_Id        integer  NOT NULL ,
	Fecha                qFechaHora ,
	Cliente_Id           bigint  NULL ,
	Sucursal             SucursalN  NULL ,
	SucursalUsu          integer  NULL ,
	Moneda_Id            integer  NULL ,
	MonedaFacturacion    integer  NULL ,
	CondPagoCli_Id       integer  NULL ,
	ListaPrecio_Id       integer  NULL ,
	Vendedor_Id          bigint  NULL ,
	FormaEntrega_Id      integer  NULL ,
	Estado               char(1)  NOT NULL ,
	UsuarioAutoriz_Id    integer  NULL ,
	FechaAutorizo        qFechaHora  NULL ,
	Observaciones        QMemo  NULL ,
	ObservEstado         QMemo  NULL ,
	Motivo_Id            smallint  NULL ,
	SubTotal             qMonedaD2 ,
	SubTotalBonif        qMonedaD2 ,
	ImporteTotal         qMonedaD2 ,
	Bonificacion1        qMonedaD2 ,
	Bonificacion2        qMonedaD2 ,
	Bonificacion3        qMonedaD2 ,
	Bonificacion4        qMonedaD2 ,
	Bonificacion5        qMonedaD2 ,
	Dato1                qMonedaD2 ,
	Dato2                qMonedaD2 ,
	Dato3                qMonedaD2 ,
	FechaUltMod          qFechaHora ,
	CliOrdenCompra       varchar(100)  NOT NULL ,
	venNroPedido         varchar(15)  NOT NULL ,
	FacturaAnticipo      Sino ,
	TrabaDespacho        Sino ,
	PorAnticipo          qPorcentaje ,
	Anticipo             qMonedaD2 ,
	AnticipoPendiente    qMonedaD2 ,
	ObsAnticipo          QMemo  NULL ,
	TipoPrecioForm       char(1)  NOT NULL ,
	CongelaCambio        Sino ,
	Fecha_Registro       datetime  NOT NULL 
	CONSTRAINT today2
		 DEFAULT  getdate(),
	Cambio               qMonedaD8 ,
	Incoterm_Id          integer  NULL ,
	SoloEntrega          Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	MetodoPago           varchar(3)  NULL ,
	UsoCfdi              char(3)  NULL ,
	CONSTRAINT XPKvenPedidos PRIMARY KEY  CLUSTERED (venPedidos ASC)
)
go



CREATE TABLE venPedidosAnul
( 
	venPedidos           integer  NOT NULL ,
	Fecha                qFechaHora ,
	Operacion            char(1)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKvenPedidosAnul PRIMARY KEY  CLUSTERED (venPedidos ASC)
)
go



CREATE TABLE venPediFacturados
( 
	venMovimientos       bigint  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	Reparto_Id           integer  NULL ,
	CONSTRAINT XPKvenPediFacturados PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go



CREATE TABLE venPediRemitidos
( 
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	venReparto           integer  NULL ,
	CONSTRAINT XPKvenPediRemitidos PRIMARY KEY  CLUSTERED (venPedidos ASC,Renglon_Pe ASC,Renglon ASC,stkMoviCabe ASC)
)
go



CREATE TABLE venPediSegmentos
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	CONSTRAINT XPKvenPediSegmentos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC,Segmento_Id ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venPediSegmentos ON venPediSegmentos
( 
	venPedidos            ASC
)
go



CREATE TABLE venPediValiComer
( 
	venPedidos           integer  NOT NULL ,
	MVendedor            Sino ,
	MFormaE              Sino ,
	MListaP              Sino ,
	MBonifDato           Sino ,
	MBonifReng           Sino ,
	MPrecioReng          Sino ,
	CONSTRAINT XPKvenPediValidaComer PRIMARY KEY  CLUSTERED (venPedidos ASC)
)
go



CREATE TABLE venPropietarioArrenda
( 
	venPropietarioArrenda integer IDENTITY ( 1,1 ) ,
	PropArre_Id          varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	PropArre             integer  NOT NULL ,
	Rfc                  varchar(14)  NOT NULL ,
	Nombre               varchar(254)  NOT NULL ,
	NumRegIdTrib         varchar(40)  NOT NULL ,
	ResidenciaFiscal     integer  NULL ,
	Calle                varchar(100)  NOT NULL ,
	NumeroExterior       varchar(30)  NULL ,
	Numerointerior       varchar(30)  NULL ,
	Colonia              varchar(120)  NULL ,
	Localidad            varchar(120)  NULL ,
	Referencia           varchar(100)  NULL ,
	Municipio            varchar(120)  NULL ,
	Estado               varchar(30)  NULL ,
	Pais                 integer  NULL ,
	CodigoPostal         varchar(20)  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenPropietarioArrenda PRIMARY KEY  CLUSTERED (venPropietarioArrenda ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX AkvenPropietarioArrenda ON venPropietarioArrenda
( 
	PropArre_Id           ASC
)
go



CREATE TABLE venRegion
( 
	venRegion            integer IDENTITY ,
	Region_Id            varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvenRegion PRIMARY KEY  CLUSTERED (venRegion ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venRegion ON venRegion
( 
	Region_Id             ASC
)
go



CREATE TABLE venRepaPedi
( 
	venReparto           integer  NOT NULL ,
	Renglon_Rep          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	CantidadForm         qCantidadD8 ,
	CantidadAlternaForm  qCantidadD8 ,
	Remitido             Sino ,
	Facturado            Sino ,
	CONSTRAINT XPKvenRepaPedi PRIMARY KEY  CLUSTERED (venReparto ASC,Renglon_Rep ASC,venPedidos ASC,Renglon_Pe ASC)
)
go



CREATE TABLE venRepaPediSerie
( 
	venReparto           integer  NOT NULL ,
	Renglon_Rep          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKvenRepaPediSerie PRIMARY KEY  CLUSTERED (venReparto ASC,Renglon_Rep ASC,venPedidos ASC,Renglon_Pe ASC,Serie ASC)
)
go



CREATE TABLE venRepaPediSerieUbi
( 
	venReparto           integer  NOT NULL ,
	Renglon_Rep          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKvenRepaPediSerieUbi PRIMARY KEY  CLUSTERED (venReparto ASC,Renglon_Rep ASC,venPedidos ASC,Renglon_Pe ASC,Serie ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE venReparto
( 
	venReparto           integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	Sucursal             integer  NULL ,
	FechaReparto         qFecha ,
	FechaEntrega         qFecha ,
	Deposito_Id          integer  NULL ,
	ZonaDesde            varchar(5)  NOT NULL ,
	ZonaHasta            varchar(5)  NOT NULL ,
	TipoClieDesde        varchar(5)  NOT NULL ,
	TipoClieHasta        varchar(5)  NOT NULL ,
	ClienteDesde         varchar(15)  NOT NULL ,
	ClienteHasta         varchar(15)  NOT NULL ,
	DepoPedido_Id        integer  NULL ,
	Automatico           Sino ,
	Cerrado              Sino ,
	CONSTRAINT XPKvenReparto PRIMARY KEY  CLUSTERED (venReparto ASC)
)
go



CREATE TABLE venRepaSegmentos
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	venReparto           integer  NULL ,
	CONSTRAINT XPKvenRepaSegmentos PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venRepaSegmentos ON venRepaSegmentos
( 
	venReparto            ASC
)
go



CREATE TABLE venRepaUbicacion
( 
	venReparto           integer  NOT NULL ,
	Renglon_Rep          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	CantidadForm         qCantidadD8 ,
	CantidadAlternaForm  qCantidadD8 ,
	CONSTRAINT XPKvenRepaUbicacion PRIMARY KEY  CLUSTERED (venReparto ASC,Renglon_Rep ASC,venPedidos ASC,Renglon_Pe ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE venSTMAfip
( 
	venSubTipoMov        integer  NOT NULL ,
	Letra                char(1)  NOT NULL ,
	Comprobante_Id       integer  NOT NULL ,
	CONSTRAINT XPKvenSTMAfip PRIMARY KEY  CLUSTERED (venSubTipoMov ASC,Letra ASC)
)
go



CREATE TABLE venSubTipoMov
( 
	venSubTipoMov        integer IDENTITY ,
	SubTipoMov_Id        varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	venTipoMov           char(1)  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	MueveStock           Sino ,
	EsVentaContado       Sino ,
	AdmiteDevolucion     Sino ,
	ModificaPrecio       Sino ,
	Reservado            Sino ,
	GeneraRemito         Sino ,
	SegmentoRemito_Id    integer  NULL ,
	NCxDevolucion        Sino ,
	UsuarioAutorizado    integer  NULL ,
	AdmiteBoniRenglon    Sino ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	PideCambio           Sino ,
	ModFecha             Sino ,
	ModCondPago          Sino ,
	ModVendedor          Sino ,
	ModCobrador          Sino ,
	PideObervaciones     Sino ,
	CantidadCopias       smallint  NOT NULL ,
	ModDeposito          Sino ,
	ModListaPrecios      Sino ,
	PideFechaEntrega     Sino ,
	PideObsReng          Sino ,
	CtaDefecto           integer  NULL ,
	ModCtaDefecto        Sino ,
	ModCentro1           Sino ,
	ModCentro2           Sino ,
	PideOtrosCargos      Sino ,
	CtaOtrosCargos       integer  NULL ,
	PermModCtaOtCar      Sino ,
	FechaEntregaporRen   Sino ,
	AdmiteFactsinEntr    Sino ,
	ModiUniMed           Sino ,
	AfectaComVenta       Sino ,
	AfectaComCobra       Sino ,
	MaxCantItems         smallint  NOT NULL ,
	EsPorDifPrecio       Sino ,
	AfectaEstadistica    Sino ,
	ClaveAcceso          varchar(50)  NOT NULL ,
	EsPorDifCambio       Sino ,
	TipoPrecioForm       char(1)  NOT NULL ,
	SoloImpuestos        Sino ,
	CodigoFormulario     varchar(15)  NULL ,
	BajoCosto            Sino ,
	Administrativa       Sino ,
	PideReferencia       Sino ,
	PideOrdenCompra      Sino ,
	PideCongelarCambio   Sino ,
	PideMarcaReserva     Sino ,
	PermiteSoloEntrega   Sino ,
	CodigoFiscal         varchar(10)  NULL ,
	PidePredial          Sino ,
	PideCodProd          Sino ,
	PideComExpoMX        Sino  NOT NULL ,
	Reporte_Id           integer  NULL ,
	EsquemaAuto_Id       integer  NULL ,
	PorCotizacion        Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	UsaCartaPorte        Sino 
	CONSTRAINT Cero_1462084078
		 DEFAULT  0,
	CONSTRAINT XPKvenSubTipoMov PRIMARY KEY  CLUSTERED (venSubTipoMov ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venSubTipoMov ON venSubTipoMov
( 
	SubTipoMov_Id         ASC
)
go



CREATE TABLE venTipoMov
( 
	venTipoMov           char(1)  NOT NULL ,
	Descripcion          char(50)  NOT NULL ,
	Signo                smallint  NOT NULL ,
	TipoMovResumido      char(3)  NOT NULL ,
	CONSTRAINT XPKvenTipoMov PRIMARY KEY  CLUSTERED (venTipoMov ASC)
)
go



CREATE TABLE venTiposClie
( 
	venTiposClie         integer IDENTITY ,
	TipoClie_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKclitipo PRIMARY KEY  CLUSTERED (venTiposClie ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venTiposClie ON venTiposClie
( 
	TipoClie_Id           ASC
)
go



CREATE TABLE venVendedores
( 
	venVendedores        bigint  NOT NULL ,
	Vendedor_Id          varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nombre               varchar(35)  NOT NULL ,
	Usuario              integer  NULL ,
	Comision             numeric(6,2)  NOT NULL ,
	ComisionxSuperv      numeric(6,2)  NOT NULL ,
	Supervisor_Id        bigint  NULL ,
	PisoDeVentas         qMonedaD2 ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	FacturaCobrada       Sino ,
	ConAnticipos         Sino ,
	SinImpuestos         Sino ,
	Usuario_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKvenVendedores PRIMARY KEY  CLUSTERED (venVendedores ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venVendedores ON venVendedores
( 
	Vendedor_Id           ASC
)
go



CREATE TABLE venZona
( 
	venZona              integer IDENTITY ,
	Zona_Id              varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(50)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKvenZona PRIMARY KEY  CLUSTERED (venZona ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venZona ON venZona
( 
	Zona_Id               ASC
)
go




exec sp_bindrule 'MayorOIgualCero', 'genMovCuotas.Importe'
go




exec sp_bindrule 'MayorOIgualCero', 'genMovCuotas.Saldo'
go


