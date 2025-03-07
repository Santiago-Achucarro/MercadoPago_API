ALTER TABLE impLiquidacion ADD SePaga Bit NOT NULL
ALTER TABLE impLiquidacion ADD tesMovimientos BigInt 

DROP Table tesMoviImp
GO

INSERT INTO genVersion (Version) Values(519.000)
GO
