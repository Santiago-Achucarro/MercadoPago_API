ALTER TABLE disControlesGrilla add ExpandirHastaNivel smallint default 0 not null
GO
exec TempdisDisenioCopiarActual
GO
INSERT INTO genVersion (Version) VALUES(1090.05)
GO