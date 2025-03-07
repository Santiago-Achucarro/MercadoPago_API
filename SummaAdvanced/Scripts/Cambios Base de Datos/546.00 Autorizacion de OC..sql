CREATE TABLE comOCAutorizando
( 
	comOrdenComp         integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	NivelAuto_Id         integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFechaHora  NULL ,
	TipoApro             char(1)  NOT NULL ,
	ResultadoFormula     varchar(max)  NULL ,
	CONSTRAINT XPKcomOCAutorizando PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Secuencia ASC)
)
go


Alter table comTipoPermi Add EsquemaAuto_Id Int NULL





ALTER TABLE comOCAutorizando
	ADD CONSTRAINT V2R_4436 FOREIGN KEY (comOrdenComp) REFERENCES comOrdenComp(comOrdenComp)
go




ALTER TABLE comOCAutorizando
	ADD CONSTRAINT V2R_4437 FOREIGN KEY (NivelAuto_Id) REFERENCES comNivelesAuto(comNivelesAuto)
go




ALTER TABLE comOCAutorizando
	ADD CONSTRAINT V2R_4438 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go


ALTER TABLE comTipoPermi
	ADD CONSTRAINT V2R_4439 FOREIGN KEY (EsquemaAuto_Id) REFERENCES comEsquemaAuto(comEsquemaAuto)
go


insert into genVersion (Version) Values(546.00)
GO
