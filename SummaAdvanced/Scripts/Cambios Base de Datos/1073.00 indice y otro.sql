CREATE NONCLUSTERED INDEX idxgencanmovFecha ON [dbo].[genCancMov]
(
	FechaAplicacion ASC
)
GO

ALTER TABLE venCompCartaPorte ALTER COLUMN UnidadPeso  varchar(5)  NULL 
go

INSERT INTO genVersion(Version) Values(1073.00)
GO
