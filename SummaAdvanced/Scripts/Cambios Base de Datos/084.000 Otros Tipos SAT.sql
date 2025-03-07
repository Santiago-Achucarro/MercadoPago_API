insert into genVersion (Version) Values(84.000)
GO

UPDATE  conTiposSat SET Descripcion = 'Devoluciones, descuentos o bonificaciones sobre ventas y/o servicios en zona fronteriza norte'  WHERE TipoSat_id ='402.02'
UPDATE  conTiposSat SET Descripcion = 'Devoluciones, descuentos o bonificaciones sobre ventas y/o servicios al 0%'  WHERE TipoSat_id like '402.03'
UPDATE  conTiposSat SET Descripcion = 'Devoluciones, descuentos o bonificaciones sobre ventas y/o servicios exentos'  WHERE TipoSat_id like '402.04'
UPDATE  conTiposSat SET Descripcion = 'Ventas y/o servicios exentos'  WHERE TipoSat_id like '401.10'
GO

INSERT INTO conTiposSat(TipoSat_id, Descripcion,Rubro,Circulante, Imputable) Values('402.05','Devoluciones, descuentos o bonificaciones de otros ingresos','ING',0,1)
GO