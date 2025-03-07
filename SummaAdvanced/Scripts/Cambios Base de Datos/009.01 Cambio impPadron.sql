IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 9.01)
begin

INSERT INTO genVersion (Version) Values (9.01)

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
	Usuario_Id           integer Not NULL ,
	CONSTRAINT XPKimpPadron PRIMARY KEY  CLUSTERED (impPadron ASC)
);




CREATE UNIQUE NONCLUSTERED INDEX XAK1impPadron ON impPadron
( 
	Padron_Id             ASC
);




ALTER TABLE impPadron
	ADD CONSTRAINT R_3926 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas);




ALTER TABLE impPadron
	ADD CONSTRAINT R_3927 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios);



Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'PADRON', 'Valor_del_padron_del_parametro', 123, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'NCDEVOL', 'Indica_si_es_NC_por_devolucion', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'ASIGPORC', 'Asigna_valor_recibido_al_porcentaje', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'MUEVESTOCK', 'Indica_si_el_subtipo_mueve_stock', 103, 'L')



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
);



CREATE TABLE impRentasCapExentosTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Trimestre            smallint  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	Tipo                 char(1)  NOT NULL ,
	AlicuotaPer          qPorcentaje ,
	AlicuotaRet          qPorcentaje ,
	GrupoPer             smallint  NOT NULL ,
	GrupoRet             smallint  NOT NULL ,
	CONSTRAINT XPKimpRentasCapExentosTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Trimestre ASC)
);




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
);




CREATE TABLE impRentasCapMagSupTxt
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
	CONSTRAINT XPKimpRentasCapMagSupTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Mes ASC)
);




CREATE TABLE impRentasCapRiesgoTxt
( 
	CUIT                 char(14)  NOT NULL ,
	Anio                 smallint  NOT NULL ,
	Trimestre            smallint  NOT NULL ,
	FechaVigDesde        qFecha ,
	FechaVigHasta        qFecha ,
	Tipo                 char(1)  NOT NULL ,
	AlicuotaPer          qPorcentaje ,
	AlicuotaRet          qPorcentaje ,
	GrupoPer             smallint  NOT NULL ,
	GrupoRet             smallint  NOT NULL ,
	CONSTRAINT XPKimpRentasCapTxt PRIMARY KEY  CLUSTERED (CUIT ASC,Anio ASC,Trimestre ASC)
);

End
