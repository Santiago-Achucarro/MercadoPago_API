
DROP TABLE proOrdenStock
go
DROP TABLE proMovCierreRecursos
go
DROP TABLE proMovCierreTrabajos3
go
DROP TABLE proMovCierreOrden
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
	CONSTRAINT XPKproMovCierreTrabajos3 PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
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




ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT V2R_4134 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT V2R_4137 FOREIGN KEY (Causa_Id) REFERENCES proCausas(proCausas)
go




ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT V2R_4304 FOREIGN KEY (proMovCierreOrden) REFERENCES conAsientos(conAsientos)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT V2R_4139 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT V2R_4138 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT V2R_4306 FOREIGN KEY (proMovCierreOrden,Renglon) REFERENCES conMovCont(conAsientos,Renglon)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT V2R_4311 FOREIGN KEY (SubRecurso_Id) REFERENCES proSubRecursos(proSubRecursos)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT V2R_4141 FOREIGN KEY (Trabajo3_Id) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT V2R_4142 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT V2R_4143 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT V2R_4140 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT V2R_4307 FOREIGN KEY (proMovCierreOrden,Renglon) REFERENCES conMovCont(conAsientos,Renglon)
go




ALTER TABLE proOrdenStock
	ADD CONSTRAINT V2R_4131 FOREIGN KEY (stkMoviCabe) REFERENCES stkMoviCabe(stkMoviCabe)
go




ALTER TABLE proOrdenStock
	ADD CONSTRAINT V2R_4135 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proOrdenStockCosto
	ADD CONSTRAINT V2R_4308 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proOrdenStockCosto
	ADD CONSTRAINT V2R_4309 FOREIGN KEY (stkMoviCabe,Renglon) REFERENCES stkMoviCuerpo(stkMoviCabe,Renglon)
go



INSERT INTO genSegmentos(Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, Inactivo, Usuario_Id, Posteado, TamanioVariable) VALUES('CPRO', 'Cierre de Orden Produccion', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, '1N')

Alter Table proRecursos ADD Cuenta_Id Int
GO

ALTER TABLE proRecursos
	ADD CONSTRAINT V2R_4312 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
go

Alter table proCentroProductivo ADD CtaProdProceso Int
GO

ALTER TABLE proCentroProductivo
	ADD CONSTRAINT V2R_4313 FOREIGN KEY (CtaProdProceso) REFERENCES conCuentas(conCuentas)
go

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('PRDE', 'E', 'Produccion Entrada', 0, 1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('PRDS', 'S', 'Produccion Salida', 0, 1)
GO

INSERT INTO genVersion (Version) Values(523.000)

GO




