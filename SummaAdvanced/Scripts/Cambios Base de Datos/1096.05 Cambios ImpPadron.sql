ALTER TABLE impPadron add PosInicioCUIT int 
ALTER TABLE impPadron add CUITConGuiones Sino default 0 not null 
ALTER TABLE impPadron add PosInicioDevolucion int
GO
INSERT INTO genVersion (Version) VALUES(1096.05)
GO


