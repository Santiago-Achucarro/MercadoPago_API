ALTER TABLE venCotizCuerpo Add TipoPrecio Char(1)
GO

Update venCotizCuerpo SET TipoPrecio = CASE WHEN  PrecioForm = PrecioListaForm THEN  'L' ELSE 'M' END
GO


ALTER TABLE venCotizCuerpo Alter Column TipoPrecio Char(1) NOT NULL
GO

INSERT INTO genVersion(Version) Values(1038.00)
GO