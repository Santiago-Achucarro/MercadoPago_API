CREATE TABLE venMovConforma
( 
	venMovimientos       bigint  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaConforma        datetime  NOT NULL ,
	FechaRegistro        qFechaHora ,
	Observaciones        QMemo ,
	CONSTRAINT XPKvenMovConforma PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go




ALTER TABLE venMovConforma
	ADD CONSTRAINT V2R_4541 FOREIGN KEY (venMovimientos) REFERENCES venMovimientos(venMovimientos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venMovConforma
	ADD CONSTRAINT V2R_4542 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


INSERT INTO genVersion (Version) Values(578.00)
GO
