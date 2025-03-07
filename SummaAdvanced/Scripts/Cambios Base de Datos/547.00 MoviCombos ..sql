ALTER TABLE stkMoviCuerpo DROP CONSTRAINT R_3749
GO
DROP TABLE stkMoviCuerpoCombo
GO

--ALTER TABLE stkMoviCuerpoCombo DROP CONSTRAINT R_3747
--ALTER TABLE stkMoviCuerpoCombo DROP CONSTRAINT R_3748

CREATE TABLE stkMoviCuerpoCombo
( 
	stkMoviCabeComponente bigint  NOT NULL ,
	RenglonComponente    integer  NOT NULL ,
	stkMoviCabe          bigint  NULL ,
	Renglon              integer  NULL ,
	CONSTRAINT XPKstkMoviCuerpoCombo PRIMARY KEY  CLUSTERED (stkMoviCabeComponente ASC,RenglonComponente ASC)
)
go




ALTER TABLE stkMoviCuerpoCombo
	ADD CONSTRAINT V2R_4440 FOREIGN KEY (stkMoviCabeComponente,RenglonComponente) REFERENCES stkMoviCuerpo(stkMoviCabe,Renglon)
go




ALTER TABLE stkMoviCuerpoCombo
	ADD CONSTRAINT V2R_4441 FOREIGN KEY (stkMoviCabe,Renglon) REFERENCES stkMoviCuerpo(stkMoviCabe,Renglon)
go


INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES('SCO', 'S','Salida_de_Componentes',1,1,null)
GO

INSERT INTO genVersion (Version) Values(547.00)
GO



