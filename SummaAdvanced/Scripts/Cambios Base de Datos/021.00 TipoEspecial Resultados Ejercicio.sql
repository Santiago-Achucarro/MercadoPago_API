
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 21.00)
begin

INSERT INTO genVersion(Version) Values(21.00);

INSERT INTO conTipoEspeciales(TipoEspe_Id, Descripcion) VALUES('RESAC', 'RESULTADOS ACUMULADOS')
INSERT INTO conTipoEspeciales(TipoEspe_Id, Descripcion) VALUES('RESUL', 'RESULTADOS DEL EJERCICIO')

INSERT INTO conTipoEspecialesCuerpo(TipoEspe_Id, Tipo_Id) VALUES('RESAC', 'REACU')
INSERT INTO conTipoEspecialesCuerpo(TipoEspe_Id, Tipo_Id) VALUES('RESAC', 'REEJE')
INSERT INTO conTipoEspecialesCuerpo(TipoEspe_Id, Tipo_Id) VALUES('RESUL', 'REEJE')

end