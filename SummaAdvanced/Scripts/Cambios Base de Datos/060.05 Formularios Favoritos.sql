IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 60.05)
begin

CREATE TABLE genFavoritosUsuarios
(
	Usuario_Id int NOT NULL,
	OrdenFormularioMenu varchar(10) NOT NULL,
	FechaRegistro Datetime NOT NULL, 
	CONSTRAINT XPKgenFavoritosUsuarios PRIMARY KEY 
	(	
		Usuario_Id, OrdenFormularioMenu
	)
); 


ALTER TABLE genFavoritosUsuarios  ADD FOREIGN KEY(Usuario_Id) REFERENCES genUsuarios (genUsuarios);

--ALTER TABLE genFavoritosUsuarios  ADD FOREIGN KEY(OrdenFormularioMenu) REFERENCES genMenus (Orden);



CREATE TABLE genUltPaginasVisitadasUsuarios
(
	Usuario_Id int NOT NULL,
	OrdenFormularioMenu varchar(10) NOT NULL,
	FechaRegistro Datetime NOT NULL, 
	CONSTRAINT XPKgenUltPaginasVisitadasUsuarios PRIMARY KEY 
	(	
		Usuario_Id, OrdenFormularioMenu
	)
); 

ALTER TABLE genUltPaginasVisitadasUsuarios  ADD FOREIGN KEY(Usuario_Id) REFERENCES genUsuarios (genUsuarios);

-- ALTER TABLE genUltPaginasVisitadasUsuarios  ADD FOREIGN KEY(OrdenFormularioMenu) REFERENCES genMenus (Orden);

INSERT INTO genVersion(Version) Values(60.05);
END
GO
