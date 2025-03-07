
Create Table stkDevolucionesClie (
	stkMoviCabe bigint not null,
	venMovimientosFact bigint not null,
	venMovimientosNC bigint null,
	Renglon int not null,
	RenglonCuerpo int not null,
	RenglonNC int null
	PRIMARY KEY (stkMoviCabe, Renglon),
	FOREIGN KEY (stkmovicabe,Renglon) REFERENCES stkMoviCuerpo(stkMoviCabe,Renglon),
	FOREIGN KEY (venMovimientosFact,RenglonCuerpo) REFERENCES venMovConStockCr(venMovimientos,RenglonCuerpo),
	FOREIGN KEY (venMovimientosNC,RenglonNC) REFERENCES venMovConStockCr(venMovimientos,RenglonCuerpo))
 GO


insert into genVersion (Version) values (1008.06)
GO
