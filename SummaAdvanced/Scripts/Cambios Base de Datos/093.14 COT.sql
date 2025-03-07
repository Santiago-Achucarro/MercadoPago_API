ALTER TABLE stkHojaDeRuta ADD FormaEntrega_Id integer NULL
GO
ALTER TABLE stkHojaDeRuta ADD CONSTRAINT R_4101 FOREIGN KEY (FormaEntrega_Id) REFERENCES venFormaEntrega(venFormaEntrega)
GO

DROP TABLE stkCOTAr
GO
CREATE TABLE stkCOTAr
( 
	stkHojaDeRuta	integer  NOT NULL,
	Provincia_Id	integer  NOT NULL,
	Peso			qCantidadD8 ,
	Importe			qMonedaD2 ,
	COT				varchar(max)  NOT NULL ,
	CONSTRAINT XPKstkCOTAr PRIMARY KEY  CLUSTERED (stkHojaDeRuta ASC)
)
GO
ALTER TABLE stkCOTAr ADD CONSTRAINT R_3789 FOREIGN KEY (stkHojaDeRuta) REFERENCES stkHojaDeRuta(stkHojaDeRuta)
GO
ALTER TABLE stkCOTAr ADD CONSTRAINT R_4100 FOREIGN KEY (Provincia_Id) REFERENCES genProvincias(genProvincias)
GO

INSERT INTO genGlobales VALUES (1,'STKCOTLIMITE1','Límite de Cantidad de kgs para la generación del COT','N',14,2,0,'',NULL,NULL,'STK',0,NULL,NULL)
GO
INSERT INTO genGlobales VALUES (1,'STKCOTLIMITE2','Límite de precio para la generación del COT','N',14,2,0,'',NULL,NULL,'STK',0,NULL,NULL)
GO
INSERT INTO genGlobales VALUES (1,'STKCODKILOGRAMOS','Código de la Unidad de Medida Kilogramos "KGS"','C',5,0,0,'',NULL,NULL,'STK',0,NULL,NULL)
GO
INSERT INTO genGlobales VALUES (1,'STKCOTATRI','Atributo para Nomenclador COT','N',14,0,0,'',NULL,NULL,'STK',0,NULL,NULL)
GO

INSERT INTO genVersion (version) Values(93.14)
GO



