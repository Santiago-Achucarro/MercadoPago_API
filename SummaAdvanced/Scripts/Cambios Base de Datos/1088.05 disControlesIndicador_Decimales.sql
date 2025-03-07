ALTER TABLE disControlesIndicador ADD Decimales smallint default 0 NOT NULL
GO
exec TempdisDisenioCopiarActual
GO
INSERT INTO genVersion (Version) VALUES(1088.05)
GO