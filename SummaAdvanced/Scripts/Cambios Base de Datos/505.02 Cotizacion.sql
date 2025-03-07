insert into genVersion(Version) values(505.02)



CREATE TABLE venCotizaciones
( 
	venCotizaciones      integer  identity NOT NULL ,
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
	TipoPrecioForm       char(1)  ,
	CongelaCambio        Sino ,
	Fecha_Registro       qFechaHora ,
	Cambio               qMonedaD8 ,
	Incoterm_Id          integer  NULL ,
	SoloEntrega          Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	MetodoPago           varchar(3)  NOT NULL ,
	UsoCfdi              varchar(3)  NOT NULL ,
	ClienteExistente	 SiNo NOT NULL,
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
	CONSTRAINT XPKvenCotizCuerpo PRIMARY KEY  CLUSTERED (Cotizacion_Id ASC,Renglon_Co ASC)
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
	venCotizaciones      integer  NULL ,
	CONSTRAINT XPKvenCotizSegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4314 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4315 FOREIGN KEY (SubTipoMov_Id) REFERENCES venSubTipoMov(venSubTipoMov)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4316 FOREIGN KEY (Cliente_Id) REFERENCES venClientes(genEntidades)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4318 FOREIGN KEY (Cliente_Id,Sucursal) REFERENCES venClieHabitual(genEntidades,Sucursal)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4319 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4320 FOREIGN KEY (MonedaFacturacion) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4321 FOREIGN KEY (CondPagoCli_Id) REFERENCES venCondPago(venCondPago)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4322 FOREIGN KEY (ListaPrecio_Id) REFERENCES venListasPrecios(venListasPrecios)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4323 FOREIGN KEY (Vendedor_Id) REFERENCES venVendedores(venVendedores)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4324 FOREIGN KEY (FormaEntrega_Id) REFERENCES venFormaEntrega(venFormaEntrega)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4325 FOREIGN KEY (UsuarioAutoriz_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4326 FOREIGN KEY (Incoterm_Id) REFERENCES venIncoterm(venIncoterm_int)
go




ALTER TABLE venCotizaciones
	ADD CONSTRAINT V2R_4327 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venCotizAnul
	ADD CONSTRAINT V2R_4337 FOREIGN KEY (Cotizacion_Id) REFERENCES venCotizaciones(venCotizaciones)
go




ALTER TABLE venCotizAnul
	ADD CONSTRAINT V2R_4338 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venCotizCuerpo
	ADD CONSTRAINT V2R_4331 FOREIGN KEY (Cotizacion_Id) REFERENCES venCotizaciones(venCotizaciones)
go




ALTER TABLE venCotizCuerpo
	ADD CONSTRAINT V2R_4332 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE venCotizCuerpo
	ADD CONSTRAINT V2R_4333 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE venCotizCuerpo
	ADD CONSTRAINT V2R_4334 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE venCotizCuerpo
	ADD CONSTRAINT V2R_4335 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE venCotizCuerpo
	ADD CONSTRAINT V2R_4336 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE venCotizPedidos
	ADD CONSTRAINT V2R_4340 FOREIGN KEY (Cotizacion_Id) REFERENCES venCotizaciones(venCotizaciones)
go




ALTER TABLE venCotizPedidos
	ADD CONSTRAINT V2R_4341 FOREIGN KEY (Pedido_Id) REFERENCES venPedidos(venPedidos)
go




ALTER TABLE venCotizSegmento
	ADD CONSTRAINT V2R_4328 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE venCotizSegmento
	ADD CONSTRAINT V2R_4329 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE venCotizSegmento
	ADD CONSTRAINT V2R_4330 FOREIGN KEY (venCotizaciones) REFERENCES venCotizaciones(venCotizaciones)
go


insert into genSegmentos( Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, 
Origen1N,Origen2N,Origen3N, Origen4N,Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N,  Orden1C, Orden2C, Orden3C, Orden4C,HabilitaEdicion,
TamanioVariable,Inactivo,Usuario_Id, Posteado) 
values( 'VCOT',	'Cotizaciones de Ventas',	 8	,0	,0	,0	,1	, 8	,0	,0	,0	
 ,1	,0	,0	,0	 ,11	,0	,0	,0	, 2	,0	,0	,0	, 1	,0	,0	,0, 1,'N'	,0	,1	,1)

GO