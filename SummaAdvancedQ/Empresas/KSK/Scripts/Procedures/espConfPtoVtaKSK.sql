DROP PROCEDURE espConfPtoVtaKSKGuardar
GO
CREATE PROCEDURE espConfPtoVtaKSKGuardar
(
@pEmpresa_Id int,
@pSubTipoMov_Id varchar(5) = NULL,
@pEfectivo varchar(5) = NULL,
@pCheques varchar(5) = NULL,
@pTDebito varchar(5) = NULL,
@pTCredito varchar(5) = NULL,
@pTransferencia varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espConfPtoVtaKSK WHERE (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE espConfPtoVtaKSK
	SET		Empresa_Id = @pEmpresa_Id,
		SubTipoMov_Id = dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		Efectivo = dbo.FuncFKtesIdentifica(@pEfectivo),
		Cheques = dbo.FuncFKtesIdentifica(@pCheques),
		TDebito = dbo.FuncFKtesIdentifica(@pTDebito),
		TCredito = dbo.FuncFKtesIdentifica(@pTCredito),
		Transferencia = dbo.FuncFKtesIdentifica(@pTransferencia)
	WHERE (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO espConfPtoVtaKSK
	(
		Empresa_Id,
		SubTipoMov_Id,
		Efectivo,
		Cheques,
		TDebito,
		TCredito,
		Transferencia
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		dbo.FuncFKtesIdentifica(@pEfectivo),
		dbo.FuncFKtesIdentifica(@pCheques),
		dbo.FuncFKtesIdentifica(@pTDebito),
		dbo.FuncFKtesIdentifica(@pTCredito),
		dbo.FuncFKtesIdentifica(@pTransferencia)
	)
END 

GO

DROP PROCEDURE espConfPtoVtaKSKDatos
GO
CREATE PROCEDURE espConfPtoVtaKSKDatos
(
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT espConfPtoVtaKSK.Empresa_Id, venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, 
	Efectivo.Cartera_Id Efectivo, Efectivo.Descripcion as DescripcionEfectivo, 
	Cheques.Cartera_Id Cheques, Cheques.Descripcion as DescripcionCheques, 
	TDebito.Cartera_Id TDebito, TDebito.Descripcion as DescripcionTDebito, 
	TCredito.Cartera_Id TCredito, TCredito.Descripcion as DescripcionTCredito, 
	Transferencia.Cartera_Id Transferencia, Transferencia.Descripcion as DescripcionTransferencia
FROM espConfPtoVtaKSK 
LEFT JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = espConfPtoVtaKSK.SubTipoMov_Id)
LEFT JOIN tesIdentifica Efectivo ON (Efectivo.tesIdentifica = espConfPtoVtaKSK.Efectivo)
LEFT JOIN tesIdentifica Cheques ON (Cheques.tesIdentifica = espConfPtoVtaKSK.Cheques)
LEFT JOIN tesIdentifica TDebito ON (TDebito.tesIdentifica = espConfPtoVtaKSK.TDebito)
LEFT JOIN tesIdentifica TCredito ON (TCredito.tesIdentifica = espConfPtoVtaKSK.TCredito)
LEFT JOIN tesIdentifica Transferencia ON (Transferencia.tesIdentifica = espConfPtoVtaKSK.Transferencia)
WHERE (espConfPtoVtaKSK.Empresa_Id = @pEmpresa_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE espConfPtoVtaKSKEliminar
GO
CREATE PROCEDURE espConfPtoVtaKSKEliminar
(
@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

DELETE FROM espConfPtoVtaKSK WHERE Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO


