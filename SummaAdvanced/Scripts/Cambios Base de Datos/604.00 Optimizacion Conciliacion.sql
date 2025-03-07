CREATE NONCLUSTERED INDEX ixtesRengMoviTMC
ON [dbo].[tesRengMovi] ([TipomovCont])
INCLUDE ([Cartera_Id])
GO

CREATE NONCLUSTERED INDEX ixtesRengMovCiTMC
ON [dbo].[tesRengMovi] ([Cartera_Id],[TipomovCont])


GO
CREATE NONCLUSTERED INDEX IXtesRengConcilEspTMR
ON [dbo].[tesRengConcilEsp] ([tesMovimientos],[conRenglon])

GO


INSERT INTO genVersion (Version) Values(604.00)
GO