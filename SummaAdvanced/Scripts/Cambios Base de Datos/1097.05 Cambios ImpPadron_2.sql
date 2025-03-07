ALTER TABLE impPadron add LineaInicioDatos int Default 1 not null
ALTER TABLE impPadron add LongDevolucion int Default 4 not null
ALTER TABLE impPadron add TextoAReemplazar varchar(20) null
ALTER TABLE impPadron add TextoDeReeemplazo varchar(20) null
ALTER TABLE impPadron add Configurable Sino Default 0 not null 
GO
Update impPadron
SET Configurable = 1
where (PosInicioCUIT is not null) 
	  and (PosInicioDevolucion is not null) 

GO

INSERT INTO genVersion (Version) VALUES(1097.05)
GO

