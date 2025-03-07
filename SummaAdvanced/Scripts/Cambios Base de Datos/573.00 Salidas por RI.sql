CREATE TABLE stkMoviRI
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	comReqInterno        integer  NULL ,
	Renglon_RI           integer  NULL ,
	CONSTRAINT XPKstkMoviRI PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC)
)
go




ALTER TABLE stkMoviRI
	ADD CONSTRAINT V2R_4539 FOREIGN KEY (stkMoviCabe,Renglon) REFERENCES stkMoviCuerpo(stkMoviCabe,Renglon)
go




ALTER TABLE stkMoviRI
	ADD CONSTRAINT V2R_4540 FOREIGN KEY (comReqInterno,Renglon_RI) REFERENCES comRICuerpo(comReqInterno,Renglon_RI)
GO

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo,CantCopias , Reporte_Id)
VALUES('SRI','S','Salida Requicision Interna',1,1,null)

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo,CantCopias , Reporte_Id)
VALUES('ERI','E','Entrada Requicision Interna',1,1,null)
GO

INSERT INTO genVersion (Version) Values(573.00)
GO

