alter table discontrolesgrilla add AnchoColPorContenido bit not null default 0
GO

INSERT INTO genVersion (Version) Values(565.05)
GO

--Tengo que ejecutar este sp, para que se creen los temporales, y no de error despues los sp que utilizan los temporales
exec TempdisDisenioCopiarActual
GO

