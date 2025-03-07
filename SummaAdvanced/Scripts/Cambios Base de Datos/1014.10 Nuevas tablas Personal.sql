
CREATE TABLE suePersAporteAdic
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Adicional            qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersAporteAdic PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersAporteVoluntario
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Voluntario           qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersAporteVoluntario PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersObraSocial
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	ObraSocial           varchar(6)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersObraSocial PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersRebPromo
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Rebaja               qPorcentaje ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersRebPromo PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersRedZonal
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	Reduccion            qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersRedZonal PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



ALTER TABLE suePersAporteAdic
	ADD CONSTRAINT V2R_4587 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersAporteAdic
	ADD CONSTRAINT V2R_4588 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersAporteVoluntario
	ADD CONSTRAINT V2R_4589 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersAporteVoluntario
	ADD CONSTRAINT V2R_4590 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersObraSocial
	ADD CONSTRAINT V2R_4591 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersObraSocial
	ADD CONSTRAINT V2R_4592 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersRebPromo
	ADD CONSTRAINT V2R_4583 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersRebPromo
	ADD CONSTRAINT V2R_4584 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersRedZonal
	ADD CONSTRAINT V2R_4585 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE suePersRedZonal
	ADD CONSTRAINT V2R_4586 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert Into genVersion (Version) Values (1014.10)
Go
