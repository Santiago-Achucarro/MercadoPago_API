DROP PROCEDURE tesBPlinkGuardar
GO
CREATE PROCEDURE tesBPlinkGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pEstado_Id char(1),
@pSecuencia smallint,
@ptesCheqProp int 
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesBPlink WHERE 
(tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE tesBPlink
	SET	Estado_Id = @pEstado_Id,
		Secuencia = @pSecuencia,
		tesCheqProp = @ptesCheqProp
	WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesBPlink
	(
		tesMovimientos,
		conRenglon,
		Estado_Id,
		Secuencia,
		tesCheqProp
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		@pEstado_Id,
		@pSecuencia,
		@ptesCheqProp
	)
END 

GO

DROP PROCEDURE tesBPlinkDatos
GO
CREATE PROCEDURE tesBPlinkDatos
(
@ptesMovimientos bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

SELECT tesBPlink.tesMovimientos, tesBPlink.conRenglon, 
	tesCheqPropEstado.Estado_Id,
	tesCheqPropEstado.Descripcion as DescripcionCheqPropEstado, 
	tesBPlink.Secuencia, tesCheqProp.Empresa_Id, tesIdentifica.Cartera_Id,
	tesCheqProp.Chequera_Id, tesCheqProp.numCheque, tesCheqProp.tesCheqProp
FROM tesBPlink 
INNER JOIN tesRengMovi  ON (tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos) AND (tesRengMovi.conRenglon = tesBPlink.conRenglon)
INNER JOIN tesCheqPropEstado  ON (tesCheqPropEstado.Estado_Id = tesBPlink.Estado_Id)
INNER JOIN  tesCheqProp  ON (tesCheqProp.tesCheqProp = tesBPlink.tesCheqProp)
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
WHERE (tesBPlink.tesMovimientos = @ptesMovimientos)
AND (tesBPlink.conRenglon = ISNULL( @pconRenglon, tesBPlink.conRenglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE tesBPlinkEliminar
GO
CREATE PROCEDURE tesBPlinkEliminar
(
@ptesMovimientos bigint,
@pconRenglon int= null
)
AS
SET NOCOUNT ON 

DELETE FROM tesBPlink 
WHERE (tesBPlink.tesMovimientos = @ptesMovimientos)
AND (tesBPlink.conRenglon = ISNULL( @pconRenglon, tesBPlink.conRenglon))
 
 RETURN @@Error 

GO

GO
