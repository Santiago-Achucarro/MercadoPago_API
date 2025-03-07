-- INF_tesRendicionCaja '20180601','0001',' ', 1
DROP PROCEDURE INF_tesRendicionCaja
GO

CREATE PROCEDURE INF_tesRendicionCaja
(
	@Fecha DateTime, 
	@Sucursal VarChar(25), 
	@Cajero VarChar(25),
	@Empresa_Id Int
)

AS


-- Saldo Inicial


SELECT tesTiposId.Descripcion AS DescrcionTP, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	genMonedas.Moneda_Id,
	SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as MontoOriginal,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as Monto
FROM 
tesIdentifica INNER JOIN tesTiposId ON
tesIdentifica.TipoCartera = tesTiposId.tesTiposId
inner join tesRengMovi ON
tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
inner join tesMovimientos ON 
tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN conMovCont ON
conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
conMovCont.Renglon =tesRengMovi.conRenglon
INNER JOIN conAsientos ON
conAsientos.conAsientos = tesMovimientos.tesMovimientos
INNER JOIN genMonedas ON
genMonedas.genMonedas = tesIdentifica.Moneda_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr =conAsientos.Sucursal
WHERE
tesTiposId.TipoCartera in ('CP','EF','CT','CA') and 
conAsientos.Empresa_Id = @Empresa_Id and 
conAsientos.Fecha < @Fecha and
genSucursalesEmpr.Sucursal = @Sucursal and 
conAsientos.Anulado = 0 and
genUsuarios.Usuario_Id = CASE WHEN @Cajero=' ' THEN genUsuarios.Usuario_Id ELSE @Cajero END
group by tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	genMonedas.Moneda_Id, tesTiposId.Descripcion
order by 1,2

GO

DROP PROCEDURE INF_tesRendicionCajaMov
GO

CREATE PROCEDURE INF_tesRendicionCajaMov
(
	@Fecha DateTime, 
	@Sucursal VarChar(25), 
	@Cajero VarChar(25),
	@Empresa_Id Int
)

AS

-- Movimientos del Dia



SELECT tesTiposmov.Tipomov,  tesTiposmov.Descripcion as DescripcionTM,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion as DescripcionSTM, 	
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, genMonedas.Moneda_Id, 
	SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as MontoOriginal,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as Monto
FROM 
tesIdentifica INNER JOIN tesTiposId ON
tesIdentifica.TipoCartera = tesTiposId.tesTiposId
inner join tesRengMovi ON
tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
inner join tesMovimientos ON 
tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN conMovCont ON
conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
conMovCont.Renglon =tesRengMovi.conRenglon
INNER JOIN conAsientos ON
conAsientos.conAsientos = tesMovimientos.tesMovimientos
INNER JOIN genMonedas ON
genMonedas.genMonedas = tesIdentifica.Moneda_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN tesSubTiposMov ON
tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
INNER JOIN tesTiposmov ON
tesTiposmov.Tipomov = tesSubTiposMov.TipoMov
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE
tesTiposId.TipoCartera in ('CP','EF','CT','CA') and 
conAsientos.Empresa_Id = @Empresa_Id and 
conAsientos.Fecha = @Fecha and
conAsientos.Anulado = 0 and
genSucursalesEmpr.Sucursal = @Sucursal and 
genUsuarios.Usuario_Id = CASE WHEN @Cajero=' ' THEN genUsuarios.Usuario_Id ELSE @Cajero END
group by genMonedas.Moneda_Id, tesTiposmov.Tipomov,  tesTiposmov.Descripcion ,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion
order by 1,3,5

go

DROP PROCEDURE INF_tesRendicionCajaSF
GO

CREATE PROCEDURE INF_tesRendicionCajaSF
(
	@Fecha DateTime, 
	@Sucursal VarChar(25), 
	@Cajero VarChar(25),
	@Empresa_Id Int
)

AS

-- Saldo Final


SELECT tesTiposId.Descripcion AS DescrcionTP, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	genMonedas.Moneda_Id,
	SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as MontoOriginal,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as Monto
FROM 
tesIdentifica INNER JOIN tesTiposId ON
tesIdentifica.TipoCartera = tesTiposId.tesTiposId
inner join tesRengMovi ON
tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
inner join tesMovimientos ON 
tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN conMovCont ON
conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
conMovCont.Renglon =tesRengMovi.conRenglon
INNER JOIN conAsientos ON
conAsientos.conAsientos = tesMovimientos.tesMovimientos
INNER JOIN genMonedas ON
genMonedas.genMonedas = tesIdentifica.Moneda_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE
genSucursalesEmpr.Sucursal = @Sucursal and 
tesTiposId.TipoCartera in ('CP','EF','CT','CA') and 
conAsientos.Empresa_Id = @Empresa_Id and 
conAsientos.Fecha <= @Fecha and
conAsientos.Anulado = 0 and
conAsientos.Posteado = 1 and 
genUsuarios.Usuario_Id = CASE WHEN @Cajero=' ' THEN genUsuarios.Usuario_Id ELSE @Cajero END
group by tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	genMonedas.Moneda_Id, tesTiposId.Descripcion
order by 1,2

GO