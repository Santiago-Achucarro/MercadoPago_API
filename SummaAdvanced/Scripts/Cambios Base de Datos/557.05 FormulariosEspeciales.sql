
alter table disformularios add TipoEspecial char(1) null

GO
INSERT INTO genVersion (Version) Values(557.05)
GO

--Tengo que ejecutar este sp, para que se creen los temporales, y no de error despues los sp que utilizan los temporales
exec TempdisDisenioCopiarActual
GO
