DROP PROCEDURE tesCTlinkGuardar
GO
CREATE PROCEDURE tesCTlinkGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pEstado_Id char(1),
@pSecuencia smallint,
@ptesCheqTerceros int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesCTlink WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE tesCTlink
	SET	 Estado_Id = @pEstado_Id,
		Secuencia = @pSecuencia,
		tesCheqTerceros = @ptesCheqTerceros
	WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesCTlink
	(
		tesMovimientos,
		conRenglon,
		Estado_Id,
		Secuencia,
		tesCheqTerceros
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		@pEstado_Id,
		@pSecuencia,
		@ptesCheqTerceros
	)
END 

GO

DROP PROCEDURE tesCTlinkDatos
GO
CREATE PROCEDURE tesCTlinkDatos
(
@ptesMovimientos bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

SELECT tesCTlink.tesMovimientos, tesCTlink.conRenglon, tesCTlink.Estado_Id,
	tesCheqTerEstado.Descripcion as DescripcionCheqTerEstado, tesCTlink.Secuencia, tesCTlink.tesCheqTerceros, tesCheqTerceros.numCheque 
FROM tesCTlink 
INNER JOIN tesRengMovi  ON (tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos) AND (tesRengMovi.conRenglon = tesCTlink.conRenglon)
INNER JOIN tesCheqTerEstado  ON (tesCheqTerEstado.Estado_Id = tesCTlink.Estado_Id)
LEFT JOIN tesCheqTerceros  ON (tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros)
WHERE (tesCTlink.tesMovimientos = @ptesMovimientos)
AND (tesCTlink.conRenglon = ISNULL(@pconRenglon, tesCTlink.conRenglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE tesCTlinkEliminar
GO
CREATE PROCEDURE tesCTlinkEliminar
(
@ptesMovimientos bigint,
@pconRenglon int= null
)
AS
SET NOCOUNT ON 

DELETE FROM tesCTlink 
WHERE (tesMovimientos = @ptesMovimientos)
AND (tesCTlink.conRenglon = ISNULL(@pconRenglon, tesCTlink.conRenglon))
 
 RETURN @@Error 

GO


Drop Procedure tesCTLinkDatosXSecuencia
Go
Create Procedure tesCTLinkDatosXSecuencia
(
@pTesCheqTerceros int,
@pSecuencia smallint
)
As

Declare @ltesMovimientos bigint
Declare @lconRenglon int

Select @ltesMovimientos = tesMovimientos, @lconRenglon = conRenglon
From tesCTlink
Where tesCheqTerceros = @pTesCheqTerceros And Secuencia = @pSecuencia

exec tesCTlinkDatos @ltesMovimientos, @lconRenglon
Go
