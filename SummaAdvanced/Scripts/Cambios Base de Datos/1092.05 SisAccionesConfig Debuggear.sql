ALTER TABLE sisAccionesConfig add ModoDebug SINO default 0 not null
GO
INSERT INTO genVersion (Version) VALUES(1092.05)
GO