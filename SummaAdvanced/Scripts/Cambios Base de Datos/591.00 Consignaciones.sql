CREATE TABLE stkMoviConsigna(
	stkMoviCabe BigInt NOT NULL, 
	Renglon int Not null, 
	comOrdenComp Int NOT NULL, 
	Renglon_OC Int NOT Null, 
	Cantidad QCantidadD8 Not NULL,
	PRIMARY KEY(stkMoviCabe, Renglon, comOrdenComp, Renglon_OC)
)
GO

Alter table stkMoviConsigna add constraint fkstkMoviConsignaMC  foreign Key (stkMoviCabe, Renglon)
	references stkMoviCuerpo
GO

Alter table stkMoviConsigna add constraint fkstkMoviConsignaOC foreign Key (comOrdenComp, Renglon_OC)
	references comOcCuerpo
GO

Alter table comOcCuerpo Add CantidadConsignada QCantidadD8  NULL
GO
Update comOcCuerpo SET CantidadConsignada = 0
GO

Alter table comOcCuerpo Alter Column CantidadConsignada QCantidadD8  NOT NULL
GO


INSERT INTO genVersion(Version) Values(591.00)
GO


