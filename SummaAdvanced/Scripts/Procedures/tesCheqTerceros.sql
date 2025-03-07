-- FM 21/12/2022 tesCheqTercerosXCheque. Si cargabas un cheque y anulabas la cobranza ya no permitía volver a usar el mismo cheque --

DROP PROCEDURE tesCheqTercerosGuardar
GO
CREATE PROCEDURE tesCheqTercerosGuardar
(
@ptesCheqTerceros int,
@pCartera_Id VarChar(5),
@pBanco_Id varchar(3),
@pClearing varchar(3),
@pSecuenciaActual smallint,
@pClearingDias smallint,
@pFechaVencimiento datetime,
@pFechaAcreditacion datetime = NULL,
@pFechaConciliacion datetime = NULL,
@psucBanco varchar(15),
@pnumCheque int,
@pEstado_Id char(1),
@pCliente_Id VarChar(15) = NULL,
@pcuentaBanco varchar(15),
@pBancoConc char(5) = NULL,
@pNumeroConc int = NULL,
@pEmpresa_Id int = NULL,
@pBancoConcVta char(5) = NULL,
@pNumeroConcVta int = NULL,
@pCTCuit VARchar(25) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesCheqTerceros WHERE (tesCheqTerceros = @ptesCheqTerceros)))
BEGIN 
	UPDATE tesCheqTerceros
	SET		Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id),
		Banco_Id = dbo.FuncFKtesBancos(@pBanco_Id),
		Clearing = @pClearing,
		SecuenciaActual = @pSecuenciaActual,
		ClearingDias = @pClearingDias,
		FechaVencimiento = @pFechaVencimiento,
		FechaAcreditacion = @pFechaAcreditacion,
		FechaConciliacion = @pFechaConciliacion,
		sucBanco = @psucBanco,
		numCheque = @pnumCheque,
		Estado_Id = @pEstado_Id,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		cuentaBanco = @pcuentaBanco,
		BancoConc = dbo.FuncFKtesIdentifica(@pBancoConc),
		NumeroConc = @pNumeroConc,
		BancoConcVta = dbo.FuncFKtesIdentifica(@pBancoConcVta),
		NumeroConcVta = @pNumeroConcVta, 
		CTCuit = @pCTCuit,
		Empresa_Id = @pEmpresa_Id
	WHERE (tesCheqTerceros = @ptesCheqTerceros)
END 
ELSE 
BEGIN 
	INSERT INTO tesCheqTerceros
	(
		Cartera_Id,
		Banco_Id,
		Clearing,
		SecuenciaActual,
		ClearingDias,
		FechaVencimiento,
		FechaAcreditacion,
		FechaConciliacion,
		sucBanco,
		numCheque,
		Estado_Id,
		Cliente_Id,
		cuentaBanco,
		BancoConc,
		NumeroConc,
		Empresa_Id,
		BancoConcVta,
		NumeroConcVta,
		CTCuit
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		dbo.FuncFKtesBancos(@pBanco_Id),
		@pClearing,
		@pSecuenciaActual,
		@pClearingDias,
		@pFechaVencimiento,
		@pFechaAcreditacion,
		@pFechaConciliacion,
		@psucBanco,
		@pnumCheque,
		@pEstado_Id,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pcuentaBanco,
		dbo.FuncFKtesIdentifica(@pBancoConc),
		@pNumeroConc,
		@pEmpresa_Id,
		dbo.FuncFKtesIdentifica(@pBancoConcVta),
		@pNumeroConcVta,
		@pCTCuit
	)

SET @ptesCheqTerceros =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @ptesCheqTerceros as RetVal 

GO


DROP PROCEDURE tesCheqTercerosDatos
GO
CREATE PROCEDURE tesCheqTercerosDatos
(
@ptesCheqTerceros int
)
AS
SET NOCOUNT ON 

SELECT tesCheqTerceros.tesCheqTerceros, tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionIdentifica, 
	tesBancos.Banco_Id,	tesBancos.Descripcion as DescripcionBancos, 
	tesCheqTerceros.Clearing, tesClearing.Descripcion as DescripcionClearing, 
	tesCheqTerceros.SecuenciaActual, tesCheqTerceros.ClearingDias, 
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.FechaAcreditacion, 
	tesCheqTerceros.FechaConciliacion,	tesCheqTerceros.sucBanco, tesCheqTerceros.numCheque, 
	tesCheqTerEstado.Estado_Id, tesCheqTerEstado.Descripcion as DescripcionCheqTerEstado,
	venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionClientes, 
	tesCheqTerceros.cuentaBanco, BancoConc.Cartera_Id BancoConc,
	tesCheqTerceros.NumeroConc,  BancoConcVta.Cartera_Id BancoConcVta, tesCheqTerceros.NumeroConcVta,
	tesCheqTerceros.CTCuit, tesCheqTerceros.Empresa_Id
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesCheqTerceros.Cartera_Id
INNER JOIN tesIdCheqTerceros  ON (tesIdCheqTerceros.Cartera_Id = tesCheqTerceros.Cartera_Id)
INNER JOIN tesBancos  ON (tesBancos.tesBancos = tesCheqTerceros.Banco_Id)
INNER JOIN tesClearing  ON (tesClearing.Clearing = tesCheqTerceros.Clearing)
INNER JOIN tesCheqTerEstado  ON (tesCheqTerEstado.Estado_Id = tesCheqTerceros.Estado_Id)
LEFT JOIN venClientes  ON (venClientes.genEntidades = tesCheqTerceros.Cliente_Id)
LEFT JOIN tesIdentifica BancoConc ON BancoConc.tesIdentifica = tesCheqTerceros.BancoConc
LEFT JOIN tesIdentifica BancoConcVta ON BancoConcVta.tesIdentifica = tesCheqTerceros.BancoConcVta
WHERE (tesCheqTerceros = @ptesCheqTerceros)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesCheqTercerosEliminar
GO
CREATE PROCEDURE tesCheqTercerosEliminar
(
@ptesCheqTerceros int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesCheqTerceros 
WHERE (tesCheqTerceros = ISNULL(@ptesCheqTerceros, tesCheqTerceros))
 
 RETURN @@Error 

GO



DROP PROCEDURE tesCheqTercerosConciliar
GO
CREATE PROCEDURE tesCheqTercerosConciliar
(
@ptesCheqTerceros int,
@pBancoConc char(5), 
@pNumeroConc int , 
@pEmpresa_Id int
)
AS
	UPDATE tesCheqTerceros
		SET BancoConc = dbo.FuncFKtesIdentifica(@pBancoConc),
		NumeroConc = @pNumeroConc, Empresa_Id = @pEmpresa_Id
	WHERE (tesCheqTerceros = @ptesCheqTerceros)
GO


DROP PROCEDURE tesCheqTercerosBancoDepo
GO
CREATE PROCEDURE tesCheqTercerosBancoDepo
(
	@pTesCheqterceros int
)
AS

SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion
FROM tesCTlink 
INNER JOIN tesRengMovi on tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND conMovCont.Renglon = tesRengMovi.conRenglon AND conMovCont.TipoMov = 1
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
Where tesCTlink.Estado_Id = 'N' AND tesCTlink.tesCheqTerceros = @pTesCheqterceros
And conAsientos.Anulado = 0
GO



DROP PROCEDURE tesCheqTercerosModificar
GO
CREATE PROCEDURE tesCheqTercerosModificar
(
@ptesCheqTerceros int,
@pBanco_Id varchar(3),
@pClearing varchar(3),
@pFechaVencimiento datetime,
@psucBanco varchar(15),
@pnumCheque int,
@pEmpresa_Id int = NULL,
@pcuentaBanco varchar(15)
)
AS
SET NOCOUNT ON 
BEGIN 
	UPDATE tesCheqTerceros
	SET	Banco_Id = dbo.FuncFKtesBancos(@pBanco_Id),
		Clearing = @pClearing,
		FechaVencimiento = @pFechaVencimiento,
		sucBanco = @psucBanco,
		numCheque = @pnumCheque,
		cuentaBanco = @pcuentaBanco,
		Empresa_Id = @pEmpresa_Id
	WHERE (tesCheqTerceros = @ptesCheqTerceros)
END 
GO

DROP PROCEDURE tesCheqTercerosProveedor
GO
CREATE PROCEDURE tesCheqTercerosProveedor
(
	@pTesCheqterceros int
)
AS

SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda,
conAsientos.Cambio, conAsientos.CambioMonedaOriginal, conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta, comMovProv.TipoCtaProv
FROM tesCTlink 
INNER JOIN tesRengMovi On tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos  AND 
	conMovCont.Renglon = tesRengMovi.conRenglon AND
	conMovCont.TipoMov = 1
INNER JOIN comMovProv ON comMovProv.comMovProv = tesCTlink.tesMovimientos
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
Where tesCTlink.Estado_Id = 'P' AND tesCTlink.tesCheqTerceros = @pTesCheqterceros
And conAsientos.Anulado = 0
GO

DROP PROCEDURE tesCheqTercerosEgresosVarios
GO
CREATE PROCEDURE tesCheqTercerosEgresosVarios
(
	@pTesCheqterceros int
)
AS

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion DescripcionIdentifica,
conAsientos.Cambio, conAsientos.CambioMonedaOriginal, conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
FROM tesCTlink
Inner Join tesCheqTerceros On tesCheqTerceros.tesCheqTerceros = tesCTLink.tesCheqTerceros
INNER JOIN tesRengMovi On tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos  AND 
	conMovCont.Renglon = tesRengMovi.conRenglon AND
	conMovCont.TipoMov = 1
Inner Join conAsientos On conAsientos.conAsientos = tesCTlink.tesMovimientos
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = conMovCont.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = conMovCont.Centro2_Id
Inner Join genMenus On genMenus.Formulario_Id = conAsientos.Formulario_Id
Where genMenus.Orden = '622020' And tesCTlink.Secuencia = tesCheqTerceros.SecuenciaActual And tesCTlink.tesCheqTerceros = @pTesCheqterceros
And conAsientos.Anulado = 0
GO



DROP PROCEDURE tesCheqTercerosXCheque
GO
CREATE PROCEDURE tesCheqTercerosXCheque
(
@pEmpresa_Id int,
@pBanco_Id varchar(3),
@pcuentaBanco varchar(15),
@pnumCheque int
)
AS
SET NOCOUNT ON 

SELECT tesCheqTerceros.tesCheqTerceros, tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionIdentifica, 
	tesBancos.Banco_Id,	tesBancos.Descripcion as DescripcionBancos, 
	tesCheqTerceros.Clearing, tesClearing.Descripcion as DescripcionClearing, 
	tesCheqTerceros.SecuenciaActual, tesCheqTerceros.ClearingDias, 
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.FechaAcreditacion, 
	tesCheqTerceros.FechaConciliacion,	tesCheqTerceros.sucBanco, tesCheqTerceros.numCheque, 
	tesCheqTerEstado.Estado_Id, tesCheqTerEstado.Descripcion as DescripcionCheqTerEstado,
	venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionClientes, 
	tesCheqTerceros.cuentaBanco, BancoConc.Cartera_Id BancoConc,
	tesCheqTerceros.NumeroConc,  BancoConcVta.Cartera_Id BancoConcVta, tesCheqTerceros.NumeroConcVta,
	tesCheqTerceros.CTCuit, tesCheqTerceros.Empresa_Id
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesCheqTerceros.Cartera_Id
INNER JOIN tesIdCheqTerceros  ON (tesIdCheqTerceros.Cartera_Id = tesCheqTerceros.Cartera_Id)
INNER JOIN tesBancos  ON (tesBancos.tesBancos = tesCheqTerceros.Banco_Id)
INNER JOIN tesClearing  ON (tesClearing.Clearing = tesCheqTerceros.Clearing)
INNER JOIN tesCheqTerEstado  ON (tesCheqTerEstado.Estado_Id = tesCheqTerceros.Estado_Id)
Inner Join tesCTlink On tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros And tesCTlink.Secuencia = 1
Inner Join conAsientos On conAsientos.conAsientos = tesCTlink.tesMovimientos
LEFT JOIN venClientes  ON (venClientes.genEntidades = tesCheqTerceros.Cliente_Id)
LEFT JOIN tesIdentifica BancoConc ON BancoConc.tesIdentifica = tesCheqTerceros.BancoConc
LEFT JOIN tesIdentifica BancoConcVta ON BancoConcVta.tesIdentifica = tesCheqTerceros.BancoConcVta
WHERE
conAsientos.Empresa_Id = @pEmpresa_Id And
conAsientos.Anulado = 0 And
tesBancos.Banco_Id = @pBanco_Id And
tesCheqTerceros.cuentaBanco = @pcuentaBanco And
tesCheqTerceros.numCheque = @pnumCheque
 
RETURN @@Error

GO