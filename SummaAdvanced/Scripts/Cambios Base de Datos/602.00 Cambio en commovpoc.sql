update conMovCont set  clase = 'FACAR' where clase = 'FACR'
GO
ALTER TABLE comMovPoc add Cambio Numeric(18,6)
GO
update commovpoc set cambio = ROUND(conMovCont.Importe / conMovCont.ImporteMonedaOriginal,4)
FROM conMovCont where conMovCont.Clase = 'FACAR' AND 
conMovCont.conAsientos = comMovPOC.comMovProv
GO

update commovpoc set cambio = ROUND(conMovCont.Importe / conMovCont.ImporteMonedaOriginal,4)
FROM conMovCont where conMovCont.Clase = 'OEFAR' AND 
conMovCont.conAsientos = comMovPOC.comMovProv
GO

update commovpoc set cambio = 1 where cambio is null 
GO

ALTER TABLE comMovPoc ALTER COLUMN Cambio Numeric(18,6) NOT NULL
GO

INSERT INTO genVersion(Version) Values(602.00)
GO


