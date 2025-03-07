Create table genSegmentosForm(
	Segmento_Id Int NOT NULL, 
	OrdenFormulario VarChar(10) NOT NULL,
	Primary Key(Segmento_Id)
)
GO

Alter Table genSegmentosForm add Constraint fkgenSegmentosFormSeg
	Foreign Key (Segmento_Id) References genSegmentos
GO

INSERT INTO genVersion(Version) Values(1006.00)
GO

