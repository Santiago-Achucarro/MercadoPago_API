

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
	CONSTRAINT XPKsueNominaCfdi PRIMARY KEY  CLUSTERED (Folio ASC)
)
go





ALTER TABLE sueNominaCfdi
	ADD CONSTRAINT V2R_4420 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueNominaCfdi
	ADD CONSTRAINT V2R_4421 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go

Alter table suePeriodicidad Add CodFiscal VarChar(2)
GO
Update suePeriodicidad Set CodFiscal = '02' WHERE Periodo_Id ='S'
Update suePeriodicidad Set CodFiscal = '04' WHERE Periodo_Id ='Q'
Update suePeriodicidad Set CodFiscal = '05' WHERE Periodo_Id ='M'
Update suePeriodicidad Set CodFiscal = '99' WHERE Periodo_Id ='D'
go


Insert into genVersion (Version) Values(534.000)
GO