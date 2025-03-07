ALTER Table sueTerminadaRetro Drop Constraint XPKsueTermi
ALTER Table sueDatoRetro Drop Constraint  XPKsueDatoRetro
ALTER Table sueDatoRetro Drop Constraint  V2R_4353
ALTER Table suePagosHabiPorEmpleado Drop Constraint XPKsuePagosHabiPorEmpleado
ALTER Table sueDato Drop Constraint  XPKsueDato 
ALTER Table sueTerminadaRetro Drop Constraint V2R_4221
ALTER TABLE sueMovCont  Drop Constraint  V2R_4222 
ALTER Table sueTerminada  Drop Constraint  XPKsueTerminada
GO

ALTER Table sueTerminadaRetro ADD Constraint XPKsueTermi Primary key(sueLiquidacion, Legajo, Concepto_Id, AnioRetro ,MesRetro )
ALTER Table sueDatoRetro Add Constraint XPKsueDatoRetro Primary key(sueLiquidacion, Legajo, Concepto_Id, AnioRetro ,MesRetro )
ALTER Table sueDato Add Constraint  XPKsueDato Primary key(sueLiquidacion, Legajo, Concepto_Id)
ALTER Table sueTerminada  ADD Constraint  XPKsueTerminada Primary key(sueLiquidacion, Legajo, Concepto_Id)

ALTER TABLE sueDatoRetro
	ADD CONSTRAINT V2R_4353 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueDato(sueLiquidacion,Legajo,Concepto_Id)
go

ALTER TABLE sueTerminadaRetro
	ADD CONSTRAINT V2R_4221 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueTerminada(sueLiquidacion,Legajo,Concepto_Id)
go

ALTER TABLE sueMovCont
	ADD CONSTRAINT V2R_4222 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueTerminada(sueLiquidacion,Legajo,Concepto_Id)
go

ALTER TABLE suePagosHabiPorEmpleado 
	ADD CONSTRAINT XPKsuePagosHabiPorEmpleado PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Secuencia ASC,Legajo ASC)
GO

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
	Anulado				 Bit NOT NULL,
	CONSTRAINT XPKsueConcAcum PRIMARY KEY  CLUSTERED (sueConcAcum ASC)
)
go



CREATE TABLE sueConcAcumSegmento
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
	sueConcAcum          integer  NOT NULL ,
	CONSTRAINT XPKsueConcAcumSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC,Empresa_Id ASC)
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





ALTER TABLE sueConcAcum
	ADD CONSTRAINT V2R_4415 FOREIGN KEY (Concepto_Id) REFERENCES sueConceptos(sueConceptos)
go




ALTER TABLE sueConcAcum
	ADD CONSTRAINT V2R_4416 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueConcAcum
	ADD CONSTRAINT V2R_4417 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueConcAcumSegmento
	ADD CONSTRAINT V2R_4412 FOREIGN KEY (sueConcAcum) REFERENCES sueConcAcum(sueConcAcum)
go




ALTER TABLE sueConcAcumSegmento
	ADD CONSTRAINT V2R_4413 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE sueConcAcumSegmento
	ADD CONSTRAINT V2R_4414 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueConcDescuento
	ADD CONSTRAINT V2R_4418 FOREIGN KEY (sueConcAcum) REFERENCES sueConcAcum(sueConcAcum)
go




ALTER TABLE sueConcDescuento
	ADD CONSTRAINT V2R_4419 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueTerminada(sueLiquidacion,Legajo,Concepto_Id)
go


exec genSegmentosGuardar  'SDXT', 'SDXT', 'Descuentos por Tope' , 8,0,0,0, 1, 4,0,0,0,1,0,0,0,11,0,0,0,
	2,0,0,0,1,0,0,0,1, '1N',0,1,1
GO
DECLARE @pSegmento_Id VarChar(25)
SET @pSegmento_Id = DBO.FuncFkgenSegmentos('SDXT')
exec genSegmentosNombresGuardar   @pSegmento_Id,  'Comprobante',' ',' ',' ', 'Sucrusal',' ',' ',' ', 1

GO

IF NOT EXISTS(SELECT * FROM syscolumns inner join sysobjects on 
	syscolumns.id =sysobjects.id
	Where
		sysobjects.name = 'genSucursalesEmpr' and syscolumns.name ='RegPatronal')

ALTER TABLE genSucursalesEmpr ADD RegPatronal VarChar(20)
GO


Insert into genVersion (Version) Values(533.000)
GO

