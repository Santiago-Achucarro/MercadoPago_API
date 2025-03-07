INSERT INTO genVersion (Version) Values(37.00)

CREATE NONCLUSTERED INDEX idxConAsientos1
ON [dbo].[conAsientos] ([Empresa_Id],[Anulado],[Fecha])
INCLUDE ([conAsientos],[Especial])
GO

