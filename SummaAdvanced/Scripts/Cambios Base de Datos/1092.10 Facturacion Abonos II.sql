Drop procedure venAbonosFacturacion
Go

DROP TABLE venAbonosCuerpo
go



DROP TABLE venAbonosFacturas
go



DROP TABLE venAbonosSegmentos
go



DROP TABLE venAbonos
go



CREATE TABLE venAbonos
( 
	venAbonos            integer IDENTITY ( 1,1 ) ,
	Empresa_Id           integer  NOT NULL ,
	SubTipoMov_Id        integer  NULL ,
	FechaInicio          qFecha ,
	FechaFin             qFecha ,
	FechaUltFacturacion  qFecha ,
	FechaProxFacturacion qFecha ,
	Cliente_Id           bigint  NULL ,
	Sucursal             SucursalN  NULL 
	CONSTRAINT Cero_567613284
		 DEFAULT  0,
	SucursalUsu          integer  NULL ,
	Moneda_Id            integer  NULL ,
	MonedaFacturacion    integer  NULL ,
	CondPagoCli_Id       integer  NULL ,
	ListaPrecio_Id       integer  NULL ,
	Vendedor_Id          bigint  NULL ,
	FormaEntrega_Id      integer  NULL ,
	Observaciones        QMemo ,
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
	Frecuencia           char(1)  NOT NULL ,
	Cambio               qMonedaD8 ,
	TipoPrecioForm       char(1)  NOT NULL ,
	FechaRegistro        qFechaHora ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenAbonos PRIMARY KEY  CLUSTERED (venAbonos ASC)
)
go



CREATE TABLE venAbonosCuerpo
( 
	venAbonos            integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Medida_Id            integer  NULL ,
	Factor               qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	Cantidad             qCantidadD8 ,
	PrecioLista          qMonedaD8 ,
	PrecioListaForm      qMonedaD8 ,
	TipoPrecioForm       char(1)  NOT NULL ,
	SubTotal             qMonedaD8 ,
	Observaciones        QMemo ,
	ModificaNovedades    Sino ,
	CONSTRAINT XPKvenAbonosCuerpo PRIMARY KEY  CLUSTERED (venAbonos ASC,Renglon ASC)
)
go



CREATE TABLE venAbonosFacturacion
( 
	venAbonosFacturacion integer IDENTITY ( 1,1 ) ,
	FechaDesde           qFecha ,
	FechaHasta           qFecha ,
	FechaEmision         qFecha ,
	ClienteDesde         varchar(15)  NOT NULL ,
	ClienteHasta         varchar(15)  NOT NULL ,
	VendedorDesde        varchar(5)  NOT NULL ,
	VendedorHasta        varchar(5)  NOT NULL ,
	MonedaDesde          varchar(3)  NOT NULL ,
	MonedaHasta          varchar(3)  NOT NULL ,
	CONSTRAINT XPKvenAbonosFacturacion PRIMARY KEY  CLUSTERED (venAbonosFacturacion ASC)
)
go



CREATE TABLE venAbonosFacturas
( 
	venAbonosFacturacion integer  NOT NULL ,
	venAbonos            integer  NOT NULL ,
	venMovimientos       bigint  NOT NULL ,
	CONSTRAINT XPKvenAbonosFacturas PRIMARY KEY  CLUSTERED (venAbonosFacturacion ASC,venAbonos ASC)
)
go


CREATE TABLE venAbonosFactuSegmentos
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
	venAbonosFacturacion integer  NULL ,
	CONSTRAINT XPKvenAbonosFactuSegmentos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go


CREATE TABLE venAbonosSegmentos
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
	venAbonos            integer  NULL ,
	CONSTRAINT XPKvenAbonosSegmentos PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4763 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4764 FOREIGN KEY (SubTipoMov_Id) REFERENCES venSubTipoMov(venSubTipoMov)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4765 FOREIGN KEY (Cliente_Id,Sucursal) REFERENCES venClieHabitual(genEntidades,Sucursal)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4766 FOREIGN KEY (SucursalUsu) REFERENCES genSucursalesEmpr(genSucursalesEmpr)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4767 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4768 FOREIGN KEY (MonedaFacturacion) REFERENCES genMonedas(genMonedas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4769 FOREIGN KEY (CondPagoCli_Id) REFERENCES venCondPago(venCondPago)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4770 FOREIGN KEY (ListaPrecio_Id) REFERENCES venListasPrecios(venListasPrecios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4771 FOREIGN KEY (Vendedor_Id) REFERENCES venVendedores(venVendedores)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4772 FOREIGN KEY (FormaEntrega_Id) REFERENCES venFormaEntrega(venFormaEntrega)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonos
	ADD CONSTRAINT V2R_4773 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosCuerpo
	ADD CONSTRAINT V2R_4774 FOREIGN KEY (venAbonos) REFERENCES venAbonos(venAbonos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosCuerpo
	ADD CONSTRAINT V2R_4775 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosCuerpo
	ADD CONSTRAINT V2R_4776 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE venAbonosFacturas
	ADD CONSTRAINT V2R_4789 FOREIGN KEY (venAbonosFacturacion) REFERENCES venAbonosFacturacion(venAbonosFacturacion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosFacturas
	ADD CONSTRAINT V2R_4790 FOREIGN KEY (venMovimientos) REFERENCES venMovimientos(venMovimientos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosFacturas
	ADD CONSTRAINT V2R_4791 FOREIGN KEY (venAbonos) REFERENCES venAbonos(venAbonos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go





ALTER TABLE venAbonosFactuSegmentos
	ADD CONSTRAINT V2R_4785 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosFactuSegmentos
	ADD CONSTRAINT V2R_4786 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosFactuSegmentos
	ADD CONSTRAINT V2R_4788 FOREIGN KEY (venAbonosFacturacion) REFERENCES venAbonosFacturacion(venAbonosFacturacion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosSegmentos
	ADD CONSTRAINT V2R_4778 FOREIGN KEY (venAbonos) REFERENCES venAbonos(venAbonos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosSegmentos
	ADD CONSTRAINT V2R_4777 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venAbonosSegmentos
	ADD CONSTRAINT V2R_4781 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

----
EXECUTE genSegmentosGuardar
   @pSegmento_Id = 'ABONOS'
  ,@pSegmento_Id_Nuevo = 'ABONOS'
  ,@pDescripcion = 'Abonos de ventas'
  ,@pDigitos1N = 8
  ,@pDigitos2N = 0
  ,@pDigitos3N = 0
  ,@pDigitos4N = 0
  ,@pTieneColumnaAutomatica = 1
  ,@pDigitos1C = 4
  ,@pDigitos2C = 0
  ,@pDigitos3C = 0
  ,@pDigitos4C = 0
  ,@pOrigen1N = 1
  ,@pOrigen2N = 0
  ,@pOrigen3N = 0
  ,@pOrigen4N = 0
  ,@pOrigen1C = 11
  ,@pOrigen2C = 0
  ,@pOrigen3C = 0
  ,@pOrigen4C = 0
  ,@pOrden1N = 2
  ,@pOrden2N = 0
  ,@pOrden3N = 0
  ,@pOrden4N = 0
  ,@pOrden1C = 1
  ,@pOrden2C = 0
  ,@pOrden3C = 0
  ,@pOrden4C = 0
  ,@pHabilitaEdicion = 0
  ,@pTamanioVariable = '1N'
  ,@pInactivo = 0
  ,@pUsuario_Id = 1
  ,@pPosteado = 1
  ,@pEsSueldos  = 0
  ,@pEmpiezaEnUno = 0
GO

DECLARE @pSegmento_Id int 
set @pSegmento_Id = dbo.FuncFKgenSegmentos('ABONOS')
EXEC genSegmentosNombresGuardar
   @pSegmento_Id 
  ,@pNombre1N = 'Abono'
  ,@pNombre2N = ''
  ,@pNombre3N= ''
  ,@pNombre4N= ''
  ,@pNombre1C = 'Sucursal'
  ,@pNombre2C= ''
  ,@pNombre3C= ''
  ,@pNombre4C= ''
  ,@pUsuario_Id=1
GO

EXECUTE genSegmentosGuardar
   @pSegmento_Id = 'CICLOABONO'
  ,@pSegmento_Id_Nuevo = 'CICLOABONO'
  ,@pDescripcion = 'Ciclo Facturaci�n Abonos de ventas'
  ,@pDigitos1N = 8
  ,@pDigitos2N = 0
  ,@pDigitos3N = 0
  ,@pDigitos4N = 0
  ,@pTieneColumnaAutomatica = 1
  ,@pDigitos1C = 4
  ,@pDigitos2C = 0
  ,@pDigitos3C = 0
  ,@pDigitos4C = 0
  ,@pOrigen1N = 1
  ,@pOrigen2N = 0
  ,@pOrigen3N = 0
  ,@pOrigen4N = 0
  ,@pOrigen1C = 11
  ,@pOrigen2C = 0
  ,@pOrigen3C = 0
  ,@pOrigen4C = 0
  ,@pOrden1N = 2
  ,@pOrden2N = 0
  ,@pOrden3N = 0
  ,@pOrden4N = 0
  ,@pOrden1C = 1
  ,@pOrden2C = 0
  ,@pOrden3C = 0
  ,@pOrden4C = 0
  ,@pHabilitaEdicion = 0
  ,@pTamanioVariable = '1N'
  ,@pInactivo = 0
  ,@pUsuario_Id = 1
  ,@pPosteado = 1
  ,@pEsSueldos  = 0
  ,@pEmpiezaEnUno = 0
GO

DECLARE @pSegmento_Id int 
set @pSegmento_Id = dbo.FuncFKgenSegmentos('CICLOABONO')
EXEC genSegmentosNombresGuardar
   @pSegmento_Id 
  ,@pNombre1N = 'Ciclo'
  ,@pNombre2N = ''
  ,@pNombre3N= ''
  ,@pNombre4N= ''
  ,@pNombre1C = 'Sucursal'
  ,@pNombre2C= ''
  ,@pNombre3C= ''
  ,@pNombre4C= ''
  ,@pUsuario_Id=1
GO


Insert Into genVersion (Version) Values (1092.10)
GO
