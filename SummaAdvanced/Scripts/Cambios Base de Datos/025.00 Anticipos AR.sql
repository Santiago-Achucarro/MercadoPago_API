IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 25.00)
begin

INSERT INTO genVersion(Version) Values(25.00);



CREATE TABLE venMoviAnticipo
( 
	venMovimientos       bigint  NOT NULL ,
	Porcentaje           qPorcentaje ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKvenMoviAnticipo PRIMARY KEY  CLUSTERED (venMovimientos ASC)
);

ALTER TABLE venMoviAnticipo
	ADD CONSTRAINT R_3978 FOREIGN KEY (venMovimientos) REFERENCES venMovimientos(venMovimientos);
	
end

