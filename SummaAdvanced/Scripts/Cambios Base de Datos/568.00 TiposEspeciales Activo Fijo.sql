
IF NOT EXISTS(SELECT 1 FROM conTipoEspeciales WHERE TipoEspe_Id = 'AFVO')
BEGIN

INSERT INTO conTipoEspeciales(TipoEspe_Id, Descripcion) Values('AFVO','Activo Fijo')
INSERT INTO conTipoEspeciales(TipoEspe_Id, Descripcion) Values('AFAM','Depreciacion Acumulada')


INSERT INTO conTipoEspecialesCuerpo(TipoEspe_Id,Tipo_Id) Values('AFVO','BIUSO')
INSERT INTO conTipoEspecialesCuerpo(TipoEspe_Id,Tipo_Id) Values('AFAM','AMACU')

END

INSERT INTO genVersion (Version) Values(568.00)
GO

