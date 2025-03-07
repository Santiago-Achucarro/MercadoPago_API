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
	Usuario           integer  NOT NULL ,
	FechaCarga           qFechaHora ,
	CONSTRAINT XPKvenCFDISat PRIMARY KEY  CLUSTERED (UUID ASC)
)
go




ALTER TABLE venCFDISat
	ADD CONSTRAINT V2R_4543 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venCFDISat
	ADD CONSTRAINT V2R_4544 FOREIGN KEY (Usuario) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




GO
insert into genVersion(Version) values (577.02)