IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 14.00)
begin

INSERT INTO genVersion(Version) Values(14.00);

DROP PROCEDURE comFactRemiPendDatos;
DROP PROCEDURE comFactRemiPendGuardar;
DROP PROCEDURE comFactRemiPendEliminar;
drop table comFactRemiPend;
DROP PROCEDURE comRemiPendDatos;
DROP PROCEDURE comRemiPendGuardar;
DROP PROCEDURE comRemiPendEliminar;
drop table comRemiPend;

ALTER Table comRemiPendFact add PrecioFacturado Numeric(19,8) NOT NULL;
ALTER Table comRemiPendFact add CantidadOriginalFact Numeric(19,8) NOT NULL;

INSERT INTO stkSubTipoMov(SubTipoMov_Id, TipoMov, Descripcion,Consumo,CantCopias) VALUES('RFR', 'RV', 'Revaluo_Facturas_Remisiones', 0, 1)

END
GO



