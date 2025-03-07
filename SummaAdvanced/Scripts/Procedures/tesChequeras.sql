--ALTER TABLE tesChequeras add Empresa_id Int NOT NULL

DROP PROCEDURE tesChequerasGuardar
GO
CREATE PROCEDURE tesChequerasGuardar
(
@pChequera_id int,
@pCartera_Id VarChar(5),
@pEmpresa_id Int, 
@pTipoChequera char(1),
@pEstado_id char(1),
@pDesde int,
@pHasta int,
@pProximo int,
@pFechaAlta datetime,
@pFechaBaja datetime = NULL,
@pMotivoBaja varchar(15),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
if (@pChequera_id<> 0) 
BEGIN 
	UPDATE tesChequeras
	SET		TipoChequera = @pTipoChequera,
		Empresa_id = @pEmpresa_id,
		Estado_id = @pEstado_id,
		Desde = @pDesde,
		Hasta = @pHasta,
		Proximo = @pProximo,
		FechaAlta = GETDATE(),
		FechaBaja = @pFechaBaja,
		MotivoBaja = @pMotivoBaja,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Chequera_id = @pChequera_id) AND (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id) And Empresa_Id = @pEmpresa_id)
END 
ELSE 
BEGIN 
	set @pChequera_id = isNull((SELECT MAX(Chequera_id) from tesChequeras where Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id) And Empresa_Id = @pEmpresa_Id),0)+1
	
	INSERT INTO tesChequeras
	(
		Chequera_id,
		Cartera_Id,
		Empresa_id,
		TipoChequera,
		Estado_id,
		Desde,
		Hasta,
		Proximo,
		FechaAlta,
		FechaBaja,
		MotivoBaja,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pChequera_id,
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pEmpresa_id,
		@pTipoChequera,
		@pEstado_id,
		@pDesde,
		@pHasta,
		@pProximo,
		GETDATE(),
		@pFechaBaja,
		@pMotivoBaja,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
END 

SELECT @pChequera_id AS RetVal 

GO

DROP PROCEDURE tesChequerasDatos
GO
CREATE PROCEDURE tesChequerasDatos
(
@pChequera_id int,
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT tesChequeras.Chequera_id, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera,
	tesChequeras.Empresa_id, tesChequeras.TipoChequera,
	tesChequeras.Estado_id, tesChequerasEstado.Descripcion as DescripcionChequerasEstado, 
	tesChequeras.Desde, tesChequeras.Hasta,
	tesChequeras.Proximo, tesChequeras.FechaAlta, tesChequeras.FechaBaja, tesChequeras.MotivoBaja,
	tesChequeras.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, tesChequeras.Posteado,
	Cast(0 As Bit) FueUsada
FROM tesChequeras 
INNER JOIN tesIdBancoPropio  ON (tesIdBancoPropio.Cartera_Id = tesChequeras.Cartera_Id)
INNER JOIN tesChequerasEstado  ON (tesChequerasEstado.Estado_Id = tesChequeras.Estado_id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesChequeras.Usuario_Id)
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica =TesChequeras.Cartera_Id
LEFT OUTER JOIN tesBancos ON tesBancos.tesBancos = tesIdBancoPropio.Banco_Id
WHERE (Chequera_id = @pChequera_id)
AND (tesChequeras.Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
 
 RETURN @@Error 

GO

DROP PROCEDURE tesChequerasEliminar
GO
CREATE PROCEDURE tesChequerasEliminar
(
@pChequera_id int = NULL,
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesChequeras 
WHERE (Chequera_id = ISNULL(@pChequera_id, Chequera_id))
AND (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
 
 RETURN @@Error 

GO

