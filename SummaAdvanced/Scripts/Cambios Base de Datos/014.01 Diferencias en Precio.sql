IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 14.01)
begin

	INSERT INTO genVersion(Version) Values(14.01);


CREATE TABLE comMovProvDPreFactDir
( 
 comMovProv           bigint  NOT NULL ,
 Renglon              integer  NOT NULL ,
 stkMoviCabe          bigint  NULL ,
 RenglonStk           integer  NULL ,
 CantidadOriginal     qCantidadD8 ,
 Cantidad             qCantidadD8 ,
 Descuento            qPorcentaje ,
 Monto                qMonedaD8 ,
 CONSTRAINT XPKcomMovProvDPre PRIMARY KEY  CLUSTERED (comMovProv ASC,Renglon ASC)
);




CREATE TABLE comMovProvDPreOC
( 
 comMovProv           bigint  NOT NULL ,
 Renglon              integer  NOT NULL ,
 comMovProvFactOrig   bigint  NULL ,
 comOrdenComp         integer  NULL ,
 Renglon_OC           integer  NULL ,
 CantidadOriginal     qCantidadD8 ,
 Cantidad             qCantidadD8 ,
 Descuento            qPorcentaje ,
 Monto                qMonedaD8 ,
 CONSTRAINT XPKcomMovProvDPreOC PRIMARY KEY  CLUSTERED (comMovProv ASC,Renglon ASC)
);

ALTER TABLE comMovProvDPreFactDir
 ADD CONSTRAINT R_3947 FOREIGN KEY (comMovProv) REFERENCES comMovProv(comMovProv);

DROP TABLE stkMoviCuerpoDpre;

end