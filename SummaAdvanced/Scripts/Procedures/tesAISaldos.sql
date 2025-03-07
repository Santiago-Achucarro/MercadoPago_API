DROP PROCEDURE tesAISaldosGuardar
GO
CREATE PROCEDURE tesAISaldosGuardar
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pSaldoInicial qMonedaD2,
@pCambio qMonedaD4,
@pUsuario_Id int ,
@pConfirmado SiNo
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesAISaldos WHERE (Cartera_Id =dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE tesAISaldos
	SET		Empresa_Id = @pEmpresa_Id,
		SaldoInicial = @pSaldoInicial,
		Cambio = @pCambio,
		Usuario_Id = @pUsuario_Id,
		FechaRegistro = getDate() , 
		Confirmado = @pConfirmado
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesAISaldos
	(
		Cartera_Id,
		Empresa_Id,
		SaldoInicial,
		Cambio,
		Usuario_Id,
		FechaRegistro,
		Confirmado
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pEmpresa_Id,
		@pSaldoInicial,
		@pCambio,
		@pUsuario_Id,
		getDate(), 
		@pConfirmado
	)
END 

GO

DROP PROCEDURE tesAISaldosDatos
GO
CREATE PROCEDURE tesAISaldosDatos
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdentifica, 
	tesAISaldos.Empresa_Id, tesAISaldos.SaldoInicial, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescripcionMoneda, 
	tesAISaldos.Cambio, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	tesAISaldos.FechaRegistro, tesAISaldos.Confirmado
FROM tesAISaldos 
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = tesAISaldos.Cartera_Id)
INNER JOIN genMonedas on genMonedas.genMonedas = tesIdentifica.Moneda_Id
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesAISaldos.Usuario_Id)
WHERE (tesAISALDOS.Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (tesAISALDOS.Empresa_Id = @pEmpresa_Id)

exec tesAIChequesDatos @pCartera_id, @pEmpresa_id, null
exec tesAIDepositosDatos @pCartera_id, @pEmpresa_id, null
 
RETURN @@Error 

GO

DROP PROCEDURE tesAISaldosEliminar
GO
CREATE PROCEDURE tesAISaldosEliminar
(
@pCartera_Id varchar(5),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM tesAISaldos 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (Empresa_Id = @pEmpresa_Id)
 
RETURN @@Error 

GO


DROP PROCEDURE tesAISaldosEliminarCheques
GO
CREATE PROCEDURE tesAISaldosEliminarCheques
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT tesBPlink.tesCheqProp into #c1
	from tesBPlink
	WHERE tesMovimientos = @ptesMovimientos

DELETE FROM tesBPlink WHERE tesMovimientos = @ptesMovimientos
DELETE FROM tesCheqProp WHERE tesCheqProp IN (SELECT tesCheqProp from #c1)
DROP TABLE #c1

SELECT tesCTlink.tesCheqTerceros into #c2
	from tesCTlink
	WHERE tesMovimientos = @ptesMovimientos

DELETE FROM tesCTlink WHERE tesMovimientos = @ptesMovimientos
DELETE FROM tesCheqTerceros WHERE tesCheqTerceros IN (SELECT tesCheqTerceros from #c2)
DROP TABLE #c2

RETURN @@Error 

GO

