
CREATE TABLE suePlantilla
( 
	Centro1_Id           integer  NOT NULL ,
	Puesto_Id            integer  NOT NULL ,
	Cantidad             qMonedaD2 ,
	CONSTRAINT XPKsuePlantilla PRIMARY KEY  CLUSTERED (Centro1_Id ASC,Puesto_Id ASC)
)
go




ALTER TABLE suePlantilla
	ADD CONSTRAINT V2R_4447 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE suePlantilla
	ADD CONSTRAINT V2R_4448 FOREIGN KEY (Puesto_Id) REFERENCES suePuestos(suePuestos)
go

INSERT INTO genVersion(Version) Values(550.00)
GO