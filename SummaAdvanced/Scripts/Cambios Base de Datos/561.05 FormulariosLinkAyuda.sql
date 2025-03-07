alter table disformularios add CodigoLnk varchar(25)
GO

INSERT INTO genVersion (Version) Values(561.05)
GO

--Tengo que ejecutar este sp, para que se creen los temporales, y no de error despues los sp que utilizan los temporales
exec TempdisDisenioCopiarActual
GO
