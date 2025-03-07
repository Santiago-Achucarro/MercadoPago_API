

CREATE TABLE sueGanancias
( 
	TabGan_Id            integer  NOT NULL ,
	Hasta                qMonedaD2 ,
	Porcentaje           qPorcentaje ,
	Minimo               qMonedaD2 ,
	CONSTRAINT XPKsueGanancias PRIMARY KEY  CLUSTERED (TabGan_Id ASC,Hasta ASC)
)
go



CREATE TABLE sueGanTitulo
( 
	TabGan_Id            integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueGanTitulo PRIMARY KEY  CLUSTERED (TabGan_Id ASC)
)
go



CREATE TABLE sueTabla
( 
	Tabla_Id             integer  NOT NULL ,
	Fila                 qMonedaD2 ,
	Valor                qMonedaD2 ,
	CONSTRAINT XPKsueTabla PRIMARY KEY  CLUSTERED (Tabla_Id ASC)
)
go



CREATE TABLE sueTabTitulo
( 
	Tabla_Id             integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueTabTitulo PRIMARY KEY  CLUSTERED (Tabla_Id ASC)
)
go




ALTER TABLE sueGanancias
	ADD CONSTRAINT V2R_4348 FOREIGN KEY (TabGan_Id) REFERENCES sueGanTitulo(TabGan_Id)
go




ALTER TABLE sueGanTitulo
	ADD CONSTRAINT V2R_4347 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueTabla
	ADD CONSTRAINT V2R_4346 FOREIGN KEY (Tabla_Id) REFERENCES sueTabTitulo(Tabla_Id)
go




ALTER TABLE sueTabTitulo
	ADD CONSTRAINT V2R_4345 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go


Insert into genVersion (Version) Values(524.00)
GO