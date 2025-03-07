DROP PROCEDURE tesRengConcilEspInsertar
GO
CREATE PROCEDURE tesRengConcilEspInsertar
(
@pEmpresa_Id int,
@ptesIdentifica VarChar(5),
@pNumeroConc int,
@ptesMovimientos bigint,
@pconRenglon int, 
@pImporte QMonedaD2
)
AS
SET NOCOUNT ON 
	INSERT INTO tesRengConcilEsp
	(
		Empresa_Id,
		tesIdentifica,
		NumeroConc,
		tesMovimientos,
		conRenglon, 
		Importe 
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKtesIdentifica(@ptesIdentifica),
		@pNumeroConc,
		@ptesMovimientos,
		@pconRenglon, 
		@pImporte
	)

GO

DROP PROCEDURE tesRengConcilEspDatos
GO
CREATE PROCEDURE tesRengConcilEspDatos
(
@pEmpresa_Id int,
@ptesIdentifica VarChar(5),
@pNumeroConc int,
@ptesMovimientos bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

SELECT tesRengConcilEsp.Empresa_Id,		
	tesIdentifica.Cartera_id, tesIdentifica.Descripcion as  DescripcionCartera,
	tesRengConcilEsp.NumeroConc, tesRengConcilEsp.tesMovimientos, tesRengConcilEsp.conRenglon, 
		tesRengConcilEsp.Importe
	
FROM tesRengConcilEsp 
INNER JOIN tesConciliacion  ON (tesConciliacion.Empresa_Id = tesRengConcilEsp.Empresa_Id) AND (tesConciliacion.tesIdentifica = tesRengConcilEsp.tesIdentifica) AND (tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc)
INNER JOIN tesRengConciliac  ON (tesRengConciliac.tesMovimientos = tesRengConcilEsp.tesMovimientos) AND (tesRengConciliac.conRenglon = tesRengConcilEsp.conRenglon)
INNER JOIN tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengConcilEsp.tesIdentifica
WHERE (tesRengConcilEsp.Empresa_Id = @pEmpresa_Id)
AND (tesIdentifica.Cartera_id = @ptesIdentifica)
AND (tesRengConcilEsp.NumeroConc = @pNumeroConc)
AND (tesRengConcilEsp.tesMovimientos = @ptesMovimientos)
AND (tesRengConcilEsp.conRenglon = @pconRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE tesRengConcilEspEliminar
GO
CREATE PROCEDURE tesRengConcilEspEliminar
(
@pEmpresa_Id int,
@ptesIdentifica VarChar(5),
@pNumeroConc int,
@ptesMovimientos bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

DELETE FROM tesRengConcilEsp 
WHERE (Empresa_Id = @pEmpresa_Id)
AND (tesIdentifica = dbo.FuncFKtesIdentifica(@ptesIdentifica))
AND (NumeroConc = @pNumeroConc)
AND (tesMovimientos = @ptesMovimientos)
AND (conRenglon = @pconRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE tesRengConcilEspMovDatos
GO
CREATE PROCEDURE tesRengConcilEspMovDatos
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.Cartera_Id, tesConciliacion.NumeroConc
FROM tesRengConcilEsp 
INNER JOIN tesConciliacion  ON (tesConciliacion.Empresa_Id = tesRengConcilEsp.Empresa_Id) AND (tesConciliacion.tesIdentifica = tesRengConcilEsp.tesIdentifica) AND (tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc)
INNER JOIN tesRengConciliac  ON (tesRengConciliac.tesMovimientos = tesRengConcilEsp.tesMovimientos) AND (tesRengConciliac.conRenglon = tesRengConcilEsp.conRenglon)
INNER JOIN tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengConcilEsp.tesIdentifica
Where
tesRengConcilEsp.tesMovimientos = @ptesMovimientos

 
RETURN @@Error 

GO
