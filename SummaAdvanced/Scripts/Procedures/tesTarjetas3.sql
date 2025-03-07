DROP PROCEDURE tesTarjetas3Guardar
GO
CREATE PROCEDURE tesTarjetas3Guardar
(
@ptesTarjetas3 int,
@pCartera_Id VarChar(5),
@pEstado char(1),
@pCuotas int,
@pCupon VarChar(20),
@pLote Int,
@pComercio int,
@pNroAutorizacion VarChar(25) = NULL,
@pNroTarjeta VarChar(20) = NULL,
@pSecuenciaActual smallint,
@pFechaConciliacion datetime = NULL,
@pBancoConc char(5) = NULL,
@pNumeroConc int = NULL,
@pCliente_Id VarChar(15) = NULL,
@pEmpresa_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesTarjetas3 WHERE (tesTarjetas3 = @ptesTarjetas3)))
BEGIN 
	UPDATE tesTarjetas3
	SET	Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id),
		Estado = @pEstado,
		Cuotas = @pCuotas,
		Cupon = @pCupon,
		Lote = @pLote,
		Comercio = @pComercio,
		NroAutorizacion = @pNroAutorizacion,
		NroTarjeta = @pNroTarjeta,
		SecuenciaActual = @pSecuenciaActual,
		FechaConciliacion = @pFechaConciliacion,
		BancoConc = dbo.FuncFKtesIdentifica(@pBancoConc),
		NumeroConc = @pNumeroConc,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Empresa_Id = @pEmpresa_Id

	WHERE (tesTarjetas3 = @ptesTarjetas3)
END 
ELSE 
BEGIN 
	INSERT INTO tesTarjetas3
	(
		Cartera_Id,
		Estado,
		Cuotas,
		Cupon,
		Lote,
		Comercio,
		NroAutorizacion,
		NroTarjeta,
		SecuenciaActual,
		FechaConciliacion,
		BancoConc,
		NumeroConc,
		Cliente_Id,
		Empresa_Id
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pEstado,
		@pCuotas,
		@pCupon,
		@pLote,
		@pComercio,
		@pNroAutorizacion,
		@pNroTarjeta,
		@pSecuenciaActual,
		@pFechaConciliacion,
		dbo.FuncFKtesIdentifica(@pBancoConc),
		@pNumeroConc,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pEmpresa_Id
	)

SET @ptesTarjetas3 =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @ptesTarjetas3 as RetVal 
GO


DROP PROCEDURE tesTarjetas3Datos
GO
CREATE PROCEDURE tesTarjetas3Datos
(
@ptesTarjetas3 int
)
AS
SET NOCOUNT ON 

SELECT tesTarjetas3.tesTarjetas3, tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionIdentifica, 
	tesBancos.Banco_Id,	tesBancos.Descripcion as DescripcionBancos, 
	tesTarjetas3.Comercio, tesTarjetas3.Cuotas, tesTarjetas3.Cupon,
	tesTarjetas3.Lote, tesTarjetas3.NroAutorizacion, tesTarjetas3.NroTarjeta,
	tesIdTarjetasTipo.TipoTarjeta, tesIdTarjetasTipo.Descripcion DesTipoTarjeta,
	tesTarjetas3.SecuenciaActual, tesTarjetas3Estado.Estado, 
	tesTarjetas3Estado.Descripcion as DescripcionCheqTerEstado,
	tesTarjetas3.FechaConciliacion, BancoConc.Cartera_Id BancoConc,
	tesTarjetas3.NumeroConc, venClientes.Cliente_Id, 
	venClientes.RazonSocial as DescripcionClientes, tesTarjetas3.Empresa_Id
FROM tesTarjetas3 
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesTarjetas3.Cartera_Id
INNER JOIN tesIdTarjetas3 ON tesIdTarjetas3.Cartera_Id = tesTarjetas3.Cartera_Id
INNER JOIN tesIdTarjetasTipo ON tesIdTarjetas3.TipoTarjeta = tesIdTarjetasTipo.tesIdTarjetasTipo
INNER JOIN tesBancos  ON (tesBancos.tesBancos = tesIdTarjetas3.Banco_Id)
INNER JOIN tesTarjetas3Estado  ON (tesTarjetas3Estado.Estado = tesTarjetas3.Estado)
LEFT JOIN tesIdentifica BancoConc ON BancoConc.tesIdentifica = tesTarjetas3.BancoConc
LEFT JOIN venClientes  ON (venClientes.genEntidades = tesTarjetas3.Cliente_Id)
WHERE (tesTarjetas3 = @ptesTarjetas3)
 
RETURN @@Error 
GO


DROP PROCEDURE tesTarjetas3Eliminar
GO
CREATE PROCEDURE tesTarjetas3Eliminar
(
@ptesTarjetas3 int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesTarjetas3 
WHERE (tesTarjetas3 = ISNULL(@ptesTarjetas3, tesTarjetas3))
 
RETURN @@Error 
GO


DROP PROCEDURE tesTarjetas3Modificar
GO
CREATE PROCEDURE tesTarjetas3Modificar
(
@ptesTarjetas3 int,
@pCartera_Id VarChar(5),
@pEstado char(1),
@pCuotas int,
@pCupon VarChar(20),
@pLote Int,
@pComercio int,
@pNroAutorizacion VarChar(25) = NULL,
@pNroTarjeta VarChar(20) = NULL,
@pSecuenciaActual smallint,
@pFechaConciliacion datetime = NULL,
@pBancoConc char(5) = NULL,
@pNumeroConc int = NULL,
@pCliente_Id VarChar(15) = NULL,
@pEmpresa_Id int = NULL
)
AS
SET NOCOUNT ON 
BEGIN 
	UPDATE tesTarjetas3
	SET	Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id),
		Estado = @pEstado,
		Cuotas = @pCuotas,
		Cupon = @pCupon,
		Lote = @pLote,
		Comercio = @pComercio,
		NroAutorizacion = @pNroAutorizacion,
		NroTarjeta = @pNroTarjeta,
		SecuenciaActual = @pSecuenciaActual,
		FechaConciliacion = @pFechaConciliacion,
		BancoConc = dbo.FuncFKtesIdentifica(@pBancoConc),
		NumeroConc = @pNumeroConc,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Empresa_Id = @pEmpresa_Id
	WHERE (tesTarjetas3 = @ptesTarjetas3)
END 
GO



DROP PROCEDURE tesTarjetas3Conciliar
GO
CREATE PROCEDURE tesTarjetas3Conciliar
(
@ptesTarjetas3 int,
@pBancoConc char(5), 
@pNumeroConc int , 
@pEmpresa_Id int
)
AS
	UPDATE tesTarjetas3
		SET BancoConc = dbo.FuncFKtesIdentifica(@pBancoConc),
		NumeroConc = @pNumeroConc, Empresa_Id = @pEmpresa_Id
	WHERE (tesTarjetas3 = @ptesTarjetas3)
GO


DROP PROCEDURE tesTarjetas3BancoDepo
GO
CREATE PROCEDURE tesTarjetas3BancoDepo
(
	@ptesTarjetas3 int
)
AS
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion
 FROM tesT3Link INNER JOIN tesRengMovi on
	tesT3Link.tesMovimientos = tesRengMovi.tesMovimientos 
	INNER JOIN conMovCont ON 
	conMovCont.conAsientos = tesRengMovi.tesMovimientos  AND 
	conMovCont.Renglon = tesRengMovi.conRenglon AND
	conMovCont.TipoMov = 1
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	where tesT3Link.Estado = 'N' AND 
		tesT3Link.tesTarjetas3 = @ptesTarjetas3
GO



DROP PROCEDURE tesTarjetas3XEstadoDatos
GO
CREATE PROCEDURE tesTarjetas3XEstadoDatos (
	@Empresa_Id int, 
	@Cartera_Id Char(5), 
	@Estado Char(1))
AS

SELECT @Empresa_Id as Empresa_id, @Cartera_Id as Cartera_Id, @Estado as Estado
	
SELECT CAST(0 as bit) as Marca ,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesTarjetas3.Estado, tesTarjetas3.Cuotas, tesTarjetas3.Cupon, tesTarjetas3.Lote,
	tesTarjetas3.Comercio, tesTarjetas3.NroAutorizacion, tesTarjetas3.NroTarjeta,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesTarjetas3.tesTarjetas3, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal 
FROM tesTarjetas3 
INNER JOIN tesIdTarjetas3 ON tesTarjetas3.Cartera_Id = tesIdTarjetas3.Cartera_Id
INNER JOIN tesIdentifica ON tesTarjetas3.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesBancos ON tesBancos.tesBancos = tesIdTarjetas3.Banco_Id
INNER JOIN tesT3link ON tesT3link.tesTarjetas3 = tesTarjetas3.tesTarjetas3 AND
	tesT3link.Secuencia = tesTarjetas3.SecuenciaActual
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesT3link.tesMovimientos and 
	tesRengMovi.conRenglon = tesT3link.conRenglon
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
inner join conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesTarjetas3.Cliente_Id
WHERE
	conAsientos.Empresa_Id = @Empresa_Id and conAsientos.Anulado = 0 And
	tesIdentifica.Cartera_Id = @Cartera_Id and
	tesTarjetas3.Estado = @Estado 
ORDER BY tesTarjetas3.tesTarjetas3
GO