ALTER TABLE disControlesLupa ALTER Column Filtros varchar(500)
GO
exec TempdisDisenioCopiarActual
GO
INSERT INTO genVersion (Version) VALUES(1089.05)
GO