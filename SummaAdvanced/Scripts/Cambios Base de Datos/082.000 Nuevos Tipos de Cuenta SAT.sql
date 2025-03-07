INSERT INTO genVersion (Version) Values(82.000)
GO
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados realizados en zona fronteriza norte ' Where TipoSat_id ='401.04';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados realizados en zona fronteriza norte de contado ' Where TipoSat_id ='401.05';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados realizados en zona fronteriza norte a crédito ' Where TipoSat_id ='401.06';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados al 0% ' Where TipoSat_id ='401.07';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados al 0% de contado ' Where TipoSat_id ='401.08';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados al 0% a crédito ' Where TipoSat_id ='401.09';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios exentos ' Where TipoSat_id ='401.1';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios exentos de contado ' Where TipoSat_id ='401.11';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios exentos a crédito ' Where TipoSat_id ='401.12';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados a la tasa general nacionales partes relacionadas ' Where TipoSat_id ='401.13';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados a la tasa general extranjeros partes relacionadas ' Where TipoSat_id ='401.14';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados al 0% nacionales partes relacionadas ' Where TipoSat_id ='401.15';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios gravados al 0% extranjeros partes relacionadas ' Where TipoSat_id ='401.16';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios exentos nacionales partes relacionadas ' Where TipoSat_id ='401.17';
UPDATE conTiposSat SET Descripcion='Ventas y/o servicios exentos extranjeros partes relacionadas ' Where TipoSat_id ='401.18';
UPDATE conTiposSat SET Descripcion='Ingresos por servicios administrativos ' Where TipoSat_id ='401.19';
UPDATE conTiposSat SET Descripcion='Ingresos por servicios administrativos nacionales partes relacionadas ' Where TipoSat_id ='401.2';
UPDATE conTiposSat SET Descripcion='Ingresos por servicios administrativos extranjeros partes relacionadas ' Where TipoSat_id ='401.21';
UPDATE conTiposSat SET Descripcion='Ingresos por servicios profesionales ' Where TipoSat_id ='401.22';
UPDATE conTiposSat SET Descripcion='Ingresos por servicios profesionales nacionales partes relacionadas ' Where TipoSat_id ='401.23';
UPDATE conTiposSat SET Descripcion='Ingresos por servicios profesionales extranjeros partes relacionadas ' Where TipoSat_id ='401.24';
UPDATE conTiposSat SET Descripcion='Ingresos por arrendamiento ' Where TipoSat_id ='401.25';
UPDATE conTiposSat SET Descripcion='Ingresos por arrendamiento nacionales partes relacionadas ' Where TipoSat_id ='401.26';
UPDATE conTiposSat SET Descripcion='Ingresos por arrendamiento extranjeros partes relacionadas ' Where TipoSat_id ='401.27';
UPDATE conTiposSat SET Descripcion='Ingresos por exportación ' Where TipoSat_id ='401.28';
UPDATE conTiposSat SET Descripcion='Ingresos por comisiones ' Where TipoSat_id ='401.29';
UPDATE conTiposSat SET Descripcion='Ingresos por maquila ' Where TipoSat_id ='401.3';
UPDATE conTiposSat SET Descripcion='Ingresos por coordinados ' Where TipoSat_id ='401.31';
UPDATE conTiposSat SET Descripcion='Ingresos por regalías ' Where TipoSat_id ='401.32';
UPDATE conTiposSat SET Descripcion='Ingresos por asistencia técnica ' Where TipoSat_id ='401.33';
UPDATE conTiposSat SET Descripcion='Ingresos por donativos ' Where TipoSat_id ='401.34';
UPDATE conTiposSat SET Descripcion='Ingresos por intereses (actividad propia) ' Where TipoSat_id ='401.35';
UPDATE conTiposSat SET Descripcion='Ingresos de copropiedad ' Where TipoSat_id ='401.36';
UPDATE conTiposSat SET Descripcion='Ingresos por fideicomisos ' Where TipoSat_id ='401.37';
UPDATE conTiposSat SET Descripcion='Ingresos por factoraje financiero ' Where TipoSat_id ='401.38';
INSERT INTO conTiposSat(TipoSat_id, Descripcion,Rubro,Circulante, Imputable) Values('401.39','Ingresos por arrendamiento financiero ','ING',0,1)
INSERT INTO conTiposSat(TipoSat_id, Descripcion,Rubro,Circulante, Imputable) Values('401.4','Ingresos de extranjeros con establecimiento en el país ','ING',0,1)
INSERT INTO conTiposSat(TipoSat_id, Descripcion,Rubro,Circulante, Imputable) Values('401.41','Otros ingresos propios ','ING',0,1)
