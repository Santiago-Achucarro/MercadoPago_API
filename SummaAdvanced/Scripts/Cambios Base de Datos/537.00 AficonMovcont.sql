CREATE TABLE AficonMovcont
( 
	conAsientos          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	ActivoFijo_Id        integer  NULL ,
	Inactivo             Sino ,
	CONSTRAINT XPKAficonMovcont PRIMARY KEY  CLUSTERED (conAsientos ASC,Renglon ASC)
)
go




ALTER TABLE AficonMovcont
	ADD CONSTRAINT V2R_4424 FOREIGN KEY (conAsientos,Renglon) REFERENCES conMovCont(conAsientos,Renglon)
go




ALTER TABLE AficonMovcont
	ADD CONSTRAINT V2R_4425 FOREIGN KEY (ActivoFijo_Id) REFERENCES afiActivoFijo(afiActivoFijo)
go


INSERT INTO genVersion (Version) Values(537.00)
GO


