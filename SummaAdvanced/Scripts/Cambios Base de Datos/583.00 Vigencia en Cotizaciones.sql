Alter Table venCotizaciones add Vigencia DateTime 
GO
Update venCotizaciones set Vigencia = DateAdd(dd, 30, Fecha)
GO
Alter Table venCotizaciones Alter Column Vigencia DateTime NOT NULL
GO

INSERT INTO genVersion (Version) Values(583.00)
GO