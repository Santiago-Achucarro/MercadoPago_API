
CREATE NONCLUSTERED INDEX idxAsientosVivos
ON [dbo].[conAsientos] ([Anulado],[Posteado],[Fecha])

GO

INSERT INTO genVersion (Version) Values(1045.00)
GO

