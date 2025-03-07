DROP PROCEDURE venSTMAfipGuardar
GO
CREATE PROCEDURE venSTMAfipGuardar
(
@pvenSubTipoMov int,
@pLetra char(1),
@pComprobante_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venSTMAfip WHERE (venSubTipoMov = @pvenSubTipoMov) AND (Letra = @pLetra)))
BEGIN 
	UPDATE venSTMAfip
	SET		Comprobante_Id = @pComprobante_Id
	WHERE (venSubTipoMov = @pvenSubTipoMov) AND (Letra = @pLetra)
END 
ELSE 
BEGIN 
	INSERT INTO venSTMAfip
	(
		venSubTipoMov,
		Letra,
		Comprobante_Id
	)
	VALUES 
	(
		@pvenSubTipoMov,
		@pLetra,
		@pComprobante_Id
	)
END 

GO

DROP PROCEDURE venSTMAfipDatos
GO
CREATE PROCEDURE venSTMAfipDatos
(
@pvenSubTipoMov int,
@pLetra char(1) = null
)
AS
SET NOCOUNT ON 

SELECT venSubTipoMov.venSubTipoMov, venSTMAfip.Letra, venSTMAfip.Comprobante_Id,
	genTiposCompAfip.Descripcion as DescripcionTiposCompAfip
FROM venSTMAfip 
INNER JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venSTMAfip.venSubTipoMov)
LEFT JOIN genTiposCompAfip  ON (genTiposCompAfip.Comprobante_Id = venSTMAfip.Comprobante_Id)
WHERE (venSTMAfip.venSubTipoMov = @pvenSubTipoMov)
AND Letra = IsNull(@pLetra, Letra)
 
 RETURN @@Error 

GO

DROP PROCEDURE venSTMAfipEliminar
GO
CREATE PROCEDURE venSTMAfipEliminar
(
@pSubTipoMov_Id int,
@pLetra char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venSTMAfip 
WHERE venSubTipoMov = @pSubTipoMov_Id
AND Letra = ISNULL(@pLetra, Letra)
 
 RETURN @@Error 

GO
