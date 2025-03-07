

CREATE TABLE tesSolicitantes
( 
	genEntidades         bigint  NOT NULL ,
	Solicitante_Id       varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nombre               varchar(120)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Banco_Id             integer  NULL ,
	Cuenta               varchar(18)  NOT NULL ,
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
	CONSTRAINT XPKtesSolPago PRIMARY KEY  CLUSTERED (tesSolicitud ASC, tesMovimientos ASC)
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
	tesSolicitud         bigint  NULL ,
	CONSTRAINT XPKtesSolSegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go




ALTER TABLE tesSolicitantes
	ADD CONSTRAINT V2R_4524 FOREIGN KEY (genEntidades) REFERENCES genEntidades(genEntidades)
go




ALTER TABLE tesSolicitantes
	ADD CONSTRAINT V2R_4525 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE tesSolicitantes
	ADD CONSTRAINT V2R_4526 FOREIGN KEY (Banco_Id) REFERENCES tesBancos(tesBancos)
go




ALTER TABLE tesSolicitantes
	ADD CONSTRAINT V2R_4527 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE tesSolicitud
	ADD CONSTRAINT V2R_4528 FOREIGN KEY (Solicitante_Id) REFERENCES tesSolicitantes(genEntidades)
go




ALTER TABLE tesSolicitud
	ADD CONSTRAINT V2R_4529 FOREIGN KEY (UsuarioAutorizo) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE tesSolicitud
	ADD CONSTRAINT V2R_4530 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE tesSolicitud
	ADD CONSTRAINT V2R_4531 FOREIGN KEY (Cartera_Id) REFERENCES tesIdentifica(tesIdentifica)
go




ALTER TABLE tesSolPago
	ADD CONSTRAINT V2R_4535 FOREIGN KEY (tesSolicitud) REFERENCES tesSolicitud(tesSolicitud)
go




ALTER TABLE tesSolPago
	ADD CONSTRAINT V2R_4536 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos)
go




ALTER TABLE tesSolRendicion
	ADD CONSTRAINT V2R_4537 FOREIGN KEY (tesSolicitud) REFERENCES tesSolicitud(tesSolicitud)
go




ALTER TABLE tesSolRendicion
	ADD CONSTRAINT V2R_4538 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos)
go




ALTER TABLE tesSolSegmentos
	ADD CONSTRAINT V2R_4532 FOREIGN KEY (tesSolicitud) REFERENCES tesSolicitud(tesSolicitud)
go




ALTER TABLE tesSolSegmentos
	ADD CONSTRAINT V2R_4533 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE tesSolSegmentos
	ADD CONSTRAINT V2R_4534 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go



IF NOT EXISTS(SELECT 1 FROM tesSubTiposMov WHERE SubTipo_Id = 'PAG')
BEGIN
insert into tesSubTiposMov (TipoMov, SubTipo_Id, Descripcion, CantCopias) values('E', 'PAG', 'PAGO ANTICIPO DE GASTOS', 1)
insert into tesSubTiposMov (TipoMov, SubTipo_Id, Descripcion, CantCopias) values('E', 'RAG', 'RENDICION ANTICIPO DE GASTOS', 1)
END
GO

-- segmento AGC

exec genSegmentosGuardar  'AGC', 'AGC', 'Anticipos de Gastos por Comprobar' , 8,0,0,0, 1, 4,0,0,0,1,0,0,0,11,0,0,0,
	2,0,0,0,1,0,0,0,1, '1N',0,1,1
GO
DECLARE @pSegmento_Id VarChar(25)
SET @pSegmento_Id = DBO.FuncFkgenSegmentos('AGC')
exec genSegmentosNombresGuardar   @pSegmento_Id,  'Comprobante',' ',' ',' ', 'Sucrusal',' ',' ',' ', 1

GO

INSERT INTO genVersion(Version) Values(572.00)
GO
