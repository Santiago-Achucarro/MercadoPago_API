DROP PROCEDURE tesTarjetasPromocionesGuardar
GO
CREATE PROCEDURE tesTarjetasPromocionesGuardar
(
@pCartera_Id varchar(5),
@pPromocion_Id int
)
AS
SET NOCOUNT ON 

	INSERT INTO tesTarjetasPromociones
	(
		Cartera_Id,
		Promocion_Id
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		dbo.FuncFKtesT3Promociones(@pPromocion_Id)
	)

GO

DROP PROCEDURE tesTarjetasPromocionesDatos
GO
CREATE PROCEDURE tesTarjetasPromocionesDatos
(
@pCartera_Id varchar(5) = Null,
@pPromocion_Id int = Null
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdTarjetas3, tesT3Promociones.Promocion_Id, tesT3Promociones.Descripcion as DescripcionT3Promociones
FROM tesTarjetasPromociones 
INNER JOIN tesIdTarjetas3  ON (tesIdTarjetas3.Cartera_Id = tesTarjetasPromociones.Cartera_Id)
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesIdTarjetas3.Cartera_Id
INNER JOIN tesT3Promociones  ON (tesT3Promociones.tesT3Promociones = tesTarjetasPromociones.Promocion_Id)
WHERE tesIdentifica.Cartera_Id = isNull(@pCartera_Id, tesIdentifica.Cartera_Id)
AND tesT3Promociones.Promocion_Id = isNull(@pPromocion_Id, tesT3Promociones.Promocion_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE tesTarjetasPromocionesEliminar
GO
CREATE PROCEDURE tesTarjetasPromocionesEliminar
(
@pCartera_Id varchar(5) = Null,
@pPromocion_Id int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM tesTarjetasPromociones 
WHERE Cartera_Id = isNull(dbo.FuncFKtesIdentifica(@pCartera_Id), Cartera_Id)
AND Promocion_Id = isNull(dbo.FuncFKtesT3Promociones(@pPromocion_Id), Promocion_Id)
 
 RETURN @@Error 

GO
