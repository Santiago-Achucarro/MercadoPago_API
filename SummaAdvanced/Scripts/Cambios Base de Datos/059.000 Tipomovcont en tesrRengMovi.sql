ALTER TABLE tesRengMovi Add TipomovCont numeric(1,0)
go
UPDATE tesRengMovi SET Tipomovcont = conMovCont.TipoMov
from conMovCont WHERE
conMovCont.conAsientos =tesRengMovi.tesMovimientos AND 
conMovCont.Renglon = tesRengMovi.conRenglon
GO

ALTER TABLE tesRengMovi Alter Column TipomovCont numeric(1,0) NOT NULL
go

Update conMovCont set Importe = -Importe, ImporteMonedaOriginal = -ImporteMonedaOriginal, TipoMov = case when TipoMov=1 then 2 else 1 end
	from  tesRengMovi WHERE
	conMovCont.conAsientos =tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon = tesRengMovi.conRenglon AND 
	conMovCont.Importe < 0
GO

insert into genVersion (Version) Values(59.000)
GO
