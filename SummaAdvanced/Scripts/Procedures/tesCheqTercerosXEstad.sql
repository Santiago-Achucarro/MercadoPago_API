-- FM 19/08/2021 No tenía Order by. Ahora Order by tesCheqTerceros.FechaVencimiento
-- tesCheqTercerosXEstadoDatos 1, 'CHMX', 'C', NULL
DROP PROCEDURE tesCheqTercerosXEstadoDatos
GO
CREATE PROCEDURE tesCheqTercerosXEstadoDatos (
	@Empresa_Id int, 
	@Cartera_Id Char(5), 
	@Estado_Id Char(1),
	@FechaHasta DateTime=NULL)
AS

SELECT @Empresa_Id as Empresa_id, @Cartera_Id as Cartera_Id, @Estado_Id as Estado_id, 
	@FechaHasta as FechaDesde, @FechaHasta as FechaHasta


SELECT CAST(0 as bit) as Marca ,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.sucBanco, 
	tesCheqTerceros.numCheque, tesCheqTerceros.Estado_id,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesCheqTerceros.tesCheqTerceros, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal 
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesBancos ON tesBancos.tesBancos = tesCheqTerceros.Banco_Id
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros AND
	tesCTlink.Secuencia = tesCheqTerceros.SecuenciaActual
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos and 
	tesRengMovi.conRenglon = tesCTlink.conRenglon
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
inner join conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
WHERE
	conAsientos.Empresa_Id = @Empresa_Id and conAsientos.Anulado = 0 And
	tesIdentifica.Cartera_Id = @Cartera_Id and
	tesCheqTerceros.Estado_Id = @Estado_Id and 
	tesCheqTerceros.FechaVencimiento <= ISNULL(@FechaHasta, tesCheqTerceros.FechaVencimiento)
Order by tesCheqTerceros.FechaVencimiento
GO


-- tesCheqTercerosXEstadoDatos 1, 'CHMX', 'C', NULL
DROP PROCEDURE tesCheqTercerosXEstado2Datos
GO
CREATE PROCEDURE tesCheqTercerosXEstado2Datos (
	@Empresa_Id int, 
	@Cartera_Id Char(5), 
	@Estado_Id Char(1),
	@FechaDesde DateTime,
	@FechaHasta DateTime
	)
AS

SELECT @Empresa_Id as Empresa_id, @Cartera_Id as Cartera_Id, @Estado_Id as Estado_id, 
	@FechaDesde FechaDesde,  @FechaHasta as FechaHasta


SELECT CAST(0 as bit) as Marca ,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.sucBanco, 
	tesCheqTerceros.numCheque, tesCheqTerceros.Estado_id,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesCheqTerceros.tesCheqTerceros, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal 
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesBancos ON tesBancos.tesBancos = tesCheqTerceros.Banco_Id
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros AND
	tesCTlink.Secuencia = tesCheqTerceros.SecuenciaActual
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos and 
	tesRengMovi.conRenglon = tesCTlink.conRenglon
	INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
inner join conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
WHERE
	conAsientos.Empresa_Id = @Empresa_Id and conAsientos.Anulado = 0 And
	tesIdentifica.Cartera_Id = @Cartera_Id and
	tesCheqTerceros.Estado_Id = @Estado_Id and 
	tesCheqTerceros.FechaVencimiento Between @FechaDesde and @FechaHasta
Order by tesCheqTerceros.FechaVencimiento
GO


-- tesCheqTercerosRechazadosClieDatos 1,'A0005'

DROP PROCEDURE tesCheqTercerosRechazadosClieDatos
GO
CREATE PROCEDURE tesCheqTercerosRechazadosClieDatos (
	@Empresa_Id int, 
	@pCliente_Id VarChar(15), 
	@pCartera_Id VarChar(5)
)
AS

SELECT CAST(0 as bit) as Marca ,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.sucBanco, 
	tesCheqTerceros.numCheque, tesCheqTerceros.Estado_id,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesCheqTerceros.tesCheqTerceros, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal, ISNULL(tesCheqTerceros.CTCuit,'') CTCuit  
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesBancos ON tesBancos.tesBancos = tesCheqTerceros.Banco_Id
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros AND
	tesCTlink.Secuencia = tesCheqTerceros.SecuenciaActual
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos and 
	tesRengMovi.conRenglon = tesCTlink.conRenglon
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
inner join conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
WHERE
	conAsientos.Empresa_Id = @Empresa_Id and conAsientos.Anulado = 0 And
	venClientes.Cliente_Id = @pCliente_Id and 
	tesIdentifica.Cartera_Id = @pCartera_Id and 
	tesCheqTerceros.Estado_Id = 'R'
Order by tesCheqTerceros.FechaVencimiento
GO	