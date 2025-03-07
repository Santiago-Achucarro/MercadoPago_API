insert into genVersion (Version) values (504.02)
go
drop table proOrdenProd
drop table proOrdenSubRecurso
drop table proOrdenRecursos
drop table proOrdenSegmento
drop table proOrdenTrabajos3
drop table proOrdenStock
drop table proProgramaOrden
drop table proMovCierreRecursos
drop table proMovCierreTrabajos3
drop table proMovCierreOrden
drop table proOrden

CREATE TABLE proMovCierreOrden
( 
	proMovCierreOrden    bigint IDENTITY ( 1,1 ) ,
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
	CONSTRAINT XPKproMovCierreTrabajos3 PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
)
go


CREATE TABLE proOrden
( 
	proOrden             integer identity NOT NULL ,
	Producto_Id          integer  NULL ,
	TamBatch             qCantidadD8 ,
	Receta_Id            integer  NULL ,
	Observaciones        varchar(max)  NOT NULL ,
	Anulado bit,
	Cantidad qCantidadD8,
	CantidadIngresada qCantidadD8,
	FechaEmision datetime,
	CantidadProgramada qCantidadD8,
	FechaNecesidad datetime,
	FechaProduccion datetime null,
	FechaFin datetime null,
	CantidadTerminada qCantidadD8,
	CierreAutomatico bit,
	Medida_Id int,
	Factor qMonedaD8,
	foreign key (Medida_Id) references stkUniMed(stkUniMed),
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
	proOrden             integer  NULL ,
	CONSTRAINT XPKporOrdenSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE proOrdenStock
( 
	proMovCierreOrden    bigint  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	CONSTRAINT XPKproCierreOrden PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,stkMoviCabe ASC)
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



CREATE TABLE proProgramaOrden
( 
	proProgramas         integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	proOrden             integer  NOT NULL ,
	CONSTRAINT XPKproProgramaOrden PRIMARY KEY  CLUSTERED (proProgramas ASC,Renglon ASC,proOrden ASC)
)
go



ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT RV2_4134 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT RV2_4137 FOREIGN KEY (Causa_Id) REFERENCES proCausas(proCausas)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT RV2_4138 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT RV2_4139 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4140 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4141 FOREIGN KEY (Trabajo3_Id) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4142 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4143 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE proOrden
	ADD CONSTRAINT RV2_4088 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE proOrden
	ADD CONSTRAINT RV2_4090 FOREIGN KEY (Receta_Id) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4112 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4113 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4114 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4115 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE proOrdenRecursos
	ADD CONSTRAINT RV2_4119 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenRecursos
	ADD CONSTRAINT RV2_4120 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proOrdenSegmento
	ADD CONSTRAINT RV2_4116 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenSegmento
	ADD CONSTRAINT RV2_4117 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE proOrdenSegmento
	ADD CONSTRAINT RV2_4118 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proOrdenStock
	ADD CONSTRAINT RV2_4131 FOREIGN KEY (stkMoviCabe) REFERENCES stkMoviCabe(stkMoviCabe)
go




ALTER TABLE proOrdenStock
	ADD CONSTRAINT RV2_4135 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proOrdenSubRecurso
	ADD CONSTRAINT RV2_4123 FOREIGN KEY (proOrden,Renglon) REFERENCES proOrdenRecursos(proOrden,Renglon)
go




ALTER TABLE proOrdenSubRecurso
	ADD CONSTRAINT RV2_4124 FOREIGN KEY (SubRecurso_Id) REFERENCES proSubRecursos(proSubRecursos)
go




ALTER TABLE proOrdenTrabajos3
	ADD CONSTRAINT RV2_4125 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenTrabajos3
	ADD CONSTRAINT RV2_4126 FOREIGN KEY (proTrabajo3) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proOrdenTrabajos3
	ADD CONSTRAINT RV2_4127 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE proProgramaOrden
	ADD CONSTRAINT RV2_4128 FOREIGN KEY (proProgramas,Renglon) REFERENCES proProgramasCuerpo(proProgramas,Renglon)
go




ALTER TABLE proProgramaOrden
	ADD CONSTRAINT RV2_4129 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go

