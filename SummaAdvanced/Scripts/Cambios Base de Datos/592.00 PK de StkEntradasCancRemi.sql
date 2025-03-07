DROP table stkEntradasCancRemi
GO
CREATE table stkEntradasCancRemi(
	stkMoviCabeEntrada bigint NOT NULL, 
	RenglonEntrada Int NOT NULL,
	stkMoviCabeRemi BigInt NOT NULL, 
	RenglonRemi Int Not NULL,
	Cantidad QCantidadD8 NOT NULL, 
	Primary Key(stkMoviCabeEntrada,RenglonEntrada))
GO

ALTER TABLE stkEntradasCancRemi ADD CONSTRAINT fkstkEntradasCancRemiEnt 
	Foreign Key (stkMoviCabeEntrada, RenglonEntrada) References stkMoviCuerpo
GO

ALTER TABLE stkEntradasCancRemi ADD CONSTRAINT fkstkEntradasCancRemiRemi 
	Foreign Key (stkMoviCabeRemi, RenglonRemi) References stkMoviCuerpo
GO

insert into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id)
VALUES('ECR','E','Entrada_por_Cancelacion_Remitos',1, 1,null)

INSERT INTO genVersion(Version) Values(592.00)
GO



