IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 32.00)
begin

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES('RVS','RV', 'Revaluo_Manual', 0, 1, null);

CREATE Table stkMoviCabeCentro(
	stkMoviCabe BigInt NOT NULL, 
	Centro1_Id Int, 
	Centro2_Id int, 
	Primary key(stkMoviCabe));

Alter Table stkMoviCabeCentro ADD Constraint fkstkMoviCabeCentro
	Foreign Key(stkMoviCabe) References stkMoviCabe;


Alter Table stkMoviCabeCentro ADD Constraint fkstkMoviCabeCentroC1
	Foreign Key(Centro1_Id) References conCentro1;

Alter Table stkMoviCabeCentro ADD Constraint fkstkMoviCabeCentroC2
	Foreign Key(Centro2_Id) References conCentro2;


INSERT INTO genVersion(Version) Values(32.00);

end
go