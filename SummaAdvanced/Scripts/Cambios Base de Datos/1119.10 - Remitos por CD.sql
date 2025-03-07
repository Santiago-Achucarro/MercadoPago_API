INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('CER', 'E','Cambio_de_deposito_Entrada_con_Remito',0,1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('CSR', 'S','Cambio_de_deposito_Salida_con_Remito',0,1)
Go

exec genReportesGuardar 'STKREMICD','STKREMICD','Remitos_Clientes','InventariosReportes','stkRemiClie',1,1,'inf_stkMoviCabeH','STK'
exec genReportesSPGuardar 'STKREMICD',1,'inf_stkMoviCuerpoRemiH','Cuerpo'
exec genReportesSPGuardar 'STKREMICD',2,'inf_stkMoviSerieH','MoviSerie'
exec genReportesSPGuardar 'STKREMICD',3,'inf_stkMoviDespaH','MoviDespa'
exec genReportesSPGuardar 'STKREMICD',4,'inf_stkRemiCD','Remitos'
exec genReportesSPGuardar 'STKREMICD',5,'inf_stkMoviCausa','Causa'

Update stkSubTipoMov Set Reporte_Id = dbo.FuncFKgenReportes('STKREMICD') Where SubTipoMov_Id = 'CSR'

Insert Into genVersion (Version) Values (1119.10)
Go



