DROP PROCEDURE tesCheqPropGuardar
GO
CREATE PROCEDURE tesCheqPropGuardar
(
@pEmpresa_Id int,
@pCartera_Id VarChar(5),
@pChequera_Id int,
@pnumCheque int,
@pnumCheque_Nuevo int,
@pFechaVencimiento datetime,
@pFechaDebito datetime = NULL,
@paLaOrden varchar(120),
@pEstado_Id char(1),
@pSecuenciaActual smallint,
@pCuit qCuit = NULL,
@pCuentaDestino varchar(50) = NULL,
@pBancoDestino varchar(3) = NULL,
@pBancoDestinoExt varchar(150) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesCheqProp WHERE (Empresa_Id = @pEmpresa_Id) AND
 (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND 
 (Chequera_Id = @pChequera_Id) AND (numCheque = @pnumCheque)))
BEGIN 
	UPDATE tesCheqProp
	SET	@lIdentidad = tesCheqProp,
		Empresa_Id = @pEmpresa_Id,
		Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id),
		Chequera_Id = @pChequera_Id,
		numCheque = @pnumCheque_Nuevo,
		FechaVencimiento = @pFechaVencimiento,
		FechaDebito = @pFechaDebito,
		aLaOrden = @paLaOrden,
		Estado_Id = @pEstado_Id,
		SecuenciaActual = @pSecuenciaActual,
		Cuit = @pCuit,
		CuentaDestino = @pCuentaDestino,
		BancoDestino = dbo.FuncFKtesBancos(@pBancoDestino),
		BancoDestinoExt = @pBancoDestinoExt
	WHERE (Empresa_Id = @pEmpresa_Id) 
		AND (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND 
		(Chequera_Id = @pChequera_Id) AND (numCheque = @pnumCheque)
END 
ELSE 
BEGIN 
	INSERT INTO tesCheqProp
	(
		Empresa_Id,
		Cartera_Id,
		Chequera_Id,
		numCheque,
		FechaVencimiento,
		FechaDebito,
		aLaOrden,
		Estado_Id,
		SecuenciaActual,
		Cuit,
		CuentaDestino,
		BancoDestino,
		BancoDestinoExt
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pChequera_Id,
		@pnumCheque,
		@pFechaVencimiento,
		@pFechaDebito,
		@paLaOrden,
		@pEstado_Id,
		@pSecuenciaActual,
		@pCuit,
		@pCuentaDestino,
		dbo.FuncFKtesBancos(@pBancoDestino),
		@pBancoDestinoExt
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesCheqPropDatos
GO
CREATE PROCEDURE tesCheqPropDatos
(
@pEmpresa_Id int,
@pCartera_Id VarChar(5),
@pChequera_Id int,
@pnumCheque int
)
AS
SET NOCOUNT ON 

SELECT tesCheqProp.tesCheqProp, tesCheqProp.Empresa_Id, tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionIdBancoPropio,
	tesCheqProp.Chequera_Id, 
	tesCheqProp.numCheque, tesCheqProp.FechaVencimiento, tesCheqProp.FechaDebito, tesCheqProp.aLaOrden,
	tesCheqProp.Estado_Id, tesCheqPropEstado.Descripcion as DescripcionCheqPropEstado, tesCheqProp.SecuenciaActual, tesCheqProp.Cuit,
	tesCheqProp.CuentaDestino, tesBancos.Banco_Id, tesBancos.Descripcion as DescripcionBancos, tesCheqProp.BancoDestinoExt
FROM tesCheqProp 
INNER JOIN tesIdentifica ON (tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id)
INNER JOIN tesIdBancoPropio  ON (tesIdBancoPropio.Cartera_Id = tesCheqProp.Cartera_Id)
INNER JOIN tesChequeras  ON (tesChequeras.Chequera_Id = tesCheqProp.Chequera_Id) AND (tesChequeras.Cartera_Id = tesCheqProp.Cartera_Id) AND (tesChequeras.Empresa_Id = tesCheqProp.Empresa_Id)
INNER JOIN tesCheqPropEstado  ON (tesCheqPropEstado.Estado_Id = tesCheqProp.Estado_Id)
LEFT JOIN tesBancos  ON (tesBancos.tesBancos = tesCheqProp.BancoDestino)
WHERE (tesCheqProp.Empresa_Id = @pEmpresa_Id)
AND (tesCheqProp.Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (tesCheqProp.Chequera_Id = @pChequera_Id)
AND (tesCheqProp.numCheque = @pnumCheque)
 


 Declare @pidentity bigint= dbo.FuncFKtesCheqProp(@pEmpresa_Id,@pCartera_Id,@pChequera_Id,@pnumCheque)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesCheqProp'
 RETURN @@Error 

GO

DROP PROCEDURE tesCheqPropEliminar
GO
CREATE PROCEDURE tesCheqPropEliminar
(
@pEmpresa_Id int,
@pCartera_Id VarChar(5),
@pChequera_Id int,
@pnumCheque int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesCheqProp 
WHERE (Empresa_Id = @pEmpresa_Id)
AND (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (Chequera_Id = @pChequera_Id)
AND (numCheque = @pnumCheque)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesCheqProp
GO

CREATE FUNCTION FuncFKtesCheqProp
(
@pEmpresa_Id int,
@pCartera_Id varChar(5),
@pChequera_Id int,
@pnumCheque int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesCheqProp FROM tesCheqProp WHERE 
	Empresa_Id = @pEmpresa_Id AND 
	Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id) AND 
	Chequera_Id = @pChequera_Id AND 
	numCheque = @pnumCheque
  RETURN @pIdentity
END

GO

Drop Procedure tesBPLinkDatosXSecuencia
Go
Create Procedure tesBPLinkDatosXSecuencia
(
@pEmpresa_Id int,
@pCartera_Id varChar(5),
@pChequera_Id int,
@pnumCheque int,
@pSecuencia smallint
)
As

Declare @ltesCheqProp int
Declare @ltesMovimientos bigint
Declare @lconRenglon int

Set @ltesCheqProp = dbo.FuncFKtesCheqProp(@pEmpresa_Id, @pCartera_Id, @pChequera_Id, @pnumCheque)

Select @ltesMovimientos = tesMovimientos, @lconRenglon = conRenglon
From tesBPlink
Where tesCheqProp = @ltesCheqProp And Secuencia = @pSecuencia

Exec tesBPlinkDatos @ltesMovimientos, @lconRenglon
Go
