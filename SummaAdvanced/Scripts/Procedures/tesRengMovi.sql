
-- tesRengMoviDatos 0,null
DROP PROCEDURE tesRengMoviGuardar
GO
CREATE PROCEDURE tesRengMoviGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pCartera_Id varchar(5), 
@pCambio QmonedaD8, 
@pTipomovCont Numeric(1,0)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRengMovi WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE tesRengMovi
	SET		Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)
	WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesRengMovi
	(
		tesMovimientos,
		conRenglon,
		Cartera_Id, 
		Cambio, 
		TipomovCont
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pCambio, 
		@pTipomovCont
	)
END 

GO


DROP PROCEDURE tesRengMoviDatos
GO
CREATE PROCEDURE tesRengMoviDatos
(
@ptesMovimientos bigint,
@pconRenglon int=null, 
@pTipomov int=null
)
AS
SET NOCOUNT ON 

SELECT tesRengMovi.tesMovimientos,  conMovcont.TipoMov,  tesRengMovi.conRenglon,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdentifica, 
	conMovCont.ImporteMonedaOriginal * case when tesRengMovi.TipomovCont  =conMovCont.Tipomov then 1 else -1 end as ImporteOrig, 
	conMovCont.Importe * case when tesRengMovi.TipomovCont  =conMovCont.Tipomov then 1 else -1 end as Importe, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	tesRengMovi.TipomovCont  Tipomov, conMovCont.Clase, 
	tesTiposID.TipoCartera,tesRengMovi.Cambio
FROM tesRengMovi 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = tesRengMovi.tesMovimientos) AND (conMovCont.Renglon = tesRengMovi.conRenglon)
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id)
INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT JOIN conCentro1 ON  conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT JOIN conCentro2 ON  conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN tesTiposID ON (tesTiposID.tesTiposID = tesIdentifica.TipoCartera)
WHERE tesRengMovi.tesMovimientos = @ptesMovimientos and 
	tesRengMovi.conRenglon = isnull(@pconRenglon, tesRengMovi.conRenglon) and 
	conMovCont.Tipomov = isnull(@pTipomov, conMovCont.Tipomov)
ORDER BY 2


 
RETURN @@Error 

GO

DROP PROCEDURE tesRengMoviEliminar
GO
CREATE PROCEDURE tesRengMoviEliminar
(
@ptesMovimientos bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

DELETE FROM tesRengMovi 
WHERE (tesMovimientos = @ptesMovimientos)
AND (tesRengMovi.conRenglon = isnull(@pconRenglon, tesRengMovi.conRenglon))
 
RETURN @@Error 

GO

GO
