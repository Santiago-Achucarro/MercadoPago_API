

CREATE NONCLUSTERED INDEX IDXcomMovImpAcreditaAsi
ON [dbo].[comMovImpAcredita] ([Asiento_Id],[RenglonHaber])
GO

CREATE NONCLUSTERED INDEX IDXcomMovImpAcreditaAsiDebe
ON [dbo].[comMovImpAcredita] ([Asiento_Id],[RenglonDebe])
GO

CREATE NONCLUSTERED INDEX IDXcomMovImpAcreditaAsidc
ON [dbo].[comMovImpAcredita] ([Asiento_Id],RenDifCambio)
GO


CREATE NONCLUSTERED INDEX IDXvenMovImpTrasladoAsi
ON [dbo].[venMovImpTraslado] ([Asiento_Id],[RenglonHaber])
GO

CREATE NONCLUSTERED INDEX IDXvenMovImpTrasladoAsiDebe
ON [dbo].[venMovImpTraslado] ([Asiento_Id],[RenglonDebe])
GO

CREATE NONCLUSTERED INDEX IDXvenMovImpTrasladoAsiDC
ON [dbo].[venMovImpTraslado] ([Asiento_Id],[RenDifCambio])
GO


INSERT INTO genVersion (Version) Values(1024.00)
GO



