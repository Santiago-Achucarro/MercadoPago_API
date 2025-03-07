CREATE TABLE venEsquemaAuto
( 
	venEsquemaAuto       integer IDENTITY ( 1,1 ) ,
	EsquemaAuto_Id       varchar(10)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	CONSTRAINT XPKvenEsquemaAuto PRIMARY KEY  CLUSTERED (venEsquemaAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venEsquemaAuto ON venEsquemaAuto
( 
	EsquemaAuto_Id        ASC
)
go



CREATE TABLE venEsquemaAutoReng
( 
	EsquemaAuto_Id       integer  NOT NULL ,
	Orden                integer  NOT NULL ,
	Formula              varchar(max)  NOT NULL ,
	NivelAuto_Id         integer  NULL ,
	CONSTRAINT XPKvenEsquemaAutoReng PRIMARY KEY  CLUSTERED (EsquemaAuto_Id ASC,Orden ASC)
)
go



CREATE TABLE venNivelesAuto
( 
	venNivelesAuto       integer IDENTITY ( 1,1 ) ,
	NivelAuto_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenNivelesAuto PRIMARY KEY  CLUSTERED (venNivelesAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venNivelesAuto ON venNivelesAuto
( 
	NivelAuto_Id          ASC
)
go



CREATE TABLE venNivelesAutoUsu
( 
	Usuario_Id           integer  NOT NULL ,
	NivelAuto_Id         integer  NOT NULL ,
	CONSTRAINT XPKvenNivelesAutoUsu PRIMARY KEY  CLUSTERED (Usuario_Id ASC,NivelAuto_Id ASC)
)
go



CREATE TABLE venNPAutorizando
( 
	venPedidos           integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFechaHora  NULL ,
	TipoApro             char(1)  NOT NULL ,
	NivelAuto_Id         integer  NULL ,
	ResultadoFormula     varchar(max)  NULL ,
	CONSTRAINT XPKvenNPAutorizando PRIMARY KEY  CLUSTERED (venPedidos ASC,Secuencia ASC)
)
go



CREATE TABLE venPediValiComer
( 
	venPedidos           integer  NOT NULL ,
	MVendedor            Sino ,
	MFormaE              Sino ,
	MListaP              Sino ,
	MBonifDato           Sino ,
	MBonifReng           Sino ,
	MPrecioReng          Sino ,
	CONSTRAINT XPKvenPediValidaComer PRIMARY KEY  CLUSTERED (venPedidos ASC)
)
go

ALTER Table venSubTipoMov Add EsquemaAuto_Id Int
GO

ALTER TABLE venSubTipoMov
	ADD CONSTRAINT V2R_4506 FOREIGN KEY (EsquemaAuto_Id) REFERENCES venEsquemaAuto(venEsquemaAuto)
go



ALTER TABLE venEsquemaAuto
	ADD CONSTRAINT V2R_4495 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE venEsquemaAutoReng
	ADD CONSTRAINT V2R_4496 FOREIGN KEY (EsquemaAuto_Id) REFERENCES venEsquemaAuto(venEsquemaAuto)
go




ALTER TABLE venEsquemaAutoReng
	ADD CONSTRAINT V2R_4499 FOREIGN KEY (NivelAuto_Id) REFERENCES venNivelesAuto(venNivelesAuto)
go




ALTER TABLE venNivelesAuto
	ADD CONSTRAINT V2R_4497 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE venNivelesAuto
	ADD CONSTRAINT V2R_4498 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venNivelesAutoUsu
	ADD CONSTRAINT V2R_4500 FOREIGN KEY (NivelAuto_Id) REFERENCES venNivelesAuto(venNivelesAuto)
go




ALTER TABLE venNivelesAutoUsu
	ADD CONSTRAINT V2R_4501 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venNPAutorizando
	ADD CONSTRAINT V2R_4502 FOREIGN KEY (venPedidos) REFERENCES venPedidos(venPedidos)
go




ALTER TABLE venNPAutorizando
	ADD CONSTRAINT V2R_4503 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venNPAutorizando
	ADD CONSTRAINT V2R_4504 FOREIGN KEY (NivelAuto_Id) REFERENCES venNivelesAuto(venNivelesAuto)
go




ALTER TABLE venPediValiComer
	ADD CONSTRAINT V2R_4505 FOREIGN KEY (venPedidos) REFERENCES venPedidos(venPedidos)
go



Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'IIF', 'Condicional', 113, 'U')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MONTO', 'Monto', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'SIEMPRE', 'Requiere autorización Siempre', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MVENDEDOR', 'Modificado el Vendedor', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MFORMAE', 'Modificada la forma de entrega', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MLISTAP', 'Modificada la lista de precios', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MBONIFDATO', 'Modificado Dato en pantalla', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MBONIFRENG', 'Modificada bonificación por renglón', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MPRECIORENG', 'Modificada precio en renglón', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'ESCLIENTE', 'Es Cliente el usuario que ingreso el pedido', 103, 'L')

Insert Into venNivelesAuto (NivelAuto_Id, Empresa_Id, Descripcion, Inactivo,Posteado, Usuario_Id) Values ('LI', null, 'Listo', 0,1, 1)

GO
INSERT Into venEsquemaAuto (EsquemaAuto_Id, Descripcion, Empresa_Id) Values('VC','VALIDACION COMERCIAL',NULL)
GO
INSERT INTO genVersion (Version) Values(560.00)
GO

