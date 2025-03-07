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




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4460 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4461 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4462 FOREIGN KEY (MedidaAlterna) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4463 FOREIGN KEY (Tipo_Id) REFERENCES stkTipos(stkTipos)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4464 FOREIGN KEY (Familia_Id) REFERENCES stkFamilias(stkFamilias)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4465 FOREIGN KEY (Grupo_Id) REFERENCES stkGrupos(stkGrupos)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4466 FOREIGN KEY (UMVenta_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4467 FOREIGN KEY (MonedaUltCompra) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4468 FOREIGN KEY (UMCompra_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4469 FOREIGN KEY (CtaCompra) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4470 FOREIGN KEY (CtaAjuInventario) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4471 FOREIGN KEY (CtaVenta) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4472 FOREIGN KEY (CtaCredito) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4473 FOREIGN KEY (CtaDescuento) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4474 FOREIGN KEY (CtaCosto) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4475 FOREIGN KEY (CtaVentasExt) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4476 FOREIGN KEY (CtaCreditoExt) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4477 FOREIGN KEY (CtaDescuentoExt) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4478 FOREIGN KEY (CtaCostoExt) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4479 FOREIGN KEY (CFVenta_Id) REFERENCES stkCondFisVenta(stkCondFisVenta)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4480 FOREIGN KEY (CFCompra_Id) REFERENCES stkCondFisCompra(stkCondFisCompra)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4481 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE stkProductosPlantilla
	ADD CONSTRAINT V2R_4482 FOREIGN KEY (CtaConsumo) REFERENCES conCuentas(conCuentas)
go


INSERT INTO genVersion(Version) Values(555.02)
GO