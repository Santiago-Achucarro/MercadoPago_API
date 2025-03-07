
ALter table comDespachos alter column Aduana_Id VarChar(3) NULL
Update comDespachos set Patente = LTRIM(rtrim(patente))
Update comDespachos set Anio = LTRIM(rtrim(Anio))
Update comDespachos set Pedimento = LTRIM(rtrim(Pedimento))
Update comDespachos set Aduana = LTRIM(rtrim(Aduana))
Update comDespachos set Aduana_ID = LTRIM(rtrim(Aduana_ID))

GO

INSERT INTO genVersion (Version) Values(088.00)
GO