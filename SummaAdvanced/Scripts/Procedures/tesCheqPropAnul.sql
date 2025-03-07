DROP PROCEDURE tesCheqPropAnulGuardar
GO
CREATE PROCEDURE tesCheqPropAnulGuardar
(
@ptesCheqProp int,
@pFecha_Anul datetime,
@pObservaciones varchar(15),
@pImporte qMonedaD2,
@pFechaOriginal qFecha,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesCheqPropAnul WHERE (tesCheqProp = @ptesCheqProp)))
BEGIN 
	UPDATE tesCheqPropAnul
	SET		Fecha_Anul = @pFecha_Anul,
		Observaciones = @pObservaciones,
		Importe = @pImporte,
		FechaOriginal = @pFechaOriginal,
		Usuario_Id = @pUsuario_Id
	WHERE (tesCheqProp = @ptesCheqProp)
END 
ELSE 
BEGIN 
	INSERT INTO tesCheqPropAnul
	(
		tesCheqProp,
		Fecha_Anul,
		Observaciones,
		Importe,
		FechaOriginal,
		Usuario_Id
	)
	VALUES 
	(
		@ptesCheqProp,
		@pFecha_Anul,
		@pObservaciones,
		@pImporte,
		@pFechaOriginal,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE tesCheqPropAnulDatos
GO
CREATE PROCEDURE tesCheqPropAnulDatos
(
@pEmpresa_Id int,
@pCartera_Id VarChar(5),
@pChequera_Id int,
@pnumCheque int
)
AS
SET NOCOUNT ON 

SELECT tesCheqProp.Empresa_Id, tesIdentifica.Cartera_Id, 
	tesCheqProp.Chequera_Id, tesCheqProp.numCheque,
	tesCheqPropAnul.Fecha_Anul, tesCheqPropAnul.Observaciones, tesCheqPropAnul.Importe,
	tesCheqPropAnul.FechaOriginal, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM tesCheqPropAnul 
INNER JOIN tesCheqProp  ON (tesCheqProp.tesCheqProp = tesCheqPropAnul.tesCheqProp)
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesCheqPropAnul.Usuario_Id)
WHERE (tesCheqProp.Empresa_Id = @pEmpresa_Id)
AND (tesCheqProp.Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (tesCheqProp.Chequera_Id = @pChequera_Id)
AND (tesCheqProp.numCheque = @pnumCheque)
 
RETURN @@Error 

GO

DROP PROCEDURE tesCheqPropAnulEliminar
GO
CREATE PROCEDURE tesCheqPropAnulEliminar
(
@ptesCheqProp int
)
AS
SET NOCOUNT ON 

DELETE FROM tesCheqPropAnul 
WHERE (tesCheqProp = @ptesCheqProp)
 
 RETURN @@Error 

GO

GO