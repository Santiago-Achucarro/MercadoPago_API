ALTER TABLE disFormulariosComentarios ADD Comentario_Id int NULL
ALTER TABLE disFormulariosComentarios ADD TipoComentario char(1) NULL
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1040.05);

GO
