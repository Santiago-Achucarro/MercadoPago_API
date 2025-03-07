INSERT INTO genSegmentoOrigenes	(OriSeg_Id, Descripcion)	Values(12,'RellenoCon0');
GO
ALTER TABLE disControlesGrilla ADD FilasAMostrar int Default 0 NOT NULL;
ALTER TABLE disControlesGrilla ADD AnchoMinimo int Default 0 NOT NULL;
ALTER TABLE disControlesGrilla ADD AnchoColumnasFijas varchar(20);
ALTER TABLE disControlesGrilla ADD NombreColCalculoTotal varchar(30);
ALTER TABLE disControlesGrilla ADD ColFormatoNumericoFila varchar(30);
ALTER TABLE disControlesGrilla ADD TotalizaColumnas bit Default 0 NOT NULL; 

ALTER TABLE disControlesGrilla ADD ColumnasFijas varchar(256);
ALTER TABLE disControlesGrilla ADD ColumnasSoloLectura varchar(256);
ALTER TABLE disControlesGrilla ADD ColumnasTotalizarCantidad varchar(256);
ALTER TABLE disControlesGrilla ADD ColumnasTotalizarMinimo varchar(256);
ALTER TABLE disControlesGrilla ADD ColumnasTotalizarMaximo varchar(256);
ALTER TABLE disControlesGrilla ADD ColumnasTotalizarPromedio varchar(256);
ALTER TABLE disControlesGrilla ADD ColumnasTotalizarSuma varchar(256);

ALTER TABLE disControlesGrillaColumnas ADD TotalizarCantidad bit Default 0 NOT NULL; 
ALTER TABLE disControlesGrillaColumnas ADD TotalizarMinimo bit Default 0 NOT NULL;
ALTER TABLE disControlesGrillaColumnas ADD TotalizarMaximo bit Default 0 NOT NULL;
ALTER TABLE disControlesGrillaColumnas ADD TotalizarSuma bit Default 0 NOT NULL;
ALTER TABLE disControlesGrillaColumnas ADD TotalizarPromedio bit Default 0 NOT NULL;
GO
INSERT INTO genVersion(Version) Values(507.05);
GO

