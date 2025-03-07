
DROP INDEX [XAK1comPagosAnticipo] ON [dbo].[comPagosAnticipo]
GO

/****** Object:  Index [XAK1comPagosAnticipo]    Script Date: 9/25/2019 10:46:38 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [XAK1comPagosAnticipo] ON [dbo].[comPagosAnticipo]
(
	[Proveed_Id] ASC,
	[Moneda_Id] ASC,
	[Empresa_Id] ASC,
	[tesMovimientos] ASC,
	[FechaPago]

)
go

INSERT INTO genVersion (Version) Values(090.00)
GO