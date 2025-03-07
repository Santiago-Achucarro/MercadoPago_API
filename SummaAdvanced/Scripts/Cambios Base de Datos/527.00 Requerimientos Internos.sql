CREATE TABLE comCategorias
( 
	comCategorias        integer IDENTITY ( 1,1 ) ,
	Categoria_Id         varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomCategorias PRIMARY KEY  CLUSTERED (comCategorias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comCategorias ON comCategorias
( 
	Categoria_Id          ASC
)
go



CREATE TABLE comEsquemaAuto
( 
	comEsquemaAuto       integer IDENTITY ( 1,1 ) ,
	EsquemaAuto_Id       varchar(10)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomEsquemaAuto PRIMARY KEY  CLUSTERED (comEsquemaAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comEsquemaAuto ON comEsquemaAuto
( 
	EsquemaAuto_Id        ASC
)
go



CREATE TABLE comEsquemaAutoReng
( 
	EsquemaAuto_Id       integer  NOT NULL ,
	Orden                integer  NOT NULL ,
	NivelAuto_Id         integer  NULL ,
	Formula              QMemo ,
	CONSTRAINT XPKcomEsquemaAutoReng PRIMARY KEY  CLUSTERED (EsquemaAuto_Id ASC,Orden ASC)
)
go



CREATE TABLE comNivelesAuto
( 
	comNivelesAuto       integer IDENTITY ( 1,1 ) ,
	NivelAuto_Id         varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomNivelesAuto PRIMARY KEY  CLUSTERED (comNivelesAuto ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comNivelesAuto ON comNivelesAuto
( 
	NivelAuto_Id          ASC
)
go


CREATE TABLE comNivelesAutoUsu
( 
	NivelAuto_Id         integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKcomNivelesAutoUsu PRIMARY KEY  CLUSTERED (NivelAuto_Id ASC,Usuario_Id ASC)
)
go





CREATE TABLE comOCRI
( 
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKcomOCRI PRIMARY KEY  CLUSTERED (comOrdenComp ASC,Renglon_OC ASC,comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comReqInterno
( 
	comReqInterno        integer IDENTITY ( 1,1 ) ,
	Fecha                qFecha ,
	TipoPermi_Id         integer  NULL ,
	Observaciones        QMemo ,
	Proveed_Id           bigint  NULL ,
	EstadoRI_Id          char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomReqInterno PRIMARY KEY  CLUSTERED (comReqInterno ASC)
)
go



CREATE TABLE comRIArticulo
( 
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Factor               qCantidadD8 ,
	CantidadOriginal     qCantidadD8 ,
	PrecioOriginal       qMonedaD4 ,
	Deposito_Id          integer  NULL ,
	CONSTRAINT XPKcomRIArticulo PRIMARY KEY  CLUSTERED (comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comRIAutorizando
( 
	comReqInterno        integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	NivelAuto_Id         integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Fecha                qFechaHora  NULL ,
	TipoApro             char(1)  NOT NULL ,
	ResultadoFormula     QMemo ,
	CONSTRAINT XPKcomRIAutorizando PRIMARY KEY  CLUSTERED (comReqInterno ASC,Secuencia ASC)
)
go



CREATE TABLE comRICuerpo
( 
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	FechaNecesidad       qFecha ,
	Cantidad             qCantidadD8 ,
	Precio               qMonedaD4 ,
	CantidadRecibida     qCantidadD8 ,
	Observaciones        QMemo ,
	Pendiente            Sino ,
	Cuenta_Id            integer  NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Medida_Id            integer  NULL ,
	CONSTRAINT XPKcomRICuerpo PRIMARY KEY  CLUSTERED (comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comRIDesechado
( 
	comReqInterno        integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Fecha                qFechaHora ,
	CONSTRAINT XPKcomRIDesechado PRIMARY KEY  CLUSTERED (comReqInterno ASC)
)
go



CREATE TABLE comRIEstados
( 
	EstadoRI_Id          char(1)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	CONSTRAINT XPKcomRIEstados PRIMARY KEY  CLUSTERED (EstadoRI_Id ASC)
)
go



CREATE TABLE comRIMemo
( 
	comReqInterno        integer  NOT NULL ,
	Renglon_RI           integer  NOT NULL ,
	SubCategoria_Id      integer  NULL ,
	Detalle              QMemo ,
	CONSTRAINT XPKcomRIMemo PRIMARY KEY  CLUSTERED (comReqInterno ASC,Renglon_RI ASC)
)
go



CREATE TABLE comRISegmento
( 
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	comReqInterno        integer  NULL ,
	CONSTRAINT XPKcomRISegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC,Empresa_Id ASC)
)
go



CREATE TABLE comSubCategorias
( 
	comSubCategorias     integer IDENTITY ( 1,1 ) ,
	SubCategoria_Id      varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Categoria_Id         integer  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	CONSTRAINT XPKcomSubCategorias PRIMARY KEY  CLUSTERED (comSubCategorias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comSubCategorias ON comSubCategorias
( 
	SubCategoria_Id       ASC
)
go



CREATE TABLE comTipoPermiRI
( 
	comTipoPermiRI       integer IDENTITY ( 1,1 ) ,
	TipoPermiRI_Id       varchar(5)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	EsquemaAuto_Id       integer  NULL ,
	TipoCuerpo           char(1)  NOT NULL ,
	Reporte_Id           integer  NULL ,
	TipoRI               char(1)  NOT NULL ,
	UsuarioAutorizado_Id integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKcomTipoPermiRI PRIMARY KEY  CLUSTERED (comTipoPermiRI ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1comTipoPermiRI ON comTipoPermiRI
( 
	TipoPermiRI_Id        ASC
)
go




ALTER TABLE comCategorias
	ADD CONSTRAINT V2R_4389 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comCategorias
	ADD CONSTRAINT V2R_4390 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE comEsquemaAuto
	ADD CONSTRAINT V2R_4365 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comEsquemaAuto
	ADD CONSTRAINT V2R_4369 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE comEsquemaAutoReng
	ADD CONSTRAINT V2R_4399 FOREIGN KEY (EsquemaAuto_Id) REFERENCES comEsquemaAuto(comEsquemaAuto)
go




ALTER TABLE comEsquemaAutoReng
	ADD CONSTRAINT V2R_4400 FOREIGN KEY (NivelAuto_Id) REFERENCES comNivelesAuto(comNivelesAuto)
go




ALTER TABLE comNivelesAuto
	ADD CONSTRAINT V2R_4367 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comNivelesAuto
	ADD CONSTRAINT V2R_4368 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE comOCRI
	ADD CONSTRAINT V2R_4403 FOREIGN KEY (comReqInterno,Renglon_RI) REFERENCES comRICuerpo(comReqInterno,Renglon_RI)
go




ALTER TABLE comOCRI
	ADD CONSTRAINT V2R_4404 FOREIGN KEY (comOrdenComp,Renglon_OC) REFERENCES comOCCuerpo(comOrdenComp,Renglon_OC)
go




ALTER TABLE comReqInterno
	ADD CONSTRAINT V2R_4376 FOREIGN KEY (TipoPermi_Id) REFERENCES comTipoPermiRI(comTipoPermiRI)
go




ALTER TABLE comReqInterno
	ADD CONSTRAINT V2R_4377 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comReqInterno
	ADD CONSTRAINT V2R_4378 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE comReqInterno
	ADD CONSTRAINT V2R_4379 FOREIGN KEY (EstadoRI_Id) REFERENCES comRIEstados(EstadoRI_Id)
go




ALTER TABLE comRIArticulo
	ADD CONSTRAINT V2R_4384 FOREIGN KEY (comReqInterno,Renglon_RI) REFERENCES comRICuerpo(comReqInterno,Renglon_RI)
go




ALTER TABLE comRIArticulo
	ADD CONSTRAINT V2R_4385 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE comRIArticulo
	ADD CONSTRAINT V2R_4388 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE comRIAutorizando
	ADD CONSTRAINT V2R_4396 FOREIGN KEY (comReqInterno) REFERENCES comReqInterno(comReqInterno)
go




ALTER TABLE comRIAutorizando
	ADD CONSTRAINT V2R_4397 FOREIGN KEY (NivelAuto_Id) REFERENCES comNivelesAuto(comNivelesAuto)
go




ALTER TABLE comRIAutorizando
	ADD CONSTRAINT V2R_4398 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comRICuerpo
	ADD CONSTRAINT V2R_4380 FOREIGN KEY (comReqInterno) REFERENCES comReqInterno(comReqInterno)
go




ALTER TABLE comRICuerpo
	ADD CONSTRAINT V2R_4381 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE comRICuerpo
	ADD CONSTRAINT V2R_4382 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE comRICuerpo
	ADD CONSTRAINT V2R_4383 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE comRICuerpo
	ADD CONSTRAINT V2R_4387 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE comRIDesechado
	ADD CONSTRAINT V2R_4401 FOREIGN KEY (comReqInterno) REFERENCES comReqInterno(comReqInterno)
go




ALTER TABLE comRIDesechado
	ADD CONSTRAINT V2R_4402 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comRIMemo
	ADD CONSTRAINT V2R_4394 FOREIGN KEY (comReqInterno,Renglon_RI) REFERENCES comRICuerpo(comReqInterno,Renglon_RI)
go




ALTER TABLE comRIMemo
	ADD CONSTRAINT V2R_4395 FOREIGN KEY (SubCategoria_Id) REFERENCES comSubCategorias(comSubCategorias)
go




ALTER TABLE comRISegmento
	ADD CONSTRAINT V2R_4373 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE comRISegmento
	ADD CONSTRAINT V2R_4374 FOREIGN KEY (comReqInterno) REFERENCES comReqInterno(comReqInterno)
go




ALTER TABLE comRISegmento
	ADD CONSTRAINT V2R_4375 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE comSubCategorias
	ADD CONSTRAINT V2R_4391 FOREIGN KEY (Categoria_Id) REFERENCES comCategorias(comCategorias)
go




ALTER TABLE comSubCategorias
	ADD CONSTRAINT V2R_4392 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE comSubCategorias
	ADD CONSTRAINT V2R_4393 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE comTipoPermiRI
	ADD CONSTRAINT V2R_4364 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comTipoPermiRI
	ADD CONSTRAINT V2R_4366 FOREIGN KEY (EsquemaAuto_Id) REFERENCES comEsquemaAuto(comEsquemaAuto)
go




ALTER TABLE comTipoPermiRI
	ADD CONSTRAINT V2R_4370 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE comTipoPermiRI
	ADD CONSTRAINT V2R_4371 FOREIGN KEY (Reporte_Id) REFERENCES genReportes(genReportes)
go




ALTER TABLE comTipoPermiRI
	ADD CONSTRAINT V2R_4372 FOREIGN KEY (UsuarioAutorizado_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE comNivelesAutoUsu
	ADD CONSTRAINT V2R_4405 FOREIGN KEY (NivelAuto_Id) REFERENCES comNivelesAuto(comNivelesAuto)
go




ALTER TABLE comNivelesAutoUsu
	ADD CONSTRAINT V2R_4406 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




insert into genVersion (Version) Values(527.000)
GO